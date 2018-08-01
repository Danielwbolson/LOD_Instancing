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
	public Material _pointMaterial;

	[SerializeField]
	public Mesh _glyphMesh;


	
	[SerializeField]
	bool _sampleAtCenter = true;

	[SerializeField]
	public float GlyphScale = 4;


	[SerializeField]
	public int instanceCount = 50000;

    private ComputeBuffer argsBuffer;
    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

	
	public void Init() {
		ClearSockets();
		_anchorVariable = new VariableSocket();
		//_anchorVariable.Init();
		SetAnchorSocket(_anchorVariable);

		_colorVariable = new VariableSocket();
		//_colorVariable.Init("Color",1);
		_colorVariable.RequireScalar();
		_colorVariable.SetAnchorVariableSocket(_anchorVariable);

		_directionVariable = new VariableSocket();
		//_directionVariable.Init("Direction",2);
		_directionVariable.RequireVector();
		_directionVariable.SetAnchorVariableSocket(_anchorVariable);

		_opacityVariable = new VariableSocket();
		//_opacityVariable.Init("Opacity",3);
		_opacityVariable.RequireScalar();
		_opacityVariable.SetAnchorVariableSocket(_anchorVariable);

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
            args[1] = (uint)System.Math.Min((uint)stream.GetTopologyArray().Length,instanceCount);
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
		_pointMaterial.SetFloat("_glyphScale", GlyphScale );
		if(cellAndPointIndexBuffer == null) {
			cellAndPointIndexBuffer = new ComputeBuffer((int)args[1],sizeof(int)*2);
			Vector2Int [] cellAndPointIndexArray = new Vector2Int[args[1]];
			for(int i = 0; i < args[1];i++) {
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

