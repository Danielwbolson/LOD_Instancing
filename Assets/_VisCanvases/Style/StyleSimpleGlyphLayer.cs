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
        public StyleTypeSocket<IntRange> _lodLevel;

        [SerializeField]
        public Material _pointMaterial;



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
            if (_anchorVariable == null || !_anchorVariable.IsAssigned()) return;
            Datastream stream = _anchorVariable.GetInput().GetStream(null, 0, 0);




            if (_colorMapInput.GetInput() != null)
                _pointMaterial.SetTexture("_ColorMap", ((Colormap)_colorMapInput.GetInput()).GetTexture());
            _pointMaterial.SetFloat("_glyphScale", 0.5f);

            Material canvasMaterial = GetCanvasMaterial(canvas, _pointMaterial);
            _anchorVariable.Bind(_pointMaterial, 0, 0);
            _colorVariable.Bind(_pointMaterial, 0, 0);
            _opacityVariable.Bind(_pointMaterial, 0, 0);

            {


                    if (_glyphInput.GetInput() != null)
                    {
                        if(argsBuffer == null) argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);

                        Mesh instanceMesh = ((Glyph)(_glyphInput.GetInput())).GetLODMesh(((IntRange)_lodLevel.GetInput()));
                        args[0] = (uint)instanceMesh.GetIndexCount(0);
                        args[1] = (uint)stream.GetNumberOfElements();
                        args[2] = (uint)instanceMesh.GetIndexStart(0);
                        args[3] = (uint)instanceMesh.GetBaseVertex(0);
                        argsBuffer.SetData(args);

                        //Graphics.DrawMesh(instanceMesh, canvas.GetInnerSceneTransformMatrix(), canvasMaterial, 0);
                        Graphics.DrawMeshInstancedIndirect(instanceMesh, 0, canvasMaterial, new Bounds(new Vector3(0, 0, 0), new Vector3(300, 300, 300)),argsBuffer);

                }

            }

        }


        public override StyleLayer CopyLayer(StyleLayer toCopy)
        {
            if (toCopy != null && toCopy is StyleSimpleGlyphLayer)
            {
                _pointMaterial = ((StyleSimpleGlyphLayer)toCopy)._pointMaterial;
                instanceCount = ((StyleSimpleGlyphLayer)toCopy).instanceCount;

            }

            return Init();
        }

        public StyleSimpleGlyphLayer Init()
        {
            _anchorVariable = new VariableSocket();
            _anchorVariable.Init("Anchor",this,0);
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

            _lodLevel = (new StyleTypeSocket<IntRange>()).Init("Glyph LOD", this);
            _lodLevel.SetDefaultInputObject((new IntRange(0, 2,2)));
            AddSocket(_lodLevel);


            return this;

        }

		public override void UpdateModule() {
            base.UpdateModule();

		}

        public override string GetLabel()
        {
            //  if(_anchorVariable.GetInput() != null && ((Variable)_anchorVariable.GetInput())!=null)
            // Debug.Log("Custom Output:" + ((Variable)_anchorVariable.GetInput()).GetStream(null,0,0).GetNumberOfElements());
         
            return "Simple Glyph Layer";
        }

    }
}

