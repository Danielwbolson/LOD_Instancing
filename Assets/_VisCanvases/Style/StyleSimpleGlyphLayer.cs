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
        public StyleTypeSocket<Range<float>> _opacityThresholdInput;

        [SerializeField]
        public StyleTypeSocket<Colormap> _colorMapInput;

        [SerializeField]
        public StyleTypeSocket<Glyph> _glyphInput;

        [SerializeField]
        public StyleTypeSocket<Range<int>> _lodLevel;

        [SerializeField]
        public StyleTypeSocket<Range<int>> _maxGlyphs;

        [SerializeField]
        public StyleTypeSocket<Range<float>> _glyphScaleInput;

        [SerializeField]
        public StyleTypeSocket<Range<bool>> _useMeshInput;

        [SerializeField]
        public StyleTypeSocket<Range<bool>> _useThumbnailInput;
        [SerializeField]
        public StyleTypeSocket<Range<bool>> _faceCameraInput;

        [SerializeField]
        public StyleTypeSocket<Range<float>> _opacityMultiplierInput;

        [SerializeField]
        public StyleTypeSocket<Objectify<Color>> _colorInput;

        [SerializeField]
        public Material _pointMaterial;

        [SerializeField]
        public Mesh _billboardMesh;



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
            _pointMaterial.SetFloat("_glyphScale", (Range<float>)_glyphScaleInput.GetInput());
            _pointMaterial.SetInt("_useMesh", (Range<bool>)_useMeshInput.GetInput()?1:0);
            _pointMaterial.SetInt("_useThumbnail", (Range<bool>)_useThumbnailInput.GetInput()?1:0);
            _pointMaterial.SetColor("_Color", (Objectify<Color>)_colorInput.GetInput());
            _pointMaterial.SetFloat("_OpacityMultiplier", (Range<float>)_opacityMultiplierInput.GetInput());
            _pointMaterial.SetInt("_faceCamera", (Range<bool>)_faceCameraInput.GetInput()?1:0);
            _pointMaterial.SetFloat("_opacityThreshold", (Range<float>)_opacityThresholdInput.GetInput());




            {


                if (_glyphInput.GetInput() != null)
                    {
                         

                        if(argsBuffer == null) argsBuffer = new ComputeBuffer(1, args.Length * sizeof(uint), ComputeBufferType.IndirectArguments);

                        Mesh instanceMesh;
                        if(((Range<bool>)_useMeshInput.GetInput()) == true) {
                            instanceMesh = ((Glyph)(_glyphInput.GetInput())).GetLODMesh(((Range<int>)_lodLevel.GetInput()));
                            _pointMaterial.SetTexture("_BumpMap", ((Glyph)(_glyphInput.GetInput())).GetLODNormalMap(((Range<int>)_lodLevel.GetInput())));

                        }
                        else {
                            instanceMesh = _billboardMesh;
                            _pointMaterial.SetTexture("_BumpMap", Glyph.DefaultNormalMap());
                            if(((Range<bool>)_useThumbnailInput.GetInput()) == true) {
                                _pointMaterial.SetTexture("_MainTex", ((Glyph)(_glyphInput.GetInput())).GetPreviewImage());
                            }
                            _pointMaterial.SetTexture("_AlphaTex", ((Glyph)(_glyphInput.GetInput())).GetAlphaMap());

                        }

                        args[0] = (uint)instanceMesh.GetIndexCount(0);
                        args[1] = (uint)Mathf.Min((uint)stream.GetNumberOfElements(), (int)(Range<int>)_maxGlyphs.GetInput());
                        args[2] = (uint)instanceMesh.GetIndexStart(0);
                        args[3] = (uint)instanceMesh.GetBaseVertex(0);
                        argsBuffer.SetData(args);


                        Material canvasMaterial = GetCanvasMaterial(canvas, _pointMaterial);
                        _anchorVariable.Bind(_pointMaterial, 0, 0);
                        _colorVariable.Bind(_pointMaterial, 0, 0);
                        _opacityVariable.Bind(_pointMaterial, 0, 0);
                        _directionVariable.Bind(_pointMaterial, 0, 0);

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
                _billboardMesh = ((StyleSimpleGlyphLayer)toCopy)._billboardMesh;

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


            _opacityThresholdInput = (new StyleTypeSocket<Range<float>>()).Init("Opacity threshold", this);
            _opacityThresholdInput.SetDefaultInputObject((new Range<float>(0, 1, 0.5f)));
            AddSocket(_opacityThresholdInput);


            _directionVariable = new VariableSocket();
            _directionVariable.Init("Direction",this,2);
	        _directionVariable.SetAnchorVariableSocket(_anchorVariable);
			_directionVariable.RequireVector();

            AddSocket(_anchorVariable);
            AddSocket(_colorVariable);
            AddSocket(_opacityVariable);
            AddSocket(_directionVariable);

            _maxGlyphs = (new StyleTypeSocket<Range<int>>()).Init("Max glyphs", this);
            _maxGlyphs.SetDefaultInputObject((new Range<int>(0, 60000, 1000)));
            AddSocket(_maxGlyphs);

            _colorMapInput = (new StyleTypeSocket<Colormap> ()).Init("Color map",this);
            _glyphInput = (new StyleTypeSocket<Glyph> ()).Init("Glyph",this);

			AddSocket(_colorMapInput);
			AddSocket(_glyphInput);

            _lodLevel = (new StyleTypeSocket<Range<int>>()).Init("Glyph LOD", this);
            _lodLevel.SetDefaultInputObject((new Range<int>(0, 2,2)));
            AddSocket(_lodLevel);


            _glyphScaleInput = (new StyleTypeSocket<Range<float>>()).Init("Glyph scale", this);
            _glyphScaleInput.SetDefaultInputObject((new Range<float>(0, 10,1)));
            AddSocket(_glyphScaleInput);


            _useMeshInput = (new StyleTypeSocket<Range<bool>>()).Init("Use mesh", this);
            _useMeshInput.SetDefaultInputObject((new Range<bool>(false, true,true)));
            AddSocket(_useMeshInput);

            _useThumbnailInput = (new StyleTypeSocket<Range<bool>>()).Init("Use thumbnail", this);
            _useThumbnailInput.SetDefaultInputObject((new Range<bool>(false, true,false)));
            AddSocket(_useThumbnailInput);

            _faceCameraInput = (new StyleTypeSocket<Range<bool>>()).Init("FaceCamera", this);
            _faceCameraInput.SetDefaultInputObject((new Range<bool>(false, true,false)));
            AddSocket(_faceCameraInput);

            _opacityMultiplierInput = (new StyleTypeSocket<Range<float>>()).Init("Opacity mult", this);
            _opacityMultiplierInput.SetDefaultInputObject((new Range<float>(0,10,1)));
            AddSocket(_opacityMultiplierInput);

            _colorInput = (new StyleTypeSocket<Objectify<Color>>()).Init("GlyphColor", this);
            _colorInput.SetDefaultInputObject(new Objectify< Color>(Color.white));
            AddSocket(_colorInput);




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

