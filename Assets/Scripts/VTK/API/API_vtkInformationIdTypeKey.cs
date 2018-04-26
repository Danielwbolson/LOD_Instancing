
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationIdTypeKey {

// static vtkInformationIdTypeKey* MakeKey(const char * name, const char * location)
// static vtkInformationIdTypeKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_MakeKey_0")] public static extern 
bool vtkInformationIdTypeKey_MakeKey_0(IntPtr /*(vtkInformationIdTypeKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void Set(vtkInformation * info, vtkIdType ARG_0)
// void Set(vtkInformation* info, vtkIdType)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_Set_0")] public static extern 
bool vtkInformationIdTypeKey_Set_0(IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, long /*(vtkIdType)*/ ARG_0);

// vtkIdType Get(vtkInformation * info)
// vtkIdType Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_Get_0")] public static extern 
bool vtkInformationIdTypeKey_Get_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationIdTypeKey_ShallowCopy_0")] public static extern 
bool vtkInformationIdTypeKey_ShallowCopy_0(IntPtr /*(vtkInformationIdTypeKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
