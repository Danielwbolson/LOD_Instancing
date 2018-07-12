using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace DEPRECATED{

[CreateAssetMenu()]
public class PlaceholderLayerDataStrategyFactory : LayerDataStrategyFactory {
	public override LayerDataStrategy Create(Layer layer) {
		return new PlaceholderLayerDataStrategy(layer);
	}
}

}