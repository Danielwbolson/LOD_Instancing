using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleDataVariable : StyleModule {
		Variable _variable;

        public StyleDataVariable Init(Variable variable) {
			_variable = variable;
			AddSocket(CreateInstance<StyleSocket>().Init("",this,false,true,_variable));
            return this;
        }

        
		public override string GetLabel() {
			return _variable + "";
		}

	}
}

