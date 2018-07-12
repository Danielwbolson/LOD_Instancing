using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SculptingVis {
[CreateAssetMenu()]
public class SimplePathLayer : Layer {

	[SerializeField]
	public DataVariable _anchorVariable;

	[SerializeField]
	public DataVariable _colorVariable;


	[SerializeField]
	public Texture2D _colorMap;

	[SerializeField]
	Material _lineMaterial;

	public override bool HasBounds() {
		return _anchorVariable!= null;
	}
	public override Bounds GetBounds() {
		return _anchorVariable.GetBounds();
	}

	public override void DrawLayer(Canvas canvas) {
		if(_anchorVariable == null) return;
		Datastream stream = _anchorVariable.GetStream(null,0,0);

		Mesh[] m = stream.GetMeshes();
		if(_colorVariable != null) {
			Texture3D tex = _colorVariable.GetStream(null,0,0).Get3DTexture();
			_lineMaterial.SetTexture("_ColorData",tex);
			_lineMaterial.SetInt("_HasColorVariable",1);
			_lineMaterial.SetMatrix("_DataBoundsMatrixInv",Matrix4x4.TRS(_colorVariable.GetBounds().center,Quaternion.identity,_colorVariable.GetBounds().size).inverse);

		} else {
			_lineMaterial.SetInt("_HasColorVariable",0);

		}
				_lineMaterial.SetTexture("_ColorMap",_colorMap);
		if(m != null && m.Length > 0) {
			for(int i = 0; i < Mathf.Min(m.Length,1000); i+=1) {
				Mesh mesh = m[i];
				if(mesh!= null) {
					Graphics.DrawMesh(mesh,canvas.GetInnerSceneTransformMatrix(),GetCanvasMaterial(canvas,_lineMaterial),0);

				}
			}
		}

	}
}
}

