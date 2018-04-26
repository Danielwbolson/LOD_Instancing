
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationIntegerKey {

// static vtkInformationIntegerKey* MakeKey(const char * name, const char * location)
// static vtkInformationIntegerKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_MakeKey_0")] public static extern 
bool vtkInformationIntegerKey_MakeKey_0(IntPtr /*(vtkInformationIntegerKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void Set(vtkInformation * info, int ARG_0)
// void Set(vtkInformation* info, int)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_Set_0")] public static extern 
bool vtkInformationIntegerKey_Set_0(IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ ARG_0);

// int Get(vtkInformation * info)
// int Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_Get_0")] public static extern 
bool vtkInformationIntegerKey_Get_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIntegerKey_ShallowCopy_0")] public static extern 
bool vtkInformationIntegerKey_ShallowCopy_0(IntPtr /*(vtkInformationIntegerKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
