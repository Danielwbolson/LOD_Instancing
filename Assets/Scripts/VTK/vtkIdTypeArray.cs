

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdTypeArray : vtkDataArray {
		public vtkIdTypeArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkIdTypeArray(IntPtr p) {return new vtkIdTypeArray(p);}
		public static implicit operator  IntPtr(vtkIdTypeArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkIdTypeArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkIdTypeArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkIdTypeArray* SafeDownCast(vtkObjectBase * o)
// "static vtkIdTypeArray* SafeDownCast(vtkObjectBase *o)"
public static vtkIdTypeArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkIdTypeArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* NewInstance()
// "vtkIdTypeArray *NewInstance()"
public vtkIdTypeArray NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkIdTypeArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// static vtkIdTypeArray* New()
// "static vtkIdTypeArray* New()"
public static vtkIdTypeArray New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkIdTypeArray.New_0(returnPointer.GetPtr());
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// int GetDataType()
// "int GetDataType()"
public int GetDataType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkIdTypeArray.GetDataType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// static vtkIdTypeArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIdTypeArray* FastDownCast(vtkAbstractArray *source)"
public static vtkIdTypeArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkIdTypeArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// static vtkIdType GetDataTypeValueMin()
// "static vtkIdType GetDataTypeValueMin()"
public static long GetDataTypeValueMin() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkIdTypeArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (long)returnPointer;
}


// static vtkIdType GetDataTypeValueMax()
// "static vtkIdType GetDataTypeValueMax()"
public static long GetDataTypeValueMax() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkIdTypeArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (long)returnPointer;
}


}
};
