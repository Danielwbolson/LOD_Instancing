using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    struct BoundingSphere {
        public Vector3 position;
        public float radius;
    };

    private const int LODSIZE = 4;
    private int cachedInstanceCount = -1;
    float threadCount = 64.0f;

    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private Matrix4x4 _modelMatrix;
    private Vector3[] _meshBoundsSize;
    private BoundingSphere[] _boundingSpheres;
    private int _kCSMain;

    private const float LOD0 = 10;
    private const float LOD1 = 30;
    private const float LOD2 = 93;
    private const float LOD3 = 500;

    Vector4 _LODRanges = new Vector4(LOD0, LOD1, LOD2, LOD3 );

    private Matrix4x4[] _matrixData;
    private MaterialPropertyBlock[][] _mpbs;

    private ComputeBuffer[] _dataBuffer;

    private List<uint>[][] _LODArgs;
    private ComputeBuffer[][] _LODBuffers;
    private ComputeBuffer[][] _LODArgsBuffer;
    private ComputeBuffer _matrixBuffer;
    private ComputeBuffer _boundingBuffer;

    /*
     * CLASS DOCUMENTATION: Instanced : RenderStrategy
     * In this class, we render a given set of objects as instanced meshes, instead of 
     * gameobjects. This gives us a big boost in performance as we are able to utilize
     * the GPU instead of the CPU, as well as send much fewer calls to the GPU.
     * 
     * We also are utilizing Level-of-Detail. We have copies of our material for each
     * LOD, as for whatever reason they cannot share materials, or else not all are drawn to the
     * screen. Right now, level-of-detail is recalculated at each frame that the camera position
     * is not as it was. Meshes are changed depending on which group they are calculated to join.
     * 
     * Next step: Frustrum culling.
     */
    public Instanced(GameObject p, GameObject[] o, Material mat, ComputeShader cs, List<ObjInfo>[] data, int total) :
        base(p, o, mat, cs, data, total) {

        InitializeArguments();
        InitializeBuffers();
        InitializeOther();
        InitializeMaterials();

    }

    public void InitializeArguments() {
        _LODArgs = new List<uint>[DIFFERENTOBJECTS][];
        _LODArgsBuffer = new ComputeBuffer[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _LODArgs[i] = new List<uint>[LODSIZE];
            _LODArgsBuffer[i] = new ComputeBuffer[LODSIZE];

            for (int j = 0; j < LODSIZE; j++) {
                _LODArgs[i][j] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });
                if (_objMeshArray[i][j] != null) {
                    _LODArgs[i][j][0] = (uint)_objMeshArray[i][j].GetIndexCount(0);
                    _LODArgs[i][j][1] = (uint)_masterData[i].Count;
                    _LODArgs[i][j][2] = (uint)_objMeshArray[i][j].GetIndexStart(0);
                    _LODArgs[i][j][3] = (uint)_objMeshArray[i][j].GetBaseVertex(0);
                } else {
                    _LODArgs[i][j][0] = _LODArgs[i][j][1] = _LODArgs[i][j][2] = _LODArgs[i][j][3] = 0;
                }

                _LODArgsBuffer[i][j] = new ComputeBuffer(1, 5 * sizeof(uint), ComputeBufferType.IndirectArguments);
                _LODArgsBuffer[i][j].SetData(_LODArgs[i][j]);
            }
        }
    }

    public void InitializeBuffers() {
        _dataBuffer = new ComputeBuffer[DIFFERENTOBJECTS];

        _LODBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _dataBuffer[i] = new ComputeBuffer(_masterData[i].Count, 12 * sizeof(float) + 3 * sizeof(int));
            _dataBuffer[i].SetData(_masterData[i]);

            _LODBuffers[i] = new ComputeBuffer[LODSIZE];

            for (int j = 0; j < LODSIZE; j++) {
                _LODBuffers[i][j] = new ComputeBuffer(_masterData[i].Count, 12 * sizeof(float) + 3 * sizeof(int), ComputeBufferType.Append);
                _LODBuffers[i][j].SetCounterValue(0);
            }
        }
    }

    public void InitializeOther() {
        _matrixBuffer = new ComputeBuffer(TOTALOBJECTS, 16 * sizeof(float));
        _matrixData = new Matrix4x4[TOTALOBJECTS];
        _matrixBuffer.SetData(_matrixData);

        _boundingBuffer = new ComputeBuffer(DIFFERENTOBJECTS, 4 * sizeof(float));
        _boundingSpheres = new BoundingSphere[DIFFERENTOBJECTS];

        _meshBoundsSize = new Vector3[DIFFERENTOBJECTS];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _meshBoundsSize[i] = _objMeshArray[i][LODSIZE - 1].bounds.size;

            _boundingSpheres[i] = new BoundingSphere();
            _boundingSpheres[i].radius = Mathf.Max(Mathf.Max(_meshBoundsSize[i].x, _meshBoundsSize[i].y), _meshBoundsSize[i].z) * 0.1f;
        }
        _boundingBuffer.SetData(_boundingSpheres);

        _kCSMain = _computeShader.FindKernel("CSMain");
    }

    public void InitializeMaterials() {
        _mpbs = new MaterialPropertyBlock[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _mpbs[i] = new MaterialPropertyBlock[LODSIZE];

            for (int j = 0; j < LODSIZE; j++) {
                // Setup our materials
                _objMatArray[i][j].enableInstancing = true;
                _objMatArray[i][j].SetBuffer("dataBuffer", _LODBuffers[i][j]);
                _objMatArray[i][j].SetBuffer("matrixBuffer", _matrixBuffer);

                // Setup our dummy materialproperty blocks for shadowing
                _mpbs[i][j] = new MaterialPropertyBlock();
                _mpbs[i][j].SetFloat("DummyForShadows", i * LODSIZE + j);
            }
        }
    }

    /*
     * In general, UpdateObjects checks for conditions, reacts accordingly, and then
     * rotates and draws all of our objects
     */
    public override void UpdateObjects() {
        // If the emitter has moved
        if (_modelMatrix != _parent.transform.localToWorldMatrix) {
            _modelMatrix = _parent.transform.localToWorldMatrix;
            _computeShader.SetMatrix("modelMatrix", _modelMatrix);
        }

        //if (cachedInstanceCount != TOTALOBJECTS) {
        //    cachedInstanceCount = TOTALOBJECTS;
        //    Destroy();
        //    Reset();
        //}

        _cachedCamPosition = cam.transform.position;

        Matrix4x4 M = Matrix4x4.identity;
        Matrix4x4 V = cam.worldToCameraMatrix;
        Matrix4x4 P = cam.projectionMatrix;
        Matrix4x4 _MVP = P * V * M;

        RotatePositions();

        _computeShader.SetVector("LODRanges", _LODRanges);
        _computeShader.SetVector("camPos", _cachedCamPosition);
        _computeShader.SetMatrix("MVP", _MVP);

        _computeShader.SetBuffer(_kCSMain, "matrixBuffer", _matrixBuffer);
        _computeShader.SetBuffer(_kCSMain, "boundingBuffer", _boundingBuffer);

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {

            int instanceCount = _dataBuffer[i].count;

            _computeShader.SetBuffer(_kCSMain, "dataBuffer", _dataBuffer[i]);
            _computeShader.SetInt("instanceCount", instanceCount);

            _computeShader.SetBuffer(_kCSMain, "lod0Buffer", _LODBuffers[i][0]);
            _computeShader.SetBuffer(_kCSMain, "lod1Buffer", _LODBuffers[i][1]);
            _computeShader.SetBuffer(_kCSMain, "lod2Buffer", _LODBuffers[i][2]);
            _computeShader.SetBuffer(_kCSMain, "lod3Buffer", _LODBuffers[i][3]);

            for (int j = 0; j < LODSIZE; j++) {
                _LODBuffers[i][j].SetCounterValue(0);
            }

            _computeShader.Dispatch(_kCSMain, Mathf.CeilToInt(instanceCount / threadCount), 1, 1);

            for (int j = 0; j < LODSIZE; j++) {
                ComputeBuffer.CopyCount(_LODBuffers[i][j], _LODArgsBuffer[i][j], 4);
                //uint[] temp = new uint[5];
                //_LODArgsBuffer[i][j].GetData(temp);
                //int x = 5;
            }

            ObjInfo[] temp = new ObjInfo[_masterData[i].Count];
            _dataBuffer[i].GetData(temp);

            for (int j = 0; j < LODSIZE; j++) {
                Graphics.DrawMeshInstancedIndirect(_objMeshArray[i][j], 0, _objMatArray[i][j],
                    _objMeshArray[i][j].bounds, _LODArgsBuffer[i][j], 0, _mpbs[i][j]);
            }
        }
    }

    /*
     * Rotates all of the positions inside our LOD sections, and recreates our
     * cached objectPosition list so that we can share object positions between
     * different render modes
     */
    public void RotatePositions() {
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < _masterData[i].Count; j++) {
                // Set the positions of our instance based on our input List
                float scaleMag = _masterData[i][j].scale;
                Vector3 newPos = Quaternion.AngleAxis(
                    scaleMag * Time.deltaTime * 40,
                    Vector3.up) * _masterData[i][j].position;
                ObjInfo temp = _masterData[i][j];
                temp.position = new Vector4(newPos.x, newPos.y, newPos.z, 1);
                _masterData[i][j] = temp;
            }
            _dataBuffer[i].SetData(_masterData[i]);
        }
    }

    /*
     * When we switch render modes, we need to empty our buffers and destroy evidence
     * of instance rendering
     */
    public override void Destroy() {
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            if (_dataBuffer[i] != null)
                _dataBuffer[i].Release();
            _dataBuffer[i] = null;

            for (int j = 0; j < LODSIZE; j++) {
                if (_LODArgsBuffer[i][j] != null) {
                    _LODArgsBuffer[i][j].Release();
                }
                _LODArgsBuffer[i][j] = null;

                if (_LODBuffers[i][j] != null) {
                    _LODBuffers[i][j].Release();
                }
                _LODBuffers[i][j] = null;
            }
        }
        if (_matrixBuffer != null)
            _matrixBuffer.Release();
        if (_boundingBuffer != null) {
            _boundingBuffer.Release();
        }
        _dataBuffer = null;
        _boundingBuffer = null;
        _LODArgsBuffer = null;
        _LODBuffers = null;
        _matrixBuffer = null;
    }

    /*
     * What we want to do is sort by transparency, so that we can draw all opaque objects first
     * Second, we want to sort by distance from the camera, drawing objects from back to front
     */
    public int SortByTransparency(ObjInfo a, ObjInfo b) {
        return b.color[3].CompareTo(a.color[3]);
    }
    public int SortByDistanceFromCamera(ObjInfo a, ObjInfo b) {
        return Vector3.Distance(_cachedCamPosition, a.position).CompareTo(Vector3.Distance(_cachedCamPosition, b.position));
    }

    public void Reset() {
        InitializeArguments();
        InitializeBuffers();
        InitializeOther();
        InitializeMaterials();
    }
}
