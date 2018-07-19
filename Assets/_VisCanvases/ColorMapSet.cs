using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ColorMapSet : ScriptableObject {

	[SerializeField]
	List<Texture> _colorMaps;

	public List<Texture> GetColorMaps() {
		return _colorMaps;
	}
}
