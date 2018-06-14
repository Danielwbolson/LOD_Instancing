using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System;
using System.IO;
using UnityEditor;


[CreateAssetMenu()]
public class Database : ScriptableObject {
        public List<vtkDataSet> _datasets;
        public List<string> _datasetNames;
        public List<DV.DVDataObject> _dataObjects;
        public int GetDatasetCount() {return _datasets != null? _datasets.Count : 0;}
        public void AddDataset(vtkDataSet dataset, string datasetName, DV.DVDataObject dataObject) {
            if(_datasets == null) _datasets = new List<vtkDataSet>();
            if(_datasetNames == null) _datasetNames = new List<string>();
            if(_dataObjects == null) _dataObjects = new List<DV.DVDataObject>();
            _datasets.Add(dataset);
            _datasetNames.Add(datasetName);
            _dataObjects.Add(dataObject);
        }

}
namespace DV
{
    [CustomEditor(typeof(DVDataLoader))]
    public class DVDataLoaderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DVDataLoader myScript = (DVDataLoader)target;
            if (GUILayout.Button("Load Data"))
            {
                myScript.LoadData();
            }
        }
    }



    public class DVDataLoader : MonoBehaviour
    {

        public GameObject _root;
        public GameObject _dataObjectPrefab;
        public string _filePath;

        public Database _database;
        public void LoadData()
        {
            if (_dataObjectPrefab)
            {
                GameObject newData = Instantiate(_dataObjectPrefab);
                VTK.vtkDataSet ds = LoadVTKDataSet();

                newData.GetComponent<DVDataObject>().SetDataSet(ds);
                _database.AddDataset(ds,Path.GetFileName(_filePath), newData.GetComponent<DV.DVDataObject>());
                if (_root)
                {
                    newData.transform.SetParent(_root.transform, false);
                }
            }
        }


        protected vtkDataSet LoadVTKDataSet()
        {

            string path = Application.streamingAssetsPath + "/" + _filePath;
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
                print("Set file path " + path);
            }

            algorithm_.Update();
            return reader.GetOutputAsDataSet();
        }

    }
}