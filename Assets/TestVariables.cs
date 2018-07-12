using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VisBySculpting;
using UnityEditor;

[CustomEditor(typeof(TestVariables))]
public class TestVariablesrEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        TestVariables myScript = (TestVariables)target;
        if(GUILayout.Button("Test"))
        {
            myScript.Test();
        }
    }
}

public class TestVariables : MonoBehaviour {

	public void Test() {
		VTKDataset vtkds = VTKDataset.CreateInstance<VTKDataset>();
		vtkds.Init("/example_data/VTK/contour.vtp",0,0);
		
		vtkds.LoadDataset();
	

		Dataset ds = vtkds;


		Variable[] ancs = ds.GetAnchors();	
		foreach(Variable a in ancs ) {
			print(a.ToString());
		}


		Variable[] vars = ds.GetVariables();	

		foreach(Variable dv in vars ) {
			print(dv.ToString());
		}

	}
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
