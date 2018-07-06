using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public abstract class Dataset : ScriptableObject {

	[SerializeField]
	private HashSet<DataVariable> _variables;

	protected virtual bool validateVariable(DataVariable variable) {
		return _variables.Contains(variable);
	} 
	public virtual void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!_variables.Contains(variable)) {
			Debug.LogError("Data set does not contain variable.");
		}
	}

	protected virtual int queryNumberOfVariables() {
		return 0;
	}
	protected virtual Variable generateVarible(int i) {
		return null;
	}
	protected void populateVariables() {
		int numVariables = queryNumberOfVariables();
		for(int v = 0; v < numVariables; v++) {

		}
	}
	public virtual string GetVariableName(DataVariable variable) {
		if(!_variables.Contains(variable)) {
			Debug.LogError("Data set does not contain variable.");
		}
		return "Unknown";
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
