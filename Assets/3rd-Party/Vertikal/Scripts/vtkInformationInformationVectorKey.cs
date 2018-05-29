

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationInformationVectorKey : vtkInformationKey {
		public vtkInformationInformationVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationInformationVectorKey(IntPtr p) {return new vtkInformationInformationVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationInformationVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationInformationVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationInformationVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationInformationVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationInformationVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationInformationVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationInformationVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


// vtkInformationInformationVectorKey* NewInstance()
// "vtkInformationInformationVectorKey *NewInstance()"
public vtkInformationInformationVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationInformationVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationInformationVectorKey)(IntPtr)returnPointer;
}


}
};
