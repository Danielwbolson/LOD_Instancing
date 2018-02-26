using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class DataVariable {
	public DataVariable() {

	}
	public DataVariable(float[] data, int components) {
		setData (data, components);
	}
	public DataVariable(float[] data, int components, float [] mins, float [] maxes) {
		setData (data, components, mins, maxes);
	}
	protected float [] _data = null;
	int _numberOfElements;
	int _numberOfComponents;
	float [] _mins;
	float [] _maxes;
	public float[] getData() {
		return _data;
	}
	public float getDataAt(int index) {
		return _data [index];

	}

	public int getNumberOfComponents() {
		return _numberOfComponents;
	}
	public void setData(float[] data, int components) {
		_data = data;
		this._numberOfComponents = components;
		this._numberOfElements = _data.Length / components;
		this._mins = null;
		this._maxes = null;
	}

	public void setData(float[] data, int components, float [] mins, float [] maxes) {
		_data = data;
		this._numberOfComponents = components;
		this._numberOfElements = _data.Length / components;
		this._mins = mins;
		this._maxes = maxes;
	}

	public void setDataAt(int index, float f) {
		_data [index] = f;
	}
	public float getMinValue(int component = 0) {
		return _mins [component];
	}
	public float getMaxValue(int component = 0) {
		return _maxes [component];
	}

}
public class DataSet {
	protected Dictionary<string, DataVariable> _variables;
	public DataSet() {
		_variables = new Dictionary<string, DataVariable> ();
	}

	public void addVariable(string name, float[] data, int components) {
		_variables[name] = new DataVariable (data, components);

	}

	public void addVariable(string name, float[] data, int components, float[] mins, float[]maxes) {
		_variables[name] = new DataVariable (data, components, mins, maxes);

	}

	public DataVariable getVariable(string name) {
		return _variables [name];
	}
}


public class Paths : DataSet {

	SortedDictionary<int, List<int> > _pathIndices;

	DataVariable _positionVariable = null;
	DataVariable _normalVariable = null;

	public Paths() {
		_pathIndices = new SortedDictionary<int, List<int> >();
	}

	public void setPointData(float[] data, int components) {
		this.addVariable ("positions", data, components);
		_positionVariable = _variables ["positions"];

	}

	public void setNormalData(float[] data, int components) {
		this.addVariable ("normals", data, components);
		_normalVariable = _variables ["normals"];

	}

	public int getNumberOfLines() {
		return _pathIndices.Count();
	}

	public int[] getLineIndices(int lineIndex) {
		return _pathIndices.Values.ToList()[lineIndex].ToArray() ;;
	}
	public DataVariable getPositionVariable() {
		if (_positionVariable == null)
			_positionVariable = _variables ["positions"];
		return _positionVariable;
	}

	public DataVariable getNormalVariable() {
		if (_normalVariable == null)
			_normalVariable = _variables ["normals"];
		return _normalVariable;
	}
	public Vector3 getLineVertex(int index) {
		DataVariable ds = getPositionVariable();
		float[] p = getLineVariableValue (ds, index);
		Vector3 P;// = new Vector3 (ds.getDataAt (index * ds.getNumberOfComponents () + 0), ds.getDataAt (index * ds.getNumberOfComponents () + 1), ds.getDataAt (index * ds.getNumberOfComponents () + 2));
		P = new Vector3 (p[0], p[1], p[2]);

		return P;
	}
	public Vector3 getLineNormal(int index) {
		DataVariable ds = getNormalVariable();
		return new Vector3(ds.getDataAt (index*ds.getNumberOfComponents() +0), ds.getDataAt (index*ds.getNumberOfComponents() +1), ds.getDataAt (index*ds.getNumberOfComponents() +2) );
	}
	public float getLineVariableValue1(DataVariable variable, int index) {
		DataVariable ds = variable;
		return ds.getDataAt (index*ds.getNumberOfComponents() +0);
	}
	public float [] getLineVariableValue(DataVariable variable, int index) {
		DataVariable ds = variable;

		if (ds == null) {
			int x = 0;
		}
		float[] values = new float[ds.getNumberOfComponents()];
		for(int v = 0; v < ds.getNumberOfComponents(); v++){ 
			values[v] = ds.getDataAt (index*ds.getNumberOfComponents() +v);
		}
		return values;
	}


	public float getLineVariableValue1(string variableName, int index) {
		DataVariable ds = _variables [variableName];
		return getLineVariableValue1(ds,index);
	}
	public float [] getLineVariableValue(string variableName, int index) {
		DataVariable ds = _variables [variableName];
		return getLineVariableValue (ds, index);;
	}

