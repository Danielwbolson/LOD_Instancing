using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;



public class VTKData : MonoBehaviour {
	private IntPtr NULL = IntPtr.Zero;
	public string filename;
	unsafe public void* handle = null;

	[DllImport("vtkplugin", EntryPoint = "answer")]  private static extern int answer();
	[DllImport("vtkplugin", EntryPoint = "open_data")]  unsafe private static extern void* open_data (StringBuilder sb);
	[DllImport("vtkplugin", EntryPoint = "close_data")]  unsafe private static extern void   close_data (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_number_of_vertices")]  unsafe private static extern int   get_number_of_vertices (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_bounds")]  unsafe private static extern IntPtr get_bounds (void* h);



	private Vector3 data_center;
	private Vector3 data_size;

	void Start () {
		filename = Application.dataPath + "/data/test.vti";
	}

	// Update is called once per frame
	void Update () {

	}

	public void SetFileName(string f)
	{
		filename = f;
	}

	public void OnDrawGizmos()
	{
		unsafe{
			if (handle != null) {

				Gizmos.color = Color.yellow;

			
				//print (center.x + ", " + size.x);
				Gizmos.matrix = transform.localToWorldMatrix;
				Gizmos.DrawWireCube (data_center, data_size);
			}
		}
	}

	public void LoadData()
	{
		print ("Loading " + filename);

		unsafe{
			if (handle != null)
				close_data (handle);
			// char* s = ;
			print("opening..");
			handle = open_data (new StringBuilder(filename));

			if (handle == null)
				print ("Could not open " + filename);
			else
				print("Opened " + filename);



			IntPtr bbox_buff;
			double[] bbox = new double[6];

			bbox_buff = get_bounds (handle);
			Marshal.Copy (bbox_buff, bbox, 0, 6);
			Vector3 mm = new Vector3 ((float)(bbox [0]), (float)(bbox [2]), (float)(bbox [4]));
			Vector3 MM = new Vector3 ((float)(bbox [1]), (float)(bbox [3]), (float)(bbox [5]));

			Vector3 center = (mm + MM) / 2;
			Vector3 size = MM - mm;
			float[] sizes = { size.x, size.y, size.z };
			float extremum = sizes.Max ();
			gameObject.transform.localScale = new Vector3(1f/extremum,1f/extremum,1f/extremum);
			data_size = size;
			data_center = center;
			//print ("loaded " + get_number_of_vertices (handle) + " vertices");
		
			gameObject.transform.GetChild (0).gameObject.GetComponent<VTKContour> ().vtkContour ();
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
