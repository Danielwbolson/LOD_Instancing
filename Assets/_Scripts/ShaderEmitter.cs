//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ShaderEmitter : MonoBehaviour {

//    struct ObjInfo {
//        public Vector3 position;
//        public Vector3 direction;
//        public Vector3 color;
//        public Vector3 scale;

//        Constructor: If we add elements, must change size of buffer
//        public ObjInfo(Vector3 pos, Vector3 dir, Vector3 col, Vector3 scal) {
//            this.position = pos;
//            this.direction = dir;
//            this.color = col;
//            this.scale = scal;
//        }
//    }

//    public Mesh _mesh;
//    public Material _mat;

//    public bool _refresh;
//    public int MAXSIZE;
//    public float _width, _height;

//    public ComputeShader _shader;

//    private ComputeBuffer dataBuffer;
//    private ComputeBuffer argsBuffer;
//    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

//    private Matrix4x4 _modelMatrix;
//    private Matrix4x4 _modelMatrixInverse;
//    private List<ObjInfo> data;
//    private ObjInfo[] output;

//    void Start() {
//        _refresh = false;
//        dataBuffer = new ComputeBuffer(MAXSIZE, 12 * sizeof(float));
//        data = new List<ObjInfo>(MAXSIZE);

//        argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
//        UpdateBuffers();
//    }

//    void Update() {
//        if (_refresh) {
//            UpdateBuffers();
//            _refresh = !_refresh;
//        }

//        if (_modelMatrix != transform.localToWorldMatrix) {
//            MultByModelMatrix();
//            _modelMatrix = transform.localToWorldMatrix;
//            _modelMatrixInverse = _modelMatrix.inverse;
//        }

//        Bounds b = new Bounds(Vector3.zero, new Vector3(50, 50, 50));

//        Graphics.DrawMeshInstancedIndirect(_mesh, 0, _mat, b, argsBuffer);
//        _mat.SetMatrix("_ModelMatrix", transform.localToWorldMatrix);
//        _mat.SetMatrix("_ModelMatrixInverse", transform.localToWorldMatrix.inverse);
//    }

//    void UpdateBuffers() {

//        if (dataBuffer != null) {
//            dataBuffer.Release();
//        }

//        Data buffer
//        data = new List<ObjInfo>(MAXSIZE);
//        output = new ObjInfo[MAXSIZE];
//        dataBuffer = new ComputeBuffer(MAXSIZE, 9 * sizeof(float));

//        for (int i = 0; i < data.Count; i++) {
//            Vector3 rand_pos = new Vector3(
//                Random.Range(-_width, _width),
//                Random.Range(-_height, _height),
//                0);

//            Vector3 dir = new Vector3(1, 0, 0);

//            Vector3 col = new Vector3(1, 0, 0);

//            Vector3 scal = new Vector3(0.1f, 0.1f, 0.1f);

//            data[i] = new ObjInfo(rand_pos, dir, col, scal);
//        }

//        dataBuffer.SetData(data);
//        _mat.SetBuffer("dataBuffer", dataBuffer);

//        Indirect args
//        if (_mesh != null) {
//            args[0] = (uint)_mesh.GetIndexCount(0);
//            args[1] = (uint)MAXSIZE;
//            args[2] = (uint)_mesh.GetIndexStart(0);
//            args[3] = (uint)_mesh.GetBaseVertex(0);
//        } else {
//            args[0] = args[1] = args[2] = args[3] = 0;
//        }
//        argsBuffer.SetData(args);

//        int kernel = _shader.FindKernel("MyFunc");
//        _shader.SetBuffer(kernel, "dataBuffer", dataBuffer);
//        _shader.Dispatch(kernel, MAXSIZE, 1, 1);

//        dataBuffer.GetData(output);
//        dataBuffer.Release();
//    }

//    void MultByModelMatrix() {
//        dataBuffer = new ComputeBuffer(MAXSIZE, 9 * sizeof(float));
//        output = new ObjInfo[MAXSIZE];

//        int kernel = _shader.FindKernel("MultByModelMatrix");
//        _shader.SetMatrix("modelMatrix", transform.localToWorldMatrix);
//        _shader.Dispatch(kernel, data.Count, 1, 1);

//        dataBuffer.GetData(output);
//        dataBuffer.Release();
//    }

//    private void OnDisable() {
//        if (dataBuffer != null) {
//            dataBuffer.Release();
//        }
//        dataBuffer = null;

//        if (argsBuffer != null) {
//            argsBuffer.Release();
//        }
//        argsBuffer = null;
//    }
//}
