using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
namespace DEPRECATED{

[System.Serializable]
public class PlaceholderLayerRenderStrategy  : LayerRenderStrategy {
	public PlaceholderLayerRenderStrategy(Layer layer): base(layer) {}

	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.Label("This layer type does not have any render settings.");
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}

}
}