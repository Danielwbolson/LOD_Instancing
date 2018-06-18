using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[Serializable]
public class Layer : System.Object{

	// DataObject _dataObject = null;
	
	public LayerManager GetLayerManager() {
		return _layerManager;
	}
	public DataObject GetDataObject() {
		return  _layerDataStrategy.GetDataObject();
;
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
	[SerializeField]
	private LayerManager _layerManager;
	[SerializeField]
	private LayerType _type;

	[SerializeField]
	public LayerRenderStrategy _layerRenderStrategy;
	[SerializeField]
	public LayerDataStrategy _layerDataStrategy;
	

	public void SetLayerType(LayerType type) {
		_type = type;
		if(_layerDataStrategy != null) _layerDataStrategy.Destroy();
		if(_layerRenderStrategy != null) _layerRenderStrategy.Destroy();
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


	public Layer() {
	}
	bool destroying = false;
	public void Reset() {
			if(_layerDataStrategy != null)
			 	_layerDataStrategy.Destroy();
			if(_layerRenderStrategy != null) 
				_layerRenderStrategy.Destroy();
	}
	public void Destroy() {
		if(!destroying) {
			destroying = true;
			Reset();
			GetLayerManager().RemoveLayer(this);
		}
	}
}