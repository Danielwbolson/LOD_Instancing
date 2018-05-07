

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProp3DCollection : vtkPropCollection {
		public vtkProp3DCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkProp3DCollection(IntPtr p) {return new vtkProp3DCollection(p);}
		public static implicit operator  IntPtr(vtkProp3DCollection o) {return o.GetPtr();}

// static vtkProp3DCollection* New()
// "static vtkProp3DCollection *New()"
public static vtkProp3DCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3DCollection.New_0(returnPointer.GetPtr());
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp3DCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp3DCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProp3DCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkProp3DCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkProp3DCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3DCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// vtkProp3DCollection* NewInstance()
// "vtkProp3DCollection *NewInstance()"
public vtkProp3DCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3DCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkProp3D * p)
// "void AddItem(vtkProp3D *p)"
public void AddItem(vtkProp3D /*(vtkProp3D*)*/ p) {
	VTK_API.API_vtkProp3DCollection.AddItem_0(this, p);
}


// vtkProp3D* GetNextProp3D()
// "vtkProp3D *GetNextProp3D()"
public vtkProp3D GetNextProp3D() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3DCollection.GetNextProp3D_0(returnPointer.GetPtr(), this);
	return (vtkProp3D)(IntPtr)returnPointer;
}


// vtkProp3D* GetLastProp3D()
// "vtkProp3D *GetLastProp3D()"
public vtkProp3D GetLastProp3D() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3DCollection.GetLastProp3D_0(returnPointer.GetPtr(), this);
	return (vtkProp3D)(IntPtr)returnPointer;
}


}
};
