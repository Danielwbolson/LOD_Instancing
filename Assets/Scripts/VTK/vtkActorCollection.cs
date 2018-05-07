

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActorCollection : vtkPropCollection {
		public vtkActorCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkActorCollection(IntPtr p) {return new vtkActorCollection(p);}
		public static implicit operator  IntPtr(vtkActorCollection o) {return o.GetPtr();}

// static vtkActorCollection* New()
// "static vtkActorCollection *New()"
public static vtkActorCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.New_0(returnPointer.GetPtr());
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActorCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActorCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkActorCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkActorCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkActorCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// vtkActorCollection* NewInstance()
// "vtkActorCollection *NewInstance()"
public vtkActorCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkActor * a)
// "void AddItem(vtkActor *a)"
public void AddItem(vtkActor /*(vtkActor*)*/ a) {
	VTK_API.API_vtkActorCollection.AddItem_0(this, a);
}


// vtkActor* GetNextActor()
// "vtkActor *GetNextActor()"
public vtkActor GetNextActor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.GetNextActor_0(returnPointer.GetPtr(), this);
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetLastActor()
// "vtkActor *GetLastActor()"
public vtkActor GetLastActor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.GetLastActor_0(returnPointer.GetPtr(), this);
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetNextItem()
// "vtkActor *GetNextItem()"
public vtkActor GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetLastItem()
// "vtkActor *GetLastItem()"
public vtkActor GetLastItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActorCollection.GetLastItem_0(returnPointer.GetPtr(), this);
	return (vtkActor)(IntPtr)returnPointer;
}


// void ApplyProperties(vtkProperty * p)
// "void ApplyProperties(vtkProperty *p)"
public void ApplyProperties(vtkProperty /*(vtkProperty*)*/ p) {
	VTK_API.API_vtkActorCollection.ApplyProperties_0(this, p);
}


}
};
