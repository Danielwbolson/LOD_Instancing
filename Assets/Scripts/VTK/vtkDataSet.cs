

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSet : vtkDataObject {
		public vtkDataSet(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataSet(IntPtr p) {return new vtkDataSet(p);}
		public static implicit operator  IntPtr(vtkDataSet o) {return o.GetPtr();}

// virtual void CopyStructure(vtkDataSet * ds)
// "virtual void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkDataSet.CopyStructure_0(this, ds);
}


// virtual void CopyAttributes(vtkDataSet * ds)
// "virtual void CopyAttributes(vtkDataSet *ds)"
public void CopyAttributes(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkDataSet.CopyAttributes_0(this, ds);
}


// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual double* GetPoint(vtkIdType ptId)
// "virtual double *GetPoint(vtkIdType ptId)"
public IntPtr GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 3;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetPoint_0(returnPointer.GetPtr(), this, ptId);
	return (IntPtr)returnPointer;
}


// virtual void GetPoint(vtkIdType id, double x[3])
// "virtual void GetPoint(vtkIdType id, double x[3])"
public void GetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkDataSet.GetPoint_1(this, id, x);
}


// virtual vtkCellIterator* NewCellIterator()
// "virtual vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.NewCellIterator_0(returnPointer.GetPtr(), this);
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// virtual vtkCell* GetCell(vtkIdType cellId)
// "virtual vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetCell_0(returnPointer.GetPtr(), this, cellId);
	return (vtkCell)(IntPtr)returnPointer;
}


// virtual void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "virtual void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkDataSet.GetCell_1(this, cellId, cell);
}


// virtual void GetCellBounds(vtkIdType cellId, double bounds[6])
// "virtual void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkDataSet.GetCellBounds_0(this, cellId, bounds);
}


// virtual int GetCellType(vtkIdType cellId)
// "virtual int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkDataSet.GetCellType_0(returnPointer.GetPtr(), this, cellId);
	return (int)returnPointer;
}


// virtual void GetCellTypes(vtkCellTypes * types)
// "virtual void GetCellTypes(vtkCellTypes *types)"
public void GetCellTypes(vtkCellTypes /*(vtkCellTypes*)*/ types) {
	VTK_API.API_vtkDataSet.GetCellTypes_0(this, types);
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkDataSet.GetCellPoints_0(this, cellId, ptIds);
}


// virtual void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "virtual void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkDataSet.GetPointCells_0(this, ptId, cellIds);
}


// virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkDataSet.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.FindPoint_0(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// virtual vtkIdType FindPoint(double x[3])
// "virtual vtkIdType FindPoint(double x[3])"
public long FindPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.FindPoint_1(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.FindCell_0(returnPointer.GetPtr(), this, x, cell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.FindCell_1(returnPointer.GetPtr(), this, x, cell, gencell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// virtual vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public vtkCell FindAndGetCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.FindAndGetCell_0(returnPointer.GetPtr(), this, x, cell, cellId, tol2, subId, pcoords, weights);
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkDataSet.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkCellData* GetCellData()
// "vtkCellData *GetCellData()"
public vtkCellData GetCellData() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetCellData_0(returnPointer.GetPtr(), this);
	return (vtkCellData)(IntPtr)returnPointer;
}


// vtkPointData* GetPointData()
// "vtkPointData *GetPointData()"
public vtkPointData GetPointData() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetPointData_0(returnPointer.GetPtr(), this);
	return (vtkPointData)(IntPtr)returnPointer;
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkDataSet.Squeeze_0(this);
}


// virtual void ComputeBounds()
// "virtual void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkDataSet.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
protected IntPtr GetBounds_0() {
	int return_elements = 6;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkDataSet.GetBounds_1(this, bounds);
}


// double* GetCenter()
// "double *GetCenter()"
public IntPtr GetCenter() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetCenter_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetCenter(double center[3])
// "void GetCenter(double center[3])"
public void GetCenter(double /*(double[3])*/ []center) {
	VTK_API.API_vtkDataSet.GetCenter_1(this, center);
}


// double GetLength()
// "double GetLength()"
public double GetLength() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new double(), return_elements);
	VTK_API.API_vtkDataSet.GetLength_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkDataSet.Initialize_0(this);
}


