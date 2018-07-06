using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class DataVariable : Variable {
	
	[SerializeField]
	Dataset _dataset;
	public  void Init(Dataset dataset)
    {
		base.Init();
		_dataset = dataset;

    }
	// public virtual bool SetDataset(dataset) {
	// 	_dataset = dataset;
	// }
	protected Dataset GetDataSet() {
		return _dataset;
	}

	public override bool IsAnchor() {
		return false;
	}

	public override string GetName() {
		return _dataset.GetVariableName(this);
	}

	public override int GetDimensionality() {
		return GetDataSet().GetVariableDimensions(this) ;
	}

	public override void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		_dataset.Bind(this, material, bindSlot, instanceID, timeStep);
	}

	public override DataDimensionType GetVariableType() {
		return GetDataSet().GetDataDimensionType();
	}

}
}
