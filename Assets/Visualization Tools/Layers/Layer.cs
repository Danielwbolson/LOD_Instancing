using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[Serializable]
public class Layer {

		DataObject _dataObject = null;
	
	public LayerManager GetLayerManager() {
		return _layerManager;
	}
	public DataObject GetDataObject() {
		if(_dataObject == null) {
			_dataObject = _layerDataStrategy.GetDataObject();
		}	
		return _dataObject;
	}
	public void SetDataObject(DataObject dataObject) {
		_dataObject = dataObject;
	}
	public LayerRenderStrategy GetLayerRenderStrategy() {
		return _layerRenderStrategy;
	}
	public LayerDataStrategy GetLayerDataStrategy() {
		return _layerDataStrategy;
	}
	public Layer(LayerManager layerManager) {
		_layerManager = layerManager;
	}
	private LayerManager _layerManager;
	private LayerType _type;

	private LayerRenderStrategy _layerRenderStrategy;
	private LayerDataStrategy _layerDataStrategy;
	

	public void SetLayerType(LayerType type) {
		_type = type;
		_layerRenderStrategy = type.CreateRenderStrategy(this);
		_layerDataStrategy = type.CreateDataStrategy(this);
	}
	public string GetLayerTypeName() {return _type != null ? _type.GetName() : "No type specified"; }


	public void RenderGUI() {
		EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
		if(_layerDataStrategy!=null) _layerDataStrategy.RenderGUI();
		EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
		if(_layerRenderStrategy!=null)_layerRenderStrategy.RenderGUI();

    }

	public void Destroy() {
		Debug.Log("Removing layer " + this );
		_layerDataStrategy.Destroy();
		_layerRenderStrategy.Destroy();
	}


	 ~Layer()
    {
        Destroy();
    }
}