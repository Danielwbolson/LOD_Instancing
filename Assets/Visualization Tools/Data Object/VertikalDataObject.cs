using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using VTK;

public class VertikalDataObject : MonoBehaviour
{
    protected vtkDataSet _dataSet;
    protected Bounds _bounds;

    public Bounds GetBounds()
    {
        if (_bounds == null) _bounds = GetDataSet().GetBounds();
        return _bounds;
    }
    public void SetDataSet(vtkDataSet dataSet)
    {
        _dataSet = dataSet;
        _bounds = GetDataSet().GetBounds();
    }
    public vtkDataSet GetDataSet()
    {
        return _dataSet;
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

//public class DataObject : MonoBehaviour
//{

//    public vtkDataObject dataObject_;

//  public void OnDrawGizmos()
//  {
//        if (dataObject_ != null)
//        {
//            if (dataObject_.IsA("vtkDataSet"))
//            {
//                vtkDataSet dataSet = vtkDataSet.SafeDownCast(dataObject_);
//                Bounds b = dataSet.GetBounds();
//                //b.size = new Vector3(300, 145, 145);
//                Gizmos.matrix = transform.localToWorldMatrix;
//                Gizmos.DrawWireCube (b.center, b.size);

//            }

//        }
//  }
//  public void SetDataObject(vtkDataObject dataObject)
//    {
//        dataObject_ = dataObject;

//        if (dataObject_.IsA("vtkDataSet"))
//        {
//            vtkDataSet dataSet = vtkDataSet.SafeDownCast(dataObject_);


//        }

//    }

//    public void RefreshChildren()
//    {
//        for (int i = 0; i < transform.childCount; i++)
//        {
//            DataRenderer childDataRenderer = transform.GetChild(i).GetComponent<DataRenderer>();
//            if (childDataRenderer)
//            {
//                if (dataObject_.IsA("vtkDataSet"))
//                {
//                    childDataRenderer.SetDataSet(vtkDataSet.SafeDownCast(dataObject_));
//                    childDataRenderer.RefreshDataRenderer();
//                }

//            }
//        }
//    }

//    public void RefreshDataObject() {
//        print("Updating dataObject " + dataObject_);
//        RefreshChildren();
//    }
//  void Start ()
//  {

//  }

//    void Update() {

//    }
//}


