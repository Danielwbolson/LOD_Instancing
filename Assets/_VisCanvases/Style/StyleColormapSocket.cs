using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleColormapSocket : StyleSocket {
		public override bool DoesAccept(StyleSocket incoming) {
			return incoming.GetOutput() is Texture2D;
		}

		public Texture2D GetTexture() {
			return (Texture2D)_input;
		}
		
	}
}

