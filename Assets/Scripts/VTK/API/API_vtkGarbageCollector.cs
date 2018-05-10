
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGarbageCollector {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkGarbageCollector*)*/ callingObject, string /*(char*)*/ type);

// static vtkGarbageCollector* SafeDownCast(vtkObjectBase * o)
// static vtkGarbageCollector* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGarbageCollector* NewInstance()
// vtkGarbageCollector *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkGarbageCollector*)*/ callingObject);

// static vtkGarbageCollector* New()
// static vtkGarbageCollector* New()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static void Collect()
// static void Collect()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_Collect_0")] public static extern 
bool Collect_0();

// static void Collect(vtkObjectBase * root)
// static void Collect(vtkObjectBase* root)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_Collect_1")] public static extern 
bool Collect_1(IntPtr /*(vtkObjectBase*)*/ root);

// static void DeferredCollectionPush()
// static void DeferredCollectionPush()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_DeferredCollectionPush_0")] public static extern 
bool DeferredCollectionPush_0();

// static void DeferredCollectionPop()
// static void DeferredCollectionPop()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_DeferredCollectionPop_0")] public static extern 
bool DeferredCollectionPop_0();

// static void SetGlobalDebugFlag(bool flag)
// static void SetGlobalDebugFlag(bool flag)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_SetGlobalDebugFlag_0")] public static extern 
bool SetGlobalDebugFlag_0(bool /*(bool)*/ flag);

// static bool GetGlobalDebugFlag()
// static bool GetGlobalDebugFlag()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_GetGlobalDebugFlag_0")] public static extern 
bool GetGlobalDebugFlag_0(IntPtr /*(IntPtr*)*/ return_value);

}
};
