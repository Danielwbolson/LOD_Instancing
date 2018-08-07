using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public class PointAnchorDatastreamChannel : DatastreamChannel {


	[SerializeField]
	List<Vector3> _points;

    public List<Vector3> GetPoints() {
        if(_points == null) _points = new List<Vector3>();
        return _points;
    }

    public void SetPoints(List<Vector3> points) {
        GetPoints().Clear();
        GetPoints().AddRange(points);
    }
    public void Init() {
       
    }

    public override int GetNumberOfElements() {
        return GetPoints().Count;
    }
    
    public override int GetNumberOfComponents() {
        return 3;
    }
    
}
}