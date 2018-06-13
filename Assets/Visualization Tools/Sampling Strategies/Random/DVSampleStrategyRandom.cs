using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DV
{
    public class DVSampleStrategyRandom : DVSampleStrategy
    {

        override public void UpdateStrategy()
        {
            Random.seed = 0;
            List<DVSample> sampleList = new List<DVSample>();

            Vector3 min = _dataObject.GetBounds().min;
            Vector3 max = _dataObject.GetBounds().max;
            for (int i = 0; i < GetNumberOfSamples(); i++)
            {
                DVSample sample = new DVSample();

                sample.position = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
                sampleList.Add(sample);
            }

            _samples = sampleList.ToArray();

        }


        override public void Report()
        {
            Debug.Log("A Random Sampling Strategy");
        }
    }
}