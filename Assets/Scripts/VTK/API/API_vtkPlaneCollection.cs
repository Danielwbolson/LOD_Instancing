
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPlaneCollection {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlaneCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkPlaneCollection* SafeDownCast(vtkObjectBase * o)
// static vtkPlaneCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPlaneCollection* NewInstance()
// vtkPlaneCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlaneCollection*)*/ callingObject);

// static vtkPlaneCollection* New()
// static vtkPlaneCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void AddItem(vtkPlane * ARG_0)
// void AddItem(vtkPlane *)
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkPlaneCollection*)*/ callingObject, IntPtr /*(vtkPlane*)*/ ARG_0);

// vtkPlane* GetNextItem()
// vtkPlane *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlaneCollection*)*/ callingObject);

// vtkPlane* GetItem(int i)
// vtkPlane *GetItem(int i)
[DllImport("vtkplugin", EntryPoint="vtkPlaneCollection_GetItem_0")] public static extern 
bool GetItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlaneCollection*)*/ callingObject, int /*(int)*/ i);

}
};
