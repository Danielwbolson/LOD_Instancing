using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    private const int LODSIZE = 4;
    private int cachedInstanceCount = -1;

    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private Matrix4x4 _modelMatrix;
    private readonly Vector3[] _meshBoundsSize;
    private readonly int _Kernel;

    private const float LOD1 = 0.0689f;
    private const float LOD2 = 0.0295f;
    private const float LOD3 = 0.00967f;
    private const float LODCULL = 0.001f;

    private readonly List<uint>[][] _LODArgs;
    private List<ObjInfo>[][] _LODData;
    private Matrix4x4[] _matrixData;
    private readonly MaterialPropertyBlock[][] _mpbs;

    private ComputeBuffer[][] _LODBuffers;
    private ComputeBuffer[][] _LODArgsBuffer;
    private ComputeBuffer[][] _matrixBuffers;

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
    public Instanced(GameObject p, GameObject[] o, Material mat, ComputeShader cs, List<ObjInfo> data, int total) :
        base(p, o, mat, cs, data, total) {
        // Initialize our ComputeBuffers and lists
        _LODBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];
        _matrixBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];
        _LODArgs = new List<uint>[DIFFERENTOBJECTS][];
        _LODArgsBuffer = new ComputeBuffer[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _LODBuffers[i] = new ComputeBuffer[LODSIZE];
            _matrixBuffers[i] = new ComputeBuffer[LODSIZE];
            _LODArgs[i] = new List<uint>[LODSIZE];
            _LODArgsBuffer[i] = new ComputeBuffer[LODSIZE];
        }

        // Each list inside our _LODArgs is a 5 long, unisigned int array that holds arguments for
        // our draw call. We need to set up our buffer to deal with that
        _meshBoundsSize = new Vector3[DIFFERENTOBJECTS];
        _mpbs = new MaterialPropertyBlock[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _meshBoundsSize[i] = _objMeshArray[i][LODSIZE - 1].bounds.size;
            _mpbs[i] = new MaterialPropertyBlock[LODSIZE];
            for (int j = 0; j < LODSIZE; j++) {
                _LODArgs[i][j] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });

                // Initialize our LODArgsBuffer, where each one holds one LODArgs
                _LODArgsBuffer[i][j] = new ComputeBuffer(1, _LODArgs[i][j].Count * sizeof(uint), ComputeBufferType.IndirectArguments);

                // Setup our materials
                _objMatArray[i][j].enableInstancing = true;

                // Setup our dummy materialproperty blocks for shadowing
                _mpbs[i][j] = new MaterialPropertyBlock();
            }
        }

        // Cache our cameras position
        _cachedCamPosition = cam.transform.position;

        // Set our parent model matrix and enable instancing
        _modelMatrix = _parent.transform.localToWorldMatrix;
        _computeShader.SetMatrix("modelMatrix", _modelMatrix);

        _Kernel = _computeShader.FindKernel("CSMain");

        // Initialize our buffers
        InitializeBuffers();
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

        _cachedCamPosition = cam.transform.position;

        // Update starting position buffer
        if (cachedInstanceCount != TOTALOBJECTS)
            InitializeBuffers();

        RotatePositions();
        UpdateBuffers();

        // Render based on LOD section
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < LODSIZE; j++) {

                if (_LODBuffers[i][j] != null) {
                    _computeShader.SetBuffer(_Kernel, "matrixBuffer", _matrixBuffers[i][j]);
                    _computeShader.SetBuffer(_Kernel, "dataBuffer", _LODBuffers[i][j]);
                    _computeShader.Dispatch(_Kernel, _LODData[i][j].Count, 1, 1);
                    _mpbs[i][j].SetFloat("DummyForShadows", i * LODSIZE + j);

                    Graphics.DrawMeshInstancedIndirect(_objMeshArray[i][j], 0, _objMatArray[i][j],
                        _objMeshArray[i][j].bounds, _LODArgsBuffer[i][j], 0, _mpbs[i][j]);
                }
            }
        }
    }

    /*
     * Initialize releases all of our buffers, calculates new LOD sections, and 
     * then finally resets all of our buffers with our new information inside our LODData
     */
    void InitializeBuffers() {
        ObjInfo[] tempData = new ObjInfo[TOTALOBJECTS];

        _LODData = new List<ObjInfo>[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _LODData[i] = new List<ObjInfo>[LODSIZE];
            for (int j = 0; j < LODSIZE; j++) {
                _LODData[i][j] = new List<ObjInfo>();
            }
        }

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the position of our instance
            tempData[i] = _masterData[i];
            int index = _masterData[i].objIndex;

            Vector3 tempDataPos = new Vector3(tempData[i].position.x, tempData[i].position.y, tempData[i].position.z);

            float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
            float LODTest = 1f / dist * tempData[i].scale * 8;

            // Based on the distance from the camera and an objects scale, assign it to a different LOD group
            if (LODTest < LODCULL) {
                continue;
            } else if (LODTest < LOD3) {
                tempData[i].color = Color.white;
                _LODData[index][3].Add(tempData[i]);
            } else if (LODTest < LOD2) {
                tempData[i].color = Color.green;
                _LODData[index][2].Add(tempData[i]);
            } else if (LODTest < LOD1) {
                tempData[i].color = Color.blue;
                _LODData[index][1].Add(tempData[i]);
            } else {
                tempData[i].color = Color.yellow;
                _LODData[index][0].Add(tempData[i]);
            }
            _masterData[i] = tempData[i];
        }

        UpdateLODBuffers();
        cachedInstanceCount = TOTALOBJECTS;
    }

    /*
     * Instead of initializing all data, we want to preserve what we already had. So instead we recalculate
     * LOD distancing and change up our buffers and data sets accordingly, all while preserving data
     */
    public void UpdateBuffers() {
        List<ObjInfo>[][] tempLODData = new List<ObjInfo>[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            tempLODData[i] = new List<ObjInfo>[LODSIZE];
            for (int j = 0; j < LODSIZE; j++) {
                tempLODData[i][j] = new List<ObjInfo>();
            }
        }

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
        for (int i = 0; i < TOTALOBJECTS; i++) {
            Vector3 tempDataPos = new Vector3(_masterData[i].position.x, _masterData[i].position.y, _masterData[i].position.z);
            float tempScale = _masterData[i].scale;
            int index = _masterData[i].objIndex;

            Bounds meshBounds = new Bounds(tempDataPos, new Vector3(
                _meshBoundsSize[index].x * tempScale,
                _meshBoundsSize[index].y * tempScale,
                _meshBoundsSize[index].z * tempScale));

            if (GeometryUtility.TestPlanesAABB(planes, meshBounds)) {
                float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
                float LODTest = 1f / dist * tempScale * 8;
                ObjInfo temp = _masterData[i];

                if (LODTest < LODCULL) {
                    continue;
                } else if (LODTest < LOD3) {
                    temp.color = Color.white;
                    tempLODData[index][3].Add(temp);
                } else if (LODTest < LOD2) {
                    temp.color = Color.green;
                    tempLODData[index][2].Add(temp);
                } else if (LODTest < LOD1) {
                    temp.color = Color.blue;
                    tempLODData[index][1].Add(temp);
                } else {
                    temp.color = Color.yellow;
                    tempLODData[index][0].Add(temp);
                }
                _masterData[i] = temp;
            }
        }

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < LODSIZE; j++) {
                _LODData[i][j] = tempLODData[i][j];
            }
        }

        UpdateLODBuffers();
        cachedInstanceCount = TOTALOBJECTS;
    }

    /*
     * Reconfigures our material buffers for Level-of-Detail, assuming that we have new information or
     * at least information has changed locations
     */
    private void UpdateLODBuffers() {
        // Initialize our Level-of-Detail computebuffers for our material
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < LODSIZE; j++) {
                // Release current buffers
                if (_LODBuffers[i][j] != null) {
                    _LODBuffers[i][j].Release();
                    _LODBuffers[i][j] = null;
                }
                if (_LODArgsBuffer[i][j] != null) {
                    _LODArgsBuffer[i][j].Release();
                    _LODArgsBuffer[i][j] = null;
                }
                if (_matrixBuffers[i][j] != null) {
                    _matrixBuffers[i][j].Release();
                    _matrixBuffers[i][j] = null;
                }
                if (_objMeshArray[i][j] != null) {
                    _LODArgs[i][j][0] = (uint)_objMeshArray[i][j].GetIndexCount(0);
                    _LODArgs[i][j][1] = (uint)_LODData[i][j].Count;
                    _LODArgs[i][j][2] = (uint)_objMeshArray[i][j].GetIndexStart(0);
                    _LODArgs[i][j][3] = (uint)_objMeshArray[i][j].GetBaseVertex(0);
                } else {
                    _LODArgs[i][j][0] = _LODArgs[i][j][1] = _LODArgs[i][j][2] = _LODArgs[i][j][3] = 0;
                }

                // If we have data waiting to enter a buffer, set up our model
                if (_LODData[i][j].Count > 0) {
                    _LODBuffers[i][j] = new ComputeBuffer(_LODData[i][j].Count, 12 * sizeof(float) + 1 * sizeof(int));
                    _LODBuffers[i][j].SetData(_LODData[i][j]);

                    _LODArgsBuffer[i][j] = new ComputeBuffer(1, _LODArgs[i][j].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
                    _LODArgsBuffer[i][j].SetData(_LODArgs[i][j]);

                    _matrixData = new Matrix4x4[_LODData[i][j].Count];
                    _matrixBuffers[i][j] = new ComputeBuffer(_LODData[i][j].Count, 16 * sizeof(float));
                    _matrixBuffers[i][j].SetData(_matrixData);

                    _objMatArray[i][j].SetBuffer("dataBuffer", _LODBuffers[i][j]);
                    _objMatArray[i][j].SetBuffer("matrixBuffer", _matrixBuffers[i][j]);
                }
            }
        }
    }

    /*
     * Rotates all of the positions inside our LOD sections, and recreates our
     * cached objectPosition list so that we can share object positions between
     * different render modes
     */
    public void RotatePositions() {
        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the positions of our instance based on our input List
            float scaleMag = _masterData[i].scale;
            Vector3 newPos = Quaternion.AngleAxis(
                scaleMag * Time.deltaTime * 40,
                Vector3.up) * _masterData[i].position;
            ObjInfo temp = _masterData[i];
            temp.position = new Vector4(newPos.x, newPos.y, newPos.z, 1);
            _masterData[i] = temp;
        }
    }

    /*
     * When we switch render modes, we need to empty our buffers and destroy evidence
     * of instance rendering
     */
    public override void Destroy() {
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < LODSIZE; j++) {
                if (_LODArgsBuffer[i][j] != null) {
                    _LODArgsBuffer[i][j].Release();
                }
                _LODArgsBuffer[i][j] = null;

                if (_LODBuffers[i][j] != null) {
                    _LODBuffers[i][j].Release();
                }
                _LODBuffers[i][j] = null;

                if (_matrixBuffers[i][j] != null) {
                    _matrixBuffers[i][j].Release();
                }
                _matrixBuffers[i][j] = null;
            }
        }
        _LODArgsBuffer = null;
        _LODBuffers = null;
        _matrixBuffers = null;
    }
}
 