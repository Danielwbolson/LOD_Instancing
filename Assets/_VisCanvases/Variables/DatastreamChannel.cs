using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public abstract class DatastreamChannel : ScriptableObject {
    public abstract int GetNumberOfElements();
    public abstract int GetNumberOfComponents();


}
}