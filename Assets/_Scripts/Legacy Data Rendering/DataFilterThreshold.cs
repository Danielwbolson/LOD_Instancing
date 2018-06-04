//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using VTK;
//using UnityEditor;



//[CustomEditor(typeof(DataFilterThreshold))]
//public class ThresholdEditor : Editor
//{
//    public override void OnInspectorGUI()
//    {
//        DrawDefaultInspector();

//        DataFilterThreshold myScript = (DataFilterThreshold)target;
//        if (GUILayout.Button("Update Filter"))
//        {
//            myScript.RefreshAlgorithm();
//        }
//    }
//}




//public class DataFilterThreshold : DataFilter {

//    public double minLimit = 0;
//    public double maxLimit = 100;

//    vtkThreshold threshold;

//    public void setMinLimit(float m) {
//        minLimit = m;
//        RefreshAlgorithm();
//    }
//    public void setMaxLimit(float m) {
//        maxLimit = m;
//        RefreshAlgorithm();


//    }
//	// Use this for initialization
//	void Start () {
//        threshold = vtkThreshold.New();

//        algorithm_ = threshold;
//        print("INPUT:" + GetInput());
//        algorithm_.SetInputDataObject(0, GetInput());
//        ProcessConnections();
//        print(algorithm_.GetInputPortInformation(0).GetNumberOfKeys());
//        //  32 thresh.ThresholdBetween(0.25, 0.75)
//        //  33 thresh.SetInputArrayToProcess(1, 0, 0, 0, "thickness9")
//        RefreshAlgorithm();
//        //print(algorithm_.GetInputPortInformation(0))
//	}
//    public void RefreshAlgorithm()
//    {
//        threshold.ThresholdBetween(minLimit, maxLimit);
//        threshold.SetInputArrayToProcess(0, 0, 0, 0, inputArrays[0]);
//        base.RefreshAlgorithm();

//    }
//	// Update is called once per frame
//	void Update () {


//	}
//}
