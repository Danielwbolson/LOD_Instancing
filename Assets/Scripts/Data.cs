using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;


public class Data : ScriptableObject {



	protected Vector3 data_center;
	protected Vector3 data_size;

	protected bool is_valid = false;

	public bool Valid() {
		return is_valid;
	}
	public virtual int GetNumberOfLines() {
		return 0;
	}
	public Vector3 getBoundingCenter () {
		return data_center;
	}
	public Vector3 getBoundingSize() {
		return data_size;
	}

	virtual public int GetNumberOfVariables() {
		return 0;
	}
	virtual public bool IsType(string type) {
		return 0 == 1;
	}

	virtual public string GetVariableName(int i) {
		return null;
	}
	virtual public int GetVariableComponentCount(int i) {
		return 0;
	}
	virtual public void LoadData() {

	}

	public string filename;

	public void SetFileName(string f)
	{
		filename = f;
	}

}
