using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatoggle : MonoBehaviour {

	public GameObject tract;
	public GameObject wave;

	public bool tractIsActive = false;
	public bool waveIsActive = false;

	public void toggleTract() {
		tractIsActive = !tractIsActive;
		tract.SetActive (tractIsActive);
	}

	public void toggleWave() {
		waveIsActive = !waveIsActive;
		wave.SetActive (waveIsActive);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
