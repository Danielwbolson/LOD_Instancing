using UnityEngine;
using System.Collections;

public class TensorInnerGlyph : MonoBehaviour
{
	public float f;
	public Vector3 n;
	public float r;

	public void Initialize (float f, Vector3 n, float r)
	{
		this.f = f;
		this.n = n;
		this.r = r;
	}
}
