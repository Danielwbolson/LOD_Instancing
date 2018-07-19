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
			EditorGUILayout.Space ();
			EditorGUILayout.Space ();

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

		AnchorVariable currentAnchor = null;
		
		GUILayout.BeginVertical("box",GUILayout.MaxWidth(100));
		GUILayout.BeginVertical("box",GUILayout.MaxWidth(100));

		for(int i = 0; i < myScript._variables.Count; i++) {
			if(myScript._variables[i] == null) continue;
			Variable variable = myScript._variables[i];
			if(currentAnchor == null && variable.IsAnchor())
				currentAnchor = (AnchorVariable)variable;
			if(!variable.HasAnchor() && !variable.IsAnchor() || (variable.IsAnchor() && variable != currentAnchor) ||(!variable.IsAnchor() && variable.HasAnchor() && variable.GetAnchorVariable() != currentAnchor)){
				if(variable.IsAnchor())
					currentAnchor = (AnchorVariable)variable;
				else
					currentAnchor = (AnchorVariable)variable.GetAnchorVariable();
				GUILayout.EndVertical();
				GUILayout.BeginVertical("box",GUILayout.MaxWidth(100));

			}
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

		GUILayout.EndVertical();
	}
	public void LayerList() {
		GUILayout.BeginVertical("box", GUILayout.MaxWidth(200));
		for(int i = 0; i < myScript._layers.Count; i++) {
			GUILayout.BeginVertical("box");
			GUILayout.Label(myScript._layers[i].GetType().ToString());
			
			if(true) {
				Layer layer = myScript._layers[i];
				for(int s = 0; s < layer.GetSockets().Count; s++) {
					VariableSocket socket = layer.GetSockets()[s];
					GUILayout.BeginHorizontal("box");
					if(!socket.IsAssigned()) {
					GUILayout.Label(socket.GetName() + "["+"]");
					} else {
						GUILayout.Label(socket.GetName() + "["+ socket.GetInput().GetName()+"]");
					


					}


				float lower = 0.25f;
				float upper = 0.75f;
				if(socket.IsAssigned() && socket.GetInput().GetComponents() == 1){
				EditorGUILayout.MinMaxSlider(ref socket.LowerBound,ref socket.UpperBound,socket.GetInput().GetMin().x,socket.GetInput().GetMax().x,GUILayout.Width(100));
				Debug.Log(socket.LowerBound + " - " + socket.UpperBound);
				}else
				EditorGUILayout.LabelField("", GUI.skin.horizontalSlider,GUILayout.Width(100));


				GUILayout.Label("•",GUILayout.MaxWidth(10));
				Rect hook0 = GUILayoutUtility.GetLastRect();

				Event evt0 = Event.current;
				switch (evt0.type) {
				case EventType.DragUpdated:
				case EventType.DragPerform:
					if (!hook0.Contains (evt0.mousePosition))
						break;
					
					DragAndDrop.visualMode = DragAndDropVisualMode.Link;
				
					while (evt0.type == EventType.DragPerform) {
						DragAndDrop.AcceptDrag ();
						int var = int.Parse(DragAndDrop.GetGenericData("int").ToString());
						Variable input = (DataVariable)myScript._variables[var];
						Debug.Log( input.GetComponents());
						if(socket.ScalarRequired() && input.GetComponents() > 1) break;
						if(socket.VectorRequired() && input.GetComponents() == 1) break;
						if(input.HasAnchor() && layer.HasAnchor() && !layer.GetAnchorSocket().IsAssigned()) break;
						if(input.HasAnchor() && layer.HasAnchor() && layer.GetAnchorSocket().IsAssigned() && layer.GetAnchorSocket().GetInput()!=input.GetAnchorVariable()) break;


						_linkedVars[socket.GetName()] = var; 
						socket.SetInputVariable((DataVariable)myScript._variables[var]);
						break;
					}



					break;
				}

				if(socket.IsAssigned()) {
					if(_linkedVars.ContainsKey(socket.GetName()) ) {
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
	SimplePointLayer _pathLayer;

	[SerializeField]
	string fileToImport;


	[SerializeField]
	public List<Variable> _variables;

	[SerializeField]
	public List<Layer> _layers;

	public void Test() {
		_pathLayer.Init();
		_layers.Add(_pathLayer);

		VTKDataset vtkds = VTKDataset.CreateInstance<VTKDataset>();
		vtkds.Init("example_data/VTK/local/brain.vtp",0,0);
		
		vtkds.LoadDataset();
	

		Dataset ds1 = vtkds;
		Variable anc = ds1.GetAnchor();
			
			_variables.Add(anc);

		foreach(Variable a in ds1.GetVariables())
			_variables.Add(a);


		//_pathLayer._anchorVariable = (ds1.GetAnchors()[0]);


		VTKDataset vtkds2 = VTKDataset.CreateInstance<VTKDataset>();
		vtkds2.Init("example_data/VTK/local/brain.vti",0,0);
		
		vtkds2.LoadDataset();

		//print(vtkds2.GetVariables()[4]);
		//_pathLayer._colorVariable = (vtkds2.GetVariables()[4]);

		_variables.Add(vtkds2.GetAnchor());

		foreach(Variable a in vtkds2.GetVariables())
			_variables.Add(a);


		PointDataset pointDataset = PointDataset.CreateInstance<PointDataset>();
		pointDataset.Init(_variables[_variables.Count-1],1000,0,0);
		pointDataset.LoadDataset();
		_variables.Add(pointDataset.GetAnchor());

	}
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
