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

	[SerializeField]
	GameObject _prefab;


	void OnDestroy() {
		// foreach(List<GameObject> l in _canvasObjects.Values) 
		// 	foreach( GameObject g in l) 
		// 		Destroy(g);
	}

	Dictionary< string, GameObject> _canvasObjects;

	public override bool HasBounds() {
		return true;
	}
	public override Bounds GetBounds() {
		return _boxBounds;
	}

	
	
	public override void DrawLayer(Canvas canvas) {
		// if(_canvasObjects == null) 
		// 	_canvasObjects = new Dictionary<string,GameObject >();
		// if(!_canvasObjects.ContainsKey("" + canvas.GetHashCode() + "_" + _prefab.GetHashCode())){
		// 	_canvasObjects[canvas] = new List<GameObject>();
		// 	GameObject canvasSpecificPrefab = Instantiate(_prefab);
		// 	canvasSpecificPrefab.transform.SetParent(canvas.GetInnerSceneTransform(),false);
		// 	_canvasObjects[canvas].Add(canvasSpecificPrefab);
		// }

		Graphics.DrawMesh(_boxMesh,canvas.GetInnerSceneTransformMatrix()*Matrix4x4.TRS(_boxBounds.center, Quaternion.identity, _boxBounds.size),GetCanvasMaterial(canvas,_boxMaterial),0);
	}
}
}

