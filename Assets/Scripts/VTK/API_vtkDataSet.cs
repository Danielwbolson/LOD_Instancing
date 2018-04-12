
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataSet {

//       Method: virtual const char * vtkDataSet::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual void vtkDataSet::CopyStructure(vtkDataSet* ds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_CopyStructure_0")] public static extern 
bool CopyStructure(IntPtr /*vtkDataSet* */ obj, IntPtr/*vtkDataSet* */ ds);

//       Method: virtual void vtkDataSet::CopyAttributes(vtkDataSet* ds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_CopyAttributes_0")] public static extern 
bool CopyAttributes(IntPtr /*vtkDataSet* */ obj, IntPtr/*vtkDataSet* */ ds);

//       Method: virtual vtkIdType vtkDataSet::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual vtkIdType vtkDataSet::GetNumberOfCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual double * vtkDataSet::GetPoint(vtkIdType ptId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetPoint_0")] public static extern 
bool GetPoint(IntPtr /*double** */ ret, IntPtr /*vtkDataSet* */ obj, long ptId);

//       Method: virtual void vtkDataSet::GetPoint(vtkIdType id, double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetPoint_1")] public static extern 
bool GetPoint(IntPtr /*vtkDataSet* */ obj, long id, double[] /*3*/ x);

//       Method: virtual vtkCellIterator * vtkDataSet::NewCellIterator()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_NewCellIterator_0")] public static extern 
bool NewCellIterator(IntPtr /*vtkCellIterator** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual vtkCell * vtkDataSet::GetCell(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCell_0")] public static extern 
bool GetCell(IntPtr /*vtkCell** */ ret, IntPtr /*vtkDataSet* */ obj, long cellId);

//       Method: virtual void vtkDataSet::GetCell(vtkIdType cellId, vtkGenericCell* cell)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCell_2")] public static extern 
bool GetCell(IntPtr /*vtkDataSet* */ obj, long cellId, IntPtr/*vtkGenericCell* */ cell);

//       Method: virtual void vtkDataSet::GetCellBounds(vtkIdType cellId, double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellBounds_0")] public static extern 
bool GetCellBounds(IntPtr /*vtkDataSet* */ obj, long cellId, double[] /*6*/ bounds);

//       Method: virtual int vtkDataSet::GetCellType(vtkIdType cellId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellType_0")] public static extern 
bool GetCellType(IntPtr /*int* */ ret, IntPtr /*vtkDataSet* */ obj, long cellId);

//       Method: virtual void vtkDataSet::GetCellTypes(vtkCellTypes* types)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellTypes_0")] public static extern 
bool GetCellTypes(IntPtr /*vtkDataSet* */ obj, IntPtr/*vtkCellTypes* */ types);

//       Method: virtual void vtkDataSet::GetCellPoints(vtkIdType cellId, vtkIdList* ptIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellPoints_0")] public static extern 
bool GetCellPoints(IntPtr /*vtkDataSet* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds);

//       Method: virtual void vtkDataSet::GetPointCells(vtkIdType ptId, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetPointCells_0")] public static extern 
bool GetPointCells(IntPtr /*vtkDataSet* */ obj, long ptId, IntPtr/*vtkIdList* */ cellIds);

//       Method: virtual void vtkDataSet::GetCellNeighbors(vtkIdType cellId, vtkIdList* ptIds, vtkIdList* cellIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellNeighbors_0")] public static extern 
bool GetCellNeighbors(IntPtr /*vtkDataSet* */ obj, long cellId, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkIdList* */ cellIds);

//       Method: vtkIdType vtkDataSet::FindPoint(double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_FindPoint_0")] public static extern 
bool FindPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataSet* */ obj, double x, double y, double z);

//       Method: virtual vtkIdType vtkDataSet::FindPoint(double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_FindPoint_1")] public static extern 
bool FindPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataSet* */ obj, double[] /*3*/ x);

//       Method: vtkMTimeType vtkDataSet::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: vtkCellData * vtkDataSet::GetCellData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellData_0")] public static extern 
bool GetCellData(IntPtr /*vtkCellData** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: vtkPointData * vtkDataSet::GetPointData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetPointData_0")] public static extern 
bool GetPointData(IntPtr /*vtkPointData** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual void vtkDataSet::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkDataSet* */ obj);

//       Method: virtual void vtkDataSet::ComputeBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_ComputeBounds_0")] public static extern 
bool ComputeBounds(IntPtr /*vtkDataSet* */ obj);

//       Method: double * vtkDataSet::GetBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetBounds_0")] public static extern 
bool GetBounds(IntPtr /*double** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::GetBounds(double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetBounds_1")] public static extern 
bool GetBounds(IntPtr /*vtkDataSet* */ obj, double[] /*6*/ bounds);

