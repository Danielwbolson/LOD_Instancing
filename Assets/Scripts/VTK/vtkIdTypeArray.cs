

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdTypeArray : vtkDataArray {

// static vtkIdTypeArray* New()
// "static vtkIdTypeArray* New()"
public new static vtkIdTypeArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkIdTypeArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataType()
// "int GetDataType()"
public new int GetDataType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIdTypeArray.GetDataType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkIdTypeArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIdTypeArray* FastDownCast(vtkAbstractArray *source)"
public new static vtkIdTypeArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkIdTypeArray.FastDownCast_0(returnPointer, source);
	return Ptr.deref(returnPointer);
}


// static vtkIdType GetDataTypeValueMin()
// "static vtkIdType GetDataTypeValueMin()"
public new static long GetDataTypeValueMin() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdTypeArray.GetDataTypeValueMin_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkIdType GetDataTypeValueMax()
// "static vtkIdType GetDataTypeValueMax()"
public new static long GetDataTypeValueMax() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdTypeArray.GetDataTypeValueMax_0(returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
