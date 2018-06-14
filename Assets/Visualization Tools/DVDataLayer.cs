using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DV
{
    [ExecuteInEditMode]
    public class DVDataLayer : MonoBehaviour
    {

        public virtual void RenderGUI() {
        }
        public Material _material;

        // public DVLayerManager _layerManager;
        public Layer _layer;

        virtual public string GetName() {
            return "Undefined";
        }

        public DVDataObject GetData() {
            return _layer.GetData();
        }
        private DVDataObject _cachedDataObject = null;
        private bool _needsUpdate = false;

        protected void LockTransform()
        {
            //Tools.hidden = true;
            transform.hideFlags = HideFlags.NotEditable | HideFlags.HideInInspector;
        }
        protected void UnlockTransform()
        {
            //Tools.hidden = false;
            transform.hideFlags = HideFlags.None;
        }


        protected void RequestUpdate()
        {
            _needsUpdate = true;
        }

        private void _refreshDataSet()
        {
            // Call the virtual Refresh method
            RefreshDataSet();
            print("REFRESHING DATA SET");
            if(GetData() == null || GetData().GetDataSet() == null) return;
            if (GetData().GetDataSet().IsA("vtkImageData")) {
                _material.SetVector("_DataImageDimensions", GetData().GetImageDataDimensions());
                _material.SetTexture("_DataVolume0", GetData().GetImageDataTexture(0));
                _material.SetTexture("_DataVolume1", GetData().GetImageDataTexture(1));
                _material.SetTexture("_DataVolume2", GetData().GetImageDataTexture(2));
                _material.SetTexture("_DataVolume3", GetData().GetImageDataTexture(3));
                _material.SetTexture("_DataVolume4", GetData().GetImageDataTexture(4));
                _material.SetTexture("_DataVolume5", GetData().GetImageDataTexture(5));
                _material.SetTexture("_DataVolume6", GetData().GetImageDataTexture(6));
            }

            int numArrays = GetData().GetDataSet().GetPointData().GetNumberOfArrays();
            float [] mins = new float[numArrays];
            float [] maxes = new float[numArrays];

            for(int i = 0; i < numArrays; i++) {
                double [] range = GetData().GetRangeOfPointArrays(i,0);
                mins[i]= (float)range[0];
                maxes[i] = (float)range[1];

            }

            _material.SetFloatArray("_DataMin",mins);
            _material.SetFloatArray("_DataMax",maxes);

            _cachedDataObject = GetData();
            _needsUpdate = false;
        }

        virtual protected void RefreshDataSet() { }


        virtual protected void UpdateLayer() { }

        // Use this for initialization
        void Start() { }

        // Update is called once per frame
        void Update()
        {
            if (!GetData())
                return;

            if (_cachedDataObject != GetData())
                RequestUpdate();

            if (_needsUpdate)
                _refreshDataSet();





            _material.SetMatrix("_DataModelMatrix", GetData().transform.localToWorldMatrix);

            _material.SetMatrix("_DataModelMatrixInv", GetData().transform.worldToLocalMatrix);

            _material.SetMatrix("_DataBoundsMatrix", GetData().GetBoundsMatrix());

            _material.SetMatrix("_DataBoundsMatrixInv", GetData().GetBoundsMatrix().inverse);




            
            UpdateLayer();
        }
    }
}