using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleVariable : StyleModule {
		[SerializeField]
		protected Variable _variable;


        
		public override string GetLabel() {
			return _variable + "";
		}

	}
}

