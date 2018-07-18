using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	public class VariableSocket : ScriptableObject {
		
		[SerializeField]
		Variable _input;
		[SerializeField]
		VariableSocket _anchorVariable;


		[SerializeField]
		int _slot;


		public void Init(int slot = -1) {
			_slot = slot;
		}
		int GetSlot() {
			return _slot;
		}

		public bool IsAssigned() {
			return _input != null;
		}
		public Variable GetInput() {
			return _input;
		}
		public void Bind(Material material,int instanceID, int timestep) {
			if(_slot < 0) return;
			material.SetVector("_VariableDefaultValue_" + GetSlot(),new Vector3(0,0,1));
			if(_input != null) {
				material.SetInt("_VariableAssigned_" + GetSlot(), 1);
				_input.GetStream(_anchorVariable == null? null : (DataVariable)_anchorVariable.GetInput(),instanceID,timestep).Bind(material,GetSlot());
			} else {
				material.SetInt("_VariableAssigned_" + GetSlot(), 0);

			}
		}
		public void SetAnchorVariable(VariableSocket anchor) {
			_anchorVariable = anchor;
		}

		public Variable GetAnchorVariable() {
			return _anchorVariable.GetInput();
		}

		public bool ValidateInputVariable(Variable inputVariable) {
			if(inputVariable.GetStream((DataVariable)_anchorVariable.GetInput()) == null) {
				return false;
			}
			else return true;
		}


		public void SetInputVariable(Variable inputVariable) {
			_input = inputVariable;
		}


	}
}
