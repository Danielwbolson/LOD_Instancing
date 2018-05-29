
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkShaderDeviceAdapter2 {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkShaderDeviceAdapter2*)*/ callingObject, string /*(char*)*/ type);

// static vtkShaderDeviceAdapter2* SafeDownCast(vtkObjectBase * o)
// static vtkShaderDeviceAdapter2* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkShaderDeviceAdapter2* NewInstance()
// vtkShaderDeviceAdapter2 *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkShaderDeviceAdapter2*)*/ callingObject);

// virtual void SendAttribute(const char * attrname, int components, int type, const void * attribute, unsigned long offset = 0)
// virtual void SendAttribute(const char* attrname, int components, int type, const void* attribute, unsigned long offset = 0)
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_SendAttribute_0")] public static extern 
bool SendAttribute_0(IntPtr /*(vtkShaderDeviceAdapter2*)*/ callingObject, string /*(char*)*/ attrname, int /*(int)*/ components, int /*(int)*/ type, IntPtr /*(void*)*/ attribute, ulong /*(unsigned long)*/ offset);

// virtual void PrepareForRender()
// virtual void PrepareForRender()
[DllImport("vtkplugin", EntryPoint="vtkShaderDeviceAdapter2_PrepareForRender_0")] public static extern 
bool PrepareForRender_0(IntPtr /*(vtkShaderDeviceAdapter2*)*/ callingObject);

}
};
