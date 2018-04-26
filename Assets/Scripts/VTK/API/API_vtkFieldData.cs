
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkFieldData {

// static vtkFieldData* New()
// static vtkFieldData *New()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_New_0")] public static extern 
bool vtkFieldData_New_0(IntPtr /*(vtkFieldData**)*/ return_value);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_Initialize_0")] public static extern 
bool vtkFieldData_Initialize_0(IntPtr /*(vtkFieldData*)*/ callingObject);

// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// int Allocate(vtkIdType sz, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_Allocate_0")] public static extern 
bool vtkFieldData_Allocate_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext);

// void CopyStructure(vtkFieldData * ARG_0)
// void CopyStructure(vtkFieldData*)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_CopyStructure_0")] public static extern 
bool vtkFieldData_CopyStructure_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ ARG_0);

// void AllocateArrays(int num)
// void AllocateArrays(int num)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_AllocateArrays_0")] public static extern 
bool vtkFieldData_AllocateArrays_0(IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ num);

// int GetNumberOfArrays()
// int GetNumberOfArrays()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetNumberOfArrays_0")] public static extern 
bool vtkFieldData_GetNumberOfArrays_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject);

// int AddArray(vtkAbstractArray * array)
// int AddArray(vtkAbstractArray *array)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_AddArray_0")] public static extern 
bool vtkFieldData_AddArray_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ array);

// virtual void RemoveArray(const char * name)
// virtual void RemoveArray(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_RemoveArray_0")] public static extern 
bool vtkFieldData_RemoveArray_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ name);

// virtual void RemoveArray(int index)
// virtual void RemoveArray(int index)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_RemoveArray_1")] public static extern 
bool vtkFieldData_RemoveArray_1(IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ index);

// vtkDataArray* GetArray(int i)
// vtkDataArray *GetArray(int i)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetArray_0")] public static extern 
bool vtkFieldData_GetArray_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ i);

// vtkDataArray* GetArray(const char * arrayName, int & index)
// vtkDataArray *GetArray(const char *arrayName, int &index)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetArray_1")] public static extern 
bool vtkFieldData_GetArray_1(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ arrayName, IntPtr /*(int&)*/ index);

// vtkDataArray* GetArray(const char * arrayName)
// vtkDataArray *GetArray(const char *arrayName)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetArray_2")] public static extern 
bool vtkFieldData_GetArray_2(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ arrayName);

// vtkAbstractArray* GetAbstractArray(int i)
// vtkAbstractArray* GetAbstractArray(int i)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetAbstractArray_0")] public static extern 
bool vtkFieldData_GetAbstractArray_0(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ i);

// vtkAbstractArray* GetAbstractArray(const char * arrayName, int & index)
// vtkAbstractArray* GetAbstractArray(const char* arrayName, int &index)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetAbstractArray_1")] public static extern 
bool vtkFieldData_GetAbstractArray_1(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ arrayName, IntPtr /*(int&)*/ index);

// vtkAbstractArray* GetAbstractArray(const char * arrayName)
// vtkAbstractArray* GetAbstractArray(const char* arrayName)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetAbstractArray_2")] public static extern 
bool vtkFieldData_GetAbstractArray_2(IntPtr /*(vtkAbstractArray**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ arrayName);

// int HasArray(const char * name)
// int HasArray(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_HasArray_0")] public static extern 
bool vtkFieldData_HasArray_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ name);

// char* GetArrayName(int i)
// const char* GetArrayName(int i)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetArrayName_0")] public static extern 
bool vtkFieldData_GetArrayName_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ i);

// virtual void PassData(vtkFieldData * fd)
// virtual void PassData(vtkFieldData* fd)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_PassData_0")] public static extern 
bool vtkFieldData_PassData_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ fd);

// void CopyFieldOn(const char * name)
// void CopyFieldOn(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_CopyFieldOn_0")] public static extern 
bool vtkFieldData_CopyFieldOn_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ name);

// void CopyFieldOff(const char * name)
// void CopyFieldOff(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_CopyFieldOff_0")] public static extern 
bool vtkFieldData_CopyFieldOff_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(char*)*/ name);

