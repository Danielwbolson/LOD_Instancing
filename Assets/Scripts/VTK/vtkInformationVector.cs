

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationVector : vtkObject {
		public vtkInformationVector(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationVector(IntPtr p) {return new vtkInformationVector(p);}
		public static implicit operator  IntPtr(vtkInformationVector o) {return o.GetPtr();}

// static vtkInformationVector* New()
// "static vtkInformationVector *New()"
public static vtkInformationVector New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVector.New_0(returnPointer.GetPtr());
	return (vtkInformationVector)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVector.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVector.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationVector* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationVector* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationVector SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVector.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationVector)(IntPtr)returnPointer;
}


// vtkInformationVector* NewInstance()
// "vtkInformationVector *NewInstance()"
public vtkInformationVector NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVector.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationVector)(IntPtr)returnPointer;
}


// int GetNumberOfInformationObjects()
// "int GetNumberOfInformationObjects()"
public int GetNumberOfInformationObjects() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationVector.GetNumberOfInformationObjects_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetNumberOfInformationObjects(int n)
// "void SetNumberOfInformationObjects(int n)"
public void SetNumberOfInformationObjects(int /*(int)*/ n) {
	VTK_API.API_vtkInformationVector.SetNumberOfInformationObjects_0(this, n);
}


// void SetInformationObject(int index, vtkInformation * info)
// "void SetInformationObject(int index, vtkInformation* info)"
public void SetInformationObject(int /*(int)*/ index, vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationVector.SetInformationObject_0(this, index, info);
}


// vtkInformation* GetInformationObject(int index)
// "vtkInformation* GetInformationObject(int index)"
public vtkInformation GetInformationObject(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVector.GetInformationObject_0(returnPointer.GetPtr(), this, index);
	return (vtkInformation)(IntPtr)returnPointer;
}


// void Append(vtkInformation * info)
// "void Append(vtkInformation* info)"
public void Append(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationVector.Append_0(this, info);
}


// void Remove(vtkInformation * info)
// "void Remove(vtkInformation* info)"
public void Remove(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationVector.Remove_0(this, info);
}


// void Remove(int idx)
// "void Remove(int idx)"
public void Remove(int /*(int)*/ idx) {
	VTK_API.API_vtkInformationVector.Remove_1(this, idx);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkInformationVector.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkInformationVector.UnRegister_0(this, o);
}


// void Copy(vtkInformationVector * from, int deep = 0)
// "void Copy(vtkInformationVector* from, int deep=0)"
public void Copy(vtkInformationVector /*(vtkInformationVector*)*/ from, int /*(int)*/ deep) {
	VTK_API.API_vtkInformationVector.Copy_0(this, from, deep);
}


}
};
