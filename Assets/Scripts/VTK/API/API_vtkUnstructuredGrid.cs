
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkUnstructuredGrid {

// static vtkUnstructuredGrid* New()
// static vtkUnstructuredGrid *New()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_New_0")] public static extern 
bool vtkUnstructuredGrid_New_0(IntPtr /*(vtkUnstructuredGrid**)*/ return_value);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetDataObjectType_0")] public static extern 
bool vtkUnstructuredGrid_GetDataObjectType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_Allocate_0")] public static extern 
bool vtkUnstructuredGrid_Allocate_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_InsertNextCell_0")] public static extern 
bool vtkUnstructuredGrid_InsertNextCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds);

// vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// vtkIdType InsertNextCell(int type, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_InsertNextCell_1")] public static extern 
bool vtkUnstructuredGrid_InsertNextCell_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdList*)*/ ptIds);

// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_InsertNextCell_2")] public static extern 
bool vtkUnstructuredGrid_InsertNextCell_2(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_Reset_0")] public static extern 
bool vtkUnstructuredGrid_Reset_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void CopyStructure(vtkDataSet * ds)
// void CopyStructure(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_CopyStructure_0")] public static extern 
bool vtkUnstructuredGrid_CopyStructure_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetNumberOfCells_0")] public static extern 
bool vtkUnstructuredGrid_GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// vtkCell* GetCell(vtkIdType cellId)
// vtkCell *GetCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCell_0")] public static extern 
bool vtkUnstructuredGrid_GetCell_0(IntPtr /*(vtkCell**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// void GetCell(vtkIdType cellId, vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCell_1")] public static extern 
bool vtkUnstructuredGrid_GetCell_1(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkGenericCell*)*/ cell);

// void GetCellBounds(vtkIdType cellId, double bounds[6])
// void GetCellBounds(vtkIdType cellId, double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellBounds_0")] public static extern 
bool vtkUnstructuredGrid_GetCellBounds_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds);

// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellPoints_0")] public static extern 
bool vtkUnstructuredGrid_GetCellPoints_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetPointCells_0")] public static extern 
bool vtkUnstructuredGrid_GetPointCells_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(vtkIdList*)*/ cellIds);

// vtkCellIterator* NewCellIterator()
// vtkCellIterator* NewCellIterator()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_NewCellIterator_0")] public static extern 
bool vtkUnstructuredGrid_NewCellIterator_0(IntPtr /*(vtkCellIterator**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// int GetCellType(vtkIdType cellId)
// int GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellType_0")] public static extern 
bool vtkUnstructuredGrid_GetCellType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkUnsignedCharArray* GetCellTypesArray()
// vtkUnsignedCharArray* GetCellTypesArray()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellTypesArray_0")] public static extern 
bool vtkUnstructuredGrid_GetCellTypesArray_0(IntPtr /*(vtkUnsignedCharArray**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// vtkIdTypeArray* GetCellLocationsArray()
// vtkIdTypeArray* GetCellLocationsArray()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellLocationsArray_0")] public static extern 
bool vtkUnstructuredGrid_GetCellLocationsArray_0(IntPtr /*(vtkIdTypeArray**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_Squeeze_0")] public static extern 
bool vtkUnstructuredGrid_Squeeze_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_Initialize_0")] public static extern 
bool vtkUnstructuredGrid_Initialize_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetMaxCellSize_0")] public static extern 
bool vtkUnstructuredGrid_GetMaxCellSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void BuildLinks()
// void BuildLinks()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_BuildLinks_0")] public static extern 
bool vtkUnstructuredGrid_BuildLinks_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// vtkCellLinks* GetCellLinks()
// vtkCellLinks *GetCellLinks()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellLinks_0")] public static extern 
bool vtkUnstructuredGrid_GetCellLinks_0(IntPtr /*(vtkCellLinks**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// virtual void GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// virtual void GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellPoints_1")] public static extern 
bool vtkUnstructuredGrid_GetCellPoints_1(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts);

// void GetFaceStream(vtkIdType cellId, vtkIdList * ptIds)
// void GetFaceStream(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetFaceStream_0")] public static extern 
bool vtkUnstructuredGrid_GetFaceStream_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// void GetFaceStream(vtkIdType cellId, vtkIdType & nfaces, vtkIdType *& ptIds)
// void GetFaceStream(vtkIdType cellId, vtkIdType& nfaces, vtkIdType* &ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetFaceStream_1")] public static extern 
bool vtkUnstructuredGrid_GetFaceStream_1(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ nfaces, IntPtr /*(vtkIdType*&)*/ ptIds);

