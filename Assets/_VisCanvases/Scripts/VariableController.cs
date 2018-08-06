using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SculptingVis {

	[CreateAssetMenu()]
	public class VariableController : ScriptableObject {

		[SerializeField] 
		Material _styleOriginMaterial;

		[SerializeField]
		List<StyleVariable> _variables;

		public List<StyleVariable> GetVariables() {
			if(_variables == null) _variables = new List<StyleVariable>();
			return _variables;
		}

		public void Clear() {
			_variables.Clear();
		}

		public void AddVariable(StyleVariable variable) {
			_variables.Add(variable);
		}
	}
}
