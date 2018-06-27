using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {

public class Layer : ScriptableObject {

	[SerializeField]
	bool _visible;

	[SerializeField]
	bool _active;

	public virtual bool HasBounds() {
		return false;
	}
	public virtual Bounds GetBounds() {
		return new Bounds();
	}

	public virtual void DrawLayer(Canvas canvas) {

	}
}
}

