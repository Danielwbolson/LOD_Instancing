

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVolumeCollection : vtkPropCollection {
		public vtkVolumeCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkVolumeCollection(IntPtr p) {return new vtkVolumeCollection(p);}
		public static implicit operator  IntPtr(vtkVolumeCollection o) {return o.GetPtr();}

// static vtkVolumeCollection* New()
// "static vtkVolumeCollection *New()"
public static vtkVolumeCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeCollection.New_0(returnPointer.GetPtr());
	return (vtkVolumeCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolumeCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolumeCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkVolumeCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkVolumeCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkVolumeCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkVolumeCollection)(IntPtr)returnPointer;
}


// vtkVolumeCollection* NewInstance()
// "vtkVolumeCollection *NewInstance()"
public vtkVolumeCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkVolumeCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkVolume * a)
// "void AddItem(vtkVolume *a)"
public void AddItem(vtkVolume /*(vtkVolume*)*/ a) {
	VTK_API.API_vtkVolumeCollection.AddItem_0(this, a);
}


// vtkVolume* GetNextVolume()
// "vtkVolume *GetNextVolume()"
public vtkVolume GetNextVolume() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeCollection.GetNextVolume_0(returnPointer.GetPtr(), this);
	return (vtkVolume)(IntPtr)returnPointer;
}


// vtkVolume* GetNextItem()
// "vtkVolume *GetNextItem()"
public vtkVolume GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkVolume)(IntPtr)returnPointer;
}


}
};
