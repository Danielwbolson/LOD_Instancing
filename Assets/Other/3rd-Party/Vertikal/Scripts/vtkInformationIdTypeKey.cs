

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationIdTypeKey : vtkInformationKey {
		public vtkInformationIdTypeKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationIdTypeKey(IntPtr p) {return new vtkInformationIdTypeKey(p);}
		public static implicit operator  IntPtr(vtkInformationIdTypeKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIdTypeKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIdTypeKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationIdTypeKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationIdTypeKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationIdTypeKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIdTypeKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationIdTypeKey)(IntPtr)returnPointer;
}


// vtkInformationIdTypeKey* NewInstance()
// "vtkInformationIdTypeKey *NewInstance()"
public vtkInformationIdTypeKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIdTypeKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationIdTypeKey)(IntPtr)returnPointer;
}


// static vtkInformationIdTypeKey* MakeKey(const char * name, const char * location)
// "static vtkInformationIdTypeKey* MakeKey(const char* name, const char* location)"
public static vtkInformationIdTypeKey MakeKey(string /*(char*)*/ name, string /*(char*)*/ location) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIdTypeKey.MakeKey_0(returnPointer.GetPtr(), name, location);
	return (vtkInformationIdTypeKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, vtkIdType ARG_0)
// "void Set(vtkInformation* info, vtkIdType)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, long /*(vtkIdType)*/ ARG_0) {
	VTK_API.API_vtkInformationIdTypeKey.Set_0(this, info, ARG_0);
}


// vtkIdType Get(vtkInformation * info)
// "vtkIdType Get(vtkInformation* info)"
public long Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkInformationIdTypeKey.Get_0(returnPointer.GetPtr(), this, info);
	return (long)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationIdTypeKey.ShallowCopy_0(this, from, to);
}


}
};
