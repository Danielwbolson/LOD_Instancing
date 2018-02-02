using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MinVR {

	/** VRMain must be the first script in Unity's execution order, something that must be set manually in the Unity Editor:
	 *  1. Go to Edit -> Project Settings -> Script Execution Order.
	 *  2. Click on the "+" button and select the MinVR.VRMain script.
	 *  3. Drag it above the bar labeled "Default Time".  This will set its order to "-100", which means its Update() method
	 *     will be called before the Update() method for any other script.
	 */
	public class VRMain : MonoBehaviour {

		[Tooltip("Select this to connect to a MinVR Server to get tracker and other input events.  The server must already be running at the time your Unity program starts up.")]
		public bool connectToVRServer = true;
		[Tooltip("The IP address of the MinVR server (e.g., 127.0.0.1).")]
		public string VRServerIP = "127.0.0.1";
		[Tooltip("The port of the MinVR server (typically 3490).")]
		public int VRServerPort = 3490;

		[Tooltip("The gameobject that contains VR display devices.")]
		public GameObject displayDevices;

		public delegate void VREventDelegate(VREvent e);
		public static event VREventDelegate VREventHandler;
		
		private VRNetClient _netClient;
		
		// When Unity starts up, Update seems to be called twice before we reach the EndOfFrame callback, so we maintain
		// a state variable here to make sure that we don't request events twice before requesting swapbuffers.
		private enum NetState {PreUpdateNext, PostRenderNext}
		private NetState _state = NetState.PreUpdateNext;

		private List<VREvent> _inputEvents = new List<VREvent> ();

		private VRClientInputTracker[] _inputTrackers;

		// singleton instance
		private static VRMain instance;

		void Awake () {
			// singleton
			if (instance == null) {
				// persistent throughout different scenes
				DontDestroyOnLoad (gameObject);
				instance = this;
			} else if (instance != this) {
				// if a singleton already exists, destory it
				DestroyImmediate (gameObject);
			}

			// process command line arguments
			String[] args = Environment.GetCommandLineArgs ();

			for (int i = 0; i < args.Length; i++) {
				String currArg = args [i];

				if (currArg.StartsWith ("+VRDisplayDevice=")) {
					String argValue = currArg.Substring ("+VRDisplayDevice=".Length);
					this.ProcessDisplayDeviceArgument (argValue);
				} else if (currArg.StartsWith ("+WindowSetting=")) {
					#if UNITY_STANDALONE_WIN
					String argValue = currArg.Substring ("+WindowSetting=".Length);
					this.ProcessWindowArgument(argValue);
					#endif
				}
			}
		}

		void Start () {
			if (connectToVRServer) {
				_netClient = new VRNetClient(VRServerIP, VRServerPort);
			}

			// GetComponent returns null if the component does not exist
			_inputTrackers = this.GetComponents<VRClientInputTracker>();
		}

		// See important note above... this Update() method MUST be called before any others in your Unity App.
		void Update () {
			if (_state == NetState.PreUpdateNext) {
				// Since we force this Script to be the first one that Unity calls, this gives us a hook to create
				// something like a "PreUpdate()" function.  It would have been nice if Unity provided this for us,
				// but they do not (yet) provide a PreUpdate() callback.
				PreUpdate ();

				// We also need a callback when the scene is done rendering, so we request that callback each frame.
				StartCoroutine(EndOfFrameCallback());
			}
		}

		IEnumerator EndOfFrameCallback() {
			// This is a fancy feature of Unity and C# and is the only way I know how to get a callback after Unity
			// has finished completely rendering the frame, which may include rendering more than one camera.
			// The yield command pauses execution of this function until the EndOfFrame is reached.
			yield return new WaitForEndOfFrame();

			if (_state == NetState.PostRenderNext) {
				PostRender();				
			}
		}


		// AT THE START OF EACH FRAME: SYNCHRONIZE INPUT EVENTS AND CALL ONVREVENT CALLBACK FUNCTIONS
		void PreUpdate() {
			// add input events from this client's input trackers (such as fake input events)
			if (this._inputTrackers != null) {
				for (int i = 0; i < this._inputTrackers.Length; i++) {
					VRClientInputTracker currTracker = this._inputTrackers[i];
					if (currTracker.useIt) {
						currTracker.AddEvents(ref this._inputEvents);
					}
				}
			}

			// Synchronize with the server
			if (_netClient != null) {
				_netClient.SynchronizeInputEventsAcrossAllNodes(ref _inputEvents);
			}

			// Update the VR input managers
			VRInput.instance.UpdateInputs(_inputEvents);

			// Call any event callback functions that have been registered with the VREventHandler
			for (int i=0; i<_inputEvents.Count; i++) {
				if (VREventHandler != null) {
					VREventHandler(_inputEvents[i]);
				}
			}		
			_state = NetState.PostRenderNext;
		}



		// AT END OF EACH FRAME:  WAIT FOR THE SIGNAL THAT ALL CLIENTS ARE ALSO READY, THEN SWAPBUFFERS
		void PostRender() {
			if (_netClient != null) {
				_netClient.SynchronizeSwapBuffersAcrossAllNodes ();
			}
			_state = NetState.PreUpdateNext;
			_inputEvents.Clear();
		}


		// sets the position of the window with a DLL call
		// sets the resolution with the built-in function
		private void ProcessWindowArgument (string argValue)
		{
			string[] vals = argValue.Split (',');
			if (vals.Length == 4) {
				int x = Int32.Parse (vals [0]);
				int y = Int32.Parse (vals [1]);
				int w = Int32.Parse (vals [2]);
				int h = Int32.Parse (vals [3]);

				if (x >= 0 && y >= 0 && w >= 0 && h >= 0) {
					WindowUtility.SetPosition (x, y, w, h);
				}
			}
		}

		// iterates through Gameobjects under the dipslay device group gameobject
		// activates the interested one; otherwise deactivates 
		// set the window title as the input value.
		// argValue e.g. "Cave/CaveLeftWall"
		private void ProcessDisplayDeviceArgument (string argValue)
		{
			if (String.IsNullOrEmpty(argValue)) {
				this.gameObject.SetActive(false);
				return;
			}

			// e.g. "Cave/CaveLeftWall" or "iPhone4"
			string[] argTokens = argValue.Split('/');

			// for each hiearchy
			GameObject currLevelObject = this.displayDevices;
			for (int i = 0; i < argTokens.Length; i++) {
				string currToken = argTokens[i];
				Transform foundT = currLevelObject.transform.Find(currToken);
				GameObject foundChild = foundT == null ? null : foundT.gameObject;

				// activeates the found and deactives others
				for (int childIdx = 0; childIdx < currLevelObject.transform.childCount; childIdx++) {
					GameObject currChild = currLevelObject.transform.GetChild (childIdx).gameObject;
					if (currChild == foundChild) {
						currChild.gameObject.SetActive (true);
					} else {
						currChild.gameObject.SetActive (false);
					}
				}

				// prepare for the next hierachy, if there is a need
				if (foundChild == null) {
					break;
				} else {
					currLevelObject = foundChild;
				}
			}

			// set the window title
			WindowUtility.SetWindowTitle(argValue);
		}
	}

} // namespace MinVR
