using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;



public class StreamlineRenderer : Filter {
	public VTKData vtkData;
	public float isovalue = 0.001f;
	bool is_valid = false;

	protected List<Spline> splines;

	[DllImport("vtkplugin")] unsafe private static extern int contour (void *d, float v, int *np, float **p, float **n, int *nt, int **t);
	[DllImport("vtkplugin")] unsafe private static extern void free_data (void* h);

	[DllImport("vtkplugin")] unsafe private static extern void get_array(void *h, StringBuilder array_name, float **values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern void get_points(void *h, float **values, int *number_of_elements, int *number_of_components);
	[DllImport("vtkplugin")] unsafe private static extern int get_number_of_lines (void*h);
	[DllImport("vtkplugin")] unsafe private static extern void get_line_ids (void*h, int line, int** ids_list, int*number_of_ids);
		
	public override void RefreshFilter() {
		getLines ();


	}
	private List<List<int> > ids;
	private Vector3 [] line_positions = null;
	private Vector3 [] line_normals = null;
	private float[] line_values = null;

	private List< List<Vector4> > uniformSplines;

	unsafe void OnDrawGizmos() {
		return;
		if (!is_valid)
			return;
		Gizmos.matrix = transform.localToWorldMatrix;

		for (int l = 0; l < uniformSplines.Count; l++) {
			for (int i = 1; i < uniformSplines [l].Count; i++) {
				Vector3 A = uniformSplines [l] [(i - 1)];
				Vector3 B = uniformSplines [l] [(i)];

				if (i == 1)
					Gizmos.color = Color.green;
				else if (i == uniformSplines [l].Count - 1)
					Gizmos.color = Color.red;
				else if (i % 2 == 0)
					Gizmos.color = Color.white;
				else
					Gizmos.color = Color.black;
				Gizmos.DrawLine(A,B)  ;
			}
		}

		for (int l = 0; l < ids.Count; l++) {
			for (int i = 1; i < ids [l].Count; i++) {
				Vector3 A = line_positions[ids [l] [(i - 1)]];
				Vector3 B = line_positions[ids [l] [i]];

				if (i == 1)
					Gizmos.color = Color.green;
				else if (i == uniformSplines [l].Count - 1)
					Gizmos.color = Color.red;
				else if (i % 2 == 0)
					Gizmos.color = Color.white;
				else
					Gizmos.color = Color.black;
				Gizmos.DrawLine(A,B)  ;
			}
		}
			

		Gizmos.color = Color.green;
	}

	
	unsafe public void getLines()
	{

		if (vtkData == null)
			vtkData = gameObject.transform.parent.gameObject.GetComponent<VTKData> ();
		if (vtkData.handle != null) 
		{
			

			splines = new List<Spline> ();

			float* normals = null;
			float* dataValues = null;
			float* points = null;
			int num_elements_normals = 0;
			int num_components_normals = 0;

			int num_elements_data = 0;
			int num_components_data = 0;

			int num_points = 0;
			int point_components = 0;


			get_array (vtkData.handle, new StringBuilder ("Normals"), &normals, &num_elements_normals, &num_components_normals);
			get_array (vtkData.handle, new StringBuilder ("RTData"), &dataValues, &num_elements_data, &num_components_data);
			get_points (vtkData.handle, &points, &num_points, &point_components);
			int number_of_lines = get_number_of_lines (vtkData.handle);
			ids = new List<List<int> > ();
			line_values = new float[num_points];
			line_positions = new Vector3[num_points];
			line_normals = new Vector3[num_points];
			print ("COMP: " + point_components);
			for (int i = 0; i < num_points; i++) {
				line_positions [i] = new Vector3 (points [i * 3 + 0], points [i * 3 + 1], points [i * 3 + 2]);
				line_normals [i] = new Vector3 (normals [i * 3 + 0], normals [i * 3 + 1], normals [i * 3 + 2]);
				line_values[i] = dataValues[i];
				//print (line_positions[i]);
			}
			for (int i = 0; i < number_of_lines; i++) {
				int* id_list = null;
				int num_ids = 0;
				get_line_ids (vtkData.handle, i, &id_list, &num_ids);
//				print ("Line " + i + " has " + num_ids + " points");
				ids.Add (new List<int> ());
				for (int id = 0; id < num_ids; id++) {
					ids.Last().Add(id_list[id]);
				}
				free_data(id_list);
			}

			uniformSplines = new List<List<Vector4> >() ;
			//print (ids.Count + " == " + number_of_lines);
			for (int l = 0; l < ids.Count; l++) {
				splines.Add (new Spline ());
				
				for (int i = 0; i < ids [l].Count; i++) {
					splines.Last ().addControlPoint (new Vector4(line_positions[ids [l] [i]].x,line_positions[ids [l] [i]].y,line_positions[ids [l] [i]].z,1));
				}
				//print (splines.Last().getLength(0, splines.Last ().controlPointCount ()-1));
				uniformSplines.Add (splines.Last ().generateUniformPositions (0.2f));
			}
			//print (num_elements_normals);
			//print (num_components_normals);
			//print (normals [0] + "," + normals [1] + "," + normals [2]);
			//print (num_components_data);

			print (dataValues [0]);

			free_data (normals);
			free_data (dataValues);
			free_data (points);
			is_valid = true;
			UpdateBuffer ();

		} //else
		//print ("not!");
	}

	private ComputeBuffer positionBuffer;
	private ComputeBuffer offsetBuffer;
	public Material _material;
	public Mesh _mesh;

	void UpdateBuffer() {
		List<int> offsets = new List<int> ();
		List<Vector4> points = new List<Vector4> ();

		int offset = 0;
		for (int i = 0; i < uniformSplines.Count; i++) {
			offsets.Add (offset);
			offset += uniformSplines[i].Count;
			for (int p = 0; p < uniformSplines [i].Count; p++) {
				//points.Add (new Vector4 (i, p, 0, 1));
				//print (points.Last ());
				points.Add (uniformSplines [i] [p]);
			}
		}

		positionBuffer = new ComputeBuffer (points.Count,sizeof(float)*4);
		positionBuffer.SetData (points.ToArray());

		offsetBuffer = new ComputeBuffer (offsets.Count, sizeof(int));
		offsetBuffer.SetData (offsets.ToArray ());


		if (_material != null) {
			_material.SetBuffer ("_positions", positionBuffer);
			Debug.Log ("SET BUFFER: " + points.Count);
			_material.SetInt ("_numPositions", points.Count);

			_material.SetBuffer ("_offsets", offsetBuffer);
			Debug.Log ("SET BUFFER");
			_material.SetInt ("_numLines", offsets.Count);

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

		_material.SetFloat("_meshHeight",_mesh.bounds.extents.y);
		print ("_meshHeight " +  _mesh.bounds.extents.y);

		argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);
		UpdateBuffers();

	}
	void Update()
	{ 
		if (!is_valid)
			return;
		_material.SetMatrix ("_DataTransform", transform.localToWorldMatrix);
		_material.SetFloat("_offset", _offset);
		_material.SetFloat ("_glyphScale", _glyphScale);
		_material.SetFloat ("_glyphRadius", _glyphRadius);
		_material.SetFloat ("_glyphInflate", _glyphInflate);
		_material.SetFloat ("_glyphTwist", _glyphTwist);
		_material.SetFloat ("_glyphSpacing", _glyphSpacing);
		_material.SetFloat ("_glyphTextureScale", _glyphTextureScale);

		// Update starting position buffer
		if (cachedInstanceCount != instanceCount) UpdateBuffers();

		// Pad input
		//if (Input.GetAxisRaw("Horizontal") != 0.0f) instanceCount = (int)Mathf.Clamp(instanceCount + Input.GetAxis("Horizontal") * 40000, 1.0f, 5000000.0f);

		// Render
		Graphics.DrawMeshInstancedIndirect(_mesh, 0, _material, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)), argsBuffer,0,null, UnityEngine.Rendering.ShadowCastingMode.Off);
		//  instanceMaterial.SetBuffer("positionBuffer", positionBuffer);
	}


}






