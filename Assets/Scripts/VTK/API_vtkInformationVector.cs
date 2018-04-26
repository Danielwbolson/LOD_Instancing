
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationVector {

//       Method: static vtkInformationVector * vtkInformationVector::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkInformationVector_New_0")] public static extern 
bool New(IntPtr /*vtkInformationVector** */ ret);

//       Method: virtual const char * vtkInformationVector::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkInformationVector* */ obj);

//       Method: int vtkInformationVector::GetNumberOfInformationObjects()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_GetNumberOfInformationObjects_0")] public static extern 
bool GetNumberOfInformationObjects(IntPtr /*int* */ ret, IntPtr /*vtkInformationVector* */ obj);

//       Method: void vtkInformationVector::SetNumberOfInformationObjects(int n)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_SetNumberOfInformationObjects_0")] public static extern 
bool SetNumberOfInformationObjects(IntPtr /*vtkInformationVector* */ obj, int n);

//       Method: void vtkInformationVector::SetInformationObject(int index, vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_SetInformationObject_0")] public static extern 
bool SetInformationObject(IntPtr /*vtkInformationVector* */ obj, int index, IntPtr/*vtkInformation* */ info);

//       Method: vtkInformation * vtkInformationVector::GetInformationObject(int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_GetInformationObject_0")] public static extern 
bool GetInformationObject(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkInformationVector* */ obj, int index);

//       Method: void vtkInformationVector::Append(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_Append_0")] public static extern 
bool Append(IntPtr /*vtkInformationVector* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: void vtkInformationVector::Remove(vtkInformation* info)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_Remove_0")] public static extern 
bool Remove(IntPtr /*vtkInformationVector* */ obj, IntPtr/*vtkInformation* */ info);

//       Method: void vtkInformationVector::Remove(int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_Remove_1")] public static extern 
bool Remove(IntPtr /*vtkInformationVector* */ obj, int idx);

//       Method: void vtkInformationVector::Register(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_Register_0")] public static extern 
bool Register(IntPtr /*vtkInformationVector* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkInformationVector::UnRegister(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkInformationVector* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: void vtkInformationVector::Copy(vtkInformationVector* from, int deep)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkInformationVector_Copy_0")] public static extern 
bool Copy(IntPtr /*vtkInformationVector* */ obj, IntPtr/*vtkInformationVector* */ from, int deep);

}
};
