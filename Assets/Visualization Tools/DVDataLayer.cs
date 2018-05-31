using UnityEngine;
using System.Collections;

namespace DV
{
    public class DVDataLayer : MonoBehaviour
    {

        public DVLayerManager _layerManager;
        virtual public string GetName() {
            return "Undefined";
        }

        public DVDataObject GetData() {
            return _layerManager.GetData();
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


            _cachedDataObject = GetData();
            _needsUpdate = false;
        }

        virtual protected void RefreshDataSet() { }


        virtual protected void UpdateDataLayer() { }

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


            UpdateDataLayer();
        }
    }
}