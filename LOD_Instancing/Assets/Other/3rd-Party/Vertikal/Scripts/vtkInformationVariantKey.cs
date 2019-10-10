

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationVariantKey : vtkInformationKey {
		public vtkInformationVariantKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationVariantKey(IntPtr p) {return new vtkInformationVariantKey(p);}
		public static implicit operator  IntPtr(vtkInformationVariantKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVariantKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVariantKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationVariantKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationVariantKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationVariantKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVariantKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationVariantKey)(IntPtr)returnPointer;
}


// vtkInformationVariantKey* NewInstance()
// "vtkInformationVariantKey *NewInstance()"
public vtkInformationVariantKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVariantKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationVariantKey)(IntPtr)returnPointer;
}


// static vtkInformationVariantKey* MakeKey(const char * name, const char * location)
// "static vtkInformationVariantKey* MakeKey(const char* name, const char* location)"
public static vtkInformationVariantKey MakeKey(string /*(char*)*/ name, string /*(char*)*/ location) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVariantKey.MakeKey_0(returnPointer.GetPtr(), name, location);
	return (vtkInformationVariantKey)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationVariantKey.ShallowCopy_0(this, from, to);
}


}
};
