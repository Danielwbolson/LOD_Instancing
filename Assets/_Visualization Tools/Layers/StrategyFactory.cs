using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


public abstract class StrategyFactory<T> : ScriptableObject {
	private Layer _layer;

	public abstract T Create(Layer layer);
	public void SetLayer(Layer l) {
		_layer = l;
	}
}