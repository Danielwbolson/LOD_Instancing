using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VertikalSampleStrategy : MonoBehaviour
{
    public struct VertikalSample
    {
        public Vector3 position;
    }
    public void SetDataSet(VertikalDataObject dataObject)
    {
        _dataObject = dataObject;

    }
    protected VertikalDataObject _dataObject;

    protected VertikalSample[] _samples;

    public int GetNumberOfSamples()
    {
        if (_samples == null) return 0;
        return _samples.Length;
    }
    public VertikalSample[] GetSamples()
    {
        return _samples;
    }
    
	virtual public void UpdateStrategy()
	{
        
	}
	virtual public void Report()
    {
    }
}
