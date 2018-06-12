using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV
{

        [CustomEditor(typeof(DVDataGlyphLayer))]
    public class DVDataGlyphLayerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DVDataGlyphLayer myScript = (DVDataGlyphLayer)target;
            if (GUILayout.Button("Refresh Layer"))
            {
                myScript.RequestUpdate();
            }
        }
    }


    public class DVDataGlyphLayer : DVDataLayer
    {



		public bool _UseDirection;
        [Range(0,6)] public int _DirectionArray;
		public bool _UseMask;
		[Range(0,6)] public int _MaskArray;
		public bool _UseColor;
		[Range(0,6)] public int _ColorArray;
		public bool _UseTransparency;
		[Range(0,6)] public int _TransparencyArray;
        public GameObject [] _glyphMesh;

        private int _glyphMeshCountCached; 

        public Texture _MainTex;
        
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

            _material.SetInt("_UseDirection",_UseDirection?1:0);
            _material.SetInt("_DirectionArray",_DirectionArray);
            _material.SetInt("_UseColor",_UseColor?1:0);
            _material.SetInt("_ColorArray",_ColorArray);
            _material.SetInt("_UseMask",_UseMask?1:0);
            _material.SetInt("_MaskArray",_MaskArray);
            _material.SetInt("_UseTransparency",_UseTransparency?1:0);
            _material.SetInt("_TransparencyArray",_TransparencyArray);  

            _material.SetTexture("_MainTex",_MainTex);
            if(_samplingStrategyCached != _samplingStrategy) {
                RequestUpdate();
            }
            if(_renderingStrategy != _renderingStrategyCached) {
                RequestUpdate();
            }
            if(_glyphMeshCountCached != _glyphMesh.Length) {
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

            _glyphMeshCountCached = _glyphMesh.Length;
        }
    }
}