
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractPropPicker {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractPropPicker* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractPropPicker* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractPropPicker* NewInstance()
// vtkAbstractPropPicker *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual void SetPath(vtkAssemblyPath * ARG_0)
// virtual void SetPath(vtkAssemblyPath*)
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_SetPath_0")] public static extern 
bool SetPath_0(IntPtr /*(vtkAbstractPropPicker*)*/ callingObject, IntPtr /*(vtkAssemblyPath*)*/ ARG_0);

// virtual vtkAssemblyPath* GetPath()
// virtual vtkAssemblyPath *GetPath ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetPath_0")] public static extern 
bool GetPath_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkProp* GetViewProp()
// virtual vtkProp* GetViewProp()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetViewProp_0")] public static extern 
bool GetViewProp_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkProp3D* GetProp3D()
// virtual vtkProp3D *GetProp3D()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetProp3D_0")] public static extern 
bool GetProp3D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkActor* GetActor()
// virtual vtkActor *GetActor()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetActor_0")] public static extern 
bool GetActor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkActor2D* GetActor2D()
// virtual vtkActor2D *GetActor2D()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetActor2D_0")] public static extern 
bool GetActor2D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkVolume* GetVolume()
// virtual vtkVolume *GetVolume()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetVolume_0")] public static extern 
bool GetVolume_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkAssembly* GetAssembly()
// virtual vtkAssembly *GetAssembly()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetAssembly_0")] public static extern 
bool GetAssembly_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

// virtual vtkPropAssembly* GetPropAssembly()
// virtual vtkPropAssembly *GetPropAssembly()
[DllImport("vtkplugin", EntryPoint="vtkAbstractPropPicker_GetPropAssembly_0")] public static extern 
bool GetPropAssembly_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractPropPicker*)*/ callingObject);

}
};
