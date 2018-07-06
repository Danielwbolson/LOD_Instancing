using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using VTK;

namespace DEPRECATED {


[Serializable]
public class Variable : ScriptableObject {
    public enum StorageType {
        TEXTURE,
        BUFFER
    }
	public Variable(DataObject dataObject) {
		_dataObject = dataObject;	
	}
	
	public enum VariableType {
		ERROR,
		POINT,
		CELL
	};

    [SerializeField, HideInInspector]
	DataObject _dataObject;
    [SerializeField, HideInInspector]
	int _arrayID;
    [SerializeField, HideInInspector]
	string _arrayName;
    [SerializeField, HideInInspector]
	VariableType _variableType;
    [SerializeField, HideInInspector]
	vtkAbstractArray _abstractArray;

    public StorageType GetStorageType() {
        if(_dataObject.GetDataSet().IsA("vtkImageData"))
            return StorageType.TEXTURE;
        else
            return StorageType.BUFFER;
    }
    public string GetVariableName() {
        return _arrayName;
    }
    public int GetVariableIndex() {
        return _arrayID;
    }
    public VariableType GetVariableType() {
        return _variableType;
    }
    public int GetVariableComponentCount() {
        return _abstractArray.GetNumberOfComponents();
    }
    public long GetVariableElementCount() {
        return _abstractArray.GetNumberOfTuples();
    }

    public Vector4 GetMinValue() {
        return _min;
    }

    public Vector4 GetMaxValue() {
        return _max;
    }
    [SerializeField, HideInInspector]
    Vector4 _min;
    [SerializeField, HideInInspector]
    Vector4 _max;
    void SetMinAndMax(vtkDataArray dataArray) {
        _min = new Vector4();
        _max = new Vector4();
        for(int i = 0; i < GetVariableComponentCount(); i++) {
            double [] range = new double[2]; 
            dataArray.GetRange(range,i);
            _min[i] = (float)range[0];
            _max[i] = (float)range[1];
        }
    }
	public bool SetPointVariableName(string name) {
		vtkPointData pd = _dataObject.GetDataSet().GetPointData();
		int pd_array_count = pd.GetNumberOfArrays();
		IntPtr index = new IntPtr((int)-1);
		_abstractArray = pd.GetAbstractArray(name, index);
		if(index.ToInt32() < 0) {
			_variableType = VariableType.ERROR;
			return false;
		} else {
			_arrayID = index.ToInt32();
			_arrayName = name;
			_variableType = VariableType.POINT;
            SetMinAndMax(vtkDataArray.SafeDownCast(_abstractArray));
			return true;
		}
	}

	public bool SetCellVariableName(string name) {
		vtkCellData cd = _dataObject.GetDataSet().GetCellData();
		int cd_array_count = cd.GetNumberOfArrays();
		IntPtr index = new IntPtr((int)-1);
		_abstractArray = cd.GetAbstractArray(name, index);
		if(index.ToInt32() < 0) {
			_variableType = VariableType.ERROR;
			return false;
		} else {
			_arrayID = index.ToInt32();
			_arrayName = name;
			_variableType = VariableType.CELL;
            SetMinAndMax(vtkDataArray.SafeDownCast(_abstractArray));
            
			return true;
		}
	}

	public bool SetVariableName(string name) {
		return SetPointVariableName(name) || SetCellVariableName(name);
	}

	public bool SetCellVariableIndex(int index) {
		vtkCellData cd = _dataObject.GetDataSet().GetCellData();
		int cd_array_count = cd.GetNumberOfArrays();
		if(cd_array_count <= index) {
			_variableType = VariableType.ERROR;
			return false;
		} else {
			_arrayID = index;
			_arrayName = cd.GetArrayName(index);
			_variableType = VariableType.CELL;
			_abstractArray = cd.GetAbstractArray(index);
            SetMinAndMax(vtkDataArray.SafeDownCast(_abstractArray));
			return true;
		}
	}

	public bool SetPointVariableIndex(int index) {
		vtkPointData pd = _dataObject.GetDataSet().GetPointData();
		int pd_array_count = pd.GetNumberOfArrays();
		if(pd_array_count <= index) {
			_variableType = VariableType.ERROR;
			return false;
		} else {
			_arrayID = index;
			_arrayName = pd.GetArrayName(index);
			_variableType = VariableType.POINT;
			_abstractArray = pd.GetAbstractArray(index);
            SetMinAndMax(vtkDataArray.SafeDownCast(_abstractArray));
			return true;
		}
	}
}
}