using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(VertikalCreateRenderer))]
public class VertikalCreateRendererEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        VertikalCreateRenderer myScript = (VertikalCreateRenderer)target;
        if (GUILayout.Button("Add Slice"))
        {
            myScript.AddNewDataSliceRenderer();
        }
    }
}


public class VertikalCreateRenderer : MonoBehaviour {

    public GameObject _root;
    public GameObject _dataSlicePrefab;
    public int _arrayID;
	// Use this for initialization
	void Start () {
		
	}

    public void AddNewDataSliceRenderer()
    {
        if (_dataSlicePrefab)
        {
            GameObject dataSlice = Instantiate(_dataSlicePrefab);

            dataSlice.GetComponent<VertikalDataSliceRenderer>()._dataObject = this.gameObject.GetComponent<VertikalDataObject>();
            dataSlice.GetComponent<VertikalDataSliceRenderer>()._arrayId = _arrayID;
            if (_root)
            {
                dataSlice.transform.SetParent(_root.transform, false);

            }
            print(gameObject.transform.position);
            dataSlice.transform.position = gameObject.transform.position;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
