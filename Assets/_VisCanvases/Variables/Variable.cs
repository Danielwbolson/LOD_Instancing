using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
	public enum DataDimensionType {
		Point = 0,
		Path = 1,
		Mesh = 2,
		Volume = 3,
		Unknown = -1,
	}

public class Variable : ScriptableObject {


	public override string ToString()
    {
		return GetVariableType() + (GetDimensionality() == 1 ? " scalar" : " "+GetDimensionality() + "D vector")  + (IsAnchor()? " anchor" : "") + " variable \"" + GetName() + "\""; 
    } 

	public void Init() {

	}
	public virtual DataDimensionType GetVariableType() {
		return DataDimensionType.Unknown;
	}

	public virtual bool IsAnchor() {
		return false;
	}

	public virtual string GetName() {
		return "Unknown";
	}

	public virtual int GetDimensionality() {
		return 0;
	}

	public virtual void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		
	}


}
}
