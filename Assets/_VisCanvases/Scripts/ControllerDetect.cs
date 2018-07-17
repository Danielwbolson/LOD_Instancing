using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDetect : MonoBehaviour {

    GameObject _controller = null;
    Collider _controllerCollider = null;
    BoxCollider _boxCollider;
    BoxCollider _parentBoxCollider;

    private void Start() {
        _boxCollider = GetComponent<BoxCollider>();
        _parentBoxCollider = transform.parent.GetComponent<BoxCollider>();
    }

    private void Update() {
        if (_controller != null) {
            // If the controller is partially contained by the box, we want to be only able to grab it
            if (PartiallyContains(_controllerCollider)) {
                    _parentBoxCollider.enabled = false;
            // If the controller is not contained at all, set it to null and reactivate canvas box
            } else {
                _controller = null;
                _parentBoxCollider.enabled = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (_controller == null && other.gameObject.GetComponent<VRTK.VRTK_InteractNearTouchCollider>() == null) {
            _controller = other.gameObject;
            _controllerCollider = other;
        }
    }

    bool PartiallyContains(Collider other) {
        return _boxCollider.bounds.Contains(other.bounds.max) || _boxCollider.bounds.Contains(other.bounds.min);
    }
}
