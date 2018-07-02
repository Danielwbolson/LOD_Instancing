using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {
    public Vector3 minPos;
    public Vector3 maxPos;

	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
