using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SculptingVis {
[CreateAssetMenu()]
public class BoxLayer : Layer {
	[SerializeField]
	Bounds _boxBounds;

	[SerializeField]
	Mesh _boxMesh;

	[SerializeField]
	Material _boxMaterial;

	public override bool HasBounds() {
		return true;
	}
	public override Bounds GetBounds() {
		return _boxBounds;
	}

	public override void DrawLayer(Canvas canvas) {

		Graphics.DrawMesh(_boxMesh,canvas.GetInnerSceneTransformMatrix()*Matrix4x4.TRS(_boxBounds.center, Quaternion.identity, _boxBounds.size),GetCanvasMaterial(canvas,_boxMaterial),0);
	}
}
}

