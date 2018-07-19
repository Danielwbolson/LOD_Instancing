using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {
public class PointAnchorDatastreamChannel : DatastreamChannel {


	[SerializeField]
	public List<Vector3> _points;

    public void Init(Bounds sampleSpace, int sampleCount) {
        Bounds b = sampleSpace;
		List<Vector3> points = new List<Vector3>();
		for(int i = 0; i < sampleCount; i++) {	
			Vector3 r = new Vector3(Random.Range(b.min.x,b.max.x),Random.Range(b.min.y,b.max.y),Random.Range(b.min.z,b.max.z));
			points.Add(r);
		}

		_points = points;
    }

    public override int GetNumberOfElements() {
        return _points.Count;
    }
    
    public override int GetNumberOfComponents() {
        return 3;
    }
    
}
}