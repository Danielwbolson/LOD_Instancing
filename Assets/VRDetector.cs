using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (XRDevice.isPresent) {
			print ("Virtual Reality device present");
		} else {
			print ("Virtual Reality device not present");
			gameObject.SetActive (false);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
