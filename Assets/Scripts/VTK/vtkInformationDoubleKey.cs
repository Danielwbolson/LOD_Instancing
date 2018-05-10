

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInformationDoubleKey : vtkInformationKey {
		public vtkInformationDoubleKey(IntPtr p) : base(p) {}
		public static implicit operator  vtkInformationDoubleKey(IntPtr p) {return new vtkInformationDoubleKey(p);}
		public static implicit operator  IntPtr(vtkInformationDoubleKey o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDoubleKey.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkInformationDoubleKey.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkInformationDoubleKey* SafeDownCast(vtkObjectBase * o)
// "static vtkInformationDoubleKey* SafeDownCast(vtkObjectBase *o)"
public static vtkInformationDoubleKey SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleKey.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkInformationDoubleKey)(IntPtr)returnPointer;
}


// vtkInformationDoubleKey* NewInstance()
// "vtkInformationDoubleKey *NewInstance()"
public vtkInformationDoubleKey NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleKey.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkInformationDoubleKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleKey* MakeKey(const char * name, const char * location)
// "static vtkInformationDoubleKey* MakeKey(const char* name, const char* location)"
public static vtkInformationDoubleKey MakeKey(string /*(char*)*/ name, string /*(char*)*/ location) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkInformationDoubleKey.MakeKey_0(returnPointer.GetPtr(), name, location);
	return (vtkInformationDoubleKey)(IntPtr)returnPointer;
}


// void Set(vtkInformation * info, double ARG_0)
// "void Set(vtkInformation* info, double)"
public void Set(vtkInformation /*(vtkInformation*)*/ info, double /*(double)*/ ARG_0) {
	VTK_API.API_vtkInformationDoubleKey.Set_0(this, info, ARG_0);
}


// double Get(vtkInformation * info)
// "double Get(vtkInformation* info)"
public double Get(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkInformationDoubleKey.Get_0(returnPointer.GetPtr(), this, info);
	return (double)returnPointer;
}


// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// "void ShallowCopy(vtkInformation* from, vtkInformation* to)"
public void ShallowCopy(vtkInformation /*(vtkInformation*)*/ from, vtkInformation /*(vtkInformation*)*/ to) {
	VTK_API.API_vtkInformationDoubleKey.ShallowCopy_0(this, from, to);
}


}
};
