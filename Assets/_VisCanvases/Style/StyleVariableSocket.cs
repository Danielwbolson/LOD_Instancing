using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleVariableSocket : StyleSocket {
		public override bool DoesAccept(StyleSocket incoming) {
			return incoming.GetOutput() is Variable;
		}
		
	}
}

