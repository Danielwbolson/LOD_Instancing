using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System;
using System.IO;
using UnityEditor;



[CustomEditor(typeof(DataLoader))]
public class DataLoaderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DataLoader myScript = (DataLoader)target;
        if (GUILayout.Button("Load Data"))
        {
            myScript.LoadData();
        }
    }
}



public class DataLoader : MonoBehaviour {

    [SerializeField, HideInInspector]
    Database _database;
    [SerializeField, HideInInspector]
    GameObject _dataObjectPrefab;
    public string _filePath;

    [SerializeField, HideInInspector]
    Transform _root;

        // Want to change this to be a loading strategy
    public void LoadData()
    {
        VTK.vtkDataSet ds = LoadVTKDataSet(_filePath);
        if(ds.IsVoid()) return;


        if (_dataObjectPrefab)
        {
            GameObject newData = Instantiate(_dataObjectPrefab);
                  newData.GetComponent<DataObject>().SetDataSet(ds);

            newData.GetComponent<DataObject>().SetDataBase(_database);
            newData.GetComponent<DataObject>().SetFilePath(_filePath);
            newData.GetComponent<DataObject>().SetDataLoader(this);
            _database.AddDataObject(newData.GetComponent<DataObject>());
            if (_root)
            {
                newData.transform.SetParent(_root, false);
            }
        }
    }


    static public vtkDataSet LoadVTKDataSet(string filePath)
        {

        string path = Application.streamingAssetsPath + "/" + filePath;
        vtkXMLDataReader reader = IntPtr.Zero;
        if (!File.Exists(path))
        {
            print("File [" + path + "] does not exist");
            return IntPtr.Zero;
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
                reader = r;
                break;
            }


        vtkXMLDataReader algorithm_ = reader;
        if (!reader.IsVoid())
        {
            reader.SetFileName(path);
            algorithm_ = reader;
            //print("Set file path " + path);

            algorithm_.Update();
            return reader.GetOutputAsDataSet();
        } else {
            return IntPtr.Zero;
        }

    }
}