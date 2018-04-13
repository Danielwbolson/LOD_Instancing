
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkUnstructuredGrid {

//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGrid_New_0")] public static extern 
bool New(IntPtr /*vtkUnstructuredGrid** */ ret);

//       Method: virtual const char * vtkUnstructuredGrid::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: int vtkUnstructuredGrid::GetDataObjectType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetDataObjectType_0")] public static extern 
bool GetDataObjectType(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::Allocate(vtkIdType numCells, int extSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_Allocate_0")] public static extern 
bool Allocate(IntPtr /*vtkUnstructuredGrid* */ obj, long numCells, int extSize);

//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_InsertNextCell_0")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds);

//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_InsertNextCell_1")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, int type, IntPtr/*vtkIdList* */ ptIds);

//       Method: vtkIdType vtkUnstructuredGrid::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds, vtkIdType nfaces, vtkIdType* faces)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_InsertNextCell_2")] public static extern 
bool InsertNextCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds, long nfaces, IntPtr/*vtkIdType* */ faces);

//       Method: void vtkUnstructuredGrid::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::CopyStructure(vtkDataSet* ds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_CopyStructure_0")] public static extern 
bool CopyStructure(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*vtkDataSet* */ ds);

//       Method: vtkIdType vtkUnstructuredGrid::GetNumberOfCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: vtkCell * vtkUnstructuredGrid::GetCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCell_0")] public static extern 
bool GetCell(IntPtr /*vtkCell** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, long cellId);

//       Method: void vtkUnstructuredGrid::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCell_1")] public static extern 
bool GetCell(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, IntPtr/*vtkGenericCell* */ cell);

//       Method: void vtkUnstructuredGrid::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellBounds_0")] public static extern 
bool GetCellBounds(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, double[] /*6*/ bounds);

//       Method: void vtkUnstructuredGrid::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellPoints_0")] public static extern 
bool GetCellPoints(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds);

//       Method: void vtkUnstructuredGrid::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetPointCells_0")] public static extern 
bool GetPointCells(IntPtr /*vtkUnstructuredGrid* */ obj, long ptId, IntPtr/*vtkIdList* */ cellIds);

//       Method: vtkCellIterator * vtkUnstructuredGrid::NewCellIterator()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_NewCellIterator_0")] public static extern 
bool NewCellIterator(IntPtr /*vtkCellIterator** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: int vtkUnstructuredGrid::GetCellType(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, long cellId);

//       Method: vtkUnsignedCharArray * vtkUnstructuredGrid::GetCellTypesArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellTypesArray_0")] public static extern 
bool GetCellTypesArray(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetCellLocationsArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellLocationsArray_0")] public static extern 
bool GetCellLocationsArray(IntPtr /*vtkIdTypeArray** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: int vtkUnstructuredGrid::GetMaxCellSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::BuildLinks()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_BuildLinks_0")] public static extern 
bool BuildLinks(IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: vtkCellLinks * vtkUnstructuredGrid::GetCellLinks()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellLinks_0")] public static extern 
bool GetCellLinks(IntPtr /*vtkCellLinks** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::GetFaceStream(vtkIdType cellId, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetFaceStream_0")] public static extern 
bool GetFaceStream(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds);

//       Method: void vtkUnstructuredGrid::SetCells(int type, vtkCellArray* cells)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_SetCells_0")] public static extern 
bool SetCells(IntPtr /*vtkUnstructuredGrid* */ obj, int type, IntPtr/*vtkCellArray* */ cells);

//       Method: void vtkUnstructuredGrid::SetCells(int* types, vtkCellArray* cells)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_SetCells_1")] public static extern 
bool SetCells(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*int* */ types, IntPtr/*vtkCellArray* */ cells);

//       Method: void vtkUnstructuredGrid::SetCells(vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations, vtkCellArray* cells)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_SetCells_2")] public static extern 
bool SetCells(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIdTypeArray* */ cellLocations, IntPtr/*vtkCellArray* */ cells);

//       Method: void vtkUnstructuredGrid::SetCells(vtkUnsignedCharArray* cellTypes, vtkIdTypeArray* cellLocations, vtkCellArray* cells, vtkIdTypeArray* faceLocations, vtkIdTypeArray* faces)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_SetCells_3")] public static extern 
bool SetCells(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*vtkUnsignedCharArray* */ cellTypes, IntPtr/*vtkIdTypeArray* */ cellLocations, IntPtr/*vtkCellArray* */ cells, IntPtr/*vtkIdTypeArray* */ faceLocations, IntPtr/*vtkIdTypeArray* */ faces);

//       Method: vtkCellArray * vtkUnstructuredGrid::GetCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCells_0")] public static extern 
bool GetCells(IntPtr /*vtkCellArray** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_ReplaceCell_0")] public static extern 
bool ReplaceCell(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: vtkIdType vtkUnstructuredGrid::InsertNextLinkedCell(int type, int npts, vtkIdType* pts)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_InsertNextLinkedCell_0")] public static extern 
bool InsertNextLinkedCell(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, int type, int npts, IntPtr/*vtkIdType* */ pts);

//       Method: void vtkUnstructuredGrid::RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_RemoveReferenceToCell_0")] public static extern 
bool RemoveReferenceToCell(IntPtr /*vtkUnstructuredGrid* */ obj, long ptId, long cellId);

//       Method: void vtkUnstructuredGrid::AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_AddReferenceToCell_0")] public static extern 
bool AddReferenceToCell(IntPtr /*vtkUnstructuredGrid* */ obj, long ptId, long cellId);

//       Method: void vtkUnstructuredGrid::ResizeCellList(vtkIdType ptId, int size)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_ResizeCellList_0")] public static extern 
bool ResizeCellList(IntPtr /*vtkUnstructuredGrid* */ obj, long ptId, int size);

//       Method: void vtkUnstructuredGrid::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetCellNeighbors_0")] public static extern 
bool GetCellNeighbors(IntPtr /*vtkUnstructuredGrid* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkIdList* */ cellIds);

//       Method: virtual int vtkUnstructuredGrid::GetPiece()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetPiece_0")] public static extern 
bool GetPiece(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: virtual int vtkUnstructuredGrid::GetNumberOfPieces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetNumberOfPieces_0")] public static extern 
bool GetNumberOfPieces(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: virtual int vtkUnstructuredGrid::GetGhostLevel()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetGhostLevel_0")] public static extern 
bool GetGhostLevel(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::ShallowCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkUnstructuredGrid::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkUnstructuredGrid* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkUnstructuredGrid::GetIdsOfCellsOfType(int type, vtkIdTypeArray* array)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetIdsOfCellsOfType_0")] public static extern 
bool GetIdsOfCellsOfType(IntPtr /*vtkUnstructuredGrid* */ obj, int type, IntPtr/*vtkIdTypeArray* */ array);

//       Method: int vtkUnstructuredGrid::IsHomogeneous()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_IsHomogeneous_0")] public static extern 
bool IsHomogeneous(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: void vtkUnstructuredGrid::RemoveGhostCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_RemoveGhostCells_0")] public static extern 
bool RemoveGhostCells(IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGrid_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkUnstructuredGrid** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkUnstructuredGrid * vtkUnstructuredGrid::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGrid_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkUnstructuredGrid** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

//       Method: vtkIdType * vtkUnstructuredGrid::GetFaces(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetFaces_0")] public static extern 
bool GetFaces(IntPtr /*vtkIdType** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, long cellId);

//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetFaces()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetFaces_1")] public static extern 
bool GetFaces(IntPtr /*vtkIdTypeArray** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: vtkIdTypeArray * vtkUnstructuredGrid::GetFaceLocations()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetFaceLocations_0")] public static extern 
bool GetFaceLocations(IntPtr /*vtkIdTypeArray** */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: int vtkUnstructuredGrid::InitializeFacesRepresentation(vtkIdType numPrevCells)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_InitializeFacesRepresentation_0")] public static extern 
bool InitializeFacesRepresentation(IntPtr /*int* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj, long numPrevCells);

//       Method: virtual vtkMTimeType vtkUnstructuredGrid::GetMeshMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkUnstructuredGrid_GetMeshMTime_0")] public static extern 
bool GetMeshMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkUnstructuredGrid* */ obj);

//       Method: static void vtkUnstructuredGrid::ConvertFaceStreamPointIds(vtkIdList* faceStream, vtkIdType* idMap)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGrid_ConvertFaceStreamPointIds_0")] public static extern 
bool ConvertFaceStreamPointIds(IntPtr/*vtkIdList* */ faceStream, IntPtr/*vtkIdType* */ idMap);

//       Method: static void vtkUnstructuredGrid::ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType* faceStream, vtkIdType* idMap)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkUnstructuredGrid_ConvertFaceStreamPointIds_1")] public static extern 
bool ConvertFaceStreamPointIds(long nfaces, IntPtr/*vtkIdType* */ faceStream, IntPtr/*vtkIdType* */ idMap);

}
};
