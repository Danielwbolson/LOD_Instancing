

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellArray : vtkObject {

// static vtkCellArray* New()
// "static vtkCellArray *New()"
public new static vtkCellArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate(vtkIdType sz, vtkIdType ext=1000)"
public new int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellArray.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkCellArray.Initialize_0(this);
}


// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// "vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)"
public new long EstimateSize(long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.EstimateSize_0(this, returnPointer, numCells, maxPtsPerCell);
	return Ptr.deref(returnPointer);
}


// void InitTraversal()
// "void InitTraversal()"
public new void InitTraversal() {
	API_vtkCellArray.InitTraversal_0(this);
}


// int GetNextCell(vtkIdList * pts)
// "int GetNextCell(vtkIdList *pts)"
public new int GetNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellArray.GetNextCell_0(this, returnPointer, pts);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public new long GetSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfConnectivityEntries()
// "vtkIdType GetNumberOfConnectivityEntries()"
public new long GetNumberOfConnectivityEntries() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetNumberOfConnectivityEntries_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// "void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)"
public new void GetCell(long /*(vtkIdType)*/ loc, long /*(vtkIdType&)*/ []npts, long /*(vtkIdType*&)*/ []pts) {
	API_vtkCellArray.GetCell_0(this, loc, *npts, *pts);
}


// void GetCell(vtkIdType loc, vtkIdList * pts)
// "void GetCell(vtkIdType loc, vtkIdList* pts)"
public new void GetCell(long /*(vtkIdType)*/ loc, vtkIdList /*(vtkIdList*)*/ pts) {
	API_vtkCellArray.GetCell_1(this, loc, pts);
}


// vtkIdType InsertNextCell(vtkCell * cell)
// "vtkIdType InsertNextCell(vtkCell *cell)"
public new long InsertNextCell(vtkCell /*(vtkCell*)*/ cell) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.InsertNextCell_0(this, returnPointer, cell);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextCell(vtkIdList * pts)
// "vtkIdType InsertNextCell(vtkIdList *pts)"
public new long InsertNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.InsertNextCell_1(this, returnPointer, pts);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextCell(int npts)
// "vtkIdType InsertNextCell(int npts)"
public new long InsertNextCell(int /*(int)*/ npts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.InsertNextCell_2(this, returnPointer, npts);
	return Ptr.deref(returnPointer);
}


// void InsertCellPoint(vtkIdType id)
// "void InsertCellPoint(vtkIdType id)"
public new void InsertCellPoint(long /*(vtkIdType)*/ id) {
	API_vtkCellArray.InsertCellPoint_0(this, id);
}


// void UpdateCellCount(int npts)
// "void UpdateCellCount(int npts)"
public new void UpdateCellCount(int /*(int)*/ npts) {
	API_vtkCellArray.UpdateCellCount_0(this, npts);
}


// vtkIdType GetInsertLocation(int npts)
// "vtkIdType GetInsertLocation(int npts)"
public new long GetInsertLocation(int /*(int)*/ npts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetInsertLocation_0(this, returnPointer, npts);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetTraversalLocation()
// "vtkIdType GetTraversalLocation()"
public new long GetTraversalLocation() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetTraversalLocation_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetTraversalLocation(vtkIdType loc)
// "void SetTraversalLocation(vtkIdType loc)"
public new void SetTraversalLocation(long /*(vtkIdType)*/ loc) {
	API_vtkCellArray.SetTraversalLocation_0(this, loc);
}


// vtkIdType GetTraversalLocation(vtkIdType npts)
// "vtkIdType GetTraversalLocation(vtkIdType npts)"
public new long GetTraversalLocation(long /*(vtkIdType)*/ npts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetTraversalLocation_1(this, returnPointer, npts);
	return Ptr.deref(returnPointer);
}


// void ReverseCell(vtkIdType loc)
// "void ReverseCell(vtkIdType loc)"
public new void ReverseCell(long /*(vtkIdType)*/ loc) {
	API_vtkCellArray.ReverseCell_0(this, loc);
}


// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType * pts)
// "void ReplaceCell(vtkIdType loc, int npts, const vtkIdType *pts)"
public new void ReplaceCell(long /*(vtkIdType)*/ loc, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	API_vtkCellArray.ReplaceCell_0(this, loc, npts, pts);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public new int GetMaxCellSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCellArray.GetMaxCellSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType* GetPointer()
// "vtkIdType *GetPointer()"
public new long GetPointer() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.GetPointer_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// "vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)"
public new long WritePointer(long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkCellArray.WritePointer_0(this, returnPointer, ncells, size);
	return Ptr.deref(returnPointer);
}


// void SetCells(vtkIdType ncells, vtkIdTypeArray * cells)
// "void SetCells(vtkIdType ncells, vtkIdTypeArray *cells)"
public new void SetCells(long /*(vtkIdType)*/ ncells, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cells) {
	API_vtkCellArray.SetCells_0(this, ncells, cells);
}


// void DeepCopy(vtkCellArray * ca)
// "void DeepCopy(vtkCellArray *ca)"
public new void DeepCopy(vtkCellArray /*(vtkCellArray*)*/ ca) {
	API_vtkCellArray.DeepCopy_0(this, ca);
}


// vtkIdTypeArray* GetData()
// "vtkIdTypeArray* GetData()"
public new vtkIdTypeArray GetData() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkCellArray.GetData_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkCellArray.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkCellArray.Squeeze_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkCellArray.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
