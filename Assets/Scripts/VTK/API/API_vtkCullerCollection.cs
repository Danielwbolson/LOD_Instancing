
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCullerCollection {

// static vtkCullerCollection* New()
// static vtkCullerCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCullerCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkCullerCollection* SafeDownCast(vtkObjectBase * o)
// static vtkCullerCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCullerCollection* NewInstance()
// vtkCullerCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCullerCollection*)*/ callingObject);

// void AddItem(vtkCuller * a)
// void AddItem(vtkCuller *a)
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkCullerCollection*)*/ callingObject, IntPtr /*(vtkCuller*)*/ a);

// vtkCuller* GetNextItem()
// vtkCuller *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCullerCollection*)*/ callingObject);

// vtkCuller* GetLastItem()
// vtkCuller *GetLastItem()
[DllImport("vtkplugin", EntryPoint="vtkCullerCollection_GetLastItem_0")] public static extern 
bool GetLastItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCullerCollection*)*/ callingObject);

}
};
