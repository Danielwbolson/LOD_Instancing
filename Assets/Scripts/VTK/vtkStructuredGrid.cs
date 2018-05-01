

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStructuredGrid : vtkPointSet {
		public vtkStructuredGrid(IntPtr p) : base(p) {}
		public static implicit operator  vtkStructuredGrid(IntPtr p) {return new vtkStructuredGrid(p);}
		public static implicit operator  IntPtr(vtkStructuredGrid o) {return o.GetPtr();}

// static vtkStructuredGrid* New()
// "static vtkStructuredGrid *New()"
public static vtkStructuredGrid New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkStructuredGrid.New_0(returnPointer.GetPtr());
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkStructuredGrid.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkStructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkStructuredGrid.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public IntPtr GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkStructuredGrid.GetPoint_0(returnPointer.GetPtr(), this, ptId);
	return (IntPtr)returnPointer;
}


// void GetPoint(vtkIdType ptId, double p[3])
// "void GetPoint(vtkIdType ptId, double p[3])"
public void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []p) {
	API_vtkStructuredGrid.GetPoint_1(this, ptId, p);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkStructuredGrid.GetCell_0(returnPointer.GetPtr(), this, cellId);
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* GetCell(int i, int j, int k)
// "vtkCell *GetCell(int i, int j, int k)"
public vtkCell GetCell(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkStructuredGrid.GetCell_1(returnPointer.GetPtr(), this, i, j, k);
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkStructuredGrid.GetCell_2(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	API_vtkStructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkStructuredGrid.GetCellType_0(returnPointer.GetPtr(), this, cellId);
	return (int)returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkStructuredGrid.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkStructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkStructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	API_vtkStructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkStructuredGrid.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkStructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds, int * seedLoc)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds, int *seedLoc)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds, IntPtr /*(int*)*/ seedLoc) {
	API_vtkStructuredGrid.GetCellNeighbors_1(this, cellId, ptIds, cellIds, seedLoc);
}


// void SetDimensions(int i, int j, int k)
// "void SetDimensions(int i, int j, int k)"
public void SetDimensions(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	API_vtkStructuredGrid.SetDimensions_0(this, i, j, k);
}


// void SetDimensions(int dim[3])
// "void SetDimensions(int dim[3])"
public void SetDimensions(int /*(int[3])*/ []dim) {
	API_vtkStructuredGrid.SetDimensions_1(this, dim);
}


// virtual int* GetDimensions()
// "virtual int *GetDimensions ()"
public IntPtr GetDimensions() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkStructuredGrid.GetDimensions_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetDimensions(int dim[3])
// "virtual void GetDimensions (int dim[3])"
public void GetDimensions(int /*(int[3])*/ []dim) {
	API_vtkStructuredGrid.GetDimensions_1(this, dim);
}


// int GetDataDimension()
// "int GetDataDimension()"
public int GetDataDimension() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkStructuredGrid.GetDataDimension_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetExtent(int extent[6])
// "void SetExtent(int extent[6])"
public void SetExtent(int /*(int[6])*/ []extent) {
	API_vtkStructuredGrid.SetExtent_0(this, extent);
}


// void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// "void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)"
public void SetExtent(int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2) {
	API_vtkStructuredGrid.SetExtent_1(this, x1, x2, y1, y2, z1, z2);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkStructuredGrid.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkStructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkStructuredGrid.DeepCopy_0(this, src);
}


// int GetExtentType()
// "int GetExtentType()"
public int GetExtentType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkStructuredGrid.GetExtentType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void BlankPoint(vtkIdType ptId)
// "void BlankPoint(vtkIdType ptId)"
public void BlankPoint(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.BlankPoint_0(this, ptId);
}


// void UnBlankPoint(vtkIdType ptId)
// "void UnBlankPoint(vtkIdType ptId)"
public void UnBlankPoint(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.UnBlankPoint_0(this, ptId);
}


// void BlankCell(vtkIdType ptId)
// "void BlankCell(vtkIdType ptId)"
public void BlankCell(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.BlankCell_0(this, ptId);
}


// void UnBlankCell(vtkIdType ptId)
// "void UnBlankCell(vtkIdType ptId)"
public void UnBlankCell(long /*(vtkIdType)*/ ptId) {
	API_vtkStructuredGrid.UnBlankCell_0(this, ptId);
}


// char IsPointVisible(vtkIdType ptId)
// "unsigned char IsPointVisible(vtkIdType ptId)"
public char IsPointVisible(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new char(), return_elements);
	API_vtkStructuredGrid.IsPointVisible_0(returnPointer.GetPtr(), this, ptId);
	return (char)returnPointer;
}


// char IsCellVisible(vtkIdType cellId)
// "unsigned char IsCellVisible(vtkIdType cellId)"
public char IsCellVisible(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new char(), return_elements);
	API_vtkStructuredGrid.IsCellVisible_0(returnPointer.GetPtr(), this, cellId);
	return (char)returnPointer;
}


// bool HasAnyBlankPoints()
// "bool HasAnyBlankPoints()"
public bool HasAnyBlankPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	API_vtkStructuredGrid.HasAnyBlankPoints_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// bool HasAnyBlankCells()
// "bool HasAnyBlankCells()"
public bool HasAnyBlankCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	API_vtkStructuredGrid.HasAnyBlankCells_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void GetCellDims(int cellDims[3])
// "void GetCellDims( int cellDims[3] )"
public void GetCellDims(int /*(int[3])*/ []cellDims) {
	API_vtkStructuredGrid.GetCellDims_0(this, cellDims);
}


// void Crop(const int * updateExtent)
// "void Crop(const int* updateExtent)"
public void Crop(IntPtr /*(int*)*/ updateExtent) {
	API_vtkStructuredGrid.Crop_0(this, updateExtent);
}


// void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)
// "void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)"
public void GetPoint(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, double /*(double[3])*/ []p, bool /*(bool)*/ adjustForExtent) {
	API_vtkStructuredGrid.GetPoint_2(this, i, j, k, p, adjustForExtent);
}


}
};
