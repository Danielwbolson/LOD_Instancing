
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationExecutivePortVectorKey {

// static vtkInformationExecutivePortVectorKey* MakeKey(const char * name, const char * location)
// static vtkInformationExecutivePortVectorKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_MakeKey_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_MakeKey_0(IntPtr /*(vtkInformationExecutivePortVectorKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void Append(vtkInformation * info, vtkExecutive * executive, int port)
// void Append(vtkInformation* info, vtkExecutive* executive, int port)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Append_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Append_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkExecutive*)*/ executive, int /*(int)*/ port);

// void Remove(vtkInformation * info, vtkExecutive * executive, int port)
// void Remove(vtkInformation* info, vtkExecutive* executive, int port)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Remove_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Remove_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkExecutive*)*/ executive, int /*(int)*/ port);

// void Set(vtkInformation * info, vtkExecutive ** executives, int * ports, int length)
// void Set(vtkInformation* info, vtkExecutive** executives, int* ports, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Set_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Set_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkExecutive**)*/ executives, IntPtr /*(int*)*/ ports, int /*(int)*/ length);

// vtkExecutive** GetExecutives(vtkInformation * info)
// vtkExecutive** GetExecutives(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_GetExecutives_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_GetExecutives_0(IntPtr /*(vtkExecutive***)*/ return_value, IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int* GetPorts(vtkInformation * info)
// int* GetPorts(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_GetPorts_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_GetPorts_0(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Get(vtkInformation * info, vtkExecutive ** executives, int * ports)
// void Get(vtkInformation* info, vtkExecutive** executives, int* ports)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Get_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Get_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkExecutive**)*/ executives, IntPtr /*(int*)*/ ports);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Length_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// void Remove(vtkInformation * info)
// void Remove(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Remove_1")] public static extern 
bool vtkInformationExecutivePortVectorKey_Remove_1(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Report(vtkInformation * info, vtkGarbageCollector * collector)
// void Report(vtkInformation* info, vtkGarbageCollector* collector)
[DllImport("vtkplugin", EntryPoint="vtkInformationExecutivePortVectorKey_Report_0")] public static extern 
bool vtkInformationExecutivePortVectorKey_Report_0(IntPtr /*(vtkInformationExecutivePortVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkGarbageCollector*)*/ collector);

}
};
