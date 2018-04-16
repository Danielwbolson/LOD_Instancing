
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkObject {

//       Method: static vtkObject * vtkObject::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_New_0")] public static extern 
bool New(IntPtr /*vtkObject** */ ret);

//       Method: virtual void vtkObject::DebugOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_DebugOn_0")] public static extern 
bool DebugOn(IntPtr /*vtkObject* */ obj);

//       Method: virtual void vtkObject::DebugOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_DebugOff_0")] public static extern 
bool DebugOff(IntPtr /*vtkObject* */ obj);

//       Method: bool vtkObject::GetDebug()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_GetDebug_0")] public static extern 
bool GetDebug(IntPtr /*bool* */ ret, IntPtr /*vtkObject* */ obj);

//       Method: void vtkObject::SetDebug(bool debugFlag)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_SetDebug_0")] public static extern 
bool SetDebug(IntPtr /*vtkObject* */ obj, bool debugFlag);

//       Method: static void vtkObject::BreakOnError()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_BreakOnError_0")] public static extern 
bool BreakOnError();

//       Method: virtual void vtkObject::Modified()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_Modified_0")] public static extern 
bool Modified(IntPtr /*vtkObject* */ obj);

//       Method: virtual vtkMTimeType vtkObject::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkObject* */ obj);

//       Method: static void vtkObject::SetGlobalWarningDisplay(int val)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_SetGlobalWarningDisplay_0")] public static extern 
bool SetGlobalWarningDisplay(int val);

//       Method: static void vtkObject::GlobalWarningDisplayOn()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_GlobalWarningDisplayOn_0")] public static extern 
bool GlobalWarningDisplayOn();

//       Method: static void vtkObject::GlobalWarningDisplayOff()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_GlobalWarningDisplayOff_0")] public static extern 
bool GlobalWarningDisplayOff();

//       Method: static int vtkObject::GetGlobalWarningDisplay()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkObject_GetGlobalWarningDisplay_0")] public static extern 
bool GetGlobalWarningDisplay(IntPtr /*int* */ ret);

//       Method: vtkCommand * vtkObject::GetCommand(unsigned long tag)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_GetCommand_0")] public static extern 
bool GetCommand(IntPtr /*vtkCommand** */ ret, IntPtr /*vtkObject* */ obj, ulong tag);

//       Method: void vtkObject::RemoveObserver(vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObserver_0")] public static extern 
bool RemoveObserver(IntPtr /*vtkObject* */ obj, IntPtr/*vtkCommand* */ ARG_0);

//       Method: void vtkObject::RemoveObservers(unsigned long evt, vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObservers_0")] public static extern 
bool RemoveObservers(IntPtr /*vtkObject* */ obj, ulong evt, IntPtr/*vtkCommand* */ ARG_0);

//       Method: void vtkObject::RemoveObservers(const char* evt, vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObservers_1")] public static extern 
bool RemoveObservers(IntPtr /*vtkObject* */ obj, string/*const char* */ evt, IntPtr/*vtkCommand* */ ARG_0);

//       Method: int vtkObject::HasObserver(unsigned long evt, vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_HasObserver_0")] public static extern 
bool HasObserver(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, ulong evt, IntPtr/*vtkCommand* */ ARG_0);

//       Method: int vtkObject::HasObserver(const char* evt, vtkCommand* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_HasObserver_1")] public static extern 
bool HasObserver(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, string/*const char* */ evt, IntPtr/*vtkCommand* */ ARG_0);

//       Method: void vtkObject::RemoveObserver(unsigned long tag)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObserver_1")] public static extern 
bool RemoveObserver(IntPtr /*vtkObject* */ obj, ulong tag);

//       Method: void vtkObject::RemoveObservers(unsigned long evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObservers_2")] public static extern 
bool RemoveObservers(IntPtr /*vtkObject* */ obj, ulong evt);

//       Method: void vtkObject::RemoveObservers(const char* evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveObservers_3")] public static extern 
bool RemoveObservers(IntPtr /*vtkObject* */ obj, string/*const char* */ evt);

//       Method: void vtkObject::RemoveAllObservers()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_RemoveAllObservers_0")] public static extern 
bool RemoveAllObservers(IntPtr /*vtkObject* */ obj);

//       Method: int vtkObject::HasObserver(unsigned long evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_HasObserver_2")] public static extern 
bool HasObserver(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, ulong evt);

//       Method: int vtkObject::HasObserver(const char* evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_HasObserver_3")] public static extern 
bool HasObserver(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, string/*const char* */ evt);

//       Method: int vtkObject::InvokeEvent(unsigned long evt, void* callData)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_InvokeEvent_0")] public static extern 
bool InvokeEvent(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, ulong evt, IntPtr/*void* */ callData);

//       Method: int vtkObject::InvokeEvent(const char* evt, void* callData)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_InvokeEvent_1")] public static extern 
bool InvokeEvent(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, string/*const char* */ evt, IntPtr/*void* */ callData);

//       Method: int vtkObject::InvokeEvent(unsigned long evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_InvokeEvent_2")] public static extern 
bool InvokeEvent(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, ulong evt);

//       Method: int vtkObject::InvokeEvent(const char* evt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkObject_InvokeEvent_3")] public static extern 
bool InvokeEvent(IntPtr /*int* */ ret, IntPtr /*vtkObject* */ obj, string/*const char* */ evt);

}
};
