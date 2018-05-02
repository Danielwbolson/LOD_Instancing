

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnsignedCharArray : vtkDataArray {
		public vtkUnsignedCharArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnsignedCharArray(IntPtr p) {return new vtkUnsignedCharArray(p);}
		public static implicit operator  IntPtr(vtkUnsignedCharArray o) {return o.GetPtr();}

// static vtkUnsignedCharArray* New()
// "static vtkUnsignedCharArray* New()"
public static vtkUnsignedCharArray New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkUnsignedCharArray.New_0(returnPointer.GetPtr());
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray * source)
// "static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray *source)"
public static vtkUnsignedCharArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkUnsignedCharArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// static char GetDataTypeValueMin()
// "static unsigned char GetDataTypeValueMin()"
public static char GetDataTypeValueMin() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new char(), return_elements);
	VTK_API.API_vtkUnsignedCharArray.GetDataTypeValueMin_0(returnPointer.GetPtr());
	return (char)returnPointer;
}


// static char GetDataTypeValueMax()
// "static unsigned char GetDataTypeValueMax()"
public static char GetDataTypeValueMax() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new char(), return_elements);
	VTK_API.API_vtkUnsignedCharArray.GetDataTypeValueMax_0(returnPointer.GetPtr());
	return (char)returnPointer;
}


}
};
