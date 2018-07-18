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
	public Texture2D _colorMap;

	[SerializeField]
	Material _pointMaterial;

	[SerializeField]
	Mesh _glyphMesh;


	[SerializeField]
	int instanceCount = 10000;

    private ComputeBuffer argsBuffer;
    private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };


	public void Init() {
		_anchorVariable = CreateInstance<VariableSocket>();
		_anchorVariable.Init(0);
		_colorVariable = CreateInstance<VariableSocket>();
		_colorVariable.Init(1);
		_colorVariable.SetAnchorVariable(_anchorVariable);
	
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

	public override void DrawLayer(Canvas canvas) {
		if(_anchorVariable == null || !_anchorVariable.IsAssigned()) return;
		Datastream stream = _anchorVariable.GetInput().GetStream(null,0,0);


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

		//Mesh[] m = stream.GetMeshes();

		_pointMaterial.SetTexture("_ColorMap",_colorMap);

		Material canvasMaterial = GetCanvasMaterial(canvas,_pointMaterial);
		_anchorVariable.Bind(canvasMaterial,0,0);
		_colorVariable.Bind(canvasMaterial,0,0);
		// Graphics.DrawMesh(_glyphMesh,Matrix4x4.identity,_pointMaterial,0);
		Graphics.DrawMeshInstancedIndirect(_glyphMesh,0,canvasMaterial, new Bounds(Vector3.zero, new Vector3(100.0f, 100.0f, 100.0f)),argsBuffer);

	}
}
}

