using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using VTK;

namespace DEPRECATED{

public class VolumeLayerRenderStrategy  : LayerRenderStrategy {

	[SerializeField]
	Mesh _cubeMesh;
	
	public VolumeLayerRenderStrategy(Layer layer, Mesh cube, Material volumeMaterial): base(layer) {
			_cubeMesh = cube;
			SetMaterial(Instantiate(volumeMaterial));
		}


	public override void UpdateRender() {
		base.UpdateRender();
        // Material _material = _volumeMaterial;
        // _material.SetMatrix("_DataModelMatrix", GetLayer().GetDataObject().transform.localToWorldMatrix);
        // _material.SetMatrix("_DataModelMatrixInv", GetLayer().GetDataObject().transform.worldToLocalMatrix);
        // _material.SetMatrix("_DataBoundsMatrix", GetLayer().GetDataObject().GetBoundsMatrix());
        // _material.SetMatrix("_DataBoundsMatrixInv", GetLayer().GetDataObject().GetBoundsMatrix().inverse);

        // for(int v = 0; v <  GetVariableCount(); v++) {
        //     Vector4 min = GetVariable(v).GetMinValue();
        //     Vector4 max = GetVariable(v).GetMaxValue();
        //     _material.SetVector("_DataMin" + v, min);
        //     _material.SetVector("_DataMax" + v, max);
        //     _material.SetInt("_VariableStorage" + v, (int)GetVariable(v).GetStorageType());
        //     _material.SetInt("_VariableType" + v, (int)GetVariable(v).GetVariableType());

        //     if(GetVariable(v).GetStorageType() == Variable.StorageType.TEXTURE) {
        //         Texture t = GetLayer().GetDataObject().GetImageDataTexture(GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableIndex());
        //         _material.SetTexture("_DataVolume" + v, t);
        //     } else {
                
        //     }
        // }

		

		Bounds b = GetLayer().GetDataObject().GetBounds();
		Graphics.DrawMesh(_cubeMesh, GetLayer().GetDataObject().GetBoundsMatrix(),GetMaterial(),0);
	}


	public override void DrawGizmos() {

	}

	[SerializeField]
	Variable _selectedVariable;


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
			for(int i = 0; i <  GetLayer().GetDataObject().GetVariableList().GetVariables().Count; i++)
			{
				if (GetVariable(0) != null && GetLayer().GetDataObject().GetVariableList().GetVariables()[i].GetVariableName().Equals (GetVariable(0).GetVariableName()))
				{
					selected = s; 
				}
				s++;
			}
			int s2 = selected;
			selected = EditorGUILayout.Popup("Choose variable:", selected, options);
			if(selected != s2 || GetVariable() == null){
				SetVariable(GetLayer().GetDataObject().GetVariableList().GetVariables()[selected], 0);
				
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
}