using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	[System.Serializable]
	public class StyleSocket : ScriptableObject {
		[SerializeField]
		StyleModule _module;
		[SerializeField]
		bool _isInput;
		[SerializeField]
		bool _isOutput;
		

		public void Init(StyleModule module, bool isInput, bool isOutput) {
			_module = module;
			_isInput = isInput;
			_isOutput = isOutput;
		}

		public virtual string GetUniqueIdentifier() {
			return GetInstanceID() + "";
		}

		public virtual string GetLabel() {
			return _module.GetLabel() + " Socket";	
		}

		
	}
}

