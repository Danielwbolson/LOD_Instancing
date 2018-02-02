using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	[System.Serializable]
	public class MyFloatEvent : UnityEvent<float> {}

	public class VRUnityMouseScrollListener : MonoBehaviour
	{
		/// <summary>
		/// The events that are executed for a horizontal mouse scroll event. A typical mouse only supports a vertical scroll.
		/// </summary>
		public MyFloatEvent horizontalScrollEvent;
		/// <summary>
		/// The events that are executed for a vertical mouse scroll event. A typical mouse only supports a vertical scroll.
		/// </summary>
		public MyFloatEvent verticalScrollEvent;

		void Start ()
		{
			VRMain.VREventHandler += OnVREvent;
		}

		void OnVREvent (VREvent e)
		{
			if (e.Name == VRUnityInputTracker.MouseScrollEventName) {
				double[] scrollDeltas = e.DataIndex.GetValueAsDoubleArray (VRUnityInputTracker.MouseScrollValueField);

				if (scrollDeltas[0] != 0.0) {
					//Debug.Log("horizontal scroll delta:" + scrollDeltas[0]);
					horizontalScrollEvent.Invoke ((float) scrollDeltas[0]);
				}

				if (scrollDeltas[1] != 0.0) {
					//Debug.Log("vertical scroll delta:" + scrollDeltas[1]);
					verticalScrollEvent.Invoke ((float) scrollDeltas[1]);
				}
			}
		}
	}
}
// namespace MinVR