using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;


public class VTKData : Data {
	private IntPtr NULL = IntPtr.Zero;

	unsafe public void* handle = null;

	public string[] variable_names;
	int[] variable_components;


	[DllImport("vtkplugin", EntryPoint = "answer")]  private static extern int answer();
	[DllImport("vtkplugin", EntryPoint = "open_data")]  unsafe private static extern void* open_data (StringBuilder sb);
	[DllImport("vtkplugin", EntryPoint = "close_data")]  unsafe private static extern void   close_data (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_number_of_vertices")]  unsafe private static extern int   get_number_of_vertices (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_bounds")]  unsafe private static extern IntPtr get_bounds (void* h);
	[DllImport("vtkplugin", EntryPoint = "free_data")]  unsafe private static extern void free_data (void* h);

	[DllImport("vtkplugin", EntryPoint = "get_variable_names")] 
	unsafe private static extern void get_variable_names(void *h, char ***names, int ** components, int *number_of_variables);


	public void LoadData()
	{
		print ("Loading " + Application.streamingAssetsPath + "/" + filename);

		unsafe{
			if (handle != null)
				close_data (handle);
			// char* s = ;
			print("opening..");
			handle = open_data (new StringBuilder(Application.streamingAssetsPath + "/" + filename));



			if (handle == null)
				print ("Could not open " + Application.streamingAssetsPath + "/" + filename);
			else
				print("Opened " + Application.streamingAssetsPath + "/" + filename);


			char** names = null;
			int* components = null;
			int numVars = 0;
			get_variable_names (handle, &names, &components, &numVars);
			variable_names = new string[numVars];
			variable_components = new int[numVars];
			//print (numVars);
			for (int i = 0; i < numVars; i++) {
				//print ( Marshal.PtrToStringAnsi((IntPtr)names[i]) + " (" + components [i] + ")");
				variable_names [i] = Marshal.PtrToStringAnsi ((IntPtr)names [i]);
				variable_components [i] = components [i];
			}

			for (int i = 0; i < numVars; i++) {
				free_data(names[i]);
			}
			free_data (names);
			free_data (components);


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

			float[] sizes = { data_size.x, data_size.y, data_size.z };
			float extremum = sizes.Max ();
			gameObject.transform.localScale = new Vector3(1f/extremum,1f/extremum,1f/extremum);

			updateBounds ();
			is_valid = true;
			
			for (int c = 0; c < gameObject.transform.childCount; c++) {
				Filter f = gameObject.transform.GetChild (c).GetComponent<Filter> ();
				if (f == null)
					continue;
				f.RefreshFilter ();
			}

			return;

		}
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
