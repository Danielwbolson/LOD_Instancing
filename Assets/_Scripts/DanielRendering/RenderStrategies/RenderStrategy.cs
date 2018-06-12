using System.Collections;
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

    protected List<ObjInfo>[] _masterData;
    protected Material[][] _objMatArray;

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
            _objMatArray[i] = new Material[4];
            for (int j = 0; j < 4; j++) {
                _objMatArray[i][j] = new Material(_objMat);
            }
        }

        MeshFilter[][] tempArray = new MeshFilter[DIFFERENTOBJECTS][];
        _objMeshArray = new Mesh[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            tempArray[i] = _objs[i].GetComponentsInChildren<MeshFilter>();
            _objMeshArray[i] = new Mesh[4];
            for (int j = 0; j < 4; j++) {
                _objMeshArray[i][j] = tempArray[i][j].sharedMesh;
            }
        }
    }

    public virtual void UpdateObjects() { }

    public virtual void Destroy() { }

    public List<ObjInfo>[] GetObjInfo() {
        return _masterData;
    }

    public void SetObjInfo(List<ObjInfo>[] data) {
        _masterData = data;
    }

    public void SetNumObjects(int num) {
        TOTALOBJECTS = num;
    }
}
