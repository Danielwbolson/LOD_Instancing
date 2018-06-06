using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DV
{
    public class DVSampleStrategy : MonoBehaviour
    {
        public struct DVSample
        {
            public Vector3 position;
        }
        public void SetDataSet(DVDataObject dataObject)
        {
            _dataObject = dataObject;

        }
        protected DVDataObject _dataObject;

        protected DVSample[] _samples;

        public int GetNumberOfSamples()
        {
            if (_samples == null) return 0;
            return _samples.Length;
        }
        public DVSample[] GetSamples()
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
}