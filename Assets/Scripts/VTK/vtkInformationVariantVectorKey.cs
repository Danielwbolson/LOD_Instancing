

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationVariantVectorKey : vtkInformationKey {
		public vtkInformationVariantVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationVariantVectorKey(IntPtr p) {return new vtkInformationVariantVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationVariantVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVariantVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationVariantVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationVariantVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationVariantVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationVariantVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVariantVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationVariantVectorKey)(IntPtr)returnPointer;
}


// vtkInformationVariantVectorKey* NewInstance()
// "vtkInformationVariantVectorKey *NewInstance()"
public vtkInformationVariantVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationVariantVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationVariantVectorKey)(IntPtr)returnPointer;
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationVariantVectorKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationVariantVectorKey.ShallowCopy_0(this, from, to);
}


}
};
