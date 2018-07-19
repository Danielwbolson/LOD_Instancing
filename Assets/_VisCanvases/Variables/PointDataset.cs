using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class PointDataset : Dataset {


	[SerializeField]
	AnchorVariable _anchorVariable;

	[SerializeField]
	Bounds _bounds;
	

	public override Variable GetAnchor() {
		return _anchorVariable;
	}

	public override void SetAnchor(Variable anchor) {
		if(anchor is AnchorVariable)
		_anchorVariable = (AnchorVariable)anchor;
	}

	[SerializeField]
	int _instanceID = 0;

	[SerializeField]
	int _timestep = 0;

	int _sampleCount;
	public void Init(Variable sampleSpace, int sampleCount, int instanceID, int timestep) {

		_instanceID = instanceID;
		_timestep = timestep;

		Bounds b = sampleSpace.GetBounds();

		_bounds = b;
		_sampleCount = sampleCount;
	}
	protected override Datastream lookupDataStream(DataVariable variable, DataVariable anchor, int instanceID = 0, int timeStep = 0) {

		return null;
	}

	public override bool ContainsInstanceID(int instanceID) {
		return instanceID == _instanceID;
	}
	public override bool ContainsTimestep(int timestep) {
		return timestep == _timestep;
	}
	public override string GetVariableName(DataVariable variable) {
		
		return "Position";
	}
	protected override int queryNumberOfVariables() {
		return 0;// GetVariables().Length ;
	}
	protected override DataVariable generateVarible(int i) {
		return null;
	}
	
	protected override AnchorVariable generateAnchor() {
		AnchorVariable av =  CreateInstance<AnchorVariable>();
		av.Init(this);
		return av;
	}

	public override int GetDomainDimensionality() {
		return 0;
	}
	protected override DatastreamChannel generateDatastreamChannel(DataVariable variable) {

		if(variable is AnchorVariable) {
			PointAnchorDatastreamChannel pointChannel = CreateInstance<PointAnchorDatastreamChannel>();

			pointChannel.Init(_bounds, _sampleCount);
			return pointChannel;;
		} else {
			return null;
		}
		return null;
	}
	public void Print() {
		// if(_dataset != null) {
		// 	Debug.Log(_dataset.GetClassName());
		// 	// VTK.vtkAbstractArray abstractArray = _dataset.GetPointData()
		// 	VTK.vtkPointSet pointSet = null;
		// 	if(_dataset.IsA("vtkPointSet"))
		// 		pointSet = VTK.vtkPointSet.SafeDownCast(_dataset);
			
		// 	if(pointSet != null)
		// 		Debug.Log("<Position> " + pointSet.GetNumberOfPoints() );
		// 	for(int i = 0; i < _dataset.GetPointData().GetNumberOfArrays(); i++) {
		// 		Debug.Log(_dataset.GetPointData().GetArrayName(i) + _dataset.GetPointData().GetAbstractArray(i).GetNumberOfTuples());
		// 	}
		// }
	}
	protected override bool hasAnchor() {
		return true;
	}
	public override void LoadDataset() {
		
		populateVariables();
	}
	protected override bool validateVariable(DataVariable variable) {
		return base.validateVariable(variable) &&  variable is AnchorVariable;
	} 


	public override void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!validateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
		}
	}

	public override bool IsPath() {
		return false;
	}

	public override bool IsMesh() {
		return false;
	}

	public override bool IsVolume() {
		return false;
	}


	public override Vector3 GetMin(DataVariable variable) {
		Vector3 result = new Vector3();

		return result;
	}

	public override Vector3 GetMax(DataVariable variable) {
		Vector3 result = new Vector3();

		return result;
	}


	public override int GetVariableComponents(DataVariable variable) {
			if(!validateVariable(variable)) {
			Debug.LogError("Variable is not a valid  variable for this  dataset.");
			return -1;
		}

		 if(variable is AnchorVariable) {
			return 3;
		}
		
		return 0;
	}
	public override bool IsVector(DataVariable variable) {
		return false;
	}


	public override Bounds GetBounds() {
		if(_bounds.size == new Vector3(0,0,0));

		return _bounds;
	}
}
}
