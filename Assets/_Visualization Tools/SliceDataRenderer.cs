using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;


[ExecuteInEditMode]
public class SliceDataRenderer : DataRenderer {

    [SerializeField]
    Text _variableDisplayText;

    public override void RefreshData() {
        base.RefreshData();
        if(_variableDisplayText!= null) {
            _variableDisplayText.text = GetLayer().GetLayerRenderStrategy().GetVariable(0).GetVariableName();
        }

        // Material _material = GetComponent<MeshRenderer>().material;
     
    }

    public override void ApplyMaterial() {
        GetComponent<MeshRenderer>().material = GetMaterial();
    }
        
}