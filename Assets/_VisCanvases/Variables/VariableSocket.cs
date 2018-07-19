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

		[SerializeField]
		string _name;


		[SerializeField]
		public float LowerBound;

		[SerializeField]
		public float UpperBound;



		bool _vectorRequired = false;
		bool _scalarRequired = false;
		public void RequireVector() {
			_vectorRequired = true;
			_scalarRequired = false;
		}
		public bool VectorRequired() {
			return _vectorRequired;
		}
		public bool ScalarRequired() {
			return _scalarRequired;
		}
		public void RequireScalar() {
			_vectorRequired = false;
			_scalarRequired = true;
		}
		public void Init(string name = "Anchor", int slot = -1) {
			_slot = slot;
			_name = name;
		}
		public int GetSlot() {
			return _slot;
		}
		public string GetName() {
			return _name;
		}
		public bool IsAnchor() {
			return _slot < 0;
		}
		public bool IsAssigned() {
			return _input != null;
		}
		public Variable GetInput() {
			return _input;
		}
		public void Bind(Material material,int instanceID, int timestep) {
			string slot = IsAnchor()?"Anchor":(""+GetSlot());
			material.SetVector("_VariableDefaultValue_" + slot,new Vector3(0,0,1));
			material.SetFloat("_VariableMinOverride_"+slot,LowerBound);
			material.SetFloat("_VariableMaxOverride_" +slot, UpperBound);
			if(_input != null) {
				material.SetInt("_VariableAssigned_" + slot, 1);
				_input.GetStream(_anchorVariable == null? null : (DataVariable)_anchorVariable.GetInput(),instanceID,timestep).Bind(material,GetSlot());
			} else {
				material.SetInt("_VariableAssigned_" + slot, 0);

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
			LowerBound = inputVariable.GetMin().x;
			UpperBound = inputVariable.GetMax().x;
		}


	}
}
