
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPointSet {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, string /*(char*)*/ type);

// static vtkPointSet* SafeDownCast(vtkObjectBase * o)
// static vtkPointSet* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPointSet* NewInstance()
// vtkPointSet *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// void CopyStructure(vtkDataSet * pd)
// void CopyStructure(vtkDataSet *pd)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_CopyStructure_0")] public static extern 
bool CopyStructure_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ pd);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void GetPoint(vtkIdType ptId, double x[3])
// void GetPoint(vtkIdType ptId, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetPoint_0")] public static extern 
bool GetPoint_0(IntPtr /*(vtkPointSet*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x);

// vtkIdType FindPoint(double x[3])
// vtkIdType FindPoint(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindPoint_0")] public static extern 
bool FindPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType FindPoint(double x, double y, double z)
// vtkIdType FindPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindPoint_1")] public static extern 
bool FindPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindCell_0")] public static extern 
bool FindCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_FindCell_1")] public static extern 
bool FindCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, double /*(double[3])*/ []x, IntPtr /*(vtkCell*)*/ cell, IntPtr /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights);

// double* GetPoint(vtkIdType ptId)
// double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// vtkCellIterator* NewCellIterator()
// vtkCellIterator* NewCellIterator()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_NewCellIterator_0")] public static extern 
bool NewCellIterator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void ComputeBounds()
// void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_ComputeBounds_0")] public static extern 
bool ComputeBounds_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkPointSet*)*/ callingObject);

// virtual void SetPoints(vtkPoints * ARG_0)
// virtual void SetPoints(vtkPoints*)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_SetPoints_0")] public static extern 
bool SetPoints_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkPoints*)*/ ARG_0);

// virtual vtkPoints* GetPoints()
// virtual vtkPoints *GetPoints ()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkPointSet_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkPointSet*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkPointSet_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkPointSet*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

}
};
