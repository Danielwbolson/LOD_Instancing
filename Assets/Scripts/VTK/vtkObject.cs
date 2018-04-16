
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkObject : vtkObjectBase {

//       Method: static vtkObject * vtkObject::New()
// 
public static vtkObject New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.New(p);
	vtkObject result = new vtkObject();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkObject::DebugOn()
// 
public void DebugOn() {
	VTK.API_vtkObject.DebugOn(obj);
}


//       Method: virtual void vtkObject::DebugOff()
// 
public void DebugOff() {
	VTK.API_vtkObject.DebugOff(obj);
}


//       Method: bool vtkObject::GetDebug()
// 
public bool GetDebug() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.GetDebug(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkObject::SetDebug(bool debugFlag)
// 
public void SetDebug(bool debugFlag) {
	VTK.API_vtkObject.SetDebug(obj, debugFlag);
}


//       Method: static void vtkObject::BreakOnError()
// 
public static void BreakOnError() {
	VTK.API_vtkObject.BreakOnError();
}


//       Method: virtual void vtkObject::Modified()
// 
public void Modified() {
	VTK.API_vtkObject.Modified(obj);
}


//       Method: virtual vtkMTimeType vtkObject::GetMTime()
// 
public ulong GetMTime() {
	int numElements = 1;
	ulong example = new ulong();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.GetMTime(p,obj);
	// UNSPECIFIED TYPE
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkObject::SetGlobalWarningDisplay(int val)
// 
public static void SetGlobalWarningDisplay(int val) {
	VTK.API_vtkObject.SetGlobalWarningDisplay(val);
}


//       Method: static void vtkObject::GlobalWarningDisplayOn()
// 
public static void GlobalWarningDisplayOn() {
	VTK.API_vtkObject.GlobalWarningDisplayOn();
}


//       Method: static void vtkObject::GlobalWarningDisplayOff()
// 
public static void GlobalWarningDisplayOff() {
	VTK.API_vtkObject.GlobalWarningDisplayOff();
}


//       Method: static int vtkObject::GetGlobalWarningDisplay()
// 
public static int GetGlobalWarningDisplay() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.GetGlobalWarningDisplay(p);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkCommand * vtkObject::GetCommand(unsigned long tag)
// 
public vtkCommand GetCommand(ulong tag) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.GetCommand(p,obj, tag);
	vtkCommand result = new vtkCommand();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkObject::RemoveObserver(vtkCommand* ARG_0)
// 
public void RemoveObserver(vtkCommand/*vtkCommand* */ ARG_0) {
	VTK.API_vtkObject.RemoveObserver(obj, ARG_0);
}


//       Method: void vtkObject::RemoveObservers(unsigned long evt, vtkCommand* ARG_0)
// 
public void RemoveObservers(ulong evt, vtkCommand/*vtkCommand* */ ARG_0) {
	VTK.API_vtkObject.RemoveObservers(obj, evt, ARG_0);
}


//       Method: void vtkObject::RemoveObservers(const char* evt, vtkCommand* ARG_0)
// 
public void RemoveObservers(string/*const char* */ evt, vtkCommand/*vtkCommand* */ ARG_0) {
	VTK.API_vtkObject.RemoveObservers(obj, evt, ARG_0);
}


//       Method: int vtkObject::HasObserver(unsigned long evt, vtkCommand* ARG_0)
// 
public int HasObserver(ulong evt, vtkCommand/*vtkCommand* */ ARG_0) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.HasObserver(p,obj, evt, ARG_0);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::HasObserver(const char* evt, vtkCommand* ARG_0)
// 
public int HasObserver(string/*const char* */ evt, vtkCommand/*vtkCommand* */ ARG_0) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.HasObserver(p,obj, evt, ARG_0);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkObject::RemoveObserver(unsigned long tag)
// 
public void RemoveObserver(ulong tag) {
	VTK.API_vtkObject.RemoveObserver(obj, tag);
}


//       Method: void vtkObject::RemoveObservers(unsigned long evt)
// 
public void RemoveObservers(ulong evt) {
	VTK.API_vtkObject.RemoveObservers(obj, evt);
}


//       Method: void vtkObject::RemoveObservers(const char* evt)
// 
public void RemoveObservers(string/*const char* */ evt) {
	VTK.API_vtkObject.RemoveObservers(obj, evt);
}


//       Method: void vtkObject::RemoveAllObservers()
// 
public void RemoveAllObservers() {
	VTK.API_vtkObject.RemoveAllObservers(obj);
}


//       Method: int vtkObject::HasObserver(unsigned long evt)
// 
public int HasObserver(ulong evt) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.HasObserver(p,obj, evt);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::HasObserver(const char* evt)
// 
public int HasObserver(string/*const char* */ evt) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.HasObserver(p,obj, evt);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::InvokeEvent(unsigned long evt, void* callData)
// 
public int InvokeEvent(ulong evt, IntPtr/*void* */ callData) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.InvokeEvent(p,obj, evt, callData);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::InvokeEvent(const char* evt, void* callData)
// 
public int InvokeEvent(string/*const char* */ evt, IntPtr/*void* */ callData) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.InvokeEvent(p,obj, evt, callData);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::InvokeEvent(unsigned long evt)
// 
public int InvokeEvent(ulong evt) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.InvokeEvent(p,obj, evt);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkObject::InvokeEvent(const char* evt)
// 
public int InvokeEvent(string/*const char* */ evt) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkObject.InvokeEvent(p,obj, evt);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
