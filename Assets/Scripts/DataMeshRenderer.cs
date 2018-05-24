using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using System.Runtime.InteropServices;

using VTK;


public class DataMeshRenderer : DataRenderer {

    public Material dataMaterial;
    public vtkDataSet dataSet = IntPtr.Zero;
    public int arrayId = 0; 
    public GameObject dataMeshPreFab;

    [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
    public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);
    public int[] triangleIndices;


        // Use this for initialization
    void Start()
    {
    }
    public void RefreshDataRenderer() {

        if (dataSet.IsVoid())
        {
            print("SNAP");
            return;
        }

        //for (int i = 0; i < dataSet.GetPointData().GetNumberOfArrays(); i++)
        //{
        //    print(i + ": " + dataSet.GetPointData().GetArrayName(i));
        //}

        vtkPointData pointData = dataSet.GetPointData();

        ComputeBuffer dataBuffer = null;
        if (pointData.GetNumberOfArrays() > arrayId)
        {

            vtkDataArray dataArray = pointData.GetArray(arrayId);
            long numberOfTuples = dataArray.GetNumberOfTuples();
            float[] data = new float[numberOfTuples];
            Marshal.Copy(dataArray.GetVoidPointer(0), data, 0, (Int32)data.Length);
            dataBuffer = new ComputeBuffer((int)data.Length, sizeof(float));
            dataBuffer.SetData(data);
        }







        if (true && dataSet.IsA("vtkPointSet"))
        {

            vtkPointSet pointSet = vtkPointSet.SafeDownCast(dataSet);

            // Get list of Vector3's
            Vector3[] points = new Vector3[dataSet.GetNumberOfPoints()];
            IntPtr voidPointer = pointSet.GetPoints().GetVoidPointer(0);

            GCHandle handleVs = GCHandle.Alloc(points, GCHandleType.Pinned);
            IntPtr pV = handleVs.AddrOfPinnedObject();
            CopyMemory(pV, voidPointer, (UInt32)(dataSet.GetNumberOfPoints() * 3 * 4));
            handleVs.Free();


            // Get list of triangle indices
            List<int> indexList = new List<int>();
            vtkIdList list = vtkIdList.New();
            vtkPoints p = vtkPoints.New();


            DateTime before = DateTime.Now;

            for (int i = 0; i < dataSet.GetNumberOfCells(); i++)
            {
                vtkCell cell = dataSet.GetCell(i);
                int dimensions = cell.GetCellDimension();

                if (dimensions == 2)
                {
                    cell.Triangulate(0, list, p);
                    IntPtr lPtr = list.GetPointer(0);
                    long numberOfIDs = list.GetNumberOfIds();
                    long[] ids = new long[numberOfIDs];
                    Marshal.Copy(lPtr, ids, 0, (Int32)numberOfIDs);
                    for (int j = 0; j < numberOfIDs; j++)
                    {
                        indexList.Add((int)ids[j]);
                    }
                }
            }

            DateTime after = DateTime.Now;
            TimeSpan duration = after.Subtract(before);
            Debug.Log("Duration of triangulation in seconds: " + duration.Seconds);

            triangleIndices = indexList.ToArray();


            int indicesLeft = triangleIndices.Length;
            int indicesLoaded = 0;

            int maxMeshes = 20;
            DateTime before2 = DateTime.Now;
            foreach (Transform child in transform)
            {

                GameObject.Destroy(child.gameObject);
            }

            while (indicesLeft > indicesLoaded && maxMeshes > 0)
            {
                maxMeshes--;
                GameObject dataMesh = Instantiate(dataMeshPreFab);
                dataMesh.transform.SetParent(this.transform, false);
                Mesh mesh = new Mesh();
                dataMesh.GetComponent<MeshFilter>().mesh = mesh;
                dataMesh.GetComponent<MeshRenderer>().material = dataMaterial;
                int indicesToLoad = Math.Min(60000, indicesLeft - indicesLoaded);
                Vector3[] vertices = new Vector3[indicesToLoad];

                for (int i = 0; i < indicesToLoad; i++)
                {
                    vertices[i] = points[triangleIndices[indicesLoaded + i]];
                }
                mesh.vertices = vertices;

                mesh.triangles = Enumerable.Range(0, indicesToLoad).ToArray();

                ComputeBuffer indexBuffer = new ComputeBuffer(indicesToLoad, sizeof(int));
                indexBuffer.SetData(triangleIndices.SubArray(indicesLoaded, indicesToLoad));

                dataMesh.GetComponent<MeshRenderer>().material.SetBuffer("_index", indexBuffer);
                dataMesh.GetComponent<MeshRenderer>().material.SetBuffer("_data", dataBuffer);

                mesh.RecalculateNormals();

                indicesLoaded += indicesToLoad;
            }
            DateTime after2 = DateTime.Now;
            TimeSpan duration2 = after2.Subtract(before2);
            Debug.Log("Duration of Prefabrication in seconds: " + duration2.Seconds);
        }
    }
    public void SetDataSet(vtkDataSet dataset) {
        dataSet = dataset;
        print("Set to render a " + dataSet);
        print(dataSet.GetClassName());
        print("Loaded a " + dataSet.GetClassName() + " with " + dataSet.GetNumberOfPoints().ToString() + " points and " + dataSet.GetNumberOfCells().ToString() + " cells.");

	}

}
