
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProp3DCollection {

// static vtkProp3DCollection* New()
// static vtkProp3DCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3DCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkProp3DCollection* SafeDownCast(vtkObjectBase * o)
// static vtkProp3DCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProp3DCollection* NewInstance()
// vtkProp3DCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3DCollection*)*/ callingObject);

// void AddItem(vtkProp3D * p)
// void AddItem(vtkProp3D *p)
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkProp3DCollection*)*/ callingObject, IntPtr /*(vtkProp3D*)*/ p);

// vtkProp3D* GetNextProp3D()
// vtkProp3D *GetNextProp3D()
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_GetNextProp3D_0")] public static extern 
bool GetNextProp3D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3DCollection*)*/ callingObject);

// vtkProp3D* GetLastProp3D()
// vtkProp3D *GetLastProp3D()
[DllImport("vtkplugin", EntryPoint="vtkProp3DCollection_GetLastProp3D_0")] public static extern 
bool GetLastProp3D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3DCollection*)*/ callingObject);

}
};
