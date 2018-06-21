using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GlyphDataRenderer : DataRenderer {

	// Use this for initialization
	void Start () {
		LockTransform();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3(0,0,0);
	}
}
