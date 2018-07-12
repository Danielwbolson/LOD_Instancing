using System.Collections.Generic;
using UnityEngine;
using System;

namespace DEPRECATED{
[System.Serializable]
public abstract class LayerRenderStrategy : Strategy {

	public LayerRenderStrategy(Layer layer): base(layer) {}
	[UnityEngine.SerializeField]
	List<DataRenderer> _dataRenderers;
	[SerializeField]
	Material _material;

	public void SetMaterial(Material material) {
		_material = material;
	}
	public Material GetMaterial() {
		return _material;
	}
	public virtual void SetupRender() {
		
	}

	public virtual void UpdateRender() {
		if(_material) {
			_material.SetMatrix("_DataModelMatrix", GetLayer().GetDataObject().transform.localToWorldMatrix);
			_material.SetMatrix("_DataModelMatrixInv", GetLayer().GetDataObject().transform.worldToLocalMatrix);
			_material.SetMatrix("_DataBoundsMatrix", GetLayer().GetDataObject().GetBoundsMatrix());
			_material.SetMatrix("_DataBoundsMatrixInv", GetLayer().GetDataObject().GetBoundsMatrix().inverse);

			for(int v = 0; v < GetVariableCount(); v++) {
				Vector4 min = GetVariable(v).GetMinValue();
				Vector4 max = GetVariable(v).GetMaxValue();
				_material.SetVector("_DataMin" + v, min);
				_material.SetVector("_DataMax" + v, max);
				_material.SetInt("_VariableStorage" + v, (int)GetVariable(v).GetStorageType());
				_material.SetInt("_VariableType" + v, (int)GetVariable(v).GetVariableType());

				if(GetVariable(v).GetStorageType() == Variable.StorageType.TEXTURE) {
					Texture t = GetLayer().GetDataObject().GetImageDataTexture(GetLayer().GetLayerRenderStrategy().GetVariable(v).GetVariableIndex());
					_material.SetTexture("_DataVolume" + v, t);
				} else {
					
				}
			}
		}
	}
	
	public virtual void DrawGizmos() {

	}
	protected void AddDataRenderer(DataRenderer dataRenderer) {
		if(_dataRenderers == null) _dataRenderers = new List<DataRenderer>();
		dataRenderer.SetLayerRenderStrategy(this);
		_dataRenderers.Add(dataRenderer);
	}

	[SerializeField]
	List<Variable> _variables;



	public int GetVariableCount() {
		return _variables != null?  _variables.Count : 0;
	}
	protected void AddVariable(Variable v) {
		if(_variables == null) _variables = new List<Variable>();
		_variables.Add(v);
	}
	protected void SetVariable(Variable v, int index) {
		while(index >= GetVariableCount()) 
			AddVariable(null);
		_variables[index] = v;
		if(_dataRenderers!=null)
			foreach(var dr in _dataRenderers) 
				dr.RefreshData();
	}
	public Variable GetVariable(int index = 0) {
		if(index >= GetVariableCount()) return null;
		return _variables[index];
	}
	public override void Destroy() {
		if(_dataRenderers != null)
			for(int i = _dataRenderers.Count-1; i >= 0; i--) 
				if(_dataRenderers[i] != null && _dataRenderers[i].GetLayer() != null) {
					DataRenderer dr = _dataRenderers[i];
					dr.Destroy();
				}
		base.Destroy();
	}

}

}