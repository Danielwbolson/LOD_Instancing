using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public class VectorArrayDatastreamChannel : ArrayDatastreamChannel {

    public void Init(int numberofElements, int numberofComponents) {
        _array = new Vector4[numberofElements];
        _numComponents = numberofComponents;
    }

    public void SetArray(Vector4 [] array) {
        _array = array;
    }
    public Vector4 [] GetArray() {
        return _array;
    }

    Vector4 [] _array;
    int _numComponents;

    public override int GetNumberOfElements() {
        return (int)_array.Length;
    }
    public override int GetNumberOfComponents() {
        return (int)_numComponents;
    }
}
}