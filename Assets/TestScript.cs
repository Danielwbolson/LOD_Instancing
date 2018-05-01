using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using System.Runtime.InteropServices;


public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var example = new double();
        print(Marshal.SizeOf(example));

        double[] example2 = new double[2];
        print(Marshal.SizeOf(example2));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
