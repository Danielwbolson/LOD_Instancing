

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGarbageCollector : vtkObject {
		public vtkGarbageCollector(IntPtr p) : base(p) {}
		public static implicit operator  vtkGarbageCollector(IntPtr p) {return new vtkGarbageCollector(p);}
		public static implicit operator  IntPtr(vtkGarbageCollector o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkGarbageCollector.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkGarbageCollector.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkGarbageCollector* SafeDownCast(vtkObjectBase * o)
// "static vtkGarbageCollector* SafeDownCast(vtkObjectBase *o)"
public static vtkGarbageCollector SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGarbageCollector.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkGarbageCollector)(IntPtr)returnPointer;
}


// vtkGarbageCollector* NewInstance()
// "vtkGarbageCollector *NewInstance()"
public vtkGarbageCollector NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGarbageCollector.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkGarbageCollector)(IntPtr)returnPointer;
}


// static vtkGarbageCollector* New()
// "static vtkGarbageCollector* New()"
public static vtkGarbageCollector New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkGarbageCollector.New_0(returnPointer.GetPtr());
	return (vtkGarbageCollector)(IntPtr)returnPointer;
}


// static void Collect()
// "static void Collect()"
public static void Collect() {
	VTK_API.API_vtkGarbageCollector.Collect_0();
}


// static void Collect(vtkObjectBase * root)
// "static void Collect(vtkObjectBase* root)"
public static void Collect(vtkObjectBase /*(vtkObjectBase*)*/ root) {
	VTK_API.API_vtkGarbageCollector.Collect_1(root);
}


// static void DeferredCollectionPush()
// "static void DeferredCollectionPush()"
public static void DeferredCollectionPush() {
	VTK_API.API_vtkGarbageCollector.DeferredCollectionPush_0();
}


// static void DeferredCollectionPop()
// "static void DeferredCollectionPop()"
public static void DeferredCollectionPop() {
	VTK_API.API_vtkGarbageCollector.DeferredCollectionPop_0();
}


// static void SetGlobalDebugFlag(bool flag)
// "static void SetGlobalDebugFlag(bool flag)"
public static void SetGlobalDebugFlag(bool /*(bool)*/ flag) {
	VTK_API.API_vtkGarbageCollector.SetGlobalDebugFlag_0(flag);
}


// static bool GetGlobalDebugFlag()
// "static bool GetGlobalDebugFlag()"
public static bool GetGlobalDebugFlag() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkGarbageCollector.GetGlobalDebugFlag_0(returnPointer.GetPtr());
	return (bool)returnPointer;
}


}
};
