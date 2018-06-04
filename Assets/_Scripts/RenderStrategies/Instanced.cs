using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    private const int LODSIZE = 4;
    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private Matrix4x4 _modelMatrix;
    private readonly MaterialPropertyBlock[] _mpb;
    private Vector3 _meshBoundsSize;
    private int _Kernel;

    private const float LOD1 = 0.0689f;
    private const float LOD2 = 0.0295f;
    private const float LOD3 = 0.00967f;
    private const float LODCULL = 0.001f;

    private readonly List<uint>[] _LODArgs;
    private List<ObjInfo>[] _LODData;
    private Matrix4x4[] _matrixData;

    private int cachedInstanceCount = -1;
    private ComputeBuffer[] _LODBuffers;
    private ComputeBuffer[] _LODArgsBuffer;
    private ComputeBuffer[] _matrixBuffers;

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
    public Instanced(GameObject p, GameObject o, Material mat, ComputeShader cs, List<ObjInfo> data, int total) : 
        base(p, o, mat, cs, data, total) {
        // Initialize our ComputeBuffers and lists
        _LODData = new List<ObjInfo>[LODSIZE];
        _LODBuffers = new ComputeBuffer[LODSIZE];

        _matrixBuffers = new ComputeBuffer[LODSIZE];

        _LODArgs = new List<uint>[LODSIZE];
        _LODArgsBuffer = new ComputeBuffer[LODSIZE];

        // Each list inside our _LODArgs is a 5 long, unisigned int array that holds arguments for
        // our draw call
        for (int i = 0; i < LODSIZE; i++) {
            _LODArgs[i] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });

            // Initialize our LODArgsBuffer, where each one holds one LODArgs
            _LODArgsBuffer[i] = new ComputeBuffer(1, _LODArgs[i].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
        }

        _mpb = new MaterialPropertyBlock[LODSIZE];
        for (int i = 0; i < LODSIZE; i++) {
            _mpb[i] = new MaterialPropertyBlock();
        }

        _meshBoundsSize = _objMeshArray[0].bounds.size;

        // Cache our cameras position
        _cachedCamPosition = cam.transform.position;

        // Set our parent model matrix and enable instancing
        _modelMatrix = _parent.transform.localToWorldMatrix;
        for (int i = 0; i < LODSIZE; i++) {
            _computeShaderArray[i].SetMatrix("modelMatrix", _modelMatrix);
            _objMatArray[i].enableInstancing = true;
        }

        _Kernel = _computeShader.FindKernel("InstanceMatrix");

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
            _objMat.SetMatrix("modelMatrix", _modelMatrix);
        }

        _cachedCamPosition = cam.transform.position;

        // Update starting position buffer
        if (cachedInstanceCount != TOTALOBJECTS)
            InitializeBuffers();

        RotatePositions();
        //UpdateBuffers();

        // Render based on LOD section
        for (int i = 0; i < LODSIZE; i++) {

            if (_LODBuffers[i] != null) {
                _computeShaderArray[i].Dispatch(_Kernel, _LODData[i].Count, 1, 1);

                _mpb[i].SetFloat("DummyForShadows", i);

                Graphics.DrawMeshInstancedIndirect(_objMeshArray[i], 0, _objMatArray[i], _objMeshArray[i].bounds, _LODArgsBuffer[i], 0, _mpb[i]);
            }
        }
    }

    /*
     * Initialize releases all of our buffers, calculates new LOD sections, and 
     * then finally resets all of our buffers with our new information inside our LODData
     */
    void InitializeBuffers() {
        ObjInfo[] tempData = new ObjInfo[TOTALOBJECTS];
        for (int i = 0; i < LODSIZE; i++) {
            _LODData[i] = new List<ObjInfo>();
        }

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the position of our instance
            tempData[i].position = _masterData[i].position;

            tempData[i].scale = _masterData[i].scale;

            Vector3 tempDataPos = new Vector3(tempData[i].position.x, tempData[i].position.y, tempData[i].position.z);

            float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
            float scal = tempData[i].scale.magnitude;
            float LODTest = 1f / dist * scal;

            // Based on the distance from the camera and an objects scale, assign it to a different LOD group
            if (LODTest < LODCULL) {
                continue;
            } else if (LODTest < LOD3) {
                tempData[i].color = Color.white;
                _LODData[3].Add(tempData[i]);
            } else if (LODTest < LOD2) {
                tempData[i].color = Color.green;
                _LODData[2].Add(tempData[i]);
            } else if (LODTest < LOD1) {
                tempData[i].color = Color.blue;
                _LODData[1].Add(tempData[i]);
            } else {
                tempData[i].color = Color.yellow;
                _LODData[0].Add(tempData[i]);
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
        List<ObjInfo>[] tempLODData = new List<ObjInfo>[LODSIZE];
        for (int i = 0; i < LODSIZE; i++) {
            tempLODData[i] = new List<ObjInfo>();
        }

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
        for (int i = 0; i < TOTALOBJECTS; i++) {
            Vector3 tempDataPos = new Vector3(_masterData[i].position.x, _masterData[i].position.y, _masterData[i].position.z);
            Vector3 tempScale = new Vector3(_masterData[i].scale.x, _masterData[i].scale.y, _masterData[i].scale.z);

            Bounds meshBounds = new Bounds(tempDataPos, new Vector3(
                _meshBoundsSize.x * tempScale.x,
                _meshBoundsSize.y * tempScale.y,
                _meshBoundsSize.z * tempScale.z));

            if (GeometryUtility.TestPlanesAABB(planes, meshBounds)) {
                float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
                float scal = _masterData[i].scale.magnitude;
                float LODTest = 1f / dist * scal;
                ObjInfo temp = _masterData[i];

                if (LODTest < LODCULL) {
                    continue;
                } else if (LODTest < LOD3) {
                    temp.color = Color.white;
                    _masterData[i] = temp;
                    tempLODData[3].Add(temp);
                } else if (LODTest < LOD2) {
                    temp.color = Color.green;
                    _masterData[i] = temp;
                    tempLODData[2].Add(temp);
                } else if (LODTest < LOD1) {
                    temp.color = Color.blue;
                    _masterData[i] = temp;
                    tempLODData[1].Add(temp);
                } else {
                    temp.color = Color.yellow;
                    _masterData[i] = temp;
                    tempLODData[0].Add(temp);
                }
            }
        }

        for (int i = 0; i < _LODData.Length; i++) {
            _LODData[i] = tempLODData[i];
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
        for (int i = 0; i < LODSIZE; i++) {
            if (_LODBuffers[i] != null) {
                _LODBuffers[i].Release();
                _LODBuffers[i] = null;
            }

            if (_matrixBuffers[i] != null) {
                _matrixBuffers[i].Release();
                _matrixBuffers[i] = null;
            }

            if (_LODData[i].Count > 0) {
                _LODBuffers[i] = new ComputeBuffer(_LODData[i].Count, 12 * sizeof(float));
                _LODBuffers[i].SetData(_LODData[i]);

                _matrixData = new Matrix4x4[_LODData[i].Count];
                _matrixBuffers[i] = new ComputeBuffer(_LODData[i].Count, 16 * sizeof(float));
                _matrixBuffers[i].SetData(_matrixData);

                _computeShaderArray[i].SetBuffer(_Kernel, "dataBuffer", _LODBuffers[i]);
                _computeShaderArray[i].SetBuffer(_Kernel, "matrixBuffer", _matrixBuffers[i]);

                _objMatArray[i].SetBuffer("dataBuffer", _LODBuffers[i]);
                _objMatArray[i].SetBuffer("matrixBuffer", _matrixBuffers[i]);
            }

            // Information for out LODArgs
            if (_objMeshArray[i] != null) {
                _LODArgs[i][0] = (uint)_objMeshArray[i].GetIndexCount(0);
                _LODArgs[i][1] = (uint)_LODData[i].Count;
                _LODArgs[i][2] = (uint)_objMeshArray[i].GetIndexStart(0);
                _LODArgs[i][3] = (uint)_objMeshArray[i].GetBaseVertex(0);
            } else {
                _LODArgs[i][0] = _LODArgs[i][1] = _LODArgs[i][2] = _LODArgs[i][3] = 0;
            }

            // Information for our LODArgsBuffers
            if (_LODArgsBuffer[i] != null) {
                _LODArgsBuffer[i].Release();
                _LODArgsBuffer[i] = null;
            }
            _LODArgsBuffer[i] = new ComputeBuffer(1, _LODArgs[i].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
            _LODArgsBuffer[i].SetData(_LODArgs[i]);
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
            float scaleMag = new Vector3(_masterData[i].scale.x, _masterData[i].scale.y, _masterData[i].scale.z).magnitude;
            Vector3 newPos = Quaternion.AngleAxis(
                scaleMag * scaleMag * Time.deltaTime * 100,
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
        for (int i = 0; i < _LODArgsBuffer.Length; i++) {
            if (_LODArgsBuffer[i] != null) {
                _LODArgsBuffer[i].Release();
            }
            _LODArgsBuffer[i] = null;

            if (_LODBuffers[i] != null)
                _LODBuffers[i].Release();
            _LODBuffers[i] = null;
        }
        _LODArgsBuffer = null;
        _LODBuffers = null;
    }
}
 