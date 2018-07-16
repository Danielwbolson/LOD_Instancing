using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBoundingBox : MonoBehaviour {

    public bool _isChild;
    BoxCollider _boxCollider;
    LineRenderer _lineRenderer;
    Vector3[] _vertexList;

    GameObject _controller;
    Collider _controllerCollider;

    VRTK.VRTK_InteractableObject _interactableObject;
    VRTK.VRTK_InteractableObject _fellowInteractableObject;

    public Color white = Color.white;
    public int lengthOfLineRenderer = 16;

    void Start() {
        if (_isChild)
            _fellowInteractableObject = transform.parent.GetComponent<VRTK.VRTK_InteractableObject>();
        else
            _fellowInteractableObject = transform.GetChild(0).GetComponent<VRTK.VRTK_InteractableObject>();

        _boxCollider = GetComponent<BoxCollider>();
        _interactableObject = GetComponent<VRTK.VRTK_InteractableObject>();
        UpdateVertexList();

        _lineRenderer = gameObject.AddComponent<LineRenderer>();
        _lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        _lineRenderer.widthMultiplier = 0.04f;
        _lineRenderer.positionCount = lengthOfLineRenderer;

        _lineRenderer.startColor = white;
        _lineRenderer.endColor = white;
    }

    void Update() {
        if (!_interactableObject.IsGrabbed() && !_fellowInteractableObject.IsGrabbed()) {
            _lineRenderer.enabled = true;
            UpdateVertexList();
            _lineRenderer.SetPositions(_vertexList);
        } else {
            _lineRenderer.enabled = false;
        }
    }

    void UpdateVertexList() {
        Vector3 p1 = _boxCollider.bounds.center - _boxCollider.bounds.extents * 0.96f; // Left, bottom, close
        Vector3 p2 = _boxCollider.bounds.center + _boxCollider.bounds.extents * 0.96f; // Right, top, far
        Vector3 p3 = new Vector3(p1.x, p1.y, p2.z); // Left, bottom, far
        Vector3 p4 = new Vector3(p1.x, p2.y, p1.z); // Left, top, close
        Vector3 p5 = new Vector3(p2.x, p1.y, p1.z); // Right, bottom, close
        Vector3 p6 = new Vector3(p1.x, p2.y, p2.z); // Left, top, far
        Vector3 p7 = new Vector3(p2.x, p1.y, p2.z); // Right, bottom, far
        Vector3 p8 = new Vector3(p2.x, p2.y, p1.z); // Right, top, close

        _vertexList = new Vector3[16] {
            p1, p3, p7, p5, p1, // bottom
            p4, p6, p2, p8, p4, // top
            p6, p3, p7, p2, p8, p5 // axles
        };
    }
}
