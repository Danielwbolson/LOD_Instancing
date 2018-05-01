

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIntArray : vtkDataArray {

// static vtkIntArray* New()
// "static vtkIntArray* New()"
public new static vtkIntArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkIntArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkIntArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIntArray* FastDownCast(vtkAbstractArray *source)"
public new static vtkIntArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkIntArray.FastDownCast_0(returnPointer, source);
	return Ptr.deref(returnPointer);
}


// static int GetDataTypeValueMin()
// "static int GetDataTypeValueMin()"
public new static int GetDataTypeValueMin() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIntArray.GetDataTypeValueMin_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static int GetDataTypeValueMax()
// "static int GetDataTypeValueMax()"
public new static int GetDataTypeValueMax() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIntArray.GetDataTypeValueMax_0(returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
