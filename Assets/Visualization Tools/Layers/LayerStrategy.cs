using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[Serializable]
public abstract class Strategy {
	Layer _layer;
	public Layer GetLayer() {
		return _layer;
	}
	public Strategy(Layer layer) {
		_layer = layer;
	}
	public virtual void Destroy() { isDestroyed = true;}
	private bool isDestroyed = false;
	 ~Strategy() {
		//if(!isDestroyed)
		//	Destroy();
	}
	public abstract void RenderGUI();

}