using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class VTKDataset : Dataset {
	
	[SerializeField]
	string _datasetPath;

	VTK.vtkDataSet _dataset;

	protected override bool ValidateVariable(DataVariable variable) {
		return base.ValidateVariable(variable) && (variable is VTKDataVariable || variable is VTKPositionDataVariable);
	} 


	public override void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!ValidateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
		}
	}

	public override bool IsPath() {
		return _dataset is VTK.vtkPolyData &&  ((VTK.vtkPolyData)_dataset).GetNumberOfLines() > 0;
	}

	public override bool IsMesh() {
		if(_dataset is VTK.vtkPolyData && ((VTK.vtkPolyData)_dataset).GetNumberOfPolys() > 0) return true;
		else if(_dataset is VTK.vtkUnstructuredGrid ) return true;
		else return false;
	}

	public override bool IsVolume() {
		return _dataset is VTK.vtkImageData; 
	}

	public override string GetVariableName(DataVariable variable) {
		if(!ValidateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
		}

		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);

			if(vtkVariable.IsCellVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetCellData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return "";
				}
				return abstractArray.GetName();
			} 

			if(vtkVariable.IsPointVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetPointData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return "";
				}
				return abstractArray.GetName();
			} 
		} else if(variable is VTKPositionDataVariable) {
			VTKPositionDataVariable positionVariable = (VTKPositionDataVariable)variable;
			return "Position";
		}
		
		return "";
	}

	public override bool IsVector(DataVariable variable) {
		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);

			if(vtkVariable.IsCellVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetCellData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return false;
				}
				return abstractArray.GetNumberOfComponents() > 1;
			} 

			if(vtkVariable.IsPointVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetPointData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return false;
				}
				return abstractArray.GetNumberOfComponents() > 1;
			} 
		} else if(variable is VTKPositionDataVariable) {
			VTKPositionDataVariable positionVariable = (VTKPositionDataVariable)variable;
			return true;
		}  

		return false;
	}

}
}
