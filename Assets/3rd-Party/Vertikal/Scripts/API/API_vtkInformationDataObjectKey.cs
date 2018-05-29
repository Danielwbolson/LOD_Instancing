
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationDataObjectKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDataObjectKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDataObjectKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDataObjectKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationDataObjectKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationDataObjectKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationDataObjectKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationDataObjectKey* NewInstance()
// vtkInformationDataObjectKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationDataObjectKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationDataObjectKey*)*/ callingObject);

}
};
