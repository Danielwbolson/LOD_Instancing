using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System;
using System.IO;
using UnityEditor;

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

        public void LoadData()
        {
            if (_dataObjectPrefab)
            {
                GameObject newData = Instantiate(_dataObjectPrefab);
                newData.GetComponent<DVDataObject>().SetDataSet(LoadVTKDataSet());
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