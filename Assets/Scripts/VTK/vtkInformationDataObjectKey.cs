

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationDataObjectKey : vtkInformationKey {
		public vtkInformationDataObjectKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationDataObjectKey(IntPtr p) {return new vtkInformationDataObjectKey(p);}
		public static implicit operator  IntPtr(vtkInformationDataObjectKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDataObjectKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDataObjectKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationDataObjectKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationDataObjectKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationDataObjectKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDataObjectKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationDataObjectKey)(IntPtr)returnPointer;
}


// vtkInformationDataObjectKey* NewInstance()
// "vtkInformationDataObjectKey *NewInstance()"
public vtkInformationDataObjectKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDataObjectKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationDataObjectKey)(IntPtr)returnPointer;
}


}
};
