using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class VTKDataset : Dataset {
	
	[SerializeField]
	string _datasetPath;

	VTK.vtkDataSet _dataset;


	protected VTK.vtkDataSet GetDataSet() {
		if(_dataset == null) LoadDataset();
		return _dataset;
	}
	[SerializeField]
	VTKAnchorDataVariable _anchorVariable;
	
	public override Variable GetAnchor() {
		return _anchorVariable;
	}

	public override void SetAnchor(Variable anchor) {
		if(anchor is VTKAnchorDataVariable)
		_anchorVariable = (VTKAnchorDataVariable)anchor;
	}
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
		return  GetDataSet().GetPointData().GetNumberOfArrays() + GetDataSet().GetCellData().GetNumberOfArrays() ;
	}
	
	protected override bool hasAnchor() {
		return (GetDataDimensionType() != DataDimensionType.Volume);
	}
	protected override AnchorVariable generateAnchor() {
		if(!hasAnchor()) return null;
		VTKAnchorDataVariable var = ScriptableObject.CreateInstance<VTKAnchorDataVariable>();
		var.Init(this);
		return var;
	}
	protected override DataVariable generateVarible(int i) {
		int numPointArrays = GetDataSet().GetPointData().GetNumberOfArrays();
		int numCellArrays = GetDataSet().GetCellData().GetNumberOfArrays();
		VTK.vtkAbstractArray abstractArray;

		int positionOffset = 0;
		DataVariable result = null;
		if(positionOffset == 1 &&  i == 0 ) {
			

		} else if(i < numPointArrays + positionOffset) {
			abstractArray = GetDataSet().GetPointData().GetAbstractArray(i-positionOffset);
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
				array = GetDataSet().GetCellData().GetAbstractArray(arrayID);
			} else {
				array = GetDataSet().GetPointData().GetAbstractArray(arrayID);
			}
			vtkchannel.Init(GetDataSet(), array);
			return vtkchannel;
		} else if(variable is VTKAnchorDataVariable) {
			VTKAnchorDatastreamChannel vtkchannel = CreateInstance<VTKAnchorDatastreamChannel>();

			vtkchannel.Init(GetDataSet());
			return vtkchannel;;
		} else {
			return null;
		}
	}
	public void Print() {
		if(GetDataSet() != null) {
			Debug.Log(GetDataSet().GetClassName());
			// VTK.vtkAbstractArray abstractArray = _dataset.GetPointData()
			VTK.vtkPointSet pointSet = null;
			if(GetDataSet().IsA("vtkPointSet"))
				pointSet = VTK.vtkPointSet.SafeDownCast(GetDataSet());
			
			if(pointSet != null)
				Debug.Log("<Position> " + pointSet.GetNumberOfPoints() );
			for(int i = 0; i < GetDataSet().GetPointData().GetNumberOfArrays(); i++) {
				Debug.Log(GetDataSet().GetPointData().GetArrayName(i) + GetDataSet().GetPointData().GetAbstractArray(i).GetNumberOfTuples());
			}
		}
	}
	public void SetDatasetPath(string path) {
		_datasetPath = path;
	}
	public override bool LoadDataset() {
		_dataset = DEPRECATED.DataLoader.LoadVTKDataSet(_datasetPath);
		if(!GetDataSet().IsVoid())
			populateVariables();
		return !GetDataSet().IsVoid();
	}
	protected override bool validateVariable(DataVariable variable) {
		return base.validateVariable(variable) && (variable is VTKDataVariable || variable is VTKAnchorDataVariable);
	} 


	public override void Bind(DataVariable variable, Material material, int bindSlot, int instanceID = 0, int timeStep = 0) {
		if(!validateVariable(variable)) {
			Debug.LogError("Variable is not a valid VTK variable for this VTK dataset.");
		}
	}

	public override bool IsPath() {
		return GetDataSet().IsA("vtkPolyData") &&  (VTK.vtkPolyData.SafeDownCast(GetDataSet()).GetNumberOfLines()) > 0;
	}

	public override bool IsMesh() {
		if(GetDataSet().IsA("vtkPolyData") && (VTK.vtkPolyData.SafeDownCast(GetDataSet())).GetNumberOfPolys() > 0) return true;
		else if(GetDataSet().IsA("vtkUnstructuredGrid")) return true;
		else return false;
	}

	public override bool IsVolume() {
		if(GetDataSet() == null) return false;
		return GetDataSet().IsA("vtkImageData"); // /* Perhaps verify the dimensionality of the image?*/ && VTK.vtkImageData.SafeDownCast(_dataset).GetDi; 
	}


	public override Vector3 GetMin(DataVariable variable) {
		Vector3 result = new Vector3();
		if(variable is VTKDataVariable)
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
		if(variable is VTKDataVariable && GetAbstractArray((VTKDataVariable)variable).IsA("vtkDataArray")) {
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
				VTK.vtkAbstractArray abstractArray = GetDataSet().GetCellData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return null;
				}
				return abstractArray;
			} 

			if(vtkVariable.IsPointVariable()) {
				VTK.vtkAbstractArray abstractArray = GetDataSet().GetPointData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return null;
				}
				return abstractArray;
			} 
		}
		return null;
	}
	public override string GetVariableName(DataVariable variable) {
		// if(variable.IsAnchor()) return "Anchor";
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
		} else if(variable is VTKAnchorDataVariable) {
			VTKAnchorDataVariable positionVariable = (VTKAnchorDataVariable)variable;
			return "Position";
		}
		
		return "";
	}

	public override int GetVariableComponents(DataVariable variable) {
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
		} else if(variable is VTKAnchorDataVariable) {
			VTKAnchorDataVariable positionVariable = (VTKAnchorDataVariable)variable;
			return 3;
		}
		
		return 0;
	}
	public override bool IsVector(DataVariable variable) {
		if(variable is VTKDataVariable) {
			VTKDataVariable vtkVariable = (VTKDataVariable)(variable);

			if(vtkVariable.IsCellVariable()) {
				VTK.vtkAbstractArray abstractArray = GetDataSet().GetCellData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return false;
				}
				return abstractArray.GetNumberOfComponents() > 1;
			} 

			if(vtkVariable.IsPointVariable()) {
				VTK.vtkAbstractArray abstractArray = GetDataSet().GetPointData().GetAbstractArray(vtkVariable.GetArrayID());
				if(abstractArray.IsVoid()) {
					return false;
				}
				return abstractArray.GetNumberOfComponents() > 1;
			} 
		} else if(variable is VTKAnchorDataVariable) {
			VTKAnchorDataVariable positionVariable = (VTKAnchorDataVariable)variable;
			return true;
		}  

		return false;
	}


	public override Bounds GetBounds() {
		if(GetDataSet() == null) return new Bounds();
		return GetDataSet().GetBounds();
	}
}
}
