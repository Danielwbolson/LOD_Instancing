using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class AnchorVariable : DataVariable {

	public override bool IsAnchor() {
		return true;
	}
	public override Variable GetAnchorVariable() {
		return null;
	}

		
	public override bool IsPointVariable() {
		return true;
	}
	public override bool IsCellVariable() {
		return false;
	}
}
}