//       Method: double * vtkDataSet::GetCenter()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCenter_0")] public static extern 
bool GetCenter(IntPtr /*double** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::GetCenter(double center[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCenter_1")] public static extern 
bool GetCenter(IntPtr /*vtkDataSet* */ obj, double[] /*3*/ center);

//       Method: double vtkDataSet::GetLength()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetLength_0")] public static extern 
bool GetLength(IntPtr /*double* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkDataSet* */ obj);

//       Method: virtual void vtkDataSet::GetScalarRange(double range[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetScalarRange_0")] public static extern 
bool GetScalarRange(IntPtr /*vtkDataSet* */ obj, double[] /*2*/ range);

//       Method: double * vtkDataSet::GetScalarRange()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetScalarRange_1")] public static extern 
bool GetScalarRange(IntPtr /*double** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual int vtkDataSet::GetMaxCellSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize(IntPtr /*int* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: int vtkDataSet::GetDataObjectType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetDataObjectType_0")] public static extern 
bool GetDataObjectType(IntPtr /*int* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::ShallowCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkDataSet* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: void vtkDataSet::DeepCopy(vtkDataObject* src)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkDataSet* */ obj, IntPtr/*vtkDataObject* */ src);

//       Method: int vtkDataSet::CheckAttributes()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_CheckAttributes_0")] public static extern 
bool CheckAttributes(IntPtr /*int* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual void vtkDataSet::GenerateGhostArray(int zeroExt[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GenerateGhostArray_0")] public static extern 
bool GenerateGhostArray(IntPtr /*vtkDataSet* */ obj, int[] /*6*/ zeroExt);

//       Method: virtual void vtkDataSet::GenerateGhostArray(int zeroExt[6], bool cellOnly)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GenerateGhostArray_1")] public static extern 
bool GenerateGhostArray(IntPtr /*vtkDataSet* */ obj, int[] /*6*/ zeroExt, bool cellOnly);

//       Method: static vtkDataSet * vtkDataSet::GetData(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataSet_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkDataSet** */ ret, IntPtr/*vtkInformation* */ info);

//       Method: static vtkDataSet * vtkDataSet::GetData(vtkInformationVector* v, int i)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataSet_GetData_1")] public static extern 
bool GetData(IntPtr /*vtkDataSet** */ ret, IntPtr/*vtkInformationVector* */ v, int i);

//       Method: vtkFieldData * vtkDataSet::GetAttributesAsFieldData(int type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData(IntPtr /*vtkFieldData** */ ret, IntPtr /*vtkDataSet* */ obj, int type);

//       Method: vtkIdType vtkDataSet::GetNumberOfElements(int type)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataSet* */ obj, int type);

//       Method: bool vtkDataSet::HasAnyGhostCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_HasAnyGhostCells_0")] public static extern 
bool HasAnyGhostCells(IntPtr /*bool* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: bool vtkDataSet::HasAnyGhostPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_HasAnyGhostPoints_0")] public static extern 
bool HasAnyGhostPoints(IntPtr /*bool* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual bool vtkDataSet::HasAnyBlankCells()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_HasAnyBlankCells_0")] public static extern 
bool HasAnyBlankCells(IntPtr /*bool* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: virtual bool vtkDataSet::HasAnyBlankPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_HasAnyBlankPoints_0")] public static extern 
bool HasAnyBlankPoints(IntPtr /*bool* */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: vtkUnsignedCharArray * vtkDataSet::GetPointGhostArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetPointGhostArray_0")] public static extern 
bool GetPointGhostArray(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::UpdatePointGhostArrayCache()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_UpdatePointGhostArrayCache_0")] public static extern 
bool UpdatePointGhostArrayCache(IntPtr /*vtkDataSet* */ obj);

//       Method: vtkUnsignedCharArray * vtkDataSet::AllocatePointGhostArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_AllocatePointGhostArray_0")] public static extern 
bool AllocatePointGhostArray(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: vtkUnsignedCharArray * vtkDataSet::GetCellGhostArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_GetCellGhostArray_0")] public static extern 
bool GetCellGhostArray(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkDataSet* */ obj);

//       Method: void vtkDataSet::UpdateCellGhostArrayCache()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_UpdateCellGhostArrayCache_0")] public static extern 
bool UpdateCellGhostArrayCache(IntPtr /*vtkDataSet* */ obj);

//       Method: vtkUnsignedCharArray * vtkDataSet::AllocateCellGhostArray()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSet_AllocateCellGhostArray_0")] public static extern 
bool AllocateCellGhostArray(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkDataSet* */ obj);

}
};
