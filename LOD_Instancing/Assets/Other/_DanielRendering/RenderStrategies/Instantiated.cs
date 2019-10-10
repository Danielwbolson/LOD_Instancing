﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiated : RenderStrategy {

    private List<GameObject> _gameObjects;
    private int _cachedNumObjects;

/*
 * CLASS DOCUMENTATION: Instantiated : RenderStrategy
 * In this class, we render a given set of objects as instantiated GameObjects.
 * This is the default way to render objects in Unity. We instantiate a gameobject, 
 * give it some data, and have unit render it as a gameobject.
 * 
 * We also have Level-Of-Detail working with this strategy. We have 4 LOD groups, varying
 * by polygon count, that all share the same material. We are using Unity's built in
 * LOD system as it is made to work with their gameobjects.
 */
    public Instantiated(GameObject p, GameObject[] o, Material mat, ComputeShader cs, List<ObjInfo>[] data, int total) : 
        
        base(p, o, mat, cs, data, total) {

        _objMat.enableInstancing = false;

        InitializeObjects();
    }

    // Initialize all our gameobjects with the data sent in from our ObjRenderer
    public void InitializeObjects() {
        _gameObjects = new List<GameObject>();

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < _masterData[i].Count; j++) {
                GameObject temp_obj = GameObject.Instantiate(_objs[i]) as GameObject;
                temp_obj.transform.parent = _parent.transform;
                _gameObjects.Add(temp_obj);

                // Set our materials for each LOD mesh
                MeshRenderer[] _MeshArray = temp_obj.GetComponentsInChildren<MeshRenderer>();
                Material[] _tempMatArray = new Material[_MeshArray.Length];
                Vector4[] color = new Vector4[_MeshArray.Length];
                for (int k = 0; k < _MeshArray.Length; k++) {
                    _tempMatArray[k] = new Material(_objMatArray[i][k]);

                    color[k] = new Vector4(
                        Mathf.Clamp(0 + k * (1f / (color.Length - 1)), 0, 1),
                        Mathf.Clamp(1 - k * (1f / (color.Length - 1)), 0, 1),
                        0,
                        _masterData[i][j].color[3]);
                    _tempMatArray[k].SetVector("color", color[k]);

                    if (_bumpMaps[i][k] != null && _bumpMapsEnabled) {
                        _tempMatArray[k].SetTexture("_BumpMap", _bumpMaps[i][k]);
                        _tempMatArray[k].shaderKeywords = new string[1] { "_NORMALMAP" };
                    } else {
                        _tempMatArray[k].SetTexture("_BumpMap", null);
                        _tempMatArray[k].shaderKeywords = new string[0];
                    }
                    _MeshArray[k].material = _tempMatArray[k];
                }

                // Set our position based on what was passed in
                
                temp_obj.transform.localPosition = _masterData[i][j].position;

                Vector3 scal = _masterData[i][j].scale;

                temp_obj.transform.localScale = new Vector3(scal.x, scal.y, scal.z);

                //temp_obj.transform.forward = _masterData[i][j].direction;
            }
        }
        _cachedNumObjects = TOTALOBJECTS;
    }

    /*
     * Called each frame, updates our gameobjects
     */
    public override void UpdateMeshes() {
        if (_cachedNumObjects != TOTALOBJECTS) {
            Destroy();
            InitializeObjects();
        }

        if (_cachedDebug != _debug) {
            int index = 0;
            for (int i = 0; i < DIFFERENTOBJECTS; i++) {

                if (i != 0) {
                    index += _masterData[i - 1].Count;
                }

                for (int j = 0; j < _masterData[i].Count; j++) {
                    MeshRenderer[] _MeshArray = _gameObjects[index + j].GetComponentsInChildren<MeshRenderer>();
                    Material[] _tempMatArray = new Material[_MeshArray.Length];
                    for (int k = 0; k < _tempMatArray.Length; k++) {
                        _tempMatArray[k] = _MeshArray[k].material;
                        _tempMatArray[k].SetInt("debug", _debug);
                    }
                }
            }
            _cachedDebug = _debug;
        }

        if (_cachedBumpMapsEnabled != _bumpMapsEnabled) {
            int index = 0;
            for (int i = 0; i < DIFFERENTOBJECTS; i++) {

                if (i != 0) {
                    index += _masterData[i - 1].Count;
                }

                for (int j = 0; j < _masterData[i].Count; j++) {
                    MeshRenderer[] _MeshArray = _gameObjects[index + j].GetComponentsInChildren<MeshRenderer>();
                    Material[] _tempMatArray = new Material[_MeshArray.Length];
                    for (int k = 0; k < _tempMatArray.Length; k++) {
                        _tempMatArray[k] = _MeshArray[k].material;
                        if (_bumpMaps[i][k] != null && _bumpMapsEnabled) {
                            _tempMatArray[k].SetTexture("_BumpMap", _bumpMaps[i][k]);
                            _tempMatArray[k].shaderKeywords = new string[1] { "_NORMALMAP" };
                        } else {
                            _tempMatArray[k].SetTexture("_BumpMap", null);
                            _tempMatArray[k].shaderKeywords = new string[0];
                        }
                    }
                }
            }
            _cachedBumpMapsEnabled = _bumpMapsEnabled;
        }

        RotatePositions();
    }

    /*
     * Rotates our gameobjects around the vertical axis at a rate dependant on their scale
     */
    public void RotatePositions() {
        int index = 0;
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {

            if (i != 0) {
                index += _masterData[i - 1].Count;
            }

            for (int j = 0; j < _masterData[i].Count; j++) {
                float rotation = _masterData[i][j].scale.magnitude * Time.deltaTime;
                ObjInfo temp = _masterData[i][j];
                Vector3 rot = Quaternion.AngleAxis(rotation, Vector3.up) * temp.position;
                temp.position = new Vector4(rot.x, rot.y, rot.z, 1);

                _gameObjects[index + j].transform.localPosition = temp.position;
                _masterData[i][j] = temp;
            }
        }
    }

    /*
     * When we exit this render strategy, we need to destroy all gameobjects
     */
    public override void Destroy() {
        foreach (GameObject g in _gameObjects) {
            GameObject.Destroy(g);
        }
        _gameObjects.Clear();
    }
}
