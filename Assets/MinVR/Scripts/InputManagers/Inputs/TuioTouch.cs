using UnityEngine;
using System.Collections;

public class TuioTouch {

	public enum TouchPhase { Down, Move, Up};

	public readonly int id;
	public TouchPhase phase;
	public Vector2 pos; // in a pixel coordinate
	public Vector2 rawPos;
	public float acc;
	public float speed;

	public TuioTouch (int id)
	{
		this.id = id;
		this.phase = TouchPhase.Down;
	}
}
