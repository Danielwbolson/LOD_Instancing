
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkVolumeCollection {

// static vtkVolumeCollection* New()
// static vtkVolumeCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkVolumeCollection* SafeDownCast(vtkObjectBase * o)
// static vtkVolumeCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkVolumeCollection* NewInstance()
// vtkVolumeCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeCollection*)*/ callingObject);

// void AddItem(vtkVolume * a)
// void AddItem(vtkVolume *a)
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkVolumeCollection*)*/ callingObject, IntPtr /*(vtkVolume*)*/ a);

// vtkVolume* GetNextVolume()
// vtkVolume *GetNextVolume()
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_GetNextVolume_0")] public static extern 
bool GetNextVolume_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeCollection*)*/ callingObject);

// vtkVolume* GetNextItem()
// vtkVolume *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkVolumeCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeCollection*)*/ callingObject);

}
};
