using UnityEngine;
using System;
using System.Collections;
using System.Globalization;

/**
  x  y  z   f1   n1(1)  n1(2)  n1(3)  R1  f2   n2(1)  n2(2)  n2(3)  R2

  x, y, z are the coordinates and the total matrix size is 80x96x64. 
  f1 is the volume fraction (density) of the cylinder1, 
  n1 is a 3x1 unit vector representing cylinder1 orientation. 
  R1 is the radius of cylinder1. 

  f2, n2 and R2 describe volume fraction (density), orientation and radius of the second cylinder.
  Length of both the cylinders are a contant = 1.7e3.`
 */

public class CylinderCreator : MonoBehaviour
{
	[Tooltip ("Cube or cylinder size.")]
	public float clength = 0.4f;
	[Tooltip ("Min cube or cylinder radius")]
	public float cminwidth = 0.05f;
	[Tooltip ("Max cube or cylinder radius")]
	public float cmaxwidth = 0.3f;

	public GameObject baseVoxelCube;
	public GameObject container;

	void Start ()
	{
		int xmax = 80;
		int ymax = 96;
		int zmax = 64;

		float[,,] f1 = new float[xmax, ymax, zmax];
		Vector3[,,] n1 = new Vector3[xmax, ymax, zmax];
		float[,,] R1 = new float[xmax, ymax, zmax];

		float[,,] f2 = new float[xmax, ymax, zmax];
		Vector3[,,] n2 = new Vector3[xmax, ymax, zmax];
		float[,,] R2 = new float[xmax, ymax, zmax];


		// 1) load data
		string[] lines = System.IO.File.ReadAllLines (Application.streamingAssetsPath  + "/example_data/Resources/Zep_cyl_cyl_32.txt");
		// skip the first line, which is the header
		for (int l = 1; l < lines.Length; l++) {
			string[] values = lines [l].Split (new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
			int x = (int)(float.Parse (values [0], CultureInfo.InvariantCulture)) - 1;
			int y = (int)(float.Parse (values [1], CultureInfo.InvariantCulture)) - 1;
			int z = (int)(float.Parse (values [2], CultureInfo.InvariantCulture)) - 1;

			f1 [x, y, z] = float.Parse (values [3], CultureInfo.InvariantCulture);
			n1 [x, y, z] = new Vector3 (float.Parse (values [4], CultureInfo.InvariantCulture), float.Parse (values [5], CultureInfo.InvariantCulture), float.Parse (values [6], CultureInfo.InvariantCulture));
			R1 [x, y, z] = float.Parse (values [7], CultureInfo.InvariantCulture);

			f2 [x, y, z] = float.Parse (values [8], CultureInfo.InvariantCulture);
			n2 [x, y, z] = new Vector3 (float.Parse (values [9], CultureInfo.InvariantCulture), float.Parse (values [10], CultureInfo.InvariantCulture), float.Parse (values [11], CultureInfo.InvariantCulture));
			R2 [x, y, z] = float.Parse (values [12], CultureInfo.InvariantCulture);
		}


		// 2) calculate max values
		float fmax = 0.0f;
		float Rmax = 0.0f;
		for (int z = 0; z < zmax; z++) {
			for (int y = 0; y < ymax; y++) {
				for (int x = 0; x < xmax; x++) {
					if (f1 [x, y, z] > fmax) {
						fmax = f1 [x, y, z];
					}
					if (f2 [x, y, z] > fmax) {
						fmax = f2 [x, y, z];
					}
					if (R1 [x, y, z] > Rmax) {
						Rmax = R1 [x, y, z];
					}
					if (R2 [x, y, z] > Rmax) {
						Rmax = R2 [x, y, z];
					}
				}
			}
		}


		// 3) create geometry
		for (int z = 31; z < 32; z++) {
			for (int y = 0; y < ymax; y++) {
				for (int x = 0; x < xmax; x++) {

					// skip empty values
					if ((f1 [x, y, z] <= 0f && R1 [x, y, z] <= 0f) ||
					    (f1 [x, y, z] <= 0f && R1 [x, y, z] <= 0f)) {
						continue;
					}

					TensorVoxelCube voxel = GameObject.Instantiate (this.baseVoxelCube).GetComponent<TensorVoxelCube> ();
					voxel.Initialize (x, y, z);
					voxel.transform.localPosition = new Vector3 ((float)x - (float)(xmax / 2), (float)y - (float)(ymax / 2), (float)0.0);
					voxel.gameObject.name = x + "-" + y + "-" + z;
					voxel.transform.SetParent (this.container.transform, false);
					voxel.gameObject.SetActive (true);

					// first glyph
					TensorInnerGlyph glyph = voxel.innerGlyphs [0];
					glyph.Initialize (f1 [x, y, z], n1 [x, y, z], R1 [x, y, z]);
					{ 
						glyph.transform.localRotation = Quaternion.FromToRotation (new Vector3 (0, 1, 0), glyph.n);
						float w = (glyph.r / Rmax) * (cmaxwidth - cminwidth) + cminwidth;
						glyph.transform.localScale = new Vector3 (w, clength, w);

						// update the UVs of the mesh
						Mesh mesh = glyph.GetComponent<MeshFilter> ().mesh;
						Vector2[] uvs = mesh.uv;
						float v = glyph.f / fmax;
						for (int i = 0; i < uvs.Length; i++) {
							uvs [i].x = v;
							uvs [i].y = 0;
						}
						mesh.uv = uvs;

						/*Color32[] colors = new Color32[mesh.vertices.Length];
						float v = glyph.f / fmax;
						Color32 c = new Color(0, 0, v);
						for (int i = 0; i < colors.Length; i++) {
							colors[i] = c;
						}
						mesh.colors32 = colors;*/
					}

					// second glyph
					glyph = voxel.innerGlyphs [1];
					glyph.Initialize (f2 [x, y, z], n2 [x, y, z], R2 [x, y, z]);
					{ 
						glyph.transform.localRotation = Quaternion.FromToRotation (new Vector3 (0, 1, 0), glyph.n);
						float w = (glyph.r / Rmax) * (cmaxwidth - cminwidth) + cminwidth;
						glyph.transform.localScale = new Vector3 (w, clength, w);
					

						// update the UVs of the mesh
						Mesh mesh = glyph.GetComponent<MeshFilter> ().mesh;
						Vector2[] uvs = mesh.uv;
						float v = glyph.f / fmax;
						for (int i = 0; i < uvs.Length; i++) {
							uvs [i].x = v;
							uvs [i].y = 0;
						}
						mesh.uv = uvs;

						/*Color32[] colors = new Color32[mesh.vertices.Length];
						float v = glyph.f / fmax;
						Color32 c = new Color(v, 0, 0);
						for (int i = 0; i < colors.Length; i++) {
							colors[i] = c;
						}
						mesh.colors32 = colors;*/
					}
				}
			}
		}
	}

	public void SetFirstGlyphVisibility (bool v)
	{
		this.SetGlyphVisibility (0, v);
	}

	public void SetSecondGlyphVisibility (bool v)
	{
		this.SetGlyphVisibility (1, v);
	}

	private void SetGlyphVisibility (int idx, bool v)
	{
		foreach (Transform child in this.container.transform) {
			TensorVoxelCube voxel = child.GetComponent<TensorVoxelCube> ();
			if (voxel != null) {
				voxel.SetGlyphVisibility (idx, v);
			}
		}
	}
}