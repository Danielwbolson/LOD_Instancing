using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatoggle : MonoBehaviour {

	public GameObject tract;
	public GameObject wave;
    public GameObject brain;

    public bool tractIsActive = false;
	public bool waveIsActive = false;
    public bool brainIsActive = false;

    public void toggleTract() {
		tractIsActive = !tractIsActive;
		tract.SetActive (tractIsActive);
	}

    public void toggleBrain()
    {
        brainIsActive = !brainIsActive;
        brain.SetActive(brainIsActive);
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
