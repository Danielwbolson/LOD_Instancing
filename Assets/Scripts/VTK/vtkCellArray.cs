

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellArray : vtkObject {
		public vtkCellArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellArray(IntPtr p) {return new vtkCellArray(p);}
		public static implicit operator  IntPtr(vtkCellArray o) {return o.GetPtr();}

// static vtkCellArray* New()
// "static vtkCellArray *New()"
public static vtkCellArray New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellArray.New_0(returnPointer.GetPtr());
	return (vtkCellArray)(IntPtr)returnPointer;
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate(vtkIdType sz, vtkIdType ext=1000)"
public int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkCellArray.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	API_vtkCellArray.Initialize_0(this);
}


// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// "vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)"
public long EstimateSize(long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.EstimateSize_0(returnPointer.GetPtr(), this, numCells, maxPtsPerCell);
	return (long)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	API_vtkCellArray.InitTraversal_0(this);
}


// int GetNextCell(vtkIdList * pts)
// "int GetNextCell(vtkIdList *pts)"
public int GetNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkCellArray.GetNextCell_0(returnPointer.GetPtr(), this, pts);
	return (int)returnPointer;
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public long GetSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.GetSize_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfConnectivityEntries()
// "vtkIdType GetNumberOfConnectivityEntries()"
public long GetNumberOfConnectivityEntries() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.GetNumberOfConnectivityEntries_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// "void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)"
public void GetCell(long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	API_vtkCellArray.GetCell_0(this, loc, npts, pts);
}


// void GetCell(vtkIdType loc, vtkIdList * pts)
// "void GetCell(vtkIdType loc, vtkIdList* pts)"
public void GetCell(long /*(vtkIdType)*/ loc, vtkIdList /*(vtkIdList*)*/ pts) {
	API_vtkCellArray.GetCell_1(this, loc, pts);
}


// vtkIdType InsertNextCell(vtkCell * cell)
// "vtkIdType InsertNextCell(vtkCell *cell)"
public long InsertNextCell(vtkCell /*(vtkCell*)*/ cell) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.InsertNextCell_0(returnPointer.GetPtr(), this, cell);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(vtkIdList * pts)
// "vtkIdType InsertNextCell(vtkIdList *pts)"
public long InsertNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.InsertNextCell_1(returnPointer.GetPtr(), this, pts);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(int npts)
// "vtkIdType InsertNextCell(int npts)"
public long InsertNextCell(int /*(int)*/ npts) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.InsertNextCell_2(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// void InsertCellPoint(vtkIdType id)
// "void InsertCellPoint(vtkIdType id)"
public void InsertCellPoint(long /*(vtkIdType)*/ id) {
	API_vtkCellArray.InsertCellPoint_0(this, id);
}


// void UpdateCellCount(int npts)
// "void UpdateCellCount(int npts)"
public void UpdateCellCount(int /*(int)*/ npts) {
	API_vtkCellArray.UpdateCellCount_0(this, npts);
}


// vtkIdType GetInsertLocation(int npts)
// "vtkIdType GetInsertLocation(int npts)"
public long GetInsertLocation(int /*(int)*/ npts) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.GetInsertLocation_0(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// vtkIdType GetTraversalLocation()
// "vtkIdType GetTraversalLocation()"
public long GetTraversalLocation() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.GetTraversalLocation_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SetTraversalLocation(vtkIdType loc)
// "void SetTraversalLocation(vtkIdType loc)"
public void SetTraversalLocation(long /*(vtkIdType)*/ loc) {
	API_vtkCellArray.SetTraversalLocation_0(this, loc);
}


// vtkIdType GetTraversalLocation(vtkIdType npts)
// "vtkIdType GetTraversalLocation(vtkIdType npts)"
public long GetTraversalLocation(long /*(vtkIdType)*/ npts) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellArray.GetTraversalLocation_1(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// void ReverseCell(vtkIdType loc)
// "void ReverseCell(vtkIdType loc)"
public void ReverseCell(long /*(vtkIdType)*/ loc) {
	API_vtkCellArray.ReverseCell_0(this, loc);
}


// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType * pts)
// "void ReplaceCell(vtkIdType loc, int npts, const vtkIdType *pts)"
public void ReplaceCell(long /*(vtkIdType)*/ loc, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	API_vtkCellArray.ReplaceCell_0(this, loc, npts, pts);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkCellArray.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType* GetPointer()
// "vtkIdType *GetPointer()"
public IntPtr GetPointer() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellArray.GetPointer_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// "vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)"
public IntPtr WritePointer(long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellArray.WritePointer_0(returnPointer.GetPtr(), this, ncells, size);
	return (IntPtr)returnPointer;
}


// void SetCells(vtkIdType ncells, vtkIdTypeArray * cells)
// "void SetCells(vtkIdType ncells, vtkIdTypeArray *cells)"
public void SetCells(long /*(vtkIdType)*/ ncells, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cells) {
	API_vtkCellArray.SetCells_0(this, ncells, cells);
}


// void DeepCopy(vtkCellArray * ca)
// "void DeepCopy(vtkCellArray *ca)"
public void DeepCopy(vtkCellArray /*(vtkCellArray*)*/ ca) {
	API_vtkCellArray.DeepCopy_0(this, ca);
}


// vtkIdTypeArray* GetData()
// "vtkIdTypeArray* GetData()"
public vtkIdTypeArray GetData() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellArray.GetData_0(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	API_vtkCellArray.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	API_vtkCellArray.Squeeze_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkCellArray.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


}
};