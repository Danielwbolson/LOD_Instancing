using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace SculptingVis {
	public class Glyph : VisualElement {

		static Texture2D _defaultNormalMap;
		static Texture2D DefaultNormalMap() {
			if(_defaultNormalMap == null) {
				_defaultNormalMap = new Texture2D(1,1);
				_defaultNormalMap.SetPixel(0,0,new Color(0.5f,0.5f,1.0f));
			}
			return _defaultNormalMap;
		}
		[SerializeField]
		Texture2D _thumbnail;

		[SerializeField]
		Mesh[] _lodMeshes;

		[SerializeField]
		Texture2D[] _normalMaps;


		public int GetNumberOfLODs() {
			if(_lodMeshes != null) return _lodMeshes.Length;
			return 0;
		}

		public Mesh GetLODMesh(int level) {
			return _lodMeshes[level];
		}

		public Texture2D GetLODNormalMap(int level) {
			return _normalMaps[level];
		}

		
		public static VisualElement LoadFile(string filePath) {
			
			string extention = Path.GetExtension(filePath);
           
			if(extention.ToUpper() == ".GLYPH") {

				Glyph glyph = CreateInstance<Glyph>();
				string name = Path.GetFileNameWithoutExtension(filePath);
				glyph.SetName(name);

				DirectoryInfo info = new DirectoryInfo(filePath);
				FileInfo[] fileInfo = info.GetFiles();
				DirectoryInfo[] directoryInfo = info.GetDirectories();
				foreach (var file in fileInfo){
					if(file.Extension.ToUpper() == ".PNG") {
						Texture2D loadedImage = new Texture2D(1,1);
						loadedImage.LoadImage(File.ReadAllBytes(file.FullName));
						glyph._thumbnail = loadedImage;					
					}

					if(file.Extension.ToUpper() == ".OBJ") {
						if(Path.GetFileNameWithoutExtension(file.FullName) .Contains("_LOD")) {
							Debug.Log("Mesh Loading does not currently support individual LOD meshes.");

						} else {
							string objPath = file.FullName;
							Mesh[] meshes = OBJLoader.LoadOBJFileToMeshes(objPath);
							glyph._lodMeshes = meshes;
						}
					}
				}

				glyph._normalMaps = new Texture2D[glyph._lodMeshes.Length];
				for(int t = 0; t < glyph._normalMaps.Length;t++) {
					glyph._normalMaps[t] = DefaultNormalMap();
				}
                foreach (var directory in directoryInfo)
                {
                    if (directory.Name.ToUpper() == "NORMALMAPS")
                    {
                        DirectoryInfo normalMapDir = new DirectoryInfo(directory.FullName);
                        foreach (var file in normalMapDir.GetFiles())
                        {
                            if (file.Extension.ToUpper() == ".PNG" && file.Name.ToUpper().StartsWith("LOD"))
                            {
								string number = Path.GetFileNameWithoutExtension(file.FullName).Substring(3); 
								int level = int.Parse(number);

								Texture2D normalMap = new Texture2D(1, 1);
								normalMap.LoadImage(File.ReadAllBytes(file.FullName));
								glyph._normalMaps[glyph._normalMaps.Length - level - 1] = normalMap;
							
                            }
                        }
                    }
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
