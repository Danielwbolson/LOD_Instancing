using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



namespace DV
{
    [CustomEditor(typeof(DVCreateRenderer))]
    public class DVCreateRendererEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DVCreateRenderer myScript = (DVCreateRenderer)target;
            if (GUILayout.Button("Add Slice"))
            {
                myScript.AddNewDataSliceRenderer();
            }
        }
    }


    public class DVCreateRenderer : MonoBehaviour
    {

        public GameObject _root;
        public GameObject _dataSlicePrefab;
        public int _arrayID;
        // Use this for initialization
        void Start()
        {

        }

        public void AddNewDataSliceRenderer()
        {
            if (_dataSlicePrefab)
            {
                GameObject dataSlice = Instantiate(_dataSlicePrefab);

                dataSlice.GetComponent<DVDataSliceRenderer>()._dataObject = this.gameObject.GetComponent<DVDataObject>();
                dataSlice.GetComponent<DVDataSliceRenderer>()._arrayId = _arrayID;
                if (_root)
                {
                    dataSlice.transform.SetParent(_root.transform, false);

                }
                print(gameObject.transform.position);
                dataSlice.transform.position = gameObject.transform.position;
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}