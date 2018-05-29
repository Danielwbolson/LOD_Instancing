
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAssemblyPaths {

// static vtkAssemblyPaths* New()
// static vtkAssemblyPaths *New()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyPaths*)*/ callingObject, string /*(char*)*/ type);

// static vtkAssemblyPaths* SafeDownCast(vtkObjectBase * o)
// static vtkAssemblyPaths* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAssemblyPaths* NewInstance()
// vtkAssemblyPaths *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPaths*)*/ callingObject);

// void AddItem(vtkAssemblyPath * p)
// void AddItem(vtkAssemblyPath *p)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkAssemblyPaths*)*/ callingObject, IntPtr /*(vtkAssemblyPath*)*/ p);

// void RemoveItem(vtkAssemblyPath * p)
// void RemoveItem(vtkAssemblyPath *p)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_RemoveItem_0")] public static extern 
bool RemoveItem_0(IntPtr /*(vtkAssemblyPaths*)*/ callingObject, IntPtr /*(vtkAssemblyPath*)*/ p);

// int IsItemPresent(vtkAssemblyPath * p)
// int IsItemPresent(vtkAssemblyPath *p)
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_IsItemPresent_0")] public static extern 
bool IsItemPresent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyPaths*)*/ callingObject, IntPtr /*(vtkAssemblyPath*)*/ p);

// vtkAssemblyPath* GetNextItem()
// vtkAssemblyPath *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssemblyPaths*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAssemblyPaths_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssemblyPaths*)*/ callingObject);

}
};
