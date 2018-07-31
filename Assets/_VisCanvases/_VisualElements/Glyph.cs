using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace SculptingVis {
	public class Glyph : VisualElement {


		Texture2D _thumbnail;

		List<Mesh> _lodMeshes;

		List<Texture2D> _bumpMaps;


		public static VisualElement LoadFile(string filePath) {
			
			string extention = Path.GetExtension(filePath);
           
			if(extention.ToUpper() == ".GLYPH") {
				Glyph glyph = CreateInstance<Glyph>();
				string name = Path.GetFileNameWithoutExtension(filePath);
				glyph.SetName(name);

				Debug.Log("loading a Glyph...");

				string thumbnailPath = Path.Combine(filePath,name+".png");

				string bumpMapDirectiryPath =  Path.Combine(filePath,"NormalMaps");

				if(File.Exists(thumbnailPath)) {
					Texture2D loadedImage = new Texture2D(1,1);
					loadedImage.LoadImage(File.ReadAllBytes(thumbnailPath));
					glyph._thumbnail = loadedImage;
				} 


				return glyph;
			}


			return null;
		}



		public override Texture2D GetPreviewImage() {
			return _thumbnail;
		}

		public override float GetPreviewImageAspectRatio() {
			return 1.0f;
		}


	}
}
