using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanced : RenderStrategy {

    /*
     * Data struct of information for each mesh
     */
    struct ObjInfo {
        public Vector4 position;
        public Vector4 color;
        public Vector4 scale;
    };

    private const int LODSIZE = 4;
    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private Matrix4x4 _modelMatrix;
    private readonly MaterialPropertyBlock[] _mpb;

    private readonly float LOD1 = 0.0689f;
    private readonly float LOD2 = 0.0295f;
    private readonly float LOD3 = 0.00967f;
    private readonly float LODCULL = 0.001f;

    private List<uint>[] _LODArgs;
    private List<ObjInfo>[] _LODData;

    private int cachedInstanceCount = -1;
    private ComputeBuffer[] _LODBuffers;
    private ComputeBuffer[] _LODArgsBuffer;

    /*
     * CLASS DOCUMENTATION: Instanced : RenderStrategy
     * In this class, we render a given set of objects as instanced meshes, instead of 
     * gameobjects. This gives us a big boost in performance as we are able to utilize
     * the GPU instead of the CPU, as well as send much fewer calls to the GPU.
     * 
     * We also are working on Level-Of-Detail in combination with instance rendering.
     * Currently, not functional. However, basic idea is that we have Lists of data and 
     * ComputeBuffers which forward that data to the shader, so that we can draw the meshes.
     */
    public Instanced(GameObject p, GameObject o, Material mat, List<Vector3> poses, int total) : 
        base(p, o, mat, poses, total) {
        // Initialize our ComputeBuffers and lists
        _LODData = new List<ObjInfo>[LODSIZE];
        _LODBuffers = new ComputeBuffer[LODSIZE];
        _LODArgs = new List<uint>[LODSIZE];
        _LODArgsBuffer = new ComputeBuffer[LODSIZE];

        _mpb = new MaterialPropertyBlock[LODSIZE];
        for (int i = 0; i < LODSIZE; i++) {
            _mpb[i] = new MaterialPropertyBlock();
        }

        // Each list inside our _LODArgs is a 5 long, unisigned int array that holds arguments for
        // our draw call
        for (int i = 0; i < LODSIZE; i++) {
            _LODArgs[i] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });

        // Initialize our LODArgsBuffer, where each one holds one LODArgs
            _LODArgsBuffer[i] = new ComputeBuffer(1, _LODArgs[i].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
        }

        // Cache our cameras position
        _cachedCamPosition = cam.transform.position;

        // Initialize our buffers
        InitializeBuffers();

        // Set our parent model matrix
        _modelMatrix = _parent.transform.localToWorldMatrix;
        _objMat.SetMatrix("modelMatrix", _modelMatrix);
        _objMat.enableInstancing = true;
    }

    /*
     * In general, UpdateObjects checks for conditions, reacts accordingly, and then
     * rotates and draws all of our objects
     */
    public override void UpdateObjects() {
        // If the emitter has moved
        if (_modelMatrix != _parent.transform.localToWorldMatrix) {
            _modelMatrix = _parent.transform.localToWorldMatrix;
            _objMat.SetMatrix("modelMatrix", _modelMatrix);
        }

        // If our camera has moved
        if (_cachedCamPosition != cam.transform.position) {
            _cachedCamPosition = cam.transform.position;
            UpdateBuffers();
        }

        // Update starting position buffer
        if (cachedInstanceCount != TOTALOBJECTS)
            InitializeBuffers();

        RotatePositions();

        // Render based on LOD section
        for (int i = 0; i < LODSIZE; i++) {

            if (_LODBuffers[i] != null) {
                _mpb[i].SetFloat("DummyForShadows", i);

                Graphics.DrawMeshInstancedIndirect(_objMeshArray[i], 0, _objMatArray[i], _objMeshArray[i].bounds, _LODArgsBuffer[i], 0, _mpb[i]);
            }
        }
    }

    /*
     * UpdateBuffers releases all of our buffers, calculates new LOD sections, and 
     * then finally resets all of our buffers with our new information inside our LODData
     */
    void InitializeBuffers() {
        ObjInfo[] data = new ObjInfo[TOTALOBJECTS];
        for (int i = 0; i < LODSIZE; i++) {
            _LODData[i] = new List<ObjInfo>();
        }

        for (int i = 0; i < TOTALOBJECTS; i++) {
            // Set the position of our instance
            data[i].position = new Vector4(_objPositions[i].x, _objPositions[i].y, _objPositions[i].z, 1);

            // Set the scale of our instance
            float xScale = Random.Range(0.01f, 0.15f);
            float yScale = Random.Range(0.01f, 0.15f);
            float zScale = Random.Range(0.01f, 0.15f);
            float w = 1;
            data[i].scale = new Vector4(xScale, yScale, zScale, w);

            Vector3 tempDataPos = new Vector3(data[i].position.x, data[i].position.y, data[i].position.z);

            float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
            float scal = data[i].scale.magnitude;
            float LODTest = 1f / dist * scal;

            // Based on the distance from the camera and an objects scale, assign it to a different LOD group
            if (LODTest < LODCULL) {
                continue;
            } else if (LODTest < LOD3) {
                data[i].color = Color.white;
                _LODData[3].Add(data[i]);
            } else if (LODTest < LOD2) {
                data[i].color = Color.green;
                _LODData[2].Add(data[i]);
            } else if (LODTest < LOD1) {
                data[i].color = Color.blue;
                _LODData[1].Add(data[i]);
            } else {
                data[i].color = Color.yellow;
                _LODData[0].Add(data[i]);
            }
        }

        UpdateLODBuffers();
        cachedInstanceCount = TOTALOBJECTS;
    }

    public void UpdateBuffers() {
        List<ObjInfo>[] tempLODData = new List<ObjInfo>[4];
        for (int i = 0; i < 4; i++) {
            tempLODData[i] = new List<ObjInfo>();
        }

        for (int i = 0; i < LODSIZE; i++) {
            for (int j = 0; j < _LODData[i].Count; j++) {
                Vector3 tempDataPos = new Vector3(_LODData[i][j].position.x, _LODData[i][j].position.y, _LODData[i][j].position.z);

                float dist = Vector3.Distance(tempDataPos, _cachedCamPosition);
                float scal = _LODData[i][j].scale.magnitude;
                float LODTest = 1f / dist * scal;
                ObjInfo temp = _LODData[i][j];

                // Based on the distance from the camera and an objects scale, assign it to a different LOD group
                if (LODTest < LODCULL) {
                    continue;
                } else if (LODTest < LOD3) {
                    temp.color = Color.white;
                    _LODData[i][j] = temp;
                    tempLODData[3].Add(temp);
                } else if (LODTest < LOD2) {
                    temp.color = Color.green;
                    _LODData[i][j] = temp;
                    tempLODData[2].Add(temp);
                } else if (LODTest < LOD1) {
                    temp.color = Color.blue;
                    _LODData[i][j] = temp;
                    tempLODData[1].Add(temp);
                } else {
                    temp.color = Color.yellow;
                    _LODData[i][j] = temp;
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

    private void UpdateLODBuffers() {
        // Initialize our Level-of-Detail computebuffers for our material
        for (int i = 0; i < LODSIZE; i++) {
            if (_LODBuffers[i] != null) {
                _LODBuffers[i].Release();
                _LODBuffers[i] = null;
            }
            if (_LODData[i].Count > 0) {
                _LODBuffers[i] = new ComputeBuffer(_LODData[i].Count, 12 * sizeof(float));
                _LODBuffers[i].SetData(_LODData[i]);
                _objMatArray[i].SetBuffer("dataBuffer", _LODBuffers[i]);
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
        _objPositions = new List<Vector3>();
        for (int i = 0; i < LODSIZE; i++) {
            for (int j = 0; j < _LODData[i].Count; j++) {
                // Set the positions of our instance based on our input List
                float scaleMag = new Vector3(_LODData[i][j].scale.x, _LODData[i][j].scale.y, _LODData[i][j].scale.z).magnitude;
                Vector3 newPos = Quaternion.AngleAxis(
                    scaleMag * scaleMag * Time.deltaTime * 100,
                    Vector3.up) * _LODData[i][j].position;
                ObjInfo temp = _LODData[i][j];
                temp.position = new Vector4(newPos.x, newPos.y, newPos.z, 1);
                _LODData[i][j] = temp;

                _objPositions.Add(temp.position);
            }

            if (_LODBuffers[i] != null)
                _LODBuffers[i].SetData(_LODData[i]);
            _objMatArray[i].SetBuffer("dataBuffer", _LODBuffers[i]);
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
 