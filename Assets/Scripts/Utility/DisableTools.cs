using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DisableTools : MonoBehaviour {



    void LockTransform()
    {
        Tools.hidden = true;
        transform.hideFlags = HideFlags.NotEditable | HideFlags.HideInInspector;
    }
    void UnlockTransform()
    {
        Tools.hidden = false;
        transform.hideFlags = HideFlags.None;

    }


    void OnEnable()
    {

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
