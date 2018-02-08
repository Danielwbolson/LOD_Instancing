using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VTKGlyphField : MonoBehaviour {
	public int instanceCount = 3;
	public Mesh billboardMesh;
	public Mesh glyphMesh;

	public Material billboardMaterial;
	public Material meshMaterial;

	private int cachedInstanceCount = -1;
	private ComputeBuffer positionBuffer;
	private ComputeBuffer billboardArgsBuffer;
	private ComputeBuffer meshArgsBuffer;

	private ComputeBuffer colorBuffer;
	private bool is_valid = false;
	private uint[] billboardArgs = new uint[5] { 0, 0, 0, 0, 0 };
	private uint[] meshArgs = new uint[5] { 0, 0, 0, 0, 0 };

	public bool renderBillboards = false;
	public bool renderMeshes = false;

	public void shouldRenderBillboards(bool b){
		renderBillboards = b;
	}

	public void shouldRenderMeshes(bool b){
		renderMeshes = b;
	}

	private int SampleCount;

	public void setSampleCount(int n){
		SampleCount = n;
		UpdateBuffers ();
	}
	// Use this for initialization
	void Start () {
		is_valid = false;
		meshArgsBuffer = new ComputeBuffer(1, meshArgs.Length * sizeof(uint), ComputeBufferType.IndirectArguments);

		billboardArgsBuffer = new ComputeBuffer(1, billboardArgs.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
		SampleCount = transform.parent.transform.gameObject.GetComponent<VTKSampleSet> ().positions.Length;
		if(SampleCount > 0)
			UpdateBuffers();
	}
	public void UpdateBuffers()
	{ 
		is_valid = false;

		if (SampleCount < 1)
			return;
		instanceCount = SampleCount;
		uint numIndices_billboard = (billboardMesh != null) ? (uint)billboardMesh.GetIndexCount(0) : 0;
		uint numIndices_mesh = (glyphMesh != null) ? (uint)glyphMesh.GetIndexCount(0) : 0;


		meshArgs[0] = numIndices_mesh;
		meshArgs[1] = (uint)instanceCount;

		meshArgsBuffer.SetData(meshArgs);


		billboardArgs[0] = numIndices_billboard;
		billboardArgs[1] = (uint)instanceCount;

		billboardArgsBuffer.SetData(billboardArgs);

		// Positions & Colors
		        if (positionBuffer != null) positionBuffer.Release();
		//		if (colorBuffer != null) colorBuffer.Release();

		        positionBuffer	= new ComputeBuffer(instanceCount, 16);


		 	Vector4[] positions = new Vector4[instanceCount];

		        for (int i=0; i < instanceCount; i++)
				{
//		            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
//		            float distance = Random.Range(0.0f, 100.0f);
//		            float height = Random.Range(-2.0f, 2.0f);
//		            float size = Random.Range(0.5f, 1f);
				Vector3 v = transform.parent.transform.gameObject.GetComponent<VTKSampleSet> ().positions [i];
				positions[i]	= new Vector4(v.x,v.y,v.z,1);
		        }
		
		 positionBuffer.SetData(positions);

		billboardMaterial.SetBuffer("positionBuffer", positionBuffer);
		meshMaterial.SetBuffer("positionBuffer", positionBuffer);



		cachedInstanceCount = instanceCount;
		is_valid = true;
	}

	// Update is called once per frame
	void Update () {
		// Update starting position buffer
		if (cachedInstanceCount != instanceCount) UpdateBuffers();


		billboardMaterial.SetBuffer("positionBuffer", positionBuffer);
		meshMaterial.SetBuffer("positionBuffer", positionBuffer);

		// Pad input
		//if (Input.GetAxisRaw("Horizontal") != 0.0f) instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

		// Render
		//  instanceMaterial.SetBuffer("positionBuffer", positionBuffer);
		billboardMaterial.SetMatrix("_DataTransform", transform.parent.parent.localToWorldMatrix);
		meshMaterial.SetMatrix("_DataTransform", transform.parent.parent.localToWorldMatrix);

		if (is_valid) {
			if(renderBillboards)
				Graphics.DrawMeshInstancedIndirect(billboardMesh, 0, billboardMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), billboardArgsBuffer,0,null, UnityEngine.Rendering.ShadowCastingMode.Off);

			if(renderMeshes)
				Graphics.DrawMeshInstancedIndirect(glyphMesh, 0, meshMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), meshArgsBuffer,0,null, UnityEngine.Rendering.ShadowCastingMode.Off);

        }

	}
}
