

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellIterator : vtkObject {

// void InitTraversal()
// "void InitTraversal()"
public new void InitTraversal() {
	API_vtkCellIterator.InitTraversal_0(this);
}


// void GoToNextCell()
// "void GoToNextCell()"
public new void GoToNextCell() {
	API_vtkCellIterator.GoToNextCell_0(this);
}


// virtual bool IsDoneWithTraversal()
// "virtual bool IsDoneWithTraversal()"
public new bool IsDoneWithTraversal() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkCellIterator.IsDoneWithTraversal_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetCellType()
// "int GetCellType()"
public new int GetCellType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellIterator.GetCellType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetCellDimension()
// "int GetCellDimension()"
public new int GetCellDimension() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellIterator.GetCellDimension_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetCellId()
// "virtual vtkIdType GetCellId()"
public new long GetCellId() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellIterator.GetCellId_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public new vtkIdList GetPointIds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellIterator.GetPointIds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public new vtkPoints GetPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellIterator.GetPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdList* GetFaces()
// "vtkIdList *GetFaces()"
public new vtkIdList GetFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellIterator.GetFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCell(vtkGenericCell * cell)
// "void GetCell(vtkGenericCell *cell)"
public new void GetCell(vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkCellIterator.GetCell_0(this, cell);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellIterator.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfFaces()
// "vtkIdType GetNumberOfFaces()"
public new long GetNumberOfFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellIterator.GetNumberOfFaces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
