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
	[DllImport("vtkplugin")] private static extern IntPtr get_dimensions (IntPtr h);

	[DllImport("vtkplugin")] private static extern void free_data (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_lines (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_polygons (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_strips (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   get_number_of_points (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   ComputePointId (IntPtr h, int i, int j, int k);

	[DllImport("vtkplugin")] private static extern int   get_number_of_cells (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   IsA (IntPtr h, string type);

	[DllImport("vtkplugin")] unsafe private static extern void get_point_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(IntPtr h, string array_name, IntPtr *values, int *number_of_elements, int *number_of_components);

	[DllImport("vtkplugin")] unsafe private static extern void get_cell_variable_names(IntPtr h, char ***names, int ** components, int *number_of_variables);


	~VTKData() {
		VTK.vtkCompound.free_data (handle);
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
				VTK.vtkCompound.free_data((IntPtr)pointVarNames[i]);
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
				VTK.vtkCompound.free_data((IntPtr)cellVarNames[i]);
			}

			//free_data (names);
			//free_data (components);

			bool a = VTK.vtkDataSet.IsA (handle,"vtkUnstructuredGrid");
			bool aa = VTK.vtkCompound.IsA (handle, "vtkStructuredGrid")==1;

			VTK.vtkXMLUnstructuredGridReader p = VTK.vtkXMLUnstructuredGridReader.New ();
			print ("CLASS NAME: " + VTK.vtkXMLDataReader.GetClassName (p));
			print("" + p.CanReadFile ("/Users/sethjohnson/NSF-Sculpting-Vis-Platform/unity/VisualizationPlatform/Assets/StreamingAssets/example_data/VTK/CICE.vtu"));


			IntPtr bbox_buff;
			double[] bbox = new double[6];
			Bounds b = VTK.vtkDataSet.GetBounds(handle);
			data_size = b.size;
			data_center = b.center;
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

				IntPtr dim_buff;
				int[] dim = new int[3];

				dim_buff = get_dimensions (handle);
				Marshal.Copy (dim_buff, dim, 0, 3);

				print (dim [0] + "x" + dim [1] + "x" + dim [2]);
				IntPtr dataValues = IntPtr.Zero;;
				int num_elements_data = 0;
				int num_components_data = 0;
				get_array (handle, "FA", &dataValues, &num_elements_data, &num_components_data);

				float[] data_array = new float[num_elements_data * num_components_data];
				Marshal.Copy (dataValues, data_array, 0, data_array.Length);

				int x = 8;
				int y = 16;
				int z = 40;
				string line = "";
//				for (int i = 0; i < dim [0]; i++) {
//					for (int j = 0; j < dim [1]; j++) {
//						for (int k = 0; k < dim [2]; k++) {
//
//							if(data_array[index] != 0)
//								print("(" + i+","+j+","+ k+") " + data_array[index]);
//						}
//					}
//
//				}
				int index = z * dim [0] * dim [1] * num_components_data + y * dim [0] * num_components_data + x * num_components_data;
				print (index + ": " + data_array [index]);
				index = ComputePointId (handle, x,y,z);
				print (index + ": " + data_array [index]);

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
