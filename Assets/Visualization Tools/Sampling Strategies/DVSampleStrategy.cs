using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DV
{
    public struct DVSample
    {
        public Vector3 position;
    }
    public class DVSampleStrategy : MonoBehaviour
    {

        int _numberOfSamples = 0;
        public void SetNumberOfSamples(int n) {
            _numberOfSamples = n;
            UpdateStrategy();
        }
        public void SetDataSet(DVDataObject dataObject)
        {
            _dataObject = dataObject;

        }
        protected DVDataObject _dataObject;

        protected DVSample[] _samples;

        public int GetNumberOfSamples()
        {
            return _numberOfSamples;
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