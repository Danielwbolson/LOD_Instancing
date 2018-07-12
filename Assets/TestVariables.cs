using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SculptingVis;
using UnityEditor;

[CustomEditor(typeof(TestVariables))]
public class TestVariablesrEditor : Editor
{
	 Material mat;
	 Dictionary<string,int> _linkedVars;

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
        if(GUILayout.Button("Test"))
        {
            myScript.Test();

        }
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();

			LayerList();
			//DropAreaGUI();
			EditorGUILayout.Space ();
        	VariableList ();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal("box");
		GUILayout.Label("ColorMap1");
		GUILayout.Label("ColorMap2");
		GUILayout.Label("ColorMap3");

		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
    }


	public void VariableList() {
		GUILayout.BeginVertical("box",GUILayout.MaxWidth(100));
		for(int i = 0; i < myScript._variables.Count; i++) {
			GUILayout.BeginHorizontal("box");
			GUILayout.Label("•",GUILayout.MaxWidth(10));
			Rect hook = GUILayoutUtility.GetLastRect();
			if(hook.x > 5)
				_varHooks[i] = hook;
        	Event evt = Event.current;

			switch (evt.type) {
        		case EventType.MouseDown:
					if (!hook.Contains (evt.mousePosition)) break;
					DragAndDrop.PrepareStartDrag();
					DragAndDrop.StartDrag("hook");
					DragAndDrop.SetGenericData("int",i);

					break;
        		
        	}



			GUILayout.Label(myScript._variables[i].ToString());
			GUILayout.EndHorizontal();
		}	
		GUILayout.EndVertical();
	}
	public void LayerList() {
		GUILayout.BeginVertical("box", GUILayout.MaxWidth(150));
		for(int i = 0; i < myScript._layers.Count; i++) {
			GUILayout.BeginVertical("box");
			GUILayout.Label(myScript._layers[i].GetType().ToString());
			
			if(myScript._layers[i] is SimplePathLayer) {
				SimplePathLayer pathLayer = (SimplePathLayer)myScript._layers[i];
				GUILayout.BeginHorizontal("box");

				if(pathLayer._anchorVariable == null) {
					GUILayout.Label("Anchor" + "["+"]");
				} else {
					GUILayout.Label("Anchor" + "["+ pathLayer._anchorVariable.GetName()+"]");
				


				}
				GUILayout.Label("•",GUILayout.MaxWidth(10));
				Rect hook = GUILayoutUtility.GetLastRect();

				Event evt = Event.current;
				switch (evt.type) {
				case EventType.DragUpdated:
				case EventType.DragPerform:
					if (!hook.Contains (evt.mousePosition))
						break;
					
					DragAndDrop.visualMode = DragAndDropVisualMode.Link;
				
					if (evt.type == EventType.DragPerform) {
						DragAndDrop.AcceptDrag ();
						int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());
						_linkedVars["anchor"] = var; 
						pathLayer._anchorVariable = (DataVariable)myScript._variables[var];
					}



					break;
				}

				if(pathLayer._anchorVariable != null) {
					if(_linkedVars.ContainsKey("anchor") ) {
						Rect A = _varHooks[_linkedVars["anchor"]];
						GL.PushMatrix();
						//GL.Clear(true, false, Color.black);
						mat.SetPass(0);
						
						GL.Begin(GL.LINES);
						GL.Color(Color.black);


						GL.Vertex3(A.center.x, A.center.y, 0);
						GL.Vertex3(hook.center.x, hook.center.y, 0);
						GL.End();
						GL.PopMatrix();

					}

				}
				GUILayout.EndHorizontal();



				
				
				GUILayout.BeginHorizontal("box");

				if(pathLayer._colorVariable == null) {
					GUILayout.Label("Color" + "["+"]");
				} else {
					GUILayout.Label("Color" + "["+ pathLayer._colorVariable.GetName()+"]");
				}
				
				GUILayout.Label("•",GUILayout.MaxWidth(10));
				hook = GUILayoutUtility.GetLastRect();
				evt = Event.current;
				switch (evt.type) {
				case EventType.DragUpdated:
				case EventType.DragPerform:
					if (!hook.Contains (evt.mousePosition))
						break;
					
					DragAndDrop.visualMode = DragAndDropVisualMode.Link;
				
					if (evt.type == EventType.DragPerform) {
						DragAndDrop.AcceptDrag ();
						int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());
						_linkedVars["color"] = var; 
						pathLayer._colorVariable = (DataVariable)myScript._variables[var];					
					}



					break;
				}

				if(pathLayer._colorVariable != null && _linkedVars.ContainsKey("color")) {
					Rect A = _varHooks[_linkedVars["color"]];

					GL.PushMatrix();
					//GL.Clear(true, false, Color.black);
					mat.SetPass(0);
					
					GL.Begin(GL.LINES);
					GL.Color(Color.black);

					GL.Vertex3(A.center.x, A.center.y, 0);
					GL.Vertex3(hook.center.x, hook.center.y, 0);
					GL.End();
					GL.PopMatrix();

				}

				GUILayout.EndHorizontal();


			}
		
			GUILayout.EndVertical();
		}
		GUILayout.EndVertical();
	}

	 public void DropAreaGUI ()
    {
        Event evt = Event.current;
        Rect drop_area = GUILayoutUtility.GetRect (0.0f, 50.0f, GUILayout.ExpandWidth (true));
        GUI.Box (drop_area, "Add Trigger");
     
        switch (evt.type) {
        case EventType.DragUpdated:
        case EventType.DragPerform:
            if (!drop_area.Contains (evt.mousePosition))
                return;
             
            DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
         
            if (evt.type == EventType.DragPerform) {
                DragAndDrop.AcceptDrag ();

            }
            break;
        }
    }

}

public class TestVariables : MonoBehaviour {

	[SerializeField]
	SimplePathLayer _pathLayer;

	[SerializeField]
	string fileToImport;


	[SerializeField]
	public List<Variable> _variables;

	[SerializeField]
	public List<Layer> _layers;

	public void Test() {
		_layers.Add(_pathLayer);

		VTKDataset vtkds = VTKDataset.CreateInstance<VTKDataset>();
		vtkds.Init("example_data/VTK/local/brain.vtp",0,0);
		
		vtkds.LoadDataset();
	

		Dataset ds1 = vtkds;
		Variable[] ancs = ds1.GetAnchors();
			
		foreach(Variable a in ds1.GetAnchors())
			_variables.Add(a);

		foreach(Variable a in ds1.GetVariables())
			_variables.Add(a);


		//_pathLayer._anchorVariable = (ds1.GetAnchors()[0]);


		VTKDataset vtkds2 = VTKDataset.CreateInstance<VTKDataset>();
		vtkds2.Init("example_data/VTK/local/brain.vti",0,0);
		
		vtkds2.LoadDataset();

		print(vtkds2.GetVariables()[4]);
		//_pathLayer._colorVariable = (vtkds2.GetVariables()[4]);

		foreach(Variable a in vtkds2.GetAnchors())
			_variables.Add(a);

		foreach(Variable a in vtkds2.GetVariables())
			_variables.Add(a);


	}
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
