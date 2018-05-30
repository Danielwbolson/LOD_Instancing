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

    private Camera cam = Camera.main;
    private Vector3 _cachedCamPosition;
    private int subMeshIndex = 0;
    private Matrix4x4 _modelMatrix;
    private Mesh _objMesh;
    private GameObject _instancedObject;

    private float LOD0 = 0.60f;
    private float LOD1 = 0.25f;
    private float LOD2 = 0.08f;
    private float LOD3 = 100;

    private string[] _keywords = { "LOD0", "LOD1", "LOD2", "LOD3" };
    private string _recentKeyword = "LOD0";

    private List<uint>[] _LODArgs;
    private List<ObjInfo>[] _LODData;

    private int cachedInstanceCount = -1;
    private int cachedSubMeshIndex = -1;
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
        _LODBuffers = new ComputeBuffer[4];
        _LODArgs = new List<uint>[4];
        _LODArgsBuffer = new ComputeBuffer[4];
        _LODData = new List<ObjInfo>[4];

        // Each list inside our _LODArgs is a 5 long, unisigned int array that holds arguments for
        // our draw call
        for (int i = 0; i < 4; i++) {
            _LODArgs[i] = new List<uint>(new uint[] { 0, 0, 0, 0, 0 });
        }
        // Get references to our object and our mesh
        _instancedObject = o;
        _objMesh = _objMeshArray[1];

        // Initialize our LODArgsBuffer, where each one holds one LODArgs
        for (int i = 0; i < _LODArgsBuffer.Length; i++) {
            _LODArgsBuffer[i] = new ComputeBuffer(1, _LODArgs[i].Count * sizeof(uint), ComputeBufferType.IndirectArguments);
        }
        // Initialize our buffers
        UpdateBuffers();

        // Set our parent model matrix
        _modelMatrix = _parent.transform.localToWorldMatrix;
        _objMat.SetMatrix("modelMatrix", _modelMatrix);
        _objMat.enableInstancing = true;

        // Cache our cameras position
        _cachedCamPosition = cam.transform.position;
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
        if (_cachedCamPosition != cam.transform.position)
            _cachedCamPosition = cam.transform.position;

        // Update starting position buffer
        if (cachedInstanceCount != TOTALOBJECTS || cachedSubMeshIndex != subMeshIndex)
            UpdateBuffers();

        RotatePositions();

        // Render based on LOD section
        for (int i = 0; i < _LODArgsBuffer.Length; i++) {
            _objMat.DisableKeyword(_recentKeyword);
            _objMat.EnableKeyword(_keywords[i]);
            _recentKeyword = _keywords[i];
            if (_LODArgsBuffer[i] != null)
                Graphics.DrawMeshInstancedIndirect(_objMeshArray[i], subMeshIndex, _objMat, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), _LODArgsBuffer[i]);
        }
    }

    /*
     * UpdateBuffers releases all of our buffers, calculates new LOD sections, and 
     * then finally resets all of our buffers with our new information inside our LODData
     */
    void UpdateBuffers() {
        // Ensure submesh index is in range
        if (_objMesh != null)
            subMeshIndex = Mathf.Clamp(subMeshIndex, 0, _objMesh.subMeshCount - 1);

        ObjInfo[] data = new ObjInfo[TOTALOBJECTS];
        for (int i = 0; i < _LODData.Length; i++) {
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

            float dist = Vector3.Distance(data[i].position, _cachedCamPosition);
            float scal = data[i].scale.magnitude;

            if (1 / dist * scal < 0.00967f && 1 / dist * scal > 0.001f) {
                data[i].color = Color.white;
                _LODData[3].Add(data[i]);
            } else if (1 / dist * scal < 0.0295f) {
                data[i].color = Color.green;
                _LODData[2].Add(data[i]);
            } else if (1 / dist * scal < 0.0689f) {
                data[i].color = Color.blue;
                _LODData[1].Add(data[i]);
            } else {
                data[i].color = Color.yellow;
                _LODData[0].Add(data[i]);
            }
        }

        for (int i = 0; i < _LODBuffers.Length; i++) {
            if (_LODBuffers[i] != null) {
                _LODBuffers[i].Release();
            }
            if (_LODData[i].Count > 0) {
                _LODBuffers[i] = new ComputeBuffer(_LODData[i].Count, 12 * sizeof(float));
                _LODBuffers[i].SetData(_LODData[i]);
            }
        }

        _objMat.SetBuffer("LOD0Buffer", _LODBuffers[0]);
        _objMat.SetBuffer("LOD1Buffer", _LODBuffers[1]);
        _objMat.SetBuffer("LOD2Buffer", _LODBuffers[2]);
        _objMat.SetBuffer("LOD3Buffer", _LODBuffers[3]);

        // Information for out LODArgs
        if (_objMesh != null) {
            for (int i = 0; i < _LODArgs.Length; i++) {
                _LODArgs[i][0] = (uint)_objMesh.GetIndexCount(subMeshIndex);
                _LODArgs[i][1] = (uint)_LODData[i].Count;
                _LODArgs[i][2] = (uint)_objMesh.GetIndexStart(subMeshIndex);
                _LODArgs[i][3] = (uint)_objMesh.GetBaseVertex(subMeshIndex);
            }
        } else {
            for (int i = 0; i < _LODArgs.Length; i++) {
                _LODArgs[i][0] = _LODArgs[i][1] = _LODArgs[i][2] = _LODArgs[i][3] = 0;
            }
        }

        for (int i = 0; i < _LODArgsBuffer.Length; i++) {
            _LODArgsBuffer[i].SetData(_LODArgs[i]);
        }

        cachedInstanceCount = TOTALOBJECTS;
        cachedSubMeshIndex = subMeshIndex;
    }

    /*
     * Rotates all of the positions inside our LOD sections, and recreates our
     * cached objectPosition list so that we can share object positions between
     * different render modes
     */
    void RotatePositions() {
        _objPositions = new List<Vector3>();
        for (int i = 0; i < _LODData.Length; i++) {
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
        }
        for (int i = 0; i < _LODBuffers.Length; i++) {
            if (_LODBuffers[i] != null)
                _LODBuffers[i].SetData(_LODData[i]);
        }
        _objMat.SetBuffer("LOD0Buffer", _LODBuffers[0]);
        _objMat.SetBuffer("LOD1Buffer", _LODBuffers[1]);
        _objMat.SetBuffer("LOD2Buffer", _LODBuffers[2]);
        _objMat.SetBuffer("LOD3Buffer", _LODBuffers[3]);
    }

    // Sorts a List or Array of vector3's by how far they are from the camera
    void Sort() {
        _objPositions.Sort(SortByDistanceToCamera);
    }
    static int SortByDistanceToCamera(Vector3 a, Vector3 b) {
        return Vector3.Distance(a, Camera.main.transform.position).CompareTo(Vector3.Distance(b, Camera.main.transform.position));
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
        }
        _LODArgsBuffer = null;
    }
}
 