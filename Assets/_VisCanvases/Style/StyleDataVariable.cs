using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleDataVariable : StyleVariable {

        public StyleDataVariable Init(Variable variable) {
			_variable = variable;
			AddSocket((new StyleSocket()).Init("",this,false,true,_variable));
			AddSocket((new StyleSocket()).Init("Hook for deriving",this,false,true,_variable));

            return this;
        }

        
		public override string GetLabel() {
			return _variable + "";
		}

	}
}

