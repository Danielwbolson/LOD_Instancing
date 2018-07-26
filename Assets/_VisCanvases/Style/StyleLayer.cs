using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleLayer : StyleModule {
        public StyleLayer Init() {
            return this;
        }

        
		public override string GetLabel() {
			return "Layer";
		}

	}
}

