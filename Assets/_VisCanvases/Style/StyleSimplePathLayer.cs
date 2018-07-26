using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	[CreateAssetMenu()]
	public class StyleSimplePathLayer : StyleLayer {



		[SerializeField]
		Bounds _boxBounds;

		[SerializeField]
		Mesh _boxMesh;

		[SerializeField]
		Material _boxMaterial;

		public override bool HasBounds() {
			return true;
		}
		public override Bounds GetBounds() {
			return _boxBounds;
		}

		public override void DrawLayer(Canvas canvas) {

			Graphics.DrawMesh(_boxMesh,canvas.GetInnerSceneTransformMatrix()*Matrix4x4.TRS(_boxBounds.center, Quaternion.identity, _boxBounds.size),GetCanvasMaterial(canvas,_boxMaterial),0);
		}


        public override StyleLayer CopyLayer(StyleLayer toCopy) {
			if(toCopy != null && toCopy is StyleTestLayer) {
				_boxMaterial = ((StyleTestLayer)toCopy)._boxMaterial;
				_boxMesh = ((StyleTestLayer)toCopy)._boxMesh;
				_boxBounds = ((StyleTestLayer)toCopy)._boxBounds;
			}

            return Init();
        }

        public StyleTestLayer Init() {


			VariableSocket anchor = CreateInstance<VariableSocket>().Init("Anchor",this,1);
			anchor.SetAnchorVariableSocket(null);
			AddSocket(anchor);
			VariableSocket vs = CreateInstance<VariableSocket>().Init("Data",this,1);
			vs.RequireScalar();
			vs.SetAnchorVariableSocket(anchor);
			AddSocket(vs);

            return this;
        }

        
		public override string GetLabel() {
			return "Simple Path Layer";
		}

	}
}

