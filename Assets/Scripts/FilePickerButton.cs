using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class FilePickerButton : MonoBehaviour {

	public Button button;
	public Text nameLabel;
	public Text descLabel;
	public Image iconImage;

	private string dataFilePath;
	private FileScrollList scrollList = null;
	// Use this for initialization
	void Start () {
		
	}

	public void Setup(string currentDataFile, FileScrollList currentScrollList) {
		dataFilePath = currentDataFile;
		nameLabel.text = Path.GetFileName(currentDataFile);
		descLabel.text = Path.GetExtension (currentDataFile);
		//iconImage.sprite = dataFile.icon;

		scrollList = currentScrollList;

	}

}
