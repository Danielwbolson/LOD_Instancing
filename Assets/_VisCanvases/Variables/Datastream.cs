using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;

namespace SculptingVis {
public class Datastream : ScriptableObject {
    [SerializeField]
    DatastreamChannel _rootChannel;

    [SerializeField]
    DataVariable _owner;

    DataVariable GetVariable() {
        return _owner;
    }
    public void Init(DataVariable owner, DatastreamChannel rootChannel) {
        _owner = owner;
        _rootChannel = rootChannel;

        if(_rootChannel is VTKPositionDatastreamChannel) {

        }
        if(_rootChannel.GetNumberOfComponents() > 1) {

        }
    }

    public int GetNumberOfElements() {
        return _rootChannel.GetNumberOfElements();
    }

    public int GetNumberOfComponents() {
        return _rootChannel.GetNumberOfComponents();
    }

    Mesh [] _meshes;

    public Mesh[] GetMeshes() {
        if(_meshes == null) {
            int numMeshes = 1;

            if(_rootChannel is VTKPositionDatastreamChannel)  {
                VTKPositionDatastreamChannel vc = (VTKPositionDatastreamChannel)_rootChannel;
                VTK.vtkDataSet ds = vc.GetVTKDataSet();
                
                if(_owner.GetVariableType() == DataDimensionType.Path) {
                    VTK.vtkPolyData pd = VTK.vtkPolyData.SafeDownCast(ds);
                    VTK.vtkCellArray ca = VTK.vtkPolyData.SafeDownCast(ds).GetLines();
                    int numcells = (int)ca.GetNumberOfCells();

                    List<Vector3> points = new List<Vector3>();
                    List<Vector2> tex = new List<Vector2>();
                    List<int> indices = new List<int>();
                    int index = 0;
                    _meshes = new Mesh[ pd.GetNumberOfLines()];


                    // pd.GetLines().InitTraversal();
                    VTK.vtkIdList idlist =VTK.vtkIdList.New();
                    // while(pd.GetLines().GetNextCell(idlist) != 0) {
                    //     Debug.Log("Line has" + idlist.GetNumberOfIds() + " points");
                    //     for(long i = 0; i < idlist.GetNumberOfIds(); i++) {
                    //         double [] p = new double[3];
                    //         pd.GetPoint(i,p);
                    //         points.Add(pd.GetPoints().GetPoint(i));
                    //         indices.Add(index++);
                    //     }
                    // }
                    // Debug.Log(index);
                    for(long c = 0; c < pd.GetNumberOfLines(); c++) {
 
                        pd.GetCellPoints(c,idlist);
                        

                        int idCount = (int)idlist.GetNumberOfIds();
                        for(int i = 0; i < idCount; i++) {
                            int id = (int)idlist.GetId(i);
                            double [] p = new double[3];
                            pd.GetPoint(id,p);
                            points.Add(pd.GetPoints().GetPoint(id));
                            //Debug.Log(c + " " + i + " " + id + " " + " " + index + " " + p[0] + "," + p[1] + "," + p[2]);
                            tex.Add(new Vector2(c,id));


                            indices.Add(index);
                            index++;
                            

                        }

                    Mesh m = new Mesh();
                    m.vertices = (points.ToArray());
                    m.uv = tex.ToArray();
                    m.SetIndices(indices.ToArray(),MeshTopology.LineStrip,0);

                    _meshes[c] = m;
                    points.Clear();
                    indices.Clear();
                    tex.Clear();
                    index = 0;

                    }

                    // for(int i = 0; i < pd.GetNumberOfPoints(); i++) {
                    //         double [] p = new double[3];
                    //         pd.GetPoint(i,p);
                    //         Debug.Log(i + " " + p[0] + "," + p[1] + "," + p[2]);

                    // }
                 
                    Debug.Log(indices.Count);
                }
                
            }
        
        }
        return _meshes;
    }

    Texture3D _3DTexture;


