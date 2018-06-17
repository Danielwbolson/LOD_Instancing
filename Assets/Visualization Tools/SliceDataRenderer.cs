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

    public override void RefreshData() {
        base.RefreshData();
    }
        
}