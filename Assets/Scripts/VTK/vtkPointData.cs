

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointData : vtkDataSetAttributes {

// static vtkPointData* New()
// "static vtkPointData *New()"
public new static vtkPointData New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPointData.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void NullPoint(vtkIdType ptId)
// "void NullPoint(vtkIdType ptId)"
public new void NullPoint(long /*(vtkIdType)*/ ptId) {
	API_vtkPointData.NullPoint_0(this, ptId);
}


}
};
