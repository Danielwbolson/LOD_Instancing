using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DEPRECATED{

[CreateAssetMenu()]

public class MeshFieldLayer : LayerType {

	public int meshCount; 

	// public override void RenderGUI() {
	// 	meshCount = EditorGUILayout.IntField("Number of glyphs:", meshCount);
	// }

}
}