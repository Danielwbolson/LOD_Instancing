using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class DataList : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DirectoryInfo info = new DirectoryInfo(Application.streamingAssetsPath + "/example_data/VTK/");
		FileInfo[] fileInfo = info.GetFiles();
		foreach (FileInfo file in fileInfo) print (file);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
