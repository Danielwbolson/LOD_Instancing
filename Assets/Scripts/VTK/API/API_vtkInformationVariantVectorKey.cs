
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationVariantVectorKey {

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantVectorKey_Length_0")] public static extern 
bool vtkInformationVariantVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationVariantVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationVariantVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationVariantVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationVariantVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
