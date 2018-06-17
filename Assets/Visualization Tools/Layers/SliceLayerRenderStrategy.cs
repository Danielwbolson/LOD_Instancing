using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using VTK;


public class SliceLayerRenderStrategy  : LayerRenderStrategy {

	public SliceLayerRenderStrategy(Layer layer, DataRenderer slicePrefab): base(layer) {
		_slicePrefab = slicePrefab;
		_slice = UnityEngine.Object.Instantiate(_slicePrefab);
		AddDataRenderer(_slice);

		//_slice.GetComponent<SliceDataRenderer>()._layer = layer;

		}
	public override void Destroy(){
		base.Destroy();
		UnityEngine.Object.DestroyImmediate(_slice);

	}

	DataRenderer _slicePrefab;
	DataRenderer _slice;
	string selectedArray; 
	
	void SetArray(int array) {
		//_slice.GetComponent<SliceDataRenderer>()._arrayId = array;
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		DataObject dataObject = GetLayer().GetDataObject();
		if(dataObject != null) {
	VTK.vtkDataSet ds = dataObject.GetDataSet();
			
			VTK.vtkPointData pd = ds.GetPointData();
			int numArrays = pd.GetNumberOfArrays();
			
			string[] options = GetLayer().GetDataObject().GetVariableList().GetVariableNames();


			int selected = 0;
			int s = 0;
			foreach (string x in options)
			{
				if (x.Equals (selectedArray))
				{
					selected = s; 
				}
				s++;
			}
			int s2 = selected;
			selected = EditorGUILayout.Popup("Choose variable:", selected, options);
			if(selected != s2){
				SetArray(selected);
					selectedArray =  options[selected];
			} 
		} else {
			GUILayout.Label("No data variables available.");
		}
		


		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("You'll need to pick a colormap");
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}

}