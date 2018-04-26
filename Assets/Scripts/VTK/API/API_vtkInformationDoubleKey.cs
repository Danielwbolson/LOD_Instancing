
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationDoubleKey {

// static vtkInformationDoubleKey* MakeKey(const char * name, const char * location)
// static vtkInformationDoubleKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_MakeKey_0")] public static extern 
bool vtkInformationDoubleKey_MakeKey_0(IntPtr /*(vtkInformationDoubleKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void Set(vtkInformation * info, double ARG_0)
// void Set(vtkInformation* info, double)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_Set_0")] public static extern 
bool vtkInformationDoubleKey_Set_0(IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, double /*(double)*/ ARG_0);

// double Get(vtkInformation * info)
// double Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_Get_0")] public static extern 
bool vtkInformationDoubleKey_Get_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleKey_ShallowCopy_0")] public static extern 
bool vtkInformationDoubleKey_ShallowCopy_0(IntPtr /*(vtkInformationDoubleKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
