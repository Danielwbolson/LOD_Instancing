using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;


public class VTKData : Data {

	public void print(string s) {
		Debug.Log (s);
	}
	private IntPtr NULL = IntPtr.Zero;

	unsafe public IntPtr handle = IntPtr.Zero;

	public string[] point_variable_names;
	int[] point_variable_components;
	public string[] cell_variable_names;
	int[] cell_variable_components;


	int[] line_cell_ids;
	[DllImport("vtkplugin")] private static extern IntPtr open_data (StringBuilder sb);
	[DllImport("vtkplugin")] private static extern void   close_data (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_vertices (IntPtr h);
	[DllImport("vtkplugin")] private static extern IntPtr get_bounds (IntPtr h);
	[DllImport("vtkplugin")] private static extern void free_data (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_lines (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_polygons (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_strips (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_points (IntPtr h);

	[DllImport("vtkplugin")] private static extern int   get_number_of_cells (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   IsA (IntPtr h, string type);

	[DllImport("vtkplugin")] unsafe private static extern void get_point_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);


	[DllImport("vtkplugin")] unsafe private static extern void get_cell_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);


	~VTKData() {
		free_data (handle);
	}
	public override int GetNumberOfVariables() {
		return point_variable_names.Count() + cell_variable_names.Count() ;
	}

	public override string GetVariableName(int i) {
		if(i < point_variable_names.Count())
			return point_variable_names [i];
		else 
			return cell_variable_names [i-point_variable_names.Count()];
		
	}

	public override int GetVariableComponentCount(int i) {
		if(i < point_variable_names.Count())
			return point_variable_components [i];
		else 
			return cell_variable_components [i-point_variable_names.Count()];	}

	public override int GetNumberOfLines() {
		if(IsType("vtkPolyData"))
			return get_number_of_lines (handle);
		else
			return 0;
	}

	public override void LoadData()
	{
		print ("Loading " + filename);

		unsafe{
			if (handle != NULL)
				close_data (handle);
			// char* s = ;
			print("opening..");
			handle = open_data (new StringBuilder(filename));



			if (handle == NULL)
				print ("Could not open " + filename);
			else
				print("Opened " + filename);


			char** pointVarNames = null;
			int* pointVarComponents = null;

			int numPointVars = 0;

			char** cellVarNames = null;
			int* cellVarComponents = null;

			int numCellVars = 0;

			get_point_variable_names (handle, &pointVarNames, &pointVarComponents, &numPointVars);
			get_cell_variable_names (handle, &cellVarNames, &cellVarComponents, &numCellVars);

			point_variable_names = new string[numPointVars];
			point_variable_components = new int[numPointVars];
			//print (numVars);
			for (int i = 0; i < numPointVars; i++) {
				//print ( Marshal.PtrToStringAnsi((IntPtr)names[i]) + " (" + components [i] + ")");
				point_variable_names [i] = Marshal.PtrToStringAnsi ((IntPtr)pointVarNames [i]);
				point_variable_components [i] = pointVarComponents [i];
			}

			for (int i = 0; i < numPointVars; i++) {
				free_data((IntPtr)pointVarNames[i]);
			}


			cell_variable_names = new string[numCellVars];
			cell_variable_components = new int[numCellVars];
			//print (numVars);
			for (int i = 0; i < numCellVars; i++) {
				//print ( Marshal.PtrToStringAnsi((IntPtr)names[i]) + " (" + components [i] + ")");
				cell_variable_names [i] = Marshal.PtrToStringAnsi ((IntPtr)cellVarNames [i]);
				cell_variable_components [i] = cellVarComponents [i];
			}

			for (int i = 0; i < numCellVars; i++) {
				free_data((IntPtr)cellVarNames[i]);
			}

			//free_data (names);
			//free_data (components);


			IntPtr bbox_buff;
			double[] bbox = new double[6];

			bbox_buff = get_bounds (handle);
			Marshal.Copy (bbox_buff, bbox, 0, 6);
			Vector3 mm = new Vector3 ((float)(bbox [0]), (float)(bbox [2]), (float)(bbox [4]));
			Vector3 MM = new Vector3 ((float)(bbox [1]), (float)(bbox [3]), (float)(bbox [5]));

			Vector3 center = (mm + MM) / 2;
			Vector3 size = MM - mm;
			data_size = size;
			data_center = center;
			print ("Center and extent: " + data_center + ", " + data_size);
			float[] sizes = { data_size.x, data_size.y, data_size.z };
			float extremum = sizes.Max ();
			//gameObject.transform.localScale = new Vector3(1f/extremum,1f/extremum,1f/extremum);

			//updateBounds ();
			is_valid = true;
			
//			for (int c = 0; c < gameObject.transform.childCount; c++) {
//				Filter f = gameObject.transform.GetChild (c).GetComponent<Filter> ();
//				if (f == null)
//					continue;
//				f.RefreshFilter ();
//			}


			//print ("Vertices: " + get_number_of_vertices (handle));
			//print ("Polygons: " + get_number_of_polygons (handle));
			//print ("Strips:   " + get_number_of_strips (handle));
			//print ("Lines:    " + get_number_of_lines (handle));
			//print ("Cells:    " + get_number_of_cells (handle));

			if (IsType ("vtkPolyData")) {
				print("Is a PolyData");

				print ("Vertices: " + get_number_of_vertices (handle));
				print ("Polygons: " + get_number_of_polygons (handle));
				print ("Strips:   " + get_number_of_strips (handle));
				print ("Lines:    " + get_number_of_lines (handle));
				print ("Cells:    " + get_number_of_cells (handle));
			}
			if (IsType ("vtkImageData")) {
				print("Is an ImageData");

				print ("Points: " + get_number_of_points (handle));
				print ("Cells:    " + get_number_of_cells (handle));
			}
			if (IsType ("vtkUnstructuredGrid")) {
				print("Is a vtkUnstructuredGrid");

				print ("Points: " + get_number_of_points (handle));
				print ("Cells:    " + get_number_of_cells (handle));
			}
			return;

		}
	}

	public override bool IsType(string type) {
		return IsA(handle, type) == 1;
	}

	public int GetNumberOfVertices()
	{
		unsafe {
			if (handle != null)
				return get_number_of_vertices (handle);
			else
				return -1;
		}
	}
}
