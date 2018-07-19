using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public abstract class DataVariable : Variable {
	
	[SerializeField]
	Dataset _dataset;

	[SerializeField]
	Datastream _datastream;

	public  void Init(Dataset dataset)
    {
		base.Init();
		_dataset = dataset;

    }
	public override Variable GetAnchorVariable() {
		return _dataset.GetAnchor();
	}
    public void SetStream(Datastream datastream) {
        _datastream = datastream;
    }
    public override Datastream GetStream(DataVariable anchor, int instanceID, int timestep) {
            return _datastream;
		
	}

	public override Vector3 GetMin() {
		return GetDataSet().GetMin(this);
	}
	public override Vector3 GetMax() {
		return GetDataSet().GetMax(this);
	}
	

	protected Dataset GetDataSet() {
		return _dataset;
	}
	public override Bounds GetBounds() {
		return GetDataSet().GetBounds();
	}
	public override bool IsAnchor() {
		return false;
	}

	public override string GetName() {
		return _dataset.GetVariableName(this);
	}

	public override int GetComponents() {
		return GetDataSet().GetVariableComponents(this) ;
	}
	public override int GetDomainDimensionality() {
		return GetDataSet().GetDomainDimensionality();
	}

	public override void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		_dataset.Bind(this, material, bindSlot, instanceID, timeStep);
	}

	public override DataDimensionType GetVariableType() {
		return GetDataSet().GetDataDimensionType();
	}

}
}
