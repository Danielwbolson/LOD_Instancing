

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellIterator : vtkObject {
		public vtkCellIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellIterator(IntPtr p) {return new vtkCellIterator(p);}
		public static implicit operator  IntPtr(vtkCellIterator o) {return o.GetPtr();}

// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	API_vtkCellIterator.InitTraversal_0(this);
}


// void GoToNextCell()
// "void GoToNextCell()"
public void GoToNextCell() {
	API_vtkCellIterator.GoToNextCell_0(this);
}


// virtual bool IsDoneWithTraversal()
// "virtual bool IsDoneWithTraversal()"
public bool IsDoneWithTraversal() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	API_vtkCellIterator.IsDoneWithTraversal_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// int GetCellType()
// "int GetCellType()"
public int GetCellType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkCellIterator.GetCellType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetCellDimension()
// "int GetCellDimension()"
public int GetCellDimension() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkCellIterator.GetCellDimension_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkIdType GetCellId()
// "virtual vtkIdType GetCellId()"
public long GetCellId() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellIterator.GetCellId_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public vtkIdList GetPointIds() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellIterator.GetPointIds_0(returnPointer.GetPtr(), this);
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public vtkPoints GetPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellIterator.GetPoints_0(returnPointer.GetPtr(), this);
	return (vtkPoints)(IntPtr)returnPointer;
}


// vtkIdList* GetFaces()
// "vtkIdList *GetFaces()"
public vtkIdList GetFaces() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellIterator.GetFaces_0(returnPointer.GetPtr(), this);
	return (vtkIdList)(IntPtr)returnPointer;
}


// void GetCell(vtkGenericCell * cell)
// "void GetCell(vtkGenericCell *cell)"
public void GetCell(vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkCellIterator.GetCell_0(this, cell);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellIterator.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfFaces()
// "vtkIdType GetNumberOfFaces()"
public long GetNumberOfFaces() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellIterator.GetNumberOfFaces_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
