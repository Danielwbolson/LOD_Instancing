

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCommand : vtkObjectBase {
		public vtkCommand(IntPtr p) : base(p) {}
		public static implicit operator  vtkCommand(IntPtr p) {return new vtkCommand(p);}
		public static implicit operator  IntPtr(vtkCommand o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCommand.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCommand.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCommand* SafeDownCast(vtkObjectBase * o)
// "static vtkCommand* SafeDownCast(vtkObjectBase *o)"
public static vtkCommand SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCommand.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCommand)(IntPtr)returnPointer;
}


// vtkCommand* NewInstance()
// "vtkCommand *NewInstance()"
public vtkCommand NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCommand.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCommand)(IntPtr)returnPointer;
}


// void UnRegister()
// "void UnRegister()"
public void UnRegister() {
	VTK_API.API_vtkCommand.UnRegister_0(this);
}


// void UnRegister(vtkObjectBase * ARG_0)
// "void UnRegister(vtkObjectBase *)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ ARG_0) {
	VTK_API.API_vtkCommand.UnRegister_1(this, ARG_0);
}


// virtual void Execute(vtkObject * caller, unsigned long eventId, void * callData)
// "virtual void Execute(vtkObject *caller, unsigned long eventId, void *callData)"
public void Execute(vtkObject /*(vtkObject*)*/ caller, ulong /*(unsigned long)*/ eventId, IntPtr /*(void*)*/ callData) {
	VTK_API.API_vtkCommand.Execute_0(this, caller, eventId, callData);
}


// static char* GetStringFromEventId(unsigned long event)
// "static const char *GetStringFromEventId(unsigned long event)"
public static string GetStringFromEventId(ulong /*(unsigned long)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCommand.GetStringFromEventId_0(returnPointer.GetPtr(), evt);
	return (string)returnPointer;
}


// static long GetEventIdFromString(const char * event)
// "static unsigned long GetEventIdFromString(const char *event)"
public static ulong GetEventIdFromString(string /*(char*)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkCommand.GetEventIdFromString_0(returnPointer.GetPtr(), evt);
	return (ulong)returnPointer;
}


// static bool EventHasData(unsigned long event)
// "static bool EventHasData(unsigned long event)"
public static bool EventHasData(ulong /*(unsigned long)*/ evt) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCommand.EventHasData_0(returnPointer.GetPtr(), evt);
	return (bool)returnPointer;
}


// void SetAbortFlag(int f)
// "void SetAbortFlag(int f)"
public void SetAbortFlag(int /*(int)*/ f) {
	VTK_API.API_vtkCommand.SetAbortFlag_0(this, f);
}


// int GetAbortFlag()
// "int GetAbortFlag()"
public int GetAbortFlag() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCommand.GetAbortFlag_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void AbortFlagOn()
// "void AbortFlagOn()"
public void AbortFlagOn() {
	VTK_API.API_vtkCommand.AbortFlagOn_0(this);
}


// void AbortFlagOff()
// "void AbortFlagOff()"
public void AbortFlagOff() {
	VTK_API.API_vtkCommand.AbortFlagOff_0(this);
}


// void SetPassiveObserver(int f)
// "void SetPassiveObserver(int f)"
public void SetPassiveObserver(int /*(int)*/ f) {
	VTK_API.API_vtkCommand.SetPassiveObserver_0(this, f);
}


// int GetPassiveObserver()
// "int GetPassiveObserver()"
public int GetPassiveObserver() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCommand.GetPassiveObserver_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void PassiveObserverOn()
// "void PassiveObserverOn()"
public void PassiveObserverOn() {
	VTK_API.API_vtkCommand.PassiveObserverOn_0(this);
}


// void PassiveObserverOff()
// "void PassiveObserverOff()"
public void PassiveObserverOff() {
	VTK_API.API_vtkCommand.PassiveObserverOff_0(this);
}


}
};
