using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using MinVR;

// This class allows you to use Unity's UI with vr tuio touches, vr touches, and vr mouses. 
// This input module class is responsible for the vr 2D inputs like tuio touches. 
// Check VRInputModule.cs for interacting Unity's UI with a 3D input device like a stylus.
//
// There is no fake inputs like the ones in TouchInputModule.cs; 
// if you wants to work in a debug mode (w/o connecting the server), 
// use VRFakeTracker.cs to generate a fake vr touch or vr mouse event. 
namespace UnityEngine.EventSystems
{
	[AddComponentMenu("MinVR/Events/VR Touch Input Module")]
	public class VRTouchInputModule : PointerInputModule {
		#region non-process methods
		protected VRTouchInputModule()
		{}

		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		private bool m_ForceModuleActive;

		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnStandalone
		{
			get { return m_ForceModuleActive; }
			set { m_ForceModuleActive = value; }
		}

		public bool forceModuleActive
		{
			get { return m_ForceModuleActive; }
			set { m_ForceModuleActive = value; }
		}

		public override bool IsModuleSupported()
		{
			return forceModuleActive 
				|| VRInput.instance.IsTuioTouchSupported() 
				|| VRInput.instance.IsTouchSupported() 
				|| VRInput.instance.IsMouseSupported();
		}

		public override bool ShouldActivateModule()
		{
			if (!base.ShouldActivateModule())
				return false;

			if (m_ForceModuleActive)
				return true;

			// for vr tuio touches
			foreach (TuioTouch input in VRInput.instance.GetTuioTouches())
			{
				if (input.phase == TuioTouch.TouchPhase.Down
					|| input.phase == TuioTouch.TouchPhase.Move)
					return true;
			}
			// for vr touches
			foreach (Touch input in VRInput.instance.GetTouches())
			{
				if (input.phase == TouchPhase.Began
					|| input.phase == TouchPhase.Moved
					|| input.phase == TouchPhase.Stationary)
					return true;
			}
			// TODO for vr mouse

			return false;
		}

		public override void DeactivateModule()
		{
			base.DeactivateModule();
			ClearSelection();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			if (VRInput.instance.IsTuioTouchSupported())
				sb.AppendLine("VRInput: tuio");
			if (VRInput.instance.IsTouchSupported())
				sb.AppendLine("VRInput: touch");
			if (VRInput.instance.IsMouseSupported())
				sb.AppendLine("VRInput: mouse");

			foreach (var pointerEventData in m_vrTuioPointerData)
				sb.AppendLine(pointerEventData.ToString());
			foreach (var pointerEventData in m_vrPointerData)
				sb.AppendLine(pointerEventData.ToString());
			// TODO for mouse

			return sb.ToString();
		}
		#endregion
			
		// keeps track of VR tuio touches as PointerEventData forms
		#region VRTUIO PointerEventData pool
		protected Dictionary<int, PointerEventData> m_vrTuioPointerData = new Dictionary<int, PointerEventData>();

		protected bool GetVRTuioPointerData(int id, out PointerEventData data, bool create)
		{
			if (!m_vrTuioPointerData.TryGetValue(id, out data) && create) {
				data = new PointerEventData(eventSystem) {
					pointerId = id,
				};
				m_vrTuioPointerData.Add(id, data);
				return true;
			}
			return false;
		}
			
		protected void RemoveVRTuioPointerData(PointerEventData data)
		{
			m_vrTuioPointerData.Remove(data.pointerId);
		}

		protected PointerEventData GetVRTuioTouchPointerEventData(TuioTouch input, out bool pressed, out bool released)
		{
			PointerEventData pointerData;
			var created = GetVRTuioPointerData(input.id, out pointerData, true);

			pointerData.Reset();

			pressed = created || (input.phase == TuioTouch.TouchPhase.Down);
			released = (input.phase == TuioTouch.TouchPhase.Up);

			if (created)
				pointerData.position = input.pos;

			if (pressed)
				pointerData.delta = Vector2.zero;
			else
				pointerData.delta = input.pos - pointerData.position;

			pointerData.position = input.pos;

			pointerData.button = PointerEventData.InputButton.Left;

			eventSystem.RaycastAll(pointerData, m_RaycastResultCache);

			var raycast = FindFirstRaycast(m_RaycastResultCache);
			pointerData.pointerCurrentRaycast = raycast;
			m_RaycastResultCache.Clear();
			return pointerData;
		}
		#endregion

		// keeps track of VR touches as PointerEventData forms
		#region VRTouch PointerEventData pool
		protected Dictionary<int, PointerEventData> m_vrPointerData = new Dictionary<int, PointerEventData>();

		protected bool GetVRPointerData(int id, out PointerEventData data, bool create)
		{
			if (!m_vrPointerData.TryGetValue(id, out data) && create) {
				data = new PointerEventData(eventSystem) {
					pointerId = id,
				};
				m_vrPointerData.Add(id, data);
				return true;
			}
			return false;
		}

		protected void RemoveVRPointerData(PointerEventData data)
		{
			m_vrPointerData.Remove(data.pointerId);
		}

		/// <summary>
		/// Gets the VR touch pointer event data. The code is same as the GetTouchPointerEventData(...) 
		/// in PointerInputModule.cs, execpt for it looks at the VR PointerEventData pool.
		/// </summary>
		/// <returns>The VR touch pointer event data.</returns>
		/// <param name="input">Input.</param>
		/// <param name="pressed">Pressed.</param>
		/// <param name="released">Released.</param>
		protected PointerEventData GetVRTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			PointerEventData pointerData;
			var created = GetVRPointerData(input.fingerId, out pointerData, true);

