using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTKGlyphField : MonoBehaviour {
	public int instanceCount = 3;
	public Mesh instanceMesh;
	public Material instanceMaterial;

	private int cachedInstanceCount = -1;
	private ComputeBuffer positionBuffer;
	private ComputeBuffer argsBuffer;
	private ComputeBuffer colorBuffer;

	private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

	// Use this for initialization
	void Start () {
		argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
		UpdateBuffers();
	}
	public void UpdateBuffers()
	{ 
		instanceCount = transform.parent.transform.gameObject.GetComponent<VTKSampleSet> ().positions.Length;
		if ( instanceCount < 1 ) instanceCount = 1;

		uint numIndices = (instanceMesh != null) ? (uint)instanceMesh.GetIndexCount(0) : 0;
		args[0] = numIndices;
		args[1] = (uint)instanceCount;
		argsBuffer.SetData(args);

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

		instanceMaterial.SetBuffer("positionBuffer", positionBuffer);



		cachedInstanceCount = instanceCount;
	}

	// Update is called once per frame
	void Update () {
		// Update starting position buffer
		if (cachedInstanceCount != instanceCount) UpdateBuffers();


		instanceMaterial.SetBuffer("positionBuffer", positionBuffer);

		// Pad input
		//if (Input.GetAxisRaw("Horizontal") != 0.0f) instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

		// Render
		//  instanceMaterial.SetBuffer("positionBuffer", positionBuffer);
		instanceMaterial.SetMatrix("_DataTransform", transform.parent.parent.localToWorldMatrix);

		Graphics.DrawMeshInstancedIndirect(instanceMesh, 0, instanceMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), argsBuffer);

	}
}
