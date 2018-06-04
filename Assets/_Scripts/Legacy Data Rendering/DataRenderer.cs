using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using System.Runtime.InteropServices;

using VTK;

public static class Extension
{
    public static T[] SubArray<T>(this T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }
}


public class DataRenderer : MonoBehaviour {

    public vtkDataSet dataSet = IntPtr.Zero;

    [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
    public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);
    public int[] triangleIndices;


        // Use this for initialization
    void Start()
    {
    }
    virtual public void RefreshDataRenderer() {
        
    }
    public void SetDataSet(vtkDataSet dataset) {
        dataSet = dataset;
        print("Set to render a " + dataSet);
        print(dataSet.GetClassName());
        print("Loaded a " + dataSet.GetClassName() + " with " + dataSet.GetNumberOfPoints().ToString() + " points and " + dataSet.GetNumberOfCells().ToString() + " cells.");

	}

}
