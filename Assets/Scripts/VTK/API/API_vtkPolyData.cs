
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPolyData {

// static vtkPolyData* New()
// static vtkPolyData *New()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_New_0")] public static extern 
bool vtkPolyData_New_0(IntPtr /*(vtkPolyData**)*/ return_value);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetDataObjectType_0")] public static extern 
bool vtkPolyData_GetDataObjectType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void CopyStructure(vtkDataSet * ds)
// void CopyStructure(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_CopyStructure_0")] public static extern 
bool vtkPolyData_CopyStructure_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfCells_0")] public static extern 
bool vtkPolyData_GetNumberOfCells_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkCell* GetCell(vtkIdType cellId)
// vtkCell *GetCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCell_0")] public static extern 
bool vtkPolyData_GetCell_0(IntPtr /*(vtkCell**)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// void GetCell(vtkIdType cellId, vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCell_1")] public static extern 
bool vtkPolyData_GetCell_1(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkGenericCell*)*/ cell);

// int GetCellType(vtkIdType cellId)
// int GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellType_0")] public static extern 
bool vtkPolyData_GetCellType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void GetCellBounds(vtkIdType cellId, double bounds[6])
// void GetCellBounds(vtkIdType cellId, double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellBounds_0")] public static extern 
bool vtkPolyData_GetCellBounds_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds);

// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellNeighbors_0")] public static extern 
bool vtkPolyData_GetCellNeighbors_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkIdList*)*/ cellIds);

// void CopyCells(vtkPolyData * pd, vtkIdList * idList, vtkPointLocator * locator = nullptr)
// void CopyCells(vtkPolyData *pd, vtkIdList *idList, vtkPointLocator *locator = nullptr)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_CopyCells_0")] public static extern 
bool vtkPolyData_CopyCells_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkPolyData*)*/ pd, IntPtr /*(vtkIdList*)*/ idList, IntPtr /*(vtkPointLocator*)*/ locator);

// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellPoints_0")] public static extern 
bool vtkPolyData_GetCellPoints_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetPointCells_0")] public static extern 
bool vtkPolyData_GetPointCells_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(vtkIdList*)*/ cellIds);

// void ComputeBounds()
// void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ComputeBounds_0")] public static extern 
bool vtkPolyData_ComputeBounds_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_Squeeze_0")] public static extern 
bool vtkPolyData_Squeeze_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetMaxCellSize_0")] public static extern 
bool vtkPolyData_GetMaxCellSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void SetVerts(vtkCellArray * v)
// void SetVerts (vtkCellArray* v)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_SetVerts_0")] public static extern 
bool vtkPolyData_SetVerts_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ v);

// vtkCellArray* GetVerts()
// vtkCellArray *GetVerts()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetVerts_0")] public static extern 
bool vtkPolyData_GetVerts_0(IntPtr /*(vtkCellArray**)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void SetLines(vtkCellArray * l)
// void SetLines (vtkCellArray* l)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_SetLines_0")] public static extern 
bool vtkPolyData_SetLines_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ l);

// vtkCellArray* GetLines()
// vtkCellArray *GetLines()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetLines_0")] public static extern 
bool vtkPolyData_GetLines_0(IntPtr /*(vtkCellArray**)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void SetPolys(vtkCellArray * p)
// void SetPolys (vtkCellArray* p)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_SetPolys_0")] public static extern 
bool vtkPolyData_SetPolys_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ p);

// vtkCellArray* GetPolys()
// vtkCellArray *GetPolys()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetPolys_0")] public static extern 
bool vtkPolyData_GetPolys_0(IntPtr /*(vtkCellArray**)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void SetStrips(vtkCellArray * s)
// void SetStrips (vtkCellArray* s)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_SetStrips_0")] public static extern 
bool vtkPolyData_SetStrips_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkCellArray*)*/ s);

