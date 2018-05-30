﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRenderer : MonoBehaviour {

    public GameObject _obj;
    public Material _objMat;
    public int _numObjects;

    public bool _instancedRendering;
    private bool _cachedInstanceRendering;

    private List<Vector3> _objPositions;
    private RenderStrategy _renderStrategy;

    // Use this for initialization
    void Start () {
        InitializePositions();

        _renderStrategy = new Instantiated(this.gameObject, _obj, _objMat, _objPositions, _numObjects);
        _instancedRendering = false;
        _cachedInstanceRendering = _instancedRendering;
    }
    
    // Update is called once per frame
    void Update () {
        if (_cachedInstanceRendering != _instancedRendering) {
            ToggleInstancedRendering();
        }

        _renderStrategy.UpdateObjects();
    }

    void InitializePositions() {
        _objPositions = new List<Vector3>();
        for (int i = 0; i < _numObjects; i++) {
            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);

            _objPositions.Add(new Vector3(
                Mathf.Sin(angle) * distance,
                height,
                Mathf.Cos(angle) * distance));
        }
    }

    void ToggleInstancedRendering() {
        List<Vector3> newObjPositions = _renderStrategy.GetPositions();

        if (_instancedRendering == true) {
            _renderStrategy.Destroy();
            _renderStrategy = new Instanced(this.gameObject, _obj, _objMat, newObjPositions,_numObjects);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(this.gameObject, _obj, _objMat, newObjPositions, _numObjects);
        }
        _cachedInstanceRendering = _instancedRendering;
    }

    void OnDisable() {
        if (_instancedRendering) {
            _renderStrategy.Destroy();
        }
    }
}