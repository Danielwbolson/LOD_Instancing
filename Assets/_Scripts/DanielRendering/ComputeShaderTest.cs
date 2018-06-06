using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputeShaderTest : MonoBehaviour {

    public Mesh mesh;
    public Material mat;

    private int kernel;

    public ComputeShader computeShader;

    private const int MAXOBJECTS = 100;
    private ObjInfo[] data;
    private Matrix4x4[] matrixData;
    private Matrix4x4[] inverseMatrixData;

    private ComputeBuffer dataBuffer;
    private ComputeBuffer matrixBuffer;
    private ComputeBuffer inverseMatrixBuffer;

    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };
    private ComputeBuffer argsBuffer;

    // Use this for initialization
    void Start () {
        dataBuffer = new ComputeBuffer(MAXOBJECTS, 12 * sizeof(float));
        argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
        matrixBuffer = new ComputeBuffer(MAXOBJECTS, 16 * sizeof(float));
        inverseMatrixBuffer = new ComputeBuffer(MAXOBJECTS, 16 * sizeof(float));

        matrixData = new Matrix4x4[MAXOBJECTS];
        inverseMatrixData = new Matrix4x4[MAXOBJECTS];

        matrixBuffer.SetData(matrixData);
        inverseMatrixBuffer.SetData(inverseMatrixData);

        mat.enableInstancing = true;

        kernel = computeShader.FindKernel("InstanceMatrix");
        computeShader.SetBuffer(kernel, "dataBuffer", dataBuffer);
        computeShader.SetBuffer(kernel, "matrixBuffer", matrixBuffer);
        computeShader.SetBuffer(kernel, "inverseMatrixBuffer", inverseMatrixBuffer);

        mat.SetBuffer("dataBuffer", dataBuffer);
        mat.SetBuffer("matrixBuffer", matrixBuffer);
        mat.SetBuffer("inverseMatrixBuffer", inverseMatrixBuffer);

        UpdateBuffers();
    }

    // Update is called once per frame
    void Update() {
        //UpdateBuffers();

        computeShader.Dispatch(kernel, MAXOBJECTS, 1, 1);
        Graphics.DrawMeshInstancedIndirect(mesh, 0, mat, mesh.bounds, argsBuffer);
    }

    void UpdateBuffers() {
        //if (dataBuffer != null)
        //    dataBuffer.Release();

        data = new ObjInfo[MAXOBJECTS];

        for (int i = 0; i < MAXOBJECTS; i++) {
            data[i].color = Color.white;
            data[i].position = new Vector4(
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f),
                1);
            data[i].scale = 0.1f;
        }
        //dataBuffer = new ComputeBuffer(data.Length, 12 * sizeof(float));
        dataBuffer.SetData(data);
        
        if (argsBuffer != null) {
            argsBuffer.Release();
            argsBuffer = null;
        }

        if (mesh != null) {
            args[0] = (uint)mesh.GetIndexCount(0);
            args[1] = (uint)data.Length;
            args[2] = (uint)mesh.GetIndexStart(0);
            args[3] = (uint)mesh.GetBaseVertex(0);
        } else {
            args[0] = args[1] = args[2] = args[3] = 0;
        }

        argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
        argsBuffer.SetData(args);
    }
}
