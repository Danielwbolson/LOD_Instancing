using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV
{
    public class DVDataGlyphLayer : DVDataLayer
    {
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
            if (GetData() == null) return;

            Gizmos.matrix = GetData().transform.localToWorldMatrix;

            for (int i = 0; i < _strategy.GetNumberOfSamples(); i++)
            {
                //print(_strategy.GetSamples()[i].position);
                Gizmos.DrawSphere(_strategy.GetSamples()[i].position, 1);

            }
        }
        override protected void RefreshDataSet()
        {
            _strategy.SetDataSet(GetData());
            _strategy.UpdateStrategy();

        }

    }
}