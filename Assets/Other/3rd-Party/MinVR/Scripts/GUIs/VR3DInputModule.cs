using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// only works with world space canvas
// this code is based on Google Cardboard SDK's GazeInputModule.cs and Occulus Rift SDK's OVRInputModule.cs.
namespace UnityEngine.EventSystems
{
	[AddComponentMenu("MinVR/Events/VR 3D Input Module")]
	public class VR3DInputModule : BaseInputModule 
	{
		[Tooltip("3D Input which points with Z-axis. e.g. StylusRed, StylusBlue, or Head.")]
		public Transform threeDimInput;
		[Tooltip("Optional object to place at raycast intersections as a 3D cursor. " +
			"Be sure it is on a layer that raycasts will ignore OR disable the collider.")]
		public GameObject cursor;

		/// Time in seconds between the pointer down and up events sent by a magnet click.
		/// Allows time for the UI elements to make their state transitions.
		[HideInInspector]
		public float clickTime = 0.1f;  // Based on default time for a button to animate to Pressed.

		/// The pixel through which to cast rays, in viewport coordinates.  Generally, the center
		/// pixel is best, assuming a monoscopic camera is selected as the `Canvas`' event camera.
		[HideInInspector]
		public Vector2 hotspot = new Vector2(0.5f, 0.5f);

		// If cursor is to be shown, whether to scale its size in order to appear the same size visually regardless of its distance.
		// public bool scaleCursorSize = true;

		private PointerEventData pointerData;
		private Vector2 lastHeadPose;

		private bool isButtonDown = false; // true during the frame the user pressed the given button.
		private bool isButtonPressed = false; // true if the given button is held down.

		public void SetGazeButtonPressed() {
			this.isButtonDown = true;
			this.isButtonPressed = true;
		}

		public void SetGazeButtonReleased() {
			this.isButtonDown = false;
			this.isButtonPressed = false;
		}

		public override bool ShouldActivateModule() {
			return base.ShouldActivateModule();
		}

		public override void DeactivateModule() {
			base.DeactivateModule();
			if (pointerData != null) {
				HandlePendingClick();
				HandlePointerExitAndEnter(pointerData, null);
				pointerData = null;
			}
			eventSystem.SetSelectedGameObject(null, GetBaseEventData());
			if (cursor != null) {
				cursor.SetActive(false);
			}
		}

		public override bool IsPointerOverGameObject(int pointerId) {
			return pointerData != null && pointerData.pointerEnter != null;
		}

		public override void Process() {
			CastRayFromGaze();
			UpdateCurrentObject();
			PlaceCursor();

			if (!this.isButtonDown && this.isButtonPressed) { 
				// the button has been pressed since the last frame
				HandleDrag();
			} else if (Time.unscaledTime - pointerData.clickTime < clickTime) { // TODO do we need this?
				// Delay new events until clickTime has passed.
			} else if (!pointerData.eligibleForClick && this.isButtonDown) {
				// New trigger action.
				HandleTrigger();
			} else if (!this.isButtonPressed) { 
				// Check if there is a pending click to handle.
				HandlePendingClick();
			}

			// The next frame is not the frame the button was down. 
			if (this.isButtonDown) {
				this.isButtonDown = false;
			}
		}
	
		/// <summary>
		/// Casts the ray from where the 3D input object is looking at.
		/// </summary>
		private void CastRayFromGaze() {
			// pointerData.delta is used for checking if the user is dragging. 
			// pointerData.delta is a Vector2. We convert the cartesian to a spherical coordiate and use its polar and elvation angular values for the delta.
			// This means that we track the angular change instead of pixel coordinate change, used in a traditional Unity Input modules (e.g. StandaloneInputModule.cs).
			// This is only way to track if the 3D input has moves unless we extend PointerEvenetData to work with 3d position.
			// In our case, the pixel coordinate does not change, since the camera attached to the input device moves with the 3D input device. 
			Vector2 headPose = NormalizedCartesianToSpherical(threeDimInput.rotation * Vector3.forward);

			if (pointerData == null) {
				pointerData = new PointerEventData(eventSystem);
				lastHeadPose = headPose;
			}

			pointerData.Reset();
			// IMPORTANT!! we assume the view port rect of the camera attached to the 3d input object is (0,0,1,1).
			pointerData.position = new Vector2(hotspot.x * Screen.width, hotspot.y * Screen.height);
			eventSystem.RaycastAll(pointerData, m_RaycastResultCache);
			pointerData.pointerCurrentRaycast = FindFirstRaycast(m_RaycastResultCache);
			m_RaycastResultCache.Clear();
			pointerData.delta = headPose - lastHeadPose;
			lastHeadPose = headPose;
		}

		private void UpdateCurrentObject() {
			// Send enter events and update the highlight.
			var go = pointerData.pointerCurrentRaycast.gameObject;
			HandlePointerExitAndEnter(pointerData, go);
			// Update the current selection, or clear if it is no longer the current object.
			var selected = ExecuteEvents.GetEventHandler<ISelectHandler>(go);
			if (selected == eventSystem.currentSelectedGameObject) {
				ExecuteEvents.Execute(eventSystem.currentSelectedGameObject, GetBaseEventData(), ExecuteEvents.updateSelectedHandler);
			}
			else {
				eventSystem.SetSelectedGameObject(null, pointerData);
			}
		}

