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

        override public string GetName() {
            return "Slice";
        }    

        public int _arrayId = 0;
        private int _cachedArrayId = 0;

        public Text _variableDisplayText;



        override protected void RefreshDataSet()
        {


            if (GetData().GetNumberOfPointArrays() <= _arrayId)
                _arrayId = GetData().GetNumberOfPointArrays() - 1;
            
            print("Slice Layer pointed to a " + GetData().GetDataSet().GetClassName() + " with " + GetData().GetDataSet().GetNumberOfPoints().ToString() + " points and " + GetData().GetDataSet().GetNumberOfCells().ToString() + " cells.");


            if (_variableDisplayText)
                _variableDisplayText.text = GetData().GetDataSet().GetPointData().GetArrayName(_arrayId);


            _cachedArrayId = _arrayId;

        }

        override protected void UpdateDataLayer()
        {

            if (_cachedArrayId != _arrayId)
            {
                RequestUpdate();
            }
          
            GetComponent<MeshRenderer>().material.SetMatrix("_DataModelMatrix", GetData().transform.localToWorldMatrix);

            GetComponent<MeshRenderer>().material.SetMatrix("_DataModelMatrixInv", GetData().transform.worldToLocalMatrix);

            GetComponent<MeshRenderer>().material.SetMatrix("_DataBoundsMatrix", GetData().GetBoundsMatrix());

            GetComponent<MeshRenderer>().material.SetMatrix("_DataBoundsMatrixInv", GetData().GetBoundsMatrix().inverse);
            GetComponent<MeshRenderer>().material.SetFloat("_DataMin",(float)GetData().GetRangeOfPointArrays(_arrayId,0)[0]);
            GetComponent<MeshRenderer>().material.SetFloat("_DataMax",(float)GetData().GetRangeOfPointArrays(_arrayId,0)[1]);

            if (GetData().GetDataSet().IsA("vtkImageData")) {
                GetComponent<MeshRenderer>().material.SetVector("_DataImageDimensions", GetData().GetImageDataDimensions());
                GetComponent<MeshRenderer>().material.SetTexture("_DataVolume", GetData().GetImageDataTexture(_arrayId));
                
            }

        }

    }
}
