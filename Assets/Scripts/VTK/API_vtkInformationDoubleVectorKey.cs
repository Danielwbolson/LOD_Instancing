
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationDoubleVectorKey {

//       Method: virtual const char * vtkInformationDoubleVectorKey::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkInformationDoubleVectorKey* */ obj);

//  Constructor: vtkInformationDoubleVectorKey::vtkInformationDoubleVectorKey(const char* name, const char* location)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_vtkInformationDoubleVectorKey_0")] public static extern 
bool vtkInformationDoubleVectorKey(IntPtr /*vtkInformationDoubleVectorKey* */ obj, string/*const char* */ name, string/*const char* */ location);

//       Method: static vtkInformationDoubleVectorKey * vtkInformationDoubleVectorKey::MakeKey(const char* name, const char* location)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkInformationDoubleVectorKey_MakeKey_0")] public static extern 
bool MakeKey(IntPtr /*vtkInformationDoubleVectorKey** */ ret, string/*const char* */ name, string/*const char* */ location);

//       Method: void vtkInformationDoubleVectorKey::Append(vtkInformation* info, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Append_0")] public static extern 
bool Append(IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info, double value);

//       Method: void vtkInformationDoubleVectorKey::Set(vtkInformation* info, const double* value, int length)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Set_0")] public static extern 
bool Set(IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info, IntPtr/*const double* */ value, int length);

//       Method: double * vtkInformationDoubleVectorKey::Get(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Get_0")] public static extern 
bool Get(IntPtr /*double** */ ret, IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: double vtkInformationDoubleVectorKey::Get(vtkInformation* info, int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Get_1")] public static extern 
bool Get(IntPtr /*double* */ ret, IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info, int idx);

////       Method: void vtkInformationDoubleVectorKey::Get(vtkInformation* info, double* value)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Get_2")] public static extern 
//bool Get(IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info, IntPtr/*double* */ value);
//
//       Method: int vtkInformationDoubleVectorKey::Length(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_Length_0")] public static extern 
bool Length(IntPtr /*int* */ ret, IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: void vtkInformationDoubleVectorKey::ShallowCopy(vtkInformation* from, vtkInformation* to)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationDoubleVectorKey_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkInformationDoubleVectorKey* */ obj, IntPtr/*vtkInformation* */ from, IntPtr/*vtkInformation* */ to);

}
};