// vtkCellArray* GetStrips()
// vtkCellArray *GetStrips()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetStrips_0")] public static extern 
bool vtkPolyData_GetStrips_0(IntPtr /*(vtkCellArray**)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkIdType GetNumberOfVerts()
// vtkIdType GetNumberOfVerts()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfVerts_0")] public static extern 
bool vtkPolyData_GetNumberOfVerts_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkIdType GetNumberOfLines()
// vtkIdType GetNumberOfLines()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfLines_0")] public static extern 
bool vtkPolyData_GetNumberOfLines_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkIdType GetNumberOfPolys()
// vtkIdType GetNumberOfPolys()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfPolys_0")] public static extern 
bool vtkPolyData_GetNumberOfPolys_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkIdType GetNumberOfStrips()
// vtkIdType GetNumberOfStrips()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfStrips_0")] public static extern 
bool vtkPolyData_GetNumberOfStrips_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_Allocate_0")] public static extern 
bool vtkPolyData_Allocate_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void Allocate(vtkPolyData * inPolyData, vtkIdType numCells = 1000, int extSize = 1000)
// void Allocate(vtkPolyData *inPolyData, vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_Allocate_1")] public static extern 
bool vtkPolyData_Allocate_1(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkPolyData*)*/ inPolyData, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// vtkIdType InsertNextCell(int type, int npts, vtkIdType * pts)
// vtkIdType InsertNextCell(int type, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_InsertNextCell_0")] public static extern 
bool vtkPolyData_InsertNextCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ type, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// vtkIdType InsertNextCell(int type, vtkIdList * pts)
// vtkIdType InsertNextCell(int type, vtkIdList *pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_InsertNextCell_1")] public static extern 
bool vtkPolyData_InsertNextCell_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdList*)*/ pts);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_Reset_0")] public static extern 
bool vtkPolyData_Reset_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// void BuildCells()
// void BuildCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_BuildCells_0")] public static extern 
bool vtkPolyData_BuildCells_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// bool NeedToBuildCells()
// bool NeedToBuildCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_NeedToBuildCells_0")] public static extern 
bool vtkPolyData_NeedToBuildCells_0(IntPtr /*(bool*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void BuildLinks(int initialSize = 0)
// void BuildLinks(int initialSize=0)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_BuildLinks_0")] public static extern 
bool vtkPolyData_BuildLinks_0(IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ initialSize);

// void DeleteCells()
// void DeleteCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_DeleteCells_0")] public static extern 
bool vtkPolyData_DeleteCells_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// void DeleteLinks()
// void DeleteLinks()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_DeleteLinks_0")] public static extern 
bool vtkPolyData_DeleteLinks_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// void GetPointCells(vtkIdType ptId, unsigned short & ncells, vtkIdType *& cells)
// void GetPointCells(vtkIdType ptId, unsigned short& ncells, vtkIdType* &cells)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetPointCells_1")] public static extern 
bool vtkPolyData_GetPointCells_1(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(short&)*/ ncells, IntPtr /*(vtkIdType*&)*/ cells);

// void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList * cellIds)
// void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellEdgeNeighbors_0")] public static extern 
bool vtkPolyData_GetCellEdgeNeighbors_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, IntPtr /*(vtkIdList*)*/ cellIds);

// char GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// unsigned char GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCellPoints_1")] public static extern 
bool vtkPolyData_GetCellPoints_1(IntPtr /*(char*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts);

// char GetCell(vtkIdType cellId, vtkIdType *& pts)
// unsigned char GetCell(vtkIdType cellId, vtkIdType* &pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetCell_2")] public static extern 
bool vtkPolyData_GetCell_2(IntPtr /*(char*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType*&)*/ pts);

// int IsTriangle(int v1, int v2, int v3)
// int IsTriangle(int v1, int v2, int v3)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_IsTriangle_0")] public static extern 
bool vtkPolyData_IsTriangle_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ v1, int /*(int)*/ v2, int /*(int)*/ v3);

// int IsEdge(vtkIdType p1, vtkIdType p2)
// int IsEdge(vtkIdType p1, vtkIdType p2)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_IsEdge_0")] public static extern 
bool vtkPolyData_IsEdge_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2);

// int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
// int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_IsPointUsedByCell_0")] public static extern 
bool vtkPolyData_IsPointUsedByCell_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ReplaceCell_0")] public static extern 
bool vtkPolyData_ReplaceCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// void ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)
// void ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ReplaceCellPoint_0")] public static extern 
bool vtkPolyData_ReplaceCellPoint_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ oldPtId, long /*(vtkIdType)*/ newPtId);

// void ReverseCell(vtkIdType cellId)
// void ReverseCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ReverseCell_0")] public static extern 
bool vtkPolyData_ReverseCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void DeletePoint(vtkIdType ptId)
// void DeletePoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_DeletePoint_0")] public static extern 
bool vtkPolyData_DeletePoint_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void DeleteCell(vtkIdType cellId)
// void DeleteCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_DeleteCell_0")] public static extern 
bool vtkPolyData_DeleteCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void RemoveDeletedCells()
// void RemoveDeletedCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_RemoveDeletedCells_0")] public static extern 
bool vtkPolyData_RemoveDeletedCells_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// vtkIdType InsertNextLinkedPoint(int numLinks)
// vtkIdType InsertNextLinkedPoint(int numLinks)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_InsertNextLinkedPoint_0")] public static extern 
bool vtkPolyData_InsertNextLinkedPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ numLinks);

// vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)
// vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_InsertNextLinkedPoint_1")] public static extern 
bool vtkPolyData_InsertNextLinkedPoint_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, double /*(double[3])*/ []x, int /*(int)*/ numLinks);

// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType * pts)
// vtkIdType InsertNextLinkedCell(int type, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_InsertNextLinkedCell_0")] public static extern 
bool vtkPolyData_InsertNextLinkedCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, int /*(int)*/ type, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// void ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType * pts)
// void ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ReplaceLinkedCell_0")] public static extern 
bool vtkPolyData_ReplaceLinkedCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// void RemoveCellReference(vtkIdType cellId)
// void RemoveCellReference(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_RemoveCellReference_0")] public static extern 
bool vtkPolyData_RemoveCellReference_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void AddCellReference(vtkIdType cellId)
// void AddCellReference(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_AddCellReference_0")] public static extern 
bool vtkPolyData_AddCellReference_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_RemoveReferenceToCell_0")] public static extern 
bool vtkPolyData_RemoveReferenceToCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_AddReferenceToCell_0")] public static extern 
bool vtkPolyData_AddReferenceToCell_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId);

// void ResizeCellList(vtkIdType ptId, int size)
// void ResizeCellList(vtkIdType ptId, int size)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ResizeCellList_0")] public static extern 
bool vtkPolyData_ResizeCellList_0(IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ ptId, int /*(int)*/ size);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_Initialize_0")] public static extern 
bool vtkPolyData_Initialize_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// virtual int GetPiece()
// virtual int GetPiece()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetPiece_0")] public static extern 
bool vtkPolyData_GetPiece_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// virtual int GetNumberOfPieces()
// virtual int GetNumberOfPieces()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetNumberOfPieces_0")] public static extern 
bool vtkPolyData_GetNumberOfPieces_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// virtual int GetGhostLevel()
// virtual int GetGhostLevel()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetGhostLevel_0")] public static extern 
bool vtkPolyData_GetGhostLevel_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetActualMemorySize_0")] public static extern 
bool vtkPolyData_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_ShallowCopy_0")] public static extern 
bool vtkPolyData_ShallowCopy_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_DeepCopy_0")] public static extern 
bool vtkPolyData_DeepCopy_0(IntPtr /*(vtkPolyData*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void RemoveGhostCells()
// void RemoveGhostCells()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_RemoveGhostCells_0")] public static extern 
bool vtkPolyData_RemoveGhostCells_0(IntPtr /*(vtkPolyData*)*/ callingObject);

// static vtkPolyData* GetData(vtkInformation * info)
// static vtkPolyData* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetData_0")] public static extern 
bool vtkPolyData_GetData_0(IntPtr /*(vtkPolyData**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkPolyData* GetData(vtkInformationVector * v, int i = 0)
// static vtkPolyData* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetData_1")] public static extern 
bool vtkPolyData_GetData_1(IntPtr /*(vtkPolyData**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

// int GetScalarFieldCriticalIndex(vtkIdType pointId, vtkDataArray * scalarField)
// int GetScalarFieldCriticalIndex (vtkIdType pointId, vtkDataArray *scalarField)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetScalarFieldCriticalIndex_0")] public static extern 
bool vtkPolyData_GetScalarFieldCriticalIndex_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ pointId, IntPtr /*(vtkDataArray*)*/ scalarField);

// int GetScalarFieldCriticalIndex(vtkIdType pointId, int fieldId)
// int GetScalarFieldCriticalIndex (vtkIdType pointId, int fieldId)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetScalarFieldCriticalIndex_1")] public static extern 
bool vtkPolyData_GetScalarFieldCriticalIndex_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ pointId, int /*(int)*/ fieldId);

// int GetScalarFieldCriticalIndex(vtkIdType pointId, const char * fieldName)
// int GetScalarFieldCriticalIndex (vtkIdType pointId, const char* fieldName)
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetScalarFieldCriticalIndex_2")] public static extern 
bool vtkPolyData_GetScalarFieldCriticalIndex_2(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject, long /*(vtkIdType)*/ pointId, IntPtr /*(char*)*/ fieldName);

// virtual vtkMTimeType GetMeshMTime()
// virtual vtkMTimeType GetMeshMTime()
[DllImport("vtkplugin", EntryPoint="vtkPolyData_GetMeshMTime_0")] public static extern 
bool vtkPolyData_GetMeshMTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkPolyData*)*/ callingObject);

}
};
