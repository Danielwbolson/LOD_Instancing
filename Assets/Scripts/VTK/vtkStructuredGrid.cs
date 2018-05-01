

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStructuredGrid : vtkPointSet {

// static vtkStructuredGrid* New()
// "static vtkStructuredGrid *New()"
public new static vtkStructuredGrid New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkStructuredGrid.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public new void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkStructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStructuredGrid.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public new double GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkStructuredGrid.GetPoint_0(this, returnPointer, ptId);
	return Ptr.deref(returnPointer);
}


// void GetPoint(vtkIdType ptId, double p[3])
// "void GetPoint(vtkIdType ptId, double p[3])"
public new void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []p) {
	API_vtkStructuredGrid.GetPoint_1(this, ptId, p);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public new vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkStructuredGrid.GetCell_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetCell(int i, int j, int k)
// "vtkCell *GetCell(int i, int j, int k)"
public new vtkCell GetCell(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkStructuredGrid.GetCell_1(this, returnPointer, i, j, k);
	return Ptr.deref(returnPointer);
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public new void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkStructuredGrid.GetCell_2(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public new void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	API_vtkStructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public new int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetCellType_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStructuredGrid.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public new void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkStructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public new void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkStructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkStructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public new int GetMaxCellSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetMaxCellSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public new void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkStructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds, int * seedLoc)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds, int *seedLoc)"
public new void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds, int /*(int*)*/ []seedLoc) {
	API_vtkStructuredGrid.GetCellNeighbors_1(this, cellId, ptIds, cellIds, seedLoc);
}


// void SetDimensions(int i, int j, int k)
// "void SetDimensions(int i, int j, int k)"
public new void SetDimensions(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	API_vtkStructuredGrid.SetDimensions_0(this, i, j, k);
}


// void SetDimensions(int dim[3])
// "void SetDimensions(int dim[3])"
public new void SetDimensions(int /*(int[3])*/ []dim) {
	API_vtkStructuredGrid.SetDimensions_1(this, dim);
}


// virtual int* GetDimensions()
// "virtual int *GetDimensions ()"
public new int GetDimensions() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetDimensions_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void GetDimensions(int dim[3])
// "virtual void GetDimensions (int dim[3])"
public new void GetDimensions(int /*(int[3])*/ []dim) {
	API_vtkStructuredGrid.GetDimensions_1(this, dim);
}


// int GetDataDimension()
// "int GetDataDimension()"
public new int GetDataDimension() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetDataDimension_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetExtent(int extent[6])
// "void SetExtent(int extent[6])"
public new void SetExtent(int /*(int[6])*/ []extent) {
	API_vtkStructuredGrid.SetExtent_0(this, extent);
}


// void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// "void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)"
public new void SetExtent(int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2) {
	API_vtkStructuredGrid.SetExtent_1(this, x1, x2, y1, y2, z1, z2);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkStructuredGrid.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkStructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkStructuredGrid.DeepCopy_0(this, src);
}


// int GetExtentType()
// "int GetExtentType()"
public new int GetExtentType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStructuredGrid.GetExtentType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void BlankPoint(vtkIdType ptId)
// "void BlankPoint(vtkIdType ptId)"
public new void BlankPoint(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.BlankPoint_0(this, ptId);
}


// void UnBlankPoint(vtkIdType ptId)
// "void UnBlankPoint(vtkIdType ptId)"
public new void UnBlankPoint(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.UnBlankPoint_0(this, ptId);
}


// void BlankCell(vtkIdType ptId)
// "void BlankCell(vtkIdType ptId)"
public new void BlankCell(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.BlankCell_0(this, ptId);
}


// void UnBlankCell(vtkIdType ptId)
// "void UnBlankCell(vtkIdType ptId)"
public new void UnBlankCell(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.UnBlankCell_0(this, ptId);
}


// char IsPointVisible(vtkIdType ptId)
// "unsigned char IsPointVisible(vtkIdType ptId)"
public new char IsPointVisible(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkStructuredGrid.IsPointVisible_0(this, returnPointer, ptId);
	return Ptr.deref(returnPointer);
}


// char IsCellVisible(vtkIdType cellId)
// "unsigned char IsCellVisible(vtkIdType cellId)"
public new char IsCellVisible(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkStructuredGrid.IsCellVisible_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// bool HasAnyBlankPoints()
// "bool HasAnyBlankPoints()"
public new bool HasAnyBlankPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkStructuredGrid.HasAnyBlankPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// bool HasAnyBlankCells()
// "bool HasAnyBlankCells()"
public new bool HasAnyBlankCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkStructuredGrid.HasAnyBlankCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCellDims(int cellDims[3])
// "void GetCellDims( int cellDims[3] )"
public new void GetCellDims(int /*(int[3])*/ []cellDims) {
	API_vtkStructuredGrid.GetCellDims_0(this, cellDims);
}


// void Crop(const int * updateExtent)
// "void Crop(const int* updateExtent)"
public new void Crop(int /*(int*)*/ []updateExtent) {
	API_vtkStructuredGrid.Crop_0(this, updateExtent);
}


// void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)
// "void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)"
public new void GetPoint(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, double /*(double[3])*/ []p, bool /*(bool)*/ adjustForExtent) {
	API_vtkStructuredGrid.GetPoint_2(this, i, j, k, p, adjustForExtent);
}


}
};