// virtual void GetScalarRange(double range[2])
// "virtual void GetScalarRange(double range[2])"
public void GetScalarRange(double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataSet.GetScalarRange_0(this, range);
}


// double* GetScalarRange()
// "double *GetScalarRange()"
public IntPtr GetScalarRange() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetScalarRange_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual int GetMaxCellSize()
// "virtual int GetMaxCellSize()"
public int GetMaxCellSize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkDataSet.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	VTK_API.API_vtkDataSet.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkDataSet.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataSet.DeepCopy_0(this, src);
}


// int CheckAttributes()
// "int CheckAttributes()"
public int CheckAttributes() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkDataSet.CheckAttributes_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void GenerateGhostArray(int zeroExt[6])
// "virtual void GenerateGhostArray(int zeroExt[6])"
public void GenerateGhostArray(int /*(int[6])*/ []zeroExt) {
	VTK_API.API_vtkDataSet.GenerateGhostArray_0(this, zeroExt);
}


// virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)
// "virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)"
public void GenerateGhostArray(int /*(int[6])*/ []zeroExt, bool /*(bool)*/ cellOnly) {
	VTK_API.API_vtkDataSet.GenerateGhostArray_1(this, zeroExt, cellOnly);
}


// vtkFieldData* GetAttributesAsFieldData(int type)
// "vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetAttributesAsFieldData_0(returnPointer.GetPtr(), this, type);
	return (vtkFieldData)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfElements(int type)
// "vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	VTK_API.API_vtkDataSet.GetNumberOfElements_0(returnPointer.GetPtr(), this, type);
	return (long)returnPointer;
}


// bool HasAnyGhostCells()
// "bool HasAnyGhostCells()"
public bool HasAnyGhostCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkDataSet.HasAnyGhostCells_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// bool HasAnyGhostPoints()
// "bool HasAnyGhostPoints()"
public bool HasAnyGhostPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkDataSet.HasAnyGhostPoints_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual bool HasAnyBlankCells()
// "virtual bool HasAnyBlankCells()"
public bool HasAnyBlankCells() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkDataSet.HasAnyBlankCells_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual bool HasAnyBlankPoints()
// "virtual bool HasAnyBlankPoints()"
public bool HasAnyBlankPoints() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkDataSet.HasAnyBlankPoints_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// vtkUnsignedCharArray* GetPointGhostArray()
// "vtkUnsignedCharArray* GetPointGhostArray()"
public vtkUnsignedCharArray GetPointGhostArray() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetPointGhostArray_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// void UpdatePointGhostArrayCache()
// "void UpdatePointGhostArrayCache()"
public void UpdatePointGhostArrayCache() {
	VTK_API.API_vtkDataSet.UpdatePointGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocatePointGhostArray()
// "vtkUnsignedCharArray* AllocatePointGhostArray()"
public vtkUnsignedCharArray AllocatePointGhostArray() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.AllocatePointGhostArray_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkUnsignedCharArray* GetCellGhostArray()
// "vtkUnsignedCharArray* GetCellGhostArray()"
public vtkUnsignedCharArray GetCellGhostArray() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.GetCellGhostArray_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// void UpdateCellGhostArrayCache()
// "void UpdateCellGhostArrayCache()"
public void UpdateCellGhostArrayCache() {
	VTK_API.API_vtkDataSet.UpdateCellGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocateCellGhostArray()
// "vtkUnsignedCharArray* AllocateCellGhostArray()"
public vtkUnsignedCharArray AllocateCellGhostArray() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkDataSet.AllocateCellGhostArray_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


}
};
