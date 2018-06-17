using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


public class SliceLayerRenderStrategy  : LayerRenderStrategy {

	public SliceLayerRenderStrategy(Layer layer, GameObject slicePrefab): base(layer) {
		_slicePrefab = slicePrefab;
		_slice = UnityEngine.Object.Instantiate(_slicePrefab);
		_slice.GetComponent<DV.DVDataSliceLayer>()._layer = layer;

		}
	public override void Destroy(){
		base.Destroy();
		UnityEngine.Object.DestroyImmediate(_slice);

	}

	GameObject _slicePrefab;
	GameObject _slice;
	string selectedArray; 
	
	void SetArray(int array) {
		_slice.GetComponent<DV.DVDataSliceLayer>()._arrayId = array;
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
			VTK.vtkDataSet ds = GetLayer().GetLayerDataStrategy().GetDataObject().GetDataSet();
			VTK.vtkPointData pd = ds.GetPointData();
			int numArrays = pd.GetNumberOfArrays();
			
			string[] options = new string[numArrays];

			for(int i  = 0; i < numArrays; i++) {
				options[i] = pd.GetArrayName(i);
			}
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
				Debug.Log(s2 + " " + selected.ToString());
				SetArray(selected);
					selectedArray =  options[selected];
			} 


		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("You'll need to pick a colormap");
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}

}