using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using MinVR;

// Unity uses left hand coordinate system and a camera looks towards z-axis
// IMPORTANT: the z-axis of the orthographic camera and that of manipulating objects should point towards a same direciton and point.
public class StylusManipulation : MonoBehaviour
{
	public class StylusInfo
	{
		public bool isOn = false;

		public Vector3 pos;
		public Vector3 rightVec;
		public Vector3 upVec;

		public Vector3 lastPos;
		public Vector3 lastRightVec;
		public Vector3 lastUpVec;

		public StylusInfo ()
		{
		}
	}

	public bool isCameraMoving;

	// to get the world position of a specific point in the stylus geometry
	public GameObject blueStylus;
	public GameObject redStylus;

	// blue and red
	private StylusInfo[] stylusInfos = new StylusInfo[2];

	void Start ()
	{
		for (int i = 0; i < this.stylusInfos.Length; i++) {
			this.stylusInfos [i] = new StylusInfo ();
		}
	}

	void Update ()
	{
		{ // blue stylus
			int idx = 0;
			Transform stylusT = this.blueStylus.transform;
			IVLabStylus stylus = VRInput.instance.GetStylus0 ();

			if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Down) {
				this.StylusDown (idx, stylusT.position, stylusT.right, stylusT.up);
			} else if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Move) {
				this.StylusMove (idx, stylusT.position, stylusT.right, stylusT.up);
			} else if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Up) {
				this.StylusUp (idx);
			}
		}

		{ // red stylus
			int idx = 1;
			Transform stylusT = this.redStylus.transform;
			IVLabStylus stylus = VRInput.instance.GetStylus1 ();

			if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Down) {
				this.StylusDown (idx, stylusT.position, stylusT.right, stylusT.up);
			} else if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Move) {
				this.StylusMove (idx, stylusT.position, stylusT.right, stylusT.up);
			} else if (stylus.btn1Phase == IVLabStylus.ButtonPhase.Up) {
				this.StylusUp (idx);
			}
		}
	}

	/// <summary>
	/// Gets the matrix that moves previous frame to current one. If the camera is the moving one, it moves current frame to previous one.
	/// </summary>
	/// <returns>The transform matrix that resulted from the touches.</returns>
	public Matrix4x4 GetTransformMatrix ()
	{
		return this.ComputeTransformMatrix ();
	}

	private Matrix4x4 ComputeTransformMatrix ()
	{
		int primaryIndex = 1; // red stylus
		int secondaryIndex = 0; // blue stylus

		// 
		if (this.stylusInfos [primaryIndex].isOn) {			
			
			// Now setup the transformation for the active window
			Vector3 src1, src2, src3, dst1, dst2, dst3;

			// if the camera is moving (instead of an object), it should have a reverse effect
			// compute first points
			if (isCameraMoving) {
				src1 = this.stylusInfos [primaryIndex].pos;
				dst1 = this.stylusInfos [primaryIndex].lastPos;
			} else {
				src1 = this.stylusInfos [primaryIndex].lastPos;
				dst1 = this.stylusInfos [primaryIndex].pos;
			}

			// compute the second points
			// if second is on, use position, otherwise use a dummy point
			if (this.stylusInfos [secondaryIndex].isOn) {			
				if (isCameraMoving) {
					src2 = this.stylusInfos [secondaryIndex].pos;
					dst2 = this.stylusInfos [secondaryIndex].lastPos;
				} else {
					src2 = this.stylusInfos [secondaryIndex].lastPos;
					dst2 = this.stylusInfos [secondaryIndex].pos;
				}
			} else {
				if (isCameraMoving) {
					src2 = src1 + this.stylusInfos [primaryIndex].rightVec;
					dst2 = dst1 + this.stylusInfos [primaryIndex].lastRightVec;
				} else {
					src2 = src1 + this.stylusInfos [primaryIndex].lastRightVec;
					dst2 = dst1 + this.stylusInfos [primaryIndex].rightVec;
				}
			}

			// compute third points
			// third point is a dummy as well
			if (isCameraMoving) {
				src3 = src1 + this.stylusInfos [primaryIndex].upVec;
				dst3 = dst1 + this.stylusInfos [primaryIndex].lastUpVec;
			} else {
				src3 = src1 + this.stylusInfos [primaryIndex].lastUpVec;
				dst3 = dst1 + this.stylusInfos [primaryIndex].upVec;
			}

			// compute the matrix that moves prev frame to current one
			return this.AlignXform (src1, src2, src3, dst1, dst2, dst3);

		} else {
			// no touch; no transform
			return Matrix4x4.identity;
		}
	}

	private void StylusDown (int idx, Vector3 newPos, Vector3 newRightVec, Vector3 newUpVec)
	{
		this.stylusInfos [idx].lastPos = newPos;
		this.stylusInfos [idx].lastRightVec = newRightVec;
		this.stylusInfos [idx].lastUpVec = newUpVec;

		this.stylusInfos [idx].pos = newPos;
		this.stylusInfos [idx].rightVec = newRightVec;
		this.stylusInfos [idx].upVec = newUpVec;

		this.stylusInfos [idx].isOn = true;
	}

	private void StylusMove (int idx, Vector3 newPos, Vector3 newRightVec, Vector3 newUpVec)
	{
		this.stylusInfos [idx].lastPos = this.stylusInfos [idx].pos;
		this.stylusInfos [idx].lastRightVec = this.stylusInfos [idx].rightVec;
		this.stylusInfos [idx].lastUpVec = this.stylusInfos [idx].upVec;

		this.stylusInfos [idx].pos = newPos;
		this.stylusInfos [idx].rightVec = newRightVec;
		this.stylusInfos [idx].upVec = newUpVec;

		this.stylusInfos [idx].isOn = true;
	}

	private void StylusUp (int idx)
	{
		this.stylusInfos [idx].isOn = false;
	}

	private Matrix4x4 AlignXform (Vector3 src1, Vector3 src2, Vector3 src3,
	                              Vector3 dst1, Vector3 dst2, Vector3 dst3)
	{
		Matrix4x4 srcCF = this.CreateCoordinateFrameMatrix (src1, src2, src3);
		Matrix4x4 dstCF = this.CreateCoordinateFrameMatrix (dst1, dst2, dst3);

		float scale = (dst2 - dst1).magnitude / (src2 - src1).magnitude;
		Matrix4x4 scaleM = Matrix4x4.Scale (new Vector3 (scale, scale, scale));

		Matrix4x4 transDst1M = Matrix4x4.identity;
		transDst1M.SetColumn (3, new Vector4 (dst1.x, dst1.y, dst1.z, 1));

		Matrix4x4 transMinusDst1M = Matrix4x4.identity;
		transMinusDst1M.SetColumn (3, new Vector4 (-dst1.x, -dst1.y, -dst1.z, 1));

		return transDst1M * scaleM * transMinusDst1M * dstCF * srcCF.inverse;
	}

	// Create a coordinate frame from three points (pt1 is the origin)
	private Matrix4x4 CreateCoordinateFrameMatrix (Vector3 pt1, Vector3 pt2, Vector3 pt3)
	{
		// compute axes
		Vector3 srcX = (pt2 - pt1);
		srcX.Normalize ();
		Vector3 srcY = (pt3 - pt1);
		srcY.Normalize ();
		Vector3 srcZ = Vector3.Cross (srcX, srcY);
		srcZ.Normalize ();
		srcY = Vector3.Cross (srcZ, srcX);
		srcY.Normalize ();

		// represent them in a matrix form
		Matrix4x4 cf = new Matrix4x4 ();
		cf.SetColumn (0, new Vector4 (srcX.x, srcX.y, srcX.z, 0));
		cf.SetColumn (1, new Vector4 (srcY.x, srcY.y, srcY.z, 0));
		cf.SetColumn (2, new Vector4 (srcZ.x, srcZ.y, srcZ.z, 0));
		cf.SetColumn (3, new Vector4 (pt1.x, pt1.y, pt1.z, 1));

		return cf;
	}
}