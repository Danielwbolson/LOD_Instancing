using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FrameRateWindow : MonoBehaviour {

	private Text textUI;

	void Start () {
		this.textUI = this.GetComponent<Text>();
	}

	void Update () {
		this.textUI.text = "FPS: " + (1f / Time.deltaTime).ToString("F2");
	}
}