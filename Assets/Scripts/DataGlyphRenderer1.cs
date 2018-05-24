using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataGlyphRenderer1 : MonoBehaviour {

	[DllImport("vtkplugin")] unsafe private static extern void free_data (IntPtr h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(IntPtr h, string array_name, IntPtr *values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern  void get_array_range(IntPtr h, string array_name, int component, float * min, float * max);
	[DllImport("vtkplugin")] private static extern IntPtr get_dimensions (IntPtr h);
	[DllImport("vtkplugin")] private static extern int   ComputePointId (IntPtr h, int i, int j, int k);

	public DataObject1 dataObject;
	public float glyphScale = 0.01f;
	public int glyphCount = 500;

	private Texture3D _volumeBuffer;
	private Texture3D _volumeBuffer2;

	public Mesh _glyph;
	public Mesh _glyph2;

	public Material _glyphMaterial;
	public Material _glyphMaterial2;

	private int[] dim;
	// Use this for initialization
	unsafe void Start () {
		IntPtr dim_buff;
		dim = new int[3];
		VTKData data = (VTKData)dataObject.data;

		dim_buff = get_dimensions ( data.handle);
		Marshal.Copy (dim_buff, dim, 0, 3);

		print (dim [0] + "x" + dim [1] + "x" + dim [2]);
		IntPtr dataValues = IntPtr.Zero;;
		int num_elements_data = 0;
		int num_components_data = 0;
		get_array (data.handle, "n1", &dataValues, &num_elements_data, &num_components_data);

		float[] data_array = new float[num_elements_data * num_components_data];
		Marshal.Copy (dataValues, data_array, 0, data_array.Length);

		IntPtr dataValues2 = IntPtr.Zero;;
		int num_elements_data2 = 0;
		int num_components_data2 = 0;
		get_array (data.handle, "n2", &dataValues2, &num_elements_data2, &num_components_data2);

		float[] data_array2 = new float[num_elements_data2 * num_components_data2];
		Marshal.Copy (dataValues2, data_array2, 0, data_array2.Length);


		_volumeBuffer = new Texture3D (dim [0], dim [1], dim [2], TextureFormat.ARGB32, false);
		_volumeBuffer2 = new Texture3D (dim [0], dim [1], dim [2], TextureFormat.ARGB32, false);


		var w = _volumeBuffer.width;
		var h = _volumeBuffer.height;
		var d = _volumeBuffer.depth;
		var volumeColors = new Color[w * h * d];
		var volumeColors2 = new Color[w * h * d];

		for (int k = 0; k < d; k++) {
			for (int j = 0; j < h; j++) {
				for (int i = 0; i < w; i++) {
					int index = k * dim [0] * dim [1] * num_components_data + j * dim [0] * num_components_data + i * num_components_data;

					volumeColors [k * w * h + j * w + i] = new Color (data_array[index+0],data_array[index+1],data_array[index+2],0);
					volumeColors2 [k * w * h + j * w + i] = new Color (data_array2[index+0],data_array2[index+1],data_array2[index+2],0);

				}
			}
		}
		_volumeBuffer.SetPixels (volumeColors);
		_volumeBuffer.Apply();

		_glyphMaterial.SetTexture("_dataVolume", _volumeBuffer);
		_glyphMaterial2.SetTexture("_dataVolume", _volumeBuffer);

		_volumeBuffer2.SetPixels (volumeColors2);
		_volumeBuffer2.Apply();

		_glyphMaterial.SetTexture("_dataVolume2", _volumeBuffer2);
		_glyphMaterial2.SetTexture("_dataVolume2", _volumeBuffer2);


		is_valid = false;
		meshArgsBuffer = new ComputeBuffer(1, meshArgs.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
		meshArgsBuffer2 = new ComputeBuffer(1, meshArgs2.Length * sizeof(uint), ComputeBufferType.IndirectArguments);

		SampleCount = 5000;
		if(SampleCount > 0)
			UpdateBuffers();

	}

	private bool is_valid = false;
	private int SampleCount = 10;
	public int instanceCount = 3;
	private uint[] meshArgs = new uint[5] { 0, 0, 0, 0, 0 };
	private uint[] meshArgs2 = new uint[5] { 0, 0, 0, 0, 0 };

	private ComputeBuffer meshArgsBuffer;
	private ComputeBuffer meshArgsBuffer2;

	private ComputeBuffer positionBuffer;
	private int cachedInstanceCount = -1;
	public bool renderMeshes = true;

	public void UpdateBuffers()
	{ 
		is_valid = false;

		if (SampleCount < 1)
			return;
		instanceCount = glyphCount;
		uint numIndices_mesh = (_glyph != null) ? (uint)_glyph.GetIndexCount(0) : 0;


		meshArgs[0] = numIndices_mesh;
		meshArgs[1] = (uint)instanceCount;

		meshArgsBuffer.SetData(meshArgs);


		uint numIndices_mesh2 = (_glyph != null) ? (uint)_glyph.GetIndexCount(0) : 0;


		meshArgs2[0] = numIndices_mesh;
		meshArgs2[1] = (uint)instanceCount;

		meshArgsBuffer2.SetData(meshArgs2);

		// Positions & Colors
		if (positionBuffer != null) positionBuffer.Release();
		//		if (colorBuffer != null) colorBuffer.Release();

		positionBuffer	= new ComputeBuffer(instanceCount, 16);


		Vector4[] positions = new Vector4[instanceCount];
		UnityEngine.Random.InitState (0);
		for (int i=0; i < instanceCount; i++)
		{
			//		            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
			//		            float distance = Random.Range(0.0f, 100.0f);
			//		            float height = Random.Range(-2.0f, 2.0f);
			//		            float size = Random.Range(0.5f, 1f);
			Vector3 v = new Vector3(UnityEngine.Random.Range(0f,1f)*dim[0],UnityEngine.Random.Range(0f,1f)*dim[1],UnityEngine.Random.Range(-0f,1f)*dim[2]);
			positions[i]	= new Vector4(v.x,v.y,v.z,1);
		}

		positionBuffer.SetData(positions);

		_glyphMaterial.SetBuffer("positionBuffer", positionBuffer);

		_glyphMaterial2.SetBuffer("positionBuffer", positionBuffer);


		cachedInstanceCount = instanceCount;
		is_valid = true;
	}


	// Update is called once per frame
	void Update () {
		instanceCount = glyphCount;
		// Update starting position buffer
		if (cachedInstanceCount != instanceCount) UpdateBuffers();

		_glyphMaterial.SetBuffer("positionBuffer", positionBuffer);
		_glyphMaterial.SetVector("volumeDimensions", new Vector3(dim[0],dim[1],dim[2]));
		_glyphMaterial2.SetBuffer("positionBuffer", positionBuffer);
		_glyphMaterial2.SetVector("volumeDimensions", new Vector3(dim[0],dim[1],dim[2]));
		// Pad input
		//if (Input.GetAxisRaw("Horizontal") != 0.0f) instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

		// Render
		//  instanceMaterial.SetBuffer("positionBuffer", positionBuffer);
		_glyphMaterial.SetMatrix("_DataTransform", dataObject.transform.localToWorldMatrix);
		_glyphMaterial2.SetMatrix("_DataTransform", dataObject.transform.localToWorldMatrix);

		if (is_valid) {
			if (renderMeshes) {
				_glyphMaterial.SetFloat ("_glyphScale", glyphScale);
				_glyphMaterial2.SetFloat ("_glyphScale", glyphScale);
				_glyphMaterial.SetFloat ("_glyphScale", glyphScale);
				_glyphMaterial2.SetFloat ("_glyphScale", glyphScale);

				_glyphMaterial.SetInt ("_glyphType", 0);
				Graphics.DrawMeshInstancedIndirect (_glyph, 0, _glyphMaterial, new Bounds (Vector3.zero, new Vector3 (100.0f, 100.0f, 100.0f)), meshArgsBuffer, 0, null, UnityEngine.Rendering.ShadowCastingMode.Off);

				_glyphMaterial2.SetInt ("_glyphType", 1);
				Graphics.DrawMeshInstancedIndirect (_glyph2, 0, _glyphMaterial2, new Bounds (Vector3.zero, new Vector3 (100.0f, 100.0f, 100.0f)), meshArgsBuffer2, 0, null, UnityEngine.Rendering.ShadowCastingMode.Off);

			}
		}

	}
}
