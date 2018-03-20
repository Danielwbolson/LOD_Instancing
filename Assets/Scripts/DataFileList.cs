using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class DataFileList : MonoBehaviour {

	public List<string> paths;
	
	// Use this for initialization
	void Awake () {
		paths = new List<string> ();

		SearchDirectory (Application.streamingAssetsPath + "/" + "example_data/VTK" + "/");


	}
	
	// Update is called once per frame
	void Update () {

	}


	void SearchDirectory(string path) {
		foreach (string file in System.IO.Directory.GetFiles(path))
		{ 	
			if (!file.EndsWith (".meta")) {
				paths.Add (file);

			}
		}
	}
}
