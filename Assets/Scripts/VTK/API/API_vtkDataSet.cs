
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataSet {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataSet* SafeDownCast(vtkObjectBase * o)
// static vtkDataSet* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataSet* NewInstance()
// vtkDataSet *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual void CopyStructure(vtkDataSet * ds)
// virtual void CopyStructure(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_CopyStructure_0")] public static extern 
bool CopyStructure_0(IntPtr /*(vtkDataSet*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// virtual void CopyAttributes(vtkDataSet * ds)
// virtual void CopyAttributes(vtkDataSet *ds)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_CopyAttributes_0")] public static extern 
bool CopyAttributes_0(IntPtr /*(vtkDataSet*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds);

// virtual vtkIdType GetNumberOfPoints()
// virtual vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual vtkIdType GetNumberOfCells()
// virtual vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual double* GetPoint(vtkIdType ptId)
// virtual double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetPoint_0")] public static extern 
bool GetPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// virtual void GetPoint(vtkIdType id, double x[3])
// virtual void GetPoint(vtkIdType id, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[3])*/ []x);

// virtual vtkCellIterator* NewCellIterator()
// virtual vtkCellIterator* NewCellIterator()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_NewCellIterator_0")] public static extern 
bool NewCellIterator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual vtkCell* GetCell(vtkIdType cellId)
// virtual vtkCell *GetCell(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCell_0")] public static extern 
bool GetCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// virtual vtkCell* GetCell(int ARG_0, int ARG_1, int ARG_2)
// virtual vtkCell *GetCell(int , int , int )
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCell_1")] public static extern 
bool GetCell_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2);

// virtual void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// virtual void GetCell(vtkIdType cellId, vtkGenericCell *cell)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCell_2")] public static extern 
bool GetCell_2(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkGenericCell*)*/ cell);

// virtual void GetCellBounds(vtkIdType cellId, double bounds[6])
// virtual void GetCellBounds(vtkIdType cellId, double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellBounds_0")] public static extern 
bool GetCellBounds_0(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds);

// virtual int GetCellType(vtkIdType cellId)
// virtual int GetCellType(vtkIdType cellId)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellType_0")] public static extern 
bool GetCellType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId);

// virtual void GetCellTypes(vtkCellTypes * types)
// virtual void GetCellTypes(vtkCellTypes *types)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellTypes_0")] public static extern 
bool GetCellTypes_0(IntPtr /*(vtkDataSet*)*/ callingObject, IntPtr /*(vtkCellTypes*)*/ types);

// virtual void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// virtual void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellPoints_0")] public static extern 
bool GetCellPoints_0(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds);

// virtual void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// virtual void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetPointCells_0")] public static extern 
bool GetPointCells_0(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ ptId, IntPtr /*(vtkIdList*)*/ cellIds);

// virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellNeighbors_0")] public static extern 
bool GetCellNeighbors_0(IntPtr /*(vtkDataSet*)*/ callingObject, long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkIdList*)*/ cellIds);

// vtkIdType FindPoint(double x, double y, double z)
// vtkIdType FindPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_FindPoint_0")] public static extern 
bool FindPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual vtkIdType FindPoint(double x[3])
// virtual vtkIdType FindPoint(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_FindPoint_1")] public static extern 
bool FindPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[3])*/ []x);

// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_FindCell_0")] public static extern 
bool FindCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_FindCell_1")] public static extern 
bool FindCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, IntPtr /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// virtual vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// virtual vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_FindAndGetCell_0")] public static extern 
bool FindAndGetCell_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkCellData* GetCellData()
// vtkCellData *GetCellData()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellData_0")] public static extern 
bool GetCellData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkPointData* GetPointData()
// vtkPointData *GetPointData()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetPointData_0")] public static extern 
bool GetPointData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual void Squeeze()
// virtual void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual void ComputeBounds()
// virtual void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_ComputeBounds_0")] public static extern 
bool ComputeBounds_0(IntPtr /*(vtkDataSet*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* GetCenter()
// double *GetCenter()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCenter_0")] public static extern 
bool GetCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void GetCenter(double center[3])
// void GetCenter(double center[3])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCenter_1")] public static extern 
bool GetCenter_1(IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[3])*/ []center);

