using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VertikalDataGlyphRenderer : VertikalDataRenderer {

    public VertikalSampleStrategy _strategy;

	// Use this for initialization
	void Start () {
        LockTransform();
	    
    }

	private void OnDrawGizmos()
	{
        if (_dataObject == null) return;

        Gizmos.matrix = _dataObject.transform.localToWorldMatrix;

        for (int i = 0; i < _strategy.GetNumberOfSamples(); i++)
        {
            //print(_strategy.GetSamples()[i].position);
            Gizmos.DrawSphere(_strategy.GetSamples()[i].position,1);

        }
	}
    override protected void RefreshDataSet()
    {
        _strategy.SetDataSet(_dataObject);
        _strategy.UpdateStrategy();

    }

}
