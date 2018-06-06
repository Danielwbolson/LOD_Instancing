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
    private Plane[] _planes;

    private const float LOD1 = 0.0689f;
    private const float LOD2 = 0.0295f;
    private const float LOD3 = 0.00967f;
    private const float LODCULL = 0.001f;

    private readonly List<uint>[][] _LODArgs;
    private List<ObjInfo>[][] _LODData;
    private Matrix4x4[][][] _matrixData;
    private readonly MaterialPropertyBlock[][] _mpbs;
    private int[][] _cachedLODDataCount;

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
        _LODData = new List<ObjInfo>[DIFFERENTOBJECTS][];
        _cachedLODDataCount = new int[DIFFERENTOBJECTS][];
        _LODBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];
        _matrixData = new Matrix4x4[DIFFERENTOBJECTS][][];
        _matrixBuffers = new ComputeBuffer[DIFFERENTOBJECTS][];
        _LODArgs = new List<uint>[DIFFERENTOBJECTS][];
        _LODArgsBuffer = new ComputeBuffer[DIFFERENTOBJECTS][];

        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _LODData[i] = new List<ObjInfo>[LODSIZE];
            _cachedLODDataCount[i] = new int[LODSIZE];
            _LODBuffers[i] = new ComputeBuffer[LODSIZE];
            _matrixData[i] = new Matrix4x4[LODSIZE][];
            _matrixBuffers[i] = new ComputeBuffer[LODSIZE];
            _LODArgs[i] = new List<uint>[LODSIZE];
            _LODArgsBuffer[i] = new ComputeBuffer[LODSIZE];
            for (int j = 0; j < LODSIZE; j++) {
                _LODData[i][j] = new List<ObjInfo>();
                _cachedLODDataCount[i][j] = -1;
            }
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
        _planes = new Plane[6];

        // Initialize our buffers
        UpdateBuffers();
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

        //TransparencySorting();
        RotatePositions();
        UpdateBuffers();

        // Render based on LOD section
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            for (int j = 0; j < LODSIZE; j++) {

                if (_LODBuffers[i][j] != null) {
                    _computeShader.SetBuffer(_Kernel, "matrixBuffer", _matrixBuffers[i][j]);
                    _computeShader.SetBuffer(_Kernel, "dataBuffer", _LODBuffers[i][j]);
                    _computeShader.Dispatch(_Kernel, _cachedLODDataCount[i][j], 1, 1);
                    _mpbs[i][j].SetFloat("DummyForShadows", i * LODSIZE + j);

                    Graphics.DrawMeshInstancedIndirect(_objMeshArray[i][j], 0, _objMatArray[i][j],
                        _objMeshArray[i][j].bounds, _LODArgsBuffer[i][j], 0, _mpbs[i][j]);
                }
            }
        }
    }

    /*
     * Instead of initializing all data, we want to preserve what we already had. So instead we recalculate
     * LOD distancing and change up our buffers and data sets accordingly, all while preserving data
     */
    public void UpdateBuffers() {
        _LODData = new List<ObjInfo>[DIFFERENTOBJECTS][];
        for (int i = 0; i < DIFFERENTOBJECTS; i++) {
            _LODData[i] = new List<ObjInfo>[LODSIZE];
            for (int j = 0; j < LODSIZE; j++) {
                _LODData[i][j] = new List<ObjInfo>();
            }
        }

        //for (int i = 0; i < DIFFERENTOBJECTS; i++) {
        //    for (int j = 0; j < LODSIZE; j++) {
        //        _LODData[i][j].Clear();
        //    }
        //}

        GeometryUtility.CalculateFrustumPlanes(cam, _planes);
        Bounds meshBounds = new Bounds();
        for (int i = 0; i < TOTALOBJECTS; i++) {
            Vector3 tempDataPos = new Vector3(_masterData[i].position.x, _masterData[i].position.y, _masterData[i].position.z);
            float tempScale = _masterData[i].scale;
            int index = _masterData[i].objIndex;

            meshBounds.center = tempDataPos;
            meshBounds.size = new Vector3(
                _meshBoundsSize[index].x * tempScale,
                _meshBoundsSize[index].y * tempScale,
                _meshBoundsSize[index].z * tempScale);

            if (GeometryUtility.TestPlanesAABB(_planes, meshBounds)) {
                float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
                float LODTest = 0.9f / dist;

                ObjInfo temp = _masterData[i];

                // Based on the distance from the camera and an objects scale, assign it to a different LOD group
                if (LODTest < LODCULL) {
                    continue;
                } else if (LODTest < LOD3) {
                    temp.color = Color.white;
                    _LODData[index][3].Add(temp);
                } else if (LODTest < LOD2) {
                    temp.color = Color.green;
                    _LODData[index][2].Add(temp);
                } else if (LODTest < LOD1) {
                    temp.color = Color.blue;
                    _LODData[index][1].Add(temp);
                } else {
                    temp.color = Color.yellow;
                    _LODData[index][0].Add(temp);
                }

                temp.color[3] = _masterData[i].color[3];
                _masterData[i] = temp;
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
                // If our lod values have even changed
                if (_LODData[i][j].Count == _cachedLODDataCount[i][j] && _LODData[i][j].Count > 0) {
                    _LODBuffers[i][j].SetData(_LODData[i][j]);
                    _objMatArray[i][j].SetBuffer("dataBuffer", _LODBuffers[i][j]);
                } else {
                    _cachedLODDataCount[i][j] = _LODData[i][j].Count;
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
                        _LODArgs[i][j][1] = (uint)_cachedLODDataCount[i][j];
                        _LODArgs[i][j][2] = (uint)_objMeshArray[i][j].GetIndexStart(0);
                        _LODArgs[i][j][3] = (uint)_objMeshArray[i][j].GetBaseVertex(0);
                    } else {
                        _LODArgs[i][j][0] = _LODArgs[i][j][1] = _LODArgs[i][j][2] = _LODArgs[i][j][3] = 0;
                    }

                    if (_cachedLODDataCount[i][j] > 0) {
                        // Set up our model
                        _LODBuffers[i][j] = new ComputeBuffer(_cachedLODDataCount[i][j], 12 * sizeof(float) + 2 * sizeof(int));
                        _LODBuffers[i][j].SetData(_LODData[i][j]);

                        _LODArgsBuffer[i][j] = new ComputeBuffer(1, _LODArgs[i][j].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
                        _LODArgsBuffer[i][j].SetData(_LODArgs[i][j]);

                        _matrixData[i][j] = new Matrix4x4[_cachedLODDataCount[i][j]];
                        _matrixBuffers[i][j] = new ComputeBuffer(_cachedLODDataCount[i][j], 16 * sizeof(float));
                        _matrixBuffers[i][j].SetData(_matrixData[i][j]);

                        _objMatArray[i][j].SetBuffer("dataBuffer", _LODBuffers[i][j]);
                        _objMatArray[i][j].SetBuffer("matrixBuffer", _matrixBuffers[i][j]);
                    }
                }
            }
        }
    }

    /*
     * Sort all our meshes first by transparency, so that our Opaque meshes are drawn first.
     * Secondly by their distance from the camera so that transparent objects further away are drawn first
     */
    public void TransparencySorting() {
        if (cachedInstanceCount != TOTALOBJECTS)
            _masterData.Sort(SortByTransparency);

        List<ObjInfo> temp = new List<ObjInfo>();
        int i = 0;

        while (_masterData[i].color[3] > 0.99f) {
            temp.Add(_masterData[i]);
            _masterData.Remove(_masterData[i]);
            i++;
        }
        _masterData.Sort(SortByDistanceFromCamera);
        temp.AddRange(_masterData);
        _masterData = temp;
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
     * Calculate the LOD index of a mesh
     */
     public int LODIndex(Vector3 o) {
        float dist = Vector3.Distance(o, _cachedCamPosition);
        float LODTest = 0.9f / dist;
        if (LODTest < LODCULL) {
            return -1;
        } else if (LODTest < LOD3) {
            return 3;
        } else if (LODTest < LOD2) {
            return 2;
        } else if (LODTest < LOD1) {
            return 1;
        } else {
            return 0;
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
}
