using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {

public class Layer : ScriptableObject {

	[SerializeField, HideInInspector]
	Dictionary<Canvas, Material> _canvasMaterials;

	[SerializeField]
	bool _visible;

	[SerializeField]
	bool _active;
	protected void ClearSockets() {
		_sockets = null;
	}
	VariableSocket _anchorSocket;
	protected void SetAnchorSocket(VariableSocket anchorSocket) {
		_anchorSocket = anchorSocket;
	}
	public VariableSocket GetAnchorSocket() {
		return _anchorSocket;
	}
	public bool HasAnchor() {
		return _anchorSocket != null;
	}
	List<VariableSocket> _sockets;
	public List<VariableSocket> GetSockets() {
		if(_sockets== null) _sockets = new List<VariableSocket>();
		return _sockets;
	}
	protected Material GetCanvasMaterial(Canvas canvas, Material layerMaterial) {
		if(layerMaterial == null) {
			Debug.LogError("Layer Material is null");
			return null;
		}
		if(_canvasMaterials == null) 
			_canvasMaterials = new Dictionary<Canvas, Material>();
		Material canvasMaterial;
		
		if(!_canvasMaterials.ContainsKey(canvas) ||_canvasMaterials[canvas] == null ) 
			canvasMaterial = (_canvasMaterials[canvas] = Instantiate(layerMaterial));
		else 
			canvasMaterial = _canvasMaterials[canvas];

		canvasMaterial.CopyPropertiesFromMaterial(layerMaterial);
		canvas.SetMaterialProperties(canvasMaterial);
		return canvasMaterial;
	}
	public virtual bool HasBounds() {
		return false;
	}
	public virtual Bounds GetBounds() {
		return new Bounds();
	}

	public virtual void DrawLayer(Canvas canvas) {

	}
}
}

