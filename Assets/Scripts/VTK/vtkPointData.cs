

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointData : vtkDataSetAttributes {
		public vtkPointData(IntPtr p) : base(p) {}
		public static implicit operator  vtkPointData(IntPtr p) {return new vtkPointData(p);}
		public static implicit operator  IntPtr(vtkPointData o) {return o.GetPtr();}

// static vtkPointData* New()
// "static vtkPointData *New()"
public static vtkPointData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkPointData.New_0(returnPointer.GetPtr());
	return (vtkPointData)(IntPtr)returnPointer;
}


// void NullPoint(vtkIdType ptId)
// "void NullPoint(vtkIdType ptId)"
public void NullPoint(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkPointData.NullPoint_0(this, ptId);
}


}
};
