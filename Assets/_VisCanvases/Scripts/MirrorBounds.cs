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
            -transform.localPosition.x / transform.lossyScale.x,
            -transform.localPosition.y / transform.lossyScale.y,
            -transform.localPosition.z / transform.lossyScale.z);

        // Scale down our box from the canvas
        _boxCollider.size = new Vector3(
            _parentSize.x / transform.lossyScale.x,
            _parentSize.y / transform.lossyScale.y,
            _parentSize.z / transform.lossyScale.z) * _scaleFactor;

        _boxCollider.center = Quaternion.Inverse(_rotation) * _boxCollider.center;
        
    }
}
