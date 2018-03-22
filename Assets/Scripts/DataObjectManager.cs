using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


[System.Serializable]
public class DataFile {
	public DataFile(string path) {
		filePath = path;
	}
	public string filePath;

}

public class DataObjectManager : MonoBehaviour {

	public string path;
	public DataFactory factory;

	public List<DataFile> files;

	public DataObject dataobject;

	// Use this for initialization
	void Start () {
		Refresh ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Refresh() {
		//print ("Searching " + Application.streamingAssetsPath + "/" + path + "/"); 
		SearchDirectory (Application.streamingAssetsPath + "/" + path + "/");

		//print (files.Count + " vtk files found");
	}

	public int GetNumberOfFiles() {
		return files.Count;
	}

	public DataFile GetDataFile(int i) {
		return files [i];
	}
	void SearchDirectory(string path) {
		if (files == null)
			files = new List<DataFile> ();
		else
			files.Clear ();
		try{
			foreach (string file in System.IO.Directory.GetFiles(path))
			{ 	
				if (!file.EndsWith (".meta")) {
					files.Add (new DataFile(file));

				}
			}
		} catch(DirectoryNotFoundException e) {
			print("Could not find path " + path);
		}
	}



}
