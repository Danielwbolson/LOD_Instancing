using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu()]
public class SliceLayerRenderStrategyFactory : LayerRenderStrategyFactory {
	[SerializeField]
	DataRenderer _slicePrefab;
	[SerializeField]
	Material _sliceMaterial;
	
	public override LayerRenderStrategy Create(Layer layer) {
		return new SliceLayerRenderStrategy(layer, _slicePrefab, _sliceMaterial );
	}
}