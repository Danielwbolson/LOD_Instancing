using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisBySculpting {
public class Datastream : ScriptableObject {
    [SerializeField]
    DatastreamChannel _rootChannel;

    public void Init(DatastreamChannel rootChannel) {
        _rootChannel = rootChannel;
    }

    int GetNumberOfElements() {
        return _rootChannel.GetNumberOfElements();
    }
}

}
