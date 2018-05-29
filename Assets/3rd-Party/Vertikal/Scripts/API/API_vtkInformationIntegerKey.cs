
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationIntegerKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationIntegerKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationIntegerKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationIntegerKey* NewInstance()
// vtkInformationIntegerKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIntegerKey*)*/ callingObject);

// static vtkInformationIntegerKey* MakeKey(const char * name, const char * location)
// static vtkInformationIntegerKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_MakeKey_0")] public static extern 
bool MakeKey_0(IntPtr /*(IntPtr**)*/ return_value, string /*(char*)*/ name, string /*(char*)*/ location);

// void Set(vtkInformation * info, int ARG_0)
// void Set(vtkInformation* info, int)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ ARG_0);

// int Get(vtkInformation * info)
// int Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
