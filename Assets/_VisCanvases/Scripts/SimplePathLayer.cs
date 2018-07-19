﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SculptingVis {
[CreateAssetMenu()]
public class SimplePathLayer : Layer {

	[SerializeField]
	public VariableSocket _anchorVariable;

	[SerializeField]
	public VariableSocket _colorVariable;


	[SerializeField]
	public Texture2D _colorMap;

	[SerializeField]
	Material _lineMaterial;


	public void Init() {
		_anchorVariable = CreateInstance<VariableSocket>();
		_anchorVariable.Init();
		_colorVariable = CreateInstance<VariableSocket>();
		_colorVariable.Init("Color",1);
		_colorVariable.SetAnchorVariable(_anchorVariable);
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



		Mesh[] m = stream.GetMeshes();
		// if(_colorVariable.IsAssigned()) {
		// 	Texture3D tex = _colorVariable.GetInput().GetStream(null,0,0).Get3DTexture();
		// 	_lineMaterial.SetTexture("_ColorData",tex);
		// 	_lineMaterial.SetInt("_HasColorVariable",1);
		// 	_lineMaterial.SetMatrix("_DataBoundsMatrixInv",Matrix4x4.TRS(_colorVariable.GetBounds().center,Quaternion.identity,_colorVariable.GetBounds().size).inverse);

		// } else {
		// 	_lineMaterial.SetInt("_HasColorVariable",0);

		// }
				_lineMaterial.SetTexture("_ColorMap",_colorMap);

		Material canvasMaterial = GetCanvasMaterial(canvas,_lineMaterial);
		_anchorVariable.Bind(canvasMaterial,0,0);
		_colorVariable.Bind(canvasMaterial,0,0);
		if(m != null && m.Length > 0) {
			for(int i = 0; i < Mathf.Min(m.Length,1000); i+=1) {
				Mesh mesh = m[i];
				if(mesh!= null) {
					Graphics.DrawMesh(mesh,canvas.GetInnerSceneTransformMatrix(),canvasMaterial,0);

				}
			}
		}

	}
}
}

