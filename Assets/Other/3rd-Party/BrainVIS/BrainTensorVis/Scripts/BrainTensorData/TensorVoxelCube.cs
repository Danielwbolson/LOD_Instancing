using UnityEngine;
using System.Collections;

public class TensorVoxelCube: MonoBehaviour
{
	public int x;
	public int y;
	public int z;
	public float s;

	public TensorInnerGlyph[] innerGlyphs;

	public void Initialize (int x, int y, int z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public void SetGlyphVisibility (int idx, bool v)
	{
		TensorInnerGlyph glyph = this.innerGlyphs [idx];
		glyph.gameObject.SetActive (v);
	}

	public void SetHoverOver (bool hovered)
	{
		this.GetComponent<Renderer> ().enabled = hovered;
	}
}