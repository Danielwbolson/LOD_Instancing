using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class VTKContour : Filter {
	public VTKData vtkData;
	public float isovalue = 0.001f;

	private IntPtr NULL = IntPtr.Zero;

	[DllImport("vtkplugin")] unsafe private static extern int contour (void *d, float v, int *np, float **p, float **n, int *nt, int **t);
	[DllImport("vtkplugin")] unsafe private static extern void free_data (void* h);

	// Use this for initialization
//	void Start () {
//		print ("starting");
//		isovalue = 0.001f;
//		vtkContour ();
//
//
//	}

//	// Update is called once per frame
//	void Update () {
//
//	}

	public void SetIsoValue(float f)
	{
		isovalue = f;
		vtkContour ();
	}

	public override void RefreshFilter() {
		//print ("OVERRIDE");
		//vtkContour ();

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
			//print (np);
			int maxPointCount = 65535;
			np = Math.Min (np, maxPointCount);
			List<int> triangles = new List<int>();
			Vector3[] vertices = new Vector3[maxPointCount];
			Vector3[] normals = new Vector3[maxPointCount];

			int pointCount = Math.Min (maxPointCount, np);
			for (int i = 0; i < pointCount; i++) {
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
			for (int i = 0; i < nt; i++) {
				int i1 = t [i*3+0];
				int i2 = t [i*3+1];
				int i3 = t [i * 3 + 2];
				if (i3 >= maxPointCount || i2 >= maxPointCount || i1 >= maxPointCount) {
					continue;

				}
				triangles.Add(i1);
				triangles.Add(i2);
				triangles.Add(i3);

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
			mesh.triangles = triangles.ToArray();
			mesh.normals = normals;
			mesh.RecalculateNormals ();
			//
			//print ("YY " + isovalue + " " + np + " " + nt );
		} //else
			//print ("not!");
	}
}
