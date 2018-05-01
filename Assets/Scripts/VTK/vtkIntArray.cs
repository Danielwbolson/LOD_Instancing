

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIntArray : vtkDataArray {
		public vtkIntArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkIntArray(IntPtr p) {return new vtkIntArray(p);}
		public static implicit operator  IntPtr(vtkIntArray o) {return o.GetPtr();}

// static vtkIntArray* New()
// "static vtkIntArray* New()"
public static vtkIntArray New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkIntArray.New_0(returnPointer.GetPtr());
	return (vtkIntArray)(IntPtr)returnPointer;
}


// static vtkIntArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIntArray* FastDownCast(vtkAbstractArray *source)"
public static vtkIntArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkIntArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkIntArray)(IntPtr)returnPointer;
}


// static int GetDataTypeValueMin()
// "static int GetDataTypeValueMin()"
public static int GetDataTypeValueMin() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkIntArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// static int GetDataTypeValueMax()
// "static int GetDataTypeValueMax()"
public static int GetDataTypeValueMax() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkIntArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


}
};
