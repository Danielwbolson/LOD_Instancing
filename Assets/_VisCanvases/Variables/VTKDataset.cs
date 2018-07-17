using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class VTKDataset : Dataset {
	
	[SerializeField]
	string _datasetPath;

	VTK.vtkDataSet _dataset;

	[SerializeField]
	VTKPositionDataVariable _anchorVariable;
	
	[SerializeField]
	int _instanceID = 0;

	[SerializeField]
	int _timestep = 0;

	public void Init(string path, int instanceID, int timestep) {
		this.SetDatasetPath(path);
		_instanceID = instanceID;
		_timestep = timestep;
	}
	protected override Datastream lookupDataStream(DataVariable variable, DataVariable anchor, int instanceID = 0, int timeStep = 0) {
        //if (validateVariable(variable)) {
        //    if (anchor == null && GetDataDimensionType() == DataDimensionType.Volume)
        //    {
                
        //    }
        //}


		return null;
	}

	public override bool ContainsInstanceID(int instanceID) {
		return instanceID == _instanceID;
	}
	public override bool ContainsTimestep(int timestep) {
		return timestep == _timestep;
	}

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
			abstractArray = _dataset.GetPointData().GetAbstractArray(i-positionOffset);
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

	protected override DatastreamChannel generateDatastreamChannel(DataVariable variable) {
		if(variable is VTKDataVariable) {
			VTKDatastreamChannel vtkchannel = CreateInstance<VTKDatastreamChannel>();
			int arrayID = ((VTKDataVariable)variable).GetArrayID();
			VTK.vtkAbstractArray array;
			if(((VTKDataVariable)variable).IsCellVariable()) {
				array = _dataset.GetCellData().GetAbstractArray(arrayID);
			} else {
				array = _dataset.GetPointData().GetAbstractArray(arrayID);
			}
			vtkchannel.Init(_dataset, array);
			return vtkchannel;
		} else if(variable is VTKPositionDataVariable) {
			VTKPositionDatastreamChannel vtkchannel = CreateInstance<VTKPositionDatastreamChannel>();

			vtkchannel.Init(_dataset);
			return vtkchannel;;
		} else {
			return null;
		}
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
	public override void LoadDataset() {
		_dataset = DEPRECATED.DataLoader.LoadVTKDataSet(_datasetPath);
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
		return _dataset.IsA("vtkPolyData") &&  (VTK.vtkPolyData.SafeDownCast(_dataset).GetNumberOfLines()) > 0;
	}

	public override bool IsMesh() {
		if(_dataset.IsA("vtkPolyData") && (VTK.vtkPolyData.SafeDownCast(_dataset)).GetNumberOfPolys() > 0) return true;
		else if(_dataset.IsA("vtkUnstructuredGrid")) return true;
		else return false;
	}

	public override bool IsVolume() {
		if(_dataset == null) return false;
		return _dataset.IsA("vtkImageData"); // /* Perhaps verify the dimensionality of the image?*/ && VTK.vtkImageData.SafeDownCast(_dataset).GetDi; 
	}


	public override Vector3 GetMin(DataVariable variable) {
		Vector3 result = new Vector3();
		if(GetAbstractArray((VTKDataVariable)variable).IsA("vtkDataArray")) {
			VTK.vtkDataArray da = VTK.vtkDataArray.SafeDownCast(GetAbstractArray((VTKDataVariable)variable));
			double[] r = new double[2];
			da.GetRange(r,0);
			result.x = (float)r[0];
			da.GetRange(r,1);
			result.y = (float)r[0];
			da.GetRange(r,2);
			result.z = (float)r[0];
		}

		return result;
	}

	public override Vector3 GetMax(DataVariable variable) {
		Vector3 result = new Vector3();
		if(GetAbstractArray((VTKDataVariable)variable).IsA("vtkDataArray")) {
			VTK.vtkDataArray da = VTK.vtkDataArray.SafeDownCast(GetAbstractArray((VTKDataVariable)variable));
			double[] r = new double[2];
			da.GetRange(r,0);
			result.x = (float)r[1];
			da.GetRange(r,1);
			result.y = (float)r[1];
			da.GetRange(r,2);
			result.z = (float)r[1];
		}

		return result;
	}
	VTK.vtkAbstractArray GetAbstractArray(VTKDataVariable variable ) {
		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);

			if(vtkVariable.IsCellVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetCellData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return null;
				}
				return abstractArray;
			} 

			if(vtkVariable.IsPointVariable()) {
				VTK.vtkAbstractArray abstractArray = _dataset.GetPointData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return null;
				}
				return abstractArray;
			} 
		}
		return null;
	}
	public override string GetVariableName(DataVariable variable) {
		if(!validateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
			return "ERROR";
		}

		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);
			
			VTK.vtkAbstractArray abstractArray = GetAbstractArray(vtkVariable);
			if(abstractArray == null) {
				return "";
			} else {
				return abstractArray.GetName();
			}
		} else if(variable is VTKPositionDataVariable) {
			VTKPositionDataVariable positionVariable = (VTKPositionDataVariable)variable;
			return "Position";
		}
		
		return "";
	}

	public override int GetVariableDimensions(DataVariable variable) {
			if(!validateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
			return -1;
		}

		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);
			
			VTK.vtkAbstractArray abstractArray = GetAbstractArray(vtkVariable);
			if(abstractArray != null) {
				return abstractArray.GetNumberOfComponents();
			}
		} else if(variable is VTKPositionDataVariable) {
			VTKPositionDataVariable positionVariable = (VTKPositionDataVariable)variable;
			return 3;
		}
		
		return 0;
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


	public override Bounds GetBounds() {
		if(_dataset == null) new Bounds();
		return _dataset.GetBounds();
	}
}
}
