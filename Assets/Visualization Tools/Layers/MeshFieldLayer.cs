﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu()]

public class MeshFieldLayer : Layer {

	public int meshCount; 

	public override void RenderGUI() {
		EditorGUILayout.IntField("Number of glyphs:", meshCount);
	}

}
