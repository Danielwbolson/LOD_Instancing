using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System.Runtime.InteropServices;
using System;

public class VertikalDataSliceRenderer: MonoBehaviour {


    public VertikalDataObject _dataObject = null;

    private VertikalDataObject _cachedDataObject = null;

    public int arrayId = 0;
    private int _cachedArrayId = 0;
    Bounds bounds;

    private Vector3Int GetImageDimensions(vtkImageData imageData)
    {
        int[] imageDim = new int[3];
        imageData.GetDimensions(imageDim);

        int w = (int)imageDim[0];
        int h = (int)imageDim[1];
        int d = (int)imageDim[2];

        return new Vector3Int(w, h, d);
    }
	// Use this for initialization
	void Start () {
		
	}

    private Texture3D _volumeBuffer;


    void RefreshDataSet()
    {
        print("Slice Renderer pointed to a " + _dataObject.GetDataSet().GetClassName() + " with " + _dataObject.GetDataSet().GetNumberOfPoints().ToString() + " points and " + _dataObject.GetDataSet().GetNumberOfCells().ToString() + " cells.");
        vtkDataSet dataSet = _dataObject.GetDataSet();

        vtkPointData pointData = dataSet.GetPointData();
        bounds = dataSet.GetBounds();
        //bounds.size = new Vector3(300, 145, 145);

        ComputeBuffer dataBuffer = null;
        if (pointData.GetNumberOfArrays() > arrayId)
        {

            vtkDataArray dataArray = pointData.GetArray(arrayId);
            long numberOfTuples = dataArray.GetNumberOfTuples();

            if (dataArray.GetNumberOfComponents() > 1)
            {
                print("Can't handle vectors... yet");
                return;
            }


            vtkImageData imageData = vtkImageData.SafeDownCast(dataSet);

            int[] imageDim = new int[3];
            imageData.GetDimensions(imageDim);

            int w = (int)imageDim[0];
            int h = (int)imageDim[1];
            int d = (int)imageDim[2];
            //transform.localPosition += bounds.center;
            //transform.localScale = bounds.size; ;//(bounds.extents.x, bounds.extents.y, bounds.extents.z);

            float[] data = new float[w * h * d];
            Color[] colorData = new Color[w * h * d];




            Marshal.Copy(dataArray.GetVoidPointer(0), data, 0, (Int32)data.Length);
            dataBuffer = new ComputeBuffer((int)data.Length, sizeof(float));
            dataBuffer.SetData(data);

            print("Filling a texture of size " + w + "x" + h + "x" + d);


            for (int i = 0; i < numberOfTuples; i++)
            {
                colorData[i].r = data[i];
                colorData[i].g = 1;
                colorData[i].b = 1;
                colorData[i].a = 1;

            }



            _volumeBuffer = new Texture3D((int)(w), (int)(h), (int)(d), TextureFormat.RFloat, false);
            _volumeBuffer.SetPixels(colorData);
            _volumeBuffer.Apply();
        }
        GetComponent<MeshRenderer>().material.SetTexture("_DataVolume", _volumeBuffer);
        _cachedDataObject = _dataObject;
        _cachedArrayId = arrayId;

    }
	// Update is called once per frame
	void Update () {

        if (!_dataObject)
            return;
        if (_cachedDataObject != _dataObject)
        {
            RefreshDataSet();
        }

        if (_cachedArrayId != arrayId)
        {
            RefreshDataSet();
        }

        Bounds bounds = _dataObject.GetDataSet().GetBounds();

        //Transform parent = Transform.Instantiate(_dataObject.transform);
        //Transform mat = Transform.Instantiate(parent);


        //mat.SetParent(parent);
        //mat.localPosition = bounds.center;
        //mat.localScale = bounds.size; ;//(bounds.extents.x, bounds.extents.y, bounds.extents.z);
        Matrix4x4 dataMatrix = new Matrix4x4();
        dataMatrix.SetTRS(bounds.center, Quaternion.identity, bounds.size);
        GetComponent<MeshRenderer>().material.SetMatrix("_ModelMatrix", _dataObject.transform.localToWorldMatrix);

        GetComponent<MeshRenderer>().material.SetMatrix("_ModelMatrixInv", _dataObject.transform.worldToLocalMatrix);
       
        GetComponent<MeshRenderer>().material.SetMatrix("_DataMatrix", dataMatrix);

        GetComponent<MeshRenderer>().material.SetMatrix("_DataMatrixInv", dataMatrix.inverse);
       
        if (_dataObject.GetDataSet().IsA("vtkImageData"))

        {
            Vector3Int d = GetImageDimensions(vtkImageData.SafeDownCast(_dataObject.GetDataSet()));
            GetComponent<MeshRenderer>().material.SetVector("_Dimensions",new Vector3(d.x,d.y,d.z));

        }

    }
}
