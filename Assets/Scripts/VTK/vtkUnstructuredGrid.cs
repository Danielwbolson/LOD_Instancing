

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGrid : vtkUnstructuredGridBase {

// static vtkUnstructuredGrid* New()
// "static vtkUnstructuredGrid *New()"
public new static vtkUnstructuredGrid New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public new void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	API_vtkUnstructuredGrid.Allocate_0(this, numCells, extSize);
}


// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// "vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)"
public new long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, long /*(vtkIdType*)*/ []ptIds) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.InsertNextCell_0(this, returnPointer, type, npts, ptIds);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// "vtkIdType InsertNextCell(int type, vtkIdList *ptIds)"
public new long InsertNextCell(int /*(int)*/ type, vtkIdList /*(vtkIdList*)*/ ptIds) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.InsertNextCell_1(this, returnPointer, type, ptIds);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// "vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)"
public new long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, long /*(vtkIdType*)*/ []ptIds, long /*(vtkIdType)*/ nfaces, long /*(vtkIdType*)*/ []faces) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.InsertNextCell_2(this, returnPointer, type, npts, ptIds, nfaces, faces);
	return Ptr.deref(returnPointer);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkUnstructuredGrid.Reset_0(this);
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public new void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	API_vtkUnstructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public new long GetNumberOfCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.GetNumberOfCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public new vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetCell_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public new void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	API_vtkUnstructuredGrid.GetCell_1(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public new void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	API_vtkUnstructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public new void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkUnstructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public new void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkUnstructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public new vtkCellIterator NewCellIterator() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.NewCellIterator_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public new int GetCellType(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetCellType_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// vtkUnsignedCharArray* GetCellTypesArray()
// "vtkUnsignedCharArray* GetCellTypesArray()"
public new vtkUnsignedCharArray GetCellTypesArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetCellTypesArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdTypeArray* GetCellLocationsArray()
// "vtkIdTypeArray* GetCellLocationsArray()"
public new vtkIdTypeArray GetCellLocationsArray() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetCellLocationsArray_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkUnstructuredGrid.Squeeze_0(this);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkUnstructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public new int GetMaxCellSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetMaxCellSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void BuildLinks()
// "void BuildLinks()"
public new void BuildLinks() {
	API_vtkUnstructuredGrid.BuildLinks_0(this);
}


// vtkCellLinks* GetCellLinks()
// "vtkCellLinks *GetCellLinks()"
public new vtkCellLinks GetCellLinks() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetCellLinks_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)"
public new void GetCellPoints(long /*(vtkIdType)*/ cellId, long /*(vtkIdType&)*/ []npts, long /*(vtkIdType*&)*/ []pts) {
	API_vtkUnstructuredGrid.GetCellPoints_1(this, cellId, *npts, *pts);
}


// void GetFaceStream(vtkIdType cellId, vtkIdList * ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdList *ptIds)"
public new void GetFaceStream(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	API_vtkUnstructuredGrid.GetFaceStream_0(this, cellId, ptIds);
}


// void GetFaceStream(vtkIdType cellId, vtkIdType & nfaces, vtkIdType *& ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdType& nfaces, vtkIdType* &ptIds)"
public new void GetFaceStream(long /*(vtkIdType)*/ cellId, long /*(vtkIdType&)*/ []nfaces, long /*(vtkIdType*&)*/ []ptIds) {
	API_vtkUnstructuredGrid.GetFaceStream_1(this, cellId, *nfaces, *ptIds);
}


// void SetCells(int type, vtkCellArray * cells)
// "void SetCells(int type, vtkCellArray *cells)"
public new void SetCells(int /*(int)*/ type, vtkCellArray /*(vtkCellArray*)*/ cells) {
	API_vtkUnstructuredGrid.SetCells_0(this, type, cells);
}


// void SetCells(int * types, vtkCellArray * cells)
// "void SetCells(int *types, vtkCellArray *cells)"
public new void SetCells(int /*(int*)*/ []types, vtkCellArray /*(vtkCellArray*)*/ cells) {
	API_vtkUnstructuredGrid.SetCells_1(this, types, cells);
}


// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells)
// "void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells)"
public new void SetCells(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations, vtkCellArray /*(vtkCellArray*)*/ cells) {
	API_vtkUnstructuredGrid.SetCells_2(this, cellTypes, cellLocations, cells);
}


// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells, vtkIdTypeArray * faceLocations, vtkIdTypeArray * faces)
// "void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells, vtkIdTypeArray *faceLocations, vtkIdTypeArray *faces)"
public new void SetCells(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations, vtkCellArray /*(vtkCellArray*)*/ cells, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faceLocations, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	API_vtkUnstructuredGrid.SetCells_3(this, cellTypes, cellLocations, cells, faceLocations, faces);
}


// vtkCellArray* GetCells()
// "vtkCellArray *GetCells()"
public new vtkCellArray GetCells() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetCells_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public new void ReplaceCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	API_vtkUnstructuredGrid.ReplaceCell_0(this, cellId, npts, pts);
}


// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType * pts)
// "vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType *pts)"
public new long InsertNextLinkedCell(int /*(int)*/ type, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.InsertNextLinkedCell_0(this, returnPointer, type, npts, pts);
	return Ptr.deref(returnPointer);
}


// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public new void RemoveReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	API_vtkUnstructuredGrid.RemoveReferenceToCell_0(this, ptId, cellId);
}


// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public new void AddReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	API_vtkUnstructuredGrid.AddReferenceToCell_0(this, ptId, cellId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public new void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	API_vtkUnstructuredGrid.ResizeCellList_0(this, ptId, size);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public new void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	API_vtkUnstructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// virtual int GetPiece()
// "virtual int GetPiece()"
public new int GetPiece() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetPiece_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces()"
public new int GetNumberOfPieces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetNumberOfPieces_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel()"
public new int GetGhostLevel() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.GetGhostLevel_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkUnstructuredGrid.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkUnstructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkUnstructuredGrid.DeepCopy_0(this, src);
}


// void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public new void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	API_vtkUnstructuredGrid.GetIdsOfCellsOfType_0(this, type, array);
}


// int IsHomogeneous()
// "int IsHomogeneous()"
public new int IsHomogeneous() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.IsHomogeneous_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void RemoveGhostCells()
// "void RemoveGhostCells()"
public new void RemoveGhostCells() {
	API_vtkUnstructuredGrid.RemoveGhostCells_0(this);
}


// vtkIdType* GetFaces(vtkIdType cellId)
// "vtkIdType *GetFaces(vtkIdType cellId)"
public new long GetFaces(long /*(vtkIdType)*/ cellId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGrid.GetFaces_0(this, returnPointer, cellId);
	return Ptr.deref(returnPointer);
}


// vtkIdTypeArray* GetFaces()
// "vtkIdTypeArray* GetFaces()"
public new vtkIdTypeArray GetFaces() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetFaces_1(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdTypeArray* GetFaceLocations()
// "vtkIdTypeArray* GetFaceLocations()"
public new vtkIdTypeArray GetFaceLocations() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkUnstructuredGrid.GetFaceLocations_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int InitializeFacesRepresentation(vtkIdType numPrevCells)
// "int InitializeFacesRepresentation(vtkIdType numPrevCells)"
public new int InitializeFacesRepresentation(long /*(vtkIdType)*/ numPrevCells) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGrid.InitializeFacesRepresentation_0(this, returnPointer, numPrevCells);
	return Ptr.deref(returnPointer);
}


// virtual vtkMTimeType GetMeshMTime()
// "virtual vtkMTimeType GetMeshMTime()"
public new ulong GetMeshMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkUnstructuredGrid.GetMeshMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static void DecomposeAPolyhedronCell(vtkCellArray * polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkCellArray *polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public new static void DecomposeAPolyhedronCell(vtkCellArray /*(vtkCellArray*)*/ polyhedronCellArray, long /*(vtkIdType&)*/ []nCellpts, long /*(vtkIdType&)*/ []nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_0(polyhedronCellArray, *nCellpts, *nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public new static void DecomposeAPolyhedronCell(long /*(vtkIdType*)*/ []polyhedronCellStream, long /*(vtkIdType&)*/ []nCellpts, long /*(vtkIdType&)*/ []nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_1(polyhedronCellStream, *nCellpts, *nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)"
public new static void DecomposeAPolyhedronCell(long /*(vtkIdType)*/ nCellFaces, long /*(vtkIdType*)*/ []inFaceStream, long /*(vtkIdType&)*/ []nCellpts, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_2(nCellFaces, inFaceStream, *nCellpts, cellArray, faces);
}


// static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)"
public new static void ConvertFaceStreamPointIds(vtkIdList /*(vtkIdList*)*/ faceStream, long /*(vtkIdType*)*/ []idMap) {
	API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_0(faceStream, idMap);
}


// static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)"
public new static void ConvertFaceStreamPointIds(long /*(vtkIdType)*/ nfaces, long /*(vtkIdType*)*/ []faceStream, long /*(vtkIdType*)*/ []idMap) {
	API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_1(nfaces, faceStream, idMap);
}


}
};
