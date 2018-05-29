using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System;
using System.IO;
using UnityEditor;


[CustomEditor(typeof(DataLoader))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DataLoader myScript = (DataLoader)target;
        if (GUILayout.Button("Load Data"))
        {
            myScript.FilePathChangeHandler();
        }
    }
}



public class DataLoader : DataAlgorithm {
    

  

    public void FilePathChangeHandler()
    {

        string path = Application.streamingAssetsPath + "/" + filePath;
        vtkXMLDataReader reader = IntPtr.Zero;
        if (!File.Exists(path))
        {
            print("File [" + path + "] does not exist");
            return;
        }

        string ext = Path.GetExtension(path);

        vtkXMLDataReader[] readers = {
            vtkXMLImageDataReader.New(),
            vtkXMLPolyDataReader.New(),
            vtkXMLStructuredGridReader.New(),
            vtkXMLUnstructuredGridReader.New()
        };

        foreach (var r in readers)
            if (r.CanReadFile(path) == 1)
            {
                reader = r; break;
            }


        algorithm_ = reader;
        if(!reader.IsVoid()) {
            reader.SetFileName(path);
            algorithm_ = reader;
            print("Set file path " + path);
        }
        RefreshAlgorithm();
    }
	

	public string filePath;

  
	// Use this for initialization
	void Start () {

        vtkDataObject dataObject = GetDataObject();
        print(dataObject);
	}
	
	// Update is called once per frame
	void Update () {
		
   

	}
}
