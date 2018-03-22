using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class VariableButton : MonoBehaviour {

	public Button button;
	public Text nameLabel;
	public Text componentLabel;
	private string variableName;

	private VariableScrollList scrollList = null;
	// Use this for initialization
	void Start () 
	{
		button.onClick.AddListener (HandleClick);
	}

	public void Setup(string varName, int components, VariableScrollList currentScrollList) {
		variableName = varName;
		nameLabel.text = variableName;
		componentLabel.text = components + " components";
		//iconImage.sprite = dataFile.icon;

		scrollList = currentScrollList;

	}

	public void HandleClick()
	{
		scrollList.SelectVariable (variableName);
	}

}
