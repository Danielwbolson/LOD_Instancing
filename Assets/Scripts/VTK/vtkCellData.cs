

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellData : vtkDataSetAttributes {

// static vtkCellData* New()
// "static vtkCellData *New()"
public new static vtkCellData New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellData.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
