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
	public bool shouldNormalize = true;

	public void setShouldNormalize(bool n) {
		shouldNormalize = n;

	}

	[DllImport("vtkplugin", EntryPoint = "answer")]  private static extern int answer();
	[DllImport("vtkplugin", EntryPoint = "open_data")]  unsafe private static extern void* open_data (StringBuilder sb);
	[DllImport("vtkplugin", EntryPoint = "close_data")]  unsafe private static extern void   close_data (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_number_of_vertices")]  unsafe private static extern int   get_number_of_vertices (void* h);
	[DllImport("vtkplugin", EntryPoint = "get_bounds")]  unsafe private static extern IntPtr get_bounds (void* h);



	private Vector3 data_center;
	private Vector3 data_size;

	public Vector3 getBoundingCenter () {
		return data_center;
	}
	public Vector3 getBoundingSize() {
		return data_size;
	}

	void Start () {
		gameObject.GetComponent<LineRenderer> ().enabled = false;

	}

	// Update is called once per frame

	static float t = 0.0f;
	public float scaleFactor = 1;
	void Update () {
		if (!shouldNormalize) {
			t -= 0.5f * Time.deltaTime;
		} else
			t += 0.5f * Time.deltaTime;
		t = Mathf.Clamp (t, 0f, 1f);
		float[] sizes = { data_size.x, data_size.y, data_size.z };
		float extremum = sizes.Max ();
		scaleFactor = Mathf.SmoothStep(1f, 1f / extremum, t);


		gameObject.transform.localScale = new Vector3(scaleFactor,scaleFactor,scaleFactor);
		
	}

	public void SetFileName(string f)
	{
		filename = f;
	}

	public void OnDrawGizmos()
	{
		
	}

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

            //print ("loaded " + get_number_of_vertices (handle) + " vertices");

            Vector3[] corners = new Vector3[8];
            corners[0] = new Vector3(-1, 1, -1);
            corners[1] = new Vector3(1, 1, -1);
            corners[2] = new Vector3(-1, -1, -1);
            corners[3] = new Vector3(1, -1, -1); 


            corners[4] = new Vector3(-1, 1, 1);
            corners[5] = new Vector3(1, 1, 1);
            corners[6] = new Vector3(-1, -1, 1);
            corners[7] = new Vector3(1, -1, 1);

            Vector3[] linePositions = new Vector3[16];
            linePositions[0] = (data_center + Vector3.Scale(data_size,corners[0])*0.5f);
            linePositions[1] = (data_center + Vector3.Scale(data_size, corners[2]) * 0.5f);
            linePositions[2] = (data_center + Vector3.Scale(data_size, corners[3]) * 0.5f);
            linePositions[3] = (data_center + Vector3.Scale(data_size, corners[1]) * 0.5f);
            linePositions[4] = (data_center + Vector3.Scale(data_size, corners[0]) * 0.5f);
            linePositions[5] = (data_center + Vector3.Scale(data_size, corners[4]) * 0.5f);
            linePositions[6] = (data_center + Vector3.Scale(data_size, corners[5]) * 0.5f);
            linePositions[7] = (data_center + Vector3.Scale(data_size, corners[1]) * 0.5f);
            linePositions[8] = (data_center + Vector3.Scale(data_size, corners[3]) * 0.5f);
            linePositions[9] = (data_center + Vector3.Scale(data_size, corners[7]) * 0.5f);
            linePositions[10] = (data_center + Vector3.Scale(data_size, corners[5]) * 0.5f);
            linePositions[11] = (data_center + Vector3.Scale(data_size, corners[4]) * 0.5f);
            linePositions[12] = (data_center + Vector3.Scale(data_size, corners[6]) * 0.5f);
            linePositions[13] = (data_center + Vector3.Scale(data_size, corners[2]) * 0.5f);
			linePositions[14] = (data_center + Vector3.Scale(data_size, corners[6]) * 0.5f);
			linePositions[15] = (data_center + Vector3.Scale(data_size, corners[7]) * 0.5f);


            gameObject.GetComponent<LineRenderer>().SetPositions(linePositions);
			gameObject.GetComponent<LineRenderer> ().enabled = true;
			gameObject.transform.GetChild (0).gameObject.GetComponent<VTKContour> ().vtkContour ();

			gameObject.transform.GetChild (1).gameObject.GetComponent<VTKContour> ().vtkContour ();
			gameObject.transform.GetChild (2).gameObject.GetComponent<VTKContour> ().vtkContour ();

			gameObject.transform.GetChild (3).gameObject.GetComponent<VTKSampleSet> ().vtkSample ();
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
