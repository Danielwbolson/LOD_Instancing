
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationDoubleVectorKey {

// void Append(vtkInformation * info, double value)
// void Append(vtkInformation* info, double value)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Append_0")] public static extern 
bool vtkInformationDoubleVectorKey_Append_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, double /*(double)*/ value);

// void Set(vtkInformation * info, const double * value, int length)
// void Set(vtkInformation* info, const double* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Set_0")] public static extern 
bool vtkInformationDoubleVectorKey_Set_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value, int /*(int)*/ length);

// double* Get(vtkInformation * info)
// double* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_0")] public static extern 
bool vtkInformationDoubleVectorKey_Get_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// double Get(vtkInformation * info, int idx)
// double Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_1")] public static extern 
bool vtkInformationDoubleVectorKey_Get_1(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void Get(vtkInformation * info, double * value)
// void Get(vtkInformation* info, double* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_2")] public static extern 
bool vtkInformationDoubleVectorKey_Get_2(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Length_0")] public static extern 
bool vtkInformationDoubleVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationDoubleVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
