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
		VTKDataset vtkds = new VTKDataset();
		vtkds.SetDatasetPath("/example_data/VTK/contour.vtp");
		vtkds.LoadDataset();

		vtkds.Print();
		Dataset ds = vtkds;

		

	}
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
