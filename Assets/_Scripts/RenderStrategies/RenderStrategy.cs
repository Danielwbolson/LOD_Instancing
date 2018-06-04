using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderStrategy {

    protected GameObject _parent;
    protected GameObject _obj;
    protected Material _objMat;
    protected ComputeShader _computeShader;
    protected Mesh[] _objMeshArray;
    protected int TOTALOBJECTS;

    protected List<ObjInfo> _masterData;
    protected Material[] _objMatArray;
    protected ComputeShader[] _computeShaderArray;

    /*
     * CLASS DOCUMENTATION: RenderStrategy
     * This is a parent class utilizing the Strategy pattern for different rendering techniques.
     * This class stores relevent information that any of its strategies could use, while also
     * allowing them to share, and send data further up where is is more accessibly by the user
     */
    public RenderStrategy(GameObject p, GameObject o, Material mat, ComputeShader cs, List<ObjInfo> data, int total) {
        _parent = p;
        _obj = o;
        _objMat = mat;
        _computeShader = cs;
        _masterData = data;
        TOTALOBJECTS = total;

        _objMatArray = new Material[4];
        for (int i = 0; i < 4; i++) {
            _objMatArray[i] = new Material(_objMat);
        }
        _computeShaderArray = new ComputeShader[4];
        for (int i = 0; i < 4; i++) {
            _computeShaderArray[i] = (ComputeShader)Object.Instantiate(_computeShader);
        }

        MeshFilter[] tempArray = _obj.GetComponentsInChildren<MeshFilter>();
        _objMeshArray = new Mesh[tempArray.Length];
        for (int i = 0; i < tempArray.Length; i++) {
            _objMeshArray[i] = tempArray[i].sharedMesh;
        }
    }

    public virtual void UpdateObjects() { }

    public virtual void Destroy() { }

    public List<ObjInfo> GetObjInfo() {
        return _masterData;
    }

    public void SetObjInfo(List<ObjInfo> data) {
        _masterData = data;
    }

    public void SetNumObjects(int num) {
        TOTALOBJECTS = num;
    }
}
