using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;

namespace DV
{

    public class DVDataSliceLayer : DVDataLayer
    {



        public int _arrayId = 0;
        private int _cachedArrayId = 0;

        public Text _variableDisplayText;



        override protected void RefreshDataSet()
        {


            if (_dataObject.GetNumberOfPointArrays() <= _arrayId)
                _arrayId = _dataObject.GetNumberOfPointArrays() - 1;
            
            print("Slice Layer pointed to a " + _dataObject.GetDataSet().GetClassName() + " with " + _dataObject.GetDataSet().GetNumberOfPoints().ToString() + " points and " + _dataObject.GetDataSet().GetNumberOfCells().ToString() + " cells.");


            if (_variableDisplayText)
                _variableDisplayText.text = _dataObject.GetDataSet().GetPointData().GetArrayName(_arrayId);


            _cachedArrayId = _arrayId;

        }

        override protected void UpdateDataLayer()
        {

            if (_cachedArrayId != _arrayId)
            {
                RequestUpdate();
            }
          
            GetComponent<MeshRenderer>().material.SetMatrix("_DataModelMatrix", _dataObject.transform.localToWorldMatrix);

            GetComponent<MeshRenderer>().material.SetMatrix("_DataModelMatrixInv", _dataObject.transform.worldToLocalMatrix);

            GetComponent<MeshRenderer>().material.SetMatrix("_DataBoundsMatrix", _dataObject.GetBoundsMatrix());

            GetComponent<MeshRenderer>().material.SetMatrix("_DataBoundsMatrixInv", _dataObject.GetBoundsMatrix().inverse);

            if (_dataObject.GetDataSet().IsA("vtkImageData")) {
                GetComponent<MeshRenderer>().material.SetVector("_DataImageDimensions", _dataObject.GetImageDataDimensions());
                GetComponent<MeshRenderer>().material.SetTexture("_DataVolume", _dataObject.GetImageDataTexture(_arrayId));
                
            }

        }

    }
}
