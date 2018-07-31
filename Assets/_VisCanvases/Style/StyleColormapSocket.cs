using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleColormapSocket : StyleSocket {
		public override bool DoesAccept(StyleSocket incoming) {
			return incoming.GetOutput() is Colormap;
		}

		public Texture2D GetTexture() {
			return (Texture2D)_input;
		}
		
	}
}

