using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace DEPRECATED{

[CreateAssetMenu()]
public class PlaceholderLayerRenderStrategyFactory : LayerRenderStrategyFactory  {
		public override LayerRenderStrategy Create(Layer layer) {
		return new PlaceholderLayerRenderStrategy(layer);
	}
}
}