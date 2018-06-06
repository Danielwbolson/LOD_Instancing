using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV
{
    public class DVDataGlyphLayer : DVDataLayer
    {

        public GameObject [] _glyphMesh;

        override public string GetName() {
            return "Glyph";
        }       
        public DVSampleStrategy _samplingStrategy;
        private DVSampleStrategy _samplingStrategyCached = null;

        public DVMeshFieldRenderingStrategy _renderingStrategy;
        private DVMeshFieldRenderingStrategy _renderingStrategyCached = null;

        // Use this for initialization
        void Start()
        {
            LockTransform();

        }

        private void OnDrawGizmos()
        {
            return;
            if (GetData() == null) return;

            Gizmos.matrix = GetData().transform.localToWorldMatrix;

            for (int i = 0; i < _samplingStrategy.GetNumberOfSamples(); i++)
            {
                //print(_strategy.GetSamples()[i].position);
                Gizmos.DrawSphere(_samplingStrategy.GetSamples()[i].position, 1);

            }
        }

        override protected void UpdateLayer() {
            if(_samplingStrategyCached != _samplingStrategy) {
                RequestUpdate();
            }
            if(_renderingStrategy != _renderingStrategyCached) {
                RequestUpdate();
            }
            DrawMeshes();
         }

        void PopulateMeshData() {
          

        } 

        void DrawMeshes() {
            _renderingStrategy.DrawMeshes();
        }
        override protected void RefreshDataSet()
        {
            _samplingStrategy.SetDataSet(GetData());
            _samplingStrategy.UpdateStrategy();
            _samplingStrategyCached = _samplingStrategy;
           
           _renderingStrategyCached = _renderingStrategy;
            _renderingStrategy.SetParent(GetData().transform);
            _renderingStrategy.SetMaterial(_material);
            _renderingStrategy.SetMeshes(_glyphMesh);
            _renderingStrategy.SetSamples(_samplingStrategy.GetSamples());
            _renderingStrategy.UpdateMeshData();

        }
    }
}