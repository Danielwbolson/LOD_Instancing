using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu()]
public class Layer : ScriptableObject {
	[SerializeField]
	public string name = "LayerName";

 	// public void Awake()
    // {
    //     Debug.Log("Awake");
    // }

    public void OnEnable()
    {
		if(allLayers == null) allLayers = new List<Layer>();
        allLayers.Add(this);
		Debug.Log(allLayers.Count);
    }


	public virtual void RenderGUI() {
	}


    // public void OnDisable()
    // {
    //     Debug.Log("OnDisable");
    // }

    // public void OnDestroy()
    // {
    //     Debug.Log("OnDestroy");
    // }
	public static List<Layer> allLayers;
	 public static T[] GetAllInstances<T>() where T : ScriptableObject
     {
         string[] guids = AssetDatabase.FindAssets("t:"+ typeof(T).Name);  //FindAssets uses tags check documentation for more info
         T[] a = new T[guids.Length];
         for(int i =0;i<guids.Length;i++)         //probably could get optimized 
         {
             string path = AssetDatabase.GUIDToAssetPath(guids[i]);
             a[i] = AssetDatabase.LoadAssetAtPath<T>(path);
         }
 
         return a;
 
     }

}
