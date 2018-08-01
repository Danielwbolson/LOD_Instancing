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
        public StyleTypeSocket<Colormap> _colorMapInput;

        [SerializeField]
        public StyleTypeSocket<Glyph> _glyphInput;

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
            _anchorVariable = new VariableSocket();
            _anchorVariable.Init("Anchor",this);
            //SetAnchorSocket(_anchorVariable);
            _colorVariable = new VariableSocket();
            _colorVariable.Init("Color",this,1);
            _colorVariable.SetAnchorVariableSocket(_anchorVariable);
			_colorVariable.RequireScalar();

            _opacityVariable = new VariableSocket();
            _opacityVariable.Init("Opacity",this,3);
	        _opacityVariable.SetAnchorVariableSocket(_anchorVariable);
			_opacityVariable.RequireScalar();

            AddSocket(_anchorVariable);
            AddSocket(_colorVariable);
            AddSocket(_opacityVariable);
			_colorMapInput = (new StyleTypeSocket<Colormap> ()).Init("Color map",this);
            _glyphInput = (new StyleTypeSocket<Glyph> ()).Init("Glyph",this);

			AddSocket(_colorMapInput);
			AddSocket(_glyphInput);

            return this;

        }

		public override void UpdateModule() {
			if(_colorMapInput.GetInput() != null && _colorMapInput.GetInput() is Colormap) {
				_colorMap = ((Colormap)_colorMapInput.GetInput()).GetTexture();
			}
		}

        public override string GetLabel()
        {
            return "Simple Glyph Layer";
        }

    }
}

