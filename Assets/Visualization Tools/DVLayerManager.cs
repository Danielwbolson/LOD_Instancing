using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV{

    [CustomEditor(typeof(DVLayerManager))]
    public class DVLayerManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DVLayerManager myScript = (DVLayerManager)target;

            DrawDefaultInspector();
            for(int i = 0; i < myScript._layerTypePrefabs.Length; i++) {
                if (GUILayout.Button("Add " + myScript._layerTypePrefabs[i].GetName() + " layer")) {
                    myScript.AddLayer(i);
                }

            }

        }
    }




	public class DVLayerManager : MonoBehaviour {

    public DVDataLayer[] _layerTypePrefabs;
	List<DVDataLayer> _layers;

	DVDataObject _dataObject;

    public DVDataObject GetData() {
        return _dataObject;
    }
	// Use this for initialization
	void Start () {
        _layers = new List<DVDataLayer>();
		_dataObject = gameObject.GetComponent<DVDataObject>();
		print(_dataObject.GetDataSet());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddLayer(int index) {
        print("Adding new " + _layerTypePrefabs[index].GetName() + " layer");
        GameObject layer = Instantiate(_layerTypePrefabs[index].gameObject);
        print(layer);

        layer.GetComponent<DVDataLayer>()._layerManager = this;
        _layers.Add(layer.GetComponent<DVDataLayer>());

    }
	}
}