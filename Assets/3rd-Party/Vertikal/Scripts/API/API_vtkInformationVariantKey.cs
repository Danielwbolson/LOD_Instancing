
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationVariantKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationVariantKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationVariantKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationVariantKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationVariantKey* NewInstance()
// vtkInformationVariantKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVariantKey*)*/ callingObject);

// static vtkInformationVariantKey* MakeKey(const char * name, const char * location)
// static vtkInformationVariantKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_MakeKey_0")] public static extern 
bool MakeKey_0(IntPtr /*(IntPtr**)*/ return_value, string /*(char*)*/ name, string /*(char*)*/ location);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationVariantKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
