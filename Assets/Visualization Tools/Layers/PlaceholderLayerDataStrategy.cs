using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[System.Serializable]

public class PlaceholderLayerDataStrategy : LayerDataStrategy {
	public PlaceholderLayerDataStrategy(Layer layer) : base(layer) {}
	public override Bounds GetBounds() {
		return new Bounds(new Vector3(0,0,0), new Vector3(1,1,1));
	}
	public override void RenderGUI() {
		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.Label("This layer type does not have any data settings.");
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}
}
