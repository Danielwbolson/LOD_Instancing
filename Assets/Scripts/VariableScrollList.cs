using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class VariableScrollList : MonoBehaviour {

	//public List<DataFile> dataFileList;
	public Transform contentPanel; 

	public SimpleObjectPool buttonObjectPool;

	public Data data = null;

	// Use this for initialization
	void Start () {
		RefreshDisplay ();
	}
	void Update() {
		
//		if (currentCount != data.GetNumberOfVariables ()) {
//			RefreshDisplay ();
//		}
	}
	private void RefreshDisplay() {
		RemoveButtons ();

		AddButtons ();
	}

	private void RemoveButtons()
	{
		while (contentPanel.childCount > 0) 
		{
			GameObject toRemove = transform.GetChild(0).gameObject;
			buttonObjectPool.ReturnObject(toRemove);
		}
	}


	private void AddButtons() {
		if (data == null)
			return;
		
		for (int i = 0; i < data.GetNumberOfVariables (); i++) {
			GameObject newButton = buttonObjectPool.GetObject ();
			VariableButton button = newButton.GetComponent<VariableButton> ();
			button.Setup (data.GetVariableName(i), data.GetVariableComponentCount(i), this);
			newButton.transform.SetParent (contentPanel, false);

		}
	}

	public void SelectVariable(string v) {
		print ("Selected var " + v);

	}

	public void SetData(Data d) {
		data = d;

		RefreshDisplay ();
	}
}
