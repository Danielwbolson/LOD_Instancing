using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;


public class Image3DLayerDataStrategy : LayerDataStrategy {
	public Image3DLayerDataStrategy(Layer layer) : base(layer) {
		
		_database = layer.GetLayerManager().GetDatabase();;
	}
	public override DataObject GetDataObject() {return _dataObject;}
	[SerializeField]
	Database	_database;
	DataObject _dataObject;
	
	List<DataObject> GetAvailableDataObjects() {
		List<DataObject> dataObjects = new List<DataObject>();

		for(int i = 0; i < _database.GetDataObjectCount(); i++) {
			if(_database.GetDataObject(i).GetDataSet().IsA("vtkImageData"))
				dataObjects.Add(_database.GetDataObject(i));
		}

		return dataObjects;
	}
	VTK.vtkDataSet _dataSet = IntPtr.Zero;
	string _datasetName = "";

	void SetDataObject(DataObject dataObject) {
		_dataObject = dataObject;
		
	}

	public override Bounds GetBounds() {
		if(!_dataSet.IsVoid())
			return _dataSet.GetBounds();
		else 
			return new Bounds(new Vector3(0,0,0), new Vector3(1,1,1));
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		List<DataObject> dataObjects = GetAvailableDataObjects();
		if(dataObjects.Count == 0) {
			GUILayout.Label("No image datasets available.");
		} else {
			string[] options = new string[dataObjects.Count];

			for(int i  = 0; i < dataObjects.Count; i++) {
				options[i] = Path.GetFileName(_database.GetDataObject(i).GetFilePath());
			}
			int selected = 0;
			int s = 0;
			foreach (string x in options)
			{
				if (x.Equals (_datasetName))
				{
					selected = s; 
				}
				s++;
			}
			int s2 = selected;
			selected = EditorGUILayout.Popup("Choose dataset:", selected, options);
			if(selected != s2 || (_dataSet!= null && _dataSet.IsVoid() && options.Length > 0) ){
				SetDataObject(GetAvailableDataObjects()[selected]);

			} 
		}
	  

		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}

}