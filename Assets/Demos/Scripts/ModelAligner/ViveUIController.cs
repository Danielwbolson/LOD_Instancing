using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace VisBySculpting
{
    public class ViveUIController : MonoBehaviour
    {

        public SteamVR_TrackedObject uiPointerTracker;
        public UnityEvent onPointerTriggerDown;
        public UnityEvent onPointerTriggerUp;

        //public SteamVR_TrackedObject uiHolderTracker;
        //public GameObject uiCanvas;


        void Update()
        {
            /*{ // for the ui holder
                SteamVR_Controller.Device device0 = this.GetDevice(this.uiHolderTracker);
                if (device0 != null && device0.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
                {
                    this.uiCanvas.gameObject.SetActive(true);
                }
                else if (device0 != null && device0.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
                {
                    this.uiCanvas.gameObject.SetActive(false);
                }
            }*/

            { // for the ui pointer
                SteamVR_Controller.Device device0 = this.GetDevice(this.uiPointerTracker);
                if (device0 != null && device0.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
                {
                    Debug.Log("down");
                    this.onPointerTriggerDown.Invoke();
                }
                else if (device0 != null && device0.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
                {
                    Debug.Log("up");
                    this.onPointerTriggerUp.Invoke();
                }
            }
        }

        private SteamVR_Controller.Device GetDevice(SteamVR_TrackedObject tracker)
        {
            int index = (int)tracker.index;

            return index == -1 ? null : SteamVR_Controller.Input((int)tracker.index);
        }
    }

}