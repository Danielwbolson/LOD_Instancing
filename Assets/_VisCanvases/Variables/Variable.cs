using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	public enum DataDimensionType {
		Point = 0,
		Path = 1,
		Mesh = 2,
		Volume = 3,
		Unknown = -1,
	}

public abstract class Variable : ScriptableObject {


	// protected abstract Datastream generateDatastream();

	public virtual Datastream GetStream(DataVariable anchor, int instanceID = -1, int timestep = -1) {
		return null;
	}
	public override string ToString()
    {
		return GetVariableType() + (GetComponents() == 1 ? " scalar" : " "+GetComponents() + "D vector")  + (IsAnchor()? " anchor" : "") + " variable \"" + GetName() + "\""; 
    } 

	public void Init() {

	}
	public abstract bool IsCellVariable();

	public abstract bool IsPointVariable();
	
	public abstract Vector3 GetMin();
	public abstract Vector3 GetMax();

	public abstract Bounds GetBounds();

	public virtual DataDimensionType GetVariableType() {
		return DataDimensionType.Unknown;
	}

	public virtual bool IsAnchor() {
		return false;
	}

	public virtual string GetName() {
		return "Unknown";
	}
	
	public virtual int GetComponents() {
		return 0;
	}
	public virtual int GetDomainDimensionality() {
		return 0;
	}
	public virtual void Bind(Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		
	}


}
}
