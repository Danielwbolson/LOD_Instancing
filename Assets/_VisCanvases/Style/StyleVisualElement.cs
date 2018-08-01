using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleVisualElement : StyleModule {
        public StyleVisualElement Init(VisualElement visualElement) {
			_visualElement = visualElement;
			AddSocket((new StyleSocket()).Init("",this,false,true,_visualElement));

            return this;
        }

		[SerializeField]
		VisualElement _visualElement;
        
		public VisualElement GetVisualElement() {return _visualElement;}
		public override string GetLabel() {
			if(_visualElement != null && _visualElement.GetName() != "") return _visualElement.GetName();
			return  "Visual Element";
		}

	}
}

