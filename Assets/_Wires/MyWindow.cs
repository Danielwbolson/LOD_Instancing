using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using SculptingVis;

public class MyWindow : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    MyWindow window;

    static StyleController GetStyleController()
    {
        return (StyleController)FindObjectOfType(typeof(StyleController));
    }
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/My Window")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        MyWindow window = (MyWindow)EditorWindow.GetWindow(typeof(MyWindow));
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
        for (int i = 0; i < steps; i += 2)
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
        GUILayout.BeginVertical("box");
        GUILayout.Label(module.GetLabel());
        for (int i = 0; i < module.GetNumberOfSockets(); i++)
        {

            GUILayout.Box(module.GetSocket(i).GetLabel(),GUILayout.ExpandWidth(true));
                     if (Event.current.type == EventType.Repaint)
 {

            Rect hook = GUILayoutUtility.GetLastRect();
            hook.position += nest.position;
            if(module.GetSocket(i)!= null)
            _socketHooks[module.GetSocket(i).GetUniqueIdentifier()] = hook;
            _sockets[module.GetSocket(i).GetUniqueIdentifier()] = module.GetSocket(i);

            //Debug.Log("_socketHooks[" + module.GetSockets()[i] + "] = " + hook);
 }


        }
        GUILayout.EndVertical();
    }

    Rect [] _columns;
    void OnGUI()
    {
        
        if(_columns == null) _columns = new Rect[7];



        if (_scrollPositions == null) _scrollPositions = new Dictionary<string, Vector2>();
        if (_socketHooks == null) _socketHooks = new Dictionary<string, Rect>();
        if (_sockets == null) _sockets = new Dictionary<string, StyleSocket>();

        //if (_socketLinks == null) _socketLinks = new List<Vector2Int>();

        Rect[] columns = new Rect[7];
        EditorGUILayout.BeginVertical();
        if(GUILayout.Button("Reset")) {
            _socketHooks.Clear();
            _sockets.Clear();
            GetStyleController().Reset();
        }
        //Rect workspace = GUILayoutUtility.GetRect(0,10000,0,10000);
        EditorGUILayout.BeginHorizontal();

        columns[0] = GUILayoutUtility.GetRect(100,200,0,position.height);
      

                GUILayoutUtility.GetRect(0,50,0,position.height); //GUILayout.FlexibleSpace();


        columns[2] = GUILayoutUtility.GetRect(100,200,0,position.height);

        // if (!_scrollPositions.ContainsKey("Layers")) _scrollPositions["Layers"] = new Vector2(0, 0);
        // _scrollPositions["Layers"] = EditorGUILayout.BeginScrollView(_scrollPositions["Layers"],false,true,GUILayout.MaxWidth(200));


        // GUILayout.Label("Hello");

        // EditorGUILayout.EndScrollView();

                GUILayoutUtility.GetRect(0,50,0,position.height); //GUILayout.FlexibleSpace();


        columns[4] = GUILayoutUtility.GetRect(100,200,0,position.height);

        // if (!_scrollPositions.ContainsKey("Variables")) _scrollPositions["Variables"] = new Vector2(0, 0);
        // _scrollPositions["Variables"] = EditorGUILayout.BeginScrollView(_scrollPositions["Variables"],false,true,GUILayout.MaxWidth(200));


        // GUILayout.Label("Hello");


        // EditorGUILayout.EndScrollView();

                GUILayoutUtility.GetRect(0,50,0,position.height); //GUILayout.FlexibleSpace();


        columns[6] = GUILayoutUtility.GetRect(100,200,0,position.height);


        // if (!_scrollPositions.ContainsKey("VariableTransforms")) _scrollPositions["VariableTransforms"] = new Vector2(0, 0);
        // _scrollPositions["VariableTransforms"] = EditorGUILayout.BeginScrollView(_scrollPositions["VariableTransforms"],false,true,GUILayout.MaxWidth(200));


        // GUILayout.Label("Hello");


        // EditorGUILayout.EndScrollView();


         if (Event.current.type == EventType.Repaint)
            for(int i = 0; i < 7; i ++) {
               _columns[i] = columns[i] ;
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
                _scrollPositions["VisualElements"] = EditorGUILayout.BeginScrollView(_scrollPositions["VisualElements"],false,true);


            Rect scrollView = _columns[0];
            scrollView.position -= _scrollPositions["VisualElements"];



                // GUILayout.BeginVertical("box");
                // showPosition = EditorGUILayout.Foldout(showPosition,"Testing");

                // if(showPosition) {
                //     for(int l = 0; l < 10; l++)
                //         GUILayout.Label("" +l);
                // }

                // GUILayout.EndVertical();

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
                GUILayout.EndScrollView();
                GUILayout.EndArea();

            }
        } 
        //GUILayout.EndArea();


        Event evt = Event.current;

        switch (evt.type)
        {
            case EventType.MouseDown:


                foreach (string socket in _socketHooks.Keys)
                {
                    if (_socketHooks[socket].Contains(evt.mousePosition))
                    {
                        activeSource = _sockets[socket];
                        break;
                    }
                }

                break;
            case EventType.MouseUp:
                if (activeSource != null)
                {
                    foreach (string socket in _socketHooks.Keys)
                    {
                        if (_socketHooks[socket].Contains(evt.mousePosition))
                        {
                            StyleLink link = new StyleLink();
                            link.SetSource(activeSource);
                            link.SetDestination(_sockets[socket]);
                            GetStyleController().AddLink(link);
                            break;
                        }
                    }
                    activeLink = new Vector2Int(0, 0);

                }

                break;

        }



        Repaint();
        for(int i = 0; i < GetStyleController().GetLinks().Count; i++) {
            StyleLink link = GetStyleController().GetLinks()[i];
            if(_socketHooks.ContainsKey(link.GetSource().GetUniqueIdentifier()) && _socketHooks.ContainsKey(link.GetDestination().GetUniqueIdentifier()))
            DrawWire(_socketHooks[link.GetSource().GetUniqueIdentifier()].center,Vector2.right, _socketHooks[link.GetDestination().GetUniqueIdentifier()].center,Vector2.left);

        }
    }
}