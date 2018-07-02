using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using VTK;


public class VariableList {
    [SerializeField, HideInInspector]
    List<Variable> _variables;
    [SerializeField, HideInInspector]
	DataObject _dataObject;
	public VariableList(DataObject dataObject) {
		_dataObject = dataObject;	
	}


 
    public Variable GetPointVariable(string name) {
        Variable v = new Variable(_dataObject);
        if(v.SetPointVariableName(name)) {
            return v;
        } else {
            return null;
        }
	}

	public Variable GetCellVariable(string name) {
	    Variable v = new Variable(_dataObject);
        if(v.SetCellVariableName(name)) {
            return v;
        } else {
            return null;
        }
	}

	public Variable GetVariable(string name) {
        Variable v = new Variable(_dataObject);
        if(v.SetVariableName(name)) {
            return v;
        } else {
            return null;
        }
    }

	public Variable GetCellVariable(int index) {
		Variable v = new Variable(_dataObject);
        if(v.SetCellVariableIndex(index)) {
            return v;
        } else {
            return null;
        }
	}

	public Variable GetPointVariable(int index) {
		Variable v = new Variable(_dataObject);
        if(v.SetPointVariableIndex(index)) {
            return v;
        } else {
            return null;
        }
	}

    public List<Variable> GetVariables() {
        if(_variables == null) {
            _variables = new List<Variable>();
            vtkFieldData cd = _dataObject.GetDataSet().GetCellData();
            vtkFieldData pd = _dataObject.GetDataSet().GetPointData();
            int pd_count = pd.GetNumberOfArrays();
            int cd_count = cd.GetNumberOfArrays();

            for(int i = 0; i < pd_count; i++) {
                Variable v = new Variable(_dataObject);
                _variables.Add(GetPointVariable(i));
            }
           
            for(int i = 0; i < cd_count; i++) {
                Variable v = new Variable(_dataObject);
                _variables.Add(GetCellVariable(i));
            }   
        }
        return _variables;
    } 
    
    string [] _names;
    public string [] GetVariableNames() {
        if(_names == null) {
            _names = new string[GetVariables().Count];
            for(int i =0; i < _names.Length; i++) {
                _names[i] = "[" + GetVariables()[i].GetVariableType() + "] " + GetVariables()[i].GetVariableName() + " (" + GetVariables()[i].GetVariableComponentCount() + ")";
            }
        }
        return _names;
    } 

}