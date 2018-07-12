using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public class VTKPositionDatastreamChannel : DatastreamChannel {

    public void Init(VTK.vtkDataSet dataset) {
        _dataset = dataset;
    }

    VTK.vtkDataSet _dataset ;
    public VTK.vtkDataSet GetVTKDataSet() {
        return _dataset;
    }
    public override int GetNumberOfElements() {
        return (int)_dataset.GetNumberOfPoints();
    }
    
    public override int GetNumberOfComponents() {
        return 3;
    }
    
}
}