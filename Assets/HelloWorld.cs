using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
using System;



public class HelloWorld : MonoBehaviour {
	[DllImport("vtkplugin", EntryPoint = "answer")] unsafe private static extern int answer();
	[DllImport("vtkplugin", EntryPoint = "hello_world")] unsafe private static extern IntPtr hello_world();
	[DllImport("vtkplugin", EntryPoint = "free_data")] unsafe private static extern void free_data(IntPtr p);

	// Use this for initialization
	void Start () {
		print ("Hello! The answer from VTK is " + answer ());
		unsafe{
			IntPtr str = hello_world ();
			string s = Marshal.PtrToStringAnsi (str);

			print ("Hello! The greeting from VTK is '" + s + "'");

			free_data (str);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
