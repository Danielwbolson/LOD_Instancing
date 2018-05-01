

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredDataReader : vtkXMLDataReader {
		public vtkXMLUnstructuredDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLUnstructuredDataReader(IntPtr p) {return new vtkXMLUnstructuredDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLUnstructuredDataReader o) {return o.GetPtr();}

// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfPieces()
// "virtual vtkIdType GetNumberOfPieces()"
public long GetNumberOfPieces() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkXMLUnstructuredDataReader.GetNumberOfPieces_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// "void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)"
public void SetupUpdateExtent(int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel) {
	API_vtkXMLUnstructuredDataReader.SetupUpdateExtent_0(this, piece, numberOfPieces, ghostLevel);
}


}
};
