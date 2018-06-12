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

            GUILayout.Label("Layer Options: " +  (Layer.allLayers != null? Layer.allLayers.Count : 0).ToString());

            int selected = 0;

             string[] options = new string[Layer.GetAllInstances<Layer>().Length];

             for(int i  = 0; i < Layer.GetAllInstances<Layer>().Length; i++) {
                 options[i] = Layer.GetAllInstances<Layer>()[i].name;
             }

            GUILayout.BeginVertical("box");
            GUILayout.BeginHorizontal();
            GUILayout.Label(layerManager._layers.Count.ToString() + " layers.");
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
                    if (x.Equals (layerManager._layers[i].layerType.name.ToString()))
                    {
                        selected = s; 
                    }
                    s++;
                }
                int s2 = selected;
                selected = EditorGUILayout.Popup("Layer Type", selected, options);
                if(selected != s2){
                    Debug.Log(s2 + " " + selected.ToString());
                    layerManager._layers[i].layerType = Layer.GetAllInstances<Layer>()[selected];
    
                } 
                if(GUILayout.Button("-", GUILayout.Width(20))) {
                    Debug.Log("Deleting this layer");
                    layerManager._layers.Remove(layerManager._layers[i]);
                }
                GUILayout.EndHorizontal();
                layerManager._layers[i].layerType.RenderGUI();
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




	public class DVLayerManager : MonoBehaviour {

    public DVDataLayer[] _layerTypePrefabs;
	public List<LayerInstance> _layers;

	DVDataObject _dataObject;

    public DVDataObject GetData() {
        return _dataObject;
    }

	// Use this for initialization
	void Start () {
        _layers = new List<LayerInstance>();
		_dataObject = gameObject.GetComponent<DVDataObject>();
		print(_dataObject.GetDataSet());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddLayer(int index) {
        print("Adding new " + _layerTypePrefabs[index].GetName() + " layer");
        // GameObject layer = Instantiate(_layerTypePrefabs[index].gameObject);
        // print(layer);

        // layer.GetComponent<DVDataLayer>()._layerManager = this;
        LayerInstance l = new LayerInstance();
        l.layerType = Layer.GetAllInstances<Layer>()[index];
        _layers.Add(l);

    }
	}
}