		/// <summary>
		/// Places the cursor, if the cursor object is assigned and a raycast has occured. 
		/// </summary>
		private void PlaceCursor() {
			if (cursor == null) {
				return;
			}
			var go = pointerData.pointerCurrentRaycast.gameObject;
			Camera cam = pointerData.enterEventCamera;  // Will be null for overlay hits.
			cursor.SetActive(go != null && cam != null);
			if (cursor.activeInHierarchy) {
                // Note: rays through screen start at near clipping plane.
                //float dist = pointerData.pointerCurrentRaycast.distance + cam.nearClipPlane
                float dist = pointerData.pointerCurrentRaycast.distance;
                cursor.transform.position = cam.transform.position + cam.transform.forward * dist;
				//if (scaleCursorSize) {
				//	cursor.transform.localScale = Vector3.one * dist;
				//}
			}
		}

		// this is execatly the same as ProcessDrag(PointerEventData pointerEvent) in PointerInputModule.cs,
		// except for there is no check for ShouldStartDrag(...), which uses a threshold. 
		private void HandleDrag() {
			bool moving = pointerData.IsPointerMoving();

			if (moving && pointerData.pointerDrag != null && !pointerData.dragging) {
				ExecuteEvents.Execute(pointerData.pointerDrag, pointerData, ExecuteEvents.beginDragHandler);
				pointerData.dragging = true;
			}

			// Drag notification
			if (pointerData.dragging && moving && pointerData.pointerDrag != null) {
				// Before doing drag we should cancel any pointer down state and clear selection!
				if (pointerData.pointerPress != pointerData.pointerDrag) {
					ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerUpHandler);

					pointerData.eligibleForClick = false;
					pointerData.pointerPress = null;
					pointerData.rawPointerPress = null;
				}
				ExecuteEvents.Execute(pointerData.pointerDrag, pointerData, ExecuteEvents.dragHandler);
			}
		}

		// similar to ProcessMousePress(MouseButtonEventData data) PointerUp notification part in StandalonInputModule.cs
		private void HandlePendingClick() {
			if (!pointerData.eligibleForClick) {
				return;
			}
			var go = pointerData.pointerCurrentRaycast.gameObject;

			// Send pointer up and click events.
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerUpHandler);
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerClickHandler);

			if (pointerData.pointerDrag != null) {
				ExecuteEvents.ExecuteHierarchy(go, pointerData, ExecuteEvents.dropHandler);
			}

			if (pointerData.pointerDrag != null && pointerData.dragging) {
				ExecuteEvents.Execute(pointerData.pointerDrag, pointerData, ExecuteEvents.endDragHandler);
			}

			// Clear the click state.
			pointerData.pointerPress = null;
			pointerData.rawPointerPress = null;
			pointerData.eligibleForClick = false;
			pointerData.clickCount = 0;
			pointerData.pointerDrag = null;
			pointerData.dragging = false;
		}

		// similar to ProcessMousePress(MouseButtonEventData data) PointerDown notification part in StandalonInputModule.cs
		private void HandleTrigger() {
			var go = pointerData.pointerCurrentRaycast.gameObject;

			// Send pointer down event.
			// search for the control that will receive the press.
			// if we can't find a press handler, set the press, handler to be what would receive a click.
			pointerData.pressPosition = pointerData.position;
			pointerData.pointerPressRaycast = pointerData.pointerCurrentRaycast;
			pointerData.pointerPress =
				ExecuteEvents.ExecuteHierarchy(go, pointerData, ExecuteEvents.pointerDownHandler)
				?? ExecuteEvents.GetEventHandler<IPointerClickHandler>(go);

			// Save the drag handler as well
			pointerData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(go);
			if (pointerData.pointerDrag != null) {
				ExecuteEvents.Execute(pointerData.pointerDrag, pointerData, ExecuteEvents.initializePotentialDrag);
			}

			// Save the pending click state.
			pointerData.rawPointerPress = go;
			pointerData.eligibleForClick = true;
			pointerData.delta = Vector2.zero;
			pointerData.dragging = false;
			pointerData.useDragThreshold = true;
			pointerData.clickCount = 1;
			pointerData.clickTime = Time.unscaledTime;
		}

		/// <summary>
		/// Convert the normalized cartesian coordinate to a spherical coordinate.
		/// </summary>
		/// <returns>The cartesian in a spherical coordinate.</returns>
		/// <param name="cartCoords">Cartesian coords.</param>
		private Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords) {
			cartCoords.Normalize();
			if (cartCoords.x == 0)
				cartCoords.x = Mathf.Epsilon;
			float outPolar = Mathf.Atan(cartCoords.z / cartCoords.x);
			if (cartCoords.x < 0)
				outPolar += Mathf.PI;
			float outElevation = Mathf.Asin(cartCoords.y);
			return new Vector2(outPolar, outElevation);
		}
	}
}