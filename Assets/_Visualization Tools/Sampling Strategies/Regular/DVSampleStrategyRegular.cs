﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DEPRECATED{

namespace DV
{
    public class DVSampleStrategyRegular : DVSampleStrategy
    {

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s-a1)*(b2-b1)/(a2-a1);
        }
        override public void UpdateStrategy()
        {
            if(_dataObject == null) return;

            List<DVSample> sampleList = new List<DVSample>();

            Vector3 min = _dataObject.GetBounds().min;
            Vector3 max = _dataObject.GetBounds().max;
            int sideLength = (int)Mathf.Ceil(Mathf.Pow((float)GetNumberOfSamples(),1.0f/3.0f));

            for (int i = 0; i < sideLength; i++)
            for (int j = 0; j < sideLength; j++)
            for (int k = 0; k < sideLength; k++)
            {
                if(sampleList.Count > GetNumberOfSamples()) break;
                DVSample sample = new DVSample();

                sample.position = new Vector3(map(i,0,10,min.x, max.x), map(j,0,10,min.y, max.y), map(k,0,10,min.z, max.z));
                sampleList.Add(sample);
            }

            _samples = sampleList.ToArray();
            _needsUpdate = false;

        }


        override public void Report()
        {
            Debug.Log("A Regular Sampling Strategy");
        }
    }
}
}