using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public abstract class LayerRenderStrategy : Strategy {

	public LayerRenderStrategy(Layer layer): base(layer) {}
	[UnityEngine.SerializeField]
	List<DataRenderer> _dataRenderers;



	public virtual void SetupRender() {
		
	}

	public virtual void UpdateRender() {

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
