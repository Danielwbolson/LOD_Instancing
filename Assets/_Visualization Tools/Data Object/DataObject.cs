using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using VTK;
using System.Runtime.InteropServices;
using System;

namespace DEPRECATED{




[ExecuteInEditMode]
public class DataObject : MonoBehaviour {
    [SerializeField]
    Database _database;
    [SerializeField]
    DataLoader _dataLoader;
    [SerializeField]
    string _filePathOfOrigin;
    [SerializeField]
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
    [SerializeField, HideInInspector]
        protected Bounds _bounds;
    [SerializeField, HideInInspector]
        protected Matrix4x4 _boundMatrix;
        public Matrix4x4 GetBoundsMatrix() {
            _boundMatrix = new Matrix4x4();
            _boundMatrix.SetTRS(GetBounds().center, Quaternion.identity, GetBounds().size);
            _boundMatrix = transform.localToWorldMatrix*_boundMatrix;
            
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
    [SerializeField, HideInInspector]
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
}