using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	[AddComponentMenu("MinVR/Inputs/VR Input")]
	public class VRInput : MonoBehaviour
	{
		// singleton instance
		public static VRInput instance;

		private VRInputMananger[] _inputManagers;
		// "_tuioManager" should also be in "_inputManagers"; did this to save the time, looking for this manager in the array.
		private VRTuioInputManager _tuioManager;
		private VRStylusInputManager _stylusManager;

		void Awake () {
			// singleton
			if (instance == null) {
				// persistent throughout different scenes
				// do not need DontDestroyOnLoad(gameObject) since it is under the persistent gameobject (VRMain).
				// DontDestroyOnLoad (gameObject);
				instance = this;
			} else if (instance != this) {
				// if a singleton already exists, destory it
				DestroyImmediate (gameObject);
			}
		}

		void Start() {
			// GetComponent returns null if the component does not exist
			_inputManagers = this.GetComponents<VRInputMananger>();

			// update individual manager
			foreach (VRInputMananger m in _inputManagers) {
				if (m is VRTuioInputManager) {
					_tuioManager = (VRTuioInputManager) m;
				} else if (m is VRStylusInputManager) {
					_stylusManager = (VRStylusInputManager) m;
				}
			}
		}

		public void UpdateInputs (List<VREvent> events) {
			foreach (VRInputMananger m in _inputManagers) {
				if (m.useIt) {
					m.Refresh();
					m.ProcessVREvent(events);
				}
			}
		}

		#region vr stylus methods
		public bool IsStylusSupported() {
			if (this._stylusManager != null && this._stylusManager.useIt) {
				return true;
			}
			return false;
		}

		public IVLabStylus GetStylus0() {
			if (this._stylusManager == null) {
				return null;
			}
			return this._stylusManager.stylus0;
		}

		public IVLabStylus GetStylus1() {
			if (this._stylusManager == null) {
				return null;
			}
			return this._stylusManager.stylus1;
		}
		#endregion

		#region vr tuio methods
		public bool IsTuioTouchSupported() {
			if (this._tuioManager != null && this._tuioManager.useIt) {
				return true;
			}
			return false;
		}

		public List<TuioTouch> GetTuioTouches() {
			if (this._tuioManager == null) {
				return null;
			}
			return this._tuioManager.GetTouches();
		}

		public int GetNumOfTuioTouches() {
			if (this._tuioManager == null) {
				return 0;
			}
			return this._tuioManager.GetTouches().Count;
		}
		#endregion

		#region vr touch methods
		/// <summary>
		/// Determines whether this instance is touch supported. IMPORTANT!! this does not include TUIO touches.
		/// </summary>
		/// <returns><c>true</c> if this instance is touch supported; otherwise, <c>false</c>.</returns>
		public bool IsTouchSupported() {
			// TODO
			return false;
		}

		/// <summary>
		/// Gets the touches. IMPORTANT!! the list does not contain TUIO touches.
		/// </summary>
		/// <returns>The touches.</returns>
		public List<Touch> GetTouches() {
			// TODO
			List<Touch> touches = new List<Touch>();
			return touches;
		}

		/// <summary>
		/// Gets the number of touches. IMPORTANT!! this does not include TUIO touches.
		/// </summary>
		/// <returns>The number of touches.</returns>
		public int GetNumOfTouches() {
			// TODO
			return 0;
		}
		#endregion

		#region vr mouse methods
		public bool IsMouseSupported() {
			// TODO
			return false;
		}

		// TODO methods for vr mouse 
		#endregion
	}
}
// namespace MinVR