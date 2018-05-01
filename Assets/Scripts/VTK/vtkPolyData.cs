

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyData : vtkPointSet {

// static vtkPolyData* New()
// "static vtkPolyData *New()"
public new static vtkPolyData New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public new void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkPolyData.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public new vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.GetCell_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public new void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkPolyData.GetCell_1(this, cellId, cell);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public new int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetCellType_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public new void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	API_vtkPolyData.GetCellBounds_0(this, cellId, bounds);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public new void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkPolyData.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// void CopyCells(vtkPolyData * pd, vtkIdList * idList, vtkPointLocator * locator = nullptr)
// "void CopyCells(vtkPolyData *pd, vtkIdList *idList, vtkPointLocator *locator = nullptr)"
public new void CopyCells(vtkPolyData /*(vtkPolyData*)*/ pd, vtkIdList /*(vtkIdList*)*/ idList, vtkPointLocator /*(vtkPointLocator*)*/ locator) {
	API_vtkPolyData.CopyCells_0(this, pd, idList, locator);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public new void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkPolyData.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public new void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkPolyData.GetPointCells_0(this, ptId, cellIds);
}


// void ComputeBounds()
// "void ComputeBounds()"
public new void ComputeBounds() {
	API_vtkPolyData.ComputeBounds_0(this);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkPolyData.Squeeze_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public new int GetMaxCellSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetMaxCellSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetVerts(vtkCellArray * v)
// "void SetVerts (vtkCellArray* v)"
public new void SetVerts(vtkCellArray /*(vtkCellArray*)*/ v) {
	API_vtkPolyData.SetVerts_0(this, v);
}


// vtkCellArray* GetVerts()
// "vtkCellArray *GetVerts()"
public new vtkCellArray GetVerts() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.GetVerts_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetLines(vtkCellArray * l)
// "void SetLines (vtkCellArray* l)"
public new void SetLines(vtkCellArray /*(vtkCellArray*)*/ l) {
	API_vtkPolyData.SetLines_0(this, l);
}


// vtkCellArray* GetLines()
// "vtkCellArray *GetLines()"
public new vtkCellArray GetLines() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.GetLines_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetPolys(vtkCellArray * p)
// "void SetPolys (vtkCellArray* p)"
public new void SetPolys(vtkCellArray /*(vtkCellArray*)*/ p) {
	API_vtkPolyData.SetPolys_0(this, p);
}


// vtkCellArray* GetPolys()
// "vtkCellArray *GetPolys()"
public new vtkCellArray GetPolys() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.GetPolys_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetStrips(vtkCellArray * s)
// "void SetStrips (vtkCellArray* s)"
public new void SetStrips(vtkCellArray /*(vtkCellArray*)*/ s) {
	API_vtkPolyData.SetStrips_0(this, s);
}


// vtkCellArray* GetStrips()
// "vtkCellArray *GetStrips()"
public new vtkCellArray GetStrips() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPolyData.GetStrips_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfVerts()
// "vtkIdType GetNumberOfVerts()"
public new long GetNumberOfVerts() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.GetNumberOfVerts_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfLines()
// "vtkIdType GetNumberOfLines()"
public new long GetNumberOfLines() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.GetNumberOfLines_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfPolys()
// "vtkIdType GetNumberOfPolys()"
public new long GetNumberOfPolys() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.GetNumberOfPolys_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfStrips()
// "vtkIdType GetNumberOfStrips()"
public new long GetNumberOfStrips() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.GetNumberOfStrips_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public new void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	API_vtkPolyData.Allocate_0(this, numCells, extSize);
}


// void Allocate(vtkPolyData * inPolyData, vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkPolyData *inPolyData, vtkIdType numCells=1000, int extSize=1000)"
public new void Allocate(vtkPolyData /*(vtkPolyData*)*/ inPolyData, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	API_vtkPolyData.Allocate_1(this, inPolyData, numCells, extSize);
}


// vtkIdType InsertNextCell(int type, int npts, vtkIdType * pts)
// "vtkIdType InsertNextCell(int type, int npts, vtkIdType *pts)"
public new long InsertNextCell(int /*(int)*/ type, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.InsertNextCell_0(this, returnPointer, type, npts, pts);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextCell(int type, vtkIdList * pts)
// "vtkIdType InsertNextCell(int type, vtkIdList *pts)"
public new long InsertNextCell(int /*(int)*/ type, vtkIdList /*(vtkIdList*)*/ pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.InsertNextCell_1(this, returnPointer, type, pts);
	return Ptr.deref(returnPointer);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkPolyData.Reset_0(this);
}


// void BuildCells()
// "void BuildCells()"
public new void BuildCells() {
	API_vtkPolyData.BuildCells_0(this);
}


// bool NeedToBuildCells()
// "bool NeedToBuildCells()"
public new bool NeedToBuildCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkPolyData.NeedToBuildCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void BuildLinks(int initialSize = 0)
// "void BuildLinks(int initialSize=0)"
public new void BuildLinks(int /*(int)*/ initialSize) {
	API_vtkPolyData.BuildLinks_0(this, initialSize);
}


// void DeleteCells()
// "void DeleteCells()"
public new void DeleteCells() {
	API_vtkPolyData.DeleteCells_0(this);
}


// void DeleteLinks()
// "void DeleteLinks()"
public new void DeleteLinks() {
	API_vtkPolyData.DeleteLinks_0(this);
}


// void GetPointCells(vtkIdType ptId, unsigned short & ncells, vtkIdType *& cells)
// "void GetPointCells(vtkIdType ptId, unsigned short& ncells, vtkIdType* &cells)"
public new void GetPointCells(long /*(vtkIdType)*/ ptId, short /*(short&)*/ []ncells, long /*(vtkIdType*&)*/ []cells) {
	API_vtkPolyData.GetPointCells_1(this, ptId, *ncells, *cells);
}


// void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList * cellIds)
// "void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList *cellIds)"
public new void GetCellEdgeNeighbors(long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkPolyData.GetCellEdgeNeighbors_0(this, cellId, p1, p2, cellIds);
}


// char GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// "unsigned char GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)"
public new char GetCellPoints(long /*(vtkIdType)*/ cellId, long /*(vtkIdType&)*/ []npts, long /*(vtkIdType*&)*/ []pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkPolyData.GetCellPoints_1(this, returnPointer, cellId, *npts, *pts);
	return Ptr.deref(returnPointer);
}


// char GetCell(vtkIdType cellId, vtkIdType *& pts)
// "unsigned char GetCell(vtkIdType cellId, vtkIdType* &pts)"
public new char GetCell(long /*(vtkIdType)*/ cellId, long /*(vtkIdType*&)*/ []pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkPolyData.GetCell_2(this, returnPointer, cellId, *pts);
	return Ptr.deref(returnPointer);
}


// int IsTriangle(int v1, int v2, int v3)
// "int IsTriangle(int v1, int v2, int v3)"
public new int IsTriangle(int /*(int)*/ v1, int /*(int)*/ v2, int /*(int)*/ v3) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.IsTriangle_0(this, returnPointer, v1, v2, v3);
	return Ptr.deref(returnPointer);
}


// int IsEdge(vtkIdType p1, vtkIdType p2)
// "int IsEdge(vtkIdType p1, vtkIdType p2)"
public new int IsEdge(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.IsEdge_0(this, returnPointer, p1, p2);
	return Ptr.deref(returnPointer);
}


// int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
// "int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)"
public new int IsPointUsedByCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.IsPointUsedByCell_0(this, returnPointer, ptId, cellId);
	return Ptr.deref(returnPointer);
}


// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public new void ReplaceCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	API_vtkPolyData.ReplaceCell_0(this, cellId, npts, pts);
}


// void ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)
// "void ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)"
public new void ReplaceCellPoint(long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ oldPtId, long /*(vtkIdType)*/ newPtId) {
	API_vtkPolyData.ReplaceCellPoint_0(this, cellId, oldPtId, newPtId);
}


// void ReverseCell(vtkIdType cellId)
// "void ReverseCell(vtkIdType cellId)"
public new void ReverseCell(long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.ReverseCell_0(this, cellId);
}


// void DeletePoint(vtkIdType ptId)
// "void DeletePoint(vtkIdType ptId)"
public new void DeletePoint(long /*(vtkIdType)*/ ptId) {
	API_vtkPolyData.DeletePoint_0(this, ptId);
}


// void DeleteCell(vtkIdType cellId)
// "void DeleteCell(vtkIdType cellId)"
public new void DeleteCell(long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.DeleteCell_0(this, cellId);
}


// void RemoveDeletedCells()
// "void RemoveDeletedCells()"
public new void RemoveDeletedCells() {
	API_vtkPolyData.RemoveDeletedCells_0(this);
}


// vtkIdType InsertNextLinkedPoint(int numLinks)
// "vtkIdType InsertNextLinkedPoint(int numLinks)"
public new long InsertNextLinkedPoint(int /*(int)*/ numLinks) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.InsertNextLinkedPoint_0(this, returnPointer, numLinks);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)
// "vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)"
public new long InsertNextLinkedPoint(double /*(double[3])*/ []x, int /*(int)*/ numLinks) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.InsertNextLinkedPoint_1(this, returnPointer, x, numLinks);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType * pts)
// "vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType *pts)"
public new long InsertNextLinkedCell(int /*(int)*/ type, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPolyData.InsertNextLinkedCell_0(this, returnPointer, type, npts, pts);
	return Ptr.deref(returnPointer);
}


