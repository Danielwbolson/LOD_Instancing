

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPropCollection : vtkCollection {
		public vtkPropCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkPropCollection(IntPtr p) {return new vtkPropCollection(p);}
		public static implicit operator  IntPtr(vtkPropCollection o) {return o.GetPtr();}

// static vtkPropCollection* New()
// "static vtkPropCollection *New()"
public static vtkPropCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropCollection.New_0(returnPointer.GetPtr());
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPropCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPropCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPropCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkPropCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkPropCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// vtkPropCollection* NewInstance()
// "vtkPropCollection *NewInstance()"
public vtkPropCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkProp * a)
// "void AddItem(vtkProp *a)"
public void AddItem(vtkProp /*(vtkProp*)*/ a) {
	VTK_API.API_vtkPropCollection.AddItem_0(this, a);
}


// vtkProp* GetNextProp()
// "vtkProp *GetNextProp()"
public vtkProp GetNextProp() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropCollection.GetNextProp_0(returnPointer.GetPtr(), this);
	return (vtkProp)(IntPtr)returnPointer;
}


// vtkProp* GetLastProp()
// "vtkProp *GetLastProp()"
public vtkProp GetLastProp() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropCollection.GetLastProp_0(returnPointer.GetPtr(), this);
	return (vtkProp)(IntPtr)returnPointer;
}


// int GetNumberOfPaths()
// "int GetNumberOfPaths()"
public int GetNumberOfPaths() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropCollection.GetNumberOfPaths_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