// void SetCells(int type, vtkCellArray * cells)
// void SetCells(int type, vtkCellArray *cells)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_SetCells_0")] public static extern 
bool vtkUnstructuredGrid_SetCells_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkCellArray*)*/ cells);

// void SetCells(int * types, vtkCellArray * cells)
// void SetCells(int *types, vtkCellArray *cells)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_SetCells_1")] public static extern 
bool vtkUnstructuredGrid_SetCells_1(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(int*)*/ types, IntPtr /*(vtkCellArray*)*/ cells);

// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells)
// void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_SetCells_2")] public static extern 
bool vtkUnstructuredGrid_SetCells_2(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(vtkUnsignedCharArray*)*/ cellTypes, IntPtr /*(vtkIdTypeArray*)*/ cellLocations, IntPtr /*(vtkCellArray*)*/ cells);

// void SetCells(vtkUnsignedCharArray * cellTypes, vtkIdTypeArray * cellLocations, vtkCellArray * cells, vtkIdTypeArray * faceLocations, vtkIdTypeArray * faces)
// void SetCells(vtkUnsignedCharArray *cellTypes, vtkIdTypeArray *cellLocations, vtkCellArray *cells, vtkIdTypeArray *faceLocations, vtkIdTypeArray *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_SetCells_3")] public static extern 
bool vtkUnstructuredGrid_SetCells_3(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(vtkUnsignedCharArray*)*/ cellTypes, IntPtr /*(vtkIdTypeArray*)*/ cellLocations, IntPtr /*(vtkCellArray*)*/ cells, IntPtr /*(vtkIdTypeArray*)*/ faceLocations, IntPtr /*(vtkIdTypeArray*)*/ faces);

// vtkCellArray* GetCells()
// vtkCellArray *GetCells()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCells_0")] public static extern 
bool vtkUnstructuredGrid_GetCells_0(IntPtr /*(vtkCellArray**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_ReplaceCell_0")] public static extern 
bool vtkUnstructuredGrid_ReplaceCell_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType * pts)
// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_InsertNextLinkedCell_0")] public static extern 
bool vtkUnstructuredGrid_InsertNextLinkedCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_RemoveReferenceToCell_0")] public static extern 
bool vtkUnstructuredGrid_RemoveReferenceToCell_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_AddReferenceToCell_0")] public static extern 
bool vtkUnstructuredGrid_AddReferenceToCell_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void ResizeCellList(vtkIdType ptId, int size)
// void ResizeCellList(vtkIdType ptId, int size)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_ResizeCellList_0")] public static extern 
bool vtkUnstructuredGrid_ResizeCellList_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, int /*(int)*/ size);

// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetCellNeighbors_0")] public static extern 
bool vtkUnstructuredGrid_GetCellNeighbors_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkIdList*)*/ cellIds);

