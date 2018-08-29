﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderStrategy {


    protected GameObject _parent;
    protected GameObject[] _objs;
    protected Material _objMat;
    protected ComputeShader _computeShader;
    protected Mesh[][] _objMeshArray;
    protected int TOTALOBJECTS;
    protected int DIFFERENTOBJECTS;

    protected bool _bumpMapsEnabled = false;
    protected bool _cachedBumpMapsEnabled = false;

    protected int _debug = 0;
    protected int _cachedDebug = 0;

    protected List<ObjInfo>[] _masterData;
    protected Material[][] _objMatArray;
    protected Texture[][] _bumpMaps;

    /*
     * CLASS DOCUMENTATION: RenderStrategy
     * This is a parent class utilizing the Strategy pattern for different rendering techniques.
     * This class stores relevent information that any of its strategies could use, while also
     * allowing them to share, and send data further up where is is more accessibly by the user
     */
    public RenderStrategy(GameObject p, GameObject[] o, Material mat, ComputeShader cs, List<ObjInfo>[] data, int total) {
        _parent = p;
        _objs = o;
        _objMat = mat;
        _computeShader = cs;
        _masterData = data;
        TOTALOBJECTS = total;
        DIFFERENTOBJECTS = _objs.Length;

        _objMatArray = new Material[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _objMatArray[i] = new Material[_objs[i].transform.childCount];
            for (int j = 0; j < _objs[i].transform.childCount; j++) {
                _objMatArray[i][j] = new Material(_objMat);
            }
        }

        MeshFilter[][] tempArray = new MeshFilter[DIFFERENTOBJECTS][];
        _objMeshArray = new Mesh[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            tempArray[i] = _objs[i].GetComponentsInChildren<MeshFilter>();
            _objMeshArray[i] = new Mesh[_objs[i].transform.childCount];
            for (int j = 0; j < _objs[i].transform.childCount; j++) {
                _objMeshArray[i][j] = tempArray[i][j].sharedMesh;
            }
        }

        _bumpMaps = new Texture[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _bumpMaps[i] = new Texture[_objs[i].transform.childCount];
            for (int j = 0; j < _objs[i].transform.childCount; j++) {
                string path = "ArtWork/Meshes/" + _objs[i].name + "/NormalMaps/LOD" + j;
                _bumpMaps[i][j] = Resources.Load(path) as Texture;
            }
        }
    }

    public virtual void UpdateMeshes() { }

    public virtual void Destroy() { }

    public List<ObjInfo>[] GetObjInfo() {
        return _masterData;
    }

    public void SetDebug(bool d) {
        if (d == true) {
            _debug = 1;
        } else {
            _debug = 0;
        }
    }

    public void SetNormalMapsEnabled(bool n) {
        _bumpMapsEnabled = n;
    }
}
