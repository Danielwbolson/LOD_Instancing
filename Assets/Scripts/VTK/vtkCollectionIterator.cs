

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCollectionIterator : vtkObject {
		public vtkCollectionIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkCollectionIterator(IntPtr p) {return new vtkCollectionIterator(p);}
		public static implicit operator  IntPtr(vtkCollectionIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCollectionIterator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCollectionIterator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCollectionIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkCollectionIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkCollectionIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollectionIterator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// vtkCollectionIterator* NewInstance()
// "vtkCollectionIterator *NewInstance()"
public vtkCollectionIterator NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollectionIterator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// static vtkCollectionIterator* New()
// "static vtkCollectionIterator* New()"
public static vtkCollectionIterator New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollectionIterator.New_0(returnPointer.GetPtr());
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// virtual void SetCollection(vtkCollection * ARG_0)
// "virtual void SetCollection(vtkCollection*)"
public void SetCollection(vtkCollection /*(vtkCollection*)*/ ARG_0) {
	VTK_API.API_vtkCollectionIterator.SetCollection_0(this, ARG_0);
}


// virtual vtkCollection* GetCollection()
// "virtual vtkCollection *GetCollection ()"
public vtkCollection GetCollection() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollectionIterator.GetCollection_0(returnPointer.GetPtr(), this);
	return (vtkCollection)(IntPtr)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCollectionIterator.InitTraversal_0(this);
}


// void GoToFirstItem()
// "void GoToFirstItem()"
public void GoToFirstItem() {
	VTK_API.API_vtkCollectionIterator.GoToFirstItem_0(this);
}


// void GoToNextItem()
// "void GoToNextItem()"
public void GoToNextItem() {
	VTK_API.API_vtkCollectionIterator.GoToNextItem_0(this);
}


// int IsDoneWithTraversal()
// "int IsDoneWithTraversal()"
public int IsDoneWithTraversal() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCollectionIterator.IsDoneWithTraversal_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkObject* GetCurrentObject()
// "vtkObject* GetCurrentObject()"
public vtkObject GetCurrentObject() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollectionIterator.GetCurrentObject_0(returnPointer.GetPtr(), this);
	return (vtkObject)(IntPtr)returnPointer;
}


}
};
