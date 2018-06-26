using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DVInstancingLODMeshFieldRenderingStrategy : DV.DVMeshFieldRenderingStrategy {

    public GameObject[] _objs;
    public Material _objMat;
    public ComputeShader _computeShader;
    public int _totalNumMeshes;
    public bool _instancedRendering = true;
    public bool _debug = false;

    private int _cachedNumMeshes;
    private bool _cachedInstanceRendering;
    private bool _cachedDebug;

    private GameObject[] _cachedObjs;
    private List<ObjInfo>[] _objInfo;
    private RenderStrategy _renderStrategy;



    /*
     * CLASS DOCUMENTATION: ObjRenderer
     * This class acts as a layer and user interface. It has a series of objects in its slice that move 
     * with it, as well as giving the option to have the objects rendered in different forms:
     *   Instantiated Gameobects
     *   GPU Instanced
     */

    // Use this for initialization
    void Start () {
        _totalNumMeshes = _samples.Length;
        _objs = _meshes;

        InitializeInfo();
        // Initialize our new RenderStrategy
        _renderStrategy = new Instantiated(_parent.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
        _renderStrategy.SetDebug(_debug);
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumMeshes = _samples.Length;
        _cachedObjs = _objs;
        _cachedDebug = _debug;
    }


  // Update is called once per frame
    void Update () {

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
            if (_instancedRendering == true) {
                _renderStrategy.Destroy();
                _renderStrategy = new Instanced(_parent.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
                _renderStrategy.SetDebug(_debug);
            } else {
                _renderStrategy.Destroy();
                _renderStrategy = new Instantiated(_parent.gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
                _renderStrategy.SetDebug(_debug);
            }
            _cachedNumMeshes = _totalNumMeshes;
            _cachedObjs = _objs;
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
                position = new Vector4(_samples[i].position.x, _samples[i].position.y, _samples[i].position.z, 1), 
                //new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1),
                color = new Vector4(0, 0, 0, Random.Range(0.20f, 1.0f)),
                scale = new Vector3(Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f), Random.Range(0.05f, 0.2f)),
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

        if (_instancedRendering == true) {
            _renderStrategy.Destroy();
            _renderStrategy = new Instanced(_parent.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
            _renderStrategy.SetDebug(_debug);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(_parent.gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
            _renderStrategy.SetDebug(_debug);
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



    // Use this for initialization
    public override void UpdateMeshData() {
         Start();
    }
    public override void DrawMeshes() {
        Update();
    }

}