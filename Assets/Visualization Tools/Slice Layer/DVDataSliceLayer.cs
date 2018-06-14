using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;

namespace DV
{

[ExecuteInEditMode]
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

        override protected void UpdateLayer()
        {

            if (_cachedArrayId != _arrayId)
            {
                RequestUpdate();
            }
            GetComponent<MeshRenderer>().material.SetInt("_ArrayID", _arrayId);


        }

    }
}
