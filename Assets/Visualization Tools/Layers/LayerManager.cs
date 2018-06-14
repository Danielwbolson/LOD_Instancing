using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




    [CustomEditor(typeof(LayerManager))]
    public class LayerManagerEditor : Editor
    {

        
        public override void OnInspectorGUI()
        {
            LayerManager layerManager = (LayerManager)target;

            //DrawDefaultInspector();

            GUILayout.Label("Layer Options: " +  layerManager.GetAvailableLayerTypes().Count.ToString());

            int selected = 0;

             string[] options = new string[layerManager.GetAvailableLayerTypes().Count];

             for(int i  = 0; i < layerManager.GetAvailableLayerTypes().Count; i++) {
                 options[i] = layerManager.GetAvailableLayerTypes()[i].GetName();
             }

            GUILayout.BeginVertical("box");
            GUILayout.BeginHorizontal();
            GUILayout.Label(layerManager.GetLayers().Count.ToString() + " layers.");
            if(GUILayout.Button("+", GUILayout.Width(20))) {
                Debug.Log("Adding a new layer");
                layerManager.AddLayer(0);

            }
            GUILayout.EndHorizontal();


            for(int i = 0; i < layerManager.GetLayers().Count; i++) {
                GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal();
                int s = 0;
                foreach (string x in options)
                {
                    if (x.Equals (layerManager.GetLayers()[i].GetLayerTypeName()))
                    {
                        selected = s; 
                    }
                    s++;
                }
                int s2 = selected;
                selected = EditorGUILayout.Popup("Layer Type", selected, options);
                if(selected != s2){
                    Debug.Log(s2 + " " + selected.ToString());
                    Layer l = layerManager.GetLayers()[i];
                    l.Destroy();
                    layerManager.GetLayers()[i].SetLayerType(layerManager.GetAvailableLayerTypes()[selected]);
                   //layerManager.RemoveLayer(layerManager.GetLayers()[i]);
    
                } 
                if(GUILayout.Button("-", GUILayout.Width(20))) {
                    Debug.Log("Deleting this layer");
                    
                    layerManager.RemoveLayer(layerManager.GetLayers()[i]);
                    break;
                }
                GUILayout.EndHorizontal();
                 layerManager.GetLayers()[i].RenderGUI();
                //layerManager.GetLayers()[i].RenderGUI();
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
public class LayerManager : MonoBehaviour {

    [SerializeField]
    private LayerTypeSet _availableLayerTypes;
    public List<LayerType> GetAvailableLayerTypes() {
        return _availableLayerTypes != null? _availableLayerTypes.layerTypes : new List<LayerType>();
    }

	private List<Layer> _layers;


    public List<Layer> GetLayers() {
        if(_layers == null) _layers = new List<Layer>();
        return _layers;
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RemoveLayer(Layer toRemove ) {
        toRemove.Destroy();
        _layers.Remove(toRemove);
        
        
    }
    public Layer NewLayer(int index) {
        print("Adding new " + GetAvailableLayerTypes()[index].GetName() + " layer");
         //GameObject layer = GetAvailableLayerTypes().layerTypes[index];
        // print(layer);
        Layer layer = new Layer(this);
        layer.SetLayerType( GetAvailableLayerTypes()[index]);
        return layer;
    }
    public void AddLayer(int index) {
        
        GetLayers().Add(NewLayer(index));

    }


}