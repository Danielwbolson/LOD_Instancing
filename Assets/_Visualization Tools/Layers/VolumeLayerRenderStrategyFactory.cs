using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu()]
public class VolumeLayerRenderStrategyFactory : LayerRenderStrategyFactory {
	[SerializeField]
	public Mesh _volumeMesh;
	public Material _volumeMaterial;
	public override LayerRenderStrategy Create(Layer layer) {
		return new VolumeLayerRenderStrategy(layer,_volumeMesh, _volumeMaterial );
	}
}