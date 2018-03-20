using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FileScrollList : MonoBehaviour {

	//public List<DataFile> dataFileList;
	public Transform contentPanel; 

	public SimpleObjectPool buttonObjectPool;

	public DataObjectManager dataFileList;

	int currentCount = 0;
	// Use this for initialization
	void Start () {
		RefreshDisplay ();
	}
	void Update() {
		if (currentCount != dataFileList.GetNumberOfFiles ()) {
			RefreshDisplay ();
		}
	}
	private void RefreshDisplay() {
		AddButtons ();
	}

	private void AddButtons() {
		currentCount = dataFileList.GetNumberOfFiles ();
		for (int i = 0; i < dataFileList.GetNumberOfFiles(); i++) {
			DataFile file = dataFileList.GetDataFile(i);
			GameObject newButton = buttonObjectPool.GetObject ();
			newButton.transform.SetParent (contentPanel, false);
			FilePickerButton button = newButton.GetComponent<FilePickerButton> ();
			button.Setup (file, this);
		}
	}

	public void SelectDataFile(DataFile file) {
		print ("Selected " + file.filePath);
	}
}
