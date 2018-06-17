using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public abstract class LayerRenderStrategy : Strategy {
		[UnityEngine.SerializeField] public string hello = "hello world";
	public LayerRenderStrategy(Layer layer): base(layer) {}
	[UnityEngine.SerializeField]
	List<DataRenderer> _dataRenderers;

	protected void AddDataRenderer(DataRenderer dataRenderer) {
		if(_dataRenderers == null) _dataRenderers = new List<DataRenderer>();
		_dataRenderers.Add(dataRenderer);
	}

	public override void Destroy() {
		if(_dataRenderers != null)
			for(int i = _dataRenderers.Count-1; i >= 0; i--) 
				_dataRenderers[i].Destroy();
		base.Destroy();
	}

}
