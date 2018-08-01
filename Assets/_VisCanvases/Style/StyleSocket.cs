using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {

	
	[System.Serializable]
	public class StyleSocket {
		public System.Guid InstanceID {get; private set;}
		// Other properties, etc.


			


		[SerializeField]
		StyleModule _module;
		[SerializeField]
		bool _isInput;
		[SerializeField]
		bool _isOutput;
		
		[SerializeField]
		string _label;

		[SerializeField]
		List<StyleLink> _links;

		public List<StyleLink> GetLinks() {
			if(_links == null) _links = new List<StyleLink>();
			return _links;
		}
		public StyleSocket Init(string label, StyleModule module, bool isInput, bool isOutput, Object sourceObject = null) {
			this.InstanceID = System.Guid.NewGuid();
			_module = module;
			_isInput = isInput;
			_isOutput = isOutput;
			_label = label;
			SetSourceObject(sourceObject);
			return this;
		}

		[SerializeField]
		Object _source;

		[SerializeField]
		protected Object _input;

		public StyleModule GetModule() {
			return _module;
		}
		public void SetSourceObject(Object sourceObject) {
			_source = sourceObject;
		}

		public virtual void SetInputObject(Object inputObject) {
			_input = inputObject;
		}

		public Object GetOutput() {
			return _source;
		}
		public virtual Object GetInput() {
			return _input;
		}
		public virtual string GetUniqueIdentifier() {
			return InstanceID + "";
		}

		public virtual string GetLabel() {
			return _label;	
		}

		public bool IsOutput() {
			return _isOutput;
		}

		public bool IsInput() {
			return _isInput;
		}
		
		public virtual bool DoesAccept(StyleSocket incoming) {
			return true;
		}

		public virtual void ClearInput() {
			_input = null;
		}
	}
}

