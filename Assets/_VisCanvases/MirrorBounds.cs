using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBounds : MonoBehaviour {

    GameObject _parent;
    BoxCollider _boxCollider;
    BoxCollider _parentBoxCollider;

    Vector3 parentScale;
    Vector3 parentOrigin;

	// Use this for initialization
	void Start () {
        _parent = transform.parent.gameObject;
        _boxCollider = GetComponent<BoxCollider>();
        _parentBoxCollider = _parent.GetComponent<BoxCollider>();
        parentScale = _parent.GetComponent<SculptingVis.Canvas>().GetInnerSceneScale();
        parentOrigin = _parent.GetComponent<SculptingVis.Canvas>().GetInnerSceneOrigin();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 size = _parentBoxCollider.size;

        _boxCollider.center = new Vector3(-parentOrigin.x / parentScale.x, -parentOrigin.y / parentScale.y, -parentOrigin.z / parentScale.z);
        _boxCollider.size = new Vector3(size.x / parentScale.x, size.y / parentScale.y, size.z / parentScale.z);
	}
}
