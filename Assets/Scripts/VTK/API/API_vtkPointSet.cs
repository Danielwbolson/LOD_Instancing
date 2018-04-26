
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPointSet {

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Initialize_0")] public static extern 
bool vtkPointSet_Initialize_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// void CopyStructure(vtkDataSet * pd)
// void CopyStructure(vtkDataSet *pd)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_CopyStructure_0")] public static extern 
bool vtkPointSet_CopyStructure_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ pd);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetNumberOfPoints_0")] public static extern 
bool vtkPointSet_GetNumberOfPoints_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void GetPoint(vtkIdType ptId, double x[3])
// void GetPoint(vtkIdType ptId, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetPoint_0")] public static extern 
bool vtkPointSet_GetPoint_0(IntPtr /*(vtkPointSet*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x);

// vtkIdType FindPoint(double x[3])
// vtkIdType FindPoint(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindPoint_0")] public static extern 
bool vtkPointSet_FindPoint_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType FindPoint(double x, double y, double z)
// vtkIdType FindPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindPoint_1")] public static extern 
bool vtkPointSet_FindPoint_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindCell_0")] public static extern 
bool vtkPointSet_FindCell_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindCell_1")] public static extern 
bool vtkPointSet_FindCell_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, IntPtr /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// double* GetPoint(vtkIdType ptId)
// double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetPoint_1")] public static extern 
bool vtkPointSet_GetPoint_1(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkCellIterator* NewCellIterator()
// vtkCellIterator* NewCellIterator()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_NewCellIterator_0")] public static extern 
bool vtkPointSet_NewCellIterator_0(IntPtr /*(vtkCellIterator**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetMTime_0")] public static extern 
bool vtkPointSet_GetMTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void ComputeBounds()
// void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_ComputeBounds_0")] public static extern 
bool vtkPointSet_ComputeBounds_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Squeeze_0")] public static extern 
bool vtkPointSet_Squeeze_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// virtual void SetPoints(vtkPoints * ARG_0)
// virtual void SetPoints(vtkPoints*)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_SetPoints_0")] public static extern 
bool vtkPointSet_SetPoints_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkPoints*)*/ ARG_0);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetActualMemorySize_0")] public static extern 
bool vtkPointSet_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_ShallowCopy_0")] public static extern 
bool vtkPointSet_ShallowCopy_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_DeepCopy_0")] public static extern 
bool vtkPointSet_DeepCopy_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Register_0")] public static extern 
bool vtkPointSet_Register_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_UnRegister_0")] public static extern 
bool vtkPointSet_UnRegister_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// static vtkPointSet* GetData(vtkInformation * info)
// static vtkPointSet* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetData_0")] public static extern 
bool vtkPointSet_GetData_0(IntPtr /*(vtkPointSet**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkPointSet* GetData(vtkInformationVector * v, int i = 0)
// static vtkPointSet* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetData_1")] public static extern 
bool vtkPointSet_GetData_1(IntPtr /*(vtkPointSet**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

}
};
