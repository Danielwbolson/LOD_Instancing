using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis
{
    /*
     * Refresh planes : Have layers directly listen to stylecontroller
     * Stylecontroller will tell them about planes
     */

    public struct Plane {
        public Vector3 _center;
        public Vector3 _normal;
    }

    public class StyleLayer : StyleModule
    {
        [HideInInspector]
        public bool _toggled = true;

        [SerializeField]
        protected ComputeBuffer _planeBuffer;
        public List<Plane> _planes;

        [SerializeField]
        protected int _planeCount;

        [SerializeField]
        protected Material _layerMaterial;

        [SerializeField]
        protected List<bool> _connectedPlanes;


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

        public void AddPlane() {
            if (_planes == null) {
                _planes = new List<Plane>();
                _planeCount = 0;
                _connectedPlanes = new List<bool>();
            }

            Plane plane = new Plane {
                _center = new Vector3(0, 0, 0),
                _normal = new Vector3(1, 0, 0)
            };

            _planes.Add(plane);
            _connectedPlanes.Add(true);

            _planeCount = _planes.Count;

            _planeBuffer = new ComputeBuffer(_planeCount, 6 * sizeof(float));
            _planeBuffer.SetData(_planes);
            _layerMaterial.SetBuffer("_Planes", _planeBuffer);
            _layerMaterial.SetInt("planesSize", _planeCount);
        }

        public void RemovePlane(Plane p) {
            int i = _planes.IndexOf(p);
            _planes.Remove(p);
            _planeCount = _planes.Count;
            _connectedPlanes.Remove(_connectedPlanes[i]);

            if (_planeCount > 0) {
                _planeBuffer = new ComputeBuffer(_planeCount, 6 * sizeof(float));
                _planeBuffer.SetData(_planes);
                _layerMaterial.SetBuffer("_Planes", _planeBuffer);
                _layerMaterial.SetInt("planesSize", _planeCount);
            } else {
                _layerMaterial.SetBuffer("_Planes", null);
                _layerMaterial.SetInt("planesSize", 0);
            }
}

        public List<bool> GetConnectedPlanes() {
            if (_connectedPlanes == null)
                _connectedPlanes = new List<bool>();

            return _connectedPlanes;
        }

        public void SetConnectedPlanes(List<bool> p) {
            _connectedPlanes = p;
            List<Plane> newPlanes = new List<Plane>();

            for (int i = 0; i < _planeCount; i++) {
                if (_connectedPlanes[i]) {
                    newPlanes.Add(_planes[i]);
                }
            }

            // Set our new planes
            if (newPlanes.Count > 0) {
                _planeBuffer = new ComputeBuffer(newPlanes.Count, 6 * sizeof(float));
                _planeBuffer.SetData(newPlanes);
                _layerMaterial.SetBuffer("_Planes", _planeBuffer);
                _layerMaterial.SetInt("planesSize", newPlanes.Count);
            } else {
                _layerMaterial.SetBuffer("_Planes", null);
                _layerMaterial.SetInt("planesSize", 0);
            }
        }
    }
}

