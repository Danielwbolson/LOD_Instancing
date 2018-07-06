using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public abstract class Dataset : ScriptableObject {

	[SerializeField]
	private HashSet<DataVariable> _variables;

	[SerializeField]
	private HashSet<DataVariable> _anchors;

	protected virtual bool validateVariable(DataVariable variable) {
		return (_variables!= null) && _variables.Contains(variable);
	} 
	public virtual void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!_variables.Contains(variable)) {
			Debug.LogError("Data set does not contain variable.");
		}
	}
	public abstract void LoadDataset();

	protected virtual int queryNumberOfVariables() {
		return 0;
	}
	protected virtual DataVariable generateVarible(int i) {
		return null;
	}
	protected void populateVariables() {

		int numVariables = queryNumberOfVariables();
		for(int v = 0; v < numVariables; v++) {
            DataVariable var = generateVarible(v);
			addVariable(var);
		}
	}

	protected void addVariable(DataVariable variable) {
		if(variable.IsAnchor()) {
			if(_anchors == null) _anchors = new HashSet<DataVariable>();
			_anchors.Add(variable);
		} else {
			if(_variables == null) _variables = new HashSet<DataVariable>();
			_variables.Add(variable);
		}
	}
	public DataVariable[] GetVariables() {
		DataVariable [] output = new DataVariable[_variables.Count];
		_variables.CopyTo(output);
		return output;
	}
	public virtual string GetVariableName(DataVariable variable) {
		if(!_variables.Contains(variable)) {
			Debug.LogError("Data set does not contain variable.");
		}
		return "Unknown";
	}
	public virtual int GetVariableDimensions(DataVariable variable) {
		if(!_variables.Contains(variable)) {
			Debug.LogError("Data set does not contain variable.");
		}
		return 0;
	}
	public virtual DataDimensionType GetDataDimensionType() {
		if(IsVolume()) {
			return DataDimensionType.Volume;
		} 
		else if(IsMesh()) {
			return DataDimensionType.Mesh;
		} else if(IsPath()) {
			return DataDimensionType.Path;
		} else if (IsPoint()) {
			return DataDimensionType.Point;
		} else 
			return DataDimensionType.Unknown;
	}
		
	public virtual bool IsPoint() {
		return false;
	}

	public virtual bool IsPath() {
		return false;
	}

	public virtual bool IsMesh() {
		return false;
	}

	public virtual bool IsVolume() {
		return false; 
	}

	public abstract bool IsVector(DataVariable variable);

}
}