   public Vector3 GetImageDataDimensions(VTK.vtkDataSet dataset) {
            int[] imageDim = new int[3];
            if (dataset.IsA("vtkImageData"))
            {
                VTK.vtkImageData imageData = VTK.vtkImageData.SafeDownCast(dataset);

                imageData.GetDimensions(imageDim);

                int w = (int)imageDim[0];
                int h = (int)imageDim[1];
                int d = (int)imageDim[2];
                return new Vector3(w, h, d);
            }
            return new Vector3(0,0,0);
        }


    ComputeBuffer _computeBuffer;
    public ComputeBuffer GetComputeBuffer() {
        if(_computeBuffer == null) {
            if(_rootChannel is VTKDatastreamChannel) {
                VTK.vtkAbstractArray abstractArray  = ((VTKDatastreamChannel)_rootChannel).GetAbstractArray();

                long numberOfElements = abstractArray.GetNumberOfTuples();
                long numberOfComponents = abstractArray.GetNumberOfComponents();


                float[] data = new float[numberOfElements*numberOfComponents];
                if( abstractArray.IsA("vtkFloatArray")){
                    Marshal.Copy(abstractArray.GetVoidPointer(0), data, 0, (int)data.Length);

                } else if(abstractArray.IsA("vtkDoubleArray")){
                    double[] doubleData = new double[numberOfComponents*numberOfElements];

                    Marshal.Copy(abstractArray.GetVoidPointer(0), doubleData, 0, (int)doubleData.Length);
                    for(int i = 0; i < doubleData.Length;i++)
                        data[i] = (float)doubleData[i];
                } else if(abstractArray.IsA("vtkIntArray")) {
                    int[] intData = new int[numberOfComponents*numberOfElements];
                    Marshal.Copy(abstractArray.GetVoidPointer(0), intData, 0, (int)intData.Length);

                    for(int i = 0; i < intData.Length;i++)
                        data[i] = (float)intData[i];   
                }
                for(int i = 0; i < data.Length; i++)
                    Debug.Log(data[i]);

                _computeBuffer = new ComputeBuffer((int)numberOfElements,(int)numberOfComponents*sizeof(float));

                _computeBuffer.SetData(data);

            }
        }

        return _computeBuffer;
    }
    public Texture3D Get3DTexture() {
        if(_3DTexture == null) {

            if(_rootChannel is VTKDatastreamChannel)
            {
                VTK.vtkAbstractArray abstractArray  = ((VTKDatastreamChannel)_rootChannel).GetAbstractArray();

                long numberOfElements = abstractArray.GetNumberOfTuples();
                long numberOfComponents = abstractArray.GetNumberOfComponents();


                float[] data = new float[numberOfElements*numberOfComponents];
                Marshal.Copy(abstractArray.GetVoidPointer(0), data, 0, (int)data.Length);

                Vector3 d = GetImageDataDimensions(((VTKDatastreamChannel)_rootChannel).GetDataset());
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

                _3DTexture = new Texture3D((int)d.x,(int)d.y,(int)d.z, format, false);
                _3DTexture.SetPixels(colorData);
                _3DTexture.Apply();
            }
           
        }

        return _3DTexture;
    }

    public void Bind(Material material, int bindSlot) {
        int dim = GetVariable().GetDomainDimensionality();
        material.SetInt("_VariableDomainDimensionality_" + bindSlot,dim);
        material.SetMatrix("_VariableBoundsMatrixInv_" + bindSlot,Matrix4x4.TRS(GetVariable().GetBounds().center,Quaternion.identity,GetVariable().GetBounds().size).inverse);
        material.SetVector("_VariableMin_" + bindSlot, GetVariable().GetMin());
        material.SetVector("_VariableMax_" + bindSlot, GetVariable().GetMax());
        material.SetFloat("_VariableComponents_" + bindSlot,GetNumberOfComponents());
        Debug.Log(GetVariable().GetMin());
        Debug.Log(GetVariable().GetMax());
        switch(dim) {
            case 3: 
                material.SetTexture("_Variable3DTexture_" + bindSlot,Get3DTexture());
                break;
            case 1:
                material.SetInt("_VariableArrayType_" + bindSlot,GetVariable().IsPointVariable()?1:0);
                material.SetBuffer("_VariableDataBuffer_" + bindSlot,GetComputeBuffer());
                break;
        }
         
        
    }
}

}
