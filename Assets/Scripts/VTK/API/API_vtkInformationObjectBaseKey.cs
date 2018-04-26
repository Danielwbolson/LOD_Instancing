
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationObjectBaseKey {

// static vtkInformationObjectBaseKey* MakeKey(const char * name, const char * location, const char * requiredClass = nullptr)
// static vtkInformationObjectBaseKey* MakeKey(const char* name, const char* location, const char* requiredClass=nullptr)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_MakeKey_0")] public static extern 
bool vtkInformationObjectBaseKey_MakeKey_0(IntPtr /*(vtkInformationObjectBaseKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location, IntPtr /*(char*)*/ requiredClass);

// void Set(vtkInformation * info, vtkObjectBase * ARG_0)
// void Set(vtkInformation* info, vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Set_0")] public static extern 
bool vtkInformationObjectBaseKey_Set_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// vtkObjectBase* Get(vtkInformation * info)
// vtkObjectBase* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Get_0")] public static extern 
bool vtkInformationObjectBaseKey_Get_0(IntPtr /*(vtkObjectBase**)*/ return_value, IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_ShallowCopy_0")] public static extern 
bool vtkInformationObjectBaseKey_ShallowCopy_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// void Report(vtkInformation * info, vtkGarbageCollector * collector)
// void Report(vtkInformation* info, vtkGarbageCollector* collector)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseKey_Report_0")] public static extern 
bool vtkInformationObjectBaseKey_Report_0(IntPtr /*(vtkInformationObjectBaseKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkGarbageCollector*)*/ collector);

}
};
