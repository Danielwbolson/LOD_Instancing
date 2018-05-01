

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredDataReader : vtkXMLDataReader {

// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfPieces()
// "virtual vtkIdType GetNumberOfPieces()"
public new long GetNumberOfPieces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfPieces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// "void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)"
public new void SetupUpdateExtent(int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel) {
	API_vtkXMLUnstructuredDataReader.SetupUpdateExtent_0(this, piece, numberOfPieces, ghostLevel);
}


}
};
