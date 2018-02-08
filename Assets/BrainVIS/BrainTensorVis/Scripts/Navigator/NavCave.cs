using UnityEngine;
using System.Collections;

public class NavCave : MonoBehaviour
{
	public GameObject movingObject;

	private StylusManipulation stylusTracker;

	private Vector3 initPos;
	private Quaternion initRot;
	private Vector3 initLocalScale;

	void Start ()
	{
		this.stylusTracker = GetComponent<StylusManipulation> ();

		this.initPos = this.movingObject.transform.position;
		this.initRot = this.movingObject.transform.rotation;
		this.initLocalScale = this.movingObject.transform.localScale;
	}

	void Update ()
	{
		// first handles stylus events
		Matrix4x4 stylusMatrix = stylusTracker.GetTransformMatrix () * this.movingObject.transform.localToWorldMatrix;
		// Unity does not allow set the pos, rot, scale via matrix
		Vector3 stylusPos = stylusMatrix.GetColumn (3);
		Quaternion stylusRot = Quaternion.LookRotation (stylusMatrix.GetColumn (2), stylusMatrix.GetColumn (1));
		Vector3 stylusLocalScale = new Vector3 (stylusMatrix.GetColumn (0).magnitude, stylusMatrix.GetColumn (1).magnitude, stylusMatrix.GetColumn (2).magnitude);

		this.movingObject.transform.position = stylusPos;
		this.movingObject.transform.rotation = stylusRot;
		this.movingObject.transform.localScale = stylusLocalScale;
	}

	public void ResetMovingObject() 
	{
		this.movingObject.transform.position = this.initPos;
		this.movingObject.transform.rotation = this.initRot;
		this.movingObject.transform.localScale = this.initLocalScale;
	}
}