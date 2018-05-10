
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationIntegerPointerKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationIntegerPointerKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationIntegerPointerKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationIntegerPointerKey* NewInstance()
// vtkInformationIntegerPointerKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject);

// void Set(vtkInformation * info, int * value, int length)
// void Set(vtkInformation* info, int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// int* Get(vtkInformation * info)
// int* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Get(vtkInformation * info, int * value)
// void Get(vtkInformation* info, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Get_1")] public static extern 
bool Get_1(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Length_0")] public static extern 
bool Length_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
