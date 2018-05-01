

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractCellLinks : vtkObject {

// virtual void BuildLinks(vtkDataSet * data)
// "virtual void BuildLinks(vtkDataSet *data)"
public new void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data) {
	API_vtkAbstractCellLinks.BuildLinks_0(this, data);
}


// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// "static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)"
public new static int GetIdType(long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, vtkCellArray /*(vtkCellArray*)*/ ca) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractCellLinks.GetIdType_0(returnPointer, maxPtId, maxCellId, ca);
	return Ptr.deref(returnPointer);
}


}
};
