using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	public class VRUnityKeyCodeListener : MonoBehaviour
	{
		[System.Serializable]
		public class KeyCodeDownUpEvents
		{
			[Tooltip ("The keycode that triggers the below down and up events. See Unity's KeyCode Document to find the string form of an interested KeyCode.")]
			public string keyCode;
			/// <summary>
			/// The events that are executed for this keycode-down event.
			/// </summary>
			public UnityEvent downEvent;
			/// <summary>
			/// The events that are executed for this keycode-up event.
			/// </summary>
			public UnityEvent upEvent;
		}

		public List<KeyCodeDownUpEvents> listeningKeyCodes = new List<KeyCodeDownUpEvents>();

		void Start ()
		{
			VRMain.VREventHandler += OnVREvent;
		}

		void OnVREvent (VREvent e)
		{
			if (e.Name == VRUnityInputTracker.KeyCodeEventName) {
				// get the keycode string value
				string recievedKeyCode = e.DataIndex.GetValueAsString (VRUnityInputTracker.KeyCodeValueField);

				// checks if there are assoicated events to the recieved key code 
				foreach (KeyCodeDownUpEvents currKeyCode in listeningKeyCodes) {
					if (currKeyCode.keyCode == recievedKeyCode) {
						// (0 or 1) usually means (released or pressed)
						int state = e.DataIndex.GetValueAsInt (VRUnityInputTracker.KeyCodeStateField);
						//Debug.Log("Event name = " + e.Name);
						//Debug.Log("Key value = " + recievedKeyCode.ToString());
						//Debug.Log("Key state = " + state);

						if (state == 1) {
							currKeyCode.downEvent.Invoke ();
						} else if (state == 0) {
							currKeyCode.upEvent.Invoke ();
						}
					}
				}
			}
		}
	}
}
// namespace MinVR