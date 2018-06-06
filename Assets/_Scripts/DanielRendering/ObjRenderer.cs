using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRenderer : MonoBehaviour {

    public GameObject[] _objs;
    public Material _objMat;
    public ComputeShader _computeShader;
    public int _totalNumObjects;
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
        _renderStrategy = new Instantiated(this.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumObjects);
        _instancedRendering = false;
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumObjects = _totalNumObjects;
    }
    
    // Update is called once per frame
    void Update () {
        // If the user changes what kind of rendering they want, update
        if (_cachedInstanceRendering != _instancedRendering) {
            ToggleInstancedRendering();
        }

        if (_cachedNumObjects != _totalNumObjects) {
            InitializeInfo();
            _renderStrategy.SetNumObjects(_totalNumObjects);
            _renderStrategy.SetObjInfo(_objInfo);
            _cachedNumObjects = _totalNumObjects;
        }

        // Update our objects based on our render strategy
        _renderStrategy.UpdateObjects();
    }

    void InitializeInfo() {
        _objInfo = new List<ObjInfo>();
        for (int i = 0; i < _totalNumObjects; i++) {
            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);

            ObjInfo temp = new ObjInfo {
                objIndex = Random.Range(0, _objs.Length),
                position = new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1),
                color = new Vector4(0, 0, 0, Random.Range(0.20f, 1.0f)),
                scale = 0.1f,
                direction = Vector3.Normalize(new Vector3(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)))
            };

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
            _renderStrategy = new Instanced(this.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumObjects);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(this.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumObjects);
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
