using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[CreateAssetMenu()]
public class PlaceholderLayerRenderStrategyFactory : LayerRenderStrategyFactory  {
		public override LayerRenderStrategy Create(Layer layer) {
		return new PlaceholderLayerRenderStrategy(layer);
	}
}