using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {

[CreateAssetMenu()]
public class Style : ScriptableObject {

	[SerializeField]
	Material _styleOriginMaterial;

	[SerializeField]
	List<Layer> _layers;

	public void ApplyStyle(Canvas canvas) {

		//Graphics.DrawMesh(_styleIndicatorMesh,canvas.GetInnerSceneTransformMatrix(),_styleOriginMaterial,0);
		foreach(var layer in _layers) {
			layer.DrawLayer(canvas);
		}
	}


	public bool HasBounds() {
		if(_layers != null) {
			foreach(var layer in _layers) {
				if(layer.HasBounds())
					return true;
			}
		}
		return false;
	}
	public Bounds GetBounds() {
		Bounds allLayerBounds = new Bounds();
		bool empty = true;
		if(_layers != null && _layers.Count > 0) {
			int numLayers = _layers.Count;
			for(int i = 0; i < numLayers; i++) {
				if(_layers[i].HasBounds()) {
					if(empty) {
						allLayerBounds = _layers[i].GetBounds();
						empty = false;
					} else {
						allLayerBounds.Encapsulate(_layers[i].GetBounds());
					}
				}
			}
		}
		return allLayerBounds;
	}

}

}
