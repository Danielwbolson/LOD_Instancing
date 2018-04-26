
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationUnsignedLongKey {

// static vtkInformationUnsignedLongKey* MakeKey(const char * name, const char * location)
// static vtkInformationUnsignedLongKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_MakeKey_0")] public static extern 
bool vtkInformationUnsignedLongKey_MakeKey_0(IntPtr /*(vtkInformationUnsignedLongKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void Set(vtkInformation * info, unsigned long ARG_0)
// void Set(vtkInformation* info, unsigned long)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_Set_0")] public static extern 
bool vtkInformationUnsignedLongKey_Set_0(IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, long /*(long)*/ ARG_0);

// long Get(vtkInformation * info)
// unsigned long Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_Get_0")] public static extern 
bool vtkInformationUnsignedLongKey_Get_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationUnsignedLongKey_ShallowCopy_0")] public static extern 
bool vtkInformationUnsignedLongKey_ShallowCopy_0(IntPtr /*(vtkInformationUnsignedLongKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
