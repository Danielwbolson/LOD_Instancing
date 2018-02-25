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

//public class PathInterpolator {
//
//}
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
		_positionVariable = _variables ["normals"];

	}

	public int getNumberOfLines() {
		return _pathIndices.Count();
	}

	public int[] getLineIndices(int lineIndex) {
		return _pathIndices.Values.ToList()[lineIndex].ToArray() ;;
	}

	public Vector3 getLineVertex(int index) {
		DataVariable ds = _variables ["positions"];
		return new Vector3(ds.getDataAt (index*ds.getNumberOfComponents() +0), ds.getDataAt (index*ds.getNumberOfComponents() +1), ds.getDataAt (index*ds.getNumberOfComponents() +2) );
	}
	public Vector3 getLineNormal(int index) {
		DataVariable ds = _variables ["normals"];
		return new Vector3(ds.getDataAt (index*ds.getNumberOfComponents() +0), ds.getDataAt (index*ds.getNumberOfComponents() +1), ds.getDataAt (index*ds.getNumberOfComponents() +2) );
	}
	public float getLineVariableValue1(string variableName, int index) {
		DataVariable ds = _variables [variableName];
		return ds.getDataAt (index*ds.getNumberOfComponents() +0);
	}
	public float [] getLineVariableValue(string variableName, int index) {
		DataVariable ds = _variables [variableName];
		float[] values = new float[ds.getNumberOfComponents()];
		for(int v = 0; v < ds.getNumberOfComponents(); v++){ 
			values[v] = ds.getDataAt (index*ds.getNumberOfComponents() +v);
		}
		return values;
	}

	public void addLine(int [] indices, int seedID, bool should_combine) {
		
		if (!_pathIndices.ContainsKey (seedID)) {
			//int[] pathIndices = (int[])indices.Clone ();
			//Array.Reverse (pathIndices);
			_pathIndices [seedID] = indices.OfType<int> ().ToList ();
		} else if (should_combine) {
			_pathIndices [seedID].Reverse ();
			_pathIndices [seedID].AddRange (indices);
		} else {
			_pathIndices [-seedID] = indices.OfType<int> ().ToList ();
		}
	}
	float segmantLength(int line, float t) {
		int[] lineIndices = getLineIndices (line);

		int ti = (int)t;
		int a = Mathf.Max (ti, 0);
		int b = Mathf.Min (ti + 1, lineIndices.Count () - 1);

		Vector3 A = getPositionAtT (line, a);
		Vector3 B = getPositionAtT (line, b);

		return (A - B).magnitude;

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
		int ti = (int)t;
		int a = Mathf.Max (ti, 0);
		int b = Mathf.Min (ti + 1, lineIndices.Count () - 1);
		//float [] A = v.getDataAt(lineIndices [a]);
		//float[] B = v.getDataAt (lineIndices [b]);
		float [] tween = new float[v.getNumberOfComponents()];

		if (a >= lineIndices.Count ()|| a < 0)
			Debug.Log ("BANG");
		for(int c = 0; c< v.getNumberOfComponents(); c++) {
			float A = v.getDataAt(lineIndices [a]*v.getNumberOfComponents() + c);
			float B = v.getDataAt(lineIndices [b]*v.getNumberOfComponents() + c);

			tween [c] = Mathf.Lerp (A, B, t-ti);
					
		}
		return tween;

	}
	Vector3 getPositionAtT(int line, float t) {
		float[] r = getInterpolationAtT (_positionVariable, line, t);
		return new Vector3 (r[0], r[1], r[2]);

	}

	Vector3 getNormalAtT(int line, float t) {
		float[] r = getInterpolationAtT (_normalVariable, line, t);
		return new Vector3 (r[0], r[1], r[2]);
	}


	double getInterpolatedStep(int line, double t_a, float step) {

		double t = t_a;
		double remaining_step = step;

		double currentSegmentLength = segmantLength(line, (int)t);
		double remaining_sub_t = t - (int)t;
		if (remaining_step < remaining_sub_t * currentSegmentLength)
			t += remaining_step / currentSegmentLength;
		
		int count = getLineIndices (line).Count ();
		while (t < count && remaining_step > (currentSegmentLength = segmantLength(line, (int)t)) ) {
			remaining_step -= currentSegmentLength;
			t += 1;

			//currentSegmentLength = segmantLength(line, (int)t);

		}

		if (remaining_step <=  currentSegmentLength)
			t += remaining_step / currentSegmentLength;
		else
			return -1;
		

		return (float)t;

	}

	public Paths generateUniformPaths(float stepSize) {
		for (int l = 0; l < getNumberOfLines (); l++) {
			int i = 0;
			double t = 0;

			Debug.Log ("Line " + l);
			while ((t = getInterpolatedStep (l, t, stepSize)) > 0)
				i++;


			float len = calculateLineLength (l);
			Debug.Log ("Length: " + (len));


			Debug.Log ("Compare: " + i  + ", " + (int)(len) / stepSize);
		}
		return null;
	}


}
