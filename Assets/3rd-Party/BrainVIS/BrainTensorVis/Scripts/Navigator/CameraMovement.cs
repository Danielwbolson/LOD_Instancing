// mostly copied from Jibran I. Syed from https://jibransyed.wordpress.com/2013/02/22/rotating-panning-and-zooming-a-camera-in-unity/
// changed his code for a global movemement and work with x-z plane (works the best when there is somewhat ground plane to view);

using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
	public AnimationCurve speedCurve;  // to change the speed when the camera is close to 0 in y. 

	public float turnSpeed = 4.0f;		// Speed of camera turning when mouse moves in along an axis
	public float panSpeed = 2.0f;		// Speed of the camera when being panned
	public float zoomSpeed = 0.5f;		// Speed of the camera going back and forth

	private Vector3 mouseOrigin;	// Position of cursor when mouse dragging starts
	private bool isPanning;		// Is the camera being panned?
	private bool isRotating;	// Is the camera being rotated?
	private bool isZooming;		// Is the camera zooming?

	private Vector3 initPos;
	private Quaternion initRot;

	private int uiLayer;

	void Start() {
		this.initPos = transform.position;
		this.initRot = transform.rotation;

		this.uiLayer = LayerMask.NameToLayer("UI");
	}

	void Update () 
	{
		// Reset the camera
		if (Input.GetKeyDown(KeyCode.Space)) {
			transform.position = this.initPos;
			transform.rotation = this.initRot;
		}

		// Get the left mouse button
		if(Input.GetMouseButtonDown(0))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isRotating = true;
		}

		// Get the right mouse button
		if(Input.GetMouseButtonDown(1))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isPanning = true;
		}

		// Get the middle mouse button
		if(Input.GetMouseButtonDown(2))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isZooming = true;
		}

		// Disable movements on button release
		if (!Input.GetMouseButton(0)) isRotating=false;
		if (!Input.GetMouseButton(1)) isPanning=false;
		if (!Input.GetMouseButton(2)) isZooming=false;

		// Determine the speed factor, varied by how y position value is close to 0.
		float remapped = this.Remap(this.transform.position.y - 0f, 0f, 1.5f, 0f, 1f); // !!!!
		float speedFactor = this.speedCurve.Evaluate(remapped);
		if (speedFactor > this.speedCurve.keys[1].value) { // clamp to the max ASSUME the second key point is the max
			speedFactor = this.speedCurve.keys[1].value;
		}
		if (speedFactor < this.speedCurve.keys[0].value) { // clamp to the min ASSUME the first key point is the max
			speedFactor = this.speedCurve.keys[0].value;
		}

		// Rotate camera along X and world Y axis
		if (isRotating)
		{
			float speed = speedFactor * turnSpeed;

			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			transform.RotateAround(transform.position, transform.right, -pos.y * speed);
			transform.RotateAround(transform.position, Vector3.up, pos.x * speed);
		}

		// Move the camera on it's XZ plane
		if (isPanning)
		{
			float speed = speedFactor * panSpeed;

			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			Vector3 move = new Vector3(pos.x * speed, 0, pos.y * speed);
			move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * move;

			transform.Translate(move, Space.World);
		}

		// Move the camera linearly along world Y axis
		if (isZooming)
		{
			float speed = speedFactor * zoomSpeed;

			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

			Vector3 move = -pos.y * speed * Vector3.up; 
			transform.Translate(move, Space.World);
		}
	}

	public float Remap (float dataValue, float from0, float to0, float from1, float to1)
	{
		return from1 + (dataValue - from0) * (to1 - from1) / (to0 - from0);
	}
}