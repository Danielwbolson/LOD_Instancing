using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using VTK;

namespace DV
{
    public class DVDataObject : MonoBehaviour
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
}