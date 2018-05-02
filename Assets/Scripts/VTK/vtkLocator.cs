

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLocator : vtkObject {
		public vtkLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkLocator(IntPtr p) {return new vtkLocator(p);}
		public static implicit operator  IntPtr(vtkLocator o) {return o.GetPtr();}

// virtual void SetDataSet(vtkDataSet * ARG_0)
// "virtual void SetDataSet(vtkDataSet*)"
public void SetDataSet(vtkDataSet /*(vtkDataSet*)*/ ARG_0) {
	VTK_API.API_vtkLocator.SetDataSet_0(this, ARG_0);
}


// virtual void Update()
// "virtual void Update()"
public void Update() {
	VTK_API.API_vtkLocator.Update_0(this);
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkLocator.Initialize_0(this);
}


// virtual void BuildLocator()
// "virtual void BuildLocator()"
public void BuildLocator() {
	VTK_API.API_vtkLocator.BuildLocator_0(this);
}


// virtual void FreeSearchStructure()
// "virtual void FreeSearchStructure()"
public void FreeSearchStructure() {
	VTK_API.API_vtkLocator.FreeSearchStructure_0(this);
}


// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// "virtual void GenerateRepresentation(int level, vtkPolyData *pd)"
public void GenerateRepresentation(int /*(int)*/ level, vtkPolyData /*(vtkPolyData*)*/ pd) {
	VTK_API.API_vtkLocator.GenerateRepresentation_0(this, level, pd);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase *o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.UnRegister_0(this, o);
}


}
};