	public void addLine(int [] indices, int seedID, bool should_combine) {
		
		if (!_pathIndices.ContainsKey (seedID)) {
			//int[] pathIndices = (int[])indices.Clone ();
			//Array.Reverse (pathIndices);
			_pathIndices [seedID] = indices.OfType<int> ().ToList ();
		} else if (should_combine) {
			_pathIndices [seedID].Reverse ();
			// Flip normals
			int comp = getNormalVariable ().getNumberOfComponents ();

			for (int i = 0; i < _pathIndices [seedID].Count (); i++) {
				for (int c = 0; c < comp; c++) {
					getNormalVariable ().setDataAt(_pathIndices [seedID] [i]*comp + c,  -getNormalVariable ().getDataAt (_pathIndices [seedID] [i]*comp+c) );

				}
			}


			_pathIndices [seedID].AddRange (indices);


		} else {
			_pathIndices [-seedID] = indices.OfType<int> ().ToList ();
		}

	}
	float[][] segmentLengths;

	float segmentLength(int line, int t) {
		if (segmentLengths == null)
			segmentLengths  = new float[getNumberOfLines()][];
		if (segmentLengths [line] == null) {
			segmentLengths [line] = new float[getLineIndices (line).Count ()];
			for (int i=0; i<segmentLengths[line].Length; i++) { segmentLengths[line][i] = -1; }
		}
		if (segmentLengths [line] [t] > 0) {
			//return segmentLengths [line] [t];
		}

		int[] lineIndices = getLineIndices (line);

		int a = Mathf.Max (t, 0);
		int b = Mathf.Min (t + 1, lineIndices.Count () - 1);

		Vector3 A = getPositionAtT (line, a);
		Vector3 B = getPositionAtT (line, b);


		float dist = Vector3.Distance (A, B);

		segmentLengths [line] [t] = dist;

		return segmentLengths [line] [t] ;

	}
	float[] lineLengths;
	public float getLineLength(int line) {
		if(lineLengths == null) {
			lineLengths = new float[getNumberOfLines()];
			for(int i = 0; i < getNumberOfLines(); i++)
				lineLengths[i] = -1;
		}
		if(lineLengths[line] < 0) {
			lineLengths[line] = calculateLineLength(line);
		}

		return lineLengths[line];
	}
	float calculateLineLength(int line) {
		int[] lineIndices = getLineIndices (line);
		float length = 0;
		if (lineIndices.Count () == 0)
			return length;
		
		Vector3 last = getLineVertex(lineIndices[0]);
		Vector3 next;

		for (int i = 1; i < lineIndices.Count (); i++) {
			next = getLineVertex (lineIndices [i]);
			float between = (next - last).magnitude;

			length += between;
			last = next;
		}
		return length;
	}
	float calculateTotalLength() {
		float length = 0;
		for (int i = 0; i < getNumberOfLines (); i++) {
			length += calculateLineLength (i);
		}
		return length;
	}

	float [] getInterpolationAtT(DataVariable v, int line, float t) {
		int[] lineIndices = getLineIndices (line);
		float [] tween = new float[v.getNumberOfComponents()];

//		tween [0] = getLineVertex (lineIndices [(int)t]).x;
//		tween [1] = getLineVertex (lineIndices [(int)t]).y;
//		tween [2] = getLineVertex (lineIndices [(int)t]).z;

//		float [] result = getLineVariableValue (v, lineIndices [(int)t]);;
		///return tween;

		//return result;
		int ti = (int)t;
		int a = Mathf.Max (ti, 0);
		int b = Mathf.Min (ti + 1, lineIndices.Count () - 1);
		//float [] A = v.getDataAt(lineIndices [a]);
		//float[] B = v.getDataAt (lineIndices [b]);

		if (a >= lineIndices.Count ()|| a < 0)
			Debug.Log ("BANG");
		for(int c = 0; c< v.getNumberOfComponents(); c++) {
			float A = v.getDataAt(lineIndices [a]*v.getNumberOfComponents() + c);
			float B = v.getDataAt(lineIndices [b]*v.getNumberOfComponents() + c);

			tween [c] = Mathf.Lerp (A, B, t-ti);
					
		}
		//Debug.Log(a + "->" +b + "; " + v.getDataAt(lineIndices [a]*v.getNumberOfComponents() ) +"->" +  v.getDataAt(lineIndices [b]*v.getNumberOfComponents() ) +" (" + (t-ti) + ") = " + tween[0]); 
		return tween;

	}
	Vector3 getPositionAtT(int line, float t) {
		float[] r = getInterpolationAtT (getPositionVariable(), line, t);
		return new Vector3 (r[0], r[1], r[2]);

	}

