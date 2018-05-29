
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkActor2DCollection {

// static vtkActor2DCollection* New()
// static vtkActor2DCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkActor2DCollection* SafeDownCast(vtkObjectBase * o)
// static vtkActor2DCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkActor2DCollection* NewInstance()
// vtkActor2DCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// void Sort()
// void Sort()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_Sort_0")] public static extern 
bool Sort_0(IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// void AddItem(vtkActor2D * a)
// void AddItem(vtkActor2D *a)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkActor2DCollection*)*/ callingObject, IntPtr /*(vtkActor2D*)*/ a);

// int IsItemPresent(vtkActor2D * a)
// int IsItemPresent(vtkActor2D *a)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_IsItemPresent_0")] public static extern 
bool IsItemPresent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject, IntPtr /*(vtkActor2D*)*/ a);

// vtkActor2D* GetNextActor2D()
// vtkActor2D *GetNextActor2D()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_GetNextActor2D_0")] public static extern 
bool GetNextActor2D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// vtkActor2D* GetLastActor2D()
// vtkActor2D *GetLastActor2D()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_GetLastActor2D_0")] public static extern 
bool GetLastActor2D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// vtkActor2D* GetNextItem()
// vtkActor2D *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// vtkActor2D* GetLastItem()
// vtkActor2D *GetLastItem()
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_GetLastItem_0")] public static extern 
bool GetLastItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2DCollection*)*/ callingObject);

// void RenderOverlay(vtkViewport * viewport)
// void RenderOverlay(vtkViewport* viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor2DCollection_RenderOverlay_0")] public static extern 
bool RenderOverlay_0(IntPtr /*(vtkActor2DCollection*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

}
};
