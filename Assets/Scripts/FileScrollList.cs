using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class DataFile {
	public string fileName;
	public Sprite icon;
	public string details = "";
}


public class FileScrollList : MonoBehaviour {

	//public List<DataFile> dataFileList;
	public Transform contentPanel; 

	public SimpleObjectPool buttonObjectPool;

	public DataFileList dataFileList;
	// Use this for initialization
	void Start () {
		RefreshDisplay ();
	}

	private void RefreshDisplay() {
		AddButtons ();
	}
	private void AddButtons() {
		for (int i = 0; i < dataFileList.paths.Count; i++) {
			print (i);
			string file = dataFileList.paths [i];
			GameObject newButton = buttonObjectPool.GetObject ();
			newButton.transform.SetParent (contentPanel, false);
			FilePickerButton button = newButton.GetComponent<FilePickerButton> ();
			button.Setup (file, this);
		}
	}
}
