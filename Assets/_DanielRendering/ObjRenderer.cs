using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRenderer : MonoBehaviour {

    public GameObject[] _objs;
    public Material _objMat;
    public ComputeShader _computeShader;
    public int _totalNumMeshes;
    public bool _instancedRendering = false;
    public bool _debug = false;
    public bool _normalMapsEnabled = false;

    private int _cachedNumMeshes;
    private bool _cachedInstanceRendering;
    private bool _cachedDebug;
    private bool _cachedNormalMapsEnabled;

    private GameObject[] _cachedObjs;
    private List<ObjInfo>[] _objInfo;
    private RenderStrategy _renderStrategy;

    /*
     * CLASS DOCUMENTATION: ObjRenderer
     * This class acts as a layer and user interface. It has a series of objects in its slice that move 
     * with it, as well as giving the option to have the objects rendered in different forms:
     *   Instantiated GameObjects
     *   GPU Instanced
     */

    // Use this for initialization
    void Start() {
        InitializeInfo();

        // Initialize our new RenderStrategy
        _renderStrategy = new Instantiated(this.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
        _renderStrategy.SetDebug(_debug);
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumMeshes = _totalNumMeshes;
        _cachedObjs = _objs;
        _cachedDebug = _debug;
        _cachedNormalMapsEnabled = _normalMapsEnabled;
    }

    // Update is called once per frame
    void Update() {

        if (_cachedDebug != _debug) {
            _renderStrategy.SetDebug(_debug);
            _cachedDebug = _debug;
        }

        // If the user changes what kind of rendering they want, update
        if (_cachedInstanceRendering != _instancedRendering) {
            ToggleInstancedRendering();
        }

        // If the user changes how many meshes or unique objects they want, create new renderings
        if (_cachedNumMeshes != _totalNumMeshes || _cachedObjs != _objs) {
            InitializeInfo();

            _renderStrategy.Destroy();

            if (_instancedRendering == true) {
                _renderStrategy = new Instanced(this.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
            } else {
                _renderStrategy = new Instantiated(this.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
            }
            _renderStrategy.SetDebug(_debug);
            _renderStrategy.SetNormalMapsEnabled(_normalMapsEnabled);

            _cachedNumMeshes = _totalNumMeshes;
            _cachedObjs = _objs;
        }

        // IF the user changes whether or not they want to be using normal maps or not
        if (_cachedNormalMapsEnabled != _normalMapsEnabled) {
            _renderStrategy.SetNormalMapsEnabled(_normalMapsEnabled);
            _cachedNormalMapsEnabled = _normalMapsEnabled;
        }

        // Update our objects based on our render strategy
        _renderStrategy.UpdateMeshes();
    }

    // Initialize our set of data
    void InitializeInfo() {
        _objInfo = new List<ObjInfo>[_objs.Length];

        for (int i = 0; i < _objs.Length; i++) {
            _objInfo[i] = new List<ObjInfo>();
        }

        for (int i = 0; i < _totalNumMeshes; i++) {
            float angle = Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = Random.Range(10.0f, 50.0f);
            float height = Random.Range(-2.0f, 2.0f);

            ObjInfo temp = new ObjInfo {
                objIndex = Random.Range(0, _objs.Length),
                LODIndex = -1,
                matrixIndex = i,
                position = new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1),
                color = new Vector4(0, 0, 0, Random.Range(0.20f, 1.0f)),
                scale = new Vector3(4, 4, 4), //new Vector3(Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f)),
                direction = Vector3.Normalize(new Vector3(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)))
            };

            _objInfo[temp.objIndex].Add(temp);
        }
    }

    /*
     * Based on user input, decide whether to render objects using GPU Instancing
     * or Gameobject Instantiation
     */
    void ToggleInstancedRendering() {
        List<ObjInfo>[] newObjInfo = _renderStrategy.GetObjInfo();

        _renderStrategy.Destroy();

        if (_instancedRendering == true) {
            _renderStrategy = new Instanced(this.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
        } else {
            _renderStrategy = new Instantiated(this.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
        }
        _renderStrategy.SetDebug(_debug);
        _renderStrategy.SetNormalMapsEnabled(_normalMapsEnabled);

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