using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SculptingVis {
[CreateAssetMenu()]
public class SimplePointLayer : Layer {

	[SerializeField]
	public VariableSocket _anchorVariable;

	[SerializeField]
	public VariableSocket _colorVariable;

	[SerializeField]
	public VariableSocket _directionVariable;

	[SerializeField]
	public VariableSocket _opacityVariable;


	[SerializeField]
	public Texture2D _colorMap;

	[SerializeField]
	Material _pointMaterial;

	[SerializeField]
	Mesh _glyphMesh;


	
	[SerializeField]
	bool _sampleAtCenter;

	[SerializeField]
	float _glyphScale = 4;

	[SerializeField]
	int instanceCount;

    private ComputeBuffer argsBuffer;
    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

	
	public void Init() {
		ClearSockets();
		_anchorVariable = CreateInstance<VariableSocket>();
		_anchorVariable.Init();
		SetAnchorSocket(_anchorVariable);

		_colorVariable = CreateInstance<VariableSocket>();
		_colorVariable.Init("Color",1);
		_colorVariable.RequireScalar();
		_colorVariable.SetAnchorVariable(_anchorVariable);

		_directionVariable = CreateInstance<VariableSocket>();
		_directionVariable.Init("Direction",2);
		_directionVariable.RequireVector();
		_directionVariable.SetAnchorVariable(_anchorVariable);

		_opacityVariable = CreateInstance<VariableSocket>();
		_opacityVariable.Init("Opacity",3);
		_opacityVariable.RequireScalar();
		_opacityVariable.SetAnchorVariable(_anchorVariable);

		GetSockets() .Add(_anchorVariable);
		GetSockets() .Add(_colorVariable);
		GetSockets() .Add(_directionVariable);
		GetSockets().Add(_opacityVariable);

	    argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);

		// Indirect args
        if (_glyphMesh != null) {
            args[0] = (uint)_glyphMesh.GetIndexCount(0);
            args[1] = (uint)instanceCount;
            args[2] = (uint)_glyphMesh.GetIndexStart(0);
            args[3] = (uint)_glyphMesh.GetBaseVertex(0);
        }
        else
        {
            args[0] = args[1] = args[2] = args[3] = 0;
        }
        argsBuffer.SetData(args);

	}	
	public override bool HasBounds() {
		return _anchorVariable != null && _anchorVariable.IsAssigned();
	}
	public override Bounds GetBounds() {
		return _anchorVariable.GetInput().GetBounds();
	}


	ComputeBuffer cellAndPointIndexBuffer;
	public override void DrawLayer(Canvas canvas) {
		if(_anchorVariable == null || !_anchorVariable.IsAssigned()) return;
		Datastream stream = _anchorVariable.GetInput().GetStream(null,0,0);


		// Indirect args
        if (_glyphMesh != null) {
            args[0] = (uint)_glyphMesh.GetIndexCount(0);
            args[1] = (uint)stream.GetTopologyArray().Length;
            args[2] = (uint)_glyphMesh.GetIndexStart(0);
            args[3] = (uint)_glyphMesh.GetBaseVertex(0);
        }
        else
        {
            args[0] = args[1] = args[2] = args[3] = 0;
        }
        argsBuffer.SetData(args);

		//Mesh[] m = stream.GetMeshes();

		_pointMaterial.SetTexture("_ColorMap",_colorMap);
		_pointMaterial.SetInt("_SampleAtCenter",_sampleAtCenter?1:0);
		_pointMaterial.SetFloat("_glyphScale", _glyphScale );
		if(cellAndPointIndexBuffer == null) {
			cellAndPointIndexBuffer = new ComputeBuffer(instanceCount,sizeof(int)*2);
			Vector2Int [] cellAndPointIndexArray = new Vector2Int[instanceCount];
			for(int i = 0; i < instanceCount;i++) {
				cellAndPointIndexArray[i] = new Vector2Int(0,i);
			}
			cellAndPointIndexBuffer.SetData(cellAndPointIndexArray);
		}

		
		Material canvasMaterial = GetCanvasMaterial(canvas,_pointMaterial);
		canvasMaterial.SetBuffer("_Indices",cellAndPointIndexBuffer);
		foreach(VariableSocket socket in GetSockets()) {
			
		}
		_anchorVariable.Bind(canvasMaterial,0,0);
		_colorVariable.Bind(canvasMaterial,0,0);
		_directionVariable.Bind(canvasMaterial,0,0);
		_opacityVariable.Bind(canvasMaterial,0,0);

		// Graphics.DrawMesh(_glyphMesh,Matrix4x4.identity,_pointMaterial,0);
		Graphics.DrawMeshInstancedIndirect(_glyphMesh,0,canvasMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)),argsBuffer);

	}
}
}

