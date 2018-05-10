
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationObjectBaseKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationObjectBaseKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationObjectBaseKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationObjectBaseKey* NewInstance()
// vtkInformationObjectBaseKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject);

// void Set(vtkInformation * info, vtkObjectBase * ARG_0)
// void Set(vtkInformation* info, vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// vtkObjectBase* Get(vtkInformation * info)
// vtkObjectBase* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// void Report(vtkInformation * info, vtkGarbageCollector * collector)
// void Report(vtkInformation* info, vtkGarbageCollector* collector)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Report_0")] public static extern 
bool Report_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkGarbageCollector*)*/ collector);

}
};
