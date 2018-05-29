using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderStrategy {

    protected GameObject _parent;
    protected GameObject _obj;
    protected Material _objMat;
    protected Mesh[] _objMeshArray;
    protected List<Vector3> _objPositions;
    protected int TOTALOBJECTS;

    public RenderStrategy(GameObject p, GameObject o, Material mat, List<Vector3> poses, int total) {
        _parent = p;
        _obj = o;
        _objMat = mat;
        _objPositions = poses;
        TOTALOBJECTS = total;

        MeshFilter[] tempArray = _obj.GetComponentsInChildren<MeshFilter>();
        _objMeshArray = new Mesh[tempArray.Length];
        for (int i = 0; i < tempArray.Length; i++) {
            _objMeshArray[i] = tempArray[i].sharedMesh;
        }
    }

    public virtual void UpdateObjects() { }

    public virtual void Destroy() { }

    public List<Vector3> GetPositions() {
        return _objPositions;
    }
}
