using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRenderer : MonoBehaviour {

    public GameObject _obj;
    public Material _objMat;
    public int _numObjects;
    private int _cachedNumObjects;

    public bool _instancedRendering;
    private bool _cachedInstanceRendering;

    private List<ObjInfo> _objInfo;
    private RenderStrategy _renderStrategy;

    /*
     * CLASS DOCUMENTATION: ObjRenderer
     * This class acts as a layer and user interface. It has a series of objects in its slice that move 
     * with it, as well as giving the option to have the objects rendered in different forms:
     *  Instantiated Gameobects
     *  GPU Instanced
     */

    // Use this for initialization
    void Start () {
        InitializeInfo();

        // Initialize our new RenderStrategy
        _renderStrategy = new Instanced(this.gameObject, _obj, _objMat, _objInfo, _numObjects);
        _instancedRendering = true;
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumObjects = _numObjects;
    }
    
    // Update is called once per frame
    void Update () {
        // If the user changes what kind of rendering they want, update
        if (_cachedInstanceRendering != _instancedRendering) {
            ToggleInstancedRendering();
        }

        if (_cachedNumObjects != _numObjects) {
            InitializeInfo();
            _renderStrategy.SetNumObjects(_numObjects);
            _renderStrategy.SetObjInfo(_objInfo);
            _cachedNumObjects = _numObjects;
        }

        // Update our objects based on our render strategy
        _renderStrategy.UpdateObjects();
    }

    void InitializeInfo() {
        _objInfo = new List<ObjInfo>();
        for (int i = 0; i < _numObjects; i++) {
            ObjInfo temp = new ObjInfo();

            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);

            temp.position = new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1);

            float scalx = Random.Range(0.01f, 0.15f);
            float scaly = Random.Range(0.01f, 0.15f);
            float scalz = Random.Range(0.01f, 0.15f);

            temp.scale = new Vector4(scalx, scaly, scalz, 1);

            _objInfo.Add(temp);
        }
    }

    /*
     * Based on user input, decide whether to render objects using GPU Instancing
     * or Gameobject Instantiation
     */
    void ToggleInstancedRendering() {
        List<ObjInfo> newObjInfo = _renderStrategy.GetObjInfo();

        if (_instancedRendering == true) {
            _renderStrategy.Destroy();
            _renderStrategy = new Instanced(this.gameObject, _obj, _objMat, newObjInfo, _numObjects);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(this.gameObject, _obj, _objMat, newObjInfo, _numObjects);
        }
        _cachedInstanceRendering = _instancedRendering;
    }

    /*
     * Call the renderStrategy destroy function when we disabled
     */
    void OnDisable() {
        if (_instancedRendering) {
            _renderStrategy.Destroy();
        }
    }
}
