

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDoubleArray : vtkDataArray {
		public vtkDoubleArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkDoubleArray(IntPtr p) {return new vtkDoubleArray(p);}
		public static implicit operator  IntPtr(vtkDoubleArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDoubleArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDoubleArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkDoubleArray* SafeDownCast(vtkObjectBase * o)
// "static vtkDoubleArray* SafeDownCast(vtkObjectBase *o)"
public static vtkDoubleArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDoubleArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// vtkDoubleArray* NewInstance()
// "vtkDoubleArray *NewInstance()"
public vtkDoubleArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDoubleArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static vtkDoubleArray* New()
// "static vtkDoubleArray* New()"
public static vtkDoubleArray New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDoubleArray.New_0(returnPointer.GetPtr());
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static vtkDoubleArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDoubleArray* FastDownCast(vtkAbstractArray *source)"
public static vtkDoubleArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDoubleArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static double GetDataTypeValueMin()
// "static double GetDataTypeValueMin()"
public static double GetDataTypeValueMin() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (double)returnPointer;
}


// static double GetDataTypeValueMax()
// "static double GetDataTypeValueMax()"
public static double GetDataTypeValueMax() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (double)returnPointer;
}


}
};
