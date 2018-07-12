using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
public class DatastreamDirectory : ScriptableObject {

    // Dictionary<Variable/*Query Variable*/, 
    //     Dictionary<Variable /*Anchor Variable */,
    //     Dictionary<int /*instance */,
    //     Dictionary<int /*timestep*/,
    //     Datastream>>>> _directory;
    
    // // This is probably a stupid way to manage this.



    // Dictionary<Variable /*Anchor Variable */,
    //     Dictionary<int /*instance */,
    //     Dictionary<int /*timestep*/,
    //     Datastream>>> 
    //     getAnchorDictionary (Variable query) {
    //         if(_directory == null) _directory = new Dictionary<Variable,Dictionary<Variable,Dictionary<int,Dictionary<int,Datastream>>>>();
    //         if(!_directory.ContainsKey(query))
    //             return _directory[query];
    //         else return null; 
    //  }   


    //  Dictionary<int /*instance */,
    //     Dictionary<int /*timestep*/,
    //     Datastream>> 
    //     getInstanceDictionary (Variable query, Variable anchor) {
    //         var dir = getAnchorDictionary(query);
    //         if(dir != null && dir.ContainsKey(query))
    //             return dir[anchor];
    //         else return null;      
    //  }   

    // Dictionary<int /*timestep*/,
    //     Datastream>
    //     getTimestepDictionary (Variable query, Variable anchor, int instance) {
    //         var dir = getInstanceDictionary(query, anchor);
    //         if(dir != null && dir.ContainsKey(instance))
    //             return dir[instance];
    //         else return null; 
    //  }   
    
    // public Datastream GetDatastream(Variable query, Variable anchor = null, int instance = 0, int timestep = 0) {
    //     var dir = getTimestepDictionary(query, anchor,instance);
    //         if(dir != null && dir.ContainsKey(timestep))
    //             return dir[timestep];
    //         else return null; 
    // }

    // public void InsertDatastream(Datastream datastream,Variable query, Variable anchor = null, int instance = 0, int timestep = 0) {
    //     if(_directory == null) _directory = new Dictionary<Variable,Dictionary<Variable,Dictionary<int,Dictionary<int,Datastream>>>>();
        
    //     var dir1 =  _directory.ContainsKey(query)? _directory[query] : null;
    //     if(dir1 == null)
    //         _directory[query] = new Dictionary<Variable,Dictionary<int,Dictionary<int,Datastream>>>();

    //     var dir2 = _directory[query].ContainsKey(anchor)? _directory[query][anchor] : null;
    //     if(dir2 == null)
    //         _directory[query][anchor] = new Dictionary<int,Dictionary<int,Datastream>>();

    //     var dir3 = _directory[query][anchor].ContainsKey(instance)? _directory[query][anchor][instance] : null;
    //     if(dir3 == null)
    //         _directory[query][anchor][instance] = new Dictionary<int,Datastream>();

    //     _directory[query][anchor][instance][timestep] = datastream;
    // }

    // Datastream
    //  public void InsertDatastream(Datastream datastream,Variable query, Variable anchor = null, int instance = 0, int timestep = 0) {

    //  }
}

}
