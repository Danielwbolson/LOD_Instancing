using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VTK;

public class Test : MonoBehaviour {
    public Text versionText;
	// Use this for initialization
	void Start () {
        print("Using VTK version " + vtkVersion.GetVTKVersion());		
	    if(versionText != null)
            versionText.text = "Using VTK version " + vtkVersion.GetVTKVersion();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
