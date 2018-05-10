using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTK;

public class DataFilter : DataAlgorithm {

    vtkDataObject GetInput(int port = 0) {
        GameObject parent = transform.parent.gameObject;
        return (parent.GetComponent<DataAlgorithm>()).GetDataObject(port);

    }
	// Use this for initialization
	void Start () {
        algorithm_ = vtkThreshold.New();
        print("INPUT:" + GetInput());
        algorithm_.SetInputDataObject(0, GetInput());
        ProcessConnections();
        print(algorithm_.GetInputPortInformation(0).GetNumberOfKeys());
        //print(algorithm_.GetInputPortInformation(0))
	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
