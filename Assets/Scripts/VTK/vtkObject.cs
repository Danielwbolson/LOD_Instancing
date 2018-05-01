

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObject : vtkObjectBase {

// static vtkObject* New()
// "static vtkObject *New()"
public new static vtkObject New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkObject.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void DebugOn()
// "virtual void DebugOn()"
public new void DebugOn() {
	API_vtkObject.DebugOn_0(this);
}


// virtual void DebugOff()
// "virtual void DebugOff()"
public new void DebugOff() {
	API_vtkObject.DebugOff_0(this);
}


// bool GetDebug()
// "bool GetDebug()"
public new bool GetDebug() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkObject.GetDebug_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetDebug(bool debugFlag)
// "void SetDebug(bool debugFlag)"
public new void SetDebug(bool /*(bool)*/ debugFlag) {
	API_vtkObject.SetDebug_0(this, debugFlag);
}


// static void BreakOnError()
// "static void BreakOnError()"
public new static void BreakOnError() {
	API_vtkObject.BreakOnError_0();
}


// virtual void Modified()
// "virtual void Modified()"
public new void Modified() {
	API_vtkObject.Modified_0(this);
}


// virtual vtkMTimeType GetMTime()
// "virtual vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkObject.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static void SetGlobalWarningDisplay(int val)
// "static void SetGlobalWarningDisplay(int val)"
public new static void SetGlobalWarningDisplay(int /*(int)*/ val) {
	API_vtkObject.SetGlobalWarningDisplay_0(val);
}


// static void GlobalWarningDisplayOn()
// "static void GlobalWarningDisplayOn()"
public new static void GlobalWarningDisplayOn() {
	API_vtkObject.GlobalWarningDisplayOn_0();
}


// static void GlobalWarningDisplayOff()
// "static void GlobalWarningDisplayOff()"
public new static void GlobalWarningDisplayOff() {
	API_vtkObject.GlobalWarningDisplayOff_0();
}


// static int GetGlobalWarningDisplay()
// "static int GetGlobalWarningDisplay()"
public new static int GetGlobalWarningDisplay() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.GetGlobalWarningDisplay_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkCommand* GetCommand(unsigned long tag)
// "vtkCommand *GetCommand(unsigned long tag)"
public new vtkCommand GetCommand(ulong /*(long)*/ tag) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkObject.GetCommand_0(this, returnPointer, tag);
	return Ptr.deref(returnPointer);
}


// void RemoveObserver(vtkCommand * ARG_0)
// "void RemoveObserver(vtkCommand*)"
public new void RemoveObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObserver_0(this, ARG_0);
}


// void RemoveObservers(unsigned long event, vtkCommand * ARG_0)
// "void RemoveObservers(unsigned long event, vtkCommand *)"
public new void RemoveObservers(ulong /*(long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObservers_0(this, evt, ARG_0);
}


// void RemoveObservers(const char * event, vtkCommand * ARG_0)
// "void RemoveObservers(const char *event, vtkCommand *)"
public new void RemoveObservers(char /*(char*)*/ []evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObservers_1(this, evt, ARG_0);
}


// int HasObserver(unsigned long event, vtkCommand * ARG_0)
// "int HasObserver(unsigned long event, vtkCommand *)"
public new int HasObserver(ulong /*(long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.HasObserver_0(this, returnPointer, evt, ARG_0);
	return Ptr.deref(returnPointer);
}


// int HasObserver(const char * event, vtkCommand * ARG_0)
// "int HasObserver(const char *event, vtkCommand *)"
public new int HasObserver(char /*(char*)*/ []evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.HasObserver_1(this, returnPointer, evt, ARG_0);
	return Ptr.deref(returnPointer);
}


// void RemoveObserver(unsigned long tag)
// "void RemoveObserver(unsigned long tag)"
public new void RemoveObserver(ulong /*(long)*/ tag) {
	API_vtkObject.RemoveObserver_1(this, tag);
}


// void RemoveObservers(unsigned long event)
// "void RemoveObservers(unsigned long event)"
public new void RemoveObservers(ulong /*(long)*/ evt) {
	API_vtkObject.RemoveObservers_2(this, evt);
}


// void RemoveObservers(const char * event)
// "void RemoveObservers(const char *event)"
public new void RemoveObservers(char /*(char*)*/ []evt) {
	API_vtkObject.RemoveObservers_3(this, evt);
}


// void RemoveAllObservers()
// "void RemoveAllObservers()"
public new void RemoveAllObservers() {
	API_vtkObject.RemoveAllObservers_0(this);
}


// int HasObserver(unsigned long event)
// "int HasObserver(unsigned long event)"
public new int HasObserver(ulong /*(long)*/ evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.HasObserver_2(this, returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// int HasObserver(const char * event)
// "int HasObserver(const char *event)"
public new int HasObserver(char /*(char*)*/ []evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.HasObserver_3(this, returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// int InvokeEvent(unsigned long event, void * callData)
// "int InvokeEvent(unsigned long event, void *callData)"
public new int InvokeEvent(ulong /*(long)*/ evt, IntPtr /*(void*)*/ []callData) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.InvokeEvent_0(this, returnPointer, evt, callData);
	return Ptr.deref(returnPointer);
}


// int InvokeEvent(const char * event, void * callData)
// "int InvokeEvent(const char *event, void *callData)"
public new int InvokeEvent(char /*(char*)*/ []evt, IntPtr /*(void*)*/ []callData) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.InvokeEvent_1(this, returnPointer, evt, callData);
	return Ptr.deref(returnPointer);
}


// int InvokeEvent(unsigned long event)
// "int InvokeEvent(unsigned long event)"
public new int InvokeEvent(ulong /*(long)*/ evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.InvokeEvent_2(this, returnPointer, evt);
	return Ptr.deref(returnPointer);
}


// int InvokeEvent(const char * event)
// "int InvokeEvent(const char *event)"
public new int InvokeEvent(char /*(char*)*/ []evt) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkObject.InvokeEvent_3(this, returnPointer, evt);
	return Ptr.deref(returnPointer);
}


}
};
