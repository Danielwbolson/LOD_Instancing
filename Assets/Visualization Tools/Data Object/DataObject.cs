using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using VTK;
using System.Runtime.InteropServices;
using System;


public class Variable : ScriptableObject {
	public Variable(DataObject dataObject) {
		_dataObject = dataObject;	
	}
	
	public enum VariableType {
		ERROR,
		POINT,
		CELL
	};
	DataObject _dataObject;
	int _arrayID;
	string _arrayName;
	VariableType _variableType;
	vtkAbstractArray _abstractArray;

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

    Vector4 _min;
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


public class VariableList {
    List<Variable> _variables;
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

[ExecuteInEditMode]
public class DataObject : MonoBehaviour {
    [SerializeField]
    Database _database;
    DataLoader _dataLoader;
    GameObject _dataObjectPrefab;
    [SerializeField]
    string _filePathOfOrigin;

    VariableList _variableList;

    public VariableList GetVariableList() {
        if(_variableList == null) _variableList = new VariableList(this);
        return _variableList;
    }

    bool isValid = false;
    public string GetFilePath() {
        return _filePathOfOrigin;
    }
    public void SetFilePath(string filePath) {
        _filePathOfOrigin = filePath;
    }
    public Database GetDataBase() {
        return _database;
    }
    public void SetDataBase(Database database) {
        _database = database;
    }


    public void Destroy() {
        if(Application.isEditor) 
            DestroyImmediate(this.gameObject);
        else
            Destroy(this.gameObject);
    }
    void OnDestroy() {
        if(_database != null) {
            Database db = _database;
            _database = null;
            db.RemoveDataObject(this);

        }
    }





    // Will maybe want to replace this with a strategy

        [SerializeField]
        vtkDataSet _dataSet;
        protected Bounds _bounds;
        protected Matrix4x4 _boundMatrix;
        public Matrix4x4 GetBoundsMatrix() {
            return _boundMatrix;
        }
        public Bounds GetBounds()
        {
            if (_bounds == null) _bounds = GetDataSet().GetBounds();
            return _bounds;
        }
        public void SetDataSet(vtkDataSet dataSet)
        {
            if(dataSet == null || dataSet.IsVoid()) {
                isValid = false;
                return;
            }
            else
                isValid = true;
            _dataSet = dataSet;
            _bounds = GetDataSet().GetBounds();
            _boundMatrix = new Matrix4x4();
            _boundMatrix.SetTRS(GetBounds().center, Quaternion.identity, GetBounds().size);

        }
        public void SetDataLoader(DataLoader dataLoader) {
            _dataLoader = dataLoader;
        }
        public vtkDataSet GetDataSet()
        {
            if(_dataSet == null ||  _dataSet.IsVoid())
                SetDataSet(DataLoader.LoadVTKDataSet(_filePathOfOrigin));
            return _dataSet;
        }
        private vtkDataArray GetPointArray(int pointArray) {
            return GetDataSet().GetPointData().GetArray(pointArray);
        }
        public int GetNumberOfPointArrays() {
            return GetDataSet().GetPointData().GetNumberOfArrays();
        }
        public double [] GetRangeOfPointArrays(int pointArray, int component) {
            double [] range = new double[2];
            GetDataSet().GetPointData().GetArray(pointArray).GetRange(range,component);
            return range;
        }
        public float[] GetPointArrayData(int pointArray) {
            vtkDataArray array = GetPointArray(pointArray);
            long numberOfElements = array.GetNumberOfTuples();
            long numberOfComponents = array.GetNumberOfComponents();

            float[] data = new float[numberOfElements*numberOfComponents];
            Marshal.Copy(array.GetVoidPointer(0), data, 0, (int)data.Length);

            return data;

        }
        private Dictionary<int, Texture3D> imageDataTextures;

        public Vector3 GetImageDataDimensions() {
            int[] imageDim = new int[3];
            if (GetDataSet().IsA("vtkImageData"))
            {
                vtkImageData imageData = vtkImageData.SafeDownCast(GetDataSet());

                imageData.GetDimensions(imageDim);

                int w = (int)imageDim[0];
                int h = (int)imageDim[1];
                int d = (int)imageDim[2];
                return new Vector3(w, h, d);
            }
            return new Vector3(0,0,0);
        }
        public Texture3D GetImageDataTexture(int pointArray) {
            if (imageDataTextures == null)
                imageDataTextures = new Dictionary<int, Texture3D>();
            Texture3D result = null;

            if (!imageDataTextures.ContainsKey(pointArray))
            {

                if (GetDataSet().IsA("vtkImageData"))
                {
                    vtkDataArray array = GetPointArray(pointArray);
                    long numberOfElements = array.GetNumberOfTuples();
                    long numberOfComponents = array.GetNumberOfComponents();


                    float[] data = GetPointArrayData(pointArray);
                    Vector3 d = GetImageDataDimensions();
                    Color[] colorData = new Color[(int)(d.x*d.y*d.z)];

                    for (int c = 0; c < numberOfComponents; c++)
                    {
                        for (int i = 0; i < numberOfElements; i++)
                            colorData[i][c] = data[i * numberOfComponents + c];
                    }

                    TextureFormat format;
                    if (numberOfComponents == 1)
                        format = TextureFormat.RFloat;
                    else if (numberOfComponents == 2)
                        format = TextureFormat.RGFloat;
                    else if (numberOfComponents == 3)
                        format = TextureFormat.RGBAFloat;
                    else
                        format = TextureFormat.RGBAFloat;

                    result = new Texture3D((int)d.x,(int)d.y,(int)d.z, format, false);
                    result.SetPixels(colorData);
                    result.Apply();

                    imageDataTextures[pointArray] = result;
                }
            }
            result = imageDataTextures[pointArray];
         
            return result;
        }
        public void OnDrawGizmos()
        {



            if (GetDataSet() != null)
            {
                if (GetDataSet().IsA("vtkDataSet"))
                {
                    vtkDataSet dataSet = vtkDataSet.SafeDownCast(GetDataSet());
                    Bounds b = dataSet.GetBounds();
                    //b.size = new Vector3(300, 145, 145);

                    Gizmos.matrix = transform.localToWorldMatrix;
                    Gizmos.DrawWireCube(b.center, b.size);

                } 

            } else {

                    Gizmos.matrix = transform.localToWorldMatrix;
                    Gizmos.color = Color.red;
                    Gizmos.DrawWireCube(new Vector3(0,0,0), new Vector3(1,1,1));
                }
        }





   
}