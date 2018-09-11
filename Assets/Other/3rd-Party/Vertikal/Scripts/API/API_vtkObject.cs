
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkObject {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkObject_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkObject_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ type);

// static vtkObject* SafeDownCast(vtkObjectBase * o)
// static vtkObject* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkObject_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkObject* NewInstance()
// vtkObject *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkObject_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject);

// static vtkObject* New()
// static vtkObject *New()
[DllImport("vtkplugin", EntryPoint="vtkObject_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void DebugOn()
// virtual void DebugOn()
[DllImport("vtkplugin", EntryPoint="vtkObject_DebugOn_0")] public static extern 
bool DebugOn_0(IntPtr /*(vtkObject*)*/ callingObject);

// virtual void DebugOff()
// virtual void DebugOff()
[DllImport("vtkplugin", EntryPoint="vtkObject_DebugOff_0")] public static extern 
bool DebugOff_0(IntPtr /*(vtkObject*)*/ callingObject);

// bool GetDebug()
// bool GetDebug()
[DllImport("vtkplugin", EntryPoint="vtkObject_GetDebug_0")] public static extern 
bool GetDebug_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject);

// void SetDebug(bool debugFlag)
// void SetDebug(bool debugFlag)
[DllImport("vtkplugin", EntryPoint="vtkObject_SetDebug_0")] public static extern 
bool SetDebug_0(IntPtr /*(vtkObject*)*/ callingObject, bool /*(bool)*/ debugFlag);

// static void BreakOnError()
// static void BreakOnError()
[DllImport("vtkplugin", EntryPoint="vtkObject_BreakOnError_0")] public static extern 
bool BreakOnError_0();

// virtual void Modified()
// virtual void Modified()
[DllImport("vtkplugin", EntryPoint="vtkObject_Modified_0")] public static extern 
bool Modified_0(IntPtr /*(vtkObject*)*/ callingObject);

// virtual vtkMTimeType GetMTime()
// virtual vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkObject_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject);

// static void SetGlobalWarningDisplay(int val)
// static void SetGlobalWarningDisplay(int val)
[DllImport("vtkplugin", EntryPoint="vtkObject_SetGlobalWarningDisplay_0")] public static extern 
bool SetGlobalWarningDisplay_0(int /*(int)*/ val);

// static void GlobalWarningDisplayOn()
// static void GlobalWarningDisplayOn()
[DllImport("vtkplugin", EntryPoint="vtkObject_GlobalWarningDisplayOn_0")] public static extern 
bool GlobalWarningDisplayOn_0();

// static void GlobalWarningDisplayOff()
// static void GlobalWarningDisplayOff()
[DllImport("vtkplugin", EntryPoint="vtkObject_GlobalWarningDisplayOff_0")] public static extern 
bool GlobalWarningDisplayOff_0();

// static int GetGlobalWarningDisplay()
// static int GetGlobalWarningDisplay()
[DllImport("vtkplugin", EntryPoint="vtkObject_GetGlobalWarningDisplay_0")] public static extern 
bool GetGlobalWarningDisplay_0(IntPtr /*(IntPtr*)*/ return_value);

// vtkCommand* GetCommand(unsigned long tag)
// vtkCommand *GetCommand(unsigned long tag)
[DllImport("vtkplugin", EntryPoint="vtkObject_GetCommand_0")] public static extern 
bool GetCommand_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ tag);

// void RemoveObserver(vtkCommand * ARG_0)
// void RemoveObserver(vtkCommand*)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObserver_0")] public static extern 
bool RemoveObserver_0(IntPtr /*(vtkObject*)*/ callingObject, IntPtr /*(vtkCommand*)*/ ARG_0);

// void RemoveObservers(unsigned long event, vtkCommand * ARG_0)
// void RemoveObservers(unsigned long event, vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObservers_0")] public static extern 
bool RemoveObservers_0(IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt, IntPtr /*(vtkCommand*)*/ ARG_0);

// void RemoveObservers(const char * event, vtkCommand * ARG_0)
// void RemoveObservers(const char *event, vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObservers_1")] public static extern 
bool RemoveObservers_1(IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt, IntPtr /*(vtkCommand*)*/ ARG_0);

// int HasObserver(unsigned long event, vtkCommand * ARG_0)
// int HasObserver(unsigned long event, vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkObject_HasObserver_0")] public static extern 
bool HasObserver_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt, IntPtr /*(vtkCommand*)*/ ARG_0);

// int HasObserver(const char * event, vtkCommand * ARG_0)
// int HasObserver(const char *event, vtkCommand *)
[DllImport("vtkplugin", EntryPoint="vtkObject_HasObserver_1")] public static extern 
bool HasObserver_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt, IntPtr /*(vtkCommand*)*/ ARG_0);

// void RemoveObserver(unsigned long tag)
// void RemoveObserver(unsigned long tag)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObserver_1")] public static extern 
bool RemoveObserver_1(IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ tag);

// void RemoveObservers(unsigned long event)
// void RemoveObservers(unsigned long event)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObservers_2")] public static extern 
bool RemoveObservers_2(IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt);

// void RemoveObservers(const char * event)
// void RemoveObservers(const char *event)
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveObservers_3")] public static extern 
bool RemoveObservers_3(IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt);

// void RemoveAllObservers()
// void RemoveAllObservers()
[DllImport("vtkplugin", EntryPoint="vtkObject_RemoveAllObservers_0")] public static extern 
bool RemoveAllObservers_0(IntPtr /*(vtkObject*)*/ callingObject);

// int HasObserver(unsigned long event)
// int HasObserver(unsigned long event)
[DllImport("vtkplugin", EntryPoint="vtkObject_HasObserver_2")] public static extern 
bool HasObserver_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt);

// int HasObserver(const char * event)
// int HasObserver(const char *event)
[DllImport("vtkplugin", EntryPoint="vtkObject_HasObserver_3")] public static extern 
bool HasObserver_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt);

// int InvokeEvent(unsigned long event, void * callData)
// int InvokeEvent(unsigned long event, void *callData)
[DllImport("vtkplugin", EntryPoint="vtkObject_InvokeEvent_0")] public static extern 
bool InvokeEvent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt, IntPtr /*(void*)*/ callData);

// int InvokeEvent(const char * event, void * callData)
// int InvokeEvent(const char *event, void *callData)
[DllImport("vtkplugin", EntryPoint="vtkObject_InvokeEvent_1")] public static extern 
bool InvokeEvent_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt, IntPtr /*(void*)*/ callData);

// int InvokeEvent(unsigned long event)
// int InvokeEvent(unsigned long event)
[DllImport("vtkplugin", EntryPoint="vtkObject_InvokeEvent_2")] public static extern 
bool InvokeEvent_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, ulong /*(unsigned long)*/ evt);

// int InvokeEvent(const char * event)
// int InvokeEvent(const char *event)
[DllImport("vtkplugin", EntryPoint="vtkObject_InvokeEvent_3")] public static extern 
bool InvokeEvent_3(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObject*)*/ callingObject, string /*(char*)*/ evt);

}
};
