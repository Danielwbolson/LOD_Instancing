using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    [CreateAssetMenu()]
    public class StyleGlyphPreviewLayer : StyleLayer
    {



        [SerializeField]
        public StyleTypeSocket<Glyph> _glyphInput;

        [SerializeField]
        public StyleTypeSocket<IntRange> _lodLevel;

        [SerializeField]
        public Material _glyphMaterial;

        public int LODlevel = 0;



        public override bool HasBounds()
        {
            return _glyphInput.GetInput() != null;
        }
        public override Bounds GetBounds()
        {
            if(_glyphInput.GetInput() != null && ((Glyph)(_glyphInput.GetInput())).GetNumberOfLODs() > 0)
                return ((Glyph)(_glyphInput.GetInput())).GetLODMesh(0).bounds; 
            return new Bounds();
        }

        public override void DrawLayer(Canvas canvas)
        {
           


            if(_glyphInput.GetInput() != null && ((Glyph)(_glyphInput.GetInput())).GetNumberOfLODs() >= ((IntRange)_lodLevel.GetInput())+1)
            {
                _glyphMaterial.SetTexture("_BumpMap",((Glyph)(_glyphInput.GetInput())).GetLODNormalMap(((IntRange)_lodLevel.GetInput())));

                Material canvasMaterial = GetCanvasMaterial(canvas, _glyphMaterial);

                Graphics.DrawMesh(((Glyph)(_glyphInput.GetInput())).GetLODMesh(((IntRange)_lodLevel.GetInput())), canvas.GetInnerSceneTransformMatrix(), canvasMaterial, 0);
            }

        }


        public override StyleLayer CopyLayer(StyleLayer toCopy)
        {
            if (toCopy != null && toCopy is StyleGlyphPreviewLayer)
            {
                _glyphMaterial = ((StyleGlyphPreviewLayer)toCopy)._glyphMaterial;

            }

            return Init();
        }

        public StyleGlyphPreviewLayer Init()
        {
          
			_glyphInput = (new StyleTypeSocket<Glyph>()).Init("Glyph",this);
			AddSocket(_glyphInput);

			_lodLevel = (new StyleTypeSocket<IntRange>()).Init("Glyph LOD %",this);
            _lodLevel.SetDefaultInputObject((new IntRange(0,2)));
			AddSocket(_lodLevel);

            return this;

        }

		public override void UpdateModule() {

		}


        public override string GetLabel()
        {
            return "Glyph Preview Layer";
        }

    }
}

