using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using VTK;


public class GlyphLayerRenderStrategy  : LayerRenderStrategy {

	[SerializeField]
	List<GameObject> _glyphMeshes;
	
	[SerializeField]
	DV.DVSampleStrategy _sampleStrategy;

	[SerializeField]
	int _numberOfSamples = 100;




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



 

	public GlyphLayerRenderStrategy(Layer layer, List<GameObject> meshes, Material glyphMaterial, DV.DVSampleStrategy sampleStategy,  ComputeShader computeShader): base(layer) {
			_glyphMeshes = meshes;

			SetMaterial((glyphMaterial));

			_sampleStrategy = sampleStategy;
		
			_computeShader = computeShader;
			_sampleStrategy.SetDataSet(this.GetLayer().GetDataObject());
			_sampleStrategy.SetNumberOfSamples(_numberOfSamples);
			_sampleStrategy.UpdateStrategy();

		_objMat = glyphMaterial;
        _totalNumMeshes = _sampleStrategy.GetSamples().Length;
        _objs = meshes.ToArray();

        InitializeInfo();
        // Initialize our new RenderStrategy
        _renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
        _renderStrategy.SetDebug(_debug);
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumMeshes = _sampleStrategy.GetSamples().Length;
        _cachedObjs = _objs;
        _cachedDebug = _debug;



		}

