using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
namespace DEPRECATED{

[Serializable]
public abstract class Strategy : ScriptableObject {
	public int test;
	[SerializeField]
	public Layer _layer;
	public Layer GetLayer() {
		return _layer;
	}
	public Strategy(Layer layer) {
		_layer = layer;
	}
	public virtual void Destroy() {}

	public abstract void RenderGUI();

}
}