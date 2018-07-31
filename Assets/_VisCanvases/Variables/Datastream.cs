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

        if(_rootChannel is VTKAnchorDatastreamChannel) {

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

    Vector2Int [] _topologyArray;
    Vector2Int [] _topologyCellInfoArray;

    public Vector2Int [] GetTopologyCellInfoArray() {
        if(_topologyCellInfoArray == null) {
             if(_rootChannel is VTKAnchorDatastreamChannel)  {
                VTKAnchorDatastreamChannel vc = (VTKAnchorDatastreamChannel)_rootChannel;
                VTK.vtkDataSet ds = vc.GetVTKDataSet();
                
                if(_owner.GetVariableType() != DataDimensionType.Volume) {
                    VTK.vtkPolyData pd = VTK.vtkPolyData.SafeDownCast(ds);
                    VTK.vtkCellArray ca = VTK.vtkPolyData.SafeDownCast(ds).GetLines();
                    int numcells = (int)ca.GetNumberOfCells();

                    List<Vector2Int> topologyCellInfo = new List<Vector2Int>();
                    

                    VTK.vtkIdList idlist =VTK.vtkIdList.New();
                    int index = 0;
                    for(int c = 0; c < numcells; c++) {
                        pd.GetCellPoints(c,idlist);
                        int idCount = (int)idlist.GetNumberOfIds();
                        int INITIAL_INDEX = index;
                        index += idCount;
                        int FINAL_INDEX = index;
                        topologyCellInfo.Add(new Vector2Int(INITIAL_INDEX,FINAL_INDEX));

                    }

                _topologyCellInfoArray = topologyCellInfo.ToArray();
                }
                
            } else if(_rootChannel is PointAnchorDatastreamChannel) {
                List<Vector2Int> topologyCellInfo = new List<Vector2Int>();
                topologyCellInfo.Add(new Vector2Int(0,((PointAnchorDatastreamChannel)_rootChannel)._points.Count));
                _topologyCellInfoArray = topologyCellInfo.ToArray();

            }


        }
        return _topologyCellInfoArray;
    }
    public Vector2Int [] GetTopologyArray() {
        if(_topologyArray==null) {
            if(_rootChannel is VTKAnchorDatastreamChannel)  {
                VTKAnchorDatastreamChannel vc = (VTKAnchorDatastreamChannel)_rootChannel;
                VTK.vtkDataSet ds = vc.GetVTKDataSet();
                
                if(_owner.GetVariableType() != DataDimensionType.Volume) {
                    VTK.vtkPolyData pd = VTK.vtkPolyData.SafeDownCast(ds);
                    VTK.vtkCellArray ca = VTK.vtkPolyData.SafeDownCast(ds).GetLines();
                    int numcells = (int)ca.GetNumberOfCells();

                    List<Vector2Int> topology = new List<Vector2Int>();
                    

                    VTK.vtkIdList idlist =VTK.vtkIdList.New();
                    double [] p = new double[3];
                    for(int c = 0; c < numcells; c++) {
                        pd.GetCellPoints(c,idlist);
                    
                        int idCount = (int)idlist.GetNumberOfIds();
                        for(int i = 0; i < idCount; i++) {
                            int id = (int)idlist.GetId(i);
                            topology.Add(new Vector2Int((int)c,id));
                        }
                    }

                _topologyArray = topology.ToArray();
                }
                
            } else if(_rootChannel is PointAnchorDatastreamChannel) {
                
                List<Vector2Int> topology = new List<Vector2Int>();

                for(int i = 0; i < ((PointAnchorDatastreamChannel)_rootChannel)._points.Count;i++){
                    topology.Add(new Vector2Int(0,i));        
                }
                _topologyArray = topology.ToArray();
                
            }


        }

        return _topologyArray;
    }

    public Mesh[] GetMeshes() {
        if(_meshes == null) {
            int numMeshes = 1;

            if(_rootChannel is VTKAnchorDatastreamChannel)  {
                VTKAnchorDatastreamChannel vc = (VTKAnchorDatastreamChannel)_rootChannel;
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
                    for(long c = 0; c < pd.GetNumberOfCells(); c++) {
 
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


    ComputeBuffer _dataBuffer;
    ComputeBuffer _topologyBuffer;

    public ComputeBuffer GetComputeBuffer() {
        if(_dataBuffer == null) {

            long numberOfElements = GetNumberOfElements();
            long numberOfComponents = GetNumberOfComponents();
            float[] data = new float[numberOfElements*numberOfComponents];

            if(_rootChannel is VTKDatastreamChannel) {

                VTK.vtkAbstractArray abstractArray  = ((VTKDatastreamChannel)_rootChannel).GetAbstractArray();

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
                
                
                Debug.Log("Uploading Buffer of length " + (int)numberOfElements*(int)numberOfComponents + " (" + data.Length + ")");



                _dataBuffer = new ComputeBuffer((int)numberOfElements*(int)numberOfComponents,sizeof(float));

                _dataBuffer.SetData(data);

            } else if(_rootChannel is VTKAnchorDatastreamChannel) {
              

                VTK.vtkDataSet ds = ((VTKAnchorDatastreamChannel)_rootChannel).GetVTKDataSet();

                if(ds.IsA("vtkPointSet")) {
                    VTK.vtkPointSet ps = VTK.vtkPointSet.SafeDownCast(ds);
                    Marshal.Copy(ps.GetPoints().GetVoidPointer(0),data,0,data.Length);
                    _dataBuffer = new ComputeBuffer((int)numberOfElements*(int)numberOfComponents,sizeof(float));
                    _dataBuffer.SetData(data);

                }
            } else if(_rootChannel is PointAnchorDatastreamChannel) {
                _dataBuffer = new ComputeBuffer((int)numberOfElements*(int)numberOfComponents,sizeof(float));
                _dataBuffer.SetData(((PointAnchorDatastreamChannel)_rootChannel)._points.ToArray());
            }
        }

        return _dataBuffer;
    }

    public ComputeBuffer GetTopologyBuffer() {
        if(_topologyBuffer == null) {
            if(GetVariable().IsAnchor()) {
                _topologyBuffer = new ComputeBuffer(GetTopologyArray().Length,sizeof(int)*2);
                _topologyBuffer.SetData(GetTopologyArray());
            }
        }


        return _topologyBuffer;
    }

    ComputeBuffer _topologyCellInfoBuffer;
    public ComputeBuffer GetTopologyCellInfoBuffer() {
        if(GetTopologyArray() == null) return null;
        if(_topologyCellInfoBuffer == null) {
            if(GetVariable().IsAnchor()) {
                _topologyCellInfoBuffer = new ComputeBuffer(GetTopologyCellInfoArray().Length,sizeof(int)*2);
                _topologyCellInfoBuffer.SetData(GetTopologyCellInfoArray());
            }
        }


        return _topologyCellInfoBuffer;
    }
    static ComputeBuffer _emptyBuffer;

    static public ComputeBuffer EmptyBuffer() {
       if(_emptyBuffer == null) {
            _emptyBuffer = new ComputeBuffer(1,sizeof(float));
            float[] A = {0};
            _emptyBuffer.SetData(A);
        }
        return _emptyBuffer;
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
        string slot = GetVariable().IsAnchor()? "Anchor":(""+bindSlot);
        int dim = GetVariable().GetDomainDimensionality();
        material.SetInt("_VariableDomainDimensionality_" + slot,dim);
        material.SetMatrix("_VariableBoundsMatrixInv_" + slot,Matrix4x4.TRS(GetVariable().GetBounds().center,Quaternion.identity,GetVariable().GetBounds().size).inverse);
        if(!GetVariable().IsAnchor()) material.SetVector("_VariableMin_" + slot, GetVariable().GetMin());
        if(!GetVariable().IsAnchor()) material.SetVector("_VariableMax_" + slot, GetVariable().GetMax());

        if(!GetVariable().IsAnchor()) material.SetVector("_VariableBoundsMin_" + slot, GetVariable().GetBounds().min);
        if(!GetVariable().IsAnchor()) material.SetVector("_VariableBoundsMax_" + slot, GetVariable().GetBounds().max);
        material.SetFloat("_VariableComponents_" + slot,GetNumberOfComponents());
        
 
        material.SetBuffer("_VariableDataBuffer_" + slot,EmptyBuffer());

        switch(dim) {
            case 3: 
                material.SetTexture("_Variable3DTexture_" + slot,Get3DTexture());
                break;
            case 1:
            case 0:
                material.SetInt("_VariableArrayType_" + slot,GetVariable().IsPointVariable()?1:0);
                material.SetBuffer("_VariableDataBuffer_" + slot,GetComputeBuffer());
                
                if(GetVariable().IsAnchor()) {
                    material.SetBuffer("_AnchorTopology",GetTopologyBuffer());
                    if(GetTopologyCellInfoBuffer() != null )material.SetBuffer("_AnchorTopologyCellInfo",GetTopologyCellInfoBuffer());

                }
                break;
        }
         
        
    }
}

}
