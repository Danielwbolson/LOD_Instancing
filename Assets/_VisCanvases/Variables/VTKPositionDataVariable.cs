using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class VTKPositionDataVariable : DataVariable {
	
	public override bool IsPointVariable() {
		return true;
	}
	public override bool IsCellVariable() {
		return false;
	}

	public override bool IsAnchor() {
		return true;
	}

}
}
