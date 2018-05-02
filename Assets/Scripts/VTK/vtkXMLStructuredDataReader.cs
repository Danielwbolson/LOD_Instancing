

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredDataReader : vtkXMLDataReader {
		public vtkXMLStructuredDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredDataReader(IntPtr p) {return new vtkXMLStructuredDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredDataReader o) {return o.GetPtr();}

// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
