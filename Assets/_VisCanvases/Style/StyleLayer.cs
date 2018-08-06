using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    public class StyleLayer : StyleModule
    {
        [HideInInspector]
        public bool _toggled = true;

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
                Debug.LogError("Layer Material is null");
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

    }
}

