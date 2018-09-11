
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkVersion {

// static vtkVersion* New()
// static vtkVersion *New()
[DllImport("vtkplugin", EntryPoint="vtkVersion_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVersion_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVersion_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVersion*)*/ callingObject, string /*(char*)*/ type);

// static vtkVersion* SafeDownCast(vtkObjectBase * o)
// static vtkVersion* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkVersion_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkVersion* NewInstance()
// vtkVersion *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkVersion_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVersion*)*/ callingObject);

// static char* GetVTKVersion()
// static const char *GetVTKVersion()
[DllImport("vtkplugin", EntryPoint="vtkVersion_GetVTKVersion_0")] public static extern 
bool GetVTKVersion_0(IntPtr /*(IntPtr**)*/ return_value);

// static int GetVTKMajorVersion()
// static int GetVTKMajorVersion()
[DllImport("vtkplugin", EntryPoint="vtkVersion_GetVTKMajorVersion_0")] public static extern 
bool GetVTKMajorVersion_0(IntPtr /*(IntPtr*)*/ return_value);

// static int GetVTKMinorVersion()
// static int GetVTKMinorVersion()
[DllImport("vtkplugin", EntryPoint="vtkVersion_GetVTKMinorVersion_0")] public static extern 
bool GetVTKMinorVersion_0(IntPtr /*(IntPtr*)*/ return_value);

// static int GetVTKBuildVersion()
// static int GetVTKBuildVersion()
[DllImport("vtkplugin", EntryPoint="vtkVersion_GetVTKBuildVersion_0")] public static extern 
bool GetVTKBuildVersion_0(IntPtr /*(IntPtr*)*/ return_value);

// static char* GetVTKSourceVersion()
// static const char *GetVTKSourceVersion()
[DllImport("vtkplugin", EntryPoint="vtkVersion_GetVTKSourceVersion_0")] public static extern 
bool GetVTKSourceVersion_0(IntPtr /*(IntPtr**)*/ return_value);

}
};
