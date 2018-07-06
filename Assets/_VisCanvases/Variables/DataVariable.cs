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

	public override bool IsVector() {
		return false;
	}

	public override bool IsScalar() {
		return false;
	}

	public override void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		_dataset.Bind(this, material, bindSlot, instanceID, timeStep);
	}

	
	public override VariableType GetVariableType() {
		if(GetDataSet().IsVolume()) {
			return VariableType.Volume;
		} else if(GetDataSet().IsMesh()) {
			return VariableType.Mesh;
		} else if(GetDataSet().IsPath()) {
			return VariableType.Path;
		} else  return VariableType.Unknown;
	}

}
}
