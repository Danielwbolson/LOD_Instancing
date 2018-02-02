using UnityEngine;
using System.Collections;

public class IVLabStylus {

	public enum ButtonPhase { None, Down, Move, Up};

	public readonly int id;

	public Vector3 pos;
	public Quaternion rot;

	public Vector3 lastPos;
	public Quaternion lastRot;

	public ButtonPhase btn0Phase;
	public ButtonPhase btn1Phase;

	public IVLabStylus (int id)
	{
		this.id = id;
		this.btn0Phase = ButtonPhase.None;
		this.btn1Phase = ButtonPhase.None;
	}
}