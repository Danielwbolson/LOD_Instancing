using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBoundingBox : MonoBehaviour {

    BoxCollider _boxCollider;
    LineRenderer _lineRenderer;
    Vector3[] _p;
    Vector3[] _vertexList;
    Quaternion _rotation;

    GameObject _controller;
    Collider _controllerCollider;

    VRTK.VRTK_InteractableObject _interactableObject;

    public Color white = Color.white;
    public int lengthOfLineRenderer = 16;

    void Start() {
        _boxCollider = GetComponent<BoxCollider>();
        _interactableObject = GetComponent<VRTK.VRTK_InteractableObject>();

        _lineRenderer = gameObject.AddComponent<LineRenderer>();
        _lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        _lineRenderer.widthMultiplier = 0.01f;
        _lineRenderer.positionCount = lengthOfLineRenderer;

        _lineRenderer.startColor = white;
        _lineRenderer.endColor = white;

        _p = new Vector3[8];

        UpdateVertexList();
    }

    void Update() {
        _rotation = transform.rotation;
        if (!_interactableObject.IsGrabbed()) {
            _lineRenderer.enabled = true;
            UpdateVertexList();
            _lineRenderer.SetPositions(_vertexList);
        } else {
            _lineRenderer.enabled = false;
        }
    }

    void UpdateVertexList() {
        Vector3 center = _boxCollider.center;
        Vector3 size = _boxCollider.size;
        Vector3 extents = size / 2.0f;

        _p[0] = center + new Vector3(-extents.x, -extents.y, -extents.z) * 0.96f; // Left, bottom, close
        _p[1] = center + new Vector3(extents.x, extents.y, extents.z) * 0.96f; // Right, top, far
        _p[2] = center + new Vector3(-extents.x, -extents.y, extents.z); // Left, bottom, far
        _p[3] = center + new Vector3(-extents.x, extents.y, -extents.z); // Left, top, close
        _p[4] = center + new Vector3(extents.x, -extents.y, -extents.z); // Right, bottom, close
        _p[5] = center + new Vector3(-extents.x, extents.y, extents.z); // Left, top, far
        _p[6] = center + new Vector3(extents.x, -extents.y, extents.z); // Right, bottom, far
        _p[7] = center + new Vector3(extents.x, extents.y, -extents.z); // Right, top, close

        for (int i = 0; i < _p.Length; i++) {
            _p[i] = transform.TransformPoint(_p[i]);
        }

        _vertexList = new Vector3[16] {
            _p[0], _p[2], _p[6], _p[4], _p[0], // bottom
            _p[3], _p[5], _p[1], _p[7], _p[3], // top
            _p[5], _p[2], _p[6], _p[1], _p[7], _p[4] // axles
        };
    }
}
