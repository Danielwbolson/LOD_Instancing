using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

public static class ExtensionMethods
{
	public static float Map (this float value, float fromSource, float toSource, float fromTarget, float toTarget)
	{
		return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
	}
}

public class StreamlineRenderer : Filter {
	public bool uniformGizmo = false;
	public int numGizmo = 1;
	public VTKData vtkData;
	public float isovalue = 0.001f;
	bool is_valid = false;
	private IntPtr NULL = IntPtr.Zero;
	private Paths paths;

	//protected List<Spline> splines;

	[DllImport("vtkplugin")] unsafe private static extern void free_data (IntPtr h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(IntPtr h, string array_name, IntPtr *values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern  void get_array_range(IntPtr h, string array_name, int component, float * min, float * max);
	[DllImport("vtkplugin")] unsafe private static extern void get_points(IntPtr h, IntPtr* values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern int get_number_of_lines (IntPtr h);
	[DllImport("vtkplugin")] unsafe private static extern void get_line_ids (IntPtr h, int line, IntPtr* ids_list, int*number_of_ids, int*reasonForTermination, int*seedId);
		
	public override void RefreshFilter() {
		getLines ();


	}
		
	unsafe void OnDrawGizmos() {
		return;
		if (!is_valid)
			return;
		Gizmos.matrix = transform.localToWorldMatrix;

//		for (int l = 0; l < uniformSplines.Count; l++) {
//			for (int i = 1; i < uniformSplines [l].Count; i++) {
//				Vector3 A = uniformSplines [l] [(i - 1)];
//				Vector3 B = uniformSplines [l] [(i)];
//
//				if (i == 1)
//					Gizmos.color = Color.green;
//				else if (i == uniformSplines [l].Count - 1)
//					Gizmos.color = Color.red;
//				else if (i % 2 == 0)
//					Gizmos.color = Color.white;
//				else
//					Gizmos.color = Color.black;
//				Gizmos.DrawLine(A,B)  ;
//			}
//		}

//		for (int l = 0; l < ids.Count; l++) {
//			for (int i = 1; i < ids [l].Count; i++) {
//				Vector3 A = line_positions[ids [l] [(i - 1)]];
//				Vector3 B = line_positions[ids [l] [i]];
//
//				if (i == 1)
//					Gizmos.color = Color.green;
//				else if (i == uniformSplines [l].Count - 1)
//					Gizmos.color = Color.red;
//				else if (i % 2 == 0)
//					Gizmos.color = Color.white;
//				else
//					Gizmos.color = Color.black;
//				Gizmos.DrawLine(A,B)  ;
//			}
//		}

		float min = paths.getVariable ("data").getMinValue();
		float max = paths.getVariable ("data").getMaxValue();

		if (!uniformGizmo) {

			for (int l = 0; l < Mathf.Min( paths.getNumberOfLines(), numGizmo); l++) {
				int[] indices = paths.getLineIndices (l);

				for (int i = 1; i < indices.Count(); i++) {
					Vector3 A = paths.getLineVertex( indices [i-1]);
					Vector3 B = paths.getLineVertex( indices [i]);
					if (false) {
						float v = paths.getLineVariableValue1 ("data", indices [i - 1]);
						float v_norm = v.Map (min, max, 0, 1);
						Gizmos.color = Color.HSVToRGB(0,0,v_norm);
					} else {
						if (i == 1)
							Gizmos.color = Color.green;
						else if (i == indices.Count () - 1)
							Gizmos.color = Color.red;
						else if (i % 2 == 0)
							Gizmos.color = Color.white;
						else
							Gizmos.color = Color.black;
					}
					Gizmos.DrawLine(A,B)  ;

					Gizmos.color = Color.blue;
					//print(Vector3.Angle (B - A, paths.getLineNormal (indices [i - 1])));
					Gizmos.DrawLine (A, A + paths.getLineNormal(indices[i-1]).normalized * 0.1f);
				}
			}
		} else {
			if (uniformPaths == null)
				return;

			for (int l = 0; l < Mathf.Min( uniformPaths.getNumberOfLines(), numGizmo); l++) {
				int[] indices = uniformPaths.getLineIndices (l);

				for (int i = 1; i < indices.Count(); i++) {
					Vector3 A = uniformPaths.getLineVertex( indices [i-1]);
					Vector3 B = uniformPaths.getLineVertex( indices [i]);
					if (false) {
						float v = uniformPaths.getLineVariableValue1 ("data", indices [i - 1]);
						float v_norm = v.Map (min, max, 0, 1);
						Gizmos.color = Color.HSVToRGB(0,0,v_norm);
					} else {
						if (i == 1)
							Gizmos.color = Color.green;
						else if (i == indices.Count () - 1)
							Gizmos.color = Color.red;
						else if (i % 2 == 0)
							Gizmos.color = Color.white;
						else
							Gizmos.color = Color.black;
					}
					Gizmos.DrawLine(A,B)  ;

					Gizmos.color = Color.blue;
					//print(Vector3.Angle (B - A, paths.getLineNormal (indices [i - 1])));
					Gizmos.DrawLine (A, A + uniformPaths.getLineNormal(indices[i-1]).normalized * 0.1f);
				}
			}

		}

//

	
		Gizmos.color = Color.green;
	}

	
	unsafe public void getLines()
	{
		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();
		if (vtkData.handle != NULL) 
		{
			paths = new Paths ();

			//splines = new List<Spline> ();

			IntPtr normals = IntPtr.Zero;;
			IntPtr dataValues = IntPtr.Zero;;

			IntPtr points = IntPtr.Zero;;
			int num_elements_normals = 0;
			int num_components_normals = 0;

			int num_elements_data = 0;
			int num_components_data = 0;

			int num_points = 0;
			int point_components = 0;


			get_array (vtkData.handle, "Normals", &normals, &num_elements_normals, &num_components_normals);
			float[] normal_array = new float[num_elements_normals * num_components_normals];
			Marshal.Copy (normals, normal_array, 0, normal_array.Length);
			//free_data (normals);


			get_points (vtkData.handle, &points, &num_points, &point_components);
			float [] point_array = new float[num_points * point_components];
			Marshal.Copy ( points, point_array, 0, point_array.Length);

			//free_data (dataValues);


			get_array (vtkData.handle, "RTData", &dataValues, &num_elements_data, &num_components_data);
			float [] min = new float[num_components_data];
			float [] max = new float[num_components_data];
			for (int c = 0; c < num_components_data; c++) {
				float mn;
				float mx;

				get_array_range (vtkData.handle, "RTData", c, &mn, &mx);
				min [c] = mn;
				min [c] = mx;

			}
			print ("MINMAX: " + min + ", " + max);

			float[] data_array = new float[num_elements_data * num_components_data];
			Marshal.Copy (dataValues, data_array, 0, data_array.Length);


			//free_data (points);





			int number_of_lines = get_number_of_lines (vtkData.handle);
		
			print ("COMP: " + point_components);
			paths.setPointData (point_array, 3);
			paths.setNormalData (normal_array, num_components_normals);
			paths.addVariable ("data", data_array, num_components_data, min, max);
			for (int i = 0; i < num_points; i++) {

				//print (line_positions[i]);
			}
			for (int i = 0; i < number_of_lines; i++) {
				IntPtr id_list = IntPtr.Zero;;
				int num_ids = 0;
				int reason_for_termination = -1;
				int seedId = -1;
				get_line_ids (vtkData.handle, i, &id_list, &num_ids, &reason_for_termination, &seedId);
				print (reason_for_termination + ", " + seedId);
					
				int[] id_array = new int[num_ids];
				Marshal.Copy (id_list, id_array, 0, id_array.Length);
//				print ("Line " + i + " has " + num_ids + " points");
				paths.addLine (id_array, seedId, true);

			
				free_data(id_list);
			}


			is_valid = true;
			uniformPaths = paths.generateUniformPaths (0.1f);

			UpdateBuffer ();


		} //else
		//print ("not!");
	}
	private Paths uniformPaths = null;

	private ComputeBuffer positionBuffer;
	private ComputeBuffer normalBuffer;
	private ComputeBuffer indexBuffer;
	private ComputeBuffer offsetBuffer;
	public Material _material;
	public Mesh _mesh;


	void UpdateBuffer ()
	{
		if (uniformPaths == null)
			return;

	DataVariable posVar = uniformPaths.getVariable ("positions");
	float[] posArray = posVar.getData ();



		positionBuffer = new ComputeBuffer (posArray.Count() ,sizeof(float)*3);
		positionBuffer.SetData (posArray);

		normalBuffer = new ComputeBuffer (uniformPaths.getVariable ("normals").getData ().Count (), sizeof(float) * 4);
		normalBuffer.SetData (uniformPaths.getVariable ("normals").getData ());

		List<int> offsets = new List<int> ();

		int indexCount = 0;
		for (int l = 0; l < uniformPaths.getNumberOfLines (); l++) {
			int[] ind = uniformPaths.getLineIndices (l);
			offsets.Add (indexCount);
			print (indexCount);
			indexCount+= ind.Count();
		}
		offsets.Add (indexCount);

		indexBuffer = new ComputeBuffer (indexCount, sizeof(int));
		offsetBuffer = new ComputeBuffer (offsets.Count (), sizeof(int));
		offsetBuffer.SetData (offsets.ToArray ());

		for (int l = 0; l < uniformPaths.getNumberOfLines (); l++) {
			int[] ind = uniformPaths.getLineIndices (l);
			indexBuffer.SetData (ind, 0, offsets [l], ind.Count ());
		}

		

		//offsetBuffer = new ComputeBuffer (offsets.Count, sizeof(int));
		//offsetBuffer.SetData (offsets.ToArray ());


		if (_material != null) {
			_material.SetBuffer ("_positions", positionBuffer);
			Debug.Log ("SET BUFFER: " + posArray.Count());
			_material.SetInt ("_numPositions", posArray.Count());

			_material.SetBuffer ("_normals", normalBuffer);


			_material.SetBuffer ("_offsets", offsetBuffer);
			_material.SetBuffer ("_indices", indexBuffer);


//			_material.SetBuffer ("_offsets", offsetBuffer);
//			Debug.Log ("SET BUFFER");
//			_material.SetInt ("_numLines", offsets.Count);

		}
	}

	private int cachedInstanceCount = -1;
	private ComputeBuffer argsBuffer;

	public float _offset;
	public float _glyphScale = 1;
	public float _glyphRadius = 1;
	public float _glyphInflate = 0;
	public float _glyphTwist = 0;
	public float _glyphSpacing = 0;
	public float _glyphTextureScale = 0;
	private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };
	public int instanceCount = 3;


	void UpdateBuffers()
	{ 
		
		if ( instanceCount < 1 ) instanceCount = 1;

		uint numIndices = (_mesh != null) ? (uint)_mesh.GetIndexCount(0) : 0;
		args[0] = numIndices;
		args[1] = (uint)instanceCount;
		argsBuffer.SetData(args);

		cachedInstanceCount = instanceCount;
	}


	void Start() {


		argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
		UpdateBuffers();

	}


	ComputeBuffer glyphIDBuffer = null;
	ComputeBuffer lineIDsBuffer = null;
	ComputeBuffer lineLengthsBuffer = null;


	void UpdateMesh () {
		float meshHeight = _mesh.bounds.extents.y*_glyphScale;
		//print ("Mesh Height: " + meshHeight);
		_material.SetFloat ("_meshHeight", meshHeight);
		List<int> indices = new List<int> ();
		List<int> lineID = new List<int> ();
		List<float> lineLengths = new List<float> ();

		for (int l = 0; l < uniformPaths.getNumberOfLines (); l++) {
			float length = uniformPaths.getLineLength (l);
			lineLengths.Add (length);
			float numGlyphs = length / meshHeight;
			numGlyphs = Mathf.Ceil (numGlyphs);
			for (int g = 0; g < numGlyphs; g++) {
				lineID.Add (l);
				indices.Add (g);
			}

		}


//		positionBuffer = new ComputeBuffer (posArray.Count() ,sizeof(float)*3);
//		positionBuffer.SetData (posArray);
//
//		normalBuffer = new ComputeBuffer (uniformPaths.getVariable ("normals").getData ().Count (), sizeof(float) * 4);
//		normalBuffer.SetData (uniformPaths.getVariable ("normals").getData ());
//

		//offsetBuffer = new ComputeBuffer (offsets.Count, sizeof(int));
		//offsetBuffer.SetData (offsets.ToArray ());
//
//
//		if (_material != null) {
//			_material.SetBuffer ("_positions", positionBuffer);
//			Debug.Log ("SET BUFFER: " + posArray.Count());
//			_material.SetInt ("_numPositions", posArray.Count());
//
//			_material.SetBuffer ("_normals", normalBuffer);
//
//
//

//		if(glyphIDBuffer != null) glyphIDBuffer.Release ();
//		if(lineIDsBuffer != null) lineIDsBuffer.Release ();
//		if(lineLengthsBuffer != null) lineLengthsBuffer.Release ();


		if(glyphIDBuffer == null) glyphIDBuffer = new ComputeBuffer(indices.Count(),sizeof(int));
		if(lineIDsBuffer == null) lineIDsBuffer = new ComputeBuffer(lineID.Count(), sizeof(int));
		if(lineLengthsBuffer == null) lineLengthsBuffer = new ComputeBuffer(lineLengths.Count(), sizeof(float));
//
		glyphIDBuffer.SetData (indices.ToArray ());
		lineIDsBuffer.SetData (lineID.ToArray ());
		lineLengthsBuffer.SetData (lineLengths.ToArray ());
//
//
		_material.SetBuffer ("_glyphID", glyphIDBuffer);
		_material.SetBuffer ("_lineID", lineIDsBuffer);
		_material.SetBuffer ("_lineLength", lineLengthsBuffer);

		instanceCount = indices.Count ();
		UpdateBuffers ();

	}

	void Update()
	{ 
		if (!is_valid)
			return;

		UpdateMesh ();

		_material.SetMatrix ("_DataTransform", transform.localToWorldMatrix);
		_material.SetFloat("_offset", _offset);
		_material.SetFloat ("_glyphScale", _glyphScale);
		_material.SetFloat ("_glyphRadius", _glyphRadius);
		_material.SetFloat ("_glyphInflate", _glyphInflate);
		_material.SetFloat ("_glyphTwist", _glyphTwist);
		_material.SetFloat ("_glyphSpacing", _glyphSpacing);
		_material.SetFloat ("_glyphTextureScale", _glyphTextureScale);
		_material.SetFloat ("_stepSize", 0.1f);

		// Update starting position buffer
		if (cachedInstanceCount != instanceCount) UpdateBuffers();

		// Pad input
		//if (Input.GetAxisRaw("Horizontal") != 0.0f) instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

		// Render
		Graphics.DrawMeshInstancedIndirect(_mesh, 0, _material, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), argsBuffer,0,null, UnityEngine.Rendering.ShadowCastingMode.Off);
		//instanceMaterial.SetBuffer("positionBuffer", positionBuffer);
	}


}



//
//
//
//public class Spline
//{
//
//	public List<Vector3> controlPointsList;
//
//	public Spline() {
//		controlPointsList = new List<Vector3>();
//	}
//
//	public void addControlPoint(Vector3 t, float e = 0.001f) {
//		//if(controlPointsList.Count != 0)
//			//Debug.Log ((controlPointsList.Last () - t).magnitude + " < " + e);
//		if(controlPointsList.Count == 0 || (controlPointsList.Last() - t).magnitude > e)
//			controlPointsList.Add (t);
//
//	}
//
//	public int controlPointCount() {
//		return controlPointsList.Count;
//	}
//	public int[] getSegmentIndices(int seg) {
//		int[] result = new int[4];
//		int index0 = seg==0? 0 : seg - 1;
//		int index1 = seg;
//		int index2 = seg + 1;
//		int index3 = seg + 2 <= controlPointCount() - 1? seg + 2: seg + 1;
//
//		result [0] = index0;
//		result [1] = index1;
//		result [2] = index2;
//		result [3] = index3;
//
//		return result;
//	}
//	public float getSegmentLength(int seg) {
//
//
//		int[] index = getSegmentIndices (seg);
//		Vector3 p0 = controlPointsList[index[0]];
//		Vector3 p1 = controlPointsList[index[1]];
//		Vector3 p2 = controlPointsList[index[2]];
//		Vector3 p3 = controlPointsList[index[3]];
//
//		float len = GetLengthSimpsons (0, 1, p0, p1, p2, p3);
//		return len;
//	}
//
//	public float getLength(float t_start, float t_end) {
//		//			float t_i_a = t_start;
//		//			float t_i_b = Mathf.Floor (t_start) + 1;
//		//Debug.Log(t_start +" -- " + t_end);
//		float t_i = t_start;
//
//		float len = 0;
//
//		while (t_i <= t_end) {
//			int seg = (int)Mathf.Floor (t_i );
//
//			float seg_t = t_i - seg;
//
//			float t_j = Mathf.Min (t_end, seg + 1f)-seg;
//			if (seg < controlPointCount () - 1) {
//				int[] index = getSegmentIndices (seg);
//				Vector3 p0 = controlPointsList [index [0]];
//				Vector3 p1 = controlPointsList [index [1]];
//				Vector3 p2 = controlPointsList [index [2]];
//				Vector3 p3 = controlPointsList [index [3]];
//
//
//
//				len += GetLengthSimpsons (seg_t, t_j, p0, p1, p2, p3);
//			}
//
//			t_i += 1;
//			//Debug.Log (t_i);
//
//		}
//
//
//		return len;
//
//
//
//	}
//
//	public Vector3 getSplinePosition(float t) {
//		int seg = (int)Mathf.Floor (t);
//
//		float seg_t = t - seg;
//		if (seg > controlPointCount () - 2) {
//			seg = controlPointCount () - 2;
//			seg_t = 1;
//		}
//		int[] index = getSegmentIndices (seg);
//		Vector3 p0 = controlPointsList[index[0]];
//		Vector3 p1 = controlPointsList[index[1]];
//		Vector3 p2 = controlPointsList[index[2]];
//		Vector3 p3 = controlPointsList[index[3]];
//		return (GetCatmullRomPosition (seg_t, p0, p1, p2, p3));
//	}
//
//	public Vector3 getSplineDerivative(float t) {
//		int seg = (int)Mathf.Floor (t);
//
//		float seg_t = t - seg;
//		if (seg > controlPointCount () - 2) {
//			seg = controlPointCount () - 2 ;
//			seg_t = 1;
//		}
//		int[] index = getSegmentIndices (seg);
//		Vector3 p0 = controlPointsList[index[0]];
//		Vector3 p1 = controlPointsList[index[1]];
//		Vector3 p2 = controlPointsList[index[2]];
//		Vector3 p3 = controlPointsList[index[3]];
//		return (GetCatmullRomDerivative (seg_t, p0, p1, p2, p3));
//	}
//
//
//	//Use Newton–Raphsons method to find the t value at the end of this distance d
//	public float FindTValue(float d)
//	{
//		d = Mathf.Max (0, d);
//		int segment = 0;
//		float segmentLength = getLength (segment, segment + 1);
//		while (d > segmentLength && segment < controlPointCount()-1) {
//			d -= segmentLength;
//
//			segment++;
//			segmentLength = getLength (segment, segment + 1);
//		}
//		if (segment == controlPointCount()-1)
//			return segment;
//		int[] index = getSegmentIndices (segment);
//		Vector3 p0 = controlPointsList[index[0]];
//		Vector3 p1 = controlPointsList[index[1]];
//		Vector3 p2 = controlPointsList[index[2]];
//		Vector3 p3 = controlPointsList[index[3]];
//
//		//Need a start value to make the method start
//		//Should obviously be between 0 and 1
//		//We can say that a good starting point is the percentage of distance traveled
//		//If this start value is not working you can use the Bisection Method to find a start value
//		//https://en.wikipedia.org/wiki/Bisection_method
//		float t = d / segmentLength;
//
//		//Need an error so we know when to stop the iteration
//		float error = 0.001f;
//
//		//We also need to avoid infinite loops
//		int iterations = 0;
//
//		while (true)
//		{
//			//Newton's method
//			float tNext = t - ((GetLengthSimpsons(0f, t, p0, p1,p2,p3) - d) / GetArcLengthIntegrand(t, p0, p1,p2,p3));
//
//			//Have we reached the desired accuracy?
//			if (Mathf.Abs(tNext - t) < error)
//			{
//				break;
//			}
//
//			t = tNext;
//
//			iterations += 1;
//
//			if (iterations > 1000)
//			{
//				break;
//			}
//		}
//		return segment + t;
//	}
//
//
//
//
//	//Returns a position between 4 Vector3 with Catmull-Rom spline algorithm
//	//http://www.iquilezles.org/www/articles/minispline/minispline.htm
//	Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
//	{
//
//		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
//		Vector3 a = 2f * p1;
//		Vector3 b = p2 - p0;
//		Vector3 c = 2f * p0 - 5f * p1 + 4f * p2 - p3;
//		Vector3 d = -p0 + 3f * p1 - 3f * p2 + p3;
//
//		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
//		Vector3 pos = 0.5f * (a + (b * t) + (c * t * t) + (d * t * t * t));
//
//		return pos;
//	}
//
//	Vector3 GetCatmullRomDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
//	{
//		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
//		Vector3 a = 2f * p1;
//		Vector3 b = p2 - p0;
//		Vector3 c = 2f * p0 - 5f * p1 + 4f * p2 - p3;
//		Vector3 d = -p0 + 3f * p1 - 3f * p2 + p3;
//
//		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
//		Vector3 der = 0.5f * b + t*(c+1.5f*d*t);
//
//
//		return der;
//	}
//
//
//
//
//
//
//
//
//	//The derivative of cubic De Casteljau's Algorithm
//	Vector3 DeCasteljausAlgorithmDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
//	{
//
//		Vector3 A = 2f * p1;
//		Vector3 B = p2 - p0;
//		Vector3 C = 2f * p0 - 5f * p1 + 4f * p2 - p3;
//		Vector3 D = -p0 + 3f * p1 - 3f * p2 + p3;
//
//		Vector3 dU = t * t * (-3f * (A - 3f * (B - C) - D));
//
//		dU += t * (6f * (A - 2f * B + C));
//
//		dU += -3f * (A - B); 
//
//		return dU;
//	}
//
//
//	//Get and infinite small length from the derivative of the curve at position t
//	float GetArcLengthIntegrand(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
//	{
//		//The derivative at this point (the velocity vector)
//		Vector3 dPos = GetCatmullRomDerivative(t, p0, p1,p2,p3);
//
//		//This the how it looks like in the YouTube videos
//		//float xx = dPos.x * dPos.x;
//		//float yy = dPos.y * dPos.y;
//		//float zz = dPos.z * dPos.z;
//
//		//float integrand = Mathf.Sqrt(xx + yy + zz);
//
//		//Same as above
//		float integrand = dPos.magnitude;
//
//		return integrand;
//	}
//
//
//	//Get the length of the curve between two t values with Simpson's rule
//	float GetLengthSimpsons(float tStart, float tEnd, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
//	{
//		//This is the resolution and has to be even
//		int n = 20;
//
//		//Now we need to divide the curve into sections
//		float delta = (tEnd - tStart) / (float)n;
//
//		//The main loop to calculate the length
//
//		//Everything multiplied by 1
//		float endPoints = GetArcLengthIntegrand(tStart, p0, p1,p2,p3) + GetArcLengthIntegrand(tEnd, p0, p1,p2,p3);
//
//		//Everything multiplied by 4
//		float x4 = 0f;
//		for (int i = 1; i < n; i += 2)
//		{
//			float t = tStart + delta * i;
//
//			x4 += GetArcLengthIntegrand(t, p0, p1,p2,p3);
//		}
//
//		//Everything multiplied by 2
//		float x2 = 0f;
//		for (int i = 2; i < n; i += 2)
//		{
//			float t = tStart + delta * i;
//
//			x2 += GetArcLengthIntegrand(t, p0, p1,p2,p3);
//		}
//
//		//The final length
//		float length = (delta / 3f) * (endPoints + 4f* x4 + 2f * x2);
//
//		return length;
//	}
//
//
//	public List<Vector4> generateUniformPositions(float stepSize) {
//		List<Vector4> result = new List<Vector4> ();
//
//		float t = 0;
//		float dist = 0;
//		float nextT = 0;
//
//		Vector3 p = getSplinePosition (t);
//		result.Add (new Vector4(p.x, p.y, p.z,1));
//
//		while(t<controlPointCount()-1){
//			dist += stepSize;
//			nextT = FindTValue (dist);
//			t = nextT;
//			 p = getSplinePosition (t);
//			result.Add (new Vector4(p.x, p.y, p.z,1));
//		}
//		return result;
//	}
//}