using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	public abstract class VisualElement : ScriptableObject {
		[SerializeField]
		string _name;

		protected void SetName(string name) {
			_name = name;
		}

		public string GetName() {
			return _name;
		}



		public static VisualElement LoadFile(string filePath) {
			VisualElement result = null;
			if((result = Colormap.LoadFile(filePath)) != null)
				return result;

			if((result = Glyph.LoadFile(filePath)) != null)
				return result;

			return result;
		}

		public abstract Texture2D GetPreviewImage();

		public abstract float GetPreviewImageAspectRatio();
		
	}
}
