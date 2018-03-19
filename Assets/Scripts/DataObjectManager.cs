using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataObjectManager : MonoBehaviour {

	public string path;

	public List<string> filePaths;

	// Use this for initialization
	void Start () {
		Refresh ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Refresh() {
		print ("Searching " + Application.streamingAssetsPath + "/" + "example_data/VTK" + "/"); 
		//if (path.Length !=0) {
			SearchDirectory (Application.streamingAssetsPath + "/" + "example_data/VTK" + "/");
		//}

		print (filePaths.Count + " vtk files found");
	}
	void SearchDirectory(string path) {
		if (filePaths == null)
			filePaths = new List<string> ();
		else
			filePaths.Clear ();
		try{
			foreach (string file in System.IO.Directory.GetFiles(path))
			{ 	
				if (!file.EndsWith (".meta")) {
					filePaths.Add (file);

				}
			}
		} catch(DirectoryNotFoundException e) {
			print("Could not find path " +path);
		}
	}


}
