using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public class VTKDatastreamChannel : DatastreamChannel {

    public void Init(VTK.vtkDataSet dataset, VTK.vtkAbstractArray abstractArray) {
        _abstractArray = abstractArray;
        _dataset = dataset;
    }

    VTK.vtkDataSet _dataset;
    VTK.vtkAbstractArray _abstractArray;
    public VTK.vtkAbstractArray GetAbstractArray() {
        return _abstractArray;
    }
    public VTK.vtkDataSet GetDataset() {
        return _dataset;
    }
    public override int GetNumberOfElements() {
        return (int)_abstractArray.GetNumberOfTuples();
    }
    public override int GetNumberOfComponents() {
        return (int)_abstractArray.GetNumberOfComponents();
    }
}
}