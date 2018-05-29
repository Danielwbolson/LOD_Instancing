
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationUnsignedLongKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationUnsignedLongKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationUnsignedLongKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationUnsignedLongKey* NewInstance()
// vtkInformationUnsignedLongKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject);

// static vtkInformationUnsignedLongKey* MakeKey(const char * name, const char * location)
// static vtkInformationUnsignedLongKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_MakeKey_0")] public static extern 
bool MakeKey_0(IntPtr /*(IntPtr**)*/ return_value, string /*(char*)*/ name, string /*(char*)*/ location);

// void Set(vtkInformation * info, unsigned long ARG_0)
// void Set(vtkInformation* info, unsigned long)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, ulong /*(unsigned long)*/ ARG_0);

// long Get(vtkInformation * info)
// unsigned long Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
