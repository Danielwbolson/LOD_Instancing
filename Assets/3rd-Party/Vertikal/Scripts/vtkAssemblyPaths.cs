

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssemblyPaths : vtkCollection {
		public vtkAssemblyPaths(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssemblyPaths(IntPtr p) {return new vtkAssemblyPaths(p);}
		public static implicit operator  IntPtr(vtkAssemblyPaths o) {return o.GetPtr();}

// static vtkAssemblyPaths* New()
// "static vtkAssemblyPaths *New()"
public static vtkAssemblyPaths New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyPaths.New_0(returnPointer.GetPtr());
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAssemblyPaths.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAssemblyPaths.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAssemblyPaths* SafeDownCast(vtkObjectBase * o)
// "static vtkAssemblyPaths* SafeDownCast(vtkObjectBase *o)"
public static vtkAssemblyPaths SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyPaths.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// vtkAssemblyPaths* NewInstance()
// "vtkAssemblyPaths *NewInstance()"
public vtkAssemblyPaths NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyPaths.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// void AddItem(vtkAssemblyPath * p)
// "void AddItem(vtkAssemblyPath *p)"
public void AddItem(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
	VTK_API.API_vtkAssemblyPaths.AddItem_0(this, p);
}


// void RemoveItem(vtkAssemblyPath * p)
// "void RemoveItem(vtkAssemblyPath *p)"
public void RemoveItem(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
	VTK_API.API_vtkAssemblyPaths.RemoveItem_0(this, p);
}


// int IsItemPresent(vtkAssemblyPath * p)
// "int IsItemPresent(vtkAssemblyPath *p)"
public int IsItemPresent(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAssemblyPaths.IsItemPresent_0(returnPointer.GetPtr(), this, p);
	return (int)returnPointer;
}


// vtkAssemblyPath* GetNextItem()
// "vtkAssemblyPath *GetNextItem()"
public vtkAssemblyPath GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAssemblyPaths.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkAssemblyPaths.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


}
};
