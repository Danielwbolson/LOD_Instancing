using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu()]
public class GlyphLayerRenderStrategyFactory : LayerRenderStrategyFactory {
	[SerializeField]
	public List<GameObject> _glyphMeshes;
	public Material _glyphMaterial;
	public override LayerRenderStrategy Create(Layer layer) {
		return new GlyphLayerRenderStrategy(layer,_glyphMeshes, _glyphMaterial );
	}
}