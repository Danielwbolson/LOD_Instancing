using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SculptingVis;
using UnityEditor;

[CustomEditor(typeof(TestVariables))]
public class TestVariablesrEditor : Editor
{
    Material mat;
    Dictionary<string, int> _linkedVars;

    private void OnEnable()
    {
        _linkedVars = new Dictionary<string, int>();
        var shader = Shader.Find("Hidden/Internal-Colored");
        mat = new Material(shader);
        _varHooks = new Rect[100];
    }
    TestVariables myScript;

    Rect[] _varHooks = null;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        myScript = (TestVariables)target;
        if (GUILayout.Button("Test"))
        {
            myScript.Test();

        }
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();

        GUILayout.BeginVertical();
        DrawColorMapList();
        DrawMeshList();
        GUILayout.EndVertical();
        EditorGUILayout.Space();

        LayerList();
        //DropAreaGUI();
        EditorGUILayout.Space();
        VariableList();
        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

    public void DrawColorMapList()
    {
        GUILayout.BeginVertical("box", GUILayout.MaxWidth(65));

        for (int i = 0; i < myScript._colorMaps.GetColorMaps().Count; i++)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Box(myScript._colorMaps.GetColorMaps()[i], GUILayout.Width(50), GUILayout.Height(20));
            GUILayout.Label("•", GUILayout.MaxWidth(10));

            Rect hook = GUILayoutUtility.GetLastRect();
            // if(hook.x > 5)
            // 	_varHooks[i] = hook;
            Event evt = Event.current;

            switch (evt.type)
            {
                case EventType.MouseDown:
                    if (!hook.Contains(evt.mousePosition)) break;
                    DragAndDrop.PrepareStartDrag();
                    DragAndDrop.StartDrag("colormap");
                    Object[] objs = new Object[1];
                    objs[0] = myScript._colorMaps.GetColorMaps()[i];
                    DragAndDrop.objectReferences = objs;
                    DragAndDrop.SetGenericData("int", i);

                    break;

            }



            GUILayout.EndHorizontal();
        }
        GUILayout.EndVertical();
    }

    public void DrawMeshList()
    {
        GUILayout.BeginVertical("box", GUILayout.MaxWidth(65));

        for (int i = 0; i < myScript._meshes.GetMeshNames().Count; i++)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(myScript._meshes.GetMeshNames()[i]);
            GUILayout.Label("•", GUILayout.MaxWidth(10));

            Rect hook = GUILayoutUtility.GetLastRect();
            // if(hook.x > 5)
            // 	_varHooks[i] = hook;
            Event evt = Event.current;

            switch (evt.type)
            {
                case EventType.MouseDown:
                    if (!hook.Contains(evt.mousePosition)) break;
                    DragAndDrop.PrepareStartDrag();
                    DragAndDrop.StartDrag("mesh");
                    Object[] objs = new Object[1];
                    objs[0] = myScript._meshes.GetMeshes()[i];
                    DragAndDrop.objectReferences = objs;
                    DragAndDrop.SetGenericData("int", i);

                    break;

            }



            GUILayout.EndHorizontal();
        }
        GUILayout.EndVertical();
    }

    public void VariableList()
    {

        AnchorVariable currentAnchor = null;

        GUILayout.BeginVertical("box", GUILayout.MaxWidth(100));
        GUILayout.BeginVertical("box", GUILayout.MaxWidth(100));

        for (int i = 0; i < myScript._variables.Count; i++)
        {
            if (myScript._variables[i] == null) continue;
            Variable variable = myScript._variables[i];
            if (currentAnchor == null && variable.IsAnchor())
                currentAnchor = (AnchorVariable)variable;
            if (!variable.HasAnchor() && !variable.IsAnchor() || (variable.IsAnchor() && variable != currentAnchor) || (!variable.IsAnchor() && variable.HasAnchor() && variable.GetAnchorVariable() != currentAnchor))
            {
                if (variable.IsAnchor())
                    currentAnchor = (AnchorVariable)variable;
                else
                    currentAnchor = (AnchorVariable)variable.GetAnchorVariable();
                GUILayout.EndVertical();
                GUILayout.BeginVertical("box", GUILayout.MaxWidth(100));

            }
            GUILayout.BeginHorizontal("box");
            GUILayout.Label("•", GUILayout.MaxWidth(10));
            Rect hook = GUILayoutUtility.GetLastRect();
            if (hook.x > 5)
                _varHooks[i] = hook;
            Event evt = Event.current;

            switch (evt.type)
            {
                case EventType.MouseDown:
                    if (!hook.Contains(evt.mousePosition)) break;
                    DragAndDrop.PrepareStartDrag();
                    DragAndDrop.StartDrag("hook");
                    DragAndDrop.activeControlID = 0;
                    DragAndDrop.SetGenericData("int", i);
                    Object[] objs = new Object[1];
                    objs[0] = myScript._variables[i];
                    DragAndDrop.objectReferences = objs;
                    break;

            }



            GUILayout.Label(myScript._variables[i].ToString());
            GUILayout.EndHorizontal();
        }
        GUILayout.EndVertical();

        GUILayout.EndVertical();
    }
    public void LayerList()
    {
        GUILayout.BeginVertical("box", GUILayout.MaxWidth(100));
        for (int i = 0; i < myScript._layers.Count; i++)
        {
            GUILayout.BeginVertical("box");
            GUILayout.Label(myScript._layers[i].GetType().ToString());

            if (true)
            {
                Layer layer = myScript._layers[i];



                if (layer is SimplePointLayer)
                {
                    GUILayout.BeginHorizontal();

                    GUILayout.Label("•", GUILayout.MaxWidth(10));
                    Rect hook0 = GUILayoutUtility.GetLastRect();

                    Event evt0 = Event.current;
                    switch (evt0.type)
                    {
                        case EventType.DragUpdated:
                        case EventType.DragPerform:
                            if (!hook0.Contains(evt0.mousePosition))
                                break;

                            DragAndDrop.visualMode = DragAndDropVisualMode.Link;

                            while (evt0.type == EventType.DragPerform)
                            {
                                DragAndDrop.AcceptDrag(); Debug.Log(DragAndDrop.objectReferences[0]);
                                if (!(DragAndDrop.objectReferences[0] is Texture)) break;
                                int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());

                                ((SimplePointLayer)layer)._colorMap = (Texture2D)DragAndDrop.objectReferences[0];
                                break;
                            }



                            break;
                    }

                    GUILayout.Label("Colormap" + (((SimplePointLayer)layer)._colorMap == null ? " []" : " [" + ((SimplePointLayer)layer)._colorMap.name + "]"));

                    GUILayout.EndHorizontal();


                    GUILayout.BeginHorizontal();

                    GUILayout.Label("•", GUILayout.MaxWidth(10));
                    Rect hook1 = GUILayoutUtility.GetLastRect();

                    Event evt1 = Event.current;
                    switch (evt1.type)
                    {
                        case EventType.DragUpdated:
                        case EventType.DragPerform:
                            if (!hook1.Contains(evt1.mousePosition))
                                break;

                            DragAndDrop.visualMode = DragAndDropVisualMode.Link;

                            while (evt1.type == EventType.DragPerform)
                            {
                                DragAndDrop.AcceptDrag(); Debug.Log(DragAndDrop.objectReferences[0]);
                                if (!(DragAndDrop.objectReferences[0] is Mesh)) break;
                                int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());

                                ((SimplePointLayer)layer)._glyphMesh = (Mesh)DragAndDrop.objectReferences[0];
                                break;
                            }



                            break;
                    }

                    GUILayout.Label("Glyph");
                    GUILayout.Label("Glyph" + (((SimplePointLayer)layer)._glyphMesh == null ? " []" : " [" + myScript._meshes.GetMeshNames()[System.Array.IndexOf(myScript._meshes.GetMeshes().ToArray(), ((SimplePointLayer)layer)._glyphMesh)] + "]"));

                    GUILayout.EndHorizontal();


                    GUILayout.BeginHorizontal();
                    GUILayout.Label("Glyph size");
                    float a = ((SimplePointLayer)layer).GlyphScale - 0.001f;
                    EditorGUILayout.MinMaxSlider(ref a, ref ((SimplePointLayer)layer).GlyphScale, 0.1f, 10, GUILayout.ExpandWidth(false));
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    GUILayout.Label("Glyph count");
                    float b = ((SimplePointLayer)layer).instanceCount - 0.001f;
                    float c = ((SimplePointLayer)layer).instanceCount;
                    EditorGUILayout.MinMaxSlider(ref b, ref c, 1, 100000, GUILayout.ExpandWidth(false));
                    ((SimplePointLayer)layer).instanceCount = (int)c;
                    GUILayout.EndHorizontal();

                }





                if (layer is SimplePathLayer)
                {
                    GUILayout.BeginHorizontal();

                    GUILayout.Label("•", GUILayout.MaxWidth(10));
                    Rect hook0 = GUILayoutUtility.GetLastRect();

                    Event evt0 = Event.current;
                    switch (evt0.type)
                    {
                        case EventType.DragUpdated:
                        case EventType.DragPerform:
                            if (!hook0.Contains(evt0.mousePosition))
                                break;

                            DragAndDrop.visualMode = DragAndDropVisualMode.Link;

                            while (evt0.type == EventType.DragPerform)
                            {
                                DragAndDrop.AcceptDrag(); Debug.Log(DragAndDrop.objectReferences[0]);
                                if (!(DragAndDrop.objectReferences[0] is Texture)) break;
                                int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());

                                ((SimplePathLayer)layer)._colorMap = (Texture2D)DragAndDrop.objectReferences[0];
                                break;
                            }



                            break;
                    }

                    GUILayout.Label("Colormap");

                    GUILayout.EndHorizontal();





                    GUILayout.BeginHorizontal();
                    GUILayout.Label("Max Lines");
                    float b = ((SimplePathLayer)layer).LineCount - 0.001f;
                    float c = ((SimplePathLayer)layer).LineCount;
                    EditorGUILayout.MinMaxSlider(ref b, ref c, 1, 10000, GUILayout.ExpandWidth(false));
                    ((SimplePathLayer)layer).LineCount = (int)c;
                    GUILayout.EndHorizontal();


                }




                for (int s = 0; s < layer.GetSockets().Count; s++)
                {
                    VariableSocket socket = layer.GetSockets()[s];
                    GUILayout.BeginHorizontal("box");
                    if (!socket.IsAssigned())
                    {
                        GUILayout.Label(socket.GetName() + "[" + "]");
                    }
                    else
                    {
                        GUILayout.Label(socket.GetName() + "[" + socket.GetInput().GetName() + "]");



                    }


                    float lower = 0.25f;
                    float upper = 0.75f;
                    if (socket.IsAssigned() && socket.GetInput().GetComponents() == 1)
                    {
                        EditorGUILayout.MinMaxSlider(ref socket.LowerBound, ref socket.UpperBound, socket.GetInput().GetMin().x, socket.GetInput().GetMax().x, GUILayout.Width(100));
                        Debug.Log(socket.LowerBound + " - " + socket.UpperBound);
                    }
                    else
                        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider, GUILayout.Width(100));


                    GUILayout.Label("•", GUILayout.MaxWidth(10));
                    Rect hook0 = GUILayoutUtility.GetLastRect();

                    Event evt0 = Event.current;
                    switch (evt0.type)
                    {

                        case EventType.ContextClick:
                            if (!hook0.Contains(evt0.mousePosition))
                                break;
                            socket.SetInputVariable(null);
                            _linkedVars[socket.GetName()] = -1;
                            break;
                        case EventType.DragUpdated:
                        case EventType.DragPerform:
                            if (!hook0.Contains(evt0.mousePosition))
                                break;

                            DragAndDrop.visualMode = DragAndDropVisualMode.Link;

                            while (evt0.type == EventType.DragPerform)
                            {
                                DragAndDrop.AcceptDrag(); Debug.Log(DragAndDrop.objectReferences[0]);
                                if (!(DragAndDrop.objectReferences[0] is Variable)) break;
                                int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());
                                Variable input = (DataVariable)myScript._variables[var];
                                Debug.Log(input.GetComponents());
                                if (socket.ScalarRequired() && input.GetComponents() > 1) break;
                                if (socket.VectorRequired() && input.GetComponents() == 1) break;
                                if (input.HasAnchor() && layer.HasAnchor() && !layer.GetAnchorSocket().IsAssigned()) break;
                                if (input.HasAnchor() && layer.HasAnchor() && layer.GetAnchorSocket().IsAssigned() && layer.GetAnchorSocket().GetInput() != input.GetAnchorVariable()) break;


                                _linkedVars[socket.GetName()] = var;
                                socket.SetInputVariable((DataVariable)myScript._variables[var]);
                                break;
                            }



                            break;
                    }

                    if (socket.IsAssigned())
                    {
                        if (_linkedVars.ContainsKey(socket.GetName()))
                        {
                            Rect A = _varHooks[_linkedVars[socket.GetName()]];
                            GL.PushMatrix();
                            //GL.Clear(true, false, Color.black);
                            mat.SetPass(0);

                            GL.Begin(GL.LINES);
                            GL.Color(Color.black);


                            GL.Vertex3(A.center.x, A.center.y, 0);
                            GL.Vertex3(hook0.center.x, hook0.center.y, 0);
                            GL.End();
                            GL.PopMatrix();

                        }

                    }
                    GUILayout.EndHorizontal();
                }


            }

            GUILayout.EndVertical();
        }
        GUILayout.EndVertical();
    }

    public void DropAreaGUI()
    {
        Event evt = Event.current;
        Rect drop_area = GUILayoutUtility.GetRect(0.0f, 50.0f, GUILayout.ExpandWidth(true));
        GUI.Box(drop_area, "Add Trigger");

        switch (evt.type)
        {
            case EventType.DragUpdated:
            case EventType.DragPerform:
                if (!drop_area.Contains(evt.mousePosition))
                    return;

                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;

                if (evt.type == EventType.DragPerform)
                {
                    DragAndDrop.AcceptDrag();

                }
                break;
        }
    }

}

