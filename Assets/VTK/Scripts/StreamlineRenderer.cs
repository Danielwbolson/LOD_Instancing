using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

public class StreamlineRenderer : Filter {
	public VTKData vtkData;
	public float isovalue = 0.001f;
	bool is_valid = false;

	[DllImport("vtkplugin")] unsafe private static extern int contour (void *d, float v, int *np, float **p, float **n, int *nt, int **t);
	[DllImport("vtkplugin")] unsafe private static extern void free_data (void* h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(void *h, StringBuilder array_name, float **values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern void get_points(void *h, float **values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern int get_number_of_lines (void*h);
	[DllImport("vtkplugin")] unsafe private static extern void get_line_ids (void*h, int line, int** ids_list, int*number_of_ids);
		
	public override void RefreshFilter() {
		getLines ();


	}
	private List<List<int> > ids;
	private Vector3 [] line_positions = null;
	private Vector3 [] line_normals = null;
	private float[] line_values = null;

	unsafe void OnDrawGizmos() {
		if (!is_valid)
			return;
		Gizmos.matrix = transform.localToWorldMatrix;
		UnityEngine.Random.InitState (2);

		for (int l = 0; l < ids.Count; l++) {
			Gizmos.color =  UnityEngine.Random.ColorHSV();
			print (ids [l].Count);

			for (int i = 1; i < ids [l].Count; i++) {
				Vector3 A = line_positions [ids [l][(i - 1)]];
				Vector3 B = line_positions [ids[l][(i)]];

				Gizmos.DrawLine(A,B)  ;
			}
		}
			

		Gizmos.color = Color.green;
	}

	
	unsafe public void getLines()
	{

		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();
		if (vtkData.handle != null) 
		{
			


			float* normals = null;
			float* dataValues = null;
			float* points = null;
			int num_elements_normals = 0;
			int num_components_normals = 0;

			int num_elements_data = 0;
			int num_components_data = 0;

			int num_points = 0;
			int point_components = 0;


			get_array (vtkData.handle, new StringBuilder ("Normals"), &normals, &num_elements_normals, &num_components_normals);
			get_array (vtkData.handle, new StringBuilder ("RTData"), &dataValues, &num_elements_data, &num_components_data);
			get_points (vtkData.handle, &points, &num_points, &point_components);
			int number_of_lines = get_number_of_lines (vtkData.handle);
			ids = new List<List<int> > ();
			line_values = new float[num_points];
			line_positions = new Vector3[num_points];
			line_normals = new Vector3[num_points];
			print ("COMP: " + point_components);
			for (int i = 0; i < num_points; i++) {
				line_positions [i] = new Vector3 (points [i * 3 + 0], points [i * 3 + 1], points [i * 3 + 2]);
				line_normals [i] = new Vector3 (normals [i * 3 + 0], normals [i * 3 + 1], normals [i * 3 + 2]);
				line_values[i] = dataValues[i];
				//print (line_positions[i]);
			}
			for (int i = 0; i < number_of_lines; i++) {
				int* id_list = null;
				int num_ids = 0;
				get_line_ids (vtkData.handle, i, &id_list, &num_ids);
//				print ("Line " + i + " has " + num_ids + " points");
				ids.Add (new List<int> ());
				for (int id = 0; id < num_ids; id++) {
					ids.Last().Add(id_list[id]);
				}
				free_data(id_list);
			}
			print (num_elements_normals);
			print (num_components_normals);
			print (normals [0] + "," + normals [1] + "," + normals [2]);
			print (num_components_data);

			print (dataValues [0]);

			free_data (normals);
			free_data (dataValues);
			free_data (points);
			is_valid = true;

		} //else
		//print ("not!");
	}
}
