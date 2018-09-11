

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationRequestKey : vtkInformationKey {
		public vtkInformationRequestKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationRequestKey(IntPtr p) {return new vtkInformationRequestKey(p);}
		public static implicit operator  IntPtr(vtkInformationRequestKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationRequestKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationRequestKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationRequestKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationRequestKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationRequestKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationRequestKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationRequestKey)(IntPtr)returnPointer;
}


// vtkInformationRequestKey* NewInstance()
// "vtkInformationRequestKey *NewInstance()"
public vtkInformationRequestKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationRequestKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationRequestKey)(IntPtr)returnPointer;
}


}
};
