
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationIntegerPointerKey {

// void Set(vtkInformation * info, int * value, int length)
// void Set(vtkInformation* info, int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Set_0")] public static extern 
bool vtkInformationIntegerPointerKey_Set_0(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// int* Get(vtkInformation * info)
// int* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Get_0")] public static extern 
bool vtkInformationIntegerPointerKey_Get_0(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Get(vtkInformation * info, int * value)
// void Get(vtkInformation* info, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Get_1")] public static extern 
bool vtkInformationIntegerPointerKey_Get_1(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(int*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_Length_0")] public static extern 
bool vtkInformationIntegerPointerKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerPointerKey_ShallowCopy_0")] public static extern 
bool vtkInformationIntegerPointerKey_ShallowCopy_0(IntPtr /*(vtkInformationIntegerPointerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
