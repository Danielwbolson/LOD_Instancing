using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using System.Runtime.InteropServices;

using VTK;


public class DataSliceRenderer : DataRenderer {

    public int arrayId = 0;
    public Material sliceMaterial;
    [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
    public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);


    private Texture3D _volumeBuffer;


        // Use this for initialization
    void Start()
    {
    }
    public override void RefreshDataRenderer() {

        if (dataSet.IsVoid())
        {
            return;
        }

        //for (int i = 0; i < dataSet.GetPointData().GetNumberOfArrays(); i++)
        //{
        //    print(i + ": " + dataSet.GetPointData().GetArrayName(i));
        //}

        vtkPointData pointData = dataSet.GetPointData();
        Bounds bounds = dataSet.GetBounds();
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
            transform.localPosition = bounds.center;
            transform.localScale = bounds.size;;//(bounds.extents.x, bounds.extents.y, bounds.extents.z);

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



            _volumeBuffer = new Texture3D((int)(w),  (int)(h), (int)(d),TextureFormat.RFloat, false);
            _volumeBuffer.SetPixels(colorData);
            _volumeBuffer.Apply();

            sliceMaterial.SetVector("_Dimensions", new Vector3(w,h,d));
            sliceMaterial.SetTexture("_DataVolume", _volumeBuffer);

            transform.GetChild(0).GetComponent<MeshRenderer>().material = sliceMaterial;



        }



        return;





       
    }
	public void Update()
	{
        sliceMaterial.SetMatrix("_ModelMatrix", transform.localToWorldMatrix);
        sliceMaterial.SetMatrix("_ModelMatrixInv", transform.worldToLocalMatrix);
        transform.GetChild(0).GetComponent<MeshRenderer>().material = sliceMaterial;

	}
	public void SetDataSet(vtkDataSet dataset) {
        this.dataSet = dataset;
        print("Set to render a " + dataSet);
        print(dataSet.GetClassName());
        print("Loaded a " + dataSet.GetClassName() + " with " + dataSet.GetNumberOfPoints().ToString() + " points and " + dataSet.GetNumberOfCells().ToString() + " cells.");

	}

}
