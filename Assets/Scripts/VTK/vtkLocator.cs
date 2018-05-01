

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLocator : vtkObject {

// virtual void SetDataSet(vtkDataSet * ARG_0)
// "virtual void SetDataSet(vtkDataSet*)"
public new void SetDataSet(vtkDataSet /*(vtkDataSet*)*/ ARG_0) {
	API_vtkLocator.SetDataSet_0(this, ARG_0);
}


// virtual void Update()
// "virtual void Update()"
public new void Update() {
	API_vtkLocator.Update_0(this);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkLocator.Initialize_0(this);
}


// virtual void BuildLocator()
// "virtual void BuildLocator()"
public new void BuildLocator() {
	API_vtkLocator.BuildLocator_0(this);
}


// virtual void FreeSearchStructure()
// "virtual void FreeSearchStructure()"
public new void FreeSearchStructure() {
	API_vtkLocator.FreeSearchStructure_0(this);
}


// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// "virtual void GenerateRepresentation(int level, vtkPolyData *pd)"
public new void GenerateRepresentation(int /*(int)*/ level, vtkPolyData /*(vtkPolyData*)*/ pd) {
	API_vtkLocator.GenerateRepresentation_0(this, level, pd);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase *o)"
public new void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkLocator.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public new void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkLocator.UnRegister_0(this, o);
}


}
};
