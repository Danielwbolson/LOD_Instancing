using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[CreateAssetMenu()]
public class PlaceholderLayerDataStrategyFactory : LayerDataStrategyFactory {
	public override LayerDataStrategy Create(Layer layer) {
		return new PlaceholderLayerDataStrategy(layer);
	}
}
