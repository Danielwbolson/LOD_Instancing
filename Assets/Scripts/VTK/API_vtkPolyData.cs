
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPolyData {

//       Method: static vtkPolyData * vtkPolyData::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyData_New_0")] public static extern 
bool New(IntPtr /*vtkPolyData** */ ret);

//       Method: virtual const char * vtkPolyData::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: int vtkPolyData::GetDataObjectType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetDataObjectType_0")] public static extern 
bool GetDataObjectType(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::CopyStructure(vtkDataSet* ds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_CopyStructure_0")] public static extern 
bool CopyStructure(IntPtr /*vtkPolyData* */ obj, IntPtr/*vtkDataSet* */ ds);

//       Method: vtkIdType vtkPolyData::GetNumberOfCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkCell * vtkPolyData::GetCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCell_0")] public static extern 
bool GetCell(IntPtr /*vtkCell** */ ret, IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCell_1")] public static extern 
bool GetCell(IntPtr /*vtkPolyData* */ obj, long cellId, IntPtr/*vtkGenericCell* */ cell);

//       Method: int vtkPolyData::GetCellType(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCellBounds_0")] public static extern 
bool GetCellBounds(IntPtr /*vtkPolyData* */ obj, long cellId, double[] /*6*/ bounds);

//       Method: void vtkPolyData::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCellNeighbors_0")] public static extern 
bool GetCellNeighbors(IntPtr /*vtkPolyData* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkIdList* */ cellIds);

//       Method: void vtkPolyData::CopyCells(vtkPolyData* pd, vtkIdList* idList, vtkPointLocator* locator)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_CopyCells_0")] public static extern 
bool CopyCells(IntPtr /*vtkPolyData* */ obj, IntPtr/*vtkPolyData* */ pd, IntPtr/*vtkIdList* */ idList, IntPtr/*vtkPointLocator* */ locator);

//       Method: void vtkPolyData::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCellPoints_0")] public static extern 
bool GetCellPoints(IntPtr /*vtkPolyData* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds);

//       Method: void vtkPolyData::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetPointCells_0")] public static extern 
bool GetPointCells(IntPtr /*vtkPolyData* */ obj, long ptId, IntPtr/*vtkIdList* */ cellIds);

//       Method: void vtkPolyData::ComputeBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ComputeBounds_0")] public static extern 
bool ComputeBounds(IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkPolyData* */ obj);

//       Method: int vtkPolyData::GetMaxCellSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkCellArray * vtkPolyData::GetVerts()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetVerts_0")] public static extern 
bool GetVerts(IntPtr /*vtkCellArray** */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkCellArray * vtkPolyData::GetLines()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetLines_0")] public static extern 
bool GetLines(IntPtr /*vtkCellArray** */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkCellArray * vtkPolyData::GetPolys()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetPolys_0")] public static extern 
bool GetPolys(IntPtr /*vtkCellArray** */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkCellArray * vtkPolyData::GetStrips()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetStrips_0")] public static extern 
bool GetStrips(IntPtr /*vtkCellArray** */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkIdType vtkPolyData::GetNumberOfVerts()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfVerts_0")] public static extern 
bool GetNumberOfVerts(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkIdType vtkPolyData::GetNumberOfLines()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfLines_0")] public static extern 
bool GetNumberOfLines(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkIdType vtkPolyData::GetNumberOfPolys()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfPolys_0")] public static extern 
bool GetNumberOfPolys(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: vtkIdType vtkPolyData::GetNumberOfStrips()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfStrips_0")] public static extern 
bool GetNumberOfStrips(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::Allocate(vtkIdType numCells, int extSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_Allocate_0")] public static extern 
bool Allocate(IntPtr /*vtkPolyData* */ obj, long numCells, int extSize);

//       Method: void vtkPolyData::Allocate(vtkPolyData* inPolyData, vtkIdType numCells, int extSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_Allocate_1")] public static extern 
bool Allocate(IntPtr /*vtkPolyData* */ obj, IntPtr/*vtkPolyData* */ inPolyData, long numCells, int extSize);

//       Method: vtkIdType vtkPolyData::InsertNextCell(int type, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_InsertNextCell_0")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj, int type, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: vtkIdType vtkPolyData::InsertNextCell(int type, vtkIdList* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_InsertNextCell_1")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj, int type, IntPtr/*vtkIdList* */ pts);

//       Method: void vtkPolyData::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::BuildCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_BuildCells_0")] public static extern 
bool BuildCells(IntPtr /*vtkPolyData* */ obj);

//       Method: bool vtkPolyData::NeedToBuildCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_NeedToBuildCells_0")] public static extern 
bool NeedToBuildCells(IntPtr /*bool* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::BuildLinks(int initialSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_BuildLinks_0")] public static extern 
bool BuildLinks(IntPtr /*vtkPolyData* */ obj, int initialSize);

//       Method: void vtkPolyData::DeleteCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_DeleteCells_0")] public static extern 
bool DeleteCells(IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::DeleteLinks()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_DeleteLinks_0")] public static extern 
bool DeleteLinks(IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetCellEdgeNeighbors_0")] public static extern 
bool GetCellEdgeNeighbors(IntPtr /*vtkPolyData* */ obj, long cellId, long p1, long p2, IntPtr/*vtkIdList* */ cellIds);

//       Method: int vtkPolyData::IsTriangle(int v1, int v2, int v3)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_IsTriangle_0")] public static extern 
bool IsTriangle(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj, int v1, int v2, int v3);

//       Method: int vtkPolyData::IsEdge(vtkIdType p1, vtkIdType p2)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_IsEdge_0")] public static extern 
bool IsEdge(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj, long p1, long p2);

//       Method: int vtkPolyData::IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_IsPointUsedByCell_0")] public static extern 
bool IsPointUsedByCell(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj, long ptId, long cellId);

//       Method: void vtkPolyData::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ReplaceCell_0")] public static extern 
bool ReplaceCell(IntPtr /*vtkPolyData* */ obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: void vtkPolyData::ReplaceCellPoint(vtkIdType cellId, vtkIdType oldPtId, vtkIdType newPtId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ReplaceCellPoint_0")] public static extern 
bool ReplaceCellPoint(IntPtr /*vtkPolyData* */ obj, long cellId, long oldPtId, long newPtId);

//       Method: void vtkPolyData::ReverseCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ReverseCell_0")] public static extern 
bool ReverseCell(IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::DeletePoint(vtkIdType ptId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_DeletePoint_0")] public static extern 
bool DeletePoint(IntPtr /*vtkPolyData* */ obj, long ptId);

//       Method: void vtkPolyData::DeleteCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_DeleteCell_0")] public static extern 
bool DeleteCell(IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::RemoveDeletedCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_RemoveDeletedCells_0")] public static extern 
bool RemoveDeletedCells(IntPtr /*vtkPolyData* */ obj);

//       Method: vtkIdType vtkPolyData::InsertNextLinkedPoint(int numLinks)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_InsertNextLinkedPoint_0")] public static extern 
bool InsertNextLinkedPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj, int numLinks);

//       Method: vtkIdType vtkPolyData::InsertNextLinkedPoint(double x[3], int numLinks)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_InsertNextLinkedPoint_1")] public static extern 
bool InsertNextLinkedPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj, double[] /*3*/ x, int numLinks);

//       Method: vtkIdType vtkPolyData::InsertNextLinkedCell(int type, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_InsertNextLinkedCell_0")] public static extern 
bool InsertNextLinkedCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPolyData* */ obj, int type, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: void vtkPolyData::ReplaceLinkedCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ReplaceLinkedCell_0")] public static extern 
bool ReplaceLinkedCell(IntPtr /*vtkPolyData* */ obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: void vtkPolyData::RemoveCellReference(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_RemoveCellReference_0")] public static extern 
bool RemoveCellReference(IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::AddCellReference(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_AddCellReference_0")] public static extern 
bool AddCellReference(IntPtr /*vtkPolyData* */ obj, long cellId);

//       Method: void vtkPolyData::RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_RemoveReferenceToCell_0")] public static extern 
bool RemoveReferenceToCell(IntPtr /*vtkPolyData* */ obj, long ptId, long cellId);

//       Method: void vtkPolyData::AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_AddReferenceToCell_0")] public static extern 
bool AddReferenceToCell(IntPtr /*vtkPolyData* */ obj, long ptId, long cellId);

//       Method: void vtkPolyData::ResizeCellList(vtkIdType ptId, int size)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ResizeCellList_0")] public static extern 
bool ResizeCellList(IntPtr /*vtkPolyData* */ obj, long ptId, int size);

//       Method: void vtkPolyData::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkPolyData* */ obj);

//       Method: virtual int vtkPolyData::GetPiece()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetPiece_0")] public static extern 
bool GetPiece(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: virtual int vtkPolyData::GetNumberOfPieces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: virtual int vtkPolyData::GetGhostLevel()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetGhostLevel_0")] public static extern 
bool GetGhostLevel(IntPtr /*int* */ ret, IntPtr /*vtkPolyData* */ obj);

//       Method: void vtkPolyData::ShallowCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkPolyData* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkPolyData::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkPolyData* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkPolyData::RemoveGhostCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_RemoveGhostCells_0")] public static extern 
bool RemoveGhostCells(IntPtr /*vtkPolyData* */ obj);

//       Method: static vtkPolyData * vtkPolyData::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyData_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkPolyData** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkPolyData * vtkPolyData::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPolyData_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkPolyData** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

//       Method: virtual vtkMTimeType vtkPolyData::GetMeshMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPolyData_GetMeshMTime_0")] public static extern 
bool GetMeshMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkPolyData* */ obj);

}
};
