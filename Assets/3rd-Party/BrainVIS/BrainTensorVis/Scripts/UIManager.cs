using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class UIManager : MonoBehaviour
{
	public GameObject baseSliceButtonUI;

	public SliceMananger sliceManager;

	public Text currSliceNameTxt;
	public GameObject sliceButtonContainer;

	public Toggle cylinderOneToggle;
	public Toggle cylinderTwoToggle;
	public Toggle cylinderZeppelinToggle;
	public Toggle cylinderBgImageToggle;

	private string dataDirPath;

	void Start ()
	{
		this.dataDirPath = Application.streamingAssetsPath  + "/example_data/BrainVIS/BrainTensorData";

		string[] filePaths = Directory.GetFiles (this.dataDirPath, "*_*_*_*.txt");

		foreach (string filePath in filePaths) {
			string fName = Path.GetFileNameWithoutExtension (filePath);

			GameObject btn = GameObject.Instantiate (this.baseSliceButtonUI);
			btn.name = fName + "_btn";
			btn.GetComponentInChildren<Text> ().text = fName;
			// TODO callback functions
			btn.transform.SetParent (this.sliceButtonContainer.transform);
			btn.SetActive (true);
		}
	}

	public void OpenSlice(Text btnText) {
		sliceManager.Clear();

		//
		string fPath = this.dataDirPath + "/" + btnText.text + ".txt";
		Debug.Log("Opening " + fPath);
		sliceManager.OpenSlice(fPath);

		// 
		this.currSliceNameTxt.text = "Currnet Slice:    " + btnText.text;

		// 
		sliceManager.SetFirstGlyphVisibility(this.cylinderOneToggle.isOn);
		sliceManager.SetSecondGlyphVisibility(this.cylinderTwoToggle.isOn);
		sliceManager.SetThirdGlyphVisibility(this.cylinderZeppelinToggle.isOn);
		sliceManager.SetBackgroundImageVisibility(this.cylinderBgImageToggle.isOn);
	}
}
