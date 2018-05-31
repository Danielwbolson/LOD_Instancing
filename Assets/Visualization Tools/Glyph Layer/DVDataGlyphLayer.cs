using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV
{
    public class DVDataGlyphLayer : DVDataLayer
    {

        public Mesh _glyphMesh;

        override public string GetName() {
            return "Glyph";
        }       
        public DVSampleStrategy _strategy;

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

            for (int i = 0; i < _strategy.GetNumberOfSamples(); i++)
            {
                //print(_strategy.GetSamples()[i].position);
                Gizmos.DrawSphere(_strategy.GetSamples()[i].position, 1);

            }
        }

        public GameObject _GlyphPrefab;
        public Material _GlyphMaterial;
        List<GameObject> _glyphs;


        override protected void RefreshDataSet()
        {
            _strategy.SetDataSet(GetData());
            _strategy.UpdateStrategy();
            if(_glyphs == null) _glyphs = new  List<GameObject>();
            foreach(var glyph in _glyphs) {
                Destroy(glyph);
            }
            _glyphs.Clear();

            for(int i =0; i < _strategy.GetNumberOfSamples(); i++) {
                GameObject glyph = Instantiate(_GlyphPrefab);
                glyph.GetComponent<MeshFilter>().mesh = _glyphMesh;
                glyph.GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().material;
                glyph.transform.SetParent(GetData().transform,false);
                glyph.transform.localScale = new Vector3(1,1,1)*1.0f/_glyphMesh.bounds.size.y*4;
                glyph.transform.localPosition = _strategy.GetSamples()[i].position;
            }
        }
    }
}