using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace MinVR
{
	[System.Serializable]
	public class MyVector3Event : UnityEvent<Vector3> {}
	[System.Serializable]
	public class MyQuaternionEvent : UnityEvent<Quaternion> {}

	public class VRTrackerListener : MonoBehaviour
	{

		[Tooltip ("The name of the VREvent to track (e.g., Head_Move, Hand_Move).")]
		public string trackingEventName = "Head_Move";
		[Tooltip ("The name of the VRDataIndex field where the 4x4 transformation matrix for the tracker data is stored, typically Transform.")]
		public string matrix4x4DataField = "Transform";

		[Tooltip ("The threshold value for a change in position.")]
		public float positionMoveThreshold = 0.0f;
		[SerializeField]
		public MyVector3Event positionMoveEvent;

		[Tooltip ("The threshold value for a change in rotation (in degrees).")]
		public float rotationMoveThreshold = 0.0f;
		[SerializeField]
		public MyQuaternionEvent rotationMoveEvent;

		private Vector3 _lastPos = new Vector3 (0f, 0f, 0f);
		private Quaternion _lastRot = new Quaternion ();

		void Start ()
		{
			VRMain.VREventHandler += OnVREvent;
		}

		void OnVREvent (VREvent e)
		{
			if (e.Name == trackingEventName) {
				Matrix4x4 m = VRConvert.ToMatrix4x4 (e.DataIndex.GetValueAsDoubleArray (matrix4x4DataField));
				Vector3 newPos = m.GetTranslation ();
				Quaternion newRot = m.GetRotation ();
				
				if ((newPos - _lastPos).magnitude > positionMoveThreshold) {
					positionMoveEvent.Invoke (newPos);
					_lastPos = newPos;
				}
				if (Quaternion.Angle (newRot, _lastRot) > rotationMoveThreshold) {
					rotationMoveEvent.Invoke (newRot);
					_lastRot = newRot;
				}
			}
		}
	}
}
// namespace MinVR