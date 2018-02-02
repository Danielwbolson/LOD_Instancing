using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	public class VRInputMananger : MonoBehaviour
	{
		/// <summary>
		/// enable it to use this manager.
		/// </summary>
		public bool useIt = true;

		/// <summary>
		/// Processes the VR events.
		/// </summary>
		/// <param name="events">Events.</param>
		public virtual void ProcessVREvent (List<VREvent> events) {
			
		}

		/// <summary>
		/// Refresh this manager. This would be theplace to work with the pending events. 
		/// </summary>
		public virtual void Refresh() {

		}
	}
}
// namespace MinVR