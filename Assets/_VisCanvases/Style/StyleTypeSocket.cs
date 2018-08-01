using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleTypeSocket : StyleSocket {

	}

	public class IntRange : Object {
		public static implicit operator int(IntRange x)
		{
			return x.value;
		}
		public IntRange(int lower, int upper) {
			lowerBound = lower;
			upperBound = upper;
			value = lower;
		}
		public IntRange(int lower, int upper, int initial) {
			lowerBound = lower;
			upperBound = upper;
			value = initial;
		}
		public int lowerBound;
		public int upperBound;
		public int value;

	}
		// 	public virtual Object GetInput() {
		// 	return _input;
		// }
	public class StyleTypeSocket<T> : StyleTypeSocket {
		public override bool DoesAccept(StyleSocket incoming) {
			return incoming.GetOutput() is T;
		}
	
		// public event Func<T> OnCreateRequest;
		
		// private T CreateInstance()
		// {
		// 	if (OnCreateRequest != null)
		// 		return OnCreateRequest();
		// 	var t = typeof(T);
		// 	if (typeof(Component).IsAssignableFrom(t))
		// 		return (new GameObject(t.Name)).AddComponent<T>();
		// 	return System.Activator.CreateInstance<T>();
		// }

		public StyleTypeSocket<T> Init(string label, StyleModule module) {
			base.Init(label,module,true,false);
		
			return this;
		}

		public virtual Object GetInput() {
			if(base.GetInput() is T)
				return base.GetInput();
			else 
				return null;
		}
	}
}

