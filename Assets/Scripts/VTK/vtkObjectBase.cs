

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObjectBase {

// char* GetClassName()
// "const char* GetClassName()"
public new char GetClassName() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkObjectBase.GetClassName_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkTypeBool IsTypeOf(const char * name)
// "static vtkTypeBool IsTypeOf(const char *name)"
public new static bool IsTypeOf(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkObjectBase.IsTypeOf_0(returnPointer, name);
	return Ptr.deref(returnPointer);
}


// virtual vtkTypeBool IsA(const char * name)
// "virtual vtkTypeBool IsA(const char *name)"
public new bool IsA(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkObjectBase.IsA_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// virtual void Delete()
// "virtual void Delete()"
public new void Delete() {
	API_vtkObjectBase.Delete_0(this);
}


// virtual void FastDelete()
// "virtual void FastDelete()"
public new void FastDelete() {
	API_vtkObjectBase.FastDelete_0(this);
}


// static vtkObjectBase* New()
// "static vtkObjectBase *New()"
public new static vtkObjectBase New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkObjectBase.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void InitializeObjectBase()
// "void InitializeObjectBase()"
public new void InitializeObjectBase() {
	API_vtkObjectBase.InitializeObjectBase_0(this);
}


// virtual void Register(vtkObjectBase * o)
// "virtual void Register(vtkObjectBase* o)"
public new void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkObjectBase.Register_0(this, o);
}


// virtual void UnRegister(vtkObjectBase * o)
// "virtual void UnRegister(vtkObjectBase* o)"
public new void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkObjectBase.UnRegister_0(this, o);
}


// int GetReferenceCount()
// "int GetReferenceCount()"
public new int GetReferenceCount() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObjectBase.GetReferenceCount_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetReferenceCount(int ARG_0)
// "void SetReferenceCount(int)"
public new void SetReferenceCount(int /*(int)*/ ARG_0) {
	API_vtkObjectBase.SetReferenceCount_0(this, ARG_0);
}


}
};
