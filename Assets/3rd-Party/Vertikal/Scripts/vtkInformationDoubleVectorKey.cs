

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationDoubleVectorKey : vtkInformationKey {
		public vtkInformationDoubleVectorKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationDoubleVectorKey(IntPtr p) {return new vtkInformationDoubleVectorKey(p);}
		public static implicit operator  IntPtr(vtkInformationDoubleVectorKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDoubleVectorKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDoubleVectorKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationDoubleVectorKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationDoubleVectorKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationDoubleVectorKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleVectorKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// vtkInformationDoubleVectorKey* NewInstance()
// "vtkInformationDoubleVectorKey *NewInstance()"
public vtkInformationDoubleVectorKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleVectorKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// void Append(vtkInformation * info, double value)
// "void Append(vtkInformation* info, double value)"
public void Append(vtkInformation /*(vtkInformation*)*/ info, double /*(double)*/ value) {
	VTK_API.API_vtkInformationDoubleVectorKey.Append_0(this, info, value);
}


// void Set(vtkInformation * info, const double * value, int length)
// "void Set(vtkInformation* info, const double* value, int length)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value, int /*(int)*/ length) {
	VTK_API.API_vtkInformationDoubleVectorKey.Set_0(this, info, value, length);
}


// double* Get(vtkInformation * info)
// "double* Get(vtkInformation* info)"
public IntPtr Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleVectorKey.Get_0(returnPointer.GetPtr(), this, info);
	return (IntPtr)returnPointer;
}


// double Get(vtkInformation * info, int idx)
// "double Get(vtkInformation* info, int idx)"
public double Get(vtkInformation /*(vtkInformation*)*/ info, int /*(int)*/ idx) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkInformationDoubleVectorKey.Get_1(returnPointer.GetPtr(), this, info, idx);
	return (double)returnPointer;
}


// void Get(vtkInformation * info, double * value)
// "void Get(vtkInformation* info, double* value)"
public void Get(vtkInformation /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value) {
	VTK_API.API_vtkInformationDoubleVectorKey.Get_2(this, info, value);
}


// int Length(vtkInformation * info)
// "int Length(vtkInformation* info)"
public int Length(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkInformationDoubleVectorKey.Length_0(returnPointer.GetPtr(), this, info);
	return (int)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationDoubleVectorKey.ShallowCopy_0(this, from, to);
}


}
};
