using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class VTKSampleSet : MonoBehaviour {

	public int sampleCount;
	public VTKData vtkData;
	
	public Vector3[] positions = null;

	public bool is_valid;
	// Use this for initialization
	void Start () {
		//vtkSample ();
		Vector3[] positions = null;
		is_valid = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnDrawGizmos() {
			Gizmos.color = Color.blue;
		if (false) {
			Gizmos.matrix = transform.parent.transform.localToWorldMatrix;

			for(int i = 0; i < sampleCount; i++){
				Gizmos.DrawSphere(positions[i], 0.1f);

			}
		}


	}
	public void setSampleMag (float n){
		if (n == 0)
			setSampleMag (0);
		else
			setSampleCount((float)(Math.Pow(10,n-1)));
	}

	public void setSampleCount (float n){
		sampleCount = (int)(n);
		vtkSample ();
	}
	unsafe public void vtkSample()
	{
		print ("VTK Sample...");
		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();

		print (vtkData);

		if (vtkData.handle != null) 
		{
			UnityEngine.Random.seed = 42;
			positions = new Vector3[sampleCount];
			Vector3 bMin = vtkData.getBoundingCenter () - vtkData.getBoundingSize () / 2;
			Vector3 bMax = vtkData.getBoundingCenter () + vtkData.getBoundingSize () / 2;
			print ("Creating " + sampleCount + " samples");

			for (int i = 0; i < sampleCount; i++) {
				Vector3 randV = new Vector3 (UnityEngine.Random.Range (bMin.x, bMax.x), UnityEngine.Random.Range (bMin.y, bMax.y), UnityEngine.Random.Range (bMin.z, bMax.z));
				positions [i] = randV;

			}
			is_valid = true;
		}
		transform.GetChild (0).gameObject.GetComponent<VTKGlyphField> ().setSampleCount (sampleCount);
	}
}
