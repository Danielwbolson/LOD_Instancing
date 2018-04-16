
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkObjectBase {

//       Method: const char * vtkObjectBase::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkObjectBase* */ obj);

//       Method: const char * vtkObjectBase::GetClassNameA()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_GetClassNameA_0")] public static extern 
bool GetClassNameA(IntPtr /*const char** */ ret, IntPtr /*vtkObjectBase* */ obj);

//       Method: const char * vtkObjectBase::GetClassNameW()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_GetClassNameW_0")] public static extern 
bool GetClassNameW(IntPtr /*const char** */ ret, IntPtr /*vtkObjectBase* */ obj);

//       Method: static vtkTypeBool vtkObjectBase::IsTypeOf(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObjectBase_IsTypeOf_0")] public static extern 
bool IsTypeOf(IntPtr /*vtkTypeBool* */ ret, string/*const char* */ name);

//       Method: virtual vtkTypeBool vtkObjectBase::IsA(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_IsA_0")] public static extern 
bool IsA(IntPtr /*vtkTypeBool* */ ret, IntPtr /*vtkObjectBase* */ obj, string/*const char* */ name);

//       Method: virtual void vtkObjectBase::Delete()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_Delete_0")] public static extern 
bool Delete(IntPtr /*vtkObjectBase* */ obj);

//       Method: virtual void vtkObjectBase::FastDelete()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_FastDelete_0")] public static extern 
bool FastDelete(IntPtr /*vtkObjectBase* */ obj);

//       Method: static vtkObjectBase * vtkObjectBase::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObjectBase_New_0")] public static extern 
bool New(IntPtr /*vtkObjectBase** */ ret);

//       Method: void vtkObjectBase::InitializeObjectBase()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_InitializeObjectBase_0")] public static extern 
bool InitializeObjectBase(IntPtr /*vtkObjectBase* */ obj);

//       Method: virtual void vtkObjectBase::Register(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_Register_0")] public static extern 
bool Register(IntPtr /*vtkObjectBase* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: virtual void vtkObjectBase::UnRegister(vtkObjectBase* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkObjectBase* */ obj, IntPtr/*vtkObjectBase* */ o);

//       Method: int vtkObjectBase::GetReferenceCount()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_GetReferenceCount_0")] public static extern 
bool GetReferenceCount(IntPtr /*int* */ ret, IntPtr /*vtkObjectBase* */ obj);

//       Method: void vtkObjectBase::SetReferenceCount(int ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObjectBase_SetReferenceCount_0")] public static extern 
bool SetReferenceCount(IntPtr /*vtkObjectBase* */ obj, int ARG_0);

}
};
