

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCullerCollection : vtkCollection {
		public vtkCullerCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkCullerCollection(IntPtr p) {return new vtkCullerCollection(p);}
		public static implicit operator  IntPtr(vtkCullerCollection o) {return o.GetPtr();}

// static vtkCullerCollection* New()
// "static vtkCullerCollection *New()"
public static vtkCullerCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCullerCollection.New_0(returnPointer.GetPtr());
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCullerCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCullerCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCullerCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkCullerCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkCullerCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCullerCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// vtkCullerCollection* NewInstance()
// "vtkCullerCollection *NewInstance()"
public vtkCullerCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCullerCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkCuller * a)
// "void AddItem(vtkCuller *a)"
public void AddItem(vtkCuller /*(vtkCuller*)*/ a) {
	VTK_API.API_vtkCullerCollection.AddItem_0(this, a);
}


// vtkCuller* GetNextItem()
// "vtkCuller *GetNextItem()"
public vtkCuller GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCullerCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkCuller)(IntPtr)returnPointer;
}


// vtkCuller* GetLastItem()
// "vtkCuller *GetLastItem()"
public vtkCuller GetLastItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCullerCollection.GetLastItem_0(returnPointer.GetPtr(), this);
	return (vtkCuller)(IntPtr)returnPointer;
}


}
};
