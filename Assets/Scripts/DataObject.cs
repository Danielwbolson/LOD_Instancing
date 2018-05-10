using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using VTK;

public class DataObject : MonoBehaviour
{

    public vtkDataObject dataObject_;


    public void SetDataObject(vtkDataObject dataObject)
    {
        dataObject_ = dataObject;
    }

    public void RefreshChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            DataRenderer childDataRenderer = transform.GetChild(i).GetComponent<DataRenderer>();
            if (childDataRenderer)
            {
                if (dataObject_.IsA("vtkDataSet"))
                {
                    childDataRenderer.SetDataSet(vtkDataSet.SafeDownCast(dataObject_));
                    childDataRenderer.RefreshDataRenderer();
                }

            }
        }
    }

    public void RefreshDataObject() {
        print("Updating dataObject " + dataObject_);
        RefreshChildren();
    }
	void Start ()
	{
	
	}

    void Update() {
        
    }
}
