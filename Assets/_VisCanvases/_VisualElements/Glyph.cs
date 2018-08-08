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
			
			// Check to see if this filePath points to a Glyph package
			if(Path.GetExtension(filePath).ToUpper() == ".GLYPH") {

				// Go ahead and create the empty glyph object
				Glyph glyph = CreateInstance<Glyph>();

				// For now, name the glyph based on the file package name
				string name = Path.GetFileNameWithoutExtension(filePath);
				glyph.SetName(name);



				DirectoryInfo info = new DirectoryInfo(filePath);
				FileInfo[] fileInfo = info.GetFiles();
				DirectoryInfo[] directoryInfo = info.GetDirectories();

				// First let's iterate through the root of this package,
				// looking for thumbnail image and the OBJ
				foreach (var file in fileInfo){

					// The only PNG we expect on this level is the thumbnail...
					if(file.Extension.ToUpper() == ".PNG") {
						Texture2D loadedImage = new Texture2D(1,1);
						loadedImage.LoadImage(File.ReadAllBytes(file.FullName));
						glyph._thumbnail = loadedImage;					
					}

					// An OBJ should contain the actual meshes of our glyph. 
					// We could additionally handle individual OBJ's for 
					// each LOD, but that can be added later.
					if(file.Extension.ToUpper() == ".OBJ") {
						if(Path.GetFileNameWithoutExtension(file.FullName) .Contains("_LOD")) {
							Debug.Log("Mesh Loading does not currently support individual LOD meshes.");

						} else {
							string objPath = file.FullName;
							// Seth hacked todether the LoadOBJFileToMeshes function
							// based on LoadOBJFile, just removing the Gameobject logic
							Mesh[] meshes = OBJLoader.LoadOBJFileToMeshes(objPath);
							glyph._lodMeshes = new Mesh[meshes.Length];
							for(int i = 0; i < meshes.Length; i++) {	
								glyph._lodMeshes[meshes.Length-1 - i] = meshes[i];

							}
						}
					}
				}

				// Now that we know how many meshes there are, we can set up our 
				// normal maps, and pre-populate them with a default bump map
				glyph._normalMaps = new Texture2D[glyph._lodMeshes.Length];
				for(int t = 0; t < glyph._normalMaps.Length;t++) {
					glyph._normalMaps[t] = DefaultNormalMap();
				}

				// The only sub directory we expect right now is the normal maps, 
				// but if we have need for more we can handle them here.
				foreach (var directory in directoryInfo) {
					if (directory.Name.ToUpper() == "NORMALMAPS") {
						DirectoryInfo normalMapDir = new DirectoryInfo(directory.FullName);

						// For each file in the NormalMaps sub-directory...
						foreach (var file in normalMapDir.GetFiles()) {
							// Expect each LOD normal map to start with "LOD" followed by an integer. 
							if (file.Extension.ToUpper() == ".PNG" && file.Name.ToUpper().StartsWith("LOD")) {
								string number = Path.GetFileNameWithoutExtension(file.FullName).Substring(3); 
								int level = int.Parse(number);

								// Load the normalMap in and stick it in the list in reverse order.
								Texture2D normalMap = new Texture2D(1, 1);
								normalMap.LoadImage(File.ReadAllBytes(file.FullName));
								glyph._normalMaps[level] = normalMap;
							
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
