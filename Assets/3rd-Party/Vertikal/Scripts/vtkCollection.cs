

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCollection : vtkObject {
		public vtkCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkCollection(IntPtr p) {return new vtkCollection(p);}
		public static implicit operator  IntPtr(vtkCollection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCollection)(IntPtr)returnPointer;
}


// vtkCollection* NewInstance()
// "vtkCollection *NewInstance()"
public vtkCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCollection)(IntPtr)returnPointer;
}


// static vtkCollection* New()
// "static vtkCollection *New()"
public static vtkCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.New_0(returnPointer.GetPtr());
	return (vtkCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkObject * ARG_0)
// "void AddItem(vtkObject *)"
public void AddItem(vtkObject /*(vtkObject*)*/ ARG_0) {
	VTK_API.API_vtkCollection.AddItem_0(this, ARG_0);
}


// void InsertItem(int i, vtkObject * ARG_0)
// "void InsertItem(int i, vtkObject *)"
public void InsertItem(int /*(int)*/ i, vtkObject /*(vtkObject*)*/ ARG_0) {
	VTK_API.API_vtkCollection.InsertItem_0(this, i, ARG_0);
}


// void ReplaceItem(int i, vtkObject * ARG_0)
// "void ReplaceItem(int i, vtkObject *)"
public void ReplaceItem(int /*(int)*/ i, vtkObject /*(vtkObject*)*/ ARG_0) {
	VTK_API.API_vtkCollection.ReplaceItem_0(this, i, ARG_0);
}


// void RemoveItem(int i)
// "void RemoveItem(int i)"
public void RemoveItem(int /*(int)*/ i) {
	VTK_API.API_vtkCollection.RemoveItem_0(this, i);
}


// void RemoveItem(vtkObject * ARG_0)
// "void RemoveItem(vtkObject *)"
public void RemoveItem(vtkObject /*(vtkObject*)*/ ARG_0) {
	VTK_API.API_vtkCollection.RemoveItem_1(this, ARG_0);
}


// void RemoveAllItems()
// "void RemoveAllItems()"
public void RemoveAllItems() {
	VTK_API.API_vtkCollection.RemoveAllItems_0(this);
}


// int IsItemPresent(vtkObject * a)
// "int IsItemPresent(vtkObject *a)"
public int IsItemPresent(vtkObject /*(vtkObject*)*/ a) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCollection.IsItemPresent_0(returnPointer.GetPtr(), this, a);
	return (int)returnPointer;
}


// int GetNumberOfItems()
// "int GetNumberOfItems()"
public int GetNumberOfItems() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCollection.GetNumberOfItems_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCollection.InitTraversal_0(this);
}


// vtkObject* GetNextItemAsObject()
// "vtkObject *GetNextItemAsObject()"
public vtkObject GetNextItemAsObject() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.GetNextItemAsObject_0(returnPointer.GetPtr(), this);
	return (vtkObject)(IntPtr)returnPointer;
}


// vtkObject* GetItemAsObject(int i)
// "vtkObject *GetItemAsObject(int i)"
public vtkObject GetItemAsObject(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.GetItemAsObject_0(returnPointer.GetPtr(), this, i);
	return (vtkObject)(IntPtr)returnPointer;
}


// vtkCollectionIterator* NewIterator()
// "vtkCollectionIterator* NewIterator()"
public vtkCollectionIterator NewIterator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCollection.NewIterator_0(returnPointer.GetPtr(), this);
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkCollection.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkCollection.UnRegister_0(this, o);
}


}
};
