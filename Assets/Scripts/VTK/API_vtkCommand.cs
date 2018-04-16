
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkCommand {

//       Method: void vtkCommand::UnRegister()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_UnRegister_0")] public static extern 
bool UnRegister(IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::UnRegister(vtkObjectBase* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_UnRegister_1")] public static extern 
bool UnRegister(IntPtr /*vtkCommand* */ obj, IntPtr/*vtkObjectBase* */ ARG_0);

//       Method: virtual void vtkCommand::Execute(vtkObject* caller, unsigned long eventId, void* callData)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_Execute_0")] public static extern 
bool Execute(IntPtr /*vtkCommand* */ obj, IntPtr/*vtkObject* */ caller, ulong eventId, IntPtr/*void* */ callData);

//       Method: static const char * vtkCommand::GetStringFromEventId(unsigned long evt)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCommand_GetStringFromEventId_0")] public static extern 
bool GetStringFromEventId(IntPtr /*const char** */ ret, ulong evt);

//       Method: static bool vtkCommand::EventHasData(unsigned long evt)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkCommand_EventHasData_0")] public static extern 
bool EventHasData(IntPtr /*bool* */ ret, ulong evt);

//       Method: void vtkCommand::SetAbortFlag(int f)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_SetAbortFlag_0")] public static extern 
bool SetAbortFlag(IntPtr /*vtkCommand* */ obj, int f);

//       Method: int vtkCommand::GetAbortFlag()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_GetAbortFlag_0")] public static extern 
bool GetAbortFlag(IntPtr /*int* */ ret, IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::AbortFlagOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_AbortFlagOn_0")] public static extern 
bool AbortFlagOn(IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::AbortFlagOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_AbortFlagOff_0")] public static extern 
bool AbortFlagOff(IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::SetPassiveObserver(int f)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_SetPassiveObserver_0")] public static extern 
bool SetPassiveObserver(IntPtr /*vtkCommand* */ obj, int f);

//       Method: int vtkCommand::GetPassiveObserver()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_GetPassiveObserver_0")] public static extern 
bool GetPassiveObserver(IntPtr /*int* */ ret, IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::PassiveObserverOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_PassiveObserverOn_0")] public static extern 
bool PassiveObserverOn(IntPtr /*vtkCommand* */ obj);

//       Method: void vtkCommand::PassiveObserverOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkCommand_PassiveObserverOff_0")] public static extern 
bool PassiveObserverOff(IntPtr /*vtkCommand* */ obj);

}
};
