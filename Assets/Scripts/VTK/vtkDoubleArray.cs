

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDoubleArray : vtkDataArray {
		public vtkDoubleArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkDoubleArray(IntPtr p) {return new vtkDoubleArray(p);}
		public static implicit operator  IntPtr(vtkDoubleArray o) {return o.GetPtr();}

// static vtkDoubleArray* New()
// "static vtkDoubleArray* New()"
public static vtkDoubleArray New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDoubleArray.New_0(returnPointer.GetPtr());
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static vtkDoubleArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDoubleArray* FastDownCast(vtkAbstractArray *source)"
public static vtkDoubleArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDoubleArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static double GetDataTypeValueMin()
// "static double GetDataTypeValueMin()"
public static double GetDataTypeValueMin() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (double)returnPointer;
}


// static double GetDataTypeValueMax()
// "static double GetDataTypeValueMax()"
public static double GetDataTypeValueMax() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (double)returnPointer;
}


}
};
