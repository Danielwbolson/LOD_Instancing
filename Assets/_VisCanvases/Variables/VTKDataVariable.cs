using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis 
{
public class VTKDataVariable : DataVariable {
	
	public enum ArrayType {
		Unknown,
		Point,
		Cell
	}
	[SerializeField]
	int _arrayID;

	[SerializeField]
	ArrayType _arrayType;

	public void Init(VTKDataset dataset, ArrayType arrayType, int arrayID) {
		base.Init(dataset);


  //      VTKDatastreamChannel vtkchannel = CreateInstance<VTKDatastreamChannel>();
  //      vtkchannel.Init(dataset.)
  //      Datastream stream = CreateInstance<Datastream>();
  //      stream.Init()
		//SetDatastream()
		_arrayType = arrayType;
		_arrayID = arrayID;
	}


	public bool IsCellVariable() {
		return _arrayType == ArrayType.Cell;
	}

	public bool IsPointVariable() {
		return !IsCellVariable();
	}
	
	public int GetArrayID() {
		return _arrayID;
	}


	public override bool IsAnchor() {
		return false;
	}


}
}
