
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationVariantKey {

// static vtkInformationVariantKey* MakeKey(const char * name, const char * location)
// static vtkInformationVariantKey* MakeKey(const char* name, const char* location)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_MakeKey_0")] public static extern 
bool vtkInformationVariantKey_MakeKey_0(IntPtr /*(vtkInformationVariantKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantKey_ShallowCopy_0")] public static extern 
bool vtkInformationVariantKey_ShallowCopy_0(IntPtr /*(vtkInformationVariantKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
