using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleTestLayer : StyleLayer {

        public StyleTestLayer Init() {
			

			AddSocket(CreateInstance<StyleVariableSocket>().Init("Data",this,true,false));

            return this;
        }

        
		public override string GetLabel() {
			return "Test Layer";
		}

	}
}

