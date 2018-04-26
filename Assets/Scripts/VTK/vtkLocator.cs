
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkLocator : vtkObject {

//       Method: virtual const char * vtkLocator::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkLocator.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkLocator::Update()
// 
public void Update() {
	VTK.API_vtkLocator.Update(obj);
}


//       Method: virtual void vtkLocator::Initialize()
// 
public void Initialize() {
	VTK.API_vtkLocator.Initialize(obj);
}


//       Method: virtual void vtkLocator::BuildLocator()
// 
public void BuildLocator() {
	VTK.API_vtkLocator.BuildLocator(obj);
}


//       Method: virtual void vtkLocator::FreeSearchStructure()
// 
public void FreeSearchStructure() {
	VTK.API_vtkLocator.FreeSearchStructure(obj);
}


//       Method: virtual void vtkLocator::GenerateRepresentation(int level, vtkPolyData* pd)
// 
public void GenerateRepresentation(int level, vtkPolyData/*vtkPolyData* */ pd) {
	VTK.API_vtkLocator.GenerateRepresentation(obj, level, pd);
}


//       Method: void vtkLocator::Register(vtkObjectBase* o)
// 
public void Register(vtkObjectBase/*vtkObjectBase* */ o) {
	VTK.API_vtkLocator.Register(obj, o);
}


//       Method: void vtkLocator::UnRegister(vtkObjectBase* o)
// 
public void UnRegister(vtkObjectBase/*vtkObjectBase* */ o) {
	VTK.API_vtkLocator.UnRegister(obj, o);
}


}
};
