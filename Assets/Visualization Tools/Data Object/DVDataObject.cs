using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Runtime.InteropServices;

using VTK;

namespace DV
{
    public class DVDataObject : MonoBehaviour
    {
        protected vtkDataSet _dataSet;
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
            _dataSet = dataSet;
            _bounds = GetDataSet().GetBounds();
            _boundMatrix = new Matrix4x4();
            _boundMatrix.SetTRS(GetBounds().center, Quaternion.identity, GetBounds().size);

        }
        public vtkDataSet GetDataSet()
        {
            return _dataSet;
        }
        private vtkDataArray GetPointArray(int pointArray) {
            return _dataSet.GetPointData().GetArray(pointArray);
        }
        public int GetNumberOfPointArrays() {
            return _dataSet.GetPointData().GetNumberOfArrays();
        }
        public double [] GetRangeOfPointArrays(int pointArray, int component) {
            double [] range = new double[2];
            _dataSet.GetPointData().GetArray(pointArray).GetRange(range,component);
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
            if (_dataSet.IsA("vtkImageData"))
            {
                vtkImageData imageData = vtkImageData.SafeDownCast(_dataSet);

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

                if (_dataSet.IsA("vtkImageData"))
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



            if (_dataSet != null)
            {
                if (_dataSet.IsA("vtkDataSet"))
                {
                    vtkDataSet dataSet = vtkDataSet.SafeDownCast(_dataSet);
                    Bounds b = dataSet.GetBounds();
                    //b.size = new Vector3(300, 145, 145);

                    Gizmos.matrix = transform.localToWorldMatrix;
                    Gizmos.DrawWireCube(b.center, b.size);

                }

            }
        }
    }
}