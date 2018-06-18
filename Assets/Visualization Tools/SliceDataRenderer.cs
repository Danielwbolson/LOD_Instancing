using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;

public class SliceDataRenderer : DataRenderer {

    [SerializeField]
    Text _variableDisplayText;

    void Update() {
        Material _material = GetComponent<MeshRenderer>().material;

            _material.SetMatrix("_DataModelMatrix", GetLayer().GetDataObject().transform.localToWorldMatrix);

            _material.SetMatrix("_DataModelMatrixInv", GetLayer().GetDataObject().transform.worldToLocalMatrix);

            _material.SetMatrix("_DataBoundsMatrix", GetLayer().GetDataObject().GetBoundsMatrix());

            _material.SetMatrix("_DataBoundsMatrixInv", GetLayer().GetDataObject().GetBoundsMatrix().inverse);
    }
    public override void RefreshData() {
        base.RefreshData();
        if(_variableDisplayText!= null) {
            _variableDisplayText.text = GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableName();
        }
        GetComponent<MeshRenderer>().material.SetInt("_ArrayID", GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableIndex());

        Material _material = GetComponent<MeshRenderer>().material;


        Vector4 v = GetLayer().GetLayerRenderStrategy().GetVariable(0).GetMinValue();
        Vector4 v2 = GetLayer().GetLayerRenderStrategy().GetVariable(0).GetMaxValue();
        print(v);
        print(v2);
        _material.SetVector("_DataMin",v);
        _material.SetVector("_DataMax",v2);
        Texture t = GetLayer().GetDataObject().GetImageDataTexture(GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableIndex());
        _material.SetTexture("_DataVolume0", t);
    }
        
}