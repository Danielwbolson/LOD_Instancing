using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLineRenderer : MonoBehaviour {

	public DataObject dataObject;

	// Use this for initialization
	void Start () {
		
	}
	void OnDrawGizmos() {
		int num_lines = dataObject.data.GetNumberOfLines ();

		for(int i = 0; i< num_lines; i++)
		Gizmos.DrawLine (new Vector3 (i, 0, 0), new Vector3 (i, 1, 0));
	}
	// Update is called once per frame
	void Update () {
		
	}
}