public class TestVariables : MonoBehaviour
{

    [SerializeField]
    SimplePointLayer _pointLayer;

    [SerializeField]
    SimplePathLayer _pathLayer;

    [SerializeField]
    string fileToImport;


    [SerializeField]
    public List<Variable> _variables;

    [SerializeField]
    public List<Layer> _layers;

    [SerializeField]
    public Style _style;

    [SerializeField]
    public ColorMapSet _colorMaps;

    [SerializeField]
    public MeshSet _meshes;

    public void Test()
    {
        _style.Clear();
        // _pointLayer.Init();
        // _layers.Add(_pointLayer);
        // _style.AddLayer(_pointLayer);
        var l = SimplePathLayer.CreateInstance<SimplePointLayer>();
        l._pointMaterial = Instantiate(_pointLayer._pointMaterial);
        l._glyphMesh = _pointLayer._glyphMesh;
        l.Init();
        _layers.Add(l);
        //_style.AddLayer(l);
        l = SimplePathLayer.CreateInstance<SimplePointLayer>();
        l._pointMaterial = Instantiate(_pointLayer._pointMaterial);
        l._glyphMesh = _pointLayer._glyphMesh;
        l.Init();
        _layers.Add(l);
        //_style.AddLayer(l);



        var l2 = SimplePathLayer.CreateInstance<SimplePathLayer>();
        l2.Init();
        l2._lineMaterial = _pathLayer._lineMaterial;
        _layers.Add(l2);
        //_style.AddLayer(l2);
        VTKDataset vtkds = VTKDataset.CreateInstance<VTKDataset>();
        vtkds.Init(Application.streamingAssetsPath+ "/example_data/VTK/local/brain.vtp", 0, 0);

        vtkds.LoadDataset();


        Dataset ds1 = vtkds;
        Variable anc = ds1.GetAnchor();

        _variables.Add(anc);

        foreach (Variable a in ds1.GetVariables())
            _variables.Add(a);


        //_pointLayer._anchorVariable = (ds1.GetAnchors()[0]);


        VTKDataset vtkds2 = VTKDataset.CreateInstance<VTKDataset>();
        vtkds2.Init(Application.streamingAssetsPath+ "/example_data/VTK/local/brain.vti", 0, 0);

        vtkds2.LoadDataset();

        //print(vtkds2.GetVariables()[4]);
        //_pointLayer._colorVariable = (vtkds2.GetVariables()[4]);

        _variables.Add(vtkds2.GetAnchor());

        foreach (Variable a in vtkds2.GetVariables())
            _variables.Add(a);


        PointDataset pointDataset = PointDataset.CreateInstance<PointDataset>();
        pointDataset.Init(_variables[_variables.Count - 1], 50000, 0, 0);
        pointDataset.LoadDataset();
        _variables.Add(pointDataset.GetAnchor());

    }
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }
}
