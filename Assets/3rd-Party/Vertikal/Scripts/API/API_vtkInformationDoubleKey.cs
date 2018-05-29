
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationDoubleKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationDoubleKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationDoubleKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationDoubleKey* NewInstance()
// vtkInformationDoubleKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationDoubleKey*)*/ callingObject);

// static vtkInformationDoubleKey* MakeKey(const char * name, const char * location)
// static vtkInformationDoubleKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_MakeKey_0")] public static extern 
bool MakeKey_0(IntPtr /*(IntPtr**)*/ return_value, string /*(char*)*/ name, string /*(char*)*/ location);

// void Set(vtkInformation * info, double ARG_0)
// void Set(vtkInformation* info, double)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, double /*(double)*/ ARG_0);

// double Get(vtkInformation * info)
// double Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
