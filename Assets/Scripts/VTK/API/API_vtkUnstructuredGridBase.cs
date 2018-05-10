
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnstructuredGridBase {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, string /*(char*)*/ type);

// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase * o)
// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUnstructuredGridBase* NewInstance()
// vtkUnstructuredGridBase *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_0")] public static extern 
bool InsertNextCell_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_1")] public static extern 
bool InsertNextCell_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdList*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_2")] public static extern 
bool InsertNextCell_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces);

// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_ReplaceCell_0")] public static extern 
bool ReplaceCell_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetIdsOfCellsOfType_0")] public static extern 
bool GetIdsOfCellsOfType_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// virtual int IsHomogeneous()
// virtual int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsHomogeneous_0")] public static extern 
bool IsHomogeneous_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// static vtkUnstructuredGridBase* GetData(vtkInformation * info)
// static vtkUnstructuredGridBase* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkUnstructuredGridBase* GetData(vtkInformationVector * v, int i = 0)
// static vtkUnstructuredGridBase* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetData_1")] public static extern 
bool GetData_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetDataObjectType_1")] public static extern 
bool GetDataObjectType_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_Allocate_1")] public static extern 
bool Allocate_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_DeepCopy_1")] public static extern 
bool DeepCopy_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_3")] public static extern 
bool InsertNextCell_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// virtual vtkIdType InsertNextCell(int type, vtkIdList *ptIds)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_4")] public static extern 
bool InsertNextCell_4(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdList*)*/ ptIds);

// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_InsertNextCell_5")] public static extern 
bool InsertNextCell_5(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces);

// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_ReplaceCell_1")] public static extern 
bool ReplaceCell_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts);

// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetIdsOfCellsOfType_1")] public static extern 
bool GetIdsOfCellsOfType_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// virtual int IsHomogeneous()
// virtual int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsHomogeneous_1")] public static extern 
bool IsHomogeneous_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// static vtkUnstructuredGridBase* GetData(vtkInformation * info)
// static vtkUnstructuredGridBase* GetData(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetData_2")] public static extern 
bool GetData_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformation*)*/ info);

// static vtkUnstructuredGridBase* GetData(vtkInformationVector * v, int i = 0)
// static vtkUnstructuredGridBase* GetData(vtkInformationVector* v, int i=0)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetData_3")] public static extern 
bool GetData_3(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ v, int /*(int)*/ i);

}
};
