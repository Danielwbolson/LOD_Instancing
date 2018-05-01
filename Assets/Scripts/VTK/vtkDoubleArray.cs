

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDoubleArray : vtkDataArray {

// static vtkDoubleArray* New()
// "static vtkDoubleArray* New()"
public new static vtkDoubleArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDoubleArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static vtkDoubleArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDoubleArray* FastDownCast(vtkAbstractArray *source)"
public new static vtkDoubleArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDoubleArray.FastDownCast_0(returnPointer, source);
	return Ptr.deref(returnPointer);
}


// static double GetDataTypeValueMin()
// "static double GetDataTypeValueMin()"
public new static double GetDataTypeValueMin() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDoubleArray.GetDataTypeValueMin_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// static double GetDataTypeValueMax()
// "static double GetDataTypeValueMax()"
public new static double GetDataTypeValueMax() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDoubleArray.GetDataTypeValueMax_0(returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
