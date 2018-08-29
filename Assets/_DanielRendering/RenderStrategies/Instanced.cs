using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    struct BoundingSphere {
        public Vector3 position;
        public float radius;
    };

    private const int LODSIZE = 3;
    private int cachedInstanceCount;
    private int cachedObjCount;
    private const float threadCount = 64.0f;

    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private Matrix4x4 _modelMatrix;
    private Vector3[] _meshBoundsSize;
    private BoundingSphere[] _boundingSpheres;
    private int _kCSMain;

    private const float LOD0 = .7f;
    private const float LOD1 = .3f;
    private const float LOD2 = .01f;
    //private const float LOD3 = .01f;

    private readonly Vector4 _LODRanges = new Vector4(LOD0, LOD1, LOD2);
    private readonly string[] lodBuffers = new string[4] { "lod0Buffer", "lod1Buffer", "lod2Buffer", "lod3Buffer" };

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
     * screen. Level-of-Detail is calculated on the GPU using AppendBuffers based on distance from
     * the camera.
     * 
     * Frustrum culling is also being calculated on the GPU, using our BoundingSphere struct. We get 
     * a radius, scaled to the size of our drawn meshes, and then send that to the GPU.
     */
    public Instanced(GameObject p, GameObject[] o, Material mat, ComputeShader cs, List<ObjInfo>[] data, int total) :
        base(p, o, mat, cs, data, total) {

        cachedInstanceCount = total;
        cachedObjCount = o.Length;

        // Initialization
        InitializeArguments();
        InitializeBuffers();
        InitializeMaterials();
        InitializeComputeShader();

    }

    /*
     * Initialize our Level-of-detail arguments and their buffers
     */
    public void InitializeArguments() {
        _LODArgs = new List<uint>[DIFFERENTOBJECTS][];
        _LODArgsBuffer = new ComputeBuffer[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            int currDataCount = _masterData[i].Count;

            _LODArgs[i] = new List<uint>[LODSIZE];
            _LODArgsBuffer[i] = new ComputeBuffer[LODSIZE];

            for (int j = 0; j < LODSIZE; j++) {
                _LODArgs[i][j] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });
                if (_objMeshArray[i][j] != null) {
                    _LODArgs[i][j][0] = (uint)_objMeshArray[i][j].GetIndexCount(0);
                    _LODArgs[i][j][1] = (uint)currDataCount;
                    _LODArgs[i][j][2] = (uint)_objMeshArray[i][j].GetIndexStart(0);
                    _LODArgs[i][j][3] = (uint)_objMeshArray[i][j].GetBaseVertex(0);
                } else {
                    _LODArgs[i][j][0] = _LODArgs[i][j][1] = _LODArgs[i][j][2] = _LODArgs[i][j][3] = 0;
                }

                // Each argsbuffer holds one LODArgs
                _LODArgsBuffer[i][j] = new ComputeBuffer(1, 5 * sizeof(uint), ComputeBufferType.IndirectArguments);
                _LODArgsBuffer[i][j].SetData(_LODArgs[i][j]);
            }
        }
    }

    /*
     * Initialize our dataBuffers for each different Object, and our level-of-detail
     * buffers that will fill in as the dataBuffer for each material. Also initialize our
     * master MatrixBuffer to keep track of locations of all meshes as well as our 
     * BoundingSpheres and boundingBuffers, to calculate frustrum culling in the GPU.
     */
    public void InitializeBuffers() {
        // DataBuffer for each different object
        _dataBuffer = new ComputeBuffer[DIFFERENTOBJECTS];

        // Level of detail buffer for each different object and all its LOD's
        _LODBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];

        // Matrix Buffer to hold positions of all meshes
        if (TOTALOBJECTS > 0) {
            _matrixBuffer = new ComputeBuffer(TOTALOBJECTS, 16 * sizeof(float));
            _matrixData = new Matrix4x4[TOTALOBJECTS];
            _matrixBuffer.SetData(_matrixData);
        }

        // MeshSize for each different object, assuming that different LOD share the same size
        _meshBoundsSize = new Vector3[DIFFERENTOBJECTS];

        // BoundingBuffer that holds a bounding sphere for each different object
        if (DIFFERENTOBJECTS > 0) {
            _boundingBuffer = new ComputeBuffer(DIFFERENTOBJECTS, 4 * sizeof(float));
            _boundingSpheres = new BoundingSphere[DIFFERENTOBJECTS];
        }

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            int currDataCount = _masterData[i].Count;
            if (currDataCount > 0) {
                // Our dataBuffer corresponds with our section of MasterData for that object
                _dataBuffer[i] = new ComputeBuffer(currDataCount, 14 * sizeof(float) + 3 * sizeof(int));
                _dataBuffer[i].SetData(_masterData[i]);
            }

            _LODBuffers[i] = new ComputeBuffer[LODSIZE];

            // Setting size as the bounds of the lowest LOD for each object, as I would guess the
            // lowest lod allows for fastest calculation
            _meshBoundsSize[i] = _objMeshArray[i][LODSIZE - 1].bounds.size;

            // Get the maximum bounds size of our mesh and use it as our radius
            _boundingSpheres[i] = new BoundingSphere {
                radius = Mathf.Max(Mathf.Max(_meshBoundsSize[i].x, _meshBoundsSize[i].y), _meshBoundsSize[i].z)
            };

            for (int j = 0; j < LODSIZE; j++) {
                // Initialize our lod-buffers, much the same as our dataBuffers but will be expanding
                // and changing based on which lod meshes fit in at each update
                if (currDataCount > 0) {
                    _LODBuffers[i][j] = new ComputeBuffer(currDataCount, 14 * sizeof(float) + 3 * sizeof(int), ComputeBufferType.Append);
                    _LODBuffers[i][j].SetCounterValue(0);
                }
            }
        }
        if (_boundingBuffer != null)
            _boundingBuffer.SetData(_boundingSpheres);
    }

    /*
     * Initialize our MaterialPropertyBlocks and materials. We need one mpb and one material
     * for each LOD of each object. One material cannot be written to with DrawMeshInstancedIndirect
     * more than once each frame, so to draw everything every frame, we need a material for each
     * draw call.
     * We need multiple MPB's for a dumby fix around shadowing
     */
    public void InitializeMaterials() {
        if (DIFFERENTOBJECTS > 0) {
            // MPB's for each LOD and mesh
            _mpbs = new MaterialPropertyBlock[DIFFERENTOBJECTS][];

            for (int i = 0; i < DIFFERENTOBJECTS; i++) {
                _mpbs[i] = new MaterialPropertyBlock[LODSIZE];

                for (int j = 0; j < LODSIZE; j++) {
                    // Setup our materials
                    _objMatArray[i][j].enableInstancing = true;

                    if (_LODBuffers[i][j] != null)
                        _objMatArray[i][j].SetBuffer("dataBuffer", _LODBuffers[i][j]);

                    if (_matrixBuffer != null)
                        _objMatArray[i][j].SetBuffer("matrixBuffer", _matrixBuffer);

                    if (_bumpMaps[i][j] != null && _bumpMapsEnabled) {
                        _objMatArray[i][j].SetTexture("_BumpMap", _bumpMaps[i][j]);
                        _objMatArray[i][j].shaderKeywords = new string[1] { "_NORMALMAP" };
                    } else {
                        _objMatArray[i][j].SetTexture("_BumpMap", null);
                        _objMatArray[i][j].shaderKeywords = new string[0];
                    }

                    // Setup our dummy materialproperty blocks for shadowing
                    _mpbs[i][j] = new MaterialPropertyBlock();
                    _mpbs[i][j].SetFloat("DummyForShadows", i * LODSIZE + j);
                }
            }
        }
    }

    /*
     * Set up data for our computeShader that will not be changing. Dynamic data is set
     * every update.
     */
    public void InitializeComputeShader() {
        if (_matrixBuffer != null)
            _computeShader.SetBuffer(_kCSMain, "matrixBuffer", _matrixBuffer);

        if (_boundingBuffer != null)
            _computeShader.SetBuffer(_kCSMain, "boundingBuffer", _boundingBuffer);

        _computeShader.SetVector("LODRanges", _LODRanges);

        // Get our ComputeShader Kernel
        _kCSMain = _computeShader.FindKernel("CSMain");
    }

    /*
     * In general, UpdateMeshes checks for some conditions, and then sets up our 
     * computeShader accordingly with new information. It then calls the computeshader
     * and draws the results.
     */
    public override void UpdateMeshes() {
        // If the emitter has moved
        if (_modelMatrix != _parent.transform.localToWorldMatrix) {
            _modelMatrix = _parent.transform.localToWorldMatrix;
            _computeShader.SetMatrix("modelMatrix", _modelMatrix);
        }

        // If our number of objects has changed, reset our buffers
        if (cachedInstanceCount != TOTALOBJECTS || cachedObjCount != DIFFERENTOBJECTS) {
            cachedInstanceCount = TOTALOBJECTS;
            cachedObjCount = DIFFERENTOBJECTS;
            Destroy();
            Reset();
        }

        if (_cachedDebug != _debug) {
            for (int i = 0; i < DIFFERENTOBJECTS; i++) {
                for (int j = 0; j < LODSIZE; j++) {
                    _objMatArray[i][j].SetInt("debug", _debug);
                }
            }
            _cachedDebug = _debug;
        }

        if (_cachedBumpMapsEnabled != _bumpMapsEnabled) {
            for (int i = 0; i < DIFFERENTOBJECTS; i++) {
                for (int j = 0; j < LODSIZE; j++) {
                    if (_bumpMaps[i][j] != null && _bumpMapsEnabled) {
                        _objMatArray[i][j].SetTexture("_BumpMap", _bumpMaps[i][j]);
                        _objMatArray[i][j].shaderKeywords = new string[1] { "_NORMALMAP" };
                    } else {
                        _objMatArray[i][j].SetTexture("_BumpMap", null);
                        _objMatArray[i][j].shaderKeywords = new string[0];
                    }
                }
            }
            _cachedBumpMapsEnabled = _bumpMapsEnabled;
        }

        _cachedCamPosition = cam.gameObject.transform.position;
        Vector3 up = cam.gameObject.transform.up;

        // Calculate our MVP matrix for use in the computeshader
        Matrix4x4 M = Matrix4x4.identity;
        Matrix4x4 V = cam.worldToCameraMatrix;
        Matrix4x4 P = cam.projectionMatrix;
        Matrix4x4 _MVP = P * V * M;

        RotatePositions();

        _computeShader.SetVector("camPos", _cachedCamPosition);
        _computeShader.SetMatrix("MVP", _MVP);
        _computeShader.SetVector("up", up);

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {

            // Only draw and calculate if we have data
            if (_dataBuffer[i] != null) {
                int instanceCount = _dataBuffer[i].count;

                _computeShader.SetBuffer(_kCSMain, "dataBuffer", _dataBuffer[i]);
                _computeShader.SetInt("instanceCount", instanceCount);

                // Set our buffers in the ComputeShader and set their count to 0 so they are ready
                // to be appended
                for (int j = 0; j < LODSIZE; j++) {
                    if (_LODBuffers[i][j] != null) {
                        _computeShader.SetBuffer(_kCSMain, lodBuffers[j], _LODBuffers[i][j]);
                        _LODBuffers[i][j].SetCounterValue(0);
                    }
                }

                // Call our computeshader to move meshes to the appropriate lod buffers and do Frustrum culling
                _computeShader.Dispatch(_kCSMain, Mathf.CeilToInt(instanceCount / threadCount), 1, 1);

                // Copy how many meshes we have to draw, and draw them
                for (int j = 0; j < LODSIZE; j++) {
                    ComputeBuffer.CopyCount(_LODBuffers[i][j], _LODArgsBuffer[i][j], 4);

                    Graphics.DrawMeshInstancedIndirect(_objMeshArray[i][j], 0, _objMatArray[i][j],
                        new Bounds(Vector3.zero, new Vector3(1000, 1000, 1000)), _LODArgsBuffer[i][j], 0, _mpbs[i][j]);
                }
            }
        }
    }

    /*
     * Rotates all of the positions inside our LOD sections, and recreates our
     * cached objectPosition list so that we can share object positions between
     * different render modes.
     */
    public void RotatePositions() {
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            if (_dataBuffer[i] != null) {
                for (int j = 0; j < _masterData[i].Count; j++) {
                    // Set the positions of our instance based on our input List
                    float scaleMag = _masterData[i][j].scale.magnitude;
                    Vector3 newPos = Quaternion.AngleAxis(
                        scaleMag * Time.deltaTime,
                        Vector3.up) * _masterData[i][j].position;
                    ObjInfo temp = _masterData[i][j];
                    temp.position = new Vector4(newPos.x, newPos.y, newPos.z, 1);
                    _masterData[i][j] = temp;
                }
                _dataBuffer[i].SetData(_masterData[i]);
            }
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

    // Recalls our Initialization
    public void Reset() {
        InitializeArguments();
        InitializeBuffers();
        InitializeMaterials();
        InitializeComputeShader();
    }
}