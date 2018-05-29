//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;
//using VTK;

//public class DataAlgorithm : MonoBehaviour {
//    //[Serializable]
//    //public class Input {
//    //    public vtkDataObject[] connections;

//    //}
//    //public Input[] inputPorts;


//    protected vtkAlgorithm algorithm_;
//    public DataAlgorithm() {
//        algorithm_ = IntPtr.Zero;
//    }
//	// Use this for initialization
//	void Start () {
//    }
//    //[ExecuteInEditMode]
//    //public void OnGUI() {
//    //    print("GUI");
//    //}
//    public vtkDataObject GetDataObject(int port = 0) {
//        if (algorithm_.IsVoid())
//            return IntPtr.Zero;
//        return algorithm_.GetOutputDataObject(port);
//    }

//    public void SetInputAlgorithm(vtkAlgorithm algorithm) {

//        if (!algorithm_.IsVoid())
//            algorithm_.SetInputConnection(algorithm.GetOutputPort());

//    }

//    public void RefreshChildren() {
//        for (int i = 0; i < transform.childCount; i++) {
//            DataAlgorithm childDataAlgorithm = transform.GetChild(i).GetComponent<DataAlgorithm>();
//            if(childDataAlgorithm) {
//                childDataAlgorithm.SetInputAlgorithm(algorithm_);
//                childDataAlgorithm.RefreshAlgorithm();
//            }
//            DataObject childDataObject = transform.GetChild(i).GetComponent<DataObject>();
//            if (childDataObject)
//            {
//                childDataObject.SetDataObject(algorithm_.GetOutputDataObject(0));
//                childDataObject.RefreshDataObject();
//            }
//        }
//    }
//    public void RefreshAlgorithm() {
//        algorithm_.Update();
//        print("Updating " + algorithm_);
//        RefreshChildren();
//    }
//    public void ProcessConnections() {
//        //if (!algorithm_.IsVoid())
//        //{
//        //    if (inputPorts.Length != algorithm_.GetNumberOfInputPorts())
//        //    {
//        //        inputPorts = new Input[algorithm_.GetNumberOfInputPorts()];

//        //    }

//        //    for (int i = 0; i < algorithm_.GetNumberOfInputPorts(); i++)
//        //    {
//        //        if (inputPorts[i] == null)
//        //            inputPorts[i] = new Input();
//        //        if (inputPorts[i].connections == null || inputPorts[i].connections.Length != algorithm_.GetNumberOfInputConnections(i))
//        //        {
//        //            inputPorts[i].connections = new vtkDataObject[algorithm_.GetNumberOfInputConnections(i)];

//        //        }

//        //        for (int j = 0; j < algorithm_.GetNumberOfInputConnections(i); j++) {
//        //            inputPorts[i].connections[j] = algorithm_.GetInputDataObject(i, j);
//        //        }
//        //    }
//        //}
//    }
//	// Update is called once per frame
//	void Update () {
//        //print(algorithm_);
//        //print(algorithm_.GetNumberOfInputPorts() + " ports");
       
            
//	}
//}
