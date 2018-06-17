using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CreateAssetMenu()]
public class LayerType : ScriptableObject {
	[SerializeField]
	private string _name;

	public string GetName() {return _name;}

	[SerializeField]
	private LayerDataStrategyFactory _dataStrategyFactory;

	public LayerDataStrategy CreateDataStrategy(Layer layer) {
		return _dataStrategyFactory != null ? _dataStrategyFactory.Create(layer) : null;
	}

	[SerializeField]
	private LayerRenderStrategyFactory _renderStrategyFactory;
	public LayerRenderStrategy CreateRenderStrategy(Layer layer) {
		return _renderStrategyFactory != null ? _renderStrategyFactory.Create(layer) : null;
	}
}

