

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGrid : vtkUnstructuredGridBase {
		public vtkUnstructuredGrid(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGrid(IntPtr p) {return new vtkUnstructuredGrid(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGrid o) {return o.GetPtr();}

// static vtkUnstructuredGrid* New()
// "static vtkUnstructuredGrid *New()"
public static vtkUnstructuredGrid New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.New_0(returnPointer.GetPtr());
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGrid.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGrid.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkUnstructuredGrid* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGrid* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGrid SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* NewInstance()
// "vtkUnstructuredGrid *NewInstance()"
public vtkUnstructuredGrid NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkUnstructuredGrid.Allocate_0(this, numCells, extSize);
}


// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// "vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)"
public long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGrid.InsertNextCell_0(returnPointer.GetPtr(), this, type, npts, ptIds);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// "vtkIdType InsertNextCell(int type, vtkIdList *ptIds)"
public long InsertNextCell(int /*(int)*/ type, vtkIdList /*(vtkIdList*)*/ ptIds) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGrid.InsertNextCell_1(returnPointer.GetPtr(), this, type, ptIds);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// "vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)"
public long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGrid.InsertNextCell_2(returnPointer.GetPtr(), this, type, npts, ptIds, nfaces, faces);
	return (long)returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkUnstructuredGrid.Reset_0(this);
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkUnstructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGrid.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetCell_0(returnPointer.GetPtr(), this, cellId);
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkUnstructuredGrid.GetCell_1(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkUnstructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.NewCellIterator_0(returnPointer.GetPtr(), this);
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetCellType_0(returnPointer.GetPtr(), this, cellId);
	return (int)returnPointer;
}


// vtkUnsignedCharArray* GetCellTypesArray()
// "vtkUnsignedCharArray* GetCellTypesArray()"
public vtkUnsignedCharArray GetCellTypesArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetCellTypesArray_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* GetCellLocationsArray()
// "vtkIdTypeArray* GetCellLocationsArray()"
public vtkIdTypeArray GetCellLocationsArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetCellLocationsArray_0(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkUnstructuredGrid.Squeeze_0(this);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkUnstructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void BuildLinks()
// "void BuildLinks()"
public void BuildLinks() {
	VTK_API.API_vtkUnstructuredGrid.BuildLinks_0(this);
}


// vtkCellLinks* GetCellLinks()
// "vtkCellLinks *GetCellLinks()"
public vtkCellLinks GetCellLinks() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetCellLinks_0(returnPointer.GetPtr(), this);
	return (vtkCellLinks)(IntPtr)returnPointer;
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	VTK_API.API_vtkUnstructuredGrid.GetCellPoints_1(this, cellId, npts, pts);
}


// void GetFaceStream(vtkIdType cellId, vtkIdList * ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdList *ptIds)"
public void GetFaceStream(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetFaceStream_0(this, cellId, ptIds);
}


// void GetFaceStream(vtkIdType cellId, vtkIdType & nfaces, vtkIdType *& ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdType& nfaces, vtkIdType* &ptIds)"
public void GetFaceStream(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ nfaces, IntPtr /*(vtkIdType*&)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetFaceStream_1(this, cellId, nfaces, ptIds);
}


// void SetCells(int type, vtkCellArray * cells)
// "void SetCells(int type, vtkCellArray *cells)"
public void SetCells(int /*(int)*/ type, vtkCellArray /*(vtkCellArray*)*/ cells) {
	VTK_API.API_vtkUnstructuredGrid.SetCells_0(this, type, cells);
}


// void SetCells(int * types, vtkCellArray * cells)
// "void SetCells(int *types, vtkCellArray *cells)"
public void SetCells(IntPtr /*(int*)*/ types, vtkCellArray /*(vtkCellArray*)*/ cells) {
	VTK_API.API_vtkUnstructuredGrid.SetCells_1(this, types, cells);
}


// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells)
// "void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells)"
public void SetCells(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations, vtkCellArray /*(vtkCellArray*)*/ cells) {
	VTK_API.API_vtkUnstructuredGrid.SetCells_2(this, cellTypes, cellLocations, cells);
}


// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells, vtkIdTypeArray * faceLocations, vtkIdTypeArray * faces)
// "void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells, vtkIdTypeArray *faceLocations, vtkIdTypeArray *faces)"
public void SetCells(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ cellTypes, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cellLocations, vtkCellArray /*(vtkCellArray*)*/ cells, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faceLocations, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.SetCells_3(this, cellTypes, cellLocations, cells, faceLocations, faces);
}


// vtkCellArray* GetCells()
// "vtkCellArray *GetCells()"
public vtkCellArray GetCells() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetCells_0(returnPointer.GetPtr(), this);
	return (vtkCellArray)(IntPtr)returnPointer;
}


// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public void ReplaceCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	VTK_API.API_vtkUnstructuredGrid.ReplaceCell_0(this, cellId, npts, pts);
}


// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType * pts)
// "vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType *pts)"
public long InsertNextLinkedCell(int /*(int)*/ type, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGrid.InsertNextLinkedCell_0(returnPointer.GetPtr(), this, type, npts, pts);
	return (long)returnPointer;
}


// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void RemoveReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkUnstructuredGrid.RemoveReferenceToCell_0(this, ptId, cellId);
}


// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void AddReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkUnstructuredGrid.AddReferenceToCell_0(this, ptId, cellId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	VTK_API.API_vtkUnstructuredGrid.ResizeCellList_0(this, ptId, size);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// virtual int GetPiece()
// "virtual int GetPiece()"
public int GetPiece() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetPiece_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces()"
public int GetNumberOfPieces() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetNumberOfPieces_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel()"
public int GetGhostLevel() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.GetGhostLevel_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkUnstructuredGrid.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGrid.DeepCopy_0(this, src);
}


// void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	VTK_API.API_vtkUnstructuredGrid.GetIdsOfCellsOfType_0(this, type, array);
}


// int IsHomogeneous()
// "int IsHomogeneous()"
public int IsHomogeneous() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.IsHomogeneous_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void RemoveGhostCells()
// "void RemoveGhostCells()"
public void RemoveGhostCells() {
	VTK_API.API_vtkUnstructuredGrid.RemoveGhostCells_0(this);
}


// static vtkUnstructuredGrid* GetData(vtkInformation * info)
// "static vtkUnstructuredGrid* GetData(vtkInformation* info)"
public static vtkUnstructuredGrid GetData(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetData_0(returnPointer.GetPtr(), info);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// static vtkUnstructuredGrid* GetData(vtkInformationVector * v, int i = 0)
// "static vtkUnstructuredGrid* GetData(vtkInformationVector* v, int i=0)"
public static vtkUnstructuredGrid GetData(vtkInformationVector /*(vtkInformationVector*)*/ v, int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetData_1(returnPointer.GetPtr(), v, i);
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkIdType* GetFaces(vtkIdType cellId)
// "vtkIdType *GetFaces(vtkIdType cellId)"
public IntPtr GetFaces(long /*(vtkIdType)*/ cellId) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetFaces_0(returnPointer.GetPtr(), this, cellId);
	return (IntPtr)returnPointer;
}


// vtkIdTypeArray* GetFaces()
// "vtkIdTypeArray* GetFaces()"
public vtkIdTypeArray GetFaces() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetFaces_1(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* GetFaceLocations()
// "vtkIdTypeArray* GetFaceLocations()"
public vtkIdTypeArray GetFaceLocations() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGrid.GetFaceLocations_0(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// int InitializeFacesRepresentation(vtkIdType numPrevCells)
// "int InitializeFacesRepresentation(vtkIdType numPrevCells)"
public int InitializeFacesRepresentation(long /*(vtkIdType)*/ numPrevCells) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGrid.InitializeFacesRepresentation_0(returnPointer.GetPtr(), this, numPrevCells);
	return (int)returnPointer;
}


// virtual vtkMTimeType GetMeshMTime()
// "virtual vtkMTimeType GetMeshMTime()"
public ulong GetMeshMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkUnstructuredGrid.GetMeshMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// static void DecomposeAPolyhedronCell(vtkCellArray * polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkCellArray *polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public static void DecomposeAPolyhedronCell(vtkCellArray /*(vtkCellArray*)*/ polyhedronCellArray, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_0(polyhedronCellArray, nCellpts, nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public static void DecomposeAPolyhedronCell(IntPtr /*(vtkIdType*)*/ polyhedronCellStream, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_1(polyhedronCellStream, nCellpts, nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)"
public static void DecomposeAPolyhedronCell(long /*(vtkIdType)*/ nCellFaces, IntPtr /*(vtkIdType*)*/ inFaceStream, IntPtr /*(vtkIdType&)*/ nCellpts, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_2(nCellFaces, inFaceStream, nCellpts, cellArray, faces);
}


// static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)"
public static void ConvertFaceStreamPointIds(vtkIdList /*(vtkIdList*)*/ faceStream, IntPtr /*(vtkIdType*)*/ idMap) {
	VTK_API.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_0(faceStream, idMap);
}


// static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)"
public static void ConvertFaceStreamPointIds(long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faceStream, IntPtr /*(vtkIdType*)*/ idMap) {
	VTK_API.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_1(nfaces, faceStream, idMap);
}


}
};
