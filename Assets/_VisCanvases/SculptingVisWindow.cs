using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using SculptingVis;
using System.IO;

public class SculptingVisWindow : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    SculptingVisWindow window;

    static StyleController GetStyleController()
    {
        return (StyleController)FindObjectOfType(typeof(StyleController));
    }
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/SculptingVis")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        SculptingVisWindow window = (SculptingVisWindow)EditorWindow.GetWindow(typeof(SculptingVisWindow));
        window.Show();
        window.scrollView = new Vector2[7];
    }

    Vector4 CubicSolve(float x_1, float v_1, float x_2, float v_2)
    {
        Vector4 terms = new Vector4();
        terms[0] = 2 * x_1 - 2 * x_2 + v_1 + v_2;
        terms[1] = (v_2 - v_1 - 3 * terms[0]) / 2;
        terms[2] = v_1;
        terms[3] = x_1;
        return terms;
    }

    float CubicEvaluate(Vector4 terms, float t)
    {
        Vector4 powers = new Vector4(t * t * t, t * t, t, 1);
        return Vector4.Dot(terms, powers);
    }

    void DrawWire(Vector2 startPosition, Vector2 endPosition)
    {

    }
    Material mat;

    void DrawWire(Vector2 startPosition, Vector2 startDirection, Vector2 endPosition, Vector2 endDirection)
    {

        if (mat == null)
        {
            var shader = Shader.Find("Hidden/Internal-Colored");
            mat = new Material(shader);
        }

        Vector2 startVector = Vector3.Project(new Vector3(endPosition.x - startPosition.x, endPosition.y - startPosition.y, 0), new Vector3(startDirection.x, startDirection.y, 0));
        Vector2 endVector = -Vector3.Project(new Vector3(startPosition.x - endPosition.x, startPosition.y - endPosition.y, 0), new Vector3(endDirection.x, endDirection.y, 0));

        Vector4 Xterms = CubicSolve(startPosition.x, startVector.x, endPosition.x, endVector.x);
        Vector4 Yterms = CubicSolve(startPosition.y, startVector.y, endPosition.y, endVector.y);

        int steps = 100;
        for (int i = 0; i < steps; i += 1)
        {
            float t_1 = i / (float)steps;
            float t_2 = (i + 1) / (float)steps;

            Vector2 p_1 = new Vector2(CubicEvaluate(Xterms, t_1), CubicEvaluate(Yterms, t_1));
            Vector2 p_2 = new Vector2(CubicEvaluate(Xterms, t_2), CubicEvaluate(Yterms, t_2));

            GL.PushMatrix();
            //GL.Clear(true, false, Color.black);
            mat.SetPass(0);

            GL.Begin(GL.LINES);
            GL.Color(Color.black);

            GL.Vertex3(p_1.x, p_1.y, 0);
            GL.Vertex3(p_2.x, p_2.y, 0);
            GL.End();
            GL.PopMatrix();

        }
    }

    Vector2 mousePos;
    Vector2 boxPosition;
    Vector2[] scrollView;
    bool showPosition = false;


    Dictionary<string, Vector2> _scrollPositions;
    struct SocketHook
    {
        Rect _screenLocation;
        int _instanceID;
    }
    Dictionary<string, Rect> _socketHooks;
    Dictionary<string, StyleSocket> _sockets;

    Vector2Int activeLink;

    StyleSocket activeSource = null;
    void DrawStyleModule(StyleModule module, Rect nest)
    {
        int socket_index = 0;
        bool labelOutputHook = false;
        bool labelOutputHookLeft = false;
        bool labelOutputHookRight = false;
        if (module.GetNumberOfSockets() > 0 && module.GetSocket(0).IsOutput())
        {
            labelOutputHook = true;
            StyleSocket socket = module.GetSocket(0);
            // Temporary inspection to see which column it's in, and which it's going to
            if (module is StyleVisualElement)
            {
                if (socket.GetOutput() is VisualElement)
                    labelOutputHookRight = true;
            }
            else if (module is StyleDataVariable && socket.GetOutput() is Variable)
                labelOutputHookLeft = true;
        }

        GUILayout.BeginVertical("box");
        GUILayout.BeginHorizontal();


        if (labelOutputHookLeft)
        {
            if (labelOutputHook) DrawSocketHook(module.GetSocket(socket_index++), nest);

        }

        if (labelOutputHookRight) {
            
            if(GUILayout.Button("-",EditorStyles.miniButton,GUILayout.MaxWidth(20))) {
                GetStyleController().RemoveModule(module);
            }
        } 

        // Draw Module Label
        GUILayout.Label(module.GetLabel(),GUILayout.MaxWidth(200));


        // End Draw Module label
        if(!labelOutputHook) GUILayout.FlexibleSpace();

        if (!labelOutputHookRight) {
            if(labelOutputHook)            GUILayout.FlexibleSpace();

            if(GUILayout.Button("-",EditorStyles.miniButton,GUILayout.MaxWidth(20))) {
                GetStyleController().RemoveModule(module);
            }
        } 

        if(module is StyleVisualElement) {
            if(true) {
                GUILayout.FlexibleSpace();
                Texture t = ((StyleVisualElement)module).GetVisualElement().GetPreviewImage();
                float aspectRatio = ((StyleVisualElement)module).GetVisualElement().GetPreviewImageAspectRatio();
                Rect r = GUILayoutUtility.GetRect(150,150/aspectRatio);

                GUI.DrawTexture(r,t,ScaleMode.ScaleToFit,true,aspectRatio);

            }


        }


        if (labelOutputHookRight)
        {
            if (labelOutputHook) DrawSocketHook(module.GetSocket(socket_index++), nest);
        }

        GUILayout.EndHorizontal();



        for (; socket_index < module.GetNumberOfSockets(); socket_index++)
        {
            StyleSocket socket = module.GetSocket(socket_index);
            bool inputHookLeft = false;
            bool inputHookRight = false;
            if (module is StyleLayer && socket is StyleTypeSocket)
                inputHookLeft = true;
            else if (module is StyleLayer && socket is VariableSocket)
                inputHookRight = true;

            EditorGUILayout.BeginHorizontal();
            if (inputHookLeft)
                DrawSocketHook(socket, nest);
            else
                GUILayoutUtility.GetRect(new GUIContent(""), socket.IsOutput() ? EditorStyles.radioButton : EditorStyles.miniButton);

            GUILayout.Label(socket.GetLabel());
            if(socket is StyleTypeSocket<IntRange>) {
                ((IntRange)socket.GetInput()).value = EditorGUILayout.IntSlider(((IntRange)socket.GetInput()).value,((IntRange)socket.GetInput()).lowerBound,((IntRange)socket.GetInput()).upperBound);
            }
            GUILayout.FlexibleSpace();
            if (inputHookRight)
                DrawSocketHook(socket, nest);
            else
                GUILayoutUtility.GetRect(new GUIContent(""), socket.IsOutput() ? EditorStyles.radioButton : EditorStyles.miniButton);

            EditorGUILayout.EndHorizontal();
            //GUILayout.FlexibleSpace();


        }
        GUILayout.EndVertical();
    }

    void DrawSocketHook(StyleSocket socket, Rect nest)
    {
        if (socket != null)
        {
            bool disabled = false;
            if (activeSource != null && !socket.DoesAccept(activeSource))
                disabled = true;

            EditorGUI.BeginDisabledGroup(disabled);
            //GUILayout.Label(socket.GetUniqueIdentifier());
            GUILayout.Box("", socket.IsOutput() ? EditorStyles.radioButton : EditorStyles.miniButton);
            EditorGUI.EndDisabledGroup();
            if (Event.current.type == EventType.Repaint)
            {
                Rect hook = GUILayoutUtility.GetLastRect();
                hook.position += nest.position;
                _socketHooks[socket.GetUniqueIdentifier()] = hook;
                _sockets[socket.GetUniqueIdentifier()] = socket;
            }

            //Debug.Log("_socketHooks[" + module.GetSockets()[i] + "] = " + hook);
        }

    }
    Rect[] _columns;
    bool showVisualElementLoader = false;
    bool showCanvasManager = false;
    bool showDataLoader = false;


    public enum OPTIONS
{
    CUBE = 0,
    SPHERE = 1,
    PLANE = 2
}
    public OPTIONS op;

    void OnGUI()
    {
        if(GetStyleController() == null) {
            GUILayout.Label("There is no StyleController object in this scene.");
            return;
        }
            
        if (_columns == null) _columns = new Rect[7];



        if (_scrollPositions == null) _scrollPositions = new Dictionary<string, Vector2>();
        if (_socketHooks == null) _socketHooks = new Dictionary<string, Rect>();
        if (_sockets == null) _sockets = new Dictionary<string, StyleSocket>();


        if (Event.current.type == EventType.Repaint)
        {
            _socketHooks.Clear();
            _sockets.Clear();
        }



        //if (_socketLinks == null) _socketLinks = new List<Vector2Int>();

        Rect[] columns = new Rect[7];
        EditorGUILayout.BeginVertical();
        if (GUILayout.Button("Reset"))
        {
            _socketHooks.Clear();
            _sockets.Clear();
            GetStyleController().Reset();
        }
        //Rect workspace = GUILayoutUtility.GetRect(0,10000,0,10000);
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical(GUILayout.MaxWidth(300));
        EditorGUILayout.BeginVertical("box");
        showVisualElementLoader = EditorGUILayout.Foldout(showVisualElementLoader, "Load Visual Elements");
        if (showVisualElementLoader)
        {

            if (GUILayout.Button("Load Folder"))
            {
                string path = EditorUtility.OpenFolderPanel("Select Folder containing glyphs or colormaps", Application.streamingAssetsPath + "/Images/colormaps", "");
                if (path.Length != 0)
                {
                    GetStyleController().LoadVisualElements(path);
                }
            }
            if (GUILayout.Button("Load Files"))
            {
                string path = EditorUtility.OpenFilePanel("Select Visual Element", Application.streamingAssetsPath + "/Images/colormaps","");
                if (path.Length != 0)
                {
                    GetStyleController().LoadVisualElements(path);
                }
            }


        }

        EditorGUILayout.EndVertical();


        columns[0] = GUILayoutUtility.GetRect(new GUIContent(""),GUIStyle.none,GUILayout.ExpandHeight(true));
        EditorGUILayout.EndVertical();

        GUILayoutUtility.GetRect(0, 50, 0, position.height); //GUILayout.FlexibleSpace();






        EditorGUILayout.BeginVertical(GUILayout.MaxWidth(300));
        EditorGUILayout.BeginVertical("box");
        showCanvasManager = EditorGUILayout.Foldout(showCanvasManager, "Manage Canvases");
        if (showCanvasManager)
        {

            for(int c = 0; c < GetStyleController().GetCanvases().Count; c++) {
                SculptingVis.Canvas canvas = GetStyleController().GetCanvases()[c];
                GUILayout.BeginHorizontal();
                if(GUILayout.Button("Select")) {
                    
                }
                canvas.FitStyle(GUILayout.Toggle(canvas.IsFitting(),"Fit"));
                    
                
                GUILayout.FlexibleSpace();
                if(GUILayout.Button("-",EditorStyles.miniButton,GUILayout.MaxWidth(20))) {
                    GetStyleController().RemoveCanvas(canvas);
                }
                GUILayout.EndHorizontal();
            }
           
            if (GUILayout.Button("Add Canvas"))
            {
                GetStyleController().AddCanvas();
            }
           

        }

        EditorGUILayout.EndVertical();

    
        columns[2] = GUILayoutUtility.GetRect(100, 300, 0, position.height);
        EditorGUILayout.EndVertical();
        // if (!_scrollPositions.ContainsKey("Layers")) _scrollPositions["Layers"] = new Vector2(0, 0);
        // _scrollPositions["Layers"] = EditorGUILayout.BeginScrollView(_scrollPositions["Layers"],false,true,GUILayout.MaxWidth(200));


        // GUILayout.Label("Hello");

        // EditorGUILayout.EndScrollView();

        GUILayoutUtility.GetRect(0, 50, 0, position.height); //GUILayout.FlexibleSpace();




        EditorGUILayout.BeginVertical(GUILayout.MaxWidth(300));
        EditorGUILayout.BeginVertical("box");
        showDataLoader = EditorGUILayout.Foldout(showDataLoader, "Load Data");
        if (showDataLoader)
        {

            // if (GUILayout.Button("Load Folder"))
            // {
            //     string path = EditorUtility.OpenFolderPanel("Select Folder containing glyphs or colormaps", "", "");
            //     if (path.Length != 0)
            //     {
            //         GetStyleController().LoadVisualElements(path);
            //     }
            // }
            if (GUILayout.Button("Load File"))
            {
                string path = EditorUtility.OpenFilePanel("Select VTK file", Application.streamingAssetsPath + "/example_data/VTK/","");
                if (path.Length != 0)
                {
                    GetStyleController().LoadData(path);
                }
            }

        }

        EditorGUILayout.EndVertical();

        columns[4] = GUILayoutUtility.GetRect(100, 300, 0, position.height);
        EditorGUILayout.EndVertical();

        // GUILayoutUtility.GetRect(0, 50, 0, position.height); //GUILayout.FlexibleSpace();


        // columns[6] = GUILayoutUtility.GetRect(100, 300, 0, position.height);



        if (Event.current.type == EventType.Repaint)
            for (int i = 0; i < 7; i++)
            {
                _columns[i] = columns[i];
            }

        for (int i = 0; i < columns.Length; i++)
        {

            //columns[i] = new Rect(new Vector2(i * position.width / 7, workspace.y), new Vector2(position.width / 7, workspace.height));
        }


        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();



        for (int i = 0; i < _columns.Length; i++)
        {
            if (i % 2 == 1) continue;

            if (i == 0)
            {



                GUILayout.BeginArea(_columns[i]);

                if (!_scrollPositions.ContainsKey("VisualElements")) _scrollPositions["VisualElements"] = new Vector2(0, 0);
                _scrollPositions["VisualElements"] = EditorGUILayout.BeginScrollView(_scrollPositions["VisualElements"]);


                Rect scrollView = _columns[0];
                scrollView.position -= _scrollPositions["VisualElements"];


                for (int m = 0; m < GetStyleController().GetVisualElements().Count; m++)
                {
                    // Rect scrollRect = columns[i];
                    // scrollRect.position -= _scrollPositions["VisualElements"];
                    DrawStyleModule(GetStyleController().GetVisualElements()[m], scrollView);
                }



                EditorGUILayout.EndScrollView();
                GUILayout.EndArea();

            }


            if (i == 2)
            {

                GUILayout.BeginArea(_columns[i]);
                if (!_scrollPositions.ContainsKey("Layers")) _scrollPositions["Layers"] = new Vector2(0, 0);
                _scrollPositions["Layers"] = GUILayout.BeginScrollView(_scrollPositions["Layers"]);


                for (int m = 0; m < GetStyleController().GetLayers().Count; m++)
                {
                    Rect scrollRect = _columns[i];
                    scrollRect.position -= _scrollPositions["Layers"];
                    DrawStyleModule(GetStyleController().GetLayers()[m], scrollRect);
                }

                

                EditorGUILayout.BeginHorizontal();

                GUILayout.Label("Create layer: ");
                string [] l = GetStyleController().GetLayerTypes();
                int selected = GetStyleController().GetLayerTypeToCreate();
                GetStyleController().SetLayerTypeToCreate(EditorGUILayout.Popup(selected,l));

                if(GUILayout.Button("+",EditorStyles.miniButton, GUILayout.MaxWidth(20)))
                    GetStyleController().CreateLayer();

                EditorGUILayout.EndHorizontal();
                
                GUILayout.EndScrollView();
                GUILayout.EndArea();

            }


            if (i == 4)
            {

                GUILayout.BeginArea(_columns[i]);
                if (!_scrollPositions.ContainsKey("Variables")) _scrollPositions["Variables"] = new Vector2(0, 0);
                _scrollPositions["Variables"] = GUILayout.BeginScrollView(_scrollPositions["Variables"]);


                for (int m = 0; m < GetStyleController().GetVariables().Count; m++)
                {
                    Rect scrollRect = _columns[i];
                    scrollRect.position -= _scrollPositions["Variables"];
                    DrawStyleModule(GetStyleController().GetVariables()[m], scrollRect);
                }
                GUILayout.EndScrollView();
                GUILayout.EndArea();

            }
        }
        //GUILayout.EndArea();


        Event evt = Event.current;
        bool isDragging = false;
        Vector2 mousePos = Vector2.zero;

        switch (evt.type)
        {
            case EventType.MouseMove:
                activeSource = null;
                break;

            case EventType.MouseDown:


                foreach (string socket in _socketHooks.Keys)
                {
                    if (_socketHooks[socket].Contains(evt.mousePosition) && _sockets[socket].IsOutput())
                    {
                        activeSource = _sockets[socket];
                        break;
                    }


                    if (_socketHooks[socket].Contains(evt.mousePosition) && _sockets[socket].IsInput())
                    {
                        GetStyleController().ClearSocket(_sockets[socket]);
                        break;
                    }
                }

                break;
            case EventType.MouseDrag:
                if (activeSource != null)
                {

                    isDragging = true;
                    mousePos = evt.mousePosition;
                }
                break;
            case EventType.MouseUp:
                if (activeSource != null)
                {
                    foreach (string socket in _socketHooks.Keys)
                    {
                        if (_socketHooks[socket].Contains(evt.mousePosition))
                        {
                            StyleSocket receiving = _sockets[socket];
                            if (receiving.DoesAccept(activeSource))
                            {
                                StyleLink link = new StyleLink();
                                link.SetSource(activeSource);
                                link.SetDestination(_sockets[socket]);
                                GetStyleController().AddLink(link);
                            }
                            activeSource = null;
                            break;
                        }
                    }

                }
                    activeSource = null;

                break;

        }



        Repaint();


        for (int i = 0; i < GetStyleController().GetLinks().Count; i++)
        {
            StyleLink link = GetStyleController().GetLinks()[i];
            if (_socketHooks.ContainsKey(link.GetSource().GetUniqueIdentifier()) && _socketHooks.ContainsKey(link.GetDestination().GetUniqueIdentifier()))
                DrawWire(_socketHooks[link.GetSource().GetUniqueIdentifier()].center, Vector2.right, _socketHooks[link.GetDestination().GetUniqueIdentifier()].center, Vector2.left);

        }

        if (activeSource != null)
        {
            if (_socketHooks.ContainsKey(activeSource.GetUniqueIdentifier()))
                DrawWire(_socketHooks[activeSource.GetUniqueIdentifier()].center, Vector2.right, evt.mousePosition, Vector2.left);

        }
    }
}