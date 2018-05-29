using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    struct ObjInfo {
        public Vector4 position;
        public Vector4 color;
        public Vector4 scale;
    };

    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private int subMeshIndex = 0;
    private Matrix4x4 _modelMatrix;
    private Mesh _objMesh;
    private GameObject _instancedObject;

    private float LOD0 = 0.60f;
    private float LOD1 = 0.25f;
    private float LOD2 = 0.08f;
    private float LOD3 = 0.1f;

    private uint[][] _LODArgs;

    private List<Vector3>[] _LODPositions;

    private int cachedInstanceCount = -1;
    private int cachedSubMeshIndex = -1;
    private ComputeBuffer dataBuffer;
    private ComputeBuffer[] LODArgsBuffer;

    public Instanced(GameObject p, GameObject o, Material mat, List<Vector3> poses, int total) : 
        base(p, o, mat, poses, total) {
        _LODArgs = new uint[][4];
        LODArgsBuffer = new ComputeBuffer[4];
        _LODPositions = new List<Vector3>[4];

        for (int i = 0; i < 4; i++) {
            _LODArgs[i] = new uint[5] { 0, 0, 0, 0, 0 };
        }
        _instancedObject = o;
        _objMesh = _objMeshArray[1];

        for (int i = 0; i < LODArgsBuffer.Length; i++) {
            LODArgsBuffer[i] = new ComputeBuffer(1, _LODArgs[i].Length * sizeof(uint), ComputeBufferType.IndirectArguments);
        }
        UpdateLOD();
        UpdateBuffers();

        // Set our parent model matrix
        _modelMatrix = _parent.transform.localToWorldMatrix;
        _objMat.SetMatrix("modelMatrix", _modelMatrix);
        _objMat.enableInstancing = true;

        _cachedCamPosition = cam.transform.position;
    }

    public override void UpdateObjects() {
        if (_modelMatrix != _parent.transform.localToWorldMatrix) {
            _modelMatrix = _parent.transform.localToWorldMatrix;
            _objMat.SetMatrix("modelMatrix", _modelMatrix);
        }

        if (_cachedCamPosition != cam.transform.position) {
            UpdateLOD();
        }

        // Update starting position buffer
        if (cachedInstanceCount != TOTALOBJECTS || cachedSubMeshIndex != subMeshIndex)
            UpdateBuffers();

        RotatePositions();

        // Render
        for (int i = 0; i < LODArgsBuffer.Length; i++) {
            Graphics.DrawMeshInstancedIndirect(_objMesh, subMeshIndex, _objMat, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), LODArgsBuffer[i]);
        }
    }

    void UpdateBuffers() {
        // Ensure submesh index is in range
        if (_objMesh != null)
            subMeshIndex = Mathf.Clamp(subMeshIndex, 0, _objMesh.subMeshCount - 1);

        // Data struct
        if (dataBuffer != null)
            dataBuffer.Release();

        dataBuffer = new ComputeBuffer(TOTALOBJECTS, 12 * sizeof(float));
        ObjInfo[] data = new ObjInfo[TOTALOBJECTS];

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the position of our instance
            data[i].position = new Vector4(_objPositions[i].x, _objPositions[i].y, _objPositions[i].z, 1);

            // Set the color of our instance
            float red = Random.Range(0f, 1f);
            float green = Random.Range(0f, 1f);
            float blue = Random.Range(0f, 1f);
            float alpha = 1;
            data[i].color = new Vector4(red, green, blue, alpha);

            // Set the scale of our instance
            float xScale = Random.Range(0.01f, 0.15f);
            float yScale = Random.Range(0.01f, 0.15f);
            float zScale = Random.Range(0.01f, 0.15f);
            float w = 1;
            data[i].scale = new Vector4(xScale, yScale, zScale, w);
        }
        dataBuffer.SetData(data);
        _objMat.SetBuffer("dataBuffer", dataBuffer);

        // Indirect args
        if (_objMesh != null) {
            for (int i = 0; i < _LODArgs.Length; i++) {
                _LODArgs[i][0] = (uint)_objMesh.GetIndexCount(subMeshIndex);
                _LODArgs[i][1] = (uint)_LODPositions[i].Count;
                _LODArgs[i][2] = (uint)_objMesh.GetIndexStart(subMeshIndex);
                _LODArgs[i][3] = (uint)_objMesh.GetBaseVertex(subMeshIndex);
            }
        } else {
            for (int i = 0; i < _LODArgs.Length; i++) {
                _LODArgs[i][0] = _LODArgs[i][1] = _LODArgs[i][2] = _LODArgs[i][3] = 0;
            }
        }

        for (int i = 0; i < LODArgsBuffer.Length; i++) {
            LODArgsBuffer[i].SetData(_LODArgs[i]);
        }

        cachedInstanceCount = TOTALOBJECTS;
        cachedSubMeshIndex = subMeshIndex;
    }

    void UpdateLOD() {
        Sort();
        LevelOfDetail();
    }

    void RotatePositions() {
        ObjInfo[] data = new ObjInfo[TOTALOBJECTS];
        dataBuffer.GetData(data);

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the positions of our instance based on our input List
            float scaleMag = new Vector3(data[i].scale.x, data[i].scale.y, data[i].scale.z).magnitude;
            _objPositions[i] = Quaternion.AngleAxis(
                scaleMag * scaleMag * Time.deltaTime * 100,
                Vector3.up) * _objPositions[i];
            data[i].position = new Vector4(_objPositions[i].x, _objPositions[i].y, _objPositions[i].z, 1);
        }
        dataBuffer.SetData(data);
        _objMat.SetBuffer("dataBuffer", dataBuffer);
    }

    static int SortByDistanceToCamera(Vector3 a, Vector3 b) {
        return Vector3.Distance(a, Camera.main.transform.position).CompareTo(Vector3.Distance(b, Camera.main.transform.position));
    }

    void Sort() {
        _objPositions.Sort(SortByDistanceToCamera);
    }

    void LevelOfDetail() {
        for (int i = 0; i < _LODPositions.Length; i++) {
            _LODPositions[i].Clear();
            _LODPositions[i] = new List<Vector3>();
        }

        for (int i = 0; i < TOTALOBJECTS; i++) {
            Vector2 objectScreenCoord;
            float objYMin = Screen.height;
            float objYMax = 0;

            for (int j = 0; j < 8; j++) {
                objectScreenCoord = cam.WorldToScreenPoint(FindBoundCoords(j, _obj));

                if (objectScreenCoord.y > objYMax) {
                    objYMax = objectScreenCoord.y;
                } else if (objectScreenCoord.y < objYMin) {
                    objYMin = objectScreenCoord.y;
                }
            }

            float height = objYMax - objYMin;

            float relativeHeight = height / Screen.height;

            if (relativeHeight > LOD0) {
                _LODPositions[0].Add(_objPositions[i]);
            } else if (relativeHeight > LOD1) {
                _LODPositions[1].Add(_objPositions[i]);
            } else if (relativeHeight > LOD2) {
                _LODPositions[2].Add(_objPositions[i]);
            } else {
                _LODPositions[3].Add(_objPositions[i]);
            }
        }
            
    }

    /*
     * https://answers.unity.com/questions/352738/gameobject-width-in-screen-space.html
     * Returns bounding box points
     */
    private Vector3 FindBoundCoords(int i, GameObject _gameObject) {
        ObjInfo[] data = new ObjInfo[TOTALOBJECTS];
        dataBuffer.GetData(data);

        Vector3 scale = data[i].scale;
        Vector3 pos = data[i].position;

        // Given scale and position, find a bounding box
        _instancedObject.transform.localScale = scale;
        Bounds _TargetBounds = _instancedObject.GetComponentInChildren<MeshRenderer>().bounds;
        Vector3 _TargetCenter = _TargetBounds.center + pos;
        Vector3 _TargetExtents = _TargetBounds.extents;

        switch (i) {
            case 0:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x, _TargetExtents.y, _TargetExtents.z);
            case 1:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x, _TargetExtents.y, _TargetExtents.z * -1);
            case 2:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x, _TargetExtents.y * -1, _TargetExtents.z);
            case 3:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x, _TargetExtents.y * -1, _TargetExtents.z * -1);
            case 4:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x * -1, _TargetExtents.y, _TargetExtents.z);
            case 5:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x * -1, _TargetExtents.y, _TargetExtents.z * -1);
            case 6:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x * -1, _TargetExtents.y * -1, _TargetExtents.z);
            case 7:
                return _TargetCenter + pos + new Vector3(_TargetExtents.x * -1, _TargetExtents.y * -1, _TargetExtents.z * -1);
            default:
                return Vector3.zero;
        }
    }

    public override void Destroy() {
        if (dataBuffer != null)
            dataBuffer.Release();
        dataBuffer = null;

        for (int i = 0; i < LODArgsBuffer.Length; i++) {
            if (LODArgsBuffer[i] != null) {
                LODArgsBuffer[i].Release();
            }
            LODArgsBuffer = null;
        }
    }
}
 