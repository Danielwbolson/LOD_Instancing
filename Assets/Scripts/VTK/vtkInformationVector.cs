
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkInformationVector : vtkObject {

//       Method: static vtkInformationVector * vtkInformationVector::New()
// 
public static vtkInformationVector New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationVector.New(p);
	vtkInformationVector result = new vtkInformationVector();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkInformationVector::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkInformationVector.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkInformationVector::GetNumberOfInformationObjects()
// 
public int GetNumberOfInformationObjects() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationVector.GetNumberOfInformationObjects(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkInformationVector::SetNumberOfInformationObjects(int n)
// 
public void SetNumberOfInformationObjects(int n) {
	VTK.API_vtkInformationVector.SetNumberOfInformationObjects(obj, n);
}


//       Method: void vtkInformationVector::SetInformationObject(int index, vtkInformation* info)
// 
public void SetInformationObject(int index, vtkInformation/*vtkInformation* */ info) {
	VTK.API_vtkInformationVector.SetInformationObject(obj, index, info);
}


//       Method: vtkInformation * vtkInformationVector::GetInformationObject(int index)
// 
public vtkInformation GetInformationObject(int index) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkInformationVector.GetInformationObject(p,obj, index);
	vtkInformation result = new vtkInformation();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkInformationVector::Append(vtkInformation* info)
// 
public void Append(vtkInformation/*vtkInformation* */ info) {
	VTK.API_vtkInformationVector.Append(obj, info);
}


//       Method: void vtkInformationVector::Remove(vtkInformation* info)
// 
public void Remove(vtkInformation/*vtkInformation* */ info) {
	VTK.API_vtkInformationVector.Remove(obj, info);
}


//       Method: void vtkInformationVector::Remove(int idx)
// 
public void Remove(int idx) {
	VTK.API_vtkInformationVector.Remove(obj, idx);
}


//       Method: void vtkInformationVector::Register(vtkObjectBase* o)
// 
public void Register(vtkObjectBase/*vtkObjectBase* */ o) {
	VTK.API_vtkInformationVector.Register(obj, o);
}


//       Method: void vtkInformationVector::UnRegister(vtkObjectBase* o)
// 
public void UnRegister(vtkObjectBase/*vtkObjectBase* */ o) {
	VTK.API_vtkInformationVector.UnRegister(obj, o);
}


//       Method: void vtkInformationVector::Copy(vtkInformationVector* from, int deep)
// 
public void Copy(vtkInformationVector/*vtkInformationVector* */ from, int deep) {
	VTK.API_vtkInformationVector.Copy(obj, from, deep);
}


}
};
