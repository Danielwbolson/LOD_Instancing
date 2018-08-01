using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    [CreateAssetMenu()]
    public class StyleVolumeLayer : StyleLayer
    {
        [SerializeField]
        public VariableSocket _volumeVariable;



        public StyleTypeSocket<Colormap> _colorMapInput;
        public StyleTypeSocket<Colormap>  _opacityMapInput;


        [SerializeField]
        public Texture2D _colorMap;


        [SerializeField]
        public Texture2D _opacityMap;


        [SerializeField]
        Material _volumeMaterial;

        [SerializeField]
        Mesh _volumeCubeMesh;





        public override bool HasBounds()
        {
            return _volumeVariable != null && _volumeVariable.IsAssigned();
        }
        public override Bounds GetBounds()
        {
            return _volumeVariable.GetInput().GetBounds();
        }

        public override void DrawLayer(Canvas canvas)
        {
            if (_volumeVariable == null || !_volumeVariable.IsAssigned()) return;
            Datastream stream = _volumeVariable.GetInput().GetStream(null, 0, 0);



            if(_colorMap != null) _volumeMaterial.SetTexture("_ColorMap", _colorMap);
            if(_opacityMap != null) _volumeMaterial.SetTexture("_OpacityMap", _opacityMap);

            Material canvasMaterial = GetCanvasMaterial(canvas, _volumeMaterial);
            _volumeVariable.Bind(canvasMaterial, 0, 0);


            Graphics.DrawMesh(_volumeCubeMesh,canvas.GetInnerSceneTransformMatrix()*Matrix4x4.TRS(GetBounds().center,Quaternion.identity,GetBounds().size),canvasMaterial,0);


        }


        public override StyleLayer CopyLayer(StyleLayer toCopy)
        {
            if (toCopy != null && toCopy is StyleVolumeLayer)
            {
                _volumeMaterial = ((StyleVolumeLayer)toCopy)._volumeMaterial;
				 _colorMap = ((StyleVolumeLayer)toCopy)._colorMap;
				 _opacityMap = ((StyleVolumeLayer)toCopy)._opacityMap;

                _volumeCubeMesh = ((StyleVolumeLayer)toCopy)._volumeCubeMesh;

            }

            return Init();
        }

        public new StyleVolumeLayer Init()
        {

            //SetAnchorSocket(_anchorVariable);
            _volumeVariable = new VariableSocket();
            _volumeVariable.Init("Volume",this,1);
            _volumeVariable.SetAnchorVariableSocket(null);
			_volumeVariable.RequireScalar();


            AddSocket(_volumeVariable);
			_colorMapInput = (new StyleTypeSocket<Colormap> ()).Init("Color map",this);
            _opacityMapInput = (new StyleTypeSocket<Colormap> ()).Init("Opacity map",this);

			AddSocket(_colorMapInput);
			AddSocket(_opacityMapInput);

            return this;

        }

		public override void UpdateModule() {
			if(_colorMapInput.GetInput() != null && _colorMapInput.GetInput() is Colormap) {
				_colorMap = ((Colormap)_colorMapInput.GetInput()).GetTexture();
			}
			if(_opacityMapInput.GetInput() != null && _opacityMapInput.GetInput() is Colormap) {
				_opacityMap = ((Colormap)_opacityMapInput.GetInput()).GetTexture();
			}
		} 

        public override string GetLabel()
        {
            return "Volume Render Layer";
        }

    }
}

