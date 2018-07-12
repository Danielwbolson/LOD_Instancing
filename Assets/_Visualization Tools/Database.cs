using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System;
using System.IO;
using UnityEditor;

namespace DEPRECATED{

[CustomEditor(typeof(Database))]
public class DatabaseEditor : Editor
{
    public override void OnInspectorGUI()
    {

        Database database = (Database)target;

        GUILayout.Label(database.GetDataObjectCount() + " data objects.");

        GUILayout.BeginVertical();

        List<Rect> dataAreas = new List<Rect>();
        for(int i = 0; i < database.GetDataObjectCount(); i++) {

            dataAreas.Add(EditorGUILayout.BeginHorizontal("box"));

            GUILayout.Label("Dataset: " + Path.GetFileName(database.GetDataObject(i).GetFilePath()));
            
            if(GUILayout.Button("-", GUILayout.Width(20)))
                database.RemoveDataObject(database.GetDataObject(i));
            GUILayout.EndHorizontal();

        }

        GUILayout.EndVertical();



        Event evt = Event.current;
     
        switch (evt.type) {
        case EventType.MouseUp:
            for(int i = 0; i < dataAreas.Count; i++) {
                if (!dataAreas[i].Contains (evt.mousePosition))
                    continue;
                UnityEngine.Object[] objects = new UnityEngine.Object[1];
                objects[0] = database.GetDataObject(i).gameObject;
                Selection.objects = objects;
            }   
            break;
        }
    }
}




public class Database : MonoBehaviour {

        [SerializeField]
        List<DataObject> _dataObjects;



        public void AddDataObject(DataObject dataObject) {
            _dataObjects.Add(dataObject);
        }
        public void RemoveDataObject(DataObject dataObject) {
            _dataObjects.Remove(dataObject);
            if(dataObject.GetDataBase() != null) {// If it hasn't deleted itself yet 
                dataObject.SetDataBase(null);
                dataObject.Destroy();
            }
        }


        public int GetDataObjectCount() {
            return _dataObjects.Count;
        }

        public DataObject GetDataObject(int index) {
            return _dataObjects[index];
        }
}
}