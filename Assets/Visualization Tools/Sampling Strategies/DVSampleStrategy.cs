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

        void Update() {
            print("Updating");
            if(_needsUpdate) {
                UpdateStrategy();
            }
        }
        protected bool _needsUpdate = false;
        public void RequestUpdate() {
            _needsUpdate = true;
            Update();
        }
        int _numberOfSamples = 0;
        public void SetNumberOfSamples(int n) {
            _numberOfSamples = n;
            RequestUpdate();
        }
        public void SetDataSet(DVDataObject dataObject)
        {
            _dataObject = dataObject;
            RequestUpdate();


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