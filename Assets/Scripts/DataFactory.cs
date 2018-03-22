using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataFactory : MonoBehaviour
{
	public Transform dataRoot;
	public GameObject dataObjectPrefab;
	public GameObject lineRendererPrefab;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public Data CreateDataset (DataFile file)
	{
		Data newData = null;
		string ext = Path.GetExtension (file.filePath);
		if (ext.Contains ("vt")) {
			print (ext);

			newData = new VTKData ();
			newData.SetFileName (file.filePath);

			//if(newData.IsType("
		}
	
		if (newData != null) {newData.LoadData ();
			GameObject dataObject = Instantiate (dataObjectPrefab);
			dataObject.transform.SetParent (dataRoot);
			dataObject.GetComponent<DataObject> ().data = newData;
			if (newData.GetNumberOfLines () > 0) {
				print ("Has Lines");
				GameObject lineRenderer = Instantiate (lineRendererPrefab);
				lineRenderer.transform.SetParent (dataObject.transform);
				lineRenderer.GetComponent<DataLineRenderer> ().dataObject = dataObject.GetComponent<DataObject> ();
				lineRenderer.GetComponent<DataLineRenderer> ().getLines ();
			}
		}

		return newData;
	}
}
