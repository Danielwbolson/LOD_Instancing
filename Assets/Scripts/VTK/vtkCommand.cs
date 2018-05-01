

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCommand : vtkObjectBase {

// void UnRegister()
// "void UnRegister()"
public new void UnRegister() {
	API_vtkCommand.UnRegister_0(this);
}


// void UnRegister(vtkObjectBase * ARG_0)
// "void UnRegister(vtkObjectBase *)"
public new void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	API_vtkCommand.UnRegister_1(this, ARG_0);
}


// virtual void Execute(vtkObject * caller, unsigned long eventId, void * callData)
// "virtual void Execute(vtkObject *caller, unsigned long eventId, void *callData)"
public new void Execute(vtkObject /*(vtkObject*)*/ caller, ulong /*(long)*/ eventId, IntPtr /*(void*)*/ []callData) {
	API_vtkCommand.Execute_0(this, caller, eventId, callData);
}


// static char* GetStringFromEventId(unsigned long event)
// "static const char *GetStringFromEventId(unsigned long event)"
public new static char GetStringFromEventId(ulong /*(long)*/ evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkCommand.GetStringFromEventId_0(returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// static long GetEventIdFromString(const char * event)
// "static unsigned long GetEventIdFromString(const char *event)"
public new static ulong GetEventIdFromString(char /*(char*)*/ []evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkCommand.GetEventIdFromString_0(returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// static bool EventHasData(unsigned long event)
// "static bool EventHasData(unsigned long event)"
public new static bool EventHasData(ulong /*(long)*/ evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkCommand.EventHasData_0(returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// void SetAbortFlag(int f)
// "void SetAbortFlag(int f)"
public new void SetAbortFlag(int /*(int)*/ f) {
	API_vtkCommand.SetAbortFlag_0(this, f);
}


// int GetAbortFlag()
// "int GetAbortFlag()"
public new int GetAbortFlag() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCommand.GetAbortFlag_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void AbortFlagOn()
// "void AbortFlagOn()"
public new void AbortFlagOn() {
	API_vtkCommand.AbortFlagOn_0(this);
}


// void AbortFlagOff()
// "void AbortFlagOff()"
public new void AbortFlagOff() {
	API_vtkCommand.AbortFlagOff_0(this);
}


// void SetPassiveObserver(int f)
// "void SetPassiveObserver(int f)"
public new void SetPassiveObserver(int /*(int)*/ f) {
	API_vtkCommand.SetPassiveObserver_0(this, f);
}


// int GetPassiveObserver()
// "int GetPassiveObserver()"
public new int GetPassiveObserver() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkCommand.GetPassiveObserver_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void PassiveObserverOn()
// "void PassiveObserverOn()"
public new void PassiveObserverOn() {
	API_vtkCommand.PassiveObserverOn_0(this);
}


// void PassiveObserverOff()
// "void PassiveObserverOff()"
public new void PassiveObserverOff() {
	API_vtkCommand.PassiveObserverOff_0(this);
}


}
};
