
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkActorCollection {

// static vtkActorCollection* New()
// static vtkActorCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkActorCollection* SafeDownCast(vtkObjectBase * o)
// static vtkActorCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkActorCollection* NewInstance()
// vtkActorCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject);

// void AddItem(vtkActor * a)
// void AddItem(vtkActor *a)
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkActorCollection*)*/ callingObject, IntPtr /*(vtkActor*)*/ a);

// vtkActor* GetNextActor()
// vtkActor *GetNextActor()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_GetNextActor_0")] public static extern 
bool GetNextActor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject);

// vtkActor* GetLastActor()
// vtkActor *GetLastActor()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_GetLastActor_0")] public static extern 
bool GetLastActor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject);

// vtkActor* GetNextItem()
// vtkActor *GetNextItem()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_GetNextItem_0")] public static extern 
bool GetNextItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject);

// vtkActor* GetLastItem()
// vtkActor *GetLastItem()
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_GetLastItem_0")] public static extern 
bool GetLastItem_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActorCollection*)*/ callingObject);

// void ApplyProperties(vtkProperty * p)
// void ApplyProperties(vtkProperty *p)
[DllImport("vtkplugin", EntryPoint="vtkActorCollection_ApplyProperties_0")] public static extern 
bool ApplyProperties_0(IntPtr /*(vtkActorCollection*)*/ callingObject, IntPtr /*(vtkProperty*)*/ p);

}
};
