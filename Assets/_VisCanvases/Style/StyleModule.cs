using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis{
	public class StyleModule : ScriptableObject {
		[SerializeField]
		List<StyleSocket> _sockets;


		List<StyleSocket> GetSockets() {
			if(_sockets == null) 
				_sockets = new List<StyleSocket>();

			return _sockets;
		}

		public int GetNumberOfSockets() {
			return GetSockets().Count;
		}

		public StyleSocket GetSocket(int i) {
			return GetSockets()[i];
		}
		public virtual void AddSocket(StyleSocket socket) {
			GetSockets().Add(socket);
		}


		public virtual string GetLabel() {
			return "Module";
		}

	}
}

