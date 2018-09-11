
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationIdTypeKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationIdTypeKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationIdTypeKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationIdTypeKey* NewInstance()
// vtkInformationIdTypeKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject);

// static vtkInformationIdTypeKey* MakeKey(const char * name, const char * location)
// static vtkInformationIdTypeKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_MakeKey_0")] public static extern 
bool MakeKey_0(IntPtr /*(IntPtr**)*/ return_value, string /*(char*)*/ name, string /*(char*)*/ location);

// void Set(vtkInformation * info, vtkIdType ARG_0)
// void Set(vtkInformation* info, vtkIdType)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, long /*(vtkIdType)*/ ARG_0);

// vtkIdType Get(vtkInformation * info)
// vtkIdType Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
