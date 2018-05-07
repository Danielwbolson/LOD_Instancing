
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLightCollection {

// static vtkLightCollection* New()
// static vtkLightCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLightCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkLightCollection* SafeDownCast(vtkObjectBase * o)
// static vtkLightCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkLightCollection* NewInstance()
// vtkLightCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLightCollection*)*/ callingObject);

// void AddItem(vtkLight * a)
// void AddItem(vtkLight *a)
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkLightCollection*)*/ callingObject, IntPtr /*(vtkLight*)*/ a);

// vtkLight* GetNextItem()
// vtkLight *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkLightCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLightCollection*)*/ callingObject);

}
};