// double GetLength()
// double GetLength()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetLength_0")] public static extern 
bool GetLength_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual void GetScalarRange(double range[2])
// virtual void GetScalarRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetScalarRange_0")] public static extern 
bool GetScalarRange_0(IntPtr /*(vtkDataSet*)*/ callingObject, double /*(double[2])*/ []range);

// double* GetScalarRange()
// double *GetScalarRange()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetScalarRange_1")] public static extern 
bool GetScalarRange_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual int GetMaxCellSize()
// virtual int GetMaxCellSize()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetMaxCellSize_0")] public static extern 
bool GetMaxCellSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkDataSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkDataSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// int CheckAttributes()
// int CheckAttributes()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_CheckAttributes_0")] public static extern 
bool CheckAttributes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual void GenerateGhostArray(int zeroExt[6])
// virtual void GenerateGhostArray(int zeroExt[6])
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GenerateGhostArray_0")] public static extern 
bool GenerateGhostArray_0(IntPtr /*(vtkDataSet*)*/ callingObject, int /*(int[6])*/ []zeroExt);

// virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)
// virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GenerateGhostArray_1")] public static extern 
bool GenerateGhostArray_1(IntPtr /*(vtkDataSet*)*/ callingObject, int /*(int[6])*/ []zeroExt, bool /*(bool)*/ cellOnly);

// static vtkDataSet* GetData(vtkInformation * info)
// static vtkDataSet* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkDataSet* GetData(vtkInformationVector * v, int i = 0)
// static vtkDataSet* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetData_1")] public static extern 
bool GetData_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

// vtkFieldData* GetAttributesAsFieldData(int type)
// vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, int /*(int)*/ type);

// vtkIdType GetNumberOfElements(int type)
// vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject, int /*(int)*/ type);

// bool HasAnyGhostCells()
// bool HasAnyGhostCells()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_HasAnyGhostCells_0")] public static extern 
bool HasAnyGhostCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// bool HasAnyGhostPoints()
// bool HasAnyGhostPoints()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_HasAnyGhostPoints_0")] public static extern 
bool HasAnyGhostPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual bool HasAnyBlankCells()
// virtual bool HasAnyBlankCells()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_HasAnyBlankCells_0")] public static extern 
bool HasAnyBlankCells_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// virtual bool HasAnyBlankPoints()
// virtual bool HasAnyBlankPoints()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_HasAnyBlankPoints_0")] public static extern 
bool HasAnyBlankPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkUnsignedCharArray* GetPointGhostArray()
// vtkUnsignedCharArray* GetPointGhostArray()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetPointGhostArray_0")] public static extern 
bool GetPointGhostArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void UpdatePointGhostArrayCache()
// void UpdatePointGhostArrayCache()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_UpdatePointGhostArrayCache_0")] public static extern 
bool UpdatePointGhostArrayCache_0(IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkUnsignedCharArray* AllocatePointGhostArray()
// vtkUnsignedCharArray* AllocatePointGhostArray()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_AllocatePointGhostArray_0")] public static extern 
bool AllocatePointGhostArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkUnsignedCharArray* GetCellGhostArray()
// vtkUnsignedCharArray* GetCellGhostArray()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_GetCellGhostArray_0")] public static extern 
bool GetCellGhostArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

// void UpdateCellGhostArrayCache()
// void UpdateCellGhostArrayCache()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_UpdateCellGhostArrayCache_0")] public static extern 
bool UpdateCellGhostArrayCache_0(IntPtr /*(vtkDataSet*)*/ callingObject);

// vtkUnsignedCharArray* AllocateCellGhostArray()
// vtkUnsignedCharArray* AllocateCellGhostArray()
[DllImport("vtkplugin", EntryPoint="vtkDataSet_AllocateCellGhostArray_0")] public static extern 
bool AllocateCellGhostArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ callingObject);

}
};