	Vector3 getNormalAtT(int line, float t) {
		float[] r = getInterpolationAtT (_normalVariable, line, t);
		return new Vector3 (r[0], r[1], r[2]);
	}


	float getInterpolatedStep(int line, float t_a, float step) {

		float t = t_a;
		int count = getLineIndices (line).Count ();


		float remaining_step = step;

		float currentSegmentLength = segmentLength(line, (int)t);
		float left_in_t = 1.0f- (t - (int)t);

		if (remaining_step < left_in_t * currentSegmentLength) {
			t += remaining_step / currentSegmentLength;
			return t;
		}
		if (left_in_t > 0) { 
			remaining_step -= left_in_t * currentSegmentLength;
			t = (int)t + 1;

		}

		currentSegmentLength = segmentLength (line, (int)t);
		while (t < count && remaining_step > currentSegmentLength ) 
		{

			remaining_step -= currentSegmentLength;
			t += 1;
			if(t < count)
				currentSegmentLength = segmentLength(line, (int)t);
		}

		if (t >= count) {
			return -1;
		}
			

		return t + remaining_step / currentSegmentLength;;

			
	
	}
	public List<List<Vector3> > tempSteps;
	public List<List<Vector3> > tempNorms;

	public Paths generateUniformPaths(float stepSize) {
		tempSteps = new List<List<Vector3> > (); 
		tempNorms = new List<List<Vector3> > (); 

		_positionVariable = _variables ["positions"];
		_normalVariable = _variables ["normals"];
		//List<int> newIndices = new List<int> ();
		List<float> lineLengths = new List<float> ();

		int numLines = getNumberOfLines ();
		
		//numLines = 1;
		for (int l = 0; l < numLines; l++) {
			lineLengths.Add (calculateLineLength (l)); 
		}

		Dictionary<string, List<float> > newValues = new Dictionary<string, List<float> > ();
		List<DataVariable> sources = new List<DataVariable>();
		List<List<float>> destinations = new List<List<float>>();
		List<string> names = new List<string>();

		foreach(KeyValuePair<string,  DataVariable> entry in _variables)
		{
			names.Add (entry.Key);
			sources.Add (entry.Value);
			destinations.Add (new List<float> ());
		}

		
		List< List<int> > newIndices = new List< List<int> > ();
		List<int> seeds = new List<int>();
		List<List<int> > oldIndices = new List<List<int> > ();

		foreach(KeyValuePair<int,  List<int>> entry in _pathIndices)
		{
			seeds.Add (entry.Key);
			oldIndices.Add(entry.Value);
			newIndices.Add(new List<int>());
		}
		int index = 0;
		for (int l = 0; l < numLines; l++) {
			
			tempSteps.Add (new List<Vector3> ());
			tempNorms.Add (new List<Vector3> ());
			int[] li = getLineIndices (l);
			int i = 0;
			float t = 0;

			Debug.Log ("Line " + l);
			while ((t = getInterpolatedStep (l, t, stepSize)) > 0) {
				i++;
				for (int v = 0; v < names.Count (); v++) {
					float[] d = getInterpolationAtT (sources[v], l, (float)t);
					foreach (float f in d) {
						destinations [v].Add (f);
					}
				}

				newIndices [l].Add (index++);

//				float[] p = getInterpolationAtT (_positionVariable, l, (float)t);
//				float[] n = getInterpolationAtT (_normalVariable, l, (float)t);

//				tempSteps.Last().Add(new Vector3(p[0],p[1],p[2]));
//				tempNorms.Last ().Add (new Vector3(n[0],n[1],n[2]));


			}



			float len = calculateLineLength (l);
			Debug.Log ("Length: " + (len));


			Debug.Log ("Compare: " + i  + ", " + (int)(len) / stepSize);
		}

		Paths newPaths = new Paths ();
		for (int i = 0; i < names.Count (); i++) {
			newPaths.addVariable (names [i], destinations [i].ToArray (), sources [i].getNumberOfComponents());
		}
		for (int i = 0; i < seeds.Count (); i++) {
			newPaths.addLine (newIndices [i].ToArray (), seeds [i], false);
				
		}
		return newPaths;
	}


}
