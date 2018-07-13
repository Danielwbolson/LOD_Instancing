using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBounds : MonoBehaviour {

    GameObject _parent;
    BoxCollider _boxCollider;
    BoxCollider _parentBoxCollider;
    Vector3 _size;

    // Use this for initialization
    void Start() {
        _parent = transform.parent.gameObject;
        _boxCollider = GetComponent<BoxCollider>();
        _parentBoxCollider = _parent.GetComponent<BoxCollider>();
        _size = _parentBoxCollider.size;
    }

    // Update is called once per frame
    void Update() {
        _boxCollider.center = new Vector3(
            -transform.localPosition.x / transform.lossyScale.x,
            -transform.localPosition.y / transform.lossyScale.y,
            -transform.localPosition.z / transform.lossyScale.z);
        _boxCollider.size = new Vector3(
            _size.x / transform.lossyScale.x, 
            _size.y / transform.lossyScale.y,
            _size.z / transform.lossyScale.z);
    }
}
