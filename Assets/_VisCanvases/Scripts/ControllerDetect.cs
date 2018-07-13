using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDetect : MonoBehaviour {

    public bool child;
    GameObject _controller = null;
    Collider _controllerCollider = null;

    private void Update() {
        if (_controller != null) {
            if (FullyContains(_controllerCollider)) {
                if (child) {
                    GetComponent<BoxCollider>().enabled = true;
                } else {
                    GetComponent<BoxCollider>().enabled = false;
                }
            } else {
                if (child) {
                    GetComponent<BoxCollider>().enabled = false;
                } else {
                    GetComponent<BoxCollider>().enabled = true;
                }
            }
            // Partially contains code since ontrigger exit won't call for inside data collider
        }
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("enter");
        if (_controller == null) {
            _controller = other.gameObject;
            _controllerCollider = other;
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("exit");
        if (other.gameObject == _controller) {
            _controller = null;
            _controllerCollider = null;
        }
        GetComponent<BoxCollider>().enabled = true;
    }

    bool FullyContains(Collider other) {
        Collider canvas = GetComponent<Collider>();
        if (canvas == null) {
            return false;
        }
        return canvas.bounds.Contains(other.bounds.max) && canvas.bounds.Contains(other.bounds.min);
    }
}
