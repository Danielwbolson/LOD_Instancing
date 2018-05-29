
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationStringVectorKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationStringVectorKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationStringVectorKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationStringVectorKey* NewInstance()
// vtkInformationStringVectorKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject);

// void Append(vtkInformation * info, const char * value)
// void Append(vtkInformation* info, const char* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, string /*(char*)*/ value);

// void Set(vtkInformation * info, const char * value, int idx = 0)
// void Set(vtkInformation* info, const char* value, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, string /*(char*)*/ value, int /*(int)*/ idx);

// char* Get(vtkInformation * info, int idx = 0)
// const char* Get(vtkInformation* info, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Length_0")] public static extern 
bool Length_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
