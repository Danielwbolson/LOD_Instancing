
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationIntegerVectorKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationIntegerVectorKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationIntegerVectorKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationIntegerVectorKey* NewInstance()
// vtkInformationIntegerVectorKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject);

// void Append(vtkInformation * info, int value)
// void Append(vtkInformation* info, int value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ value);

// void Set(vtkInformation * info, const int * value, int length)
// void Set(vtkInformation* info, const int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// void Set(vtkInformation * info)
// void Set(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Set_1")] public static extern 
bool Set_1(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int* Get(vtkInformation * info)
// int* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int Get(vtkInformation * info, int idx)
// int Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_1")] public static extern 
bool Get_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void Get(vtkInformation * info, int * value)
// void Get(vtkInformation* info, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_2")] public static extern 
bool Get_2(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Length_0")] public static extern 
bool Length_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
