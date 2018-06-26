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
    public ComputeShader _computeShader;
    public int _totalNumObjects;
    private int _cachedNumObjects;

    public bool _instancedRendering;
    private bool _cachedInstanceRendering;

    private List<ObjInfo> _objInfo;
    private RenderStrategy _renderStrategy;



 

	public GlyphLayerRenderStrategy(Layer layer, List<GameObject> meshes, Material glyphMaterial, DV.DVSampleStrategy sampleStategy,  ComputeShader computeShader): base(layer) {
			_glyphMeshes = meshes;

			SetMaterial((glyphMaterial));

			_sampleStrategy = sampleStategy;
		
		_computeShader = computeShader;

		_objs = _glyphMeshes.ToArray();
		_totalNumObjects = _numberOfSamples;

        // Initialize our new RenderStrategy
        _instancedRendering = false;
        _cachedInstanceRendering = _instancedRendering;
        _cachedNumObjects = _totalNumObjects;


		}

	public override void SetupRender() {
		_renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, GetMaterial(), _computeShader, _objInfo, _totalNumObjects);

	}
	public override void UpdateRender() {

		base.UpdateRender();
		if(_renderStrategy != null) {
		_renderStrategy.SetMaterial(GetMaterial());
		}
		
	
				_sampleStrategy.SetNumberOfSamples(_numberOfSamples);
		_sampleStrategy.SetDataSet(GetLayer().GetDataObject());
		_sampleStrategy.UpdateStrategy();


		if(_renderStrategy == null) {
					InitializeInfo();

					_renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, GetMaterial(), _computeShader, _objInfo, _totalNumObjects);

		}
		if(_renderStrategy == null)
			return; 



		Mesh M = _glyphMeshes[0].GetComponentInChildren<MeshFilter>().sharedMesh;


		Bounds b = GetLayer().GetDataObject().GetBounds();
	 	//Graphics.DrawMesh(M, GetLayer().GetDataObject().GetBoundsMatrix(),GetMaterial(),0);
		//Graphics.DrawMeshInstancedIndirect(M,)
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
			_totalNumObjects = (int)newGlyphCount;
			_numberOfSamples = _totalNumObjects;
			_renderStrategy.MakeDirty();
		}
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();

		GUILayout.Label("Glyph Size: ");
		float newScale = GUILayout.HorizontalSlider(_glyphScale,0,100);
		if(Mathf.Abs(newScale - _glyphScale)>0.001) {
			_glyphScale = newScale;
			_cachedNumObjects = -1;
			_renderStrategy.MakeDirty();
		}
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();
	}

[SerializeField]
float _glyphScale = 10;

void InitializeInfo() {
        _objInfo = new List<ObjInfo>();
        for (int i = 0; i < _totalNumObjects; i++) {

            ObjInfo temp = new ObjInfo {
                objIndex = UnityEngine.Random.Range(0, _objs.Length),
                LODIndex = -1,
                position = new Vector4(_sampleStrategy.GetSamples()[i].position.x,_sampleStrategy.GetSamples()[i].position.y,_sampleStrategy.GetSamples()[i].position.z,1), //new Vector4(Mathf.Sin(angle) * distance, height, Mathf.Cos(angle) * distance, 1),
                scale = _glyphScale,
                direction = Vector3.Normalize(new Vector3(UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f)))
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
            _renderStrategy = new Instanced(this.GetLayer().GetDataObject().gameObject, _objs, GetMaterial(), _computeShader, newObjInfo, _totalNumObjects);
        } else {
            _renderStrategy.Destroy();
            _renderStrategy = new Instantiated(this.GetLayer().GetDataObject().gameObject, _objs, GetMaterial(), _computeShader, newObjInfo, _totalNumObjects);
        }
        _cachedInstanceRendering = _instancedRendering;
    }





}