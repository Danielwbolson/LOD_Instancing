using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class VTKDataset : Dataset {
	
	[SerializeField]
	string _datasetPath;

	VTK.vtkDataSet _dataset;

	protected override int queryNumberOfVariables() {
		return (_dataset.IsA("vtkPointSet")?1:0) /* <- position*/ + _dataset.GetPointData().GetNumberOfArrays() + _dataset.GetCellData().GetNumberOfArrays() ;
	}
	protected override DataVariable generateVarible(int i) {
		int numPointArrays = _dataset.GetPointData().GetNumberOfArrays();
		int numCellArrays = _dataset.GetCellData().GetNumberOfArrays();
		VTK.vtkAbstractArray abstractArray;

		int positionOffset = (_dataset.IsA("vtkPointSet")?1:0);
		DataVariable result = null;
		if(positionOffset == 1 &&  i == 0 ) {
			VTKPositionDataVariable var = ScriptableObject.CreateInstance<VTKPositionDataVariable>();
			var.Init(this);
			result = var;

		} else if(i < numPointArrays + positionOffset) {
			abstractArray = _dataset.GetPointData().GetAbstractArray(i-1);
			VTKDataVariable var = ScriptableObject.CreateInstance<VTKDataVariable>();
			var.Init(this, VTKDataVariable.ArrayType.Point, i - positionOffset);
			result = var;

		} else if (i < numPointArrays + numCellArrays + positionOffset) {
			VTKDataVariable var = ScriptableObject.CreateInstance<VTKDataVariable>();
			var.Init(this, VTKDataVariable.ArrayType.Cell,i - numPointArrays - positionOffset);
			result = var;
		} else return null;




		return result;
	}
	public void Print() {
		if(_dataset != null) {
			Debug.Log(_dataset.GetClassName());
			// VTK.vtkAbstractArray abstractArray = _dataset.GetPointData()
			VTK.vtkPointSet pointSet = null;
			if(_dataset.IsA("vtkPointSet"))
				pointSet = VTK.vtkPointSet.SafeDownCast(_dataset);
			
			if(pointSet != null)
				Debug.Log("<Position> " + pointSet.GetNumberOfPoints() );
			for(int i = 0; i < _dataset.GetPointData().GetNumberOfArrays(); i++) {
				Debug.Log(_dataset.GetPointData().GetArrayName(i) + _dataset.GetPointData().GetAbstractArray(i).GetNumberOfTuples());
			}
		}
	}
	public void SetDatasetPath(string path) {
		_datasetPath = path;
	}
	public void LoadDataset() {
		_dataset = DataLoader.LoadVTKDataSet(_datasetPath);
		populateVariables();
	}
	protected override bool validateVariable(DataVariable variable) {
		return base.validateVariable(variable) && (variable is VTKDataVariable || variable is VTKPositionDataVariable);
	} 


	public override void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!validateVariable(variable)) {
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
		if(!validateVariable(variable)) {
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