// virtual void CopyAllOn(int unused = 0)
// virtual void CopyAllOn(int unused=0)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_CopyAllOn_0")] public static extern 
bool vtkFieldData_CopyAllOn_0(IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ unused);

// virtual void CopyAllOff(int unused = 0)
// virtual void CopyAllOff(int unused=0)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_CopyAllOff_0")] public static extern 
bool vtkFieldData_CopyAllOff_0(IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ unused);

// virtual void DeepCopy(vtkFieldData * da)
// virtual void DeepCopy(vtkFieldData *da)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_DeepCopy_0")] public static extern 
bool vtkFieldData_DeepCopy_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ da);

// virtual void ShallowCopy(vtkFieldData * da)
// virtual void ShallowCopy(vtkFieldData *da)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_ShallowCopy_0")] public static extern 
bool vtkFieldData_ShallowCopy_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ da);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_Squeeze_0")] public static extern 
bool vtkFieldData_Squeeze_0(IntPtr /*(vtkFieldData*)*/ callingObject);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_Reset_0")] public static extern 
bool vtkFieldData_Reset_0(IntPtr /*(vtkFieldData*)*/ callingObject);

// virtual long GetActualMemorySize()
// virtual unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetActualMemorySize_0")] public static extern 
bool vtkFieldData_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetMTime_0")] public static extern 
bool vtkFieldData_GetMTime_0(IntPtr /*(vtkMTimeType*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject);

// void GetField(vtkIdList * ptId, vtkFieldData * f)
// void GetField(vtkIdList *ptId, vtkFieldData *f)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetField_0")] public static extern 
bool vtkFieldData_GetField_0(IntPtr /*(vtkFieldData*)*/ callingObject, IntPtr /*(vtkIdList*)*/ ptId, IntPtr /*(vtkFieldData*)*/ f);

// int GetArrayContainingComponent(int i, int & arrayComp)
// int GetArrayContainingComponent(int i, int& arrayComp)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetArrayContainingComponent_0")] public static extern 
bool vtkFieldData_GetArrayContainingComponent_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, int /*(int)*/ i, IntPtr /*(int&)*/ arrayComp);

// int GetNumberOfComponents()
// int GetNumberOfComponents()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetNumberOfComponents_0")] public static extern 
bool vtkFieldData_GetNumberOfComponents_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject);

// vtkIdType GetNumberOfTuples()
// vtkIdType GetNumberOfTuples()
[DllImport("vtkplugin", EntryPoint="vtkFieldData_GetNumberOfTuples_0")] public static extern 
bool vtkFieldData_GetNumberOfTuples_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject);

// void SetNumberOfTuples(const vtkIdType number)
// void SetNumberOfTuples(const vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_SetNumberOfTuples_0")] public static extern 
bool vtkFieldData_SetNumberOfTuples_0(IntPtr /*(vtkFieldData*)*/ callingObject, long /*(vtkIdType)*/ number);

// void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_SetTuple_0")] public static extern 
bool vtkFieldData_SetTuple_0(IntPtr /*(vtkFieldData*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, IntPtr /*(vtkFieldData*)*/ source);

// void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_InsertTuple_0")] public static extern 
bool vtkFieldData_InsertTuple_0(IntPtr /*(vtkFieldData*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, IntPtr /*(vtkFieldData*)*/ source);

// vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData * source)
// vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData* source)
[DllImport("vtkplugin", EntryPoint="vtkFieldData_InsertNextTuple_0")] public static extern 
bool vtkFieldData_InsertNextTuple_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkFieldData*)*/ callingObject, long /*(vtkIdType)*/ j, IntPtr /*(vtkFieldData*)*/ source);

}
};
