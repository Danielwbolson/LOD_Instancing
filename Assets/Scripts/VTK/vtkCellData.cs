

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellData : vtkDataSetAttributes {
		public vtkCellData(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellData(IntPtr p) {return new vtkCellData(p);}
		public static implicit operator  IntPtr(vtkCellData o) {return o.GetPtr();}

// static vtkCellData* New()
// "static vtkCellData *New()"
public static vtkCellData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellData.New_0(returnPointer.GetPtr());
	return (vtkCellData)(IntPtr)returnPointer;
}


}
};
