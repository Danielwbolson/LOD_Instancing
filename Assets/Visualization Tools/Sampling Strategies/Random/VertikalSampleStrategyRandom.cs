﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertikalSampleStrategyRandom : VertikalSampleStrategy {

    override public void UpdateStrategy()
    {
        List<VertikalSample> sampleList = new List<VertikalSample>();

        Vector3 min = _dataObject.GetBounds().min;
        Vector3 max = _dataObject.GetBounds().max;
        print(min + ";" +  max);
        for (int i = 0; i < 100; i++)
        {
            VertikalSample sample = new VertikalSample();

            sample.position = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
            sampleList.Add(sample);
        }

        _samples = sampleList.ToArray();

    }


    override public void Report()
    {
        print("A Random Sampling Strategy");
    }
}
