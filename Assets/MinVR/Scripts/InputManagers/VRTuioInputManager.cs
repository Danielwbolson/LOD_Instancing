using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MinVR
{
	[AddComponentMenu("MinVR/Inputs/Managers/VR Tuio Input Manager")]
	public class VRTuioInputManager : VRInputMananger
	{
		/// <summary>
		/// The name of the tracking event from the server.
		/// </summary>
		public string trackingEventName = "Multitouch";
		// strings for parsing a TUIO touch event data index
		public string idField = "id";
		public string stateField = "action";
		public string rawPosField = "pos";
		public string accelField = "acc";
		public string speedField = "speed";
		[Tooltip ("The size (w, h) of the touchable window.")]
		public Vector2 touchWindowSize = new Vector2(1680, 1050);

		private List<TuioTouch> touches = new List<TuioTouch> ();
		// the touches that were 'Up' in the last frame; pending to remove from 'touches' in the incoming frame.
		private List<TuioTouch> removingTouches = new List<TuioTouch> ();


		public override void Refresh() {
			// remove the touches that were 'Up' in the last frame.
			foreach (TuioTouch t in this.removingTouches) {
				this.touches.Remove(t);
			}
			// clears the removed touches from the removing touches. 
			this.removingTouches.Clear();
		}

		public override void ProcessVREvent (List<VREvent> events)
		{
			foreach (VREvent e in events) {
				if (e.Name == trackingEventName) {
					string state = e.DataIndex.GetValueAsString (this.stateField);

					if (state == "Down") {
						this.ProcessDownEvent(e);
					} else if (state == "Move") {
						this.ProcessMoveEvent(e);
					} else if (state == "Up") {
						this.ProcessUpEvent(e);
					} else { 
						// unrecognized state
					}
				}
			}
		}


		public List<TuioTouch> GetTouches() {
			return this.touches;
		}


		private TuioTouch GetTouch(int id) {
			foreach (TuioTouch t in this.touches) {
				if (t.id == id) {
					return t;
				}
			}
			return null;
		}

		private void ProcessDownEvent(VREvent e) {
			int id = e.DataIndex.GetValueAsInt (this.idField);
			if (this.GetTouch(id) != null) {
				Debug.LogWarning("Processing a down event... tuio touch id (" + id + ") has been added previously.");
				return;
			}

			double[] rawPos = e.DataIndex.GetValueAsDoubleArray (this.rawPosField);

			// create and add a tuio touch.
			TuioTouch t = new TuioTouch(id);
			t.phase = TuioTouch.TouchPhase.Down;
			t.rawPos.Set((float) rawPos[0], (float) rawPos[1]);
			// in a TUIO, (0,0) is at top-left; in an Unity screen space, (0,0) is at bot-left.
			t.pos.Set(Screen.width * ((float) rawPos[0]), Screen.height * (1.0f - (float) rawPos[1]));
			this.touches.Add(t);
		}

		private void ProcessMoveEvent(VREvent e) {
			int id = e.DataIndex.GetValueAsInt (this.idField);
			TuioTouch curr = this.GetTouch(id);
			if (curr == null) {
				Debug.LogWarning("Processing a move event... tuio touch id (" + id + ") is not found.");
				return;
			}

			double[] rawPos = e.DataIndex.GetValueAsDoubleArray (this.rawPosField);
			double acc = e.DataIndex.GetValueAsDouble (this.accelField);
			double speed = e.DataIndex.GetValueAsDouble (this.speedField);

			// update the variables
			curr.phase = TuioTouch.TouchPhase.Move;
			curr.rawPos.Set((float) rawPos[0], (float) rawPos[1]);
			// in a TUIO, (0,0) is at top-left; in an Unity screen space, (0,0) is at bot-left.
			curr.pos.Set(Screen.width * ((float) rawPos[0]), Screen.height * (1.0f - (float) rawPos[1]));
			curr.acc = (float) acc;
			curr.speed = (float) speed;
		}

		private void ProcessUpEvent(VREvent e) {
			int id = e.DataIndex.GetValueAsInt (this.idField);
			TuioTouch curr = this.GetTouch(id);
			if (curr == null) {
				Debug.LogWarning("Processing a up event... tuio touch id (" + id + ") is not found.");
				return;
			}

			curr.phase = TuioTouch.TouchPhase.Up;
			this.removingTouches.Add(curr);
		}
	}
}
// namespace MinVR