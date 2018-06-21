using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using VTK;


public class GlyphLayerRenderStrategy  : LayerRenderStrategy {

	[SerializeField]
	List<GameObject> _glyphMeshes;
	
	[SerializeField]
	DV.DVSampleStrategy _sampleStrategy;

	public GlyphLayerRenderStrategy(Layer layer, List<GameObject> meshes, Material glyphMaterial): base(layer) {
			_glyphMeshes = meshes;
			SetMaterial(Instantiate(glyphMaterial));
			
		}


	public override void UpdateRender() {
		base.UpdateRender();

		
		Mesh M = _glyphMeshes[0].GetComponentInChildren<MeshFilter>().sharedMesh;


		// Bounds b = GetLayer().GetDataObject().GetBounds();
	 	Graphics.DrawMesh(M, GetLayer().GetDataObject().GetBoundsMatrix(),GetMaterial(),0);
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