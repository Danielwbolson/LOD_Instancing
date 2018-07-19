// This componnet Demos how to use MinMax attribute! Uses the ReadOnly attribute found here https://gist.github.com/LotteMakesStuff/c0a3b404524be57574ffa5f8270268ea
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class VolumeRandomizer : MonoBehaviour {

    public AudioSource source;
    public float Size;
    [MinMax(0,1, ShowEditRange = true)]
    public Vector2 VolumeRange = new Vector2(0, 1);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    [ExecuteInEditMode]
	void Update () {
    }
}
