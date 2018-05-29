

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationIntegerKey : vtkInformationKey {
		public vtkInformationIntegerKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationIntegerKey(IntPtr p) {return new vtkInformationIntegerKey(p);}
		public static implicit operator  IntPtr(vtkInformationIntegerKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationIntegerKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationIntegerKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationIntegerKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// vtkInformationIntegerKey* NewInstance()
// "vtkInformationIntegerKey *NewInstance()"
public vtkInformationIntegerKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationIntegerKey* MakeKey(const char * name, const char * location)
// "static vtkInformationIntegerKey* MakeKey(const char* name, const char* location)"
public static vtkInformationIntegerKey MakeKey(string /*(char*)*/ name, string /*(char*)*/ location) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerKey.MakeKey_0(returnPointer.GetPtr(), name, location);
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, int ARG_0)
// "void Set(vtkInformation* info, int)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ ARG_0) {
	VTK_API.API_vtkInformationIntegerKey.Set_0(this, info, ARG_0);
}


// int Get(vtkInformation * info)
// "int Get(vtkInformation* info)"
public int Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationIntegerKey.Get_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationIntegerKey.ShallowCopy_0(this, from, to);
}


}
};
