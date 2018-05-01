

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSet : vtkDataObject {

// virtual void CopyStructure(vtkDataSet * ds)
// "virtual void CopyStructure(vtkDataSet *ds)"
public new void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkDataSet.CopyStructure_0(this, ds);
}


// virtual void CopyAttributes(vtkDataSet * ds)
// "virtual void CopyAttributes(vtkDataSet *ds)"
public new void CopyAttributes(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkDataSet.CopyAttributes_0(this, ds);
}


// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual double* GetPoint(vtkIdType ptId)
// "virtual double *GetPoint(vtkIdType ptId)"
public new double GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 3;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataSet.GetPoint_0(this, returnPointer, ptId);
	return Ptr.deref(returnPointer);
}


// virtual void GetPoint(vtkIdType id, double x[3])
// "virtual void GetPoint(vtkIdType id, double x[3])"
public new void GetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	API_vtkDataSet.GetPoint_1(this, id, x);
}


// virtual vtkCellIterator* NewCellIterator()
// "virtual vtkCellIterator* NewCellIterator()"
public new vtkCellIterator NewCellIterator() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.NewCellIterator_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkCell* GetCell(vtkIdType cellId)
// "virtual vtkCell *GetCell(vtkIdType cellId)"
public new vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetCell_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// virtual void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "virtual void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public new void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkDataSet.GetCell_1(this, cellId, cell);
}


// virtual void GetCellBounds(vtkIdType cellId, double bounds[6])
// "virtual void GetCellBounds(vtkIdType cellId, double bounds[6])"
public new void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	API_vtkDataSet.GetCellBounds_0(this, cellId, bounds);
}


// virtual int GetCellType(vtkIdType cellId)
// "virtual int GetCellType(vtkIdType cellId)"
public new int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSet.GetCellType_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// virtual void GetCellTypes(vtkCellTypes * types)
// "virtual void GetCellTypes(vtkCellTypes *types)"
public new void GetCellTypes(vtkCellTypes /*(vtkCellTypes*)*/ types) {
	API_vtkDataSet.GetCellTypes_0(this, types);
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public new void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkDataSet.GetCellPoints_0(this, cellId, ptIds);
}


// virtual void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "virtual void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public new void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkDataSet.GetPointCells_0(this, ptId, cellIds);
}


// virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public new void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkDataSet.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public new long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.FindPoint_0(this, returnPointer, x, y, z);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType FindPoint(double x[3])
// "virtual vtkIdType FindPoint(double x[3])"
public new long FindPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.FindPoint_1(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public new long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.FindCell_0(this, returnPointer, x, cell, cellId, tol2, *subId, pcoords, weights);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public new long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.FindCell_1(this, returnPointer, x, cell, gencell, cellId, tol2, *subId, pcoords, weights);
	return Ptr.deref(returnPointer);
}


// virtual vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public new vtkCell FindAndGetCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.FindAndGetCell_0(this, returnPointer, x, cell, cellId, tol2, *subId, pcoords, weights);
	return Ptr.deref(returnPointer);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataSet.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkCellData* GetCellData()
// "vtkCellData *GetCellData()"
public new vtkCellData GetCellData() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetCellData_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkPointData* GetPointData()
// "vtkPointData *GetPointData()"
public new vtkPointData GetPointData() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetPointData_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public new void Squeeze() {
	API_vtkDataSet.Squeeze_0(this);
}


// virtual void ComputeBounds()
// "virtual void ComputeBounds()"
public new void ComputeBounds() {
	API_vtkDataSet.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public new double GetBounds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataSet.GetBounds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public new void GetBounds(double /*(double[6])*/ []bounds) {
	API_vtkDataSet.GetBounds_1(this, bounds);
}


// double* GetCenter()
// "double *GetCenter()"
public new double GetCenter() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataSet.GetCenter_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetCenter(double center[3])
// "void GetCenter(double center[3])"
public new void GetCenter(double /*(double[3])*/ []center) {
	API_vtkDataSet.GetCenter_1(this, center);
}


// double GetLength()
// "double GetLength()"
public new double GetLength() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataSet.GetLength_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkDataSet.Initialize_0(this);
}


// virtual void GetScalarRange(double range[2])
// "virtual void GetScalarRange(double range[2])"
public new void GetScalarRange(double /*(double[2])*/ []range) {
	API_vtkDataSet.GetScalarRange_0(this, range);
}


// double* GetScalarRange()
// "double *GetScalarRange()"
public new double GetScalarRange() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataSet.GetScalarRange_1(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetMaxCellSize()
// "virtual int GetMaxCellSize()"
public new int GetMaxCellSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSet.GetMaxCellSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataSet.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSet.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkDataSet.DeepCopy_0(this, src);
}


// int CheckAttributes()
// "int CheckAttributes()"
public new int CheckAttributes() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataSet.CheckAttributes_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void GenerateGhostArray(int zeroExt[6])
// "virtual void GenerateGhostArray(int zeroExt[6])"
public new void GenerateGhostArray(int /*(int[6])*/ []zeroExt) {
	API_vtkDataSet.GenerateGhostArray_0(this, zeroExt);
}


// virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)
// "virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)"
public new void GenerateGhostArray(int /*(int[6])*/ []zeroExt, bool /*(bool)*/ cellOnly) {
	API_vtkDataSet.GenerateGhostArray_1(this, zeroExt, cellOnly);
}


// vtkFieldData* GetAttributesAsFieldData(int type)
// "vtkFieldData* GetAttributesAsFieldData(int type)"
public new vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetAttributesAsFieldData_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfElements(int type)
// "vtkIdType GetNumberOfElements(int type)"
public new long GetNumberOfElements(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataSet.GetNumberOfElements_0(this, returnPointer, type);
	return Ptr.deref(returnPointer);
}


// bool HasAnyGhostCells()
// "bool HasAnyGhostCells()"
public new bool HasAnyGhostCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkDataSet.HasAnyGhostCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// bool HasAnyGhostPoints()
// "bool HasAnyGhostPoints()"
public new bool HasAnyGhostPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkDataSet.HasAnyGhostPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual bool HasAnyBlankCells()
// "virtual bool HasAnyBlankCells()"
public new bool HasAnyBlankCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkDataSet.HasAnyBlankCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual bool HasAnyBlankPoints()
// "virtual bool HasAnyBlankPoints()"
public new bool HasAnyBlankPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkDataSet.HasAnyBlankPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkUnsignedCharArray* GetPointGhostArray()
// "vtkUnsignedCharArray* GetPointGhostArray()"
public new vtkUnsignedCharArray GetPointGhostArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetPointGhostArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void UpdatePointGhostArrayCache()
// "void UpdatePointGhostArrayCache()"
public new void UpdatePointGhostArrayCache() {
	API_vtkDataSet.UpdatePointGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocatePointGhostArray()
// "vtkUnsignedCharArray* AllocatePointGhostArray()"
public new vtkUnsignedCharArray AllocatePointGhostArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.AllocatePointGhostArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkUnsignedCharArray* GetCellGhostArray()
// "vtkUnsignedCharArray* GetCellGhostArray()"
public new vtkUnsignedCharArray GetCellGhostArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.GetCellGhostArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void UpdateCellGhostArrayCache()
// "void UpdateCellGhostArrayCache()"
public new void UpdateCellGhostArrayCache() {
	API_vtkDataSet.UpdateCellGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocateCellGhostArray()
// "vtkUnsignedCharArray* AllocateCellGhostArray()"
public new vtkUnsignedCharArray AllocateCellGhostArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataSet.AllocateCellGhostArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
