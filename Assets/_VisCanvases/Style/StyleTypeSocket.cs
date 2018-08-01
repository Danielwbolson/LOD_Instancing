using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleTypeSocket : StyleSocket {

	}
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
	}
}

