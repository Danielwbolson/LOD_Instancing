

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObject : vtkObjectBase {
		public vtkObject(IntPtr p) : base(p) {}
		public static implicit operator  vtkObject(IntPtr p) {return new vtkObject(p);}
		public static implicit operator  IntPtr(vtkObject o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkObject.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkObject.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkObject* SafeDownCast(vtkObjectBase * o)
// "static vtkObject* SafeDownCast(vtkObjectBase *o)"
public static vtkObject SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObject.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkObject)(IntPtr)returnPointer;
}


// vtkObject* NewInstance()
// "vtkObject *NewInstance()"
public vtkObject NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObject.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkObject)(IntPtr)returnPointer;
}


// static vtkObject* New()
// "static vtkObject *New()"
public static vtkObject New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObject.New_0(returnPointer.GetPtr());
	return (vtkObject)(IntPtr)returnPointer;
}


// virtual void DebugOn()
// "virtual void DebugOn()"
public void DebugOn() {
	VTK_API.API_vtkObject.DebugOn_0(this);
}


// virtual void DebugOff()
// "virtual void DebugOff()"
public void DebugOff() {
	VTK_API.API_vtkObject.DebugOff_0(this);
}


// bool GetDebug()
// "bool GetDebug()"
public bool GetDebug() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkObject.GetDebug_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void SetDebug(bool debugFlag)
// "void SetDebug(bool debugFlag)"
public void SetDebug(bool /*(bool)*/ debugFlag) {
	VTK_API.API_vtkObject.SetDebug_0(this, debugFlag);
}


// static void BreakOnError()
// "static void BreakOnError()"
public static void BreakOnError() {
	VTK_API.API_vtkObject.BreakOnError_0();
}


// virtual void Modified()
// "virtual void Modified()"
public void Modified() {
	VTK_API.API_vtkObject.Modified_0(this);
}


// virtual vtkMTimeType GetMTime()
// "virtual vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkObject.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// static void SetGlobalWarningDisplay(int val)
// "static void SetGlobalWarningDisplay(int val)"
public static void SetGlobalWarningDisplay(int /*(int)*/ val) {
	VTK_API.API_vtkObject.SetGlobalWarningDisplay_0(val);
}


// static void GlobalWarningDisplayOn()
// "static void GlobalWarningDisplayOn()"
public static void GlobalWarningDisplayOn() {
	VTK_API.API_vtkObject.GlobalWarningDisplayOn_0();
}


// static void GlobalWarningDisplayOff()
// "static void GlobalWarningDisplayOff()"
public static void GlobalWarningDisplayOff() {
	VTK_API.API_vtkObject.GlobalWarningDisplayOff_0();
}


// static int GetGlobalWarningDisplay()
// "static int GetGlobalWarningDisplay()"
public static int GetGlobalWarningDisplay() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.GetGlobalWarningDisplay_0(returnPointer.GetPtr());
	return (int)returnPointer;
}


// vtkCommand* GetCommand(unsigned long tag)
// "vtkCommand *GetCommand(unsigned long tag)"
public vtkCommand GetCommand(ulong /*(unsigned long)*/ tag) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObject.GetCommand_0(returnPointer.GetPtr(), this, tag);
	return (vtkCommand)(IntPtr)returnPointer;
}


// void RemoveObserver(vtkCommand * ARG_0)
// "void RemoveObserver(vtkCommand*)"
public void RemoveObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkObject.RemoveObserver_0(this, ARG_0);
}


// void RemoveObservers(unsigned long event, vtkCommand * ARG_0)
// "void RemoveObservers(unsigned long event, vtkCommand *)"
public void RemoveObservers(ulong /*(unsigned long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkObject.RemoveObservers_0(this, evt, ARG_0);
}


// void RemoveObservers(const char * event, vtkCommand * ARG_0)
// "void RemoveObservers(const char *event, vtkCommand *)"
public void RemoveObservers(string /*(char*)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkObject.RemoveObservers_1(this, evt, ARG_0);
}


// int HasObserver(unsigned long event, vtkCommand * ARG_0)
// "int HasObserver(unsigned long event, vtkCommand *)"
public int HasObserver(ulong /*(unsigned long)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.HasObserver_0(returnPointer.GetPtr(), this, evt, ARG_0);
	return (int)returnPointer;
}


// int HasObserver(const char * event, vtkCommand * ARG_0)
// "int HasObserver(const char *event, vtkCommand *)"
public int HasObserver(string /*(char*)*/ evt, vtkCommand /*(vtkCommand*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.HasObserver_1(returnPointer.GetPtr(), this, evt, ARG_0);
	return (int)returnPointer;
}


// void RemoveObserver(unsigned long tag)
// "void RemoveObserver(unsigned long tag)"
public void RemoveObserver(ulong /*(unsigned long)*/ tag) {
	VTK_API.API_vtkObject.RemoveObserver_1(this, tag);
}


// void RemoveObservers(unsigned long event)
// "void RemoveObservers(unsigned long event)"
public void RemoveObservers(ulong /*(unsigned long)*/ evt) {
	VTK_API.API_vtkObject.RemoveObservers_2(this, evt);
}


// void RemoveObservers(const char * event)
// "void RemoveObservers(const char *event)"
public void RemoveObservers(string /*(char*)*/ evt) {
	VTK_API.API_vtkObject.RemoveObservers_3(this, evt);
}


// void RemoveAllObservers()
// "void RemoveAllObservers()"
public void RemoveAllObservers() {
	VTK_API.API_vtkObject.RemoveAllObservers_0(this);
}


// int HasObserver(unsigned long event)
// "int HasObserver(unsigned long event)"
public int HasObserver(ulong /*(unsigned long)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.HasObserver_2(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int HasObserver(const char * event)
// "int HasObserver(const char *event)"
public int HasObserver(string /*(char*)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.HasObserver_3(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int InvokeEvent(unsigned long event, void * callData)
// "int InvokeEvent(unsigned long event, void *callData)"
public int InvokeEvent(ulong /*(unsigned long)*/ evt, IntPtr /*(void*)*/ callData) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.InvokeEvent_0(returnPointer.GetPtr(), this, evt, callData);
	return (int)returnPointer;
}


// int InvokeEvent(const char * event, void * callData)
// "int InvokeEvent(const char *event, void *callData)"
public int InvokeEvent(string /*(char*)*/ evt, IntPtr /*(void*)*/ callData) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.InvokeEvent_1(returnPointer.GetPtr(), this, evt, callData);
	return (int)returnPointer;
}


// int InvokeEvent(unsigned long event)
// "int InvokeEvent(unsigned long event)"
public int InvokeEvent(ulong /*(unsigned long)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.InvokeEvent_2(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


// int InvokeEvent(const char * event)
// "int InvokeEvent(const char *event)"
public int InvokeEvent(string /*(char*)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObject.InvokeEvent_3(returnPointer.GetPtr(), this, evt);
	return (int)returnPointer;
}


}
};
