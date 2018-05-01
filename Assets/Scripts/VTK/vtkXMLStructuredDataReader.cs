

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredDataReader : vtkXMLDataReader {

// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLStructuredDataReader.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLStructuredDataReader.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
