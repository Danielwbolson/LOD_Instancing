
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataArraySelection {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataArraySelection* SafeDownCast(vtkObjectBase * o)
// static vtkDataArraySelection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataArraySelection* NewInstance()
// vtkDataArraySelection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// static vtkDataArraySelection* New()
// static vtkDataArraySelection* New()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void EnableArray(const char * name)
// void EnableArray(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_EnableArray_0")] public static extern 
bool EnableArray_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// void DisableArray(const char * name)
// void DisableArray(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_DisableArray_0")] public static extern 
bool DisableArray_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// int ArrayIsEnabled(const char * name)
// int ArrayIsEnabled(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_ArrayIsEnabled_0")] public static extern 
bool ArrayIsEnabled_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// int ArrayExists(const char * name)
// int ArrayExists(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_ArrayExists_0")] public static extern 
bool ArrayExists_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// void EnableAllArrays()
// void EnableAllArrays()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_EnableAllArrays_0")] public static extern 
bool EnableAllArrays_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// void DisableAllArrays()
// void DisableAllArrays()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_DisableAllArrays_0")] public static extern 
bool DisableAllArrays_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// int GetNumberOfArrays()
// int GetNumberOfArrays()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetNumberOfArrays_0")] public static extern 
bool GetNumberOfArrays_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// int GetNumberOfArraysEnabled()
// int GetNumberOfArraysEnabled()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetNumberOfArraysEnabled_0")] public static extern 
bool GetNumberOfArraysEnabled_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// char* GetArrayName(int index)
// const char* GetArrayName(int index)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetArrayName_0")] public static extern 
bool GetArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, int /*(int)*/ index);

// int GetArrayIndex(const char * name)
// int GetArrayIndex(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetArrayIndex_0")] public static extern 
bool GetArrayIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// int GetEnabledArrayIndex(const char * name)
// int GetEnabledArrayIndex(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetEnabledArrayIndex_0")] public static extern 
bool GetEnabledArrayIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// int GetArraySetting(const char * name)
// int GetArraySetting(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetArraySetting_0")] public static extern 
bool GetArraySetting_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// int GetArraySetting(int index)
// int GetArraySetting(int index)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_GetArraySetting_1")] public static extern 
bool GetArraySetting_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, int /*(int)*/ index);

// void RemoveAllArrays()
// void RemoveAllArrays()
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_RemoveAllArrays_0")] public static extern 
bool RemoveAllArrays_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject);

// int AddArray(const char * name)
// int AddArray(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_AddArray_0")] public static extern 
bool AddArray_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// void RemoveArrayByIndex(int index)
// void RemoveArrayByIndex(int index)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_RemoveArrayByIndex_0")] public static extern 
bool RemoveArrayByIndex_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, int /*(int)*/ index);

// void RemoveArrayByName(const char * name)
// void RemoveArrayByName(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_RemoveArrayByName_0")] public static extern 
bool RemoveArrayByName_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*)*/ name);

// void SetArrays(const char *const* names, int numArrays)
// void SetArrays(const char* const* names, int numArrays)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_SetArrays_0")] public static extern 
bool SetArrays_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*const*)*/ names, int /*(int)*/ numArrays);

// void SetArraysWithDefault(const char *const* names, int numArrays, int defaultStatus)
// void SetArraysWithDefault(const char* const* names, int numArrays, int defaultStatus)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_SetArraysWithDefault_0")] public static extern 
bool SetArraysWithDefault_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, string /*(char*const*)*/ names, int /*(int)*/ numArrays, int /*(int)*/ defaultStatus);

// void CopySelections(vtkDataArraySelection * selections)
// void CopySelections(vtkDataArraySelection* selections)
[DllImport("vtkplugin", EntryPoint="vtkDataArraySelection_CopySelections_0")] public static extern 
bool CopySelections_0(IntPtr /*(vtkDataArraySelection*)*/ callingObject, IntPtr /*(vtkDataArraySelection*)*/ selections);

}
};
