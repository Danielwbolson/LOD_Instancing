using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    public class StyleLayer : StyleModule
    {
        [HideInInspector]
        public bool _toggled = true;

        [SerializeField]
        protected ComputeBuffer _planeBuffer;
        public List<StylePlane> _planes;

        [SerializeField]
        protected int _planeCount;

        [SerializeField]
        protected Material _layerMaterial;


        public StyleLayer Init()
        {
            return this;
        }


        public override string GetLabel()
        {
            return "Layer";
        }

        public virtual bool HasBounds()
        {
            return false;
        }
        public virtual Bounds GetBounds()
        {
            return new Bounds();
        }

        public virtual void DrawLayer(Canvas canvas)
        {

        }


        [SerializeField, HideInInspector]
        Dictionary<Canvas, Material> _canvasMaterials;

        protected Material GetCanvasMaterial(Canvas canvas, Material layerMaterial)
        {
            if (layerMaterial == null)
            {
                Debug.LogError("Style Material is null");
                return null;
            }
            if (_canvasMaterials == null)
                _canvasMaterials = new Dictionary<Canvas, Material>();
            Material canvasMaterial;

            if (!_canvasMaterials.ContainsKey(canvas) || _canvasMaterials[canvas] == null)
                canvasMaterial = (_canvasMaterials[canvas] = Instantiate(layerMaterial));
            else
                canvasMaterial = _canvasMaterials[canvas];

            canvasMaterial.CopyPropertiesFromMaterial(layerMaterial);
            canvas.SetMaterialProperties(canvasMaterial);
            return canvasMaterial;
        }

        public virtual StyleLayer CopyLayer(StyleLayer toCopy) {
            return this;
        }

        public void AddPlane(StylePlane p) {
            _planes.Add(p);

            _planeBuffer = new ComputeBuffer(_planes.Count, 6 * sizeof(float));
            _planeBuffer.SetData(_planes);
            _layerMaterial.SetBuffer("_Planes", _planeBuffer);
        }

        public void RemovePlane(StylePlane p) {
            _planes.Remove(p);

            _planeBuffer = new ComputeBuffer(_planes.Count, 6 * sizeof(float));
            _planeBuffer.SetData(_planes);
            _layerMaterial.SetBuffer("_Planes", _planeBuffer);
        }
    }
}

