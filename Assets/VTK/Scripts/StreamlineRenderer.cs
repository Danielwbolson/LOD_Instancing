using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;

public class StreamlineRenderer : Filter {
	public VTKData vtkData;
	public float isovalue = 0.001f;

	private IntPtr NULL = IntPtr.Zero;

	[DllImport("vtkplugin")] unsafe private static extern int contour (void *d, float v, int *np, float **p, float **n, int *nt, int **t);
	[DllImport("vtkplugin")] unsafe private static extern void free_data (void* h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(void *h, StringBuilder array_name, float **values, int *number_of_elements, int *number_of_components);


	public override void RefreshFilter() {
		vtkContour ();
		print ("AAAAAAAAHHHHHHH!!!!!");


	}
	unsafe public void vtkContour()
	{

		print ("AAAAAAAAHHHHHHH");
		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();
		if (vtkData.handle != null) 
		{

			char** names = null;
			int* components = null;
			int numVars = 0;
			float* values = null;
			int num_elements = 0;
			int num_components = 0;

			get_array (vtkData.handle, new StringBuilder ("Normals"), &values, &num_elements, &num_components);
			print (num_elements);
			print (num_components);
			print (values [0] + "," + values [1] + "," + values [2]);

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
			//mesh.RecalculateNormals ();
			//
			//print ("YY " + isovalue + " " + np + " " + nt );
		} //else
		//print ("not!");
	}
}
