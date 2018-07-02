using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class Variable : ScriptableObject {
	public enum VariableType {
		Unknown = 0,
		Volume,
		Mesh,
		Path,
	}

	public virtual VariableType GetVariableType() {
		return VariableType.Unknown;
	}

	public virtual bool IsAnchor() {
		return false;
	}

	public virtual string GetName() {
		return "Unknown";
	}

	public virtual bool IsVector() {
		return false;
	}

	public virtual bool IsScalar() {
		return false;
	}

	public virtual void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		
	}


}
}