public class Spline
{

	public List<Vector3> controlPointsList;

	public Spline() {
		controlPointsList = new List<Vector3>();
	}

	public void addControlPoint(Vector3 t, float e = 0.001f) {
		//if(controlPointsList.Count != 0)
			//Debug.Log ((controlPointsList.Last () - t).magnitude + " < " + e);
		if(controlPointsList.Count == 0 || (controlPointsList.Last() - t).magnitude > e)
			controlPointsList.Add (t);

	}

	public int controlPointCount() {
		return controlPointsList.Count;
	}
	public int[] getSegmentIndices(int seg) {
		int[] result = new int[4];
		int index0 = seg==0? 0 : seg - 1;
		int index1 = seg;
		int index2 = seg + 1;
		int index3 = seg + 2 <= controlPointCount() - 1? seg + 2: seg + 1;

		result [0] = index0;
		result [1] = index1;
		result [2] = index2;
		result [3] = index3;

		return result;
	}
	public float getSegmentLength(int seg) {


		int[] index = getSegmentIndices (seg);
		Vector3 p0 = controlPointsList[index[0]];
		Vector3 p1 = controlPointsList[index[1]];
		Vector3 p2 = controlPointsList[index[2]];
		Vector3 p3 = controlPointsList[index[3]];

		float len = GetLengthSimpsons (0, 1, p0, p1, p2, p3);
		return len;
	}

