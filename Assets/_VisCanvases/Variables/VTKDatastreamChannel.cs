using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VisBySculpting {
public class VTKDatastreamChannel : DatastreamChannel {

public void Init(VTK.vtkAbstractArray abstractArray) {
    _abstractArray = abstractArray;
}

VTK.vtkAbstractArray _abstractArray;
VTK.vtkAbstractArray GetAbstractArray() {
    return _abstractArray;
}
public override int GetNumberOfElements() {
    return (int)_abstractArray.GetNumberOfTuples();
}

}
}