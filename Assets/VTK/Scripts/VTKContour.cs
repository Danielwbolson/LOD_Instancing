using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using NUnit.Framework;

public class VTKContour : MonoBehaviour {
	public VTKData vtkData;
	public float isovalue;

	private IntPtr NULL = IntPtr.Zero;

	[DllImport("vtkplugin")] unsafe private static extern int contour (void *d, float v, int *np, float **p, float **n, int *nt, int **t);
	[DllImport("vtkplugin")] unsafe private static extern void free_data (void* h);

	// Use this for initialization
	void Start () {
		print ("starting");
		isovalue = 0.6f;
		vtkContour ();


	}

	// Update is called once per frame
	void Update () {

	}

	public void SetIsoValue(float f)
	{
		isovalue = f;
		vtkContour ();
	}


	unsafe public void vtkContour()
	{
		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();
		if (vtkData.handle != null) 
		{

			int np = 0;
			int nt = 0;
			float* p = null;
			float* n = null;
			int *t = null;

			contour ((void*)vtkData.handle, isovalue, &np, &p, &n, &nt, &t);

			int[] triangles = new int[nt*3];
			Vector3[] vertices = new Vector3[np];
			Vector3[] normals = new Vector3[np];

			for (int i = 0; i < np; i++) {
				float n1 = (float)n [i * 3 + 0];
				float n2 = (float)n [i * 3 + 1];
				float n3 = (float)n [i * 3 + 2];

				float v1 = (float)p [i * 3 + 0];
				float v2 = (float)p [i * 3 + 1];
				float v3 = (float)p [i * 3 + 2];

				vertices [i].x = v1;
				vertices [i].y = v2;
				vertices [i].z = v3;

				normals [i].x = n1;
				normals [i].y = n2;
				normals [i].z = n3;

			}

			int num_t = nt*3;
			for (int i = 0; i < num_t; i++) {
				triangles [i] = t [i];
			}

			free_data ((void*)p);
			free_data ((void*)n);
			free_data ((void*)t);
			p = null;
			n = null;
			t = null;
			Mesh mesh = new Mesh ();
			GetComponent<MeshFilter> ().mesh = mesh;
			mesh.vertices = vertices;
			mesh.triangles = triangles;
			mesh.normals = normals;
			mesh.RecalculateNormals ();
			//
			//print ("YY " + isovalue + " " + np + " " + nt );
		} //else
			//print ("not!");
	}
}
