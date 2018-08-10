using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleTypeSocket : StyleSocket {

	}


	public class Objectify<T> : Object {
		public static bool operator ==(Objectify<T> A, Objectify<T> B)
		{
			if (object.ReferenceEquals(A, null))
			{
				return object.ReferenceEquals(B, null);
			}

			return A.Equals(B);
		}

		public static bool operator !=(Objectify<T> A, Objectify<T> B)
		{
			if (object.ReferenceEquals(A, null))
			{
				return !object.ReferenceEquals(B, null);
			}

			return !A.Equals(B);
		}
		public override string ToString() {
			return  "" + value ;
		}
		public static implicit operator T(Objectify<T> x)
		{
			return x.value;
		}

		public Objectify(T initial) {
			value = initial;
		}
		public T value;
	}
	public class MinMax : Object
    {
        public MinMax(float lower, float upper)
        {
            lowerBound = lower;
            upperBound = upper;
        }
        public override string ToString()
        {
            return lowerBound + " < " + upperBound;
        }
        public float lowerBound;
        public float upperBound;
    }
	public class Range<T> :Object {
		public static bool operator ==(Range<T> A, Range<T> B)
		{
			if (object.ReferenceEquals(A, null))
			{
				return object.ReferenceEquals(B, null);
			}

			return A.Equals(B);
		}

		public static bool operator !=(Range<T> A, Range<T> B)
		{
			if (object.ReferenceEquals(A, null))
			{
				return !object.ReferenceEquals(B, null);
			}

			return !A.Equals(B);
		}
		public override string ToString() {
			return lowerBound + " < " + value + " < " + upperBound;
		}
		public static implicit operator T(Range<T> x)
		{
			return x.value;
		}
		public Range(T lower, T upper) {
			lowerBound = lower;
			upperBound = upper;
			value = lower;
		}
		public Range(T lower, T upper, T initial) {
			lowerBound = lower;
			upperBound = upper;
			value = initial;
		}
		public T lowerBound;
		public T upperBound;
		public T value;
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

