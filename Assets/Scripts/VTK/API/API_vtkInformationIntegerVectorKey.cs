
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationIntegerVectorKey {

// void Append(vtkInformation * info, int value)
// void Append(vtkInformation* info, int value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Append_0")] public static extern 
bool vtkInformationIntegerVectorKey_Append_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ value);

// void Set(vtkInformation * info, const int * value, int length)
// void Set(vtkInformation* info, const int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Set_0")] public static extern 
bool vtkInformationIntegerVectorKey_Set_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// void Set(vtkInformation * info)
// void Set(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Set_1")] public static extern 
bool vtkInformationIntegerVectorKey_Set_1(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int* Get(vtkInformation * info)
// int* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_0")] public static extern 
bool vtkInformationIntegerVectorKey_Get_0(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int Get(vtkInformation * info, int idx)
// int Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_1")] public static extern 
bool vtkInformationIntegerVectorKey_Get_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void Get(vtkInformation * info, int * value)
// void Get(vtkInformation* info, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Get_2")] public static extern 
bool vtkInformationIntegerVectorKey_Get_2(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_Length_0")] public static extern 
bool vtkInformationIntegerVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationIntegerVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationIntegerVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
