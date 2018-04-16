
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkCommand : vtkObjectBase {

//       Method: void vtkCommand::UnRegister()
// 
public void UnRegister() {
	VTK.API_vtkCommand.UnRegister(obj);
}


//       Method: void vtkCommand::UnRegister(vtkObjectBase* ARG_0)
// 
public void UnRegister(vtkObjectBase/*vtkObjectBase* */ ARG_0) {
	VTK.API_vtkCommand.UnRegister(obj, ARG_0);
}


//       Method: virtual void vtkCommand::Execute(vtkObject* caller, unsigned long eventId, void* callData)
// 
public void Execute(vtkObject/*vtkObject* */ caller, ulong eventId, IntPtr/*void* */ callData) {
	VTK.API_vtkCommand.Execute(obj, caller, eventId, callData);
}


//       Method: static const char * vtkCommand::GetStringFromEventId(unsigned long evt)
// 
public static string GetStringFromEventId(ulong evt) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkCommand.GetStringFromEventId(p, evt);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static bool vtkCommand::EventHasData(unsigned long evt)
// 
public static bool EventHasData(ulong evt) {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCommand.EventHasData(p, evt);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCommand::SetAbortFlag(int f)
// 
public void SetAbortFlag(int f) {
	VTK.API_vtkCommand.SetAbortFlag(obj, f);
}


//       Method: int vtkCommand::GetAbortFlag()
// 
public int GetAbortFlag() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCommand.GetAbortFlag(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCommand::AbortFlagOn()
// 
public void AbortFlagOn() {
	VTK.API_vtkCommand.AbortFlagOn(obj);
}


//       Method: void vtkCommand::AbortFlagOff()
// 
public void AbortFlagOff() {
	VTK.API_vtkCommand.AbortFlagOff(obj);
}


//       Method: void vtkCommand::SetPassiveObserver(int f)
// 
public void SetPassiveObserver(int f) {
	VTK.API_vtkCommand.SetPassiveObserver(obj, f);
}


//       Method: int vtkCommand::GetPassiveObserver()
// 
public int GetPassiveObserver() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCommand.GetPassiveObserver(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCommand::PassiveObserverOn()
// 
public void PassiveObserverOn() {
	VTK.API_vtkCommand.PassiveObserverOn(obj);
}


//       Method: void vtkCommand::PassiveObserverOff()
// 
public void PassiveObserverOff() {
	VTK.API_vtkCommand.PassiveObserverOff(obj);
}


}
};
