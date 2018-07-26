using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    [CreateAssetMenu()]
    public class StyleSimpleGlyphLayer : StyleLayer
    {



        [SerializeField]
        public VariableSocket _anchorVariable;

        [SerializeField]
        public VariableSocket _colorVariable;

        [SerializeField]
        public VariableSocket _directionVariable;

        [SerializeField]
        public VariableSocket _opacityVariable;


        [SerializeField]
        public StyleColormapSocket _colorMapInput;

        [SerializeField]
        public Texture2D _colorMap;

        [SerializeField]
        public Material _pointMaterial;

        [SerializeField]
        public Mesh _glyphMesh;

        [SerializeField]
        bool _sampleAtCenter = true;
        
   
	[SerializeField]
	public int instanceCount = 50000;


        private ComputeBuffer argsBuffer;
        private uint[] args = new uint[5] { 0, 0, 0, 0, 0 };

        public override bool HasBounds()
        {
            return _anchorVariable != null && _anchorVariable.IsAssigned();
        }
        public override Bounds GetBounds()
        {
            return _anchorVariable.GetInput().GetBounds();
        }

        public override void DrawLayer(Canvas canvas)
        {
           

        }


        public override StyleLayer CopyLayer(StyleLayer toCopy)
        {
            if (toCopy != null && toCopy is StyleSimpleGlyphLayer)
            {
                _pointMaterial = ((StyleSimpleGlyphLayer)toCopy)._pointMaterial;
                instanceCount = ((StyleSimpleGlyphLayer)toCopy).instanceCount;
				 _colorMap = ((StyleSimpleGlyphLayer)toCopy)._colorMap;

            }

            return Init();
        }

        public StyleSimpleGlyphLayer Init()
        {
            _anchorVariable = CreateInstance<VariableSocket>();
            _anchorVariable.Init("Anchor",this);
            //SetAnchorSocket(_anchorVariable);
            _colorVariable = CreateInstance<VariableSocket>();
            _colorVariable.Init("Color",this,1);
            _colorVariable.SetAnchorVariableSocket(_anchorVariable);
			_colorVariable.RequireScalar();

            _opacityVariable = CreateInstance<VariableSocket>();
            _opacityVariable.Init("Opacity",this,3);
	        _opacityVariable.SetAnchorVariableSocket(_anchorVariable);
			_opacityVariable.RequireScalar();

            AddSocket(_anchorVariable);
            AddSocket(_colorVariable);
            AddSocket(_opacityVariable);
			_colorMapInput = (StyleColormapSocket)CreateInstance<StyleColormapSocket>().Init("Color map",this,true,false);
			AddSocket(_colorMapInput);

            return this;

        }

		public override void UpdateModule() {
			if(_colorMapInput.GetTexture() != null) {
				_colorMap = (Texture2D)_colorMapInput.GetTexture();
			}
		}

        public override string GetLabel()
        {
            return "Simple Glyph Layer";
        }

    }
}
