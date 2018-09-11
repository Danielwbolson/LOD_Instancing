

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationIntegerVectorKey : vtkInformationKey {
		public vtkInformationIntegerVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationIntegerVectorKey(IntPtr p) {return new vtkInformationIntegerVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationIntegerVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationIntegerVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationIntegerVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationIntegerVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationIntegerVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationIntegerVectorKey)(IntPtr)returnPointer;
}


// vtkInformationIntegerVectorKey* NewInstance()
// "vtkInformationIntegerVectorKey *NewInstance()"
public vtkInformationIntegerVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationIntegerVectorKey)(IntPtr)returnPointer;
}


// void Append(vtkInformation * info, int value)
// "void Append(vtkInformation* info, int value)"
public void Append(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ value) {
	VTK_API.API_vtkInformationIntegerVectorKey.Append_0(this, info, value);
}


// void Set(vtkInformation * info, const int * value, int length)
// "void Set(vtkInformation* info, const int* value, int length)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformationIntegerVectorKey.Set_0(this, info, value, length);
}


// void Set(vtkInformation * info)
// "void Set(vtkInformation* info)"
public void Set(vtkInformation /*(vtkInformation*)*/ info) {
	VTK_API.API_vtkInformationIntegerVectorKey.Set_1(this, info);
}


// int* Get(vtkInformation * info)
// "int* Get(vtkInformation* info)"
public IntPtr Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationIntegerVectorKey.Get_0(returnPointer.GetPtr(), this, info);
	return (IntPtr)returnPointer;
}


// int Get(vtkInformation * info, int idx)
// "int Get(vtkInformation* info, int idx)"
public int Get(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationIntegerVectorKey.Get_1(returnPointer.GetPtr(), this, info, idx);
	return (int)returnPointer;
}


// void Get(vtkInformation * info, int * value)
// "void Get(vtkInformation* info, int* value)"
public void Get(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value) {
	VTK_API.API_vtkInformationIntegerVectorKey.Get_2(this, info, value);
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationIntegerVectorKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationIntegerVectorKey.ShallowCopy_0(this, from, to);
}


}
};
