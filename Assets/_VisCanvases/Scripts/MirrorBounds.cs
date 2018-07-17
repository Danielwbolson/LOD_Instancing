using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBounds : MonoBehaviour {

    BoxCollider _boxCollider;
    Vector3 _parentSize;
    public float _scaleFactor = 0.7f;
    Quaternion _rotation;

    // Use this for initialization
    void Start() {
        _boxCollider = GetComponent<BoxCollider>();
        _parentSize = transform.parent.GetComponent<BoxCollider>().size;
    }

    // Update is called once per frame
    void Update() {
        _rotation = transform.localRotation;

        _boxCollider.center = new Vector3(
            -transform.localPosition.x / transform.localScale.x,
            -transform.localPosition.y / transform.localScale.y,
            -transform.localPosition.z / transform.localScale.z);

        // Scale down our box from the canvas
        _boxCollider.size = new Vector3(
            _parentSize.x / transform.localScale.x,
            _parentSize.y / transform.localScale.y,
            _parentSize.z / transform.localScale.z) * _scaleFactor;

        _boxCollider.center = Quaternion.Inverse(_rotation) * _boxCollider.center;
        
    }
}
