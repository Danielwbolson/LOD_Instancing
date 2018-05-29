

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLightCollection : vtkCollection {
		public vtkLightCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkLightCollection(IntPtr p) {return new vtkLightCollection(p);}
		public static implicit operator  IntPtr(vtkLightCollection o) {return o.GetPtr();}

// static vtkLightCollection* New()
// "static vtkLightCollection *New()"
public static vtkLightCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLightCollection.New_0(returnPointer.GetPtr());
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLightCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLightCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkLightCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkLightCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkLightCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLightCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// vtkLightCollection* NewInstance()
// "vtkLightCollection *NewInstance()"
public vtkLightCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLightCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkLight * a)
// "void AddItem(vtkLight *a)"
public void AddItem(vtkLight /*(vtkLight*)*/ a) {
	VTK_API.API_vtkLightCollection.AddItem_0(this, a);
}


// vtkLight* GetNextItem()
// "vtkLight *GetNextItem()"
public vtkLight GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLightCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkLight)(IntPtr)returnPointer;
}


}
};
