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

public class DataPointRenderer : MonoBehaviour {


	public DataObject dataObject;
	static Material glMaterial;



	private int numberOfPoints = 0;
	private Vector3[] points;
	bool is_valid = false;
	// Use this for initialization
	unsafe void Start () {

		VTKData data = (VTKData)dataObject.data;

		//numberOfPoints = (int)VTK.vtkDataSet.GetNumberOfPoints (data.handle);
		//points = new Vector3[numberOfPoints];

		for (int i = 0; i < numberOfPoints; i++) {
			//points[i] = VTK.vtkDataSet.GetPoint(data.handle,(long)i);
		}
		is_valid = true;
			
		//VTK.vtkDataSet.GetCell(



	}
	static void CreateGLMaterial() {
		if (!glMaterial)
		{
			// Unity has a built-in shader that is useful for drawing
			// simple colored things.
			Shader shader = Shader.Find("Hidden/Internal-Colored");
			glMaterial = new Material(shader);
			glMaterial.hideFlags = HideFlags.HideAndDontSave;
			// Turn on alpha blending
			glMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
			glMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
			// Turn backface culling off
			glMaterial.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
			// Turn off depth writes
			glMaterial.SetInt("_ZWrite", 0);
		}
	}

	public void OnRenderObject()
	{
		CreateGLMaterial();
		// Apply the line material
		glMaterial.SetPass(0);

		GL.PushMatrix();
		// Set transformation matrix for drawing to
		// match our transform
		GL.MultMatrix(transform.localToWorldMatrix);

		// Draw lines
		GL.Begin(GL.LINES);
		for (int i = 0; i < numberOfPoints; ++i)
		{
			float a = 0.5f;

			GL.Color(new Color(a, 1 - a, 0, 0.8F));
			// One vertex at transform position
			GL.Vertex3(points[i].x,points[i].y,points[i].z);
			// Another vertex at edge of circle
			GL.Vertex3(points[i].x+0.001f,points[i].y+0.001f,points[i].z+0.001f);
		}
		GL.End();
		GL.PopMatrix();
	}


	public void OnDrawGizmos() {
		return;
		if (!is_valid)
			return;
		Gizmos.matrix = transform.localToWorldMatrix;
		Vector3 size = new Vector3 (0.001f, 0.001f, 0.001f);
		for (int i = 0; i < numberOfPoints; i++) {
			Gizmos.DrawWireCube (points [i], size);
		}
	}
	public void UpdateBuffers()
	{ 
		
	}


	// Update is called once per frame
	void Update () {
		

	}
}
