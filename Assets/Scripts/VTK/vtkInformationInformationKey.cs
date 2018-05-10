

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationInformationKey : vtkInformationKey {
		public vtkInformationInformationKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationInformationKey(IntPtr p) {return new vtkInformationInformationKey(p);}
		public static implicit operator  IntPtr(vtkInformationInformationKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationInformationKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationInformationKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationInformationKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationInformationKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationInformationKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationInformationKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationInformationKey)(IntPtr)returnPointer;
}


// vtkInformationInformationKey* NewInstance()
// "vtkInformationInformationKey *NewInstance()"
public vtkInformationInformationKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationInformationKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationInformationKey)(IntPtr)returnPointer;
}


}
};