// void ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "void ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public new void ReplaceLinkedCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	API_vtkPolyData.ReplaceLinkedCell_0(this, cellId, npts, pts);
}


// void RemoveCellReference(vtkIdType cellId)
// "void RemoveCellReference(vtkIdType cellId)"
public new void RemoveCellReference(long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.RemoveCellReference_0(this, cellId);
}


// void AddCellReference(vtkIdType cellId)
// "void AddCellReference(vtkIdType cellId)"
public new void AddCellReference(long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.AddCellReference_0(this, cellId);
}


// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public new void RemoveReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.RemoveReferenceToCell_0(this, ptId, cellId);
}


// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public new void AddReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	API_vtkPolyData.AddReferenceToCell_0(this, ptId, cellId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public new void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	API_vtkPolyData.ResizeCellList_0(this, ptId, size);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkPolyData.Initialize_0(this);
}


// virtual int GetPiece()
// "virtual int GetPiece()"
public new int GetPiece() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetPiece_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces()"
public new int GetNumberOfPieces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetNumberOfPieces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel()"
public new int GetGhostLevel() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetGhostLevel_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPolyData.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkPolyData.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkPolyData.DeepCopy_0(this, src);
}


// void RemoveGhostCells()
// "void RemoveGhostCells()"
public new void RemoveGhostCells() {
	API_vtkPolyData.RemoveGhostCells_0(this);
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, vtkDataArray * scalarField)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, vtkDataArray *scalarField)"
public new int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, vtkDataArray /*(vtkDataArray*)*/ scalarField) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetScalarFieldCriticalIndex_0(this, returnPointer, pointId, scalarField);
	return Ptr.deref(returnPointer);
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, int fieldId)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, int fieldId)"
public new int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, int /*(int)*/ fieldId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetScalarFieldCriticalIndex_1(this, returnPointer, pointId, fieldId);
	return Ptr.deref(returnPointer);
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, const char * fieldName)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, const char* fieldName)"
public new int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, char /*(char*)*/ []fieldName) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkPolyData.GetScalarFieldCriticalIndex_2(this, returnPointer, pointId, fieldName);
	return Ptr.deref(returnPointer);
}


// virtual vtkMTimeType GetMeshMTime()
// "virtual vtkMTimeType GetMeshMTime()"
public new ulong GetMeshMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPolyData.GetMeshMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
