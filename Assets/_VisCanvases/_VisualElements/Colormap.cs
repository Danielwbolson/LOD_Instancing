using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace SculptingVis {
	public class Colormap : VisualElement {
		[SerializeField]
		Texture2D _texture;

		public Texture2D GetTexture() {
			return _texture;
		}
		protected Colormap Init(Texture2D texture) {
			_texture = texture;
			return this;
		}
		public new static VisualElement LoadFile(string filePath) {
			
            string extention = Path.GetExtension(filePath);
           
			if(extention.ToUpper() == ".PNG") {
				Colormap result = null;
				Texture2D loadedImage = new Texture2D(1,1);
				loadedImage.LoadImage(File.ReadAllBytes(filePath));
				result = CreateInstance<Colormap>().Init(loadedImage);
				return result;
			}

			if(extention.ToUpper() == ".XML") {
				Debug.Log("No algorithm for opening XML colormap");
				// Read XML file and produce a Texture2D
			}

			if(extention.ToUpper() == ".JSON") {
				Debug.Log("No algorithm for opening JSON colormap");

				// Read XML file and produce a Texture2D
			}

			if(extention.ToUpper() == ".TXT") {
				Debug.Log("No algorithm for opening plain text colormap");

				// Read XML file and produce a Texture2D
			}
			return null;
		}
	}
}