	public float getLength(float t_start, float t_end) {
		//			float t_i_a = t_start;
		//			float t_i_b = Mathf.Floor (t_start) + 1;
		//Debug.Log(t_start +" -- " + t_end);
		float t_i = t_start;

		float len = 0;

		while (t_i <= t_end) {
			int seg = (int)Mathf.Floor (t_i );

			float seg_t = t_i - seg;

			float t_j = Mathf.Min (t_end, seg + 1f)-seg;
			if (seg < controlPointCount () - 1) {
				int[] index = getSegmentIndices (seg);
				Vector3 p0 = controlPointsList [index [0]];
				Vector3 p1 = controlPointsList [index [1]];
				Vector3 p2 = controlPointsList [index [2]];
				Vector3 p3 = controlPointsList [index [3]];



				len += GetLengthSimpsons (seg_t, t_j, p0, p1, p2, p3);
			}

			t_i += 1;
			//Debug.Log (t_i);

		}


		return len;



	}

	public Vector3 getSplinePosition(float t) {
		int seg = (int)Mathf.Floor (t);

		float seg_t = t - seg;
		if (seg > controlPointCount () - 2) {
			seg = controlPointCount () - 2;
			seg_t = 1;
		}
		int[] index = getSegmentIndices (seg);
		Vector3 p0 = controlPointsList[index[0]];
		Vector3 p1 = controlPointsList[index[1]];
		Vector3 p2 = controlPointsList[index[2]];
		Vector3 p3 = controlPointsList[index[3]];
		return (GetCatmullRomPosition (seg_t, p0, p1, p2, p3));
	}

	public Vector3 getSplineDerivative(float t) {
		int seg = (int)Mathf.Floor (t);

		float seg_t = t - seg;
		if (seg > controlPointCount () - 2) {
			seg = controlPointCount () - 2 ;
			seg_t = 1;
		}
		int[] index = getSegmentIndices (seg);
		Vector3 p0 = controlPointsList[index[0]];
		Vector3 p1 = controlPointsList[index[1]];
		Vector3 p2 = controlPointsList[index[2]];
		Vector3 p3 = controlPointsList[index[3]];
		return (GetCatmullRomDerivative (seg_t, p0, p1, p2, p3));
	}


	//Use Newton–Raphsons method to find the t value at the end of this distance d
	public float FindTValue(float d)
	{
		d = Mathf.Max (0, d);
		int segment = 0;
		float segmentLength = getLength (segment, segment + 1);
		while (d > segmentLength && segment < controlPointCount()-1) {
			d -= segmentLength;

			segment++;
			segmentLength = getLength (segment, segment + 1);
		}
		if (segment == controlPointCount()-1)
			return segment;
		int[] index = getSegmentIndices (segment);
		Vector3 p0 = controlPointsList[index[0]];
		Vector3 p1 = controlPointsList[index[1]];
		Vector3 p2 = controlPointsList[index[2]];
		Vector3 p3 = controlPointsList[index[3]];

		//Need a start value to make the method start
		//Should obviously be between 0 and 1
		//We can say that a good starting point is the percentage of distance traveled
		//If this start value is not working you can use the Bisection Method to find a start value
		//https://en.wikipedia.org/wiki/Bisection_method
		float t = d / segmentLength;

		//Need an error so we know when to stop the iteration
		float error = 0.001f;

		//We also need to avoid infinite loops
		int iterations = 0;

		while (true)
		{
			//Newton's method
			float tNext = t - ((GetLengthSimpsons(0f, t, p0, p1,p2,p3) - d) / GetArcLengthIntegrand(t, p0, p1,p2,p3));

			//Have we reached the desired accuracy?
			if (Mathf.Abs(tNext - t) < error)
			{
				break;
			}

			t = tNext;

			iterations += 1;

			if (iterations > 1000)
			{
				break;
			}
		}
		return segment + t;
	}




