
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationStringVectorKey {

// void Append(vtkInformation * info, const char * value)
// void Append(vtkInformation* info, const char* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Append_0")] public static extern 
bool vtkInformationStringVectorKey_Append_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(char*)*/ value);

// void Set(vtkInformation * info, const char * value, int idx = 0)
// void Set(vtkInformation* info, const char* value, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Set_0")] public static extern 
bool vtkInformationStringVectorKey_Set_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(char*)*/ value, int /*(int)*/ idx);

// char* Get(vtkInformation * info, int idx = 0)
// const char* Get(vtkInformation* info, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Get_0")] public static extern 
bool vtkInformationStringVectorKey_Get_0(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_Length_0")] public static extern 
bool vtkInformationStringVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationStringVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationStringVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationStringVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
