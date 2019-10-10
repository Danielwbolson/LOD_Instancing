

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPlaneCollection : vtkCollection {
		public vtkPlaneCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkPlaneCollection(IntPtr p) {return new vtkPlaneCollection(p);}
		public static implicit operator  IntPtr(vtkPlaneCollection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlaneCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlaneCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPlaneCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkPlaneCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkPlaneCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlaneCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// vtkPlaneCollection* NewInstance()
// "vtkPlaneCollection *NewInstance()"
public vtkPlaneCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlaneCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// static vtkPlaneCollection* New()
// "static vtkPlaneCollection *New()"
public static vtkPlaneCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlaneCollection.New_0(returnPointer.GetPtr());
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkPlane * ARG_0)
// "void AddItem(vtkPlane *)"
public void AddItem(vtkPlane /*(vtkPlane*)*/ ARG_0) {
	VTK_API.API_vtkPlaneCollection.AddItem_0(this, ARG_0);
}


// vtkPlane* GetNextItem()
// "vtkPlane *GetNextItem()"
public vtkPlane GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlaneCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkPlane)(IntPtr)returnPointer;
}


// vtkPlane* GetItem(int i)
// "vtkPlane *GetItem(int i)"
public vtkPlane GetItem(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlaneCollection.GetItem_0(returnPointer.GetPtr(), this, i);
	return (vtkPlane)(IntPtr)returnPointer;
}


}
};
