

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractCellLinks : vtkObject {
		public vtkAbstractCellLinks(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractCellLinks(IntPtr p) {return new vtkAbstractCellLinks(p);}
		public static implicit operator  IntPtr(vtkAbstractCellLinks o) {return o.GetPtr();}

// virtual void BuildLinks(vtkDataSet * data)
// "virtual void BuildLinks(vtkDataSet *data)"
public void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data) {
	VTK_API.API_vtkAbstractCellLinks.BuildLinks_0(this, data);
}


// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// "static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)"
public static int GetIdType(long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, vtkCellArray /*(vtkCellArray*)*/ ca) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.GetIdType_0(returnPointer.GetPtr(), maxPtId, maxCellId, ca);
	return (int)returnPointer;
}


}
};
