
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkStructuredGrid {

// static vtkStructuredGrid* New()
// static vtkStructuredGrid *New()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void CopyStructure(vtkDataSet * ds)
// void CopyStructure(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_CopyStructure_0")] public static extern 
bool CopyStructure_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// double* GetPoint(vtkIdType ptId)
// double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetPoint_0")] public static extern 
bool GetPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void GetPoint(vtkIdType ptId, double p[3])
// void GetPoint(vtkIdType ptId, double p[3])
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []p);

// vtkCell* GetCell(vtkIdType cellId)
// vtkCell *GetCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCell_0")] public static extern 
bool GetCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkCell* GetCell(int i, int j, int k)
// vtkCell *GetCell(int i, int j, int k)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCell_1")] public static extern 
bool GetCell_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k);

// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// void GetCell(vtkIdType cellId, vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCell_2")] public static extern 
bool GetCell_2(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkGenericCell*)*/ cell);

// void GetCellBounds(vtkIdType cellId, double bounds[6])
// void GetCellBounds(vtkIdType cellId, double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellBounds_0")] public static extern 
bool GetCellBounds_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds);

// int GetCellType(vtkIdType cellId)
// int GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellPoints_0")] public static extern 
bool GetCellPoints_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetPointCells_0")] public static extern 
bool GetPointCells_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(vtkIdList*)*/ cellIds);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// int GetMaxCellSize()
// int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellNeighbors_0")] public static extern 
bool GetCellNeighbors_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkIdList*)*/ cellIds);

// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds, int * seedLoc)
// void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds, int *seedLoc)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellNeighbors_1")] public static extern 
bool GetCellNeighbors_1(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkIdList*)*/ cellIds, IntPtr /*(int*)*/ seedLoc);

// void SetDimensions(int i, int j, int k)
// void SetDimensions(int i, int j, int k)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_SetDimensions_0")] public static extern 
bool SetDimensions_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k);

// void SetDimensions(int dim[3])
// void SetDimensions(int dim[3])
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_SetDimensions_1")] public static extern 
bool SetDimensions_1(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int[3])*/ []dim);

// virtual int* GetDimensions()
// virtual int *GetDimensions ()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetDimensions_0")] public static extern 
bool GetDimensions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// virtual void GetDimensions(int dim[3])
// virtual void GetDimensions (int dim[3])
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetDimensions_1")] public static extern 
bool GetDimensions_1(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int[3])*/ []dim);

// int GetDataDimension()
// int GetDataDimension()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetDataDimension_0")] public static extern 
bool GetDataDimension_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void SetExtent(int extent[6])
// void SetExtent(int extent[6])
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_SetExtent_0")] public static extern 
bool SetExtent_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int[6])*/ []extent);

// void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_SetExtent_1")] public static extern 
bool SetExtent_1(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// int GetExtentType()
// int GetExtentType()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetExtentType_0")] public static extern 
bool GetExtentType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void BlankPoint(vtkIdType ptId)
// void BlankPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_BlankPoint_0")] public static extern 
bool BlankPoint_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void UnBlankPoint(vtkIdType ptId)
// void UnBlankPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_UnBlankPoint_0")] public static extern 
bool UnBlankPoint_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void BlankCell(vtkIdType ptId)
// void BlankCell(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_BlankCell_0")] public static extern 
bool BlankCell_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void UnBlankCell(vtkIdType ptId)
// void UnBlankCell(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_UnBlankCell_0")] public static extern 
bool UnBlankCell_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// char IsPointVisible(vtkIdType ptId)
// unsigned char IsPointVisible(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_IsPointVisible_0")] public static extern 
bool IsPointVisible_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// char IsCellVisible(vtkIdType cellId)
// unsigned char IsCellVisible(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_IsCellVisible_0")] public static extern 
bool IsCellVisible_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// bool HasAnyBlankPoints()
// bool HasAnyBlankPoints()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_HasAnyBlankPoints_0")] public static extern 
bool HasAnyBlankPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// bool HasAnyBlankCells()
// bool HasAnyBlankCells()
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_HasAnyBlankCells_0")] public static extern 
bool HasAnyBlankCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkStructuredGrid*)*/ callingObject);

// void GetCellDims(int cellDims[3])
// void GetCellDims( int cellDims[3] )
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetCellDims_0")] public static extern 
bool GetCellDims_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int[3])*/ []cellDims);

// void Crop(const int * updateExtent)
// void Crop(const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_Crop_0")] public static extern 
bool Crop_0(IntPtr /*(vtkStructuredGrid*)*/ callingObject, IntPtr /*(int*)*/ updateExtent);

// void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)
// void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)
[DllImport("vtkplugin", EntryPoint="vtkStructuredGrid_GetPoint_2")] public static extern 
bool GetPoint_2(IntPtr /*(vtkStructuredGrid*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, double /*(double[3])*/ []p, bool /*(bool)*/ adjustForExtent);

}
};
