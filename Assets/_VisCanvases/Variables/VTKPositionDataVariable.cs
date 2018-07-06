using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class VTKPositionDataVariable : DataVariable {
	

	public override bool IsAnchor() {
		return true;
	}

	

	public virtual DataDimensionType GetVariableDimensionType() {
		return GetDataSet().GetDataDimensionType();
	}

}
}
