using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

public class DataLineRenderer : MonoBehaviour {

	[DllImport("vtkplugin")] unsafe private static extern void free_data (IntPtr h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(IntPtr h, string array_name, IntPtr *values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern  void get_array_range(IntPtr h, string array_name, int component, float * min, float * max);
	[DllImport("vtkplugin")] unsafe private static extern void get_points(IntPtr h, IntPtr* values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern int get_number_of_lines (IntPtr h);
	[DllImport("vtkplugin")] unsafe private static extern void get_line_ids (IntPtr h, int line, IntPtr* ids_list, int*number_of_ids, int*reasonForTermination, int*seedId);



	public bool uniformGizmo = false;
	public int numGizmo = 10;
	public VTKData vtkData;
	public float isovalue = 0.001f;
	bool is_valid = false;
	private IntPtr NULL = IntPtr.Zero;
	private Paths paths;
	public bool Use3DGlyph = false;
	//protected List<Spline> splines;
	private Paths uniformPaths = null;

	unsafe void OnDrawGizmos() {
		//return;
		if (!is_valid)
			return;
		Gizmos.matrix = transform.localToWorldMatrix;

		//		for (int l = 0; l < uniformSplines.Count; l++) {
		//			for (int i = 1; i < uniformSplines [l].Count; i++) {
		//				Vector3 A = uniformSplines [l] [(i - 1)];
		//				Vector3 B = uniformSplines [l] [(i)];
		//
		//				if (i == 1)
		//					Gizmos.color = Color.green;
		//				else if (i == uniformSplines [l].Count - 1)
		//					Gizmos.color = Color.red;
		//				else if (i % 2 == 0)
		//					Gizmos.color = Color.white;
		//				else
		//					Gizmos.color = Color.black;
		//				Gizmos.DrawLine(A,B)  ;
		//			}
		//		}

		//		for (int l = 0; l < ids.Count; l++) {
		//			for (int i = 1; i < ids [l].Count; i++) {
		//				Vector3 A = line_positions[ids [l] [(i - 1)]];
		//				Vector3 B = line_positions[ids [l] [i]];
		//
		//				if (i == 1)
		//					Gizmos.color = Color.green;
		//				else if (i == uniformSplines [l].Count - 1)
		//					Gizmos.color = Color.red;
		//				else if (i % 2 == 0)
		//					Gizmos.color = Color.white;
		//				else
		//					Gizmos.color = Color.black;
		//				Gizmos.DrawLine(A,B)  ;
		//			}
		//		}

		float min = paths.getVariable ("data").getMinValue();
		float max = paths.getVariable ("data").getMaxValue();

		if (!uniformGizmo) {
			print ("non uniform");
			for (int l = 0; l < Mathf.Min( paths.getNumberOfLines(), numGizmo); l++) {
				int[] indices = paths.getLineIndices (l);

				for (int i = 1; i < indices.Count(); i++) {
					Vector3 A = paths.getLineVertex( indices [i-1]);
					Vector3 B = paths.getLineVertex( indices [i]);
					if (true) {
						float v = paths.getLineVariableValue1 ("data", indices [i - 1]);
						float v_norm = v.Map (min, max, 0, 1);
						Gizmos.color = Color.HSVToRGB(0,0,v_norm);
					} else {
						if (i == 1)
							Gizmos.color = Color.green;
						else if (i == indices.Count () - 1)
							Gizmos.color = Color.red;
						else if (i % 2 == 0)
							Gizmos.color = Color.white;
						else
							Gizmos.color = Color.black;
					}
					Gizmos.DrawLine(A,B)  ;

					Gizmos.color = Color.blue;
					//print(Vector3.Angle (B - A, paths.getLineNormal (indices [i - 1])));
					//Gizmos.DrawLine (A, A + paths.getLineNormal(indices[i-1]).normalized * 0.1f);
				}
			}
		} else {
			if (uniformPaths == null)
				return;
			print ("uniform");

			for (int l = 0; l < Mathf.Min( uniformPaths.getNumberOfLines(), numGizmo); l++) {
				int[] indices = uniformPaths.getLineIndices (l);

				for (int i = 1; i < indices.Count(); i++) {
					Vector3 A = uniformPaths.getLineVertex( indices [i-1]);
					Vector3 B = uniformPaths.getLineVertex( indices [i]);
					if (true) {
						float v = uniformPaths.getLineVariableValue1 ("data", indices [i - 1]);
						float v_norm = v.Map (min, max, 0, 1);
						Gizmos.color = Color.HSVToRGB(0,0,v_norm);
					} else {
						if (i == 1)
							Gizmos.color = Color.green;
						else if (i == indices.Count () - 1)
							Gizmos.color = Color.red;
						else if (i % 2 == 0)
							Gizmos.color = Color.white;
						else
							Gizmos.color = Color.black;
					}
					Gizmos.DrawLine(A,B)  ;

					Gizmos.color = Color.blue;
					//print(Vector3.Angle (B - A, paths.getLineNormal (indices [i - 1])));
					//Gizmos.DrawLine (A, A + uniformPaths.getLineNormal(indices[i-1]).normalized * 0.1f);
				}
			}

		}

		//


		Gizmos.color = Color.green;
	}



	unsafe public void getLines()
	{
		print ("getting lines");
		if (vtkData == null)
			vtkData = (VTKData)dataObject.data;
		if (vtkData.handle != NULL) 
		{
			print ("Handle: " + vtkData.handle);

			paths = new Paths ();

			//splines = new List<Spline> ();

			IntPtr normals = IntPtr.Zero;;
			IntPtr dataValues = IntPtr.Zero;;

			IntPtr points = IntPtr.Zero;;
			int num_elements_normals = 0;
			int num_components_normals = 0;

			int num_elements_data = 0;
			int num_components_data = 0;

			int num_points = 0;
			int point_components = 0;


			get_array (vtkData.handle, "Normals", &normals, &num_elements_normals, &num_components_normals);
			float[] normal_array = new float[num_elements_normals * num_components_normals];
			Marshal.Copy (normals, normal_array, 0, normal_array.Length);
			//free_data (normals);


			get_points (vtkData.handle, &points, &num_points, &point_components);
			float [] point_array = new float[num_points * point_components];
			Marshal.Copy ( points, point_array, 0, point_array.Length);

			//free_data (dataValues);


			get_array (vtkData.handle, "RTData", &dataValues, &num_elements_data, &num_components_data);
			float [] min = new float[num_components_data];
			float [] max = new float[num_components_data];
			for (int c = 0; c < num_components_data; c++) {
				float mn;
				float mx;

				get_array_range (vtkData.handle, "RTData", c, &mn, &mx);
				min [c] = mn;
				min [c] = mx;

			}
			print ("MINMAX: " + min + ", " + max);

			float[] data_array = new float[num_elements_data * num_components_data];
			Marshal.Copy (dataValues, data_array, 0, data_array.Length);


			//free_data (points);





			int number_of_lines = get_number_of_lines (vtkData.handle);

			print ("COMP: " + point_components);
			paths.setPointData (point_array, 3);
			paths.setNormalData (normal_array, num_components_normals);
			paths.addVariable ("data", data_array, num_components_data, min, max);
			for (int i = 0; i < num_points; i++) {

				//print (line_positions[i]);
			}
			for (int i = 0; i < number_of_lines; i++) {
				IntPtr id_list = IntPtr.Zero;;
				int num_ids = 0;
				int reason_for_termination = -1;
				int seedId = -1;
				get_line_ids (vtkData.handle, i, &id_list, &num_ids, &reason_for_termination, &seedId);
				print (reason_for_termination + ", " + seedId);

				int[] id_array = new int[num_ids];
				Marshal.Copy (id_list, id_array, 0, id_array.Length);
				//				print ("Line " + i + " has " + num_ids + " points");
				paths.addLine (id_array, seedId, true);


				free_data(id_list);
			}


			is_valid = true;
			uniformPaths = paths.generateUniformPaths (0.1f);
			print ("LINE COUNT: " + uniformPaths.getNumberOfLines());

			//UpdateBuffer ();


		} //else
		//print ("not!");
	}


	public DataObject1 dataObject;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
