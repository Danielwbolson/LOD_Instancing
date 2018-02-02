using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
using System;



public class HelloWorld : MonoBehaviour {
	[DllImport("vtkplugin", EntryPoint = "answer")] unsafe private static extern int answer();
	[DllImport("vtkplugin", EntryPoint = "get_vtk_version")] unsafe private static extern IntPtr get_vtk_version();
	[DllImport("vtkplugin", EntryPoint = "free_data")] unsafe private static extern void free_data(IntPtr p);

	// Use this for initialization
	void Start () {
		IntPtr str = get_vtk_version();
		string s = Marshal.PtrToStringAnsi (str);

		print ("The loaded VTK version is '" + s + "'");

		free_data (str);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
