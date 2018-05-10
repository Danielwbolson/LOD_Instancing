

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationIntegerPointerKey : vtkInformationKey {
		public vtkInformationIntegerPointerKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationIntegerPointerKey(IntPtr p) {return new vtkInformationIntegerPointerKey(p);}
		public static implicit operator  IntPtr(vtkInformationIntegerPointerKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerPointerKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerPointerKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationIntegerPointerKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationIntegerPointerKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationIntegerPointerKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerPointerKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationIntegerPointerKey)(IntPtr)returnPointer;
}


// vtkInformationIntegerPointerKey* NewInstance()
// "vtkInformationIntegerPointerKey *NewInstance()"
public vtkInformationIntegerPointerKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerPointerKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationIntegerPointerKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, int * value, int length)
// "void Set(vtkInformation* info, int* value, int length)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformationIntegerPointerKey.Set_0(this, info, value, length);
}


// int* Get(vtkInformation * info)
// "int* Get(vtkInformation* info)"
public IntPtr Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerPointerKey.Get_0(returnPointer.GetPtr(), this, info);
	return (IntPtr)returnPointer;
}


// void Get(vtkInformation * info, int * value)
// "void Get(vtkInformation* info, int* value)"
public void Get(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value) {
	VTK_API.API_vtkInformationIntegerPointerKey.Get_1(this, info, value);
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationIntegerPointerKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationIntegerPointerKey.ShallowCopy_0(this, from, to);
}


}
};