// virtual int GetPiece()
// virtual int GetPiece()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetPiece_0")] public static extern 
bool vtkUnstructuredGrid_GetPiece_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// virtual int GetNumberOfPieces()
// virtual int GetNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetNumberOfPieces_0")] public static extern 
bool vtkUnstructuredGrid_GetNumberOfPieces_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// virtual int GetGhostLevel()
// virtual int GetGhostLevel()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetGhostLevel_0")] public static extern 
bool vtkUnstructuredGrid_GetGhostLevel_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetActualMemorySize_0")] public static extern 
bool vtkUnstructuredGrid_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_ShallowCopy_0")] public static extern 
bool vtkUnstructuredGrid_ShallowCopy_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_DeepCopy_0")] public static extern 
bool vtkUnstructuredGrid_DeepCopy_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetIdsOfCellsOfType_0")] public static extern 
bool vtkUnstructuredGrid_GetIdsOfCellsOfType_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// int IsHomogeneous()
// int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_IsHomogeneous_0")] public static extern 
bool vtkUnstructuredGrid_IsHomogeneous_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// void RemoveGhostCells()
// void RemoveGhostCells()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_RemoveGhostCells_0")] public static extern 
bool vtkUnstructuredGrid_RemoveGhostCells_0(IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// static vtkUnstructuredGrid* GetData(vtkInformation * info)
// static vtkUnstructuredGrid* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetData_0")] public static extern 
bool vtkUnstructuredGrid_GetData_0(IntPtr /*(vtkUnstructuredGrid**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkUnstructuredGrid* GetData(vtkInformationVector * v, int i = 0)
// static vtkUnstructuredGrid* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetData_1")] public static extern 
bool vtkUnstructuredGrid_GetData_1(IntPtr /*(vtkUnstructuredGrid**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

// vtkIdType* GetFaces(vtkIdType cellId)
// vtkIdType *GetFaces(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetFaces_0")] public static extern 
bool vtkUnstructuredGrid_GetFaces_0(IntPtr /*(vtkIdType**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkIdTypeArray* GetFaces()
// vtkIdTypeArray* GetFaces()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetFaces_1")] public static extern 
bool vtkUnstructuredGrid_GetFaces_1(IntPtr /*(vtkIdTypeArray**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// vtkIdTypeArray* GetFaceLocations()
// vtkIdTypeArray* GetFaceLocations()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetFaceLocations_0")] public static extern 
bool vtkUnstructuredGrid_GetFaceLocations_0(IntPtr /*(vtkIdTypeArray**)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// int InitializeFacesRepresentation(vtkIdType numPrevCells)
// int InitializeFacesRepresentation(vtkIdType numPrevCells)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_InitializeFacesRepresentation_0")] public static extern 
bool vtkUnstructuredGrid_InitializeFacesRepresentation_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ numPrevCells);

// virtual vtkMTimeType GetMeshMTime()
// virtual vtkMTimeType GetMeshMTime()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_GetMeshMTime_0")] public static extern 
bool vtkUnstructuredGrid_GetMeshMTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkUnstructuredGrid*)*/ callingObject);

// static void DecomposeAPolyhedronCell(vtkCellArray * polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// static void DecomposeAPolyhedronCell(vtkCellArray *polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_DecomposeAPolyhedronCell_0")] public static extern 
bool vtkUnstructuredGrid_DecomposeAPolyhedronCell_0(IntPtr /*(vtkCellArray*)*/ polyhedronCellArray, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, IntPtr /*(vtkCellArray*)*/ cellArray, IntPtr /*(vtkIdTypeArray*)*/ faces);

// static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_DecomposeAPolyhedronCell_1")] public static extern 
bool vtkUnstructuredGrid_DecomposeAPolyhedronCell_1(IntPtr /*(vtkIdType*)*/ polyhedronCellStream, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, IntPtr /*(vtkCellArray*)*/ cellArray, IntPtr /*(vtkIdTypeArray*)*/ faces);

// static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_DecomposeAPolyhedronCell_2")] public static extern 
bool vtkUnstructuredGrid_DecomposeAPolyhedronCell_2(long /*(vtkIdType)*/ nCellFaces, IntPtr /*(vtkIdType*)*/ inFaceStream, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkCellArray*)*/ cellArray, IntPtr /*(vtkIdTypeArray*)*/ faces);

// static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)
// static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_ConvertFaceStreamPointIds_0")] public static extern 
bool vtkUnstructuredGrid_ConvertFaceStreamPointIds_0(IntPtr /*(vtkIdList*)*/ faceStream, IntPtr /*(vtkIdType*)*/ idMap);

// static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)
// static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGrid_ConvertFaceStreamPointIds_1")] public static extern 
bool vtkUnstructuredGrid_ConvertFaceStreamPointIds_1(long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faceStream, IntPtr /*(vtkIdType*)*/ idMap);

}
};
