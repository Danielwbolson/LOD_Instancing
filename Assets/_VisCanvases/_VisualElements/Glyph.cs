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
		Texture2D[] _bumpMaps;


		public int GetNumberOfLODs() {
			if(_lodMeshes != null) return _lodMeshes.Length;
			return 0;
		}

		public Mesh GetLODMesh(int level) {
			return _lodMeshes[level];
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
				for (int f = 0; f < fileInfo.Length; f++){
					Debug.Log(fileInfo[f].Name);
					if(fileInfo[f].Extension.ToUpper() == ".PNG") {
						Texture2D loadedImage = new Texture2D(1,1);
						loadedImage.LoadImage(File.ReadAllBytes(fileInfo[f].Name));
						glyph._thumbnail = loadedImage;					
					}

					if(fileInfo[f].Extension.ToUpper() == ".OBJ") {
						if(Path.GetFileNameWithoutExtension(fileInfo[f].FullName) .Contains("_LOD")) {
							Debug.Log("Mesh Loading does not currently support individual LOD meshes.");

						} else {
							string objPath = fileInfo[f].FullName;
							GameObject LODmesh = OBJLoader.LoadOBJFile(objPath);

							foreach( MeshFilter mf in LODmesh.GetComponentsInChildren<MeshFilter>()) {
								Debug.Log(mf.mesh);
							}

						}
					}
					

					
				}




				Debug.Log("loading a Glyph...");

				// string thumbnailPath = Path.Combine(filePath,name+".png");

				// string bumpMapDirectiryPath =  Path.Combine(filePath,"NormalMaps");

				// if(File.Exists(thumbnailPath)) {
				// 	Texture2D loadedImage = new Texture2D(1,1);
				// 	loadedImage.LoadImage(File.ReadAllBytes(thumbnailPath));
				// 	glyph._thumbnail = loadedImage;
				// } 





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
