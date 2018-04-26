
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkGarbageCollector {

// static vtkGarbageCollector* New()
// static vtkGarbageCollector* New()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_New_0")] public static extern 
bool vtkGarbageCollector_New_0(IntPtr /*(vtkGarbageCollector**)*/ return_value);

// static void Collect()
// static void Collect()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_Collect_0")] public static extern 
bool vtkGarbageCollector_Collect_0();

// static void Collect(vtkObjectBase * root)
// static void Collect(vtkObjectBase* root)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_Collect_1")] public static extern 
bool vtkGarbageCollector_Collect_1(IntPtr /*(vtkObjectBase*)*/ root);

// static void DeferredCollectionPush()
// static void DeferredCollectionPush()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_DeferredCollectionPush_0")] public static extern 
bool vtkGarbageCollector_DeferredCollectionPush_0();

// static void DeferredCollectionPop()
// static void DeferredCollectionPop()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_DeferredCollectionPop_0")] public static extern 
bool vtkGarbageCollector_DeferredCollectionPop_0();

// static void SetGlobalDebugFlag(bool flag)
// static void SetGlobalDebugFlag(bool flag)
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_SetGlobalDebugFlag_0")] public static extern 
bool vtkGarbageCollector_SetGlobalDebugFlag_0(bool /*(bool)*/ flag);

// static bool GetGlobalDebugFlag()
// static bool GetGlobalDebugFlag()
[DllImport("vtkplugin", EntryPoint="vtkGarbageCollector_GetGlobalDebugFlag_0")] public static extern 
bool vtkGarbageCollector_GetGlobalDebugFlag_0(IntPtr /*(bool*)*/ return_value);

}
};
