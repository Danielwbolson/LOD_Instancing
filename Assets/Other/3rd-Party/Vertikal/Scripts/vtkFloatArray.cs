

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFloatArray : vtkDataArray {
		public vtkFloatArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkFloatArray(IntPtr p) {return new vtkFloatArray(p);}
		public static implicit operator  IntPtr(vtkFloatArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFloatArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFloatArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkFloatArray* SafeDownCast(vtkObjectBase * o)
// "static vtkFloatArray* SafeDownCast(vtkObjectBase *o)"
public static vtkFloatArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFloatArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// vtkFloatArray* NewInstance()
// "vtkFloatArray *NewInstance()"
public vtkFloatArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFloatArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static vtkFloatArray* New()
// "static vtkFloatArray* New()"
public static vtkFloatArray New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFloatArray.New_0(returnPointer.GetPtr());
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static vtkFloatArray* FastDownCast(vtkAbstractArray * source)
// "static vtkFloatArray* FastDownCast(vtkAbstractArray *source)"
public static vtkFloatArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFloatArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static float GetDataTypeValueMin()
// "static float GetDataTypeValueMin()"
public static float GetDataTypeValueMin() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFloatArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (float)returnPointer;
}


// static float GetDataTypeValueMax()
// "static float GetDataTypeValueMax()"
public static float GetDataTypeValueMax() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkFloatArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (float)returnPointer;
}


}
};
