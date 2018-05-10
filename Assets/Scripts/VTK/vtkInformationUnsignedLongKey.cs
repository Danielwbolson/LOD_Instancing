

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationUnsignedLongKey : vtkInformationKey {
		public vtkInformationUnsignedLongKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationUnsignedLongKey(IntPtr p) {return new vtkInformationUnsignedLongKey(p);}
		public static implicit operator  IntPtr(vtkInformationUnsignedLongKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationUnsignedLongKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationUnsignedLongKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationUnsignedLongKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationUnsignedLongKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationUnsignedLongKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationUnsignedLongKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationUnsignedLongKey)(IntPtr)returnPointer;
}


// vtkInformationUnsignedLongKey* NewInstance()
// "vtkInformationUnsignedLongKey *NewInstance()"
public vtkInformationUnsignedLongKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationUnsignedLongKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationUnsignedLongKey)(IntPtr)returnPointer;
}


// static vtkInformationUnsignedLongKey* MakeKey(const char * name, const char * location)
// "static vtkInformationUnsignedLongKey* MakeKey(const char* name, const char* location)"
public static vtkInformationUnsignedLongKey MakeKey(string /*(char*)*/ name, string /*(char*)*/ location) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationUnsignedLongKey.MakeKey_0(returnPointer.GetPtr(), name, location);
	return (vtkInformationUnsignedLongKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, unsigned long ARG_0)
// "void Set(vtkInformation* info, unsigned long)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, ulong /*(unsigned long)*/ ARG_0) {
	VTK_API.API_vtkInformationUnsignedLongKey.Set_0(this, info, ARG_0);
}


// long Get(vtkInformation * info)
// "unsigned long Get(vtkInformation* info)"
public ulong Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkInformationUnsignedLongKey.Get_0(returnPointer.GetPtr(), this, info);
	return (ulong)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationUnsignedLongKey.ShallowCopy_0(this, from, to);
}


}
};