	//Returns a position between 4 Vector3 with Catmull-Rom spline algorithm
	//http://www.iquilezles.org/www/articles/minispline/minispline.htm
	Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{

		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
		Vector3 a = 2f * p1;
		Vector3 b = p2 - p0;
		Vector3 c = 2f * p0 - 5f * p1 + 4f * p2 - p3;
		Vector3 d = -p0 + 3f * p1 - 3f * p2 + p3;

		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
		Vector3 pos = 0.5f * (a + (b * t) + (c * t * t) + (d * t * t * t));

		return pos;
	}

	Vector3 GetCatmullRomDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		//The coefficients of the cubic polynomial (except the 0.5f * which I added later for performance)
		Vector3 a = 2f * p1;
		Vector3 b = p2 - p0;
		Vector3 c = 2f * p0 - 5f * p1 + 4f * p2 - p3;
		Vector3 d = -p0 + 3f * p1 - 3f * p2 + p3;

		//The cubic polynomial: a + b * t + c * t^2 + d * t^3
		Vector3 der = 0.5f * b + t*(c+1.5f*d*t);


		return der;
	}








	//The derivative of cubic De Casteljau's Algorithm
	Vector3 DeCasteljausAlgorithmDerivative(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{

		Vector3 A = 2f * p1;
		Vector3 B = p2 - p0;
		Vector3 C = 2f * p0 - 5f * p1 + 4f * p2 - p3;
		Vector3 D = -p0 + 3f * p1 - 3f * p2 + p3;

		Vector3 dU = t * t * (-3f * (A - 3f * (B - C) - D));

		dU += t * (6f * (A - 2f * B + C));

		dU += -3f * (A - B); 

		return dU;
	}


	//Get and infinite small length from the derivative of the curve at position t
	float GetArcLengthIntegrand(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		//The derivative at this point (the velocity vector)
		Vector3 dPos = GetCatmullRomDerivative(t, p0, p1,p2,p3);

		//This the how it looks like in the YouTube videos
		//float xx = dPos.x * dPos.x;
		//float yy = dPos.y * dPos.y;
		//float zz = dPos.z * dPos.z;

		//float integrand = Mathf.Sqrt(xx + yy + zz);

		//Same as above
		float integrand = dPos.magnitude;

		return integrand;
	}


	//Get the length of the curve between two t values with Simpson's rule
	float GetLengthSimpsons(float tStart, float tEnd, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		//This is the resolution and has to be even
		int n = 20;

		//Now we need to divide the curve into sections
		float delta = (tEnd - tStart) / (float)n;

		//The main loop to calculate the length

		//Everything multiplied by 1
		float endPoints = GetArcLengthIntegrand(tStart, p0, p1,p2,p3) + GetArcLengthIntegrand(tEnd, p0, p1,p2,p3);

		//Everything multiplied by 4
		float x4 = 0f;
		for (int i = 1; i < n; i += 2)
		{
			float t = tStart + delta * i;

			x4 += GetArcLengthIntegrand(t, p0, p1,p2,p3);
		}

		//Everything multiplied by 2
		float x2 = 0f;
		for (int i = 2; i < n; i += 2)
		{
			float t = tStart + delta * i;

			x2 += GetArcLengthIntegrand(t, p0, p1,p2,p3);
		}

		//The final length
		float length = (delta / 3f) * (endPoints + 4f* x4 + 2f * x2);

		return length;
	}


	public List<Vector4> generateUniformPositions(float stepSize) {
		List<Vector4> result = new List<Vector4> ();

		float t = 0;
		float dist = 0;
		float nextT = 0;

		Vector3 p = getSplinePosition (t);
		result.Add (new Vector4(p.x, p.y, p.z,1));

		while(t<controlPointCount()-1){
			dist += stepSize;
			nextT = FindTValue (dist);
			t = nextT;
			 p = getSplinePosition (t);
			result.Add (new Vector4(p.x, p.y, p.z,1));
		}
		return result;
	}
}