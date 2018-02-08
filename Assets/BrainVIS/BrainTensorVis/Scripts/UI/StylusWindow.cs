using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StylusWindow : MonoBehaviour
{

	public Text textUI;

	public void UpdateValues (TensorVoxelCube voxel)
	{
		string txt = "";

		if (voxel == null) {
			txt = 
				"f1: " + "\n" +
			"n1: " + "\n" +
			"r1: " + "\n" +
			"f2: " + "\n" +
			"n2: " + "\n" +
			"r2: " + "\n" +
			"f3: " + "\n" +
			"n3: " + "\n" +
			"prep: " + "\n" +
			"fa: ";
		} else {
			txt = 
				"f1: " + voxel.innerGlyphs [0].f.ToString ("F5") + "\n" +
			"n1: " + voxel.innerGlyphs [0].n.ToString ("F2") + "\n" +
			"r1: " + voxel.innerGlyphs [0].r.ToString ("F5") + "\n" +
			"f2: " + voxel.innerGlyphs [1].f.ToString ("F5") + "\n" +
			"n2: " + voxel.innerGlyphs [1].n.ToString ("F2") + "\n" +
			"r2: " + voxel.innerGlyphs [1].r.ToString ("F5") + "\n" + 
			"f3: " + voxel.innerGlyphs [2].f.ToString ("F5") + "\n" +
			"n3: " + voxel.innerGlyphs [2].n.ToString ("F2") + "\n" +
			"prep: " + voxel.innerGlyphs [2].r.ToString ("F5") + "\n" + 
			"fa: " + voxel.s.ToString ("F5");
		}

		this.textUI.text = txt;
	}

	public void ChangeVisibility ()
	{
		this.gameObject.SetActive (!this.gameObject.activeSelf);
	}
}
