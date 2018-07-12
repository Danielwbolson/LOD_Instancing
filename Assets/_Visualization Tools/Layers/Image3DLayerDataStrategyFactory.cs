using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
namespace DEPRECATED{

[CreateAssetMenu()]
public class Image3DLayerDataStrategyFactory : LayerDataStrategyFactory {
	[SerializeField]
	public override LayerDataStrategy Create(Layer layer) {
		return new Image3DLayerDataStrategy(layer);
	}
}
}