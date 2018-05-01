

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObject : vtkObjectBase {
		public vtkObject(IntPtr p) : base(p) {}
		public static implicit operator  vtkObject(IntPtr p) {return new vtkObject(p);}
		public static implicit operator  IntPtr(vtkObject o) {return o.GetPtr();}

// static vtkObject* New()
// "static vtkObject *New()"
public static vtkObject New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkObject.New_0(returnPointer.GetPtr());
	return (vtkObject)(IntPtr)returnPointer;
}


// virtual void DebugOn()
// "virtual void DebugOn()"
public void DebugOn() {
	API_vtkObject.DebugOn_0(this);
}


// virtual void DebugOff()
// "virtual void DebugOff()"
public void DebugOff() {
	API_vtkObject.DebugOff_0(this);
}


// bool GetDebug()
// "bool GetDebug()"
public bool GetDebug() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	API_vtkObject.GetDebug_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void SetDebug(bool debugFlag)
// "void SetDebug(bool debugFlag)"
public void SetDebug(bool /*(bool)*/ debugFlag) {
	API_vtkObject.SetDebug_0(this, debugFlag);
}


// static void BreakOnError()
// "static void BreakOnError()"
public static void BreakOnError() {
	API_vtkObject.BreakOnError_0();
}


// virtual void Modified()
// "virtual void Modified()"
public void Modified() {
	API_vtkObject.Modified_0(this);
}


// virtual vtkMTimeType GetMTime()
// "virtual vtkMTimeType GetMTime()"
public ulong GetMTime() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkObject.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// static void SetGlobalWarningDisplay(int val)
// "static void SetGlobalWarningDisplay(int val)"
public static void SetGlobalWarningDisplay(int /*(int)*/ val) {
	API_vtkObject.SetGlobalWarningDisplay_0(val);
}


// static void GlobalWarningDisplayOn()
// "static void GlobalWarningDisplayOn()"
public static void GlobalWarningDisplayOn() {
	API_vtkObject.GlobalWarningDisplayOn_0();
}


// static void GlobalWarningDisplayOff()
// "static void GlobalWarningDisplayOff()"
public static void GlobalWarningDisplayOff() {
	API_vtkObject.GlobalWarningDisplayOff_0();
}


// static int GetGlobalWarningDisplay()
// "static int GetGlobalWarningDisplay()"
public static int GetGlobalWarningDisplay() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.GetGlobalWarningDisplay_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// vtkCommand* GetCommand(unsigned long tag)
// "vtkCommand *GetCommand(unsigned long tag)"
public vtkCommand GetCommand(ulong /*(unsigned long)*/ tag) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkObject.GetCommand_0(returnPointer.GetPtr(), this, tag);
	return (vtkCommand)(IntPtr)returnPointer;
}


// void RemoveObserver(vtkCommand * ARG_0)
// "void RemoveObserver(vtkCommand*)"
public void RemoveObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObserver_0(this, ARG_0);
}


// void RemoveObservers(unsigned long event, vtkCommand * ARG_0)
// "void RemoveObservers(unsigned long event, vtkCommand *)"
public void RemoveObservers(ulong /*(unsigned long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObservers_0(this, evt, ARG_0);
}


// void RemoveObservers(const char * event, vtkCommand * ARG_0)
// "void RemoveObservers(const char *event, vtkCommand *)"
public void RemoveObservers(string /*(char*)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	API_vtkObject.RemoveObservers_1(this, evt, ARG_0);
}


// int HasObserver(unsigned long event, vtkCommand * ARG_0)
// "int HasObserver(unsigned long event, vtkCommand *)"
public int HasObserver(ulong /*(unsigned long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.HasObserver_0(returnPointer.GetPtr(), this, evt, ARG_0);
	return (int)returnPointer;
}


// int HasObserver(const char * event, vtkCommand * ARG_0)
// "int HasObserver(const char *event, vtkCommand *)"
public int HasObserver(string /*(char*)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.HasObserver_1(returnPointer.GetPtr(), this, evt, ARG_0);
	return (int)returnPointer;
}


// void RemoveObserver(unsigned long tag)
// "void RemoveObserver(unsigned long tag)"
public void RemoveObserver(ulong /*(unsigned long)*/ tag) {
	API_vtkObject.RemoveObserver_1(this, tag);
}


// void RemoveObservers(unsigned long event)
// "void RemoveObservers(unsigned long event)"
public void RemoveObservers(ulong /*(unsigned long)*/ evt) {
	API_vtkObject.RemoveObservers_2(this, evt);
}


// void RemoveObservers(const char * event)
// "void RemoveObservers(const char *event)"
public void RemoveObservers(string /*(char*)*/ evt) {
	API_vtkObject.RemoveObservers_3(this, evt);
}


// void RemoveAllObservers()
// "void RemoveAllObservers()"
public void RemoveAllObservers() {
	API_vtkObject.RemoveAllObservers_0(this);
}


// int HasObserver(unsigned long event)
// "int HasObserver(unsigned long event)"
public int HasObserver(ulong /*(unsigned long)*/ evt) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.HasObserver_2(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int HasObserver(const char * event)
// "int HasObserver(const char *event)"
public int HasObserver(string /*(char*)*/ evt) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.HasObserver_3(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int InvokeEvent(unsigned long event, void * callData)
// "int InvokeEvent(unsigned long event, void *callData)"
public int InvokeEvent(ulong /*(unsigned long)*/ evt, IntPtr /*(void*)*/ callData) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.InvokeEvent_0(returnPointer.GetPtr(), this, evt, callData);
	return (int)returnPointer;
}


// int InvokeEvent(const char * event, void * callData)
// "int InvokeEvent(const char *event, void *callData)"
public int InvokeEvent(string /*(char*)*/ evt, IntPtr /*(void*)*/ callData) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.InvokeEvent_1(returnPointer.GetPtr(), this, evt, callData);
	return (int)returnPointer;
}


// int InvokeEvent(unsigned long event)
// "int InvokeEvent(unsigned long event)"
public int InvokeEvent(ulong /*(unsigned long)*/ evt) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.InvokeEvent_2(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int InvokeEvent(const char * event)
// "int InvokeEvent(const char *event)"
public int InvokeEvent(string /*(char*)*/ evt) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkObject.InvokeEvent_3(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


}
};
