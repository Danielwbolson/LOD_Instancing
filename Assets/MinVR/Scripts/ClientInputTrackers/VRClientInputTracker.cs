using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	public class VRClientInputTracker : MonoBehaviour
	{
		/// <summary>
		/// enable it to use this tracker.
		/// </summary>
		public bool useIt = true;

		/// <summary>
		/// Adds the events.
		/// </summary>
		/// <param name="eventList">Event list.</param>
		public virtual void AddEvents(ref List<VREvent> eventList) {

		}
	}
}
