using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDetect : MonoBehaviour {

    GameObject _controller = null;
    Collider _controllerCollider = null;
    VRTK.VRTK_InteractTouch _controllerTouch;
    VRTK.VRTK_InteractGrab _controllerGrab;

    GameObject _secondaryController = null;
    Collider _secondaryControllerCollider = null;
    VRTK.VRTK_InteractTouch _secondaryControllerTouch;
    VRTK.VRTK_InteractGrab _secondaryControllerGrab;

    GameObject _data;
    BoxCollider _boxCollider;
    VRTK.VRTK_InteractableObject _interactableObject;
    VRTK.VRTK_InteractableObject _dataInteractableObject;

    string tag = "GameController";

    private void Start() {
        _boxCollider = GetComponent<BoxCollider>();
        _data = transform.GetChild(0).gameObject;
        _interactableObject = GetComponent<VRTK.VRTK_InteractableObject>();
        _dataInteractableObject = _data.GetComponent<VRTK.VRTK_InteractableObject>();
    }

    private void Update() {
        // If there is a controller within touching distance
        if (_controller != null) {

            // If the canvas is not currently being grabbed
            if (!_interactableObject.IsGrabbed()) {

                // If we are fully inside of the canvas, then we want to be grabbing the data
                // object instead, otherwise make sure we are touching the canvas
                if (FullyContains(_controllerCollider)) {

                    // If the canvas is the item being touched, stop touching and touch the data instead
                    if (_interactableObject.IsTouched()) {
                        _controllerTouch.ForceStopTouching();
                        _controllerTouch.ForceTouch(_data);
                    }
                } else {
                    // If we are NOT fully contained by the canvas and the canvas is NOT the item being touched, 
                    // force the controllers to touch the canvas
                    if (!_interactableObject.IsTouched()) {
                        _controllerTouch.ForceStopTouching();
                        _controllerTouch.ForceTouch(gameObject);
                    }
                }
            }
        }

        if (_secondaryController != null) {
            if (!_interactableObject.IsGrabbed()) {
                if (FullyContains(_secondaryControllerCollider)) {
                    if (_interactableObject.IsTouched()) {
                        _secondaryControllerTouch.ForceStopTouching();
                        _secondaryControllerTouch.ForceTouch(_data);
                    }
                } else {
                    if (!_interactableObject.IsTouched()) {
                        _secondaryControllerTouch.ForceStopTouching();
                        _secondaryControllerTouch.ForceTouch(gameObject);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        GameObject c = ParentWithTag(other.transform, tag).gameObject;
        if (c) {
            if (_controller == null) {
                _controller = c;
                _controllerCollider = other;
                _controllerTouch = _controller.GetComponent<VRTK.VRTK_InteractTouch>();
                _controllerGrab = _controller.GetComponent<VRTK.VRTK_InteractGrab>();
            } else if (_controller != c) {
                _secondaryController = c;
                _secondaryControllerCollider = other;
                _secondaryControllerTouch = _secondaryController.GetComponent<VRTK.VRTK_InteractTouch>();
                _secondaryControllerGrab = _secondaryController.GetComponent<VRTK.VRTK_InteractGrab>();
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        GameObject c = ParentWithTag(other.transform, tag).gameObject;
        if (c) {
            // If the object to leave was our primary controller, we need to give power
            // to our secondary controller
            if (c == _controller) {
                _controller = _secondaryController;
                _controllerCollider = _secondaryControllerCollider;
                _controllerGrab = _secondaryControllerGrab;
                _controllerTouch = _secondaryControllerTouch;

                _secondaryController = null;
                _secondaryControllerCollider = null;
                _secondaryControllerGrab = null;
                _secondaryControllerTouch = null;
            } else if (c == _secondaryController) {
                _secondaryController = null;
                _secondaryControllerCollider = null;
                _secondaryControllerGrab = null;
                _secondaryControllerTouch = null;
            }
        }
    }

    bool FullyContains(Collider other) {
        return _boxCollider.bounds.Contains(other.bounds.max) && _boxCollider.bounds.Contains(other.bounds.min);
    }

    Transform ParentWithTag(Transform start, string tag) {
        while (start.tag != tag && start.parent)
            start = start.parent;

        return start.tag == tag ? start : null;
    }
}
