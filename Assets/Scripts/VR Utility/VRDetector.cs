using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;

public class VRDetector : MonoBehaviour
{
    // Use this for initialization
    public bool useVR;
    [Header("VR Settings")]
    public GameObject VR_Camera_Rig;
    public Camera VR_UI_Camera;
    public VR3DInputModule vrInputModule;
    [Header("Non-VR Settings")]
    public GameObject non_VR_Camera_Rig;
    public Camera non_UI_VR_Camera;
    public StandaloneInputModule standInputModule;
    [Header("UI Settings")]
    public Canvas[] canvases;

    private bool prevUseVrState;

    private void UpdateStates(bool useVR)
    {
        if (useVR)
        {
            // VR related
            {
                if (!this.VR_Camera_Rig.activeSelf)
                {
                    this.VR_Camera_Rig.SetActive(true);
                }
                if (!this.VR_UI_Camera.gameObject.activeSelf)
                {
                    this.VR_UI_Camera.gameObject.SetActive(true);
                }
                if (!this.vrInputModule.enabled)
                {
                    this.vrInputModule.enabled = true;
                }
            }
            // non VR related
            {
                if (this.non_VR_Camera_Rig.activeSelf)
                {
                    this.non_VR_Camera_Rig.SetActive(false);
                }
                if (this.non_UI_VR_Camera.gameObject.activeSelf)
                {
                    this.non_UI_VR_Camera.gameObject.SetActive(false);
                }
                if (this.standInputModule.enabled)
                {
                    this.standInputModule.enabled = false;
                }
            }
            // update teh canvas camera
            foreach (Canvas canvas in this.canvases)
            {
                canvas.worldCamera = this.VR_UI_Camera;
            }
        }
        else
        {
            // VR related
            {
                if (this.VR_Camera_Rig.activeSelf)
                {
                    this.VR_Camera_Rig.SetActive(false);
                }
                if (this.VR_UI_Camera.gameObject.activeSelf)
                {
                    this.VR_UI_Camera.gameObject.SetActive(false);
                }
                if (this.vrInputModule.enabled)
                {
                    this.vrInputModule.enabled = false;
                }
            }
            // non VR related
            {
                if (!this.non_VR_Camera_Rig.activeSelf)
                {
                    this.non_VR_Camera_Rig.SetActive(true);
                }
                if (!this.non_UI_VR_Camera.gameObject.activeSelf)
                {
                    this.non_UI_VR_Camera.gameObject.SetActive(true);
                }
                if (!this.standInputModule.enabled)
                {
                    this.standInputModule.enabled = true;
                }
            }
            // update teh canvas camera
            foreach (Canvas canvas in this.canvases)
            {
				if(canvas != null)
                	canvas.worldCamera = this.non_UI_VR_Camera;
            }
        }
    }


    private void Start()
    {
        if (XRDevice.isPresent)
        {
            print("Virtual Reality device present");
        }
        else
        {
            print("Virtual Reality device not present");
            this.useVR = false;
        }

        UpdateStates(this.useVR);

        this.prevUseVrState = this.useVR;
    }

    private void Update()
    {
        if (this.prevUseVrState != this.useVR)
        {
            this.UpdateStates(this.useVR);
            this.prevUseVrState = this.useVR;
        }
    }
}
