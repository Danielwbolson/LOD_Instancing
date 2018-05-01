

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataReader : vtkXMLReader {

// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLDataReader.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLDataReader.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
