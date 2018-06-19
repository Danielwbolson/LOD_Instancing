using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu()]
public class VolumeLayerRenderStrategyFactory : LayerRenderStrategyFactory {
	[SerializeField]
	
	public override LayerRenderStrategy Create(Layer layer) {
		return new VolumeLayerRenderStrategy(layer);
	}
}