			pointerData.Reset();

			pressed = created || (input.phase == TouchPhase.Began);
			released = (input.phase == TouchPhase.Canceled) || (input.phase == TouchPhase.Ended);

			if (created)
				pointerData.position = input.position;

			if (pressed)
				pointerData.delta = Vector2.zero;
			else
				pointerData.delta = input.position - pointerData.position;

			pointerData.position = input.position;

			pointerData.button = PointerEventData.InputButton.Left;

			eventSystem.RaycastAll(pointerData, m_RaycastResultCache);

			var raycast = FindFirstRaycast(m_RaycastResultCache);
			pointerData.pointerCurrentRaycast = raycast;
			m_RaycastResultCache.Clear();
			return pointerData;
		}
		#endregion

		// TODO keeps track of VR mouses as PointerEventData forms
		#region VRMouse PointerEventData pool
		// mouse 
		// pos, scroll delta, and pressed/released for left, middle, and right buttons
		#endregion

		#region process methods
		public override void Process()
		{
			ProcessVRTuioTouchEvents();
			ProcessVRTouchEvents();
			ProcessVRMouseEvents();
		}

		/// <summary>
		/// Process all vr tuio touch events.
		/// </summary>
		private void ProcessVRTuioTouchEvents()
		{
			List<TuioTouch> touches = VRInput.instance.GetTuioTouches();

			foreach (TuioTouch input in touches) {
				bool released;
				bool pressed;
				var pointer = GetVRTuioTouchPointerEventData(input, out pressed, out released);

				ProcessTouchPress(pointer, pressed, released);

				if (!released) {
					ProcessMove(pointer);
					ProcessDrag(pointer);
				}
				else {
					RemoveVRTuioPointerData(pointer);
				}
			}
		}

		/// <summary>
		/// Process all vr touch events. Not yet supported...
		/// </summary>
		private void ProcessVRTouchEvents()
		{
			// TODO
		}

		/// <summary>
		/// Process all vr mouse events. Not yet supported...
		/// </summary>
		private void ProcessVRMouseEvents()
		{
			// TODO
		}

		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			var currentOverGo = pointerEvent.pointerCurrentRaycast.gameObject;

			// PointerDown notification
			if (pressed)
			{
				pointerEvent.eligibleForClick = true;
				pointerEvent.delta = Vector2.zero;
				pointerEvent.dragging = false;
				pointerEvent.useDragThreshold = true;
				pointerEvent.pressPosition = pointerEvent.position;
				pointerEvent.pointerPressRaycast = pointerEvent.pointerCurrentRaycast;

				DeselectIfSelectionChanged(currentOverGo, pointerEvent);

				if (pointerEvent.pointerEnter != currentOverGo)
				{
					// send a pointer enter to the touched element if it isn't the one to select...
					HandlePointerExitAndEnter(pointerEvent, currentOverGo);
					pointerEvent.pointerEnter = currentOverGo;
				}

				// search for the control that will receive the press
				// if we can't find a press handler set the press
				// handler to be what would receive a click.
				var newPressed = ExecuteEvents.ExecuteHierarchy(currentOverGo, pointerEvent, ExecuteEvents.pointerDownHandler);

				// didnt find a press handler... search for a click handler
				if (newPressed == null)
					newPressed = ExecuteEvents.GetEventHandler<IPointerClickHandler>(currentOverGo);

				// Debug.Log("Pressed: " + newPressed);

				float time = Time.unscaledTime;

				if (newPressed == pointerEvent.lastPress)
				{
					var diffTime = time - pointerEvent.clickTime;
					if (diffTime < 0.3f)
						++pointerEvent.clickCount;
					else
						pointerEvent.clickCount = 1;

					pointerEvent.clickTime = time;
				}
				else
				{
					pointerEvent.clickCount = 1;
				}

				pointerEvent.pointerPress = newPressed;
				pointerEvent.rawPointerPress = currentOverGo;

				pointerEvent.clickTime = time;

				// Save the drag handler as well
				pointerEvent.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(currentOverGo);

				if (pointerEvent.pointerDrag != null)
					ExecuteEvents.Execute(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.initializePotentialDrag);
			}

			// PointerUp notification
			if (released)
			{
				// Debug.Log("Executing pressup on: " + pointer.pointerPress);
				ExecuteEvents.Execute(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);

				// Debug.Log("KeyCode: " + pointer.eventData.keyCode);

				// see if we mouse up on the same element that we clicked on...
				var pointerUpHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(currentOverGo);

				// PointerClick and Drop events
				if (pointerEvent.pointerPress == pointerUpHandler && pointerEvent.eligibleForClick)
				{
					ExecuteEvents.Execute(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerClickHandler);
				}
				else if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.ExecuteHierarchy(currentOverGo, pointerEvent, ExecuteEvents.dropHandler);
				}

				pointerEvent.eligibleForClick = false;
				pointerEvent.pointerPress = null;
				pointerEvent.rawPointerPress = null;

				if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
					ExecuteEvents.Execute(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);

				pointerEvent.dragging = false;
				pointerEvent.pointerDrag = null;

				if (pointerEvent.pointerDrag != null)
					ExecuteEvents.Execute(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);

				pointerEvent.pointerDrag = null;

				// send exit events as we need to simulate this on touch up on touch device
				ExecuteEvents.ExecuteHierarchy(pointerEvent.pointerEnter, pointerEvent, ExecuteEvents.pointerExitHandler);
				pointerEvent.pointerEnter = null;
			}
		}
		#endregion
	}
}