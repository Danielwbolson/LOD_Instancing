using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    public GameObject laserPrefab;
    private GameObject laser;
    private Transform laserTransform;
    private Vector3 hitPoint;

    void Awake() {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void Start() {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;
    }

    // Show our laser, lerp it between the origin and the hit point so it is halfway, 
    // rotate it so that it is aimed at the hitpoint, and finally scale it to fit
    private void ShowLaser(RaycastHit hit) {
        laser.SetActive(true);
        laserTransform.position = Vector3.Lerp(trackedObj.transform.position, hitPoint, 0.5f);
        laserTransform.LookAt(hitPoint);
        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y, hit.distance);
    }

    // Update is called once per frame
    void Update () {
		if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad)) {
            RaycastHit hit;

            if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100)) {
                hitPoint = hit.point;
                ShowLaser(hit);
            } // else {
                // laser.SetActive(false);
            // }
        } else {
            laser.SetActive(false);
        }
	}
}
