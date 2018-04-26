
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationKey {

// void Register(vtkObjectBase * ARG_0)
// void Register(vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Register_0")] public static extern 
bool vtkInformationKey_Register_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// void UnRegister(vtkObjectBase * ARG_0)
// void UnRegister(vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_UnRegister_0")] public static extern 
bool vtkInformationKey_UnRegister_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// char* GetName()
// const char* GetName()
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_GetName_0")] public static extern 
bool vtkInformationKey_GetName_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject);

// char* GetLocation()
// const char* GetLocation()
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_GetLocation_0")] public static extern 
bool vtkInformationKey_GetLocation_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject);

// virtual void ShallowCopy(vtkInformation * from, vtkInformation * to)
// virtual void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_ShallowCopy_0")] public static extern 
bool vtkInformationKey_ShallowCopy_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// virtual void DeepCopy(vtkInformation * from, vtkInformation * to)
// virtual void DeepCopy(vtkInformation *from, vtkInformation *to)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_DeepCopy_0")] public static extern 
bool vtkInformationKey_DeepCopy_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// virtual int Has(vtkInformation * info)
// virtual int Has(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Has_0")] public static extern 
bool vtkInformationKey_Has_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// virtual void Remove(vtkInformation * info)
// virtual void Remove(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Remove_0")] public static extern 
bool vtkInformationKey_Remove_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// virtual void Report(vtkInformation * info, vtkGarbageCollector * collector)
// virtual void Report(vtkInformation* info, vtkGarbageCollector* collector)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Report_0")] public static extern 
bool vtkInformationKey_Report_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkGarbageCollector*)*/ collector);

// void Print(vtkInformation * info)
// void Print(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Print_0")] public static extern 
bool vtkInformationKey_Print_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

}
};
