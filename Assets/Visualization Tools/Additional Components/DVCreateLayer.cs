using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



namespace DV
{
    [CustomEditor(typeof(DVCreateLayer))]
    public class DVCreateLayerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DVCreateLayer myScript = (DVCreateLayer)target;
            if (GUILayout.Button("Add Slice"))
            {
                myScript.AddNewDataSliceLayer();
            }
        }
    }


    public class DVCreateLayer : MonoBehaviour
    {

        public GameObject _root;
        public GameObject _dataSlicePrefab;
        public int _arrayID;
        // Use this for initialization
        void Start()
        {

        }

        public void AddNewDataSliceLayer()
        {
            if (_dataSlicePrefab)
            {
                GameObject dataSlice = Instantiate(_dataSlicePrefab);

                dataSlice.GetComponent<DVDataSliceLayer>()._dataObject = this.gameObject.GetComponent<DVDataObject>();
                dataSlice.GetComponent<DVDataSliceLayer>()._arrayId = _arrayID;
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