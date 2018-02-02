using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRDetector : MonoBehaviour {
    public GameObject VR_Camera;
    public GameObject non_VR_Camera;
	// Use this for initialization
	void Start () {
		if (XRDevice.isPresent) {
			print ("Virtual Reality device present");
            VR_Camera.SetActive(true);
            non_VR_Camera.SetActive(false);
        } else {
			print ("Virtual Reality device not present");
            VR_Camera.SetActive (false);
            non_VR_Camera.SetActive(true);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
