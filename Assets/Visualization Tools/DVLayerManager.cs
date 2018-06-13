using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV{


    public class LayerInstance {
        public Layer layerType;

    }

    [CustomEditor(typeof(DVLayerManager))]
    public class DVLayerManagerEditor : Editor
    {

        
        public override void OnInspectorGUI()
        {
            DVLayerManager layerManager = (DVLayerManager)target;

            //DrawDefaultInspector();

            GUILayout.Label("Layer Options: " +  (layerManager.GetAvailableLayers() != null? layerManager.GetAvailableLayers().layers.Count : 0).ToString());

            int selected = 0;

             string[] options = new string[layerManager.GetAvailableLayers().layers.Count];

             for(int i  = 0; i < layerManager.GetAvailableLayers().layers.Count; i++) {
                 options[i] = layerManager.GetAvailableLayers().layers[i].GetName();
             }

            GUILayout.BeginVertical("box");
            GUILayout.BeginHorizontal();
            GUILayout.Label(layerManager.GetLayers().Count.ToString() + " layers.");
            if(GUILayout.Button("+", GUILayout.Width(20))) {
                Debug.Log("Adding a new layer");
                layerManager.AddLayer(0);

            }
            GUILayout.EndHorizontal();


            for(int i = 0; i < layerManager._layers.Count; i++) {
                GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal();
                int s = 0;
                foreach (string x in options)
                {
                    if (x.Equals (layerManager._layers[i] .GetName()))
                    {
                        selected = s; 
                    }
                    s++;
                }
                int s2 = selected;
                selected = EditorGUILayout.Popup("Layer Type", selected, options);
                if(selected != s2){
                    Debug.Log(s2 + " " + selected.ToString());
                    DestroyImmediate(layerManager._layers[i].gameObject);

                    layerManager._layers[i] = layerManager.NewLayer(selected);
    
                } 
                if(GUILayout.Button("-", GUILayout.Width(20))) {
                    Debug.Log("Deleting this layer");
                    layerManager.RemoveLayer(layerManager._layers[i].gameObject);
                    break;
                }
                GUILayout.EndHorizontal();
                layerManager.GetLayers()[i].RenderGUI();
                GUILayout.EndVertical();
            }
 

            GUILayout.EndVertical();

            // // GUILayout.EndVertical();
            // for(int i = 0; i < layerManager._layerTypePrefabs.Length; i++) {
            //     if (GUILayout.Button("Add " + layerManager._layerTypePrefabs[i].GetName() + " layer")) {
            //         layerManager.AddLayer(i);
            //     }

            // }

        }
    }




[ExecuteInEditMode]
	public class DVLayerManager : MonoBehaviour {

    [SerializeField]
    private LayerSet _availableLayers;
    public LayerSet GetAvailableLayers() {
        return _availableLayers;
    }
    public DVDataLayer[] _layerTypePrefabs;
	public List<DVDataLayer> _layers;

	DVDataObject _dataObject;

    public DVDataObject GetData() {
        return _dataObject;
    }

    public List<DVDataLayer> GetLayers() {
        if(_layers == null) _layers = new List<DVDataLayer>();
        return _layers;

    }
	// Use this for initialization
	void Start () {
        
		_dataObject = gameObject.GetComponent<DVDataObject>();
		print(_dataObject.GetDataSet());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RemoveLayer(GameObject layer ) {

        _layers.Remove(layer.GetComponent<DVDataLayer>());
        DestroyImmediate(layer);
    }
    public DVDataLayer NewLayer(int index) {
        print("Adding new " + _layerTypePrefabs[index].GetName() + " layer");
         GameObject layer = Instantiate( GetAvailableLayers().layers[index].gameObject);
        // print(layer);

        layer.GetComponent<DVDataLayer>()._layerManager = this;
        return layer.GetComponent<DVDataLayer>();
    }
    public void AddLayer(int index) {
        
        GetLayers().Add(NewLayer(index));

    }
	}
}