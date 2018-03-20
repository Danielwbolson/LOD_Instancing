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

	private DataFile dataFile;
	private FileScrollList scrollList = null;
	// Use this for initialization
	void Start () 
	{
		button.onClick.AddListener (HandleClick);
	}

	public void Setup(DataFile currentDataFile, FileScrollList currentScrollList) {
		dataFile = currentDataFile;
		nameLabel.text = Path.GetFileName(currentDataFile.filePath);
		descLabel.text = Path.GetExtension (currentDataFile.filePath);
		//iconImage.sprite = dataFile.icon;

		scrollList = currentScrollList;

	}

	public void HandleClick()
	{
		scrollList.SelectDataFile (dataFile);
	}

}
