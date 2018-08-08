using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SculptingVis {
	public class VariableSocket : StyleSocket {
		
		[SerializeField]
		Variable _inputVariable;
		[SerializeField]
		VariableSocket _anchorVariable;


		[SerializeField]
		int _slot;



		[SerializeField]
		public float LowerBound;

		[SerializeField]
		public float UpperBound;

		

		bool _vectorRequired = false;
		bool _scalarRequired = false;
		bool _uniformRequired = false;


		public override void UpdateSocket(){
			base.UpdateSocket();
			if(this.GetLinks().Count > 0)
			_inputVariable = (Variable)this.GetLinks()[0].GetSource().GetOutput();
		}
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
		public bool UniformRequired() {
			return _uniformRequired;
		}
		public void RequireScalar() {
			_vectorRequired = false;
			_scalarRequired = true;
		}

		public void RequireUniform() {
			_uniformRequired = true;
		}
		public VariableSocket Init(string name, StyleModule module, int slot = -1) {
			base.Init(name,module,true,false,null);
			_slot = slot;
			return this;
		}
		public int GetSlot() {
			return _slot;
		}
		public string GetName() {
			return GetLabel();
		}
		public bool IsAnchor() {
			return _slot == 0;
		}
		public bool IsAssigned() {
			return _inputVariable != null;
		}
		public Variable GetInput() {
			return _inputVariable;
		}
		public void Bind(Material material,int instanceID, int timestep) {
			string slot = /*IsAnchor()?"Anchor":*/ (""+ GetSlot());
			material.SetVector("_VariableDefaultValue_" + slot,new Vector3(0,0,1));
			material.SetFloat("_VariableMinOverride_"+slot,LowerBound);
			material.SetFloat("_VariableMaxOverride_" +slot, UpperBound);
			if(_inputVariable != null) {
				material.SetInt("_VariableAssigned_" + slot, 1);
				_inputVariable.GetStream(_anchorVariable == null? null : (DataVariable)_anchorVariable.GetInput(),instanceID,timestep).Bind(material,GetSlot());
			} else {
				material.SetInt("_VariableAssigned_" + slot, 0);
				material.SetBuffer("_VariableDataBuffer_"  + slot,Datastream.EmptyBuffer());
			}
		}
		public void SetAnchorVariableSocket(VariableSocket anchor) {
			_anchorVariable = anchor;
		}

		public Variable GetAnchorVariable() {
			if(_anchorVariable == null) return null;
			return _anchorVariable.GetInput();
		}

		public override bool DoesAccept(StyleSocket incoming) {
			if(incoming.GetOutput() is Variable) {
				return ValidateInputVariable((Variable)incoming.GetOutput());
			}
			return false;
		}
		public bool ValidateInputVariable(Variable inputVariable) {
			if(inputVariable == null) 
				return false;	
			if(inputVariable.GetDomainDimensionality() != 3 && (inputVariable.GetAnchorVariable() != null && GetAnchorVariable() != null && GetAnchorVariable() != inputVariable.GetAnchorVariable()))
				return false;
			if(_anchorVariable != null && inputVariable.GetStream((DataVariable)_anchorVariable.GetInput()) == null) {
				return false;
			}
			if(inputVariable.GetComponents() == 1 && VectorRequired())
				return false;

			if(inputVariable.GetComponents() > 1 && ScalarRequired())
				return false;
			
			if(inputVariable.GetDomainDimensionality() != 3 && inputVariable.GetAnchorVariable() != GetAnchorVariable() && GetAnchorVariable() != null)
				return false;

			return true;
		}


		public void SetInputVariable(Variable inputVariable) {
			_inputVariable = inputVariable;
			if(inputVariable != null) {
				LowerBound = inputVariable.GetMin().x;
				UpperBound = inputVariable.GetMax().x;
			}

		}

		public override void SetInputObject(Object inputObject) {
			if(inputObject is Variable)
				SetInputVariable((Variable)inputObject);
		}

		public override void ClearInput() {
			_inputVariable = null;
		}

	}
}