	public override void SetupRender() {
		//_renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, GetMaterial(), _computeShader, _objInfo, _totalNumObjects);

	}
	public override void UpdateRender() {

		base.UpdateRender();
		if(_renderStrategy != null) {
		//_renderStrategy.SetMaterial(GetMaterial());
		}
		
	
				_sampleStrategy.SetNumberOfSamples(_numberOfSamples);
		_sampleStrategy.SetDataSet(GetLayer().GetDataObject());
		_sampleStrategy.UpdateStrategy();


	
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
                _renderStrategy = new Instanced(this.GetLayer().GetDataObject().gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
                _renderStrategy.SetDebug(_debug);
            } else {
                _renderStrategy.Destroy();
                _renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, _objMat, _computeShader, _objInfo, _totalNumMeshes);
                _renderStrategy.SetDebug(_debug);
            }
            _cachedNumMeshes = _totalNumMeshes;
            _cachedObjs = _objs;
        }

        // Update our objects based on our render strategy
        _renderStrategy.UpdateMeshes();

	}



	public override void DrawGizmos() {

	}

	[SerializeField]
	Variable _selectedVariable;


	public override void RenderGUI() {
		GUILayout.BeginVertical();
		DataObject dataObject = GetLayer().GetDataObject();
		if(dataObject != null) {
	VTK.vtkDataSet ds = dataObject.GetDataSet();
			
			VTK.vtkPointData pd = ds.GetPointData();
			int numArrays = pd.GetNumberOfArrays();
			
			{
						GUILayout.BeginHorizontal();

				string[] options = GetLayer().GetDataObject().GetVariableList().GetVariableNames();


				int selected = 0;
				int s = 0;
				for(int i = 0; i <  GetLayer().GetDataObject().GetVariableList().GetVariables().Count; i++)
				{
					if (GetVariable(0) != null && GetLayer().GetDataObject().GetVariableList().GetVariables()[i].GetVariableName().Equals (GetVariable(0).GetVariableName()))
					{
						selected = s; 
					}
					s++;
				}
				int s2 = selected;
				selected = EditorGUILayout.Popup("Choose Mask Variable:", selected, options);
				if(selected != s2 || GetVariable(0) == null){
					SetVariable(GetLayer().GetDataObject().GetVariableList().GetVariables()[selected], 0);
					
				} 
				GUILayout.EndHorizontal();
			}


			{
						GUILayout.BeginHorizontal();

				string[] options = GetLayer().GetDataObject().GetVariableList().GetVariableNames();


				int selected = 0;
				int s = 0;
				for(int i = 0; i <  GetLayer().GetDataObject().GetVariableList().GetVariables().Count; i++)
				{
					if (GetVariable(1) != null && GetLayer().GetDataObject().GetVariableList().GetVariables()[i].GetVariableName().Equals (GetVariable(1).GetVariableName()))
					{
						selected = s; 
					}
					s++;
				}
				int s2 = selected;
				selected = EditorGUILayout.Popup("Choose Color Variable:", selected, options);
				if(selected != s2 || GetVariable(1) == null){
					SetVariable(GetLayer().GetDataObject().GetVariableList().GetVariables()[selected], 1);
					
				} 
				GUILayout.EndHorizontal();
			}



			{
						GUILayout.BeginHorizontal();

				string[] options = GetLayer().GetDataObject().GetVariableList().GetVariableNames();


				int selected = 0;
				int s = 0;
				for(int i = 0; i <  GetLayer().GetDataObject().GetVariableList().GetVariables().Count; i++)
				{
					if (GetVariable(2) != null && GetLayer().GetDataObject().GetVariableList().GetVariables()[i].GetVariableName().Equals (GetVariable(2).GetVariableName()))
					{
						selected = s; 
					}
					s++;
				}
				int s2 = selected;
				selected = EditorGUILayout.Popup("Choose Direction Variable:", selected, options);
				if(selected != s2 || GetVariable(2) == null){
					SetVariable(GetLayer().GetDataObject().GetVariableList().GetVariables()[selected], 2);
					
				} 
							GUILayout.EndHorizontal();

			}


		} else {
			GUILayout.Label("No data variables available.");
		}
			
		


		GUILayout.BeginHorizontal();
		GUILayout.Label("Number of Glyphs: ");
		float newGlyphCount = GUILayout.HorizontalSlider(_sampleStrategy.GetNumberOfSamples(),0,10000);
		if(Mathf.Abs(newGlyphCount - _sampleStrategy.GetNumberOfSamples())>0) {
			_sampleStrategy.SetNumberOfSamples((int)newGlyphCount);
			_totalNumMeshes = (int)newGlyphCount;
			_numberOfSamples = _totalNumMeshes;
			//_renderStrategy.MakeDirty();
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();

		GUILayout.Label("Glyph Size: ");
		float newScale = GUILayout.HorizontalSlider(_glyphScale,0,100);
		if(Mathf.Abs(newScale - _glyphScale)>0.001) {
			_glyphScale = newScale;
			_cachedNumMeshes = -1;
			//_renderStrategy.MakeDirty();
		}
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}

[SerializeField]
float _glyphScale = 10;




 // Initialize our set of data
    void InitializeInfo() {
        _objInfo = new List<ObjInfo>[_objs.Length];

        for (int i = 0; i < _objs.Length; i++) {
            _objInfo[i] = new List<ObjInfo>();
        }

        for (int i = 0; i < _totalNumMeshes; i++) {
            float angle = UnityEngine.Random.Range(0.0f, Mathf.PI * 2.0f);
            float distance = UnityEngine.Random.Range(10.0f, 50.0f);
            float height = UnityEngine.Random.Range(-2.0f, 2.0f);

            ObjInfo temp = new ObjInfo {
                objIndex = UnityEngine.Random.Range(0, _objs.Length),
                LODIndex = -1,
                matrixIndex = i,
                position = new Vector4(_sampleStrategy.GetSamples()[i].position.x, _sampleStrategy.GetSamples()[i].position.y, _sampleStrategy.GetSamples()[i].position.z, 1), 
                //new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1),
                color = new Vector4(0, 0, 0, UnityEngine.Random.Range(0.20f, 1.0f)),
                scale = new Vector3(UnityEngine.Random.Range(0.05f, 0.2f), UnityEngine.Random.Range(0.05f, 0.2f), UnityEngine.Random.Range(0.05f, 0.2f)),
                direction = Vector3.Normalize(new Vector3(UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f)))
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
            _renderStrategy = new Instanced(this.GetLayer().GetDataObject().gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
            _renderStrategy.SetDebug(_debug);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, _objMat, _computeShader, newObjInfo, _totalNumMeshes);
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






}