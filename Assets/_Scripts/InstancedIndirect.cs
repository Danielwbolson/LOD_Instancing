using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancedIndirect : MonoBehaviour {

    struct ObjInfo {
        public Vector4 position;
        public Vector4 color;
        public Vector4 scale;
    };

    public int instanceCount;
    public Mesh instanceMesh;
    public Material instanceMaterial;
    public int subMeshIndex = 0;
    Matrix4x4 _modelMatrix;

    private int cachedInstanceCount = -1;
    private int cachedSubMeshIndex = -1;
    private ComputeBuffer dataBuffer;
    private ComputeBuffer argsBuffer;
    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

    void Start() {
        argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
        UpdateBuffers();
        _modelMatrix = transform.localToWorldMatrix;
        instanceMaterial.SetMatrix("modelMatrix", _modelMatrix);
        instanceMaterial.enableInstancing = true;
    }

    void Update() {
        if (_modelMatrix != transform.localToWorldMatrix) {
            _modelMatrix = transform.localToWorldMatrix;
            instanceMaterial.SetMatrix("modelMatrix", _modelMatrix);
        }

        // Update starting position buffer
        if (cachedInstanceCount != instanceCount || cachedSubMeshIndex != subMeshIndex)
            UpdateBuffers();

        // Pad input
        if (Input.GetAxisRaw("Horizontal") != 0.0f)
            instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

        // Render
        Graphics.DrawMeshInstancedIndirect(instanceMesh, subMeshIndex, instanceMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), argsBuffer);
    }

    void OnGUI() {
        GUI.Label(new Rect(265, 25, 200, 30), "Instance Count: " + instanceCount.ToString());
        instanceCount = (int)GUI.HorizontalSlider(new Rect(25, 20, 200, 30), (float)instanceCount, 1.0f, 5000000.0f);
    }

    void UpdateBuffers() {
        // Ensure submesh index is in range
        if (instanceMesh != null)
            subMeshIndex = Mathf.Clamp(subMeshIndex, 0, instanceMesh.subMeshCount - 1);

        // Data struct
        if (dataBuffer != null)
            dataBuffer.Release();
        dataBuffer = new ComputeBuffer(instanceCount, 8 * sizeof(float));
        ObjInfo[] data = new ObjInfo[instanceCount];
        for (int i = 0; i < instanceCount; i++) {
            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);
            float size = Random.Range(0.05f, 0.25f);
            data[i].position = new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, size);

            float red = Random.Range(0f, 1f);
            float green = Random.Range(0f, 1f);
            float blue = Random.Range(0f, 1f);
            float alpha = 1;
            data[i].color = new Vector4(red, green, blue, alpha);

            float xScale = Random.Range(0.05f, 1.0f);
            float yScale = Random.Range(0.05f, 1.0f);
            float zScale = Random.Range(0.05f, 1.0f);
            float w = 1;
            data[i].scale = new Vector4(xScale, yScale, zScale, w);
        }
        dataBuffer.SetData(data);
        instanceMaterial.SetBuffer("dataBuffer", dataBuffer);

        // Indirect args
        if (instanceMesh != null) {
            args[0] = (uint)instanceMesh.GetIndexCount(subMeshIndex);
            args[1] = (uint)instanceCount;
            args[2] = (uint)instanceMesh.GetIndexStart(subMeshIndex);
            args[3] = (uint)instanceMesh.GetBaseVertex(subMeshIndex);
        } else {
            args[0] = args[1] = args[2] = args[3] = 0;
        }
        argsBuffer.SetData(args);

        cachedInstanceCount = instanceCount;
        cachedSubMeshIndex = subMeshIndex;
    }

    void OnDisable() {
        if (dataBuffer != null)
            dataBuffer.Release();
        dataBuffer = null;

        if (argsBuffer != null)
            argsBuffer.Release();
        argsBuffer = null;
    }
}
