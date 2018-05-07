
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRendererCollection {

// static vtkRendererCollection* New()
// static vtkRendererCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRendererCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkRendererCollection* SafeDownCast(vtkObjectBase * o)
// static vtkRendererCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRendererCollection* NewInstance()
// vtkRendererCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRendererCollection*)*/ callingObject);

// void AddItem(vtkRenderer * a)
// void AddItem(vtkRenderer *a)
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkRendererCollection*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ a);

// vtkRenderer* GetNextItem()
// vtkRenderer *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRendererCollection*)*/ callingObject);

// void Render()
// void Render()
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkRendererCollection*)*/ callingObject);

// vtkRenderer* GetFirstRenderer()
// vtkRenderer *GetFirstRenderer()
[DllImport("vtkplugin", EntryPoint="vtkRendererCollection_GetFirstRenderer_0")] public static extern 
bool GetFirstRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRendererCollection*)*/ callingObject);

}
};
