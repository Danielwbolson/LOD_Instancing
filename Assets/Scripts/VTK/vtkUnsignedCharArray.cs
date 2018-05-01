

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnsignedCharArray : vtkDataArray {

// static vtkUnsignedCharArray* New()
// "static vtkUnsignedCharArray* New()"
public new static vtkUnsignedCharArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnsignedCharArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray * source)
// "static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray *source)"
public new static vtkUnsignedCharArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnsignedCharArray.FastDownCast_0(returnPointer, source);
	return Ptr.deref(returnPointer);
}


// static char GetDataTypeValueMin()
// "static unsigned char GetDataTypeValueMin()"
public new static char GetDataTypeValueMin() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkUnsignedCharArray.GetDataTypeValueMin_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static char GetDataTypeValueMax()
// "static unsigned char GetDataTypeValueMax()"
public new static char GetDataTypeValueMax() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkUnsignedCharArray.GetDataTypeValueMax_0(returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
