using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleColormap : StyleVisualElement {
		[SerializeField]
		Texture2D _colorMap;
		[SerializeField]
		string _name;

		public override string GetLabel() {
			return _name;
		}
        public StyleColormap Init(Texture2D texture,string name = "") {
			_colorMap = texture;
			_name = name;
			AddSocket(CreateInstance<StyleSocket>().Init("",this,false,true,_colorMap));
            return this;
        }

		public Texture2D GetTexture() {
			return _colorMap;
		}


	}
}

