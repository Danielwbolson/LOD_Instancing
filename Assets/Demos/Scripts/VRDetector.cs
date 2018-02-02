using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;

public class VRDetector : MonoBehaviour
{
    public Camera VR_Camera;
    public Camera VR_UI_Camera;
    public Camera non_VR_Camera;
    // Use this for initialization
    public bool useVR;

    public VR3DInputModule vrInputModule;
    public StandaloneInputModule standInputModule;

    public Canvas[] canvases;


    private void UpdateStates(bool useVR)
    {
        if (useVR)
        {
            this.VR_Camera.gameObject.SetActive(true);
            this.VR_UI_Camera.gameObject.SetActive(true);
            this.non_VR_Camera.gameObject.SetActive(false);

            this.vrInputModule.enabled = true;
            this.standInputModule.enabled = false;

            foreach (Canvas canvas in this.canvases)
            {
                canvas.worldCamera = this.VR_UI_Camera;
            }
        }
        else
        {
            this.VR_Camera.gameObject.SetActive(false);
            this.VR_UI_Camera.gameObject.SetActive(false);
            this.non_VR_Camera.gameObject.SetActive(true);

            this.vrInputModule.enabled = false;
            this.standInputModule.enabled = true;

            foreach (Canvas canvas in this.canvases)
            {
                canvas.worldCamera = this.non_VR_Camera;
            }
        }
    }


    void Start()
    {
        useVR = XRDevice.isPresent;
        if (useVR)
            print("Virtual Reality device present");
        else
            print("Virtual Reality device not present");

    }

    // Update is called once per frame
    void Update()
    {
        UpdateStates(this.useVR);
    }
}
