

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationStringKey : vtkInformationKey {
		public vtkInformationStringKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationStringKey(IntPtr p) {return new vtkInformationStringKey(p);}
		public static implicit operator  IntPtr(vtkInformationStringKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationStringKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationStringKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationStringKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationStringKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationStringKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationStringKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationStringKey)(IntPtr)returnPointer;
}


// vtkInformationStringKey* NewInstance()
// "vtkInformationStringKey *NewInstance()"
public vtkInformationStringKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationStringKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationStringKey)(IntPtr)returnPointer;
}


}
};
