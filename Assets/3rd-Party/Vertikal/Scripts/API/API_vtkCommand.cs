
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCommand {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCommand_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCommand_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCommand*)*/ callingObject, string /*(char*)*/ type);

// static vtkCommand* SafeDownCast(vtkObjectBase * o)
// static vtkCommand* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCommand_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCommand* NewInstance()
// vtkCommand *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCommand_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCommand*)*/ callingObject);

// void UnRegister()
// void UnRegister()
[DllImport("vtkplugin", EntryPoint="vtkCommand_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkCommand*)*/ callingObject);

// void UnRegister(vtkObjectBase * ARG_0)
// void UnRegister(vtkObjectBase *)
[DllImport("vtkplugin", EntryPoint="vtkCommand_UnRegister_1")] public static extern 
bool UnRegister_1(IntPtr /*(vtkCommand*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// virtual void Execute(vtkObject * caller, unsigned long eventId, void * callData)
// virtual void Execute(vtkObject *caller, unsigned long eventId, void *callData)
[DllImport("vtkplugin", EntryPoint="vtkCommand_Execute_0")] public static extern 
bool Execute_0(IntPtr /*(vtkCommand*)*/ callingObject, IntPtr /*(vtkObject*)*/ caller, ulong /*(unsigned long)*/ eventId, IntPtr /*(void*)*/ callData);

// static char* GetStringFromEventId(unsigned long event)
// static const char *GetStringFromEventId(unsigned long event)
[DllImport("vtkplugin", EntryPoint="vtkCommand_GetStringFromEventId_0")] public static extern 
bool GetStringFromEventId_0(IntPtr /*(IntPtr**)*/ return_value, ulong /*(unsigned long)*/ evt);

// static long GetEventIdFromString(const char * event)
// static unsigned long GetEventIdFromString(const char *event)
[DllImport("vtkplugin", EntryPoint="vtkCommand_GetEventIdFromString_0")] public static extern 
bool GetEventIdFromString_0(IntPtr /*(unsigned IntPtr*)*/ return_value, string /*(char*)*/ evt);

// static bool EventHasData(unsigned long event)
// static bool EventHasData(unsigned long event)
[DllImport("vtkplugin", EntryPoint="vtkCommand_EventHasData_0")] public static extern 
bool EventHasData_0(IntPtr /*(IntPtr*)*/ return_value, ulong /*(unsigned long)*/ evt);

// void SetAbortFlag(int f)
// void SetAbortFlag(int f)
[DllImport("vtkplugin", EntryPoint="vtkCommand_SetAbortFlag_0")] public static extern 
bool SetAbortFlag_0(IntPtr /*(vtkCommand*)*/ callingObject, int /*(int)*/ f);

// int GetAbortFlag()
// int GetAbortFlag()
[DllImport("vtkplugin", EntryPoint="vtkCommand_GetAbortFlag_0")] public static extern 
bool GetAbortFlag_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCommand*)*/ callingObject);

// void AbortFlagOn()
// void AbortFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkCommand_AbortFlagOn_0")] public static extern 
bool AbortFlagOn_0(IntPtr /*(vtkCommand*)*/ callingObject);

// void AbortFlagOff()
// void AbortFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkCommand_AbortFlagOff_0")] public static extern 
bool AbortFlagOff_0(IntPtr /*(vtkCommand*)*/ callingObject);

// void SetPassiveObserver(int f)
// void SetPassiveObserver(int f)
[DllImport("vtkplugin", EntryPoint="vtkCommand_SetPassiveObserver_0")] public static extern 
bool SetPassiveObserver_0(IntPtr /*(vtkCommand*)*/ callingObject, int /*(int)*/ f);

// int GetPassiveObserver()
// int GetPassiveObserver()
[DllImport("vtkplugin", EntryPoint="vtkCommand_GetPassiveObserver_0")] public static extern 
bool GetPassiveObserver_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCommand*)*/ callingObject);

// void PassiveObserverOn()
// void PassiveObserverOn()
[DllImport("vtkplugin", EntryPoint="vtkCommand_PassiveObserverOn_0")] public static extern 
bool PassiveObserverOn_0(IntPtr /*(vtkCommand*)*/ callingObject);

// void PassiveObserverOff()
// void PassiveObserverOff()
[DllImport("vtkplugin", EntryPoint="vtkCommand_PassiveObserverOff_0")] public static extern 
bool PassiveObserverOff_0(IntPtr /*(vtkCommand*)*/ callingObject);

}
};
