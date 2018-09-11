

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationKeyVectorKey : vtkInformationKey {
		public vtkInformationKeyVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationKeyVectorKey(IntPtr p) {return new vtkInformationKeyVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationKeyVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationKeyVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationKeyVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationKeyVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationKeyVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationKeyVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKeyVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationKeyVectorKey)(IntPtr)returnPointer;
}


// vtkInformationKeyVectorKey* NewInstance()
// "vtkInformationKeyVectorKey *NewInstance()"
public vtkInformationKeyVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationKeyVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationKeyVectorKey)(IntPtr)returnPointer;
}


}
};
