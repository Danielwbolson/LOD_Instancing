

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkObserverMediator : vtkObject {
		public vtkObserverMediator(IntPtr p) : base(p) {}
		public static implicit operator  vtkObserverMediator(IntPtr p) {return new vtkObserverMediator(p);}
		public static implicit operator  IntPtr(vtkObserverMediator o) {return o.GetPtr();}

// static vtkObserverMediator* New()
// "static vtkObserverMediator *New()"
public static vtkObserverMediator New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObserverMediator.New_0(returnPointer.GetPtr());
	return (vtkObserverMediator)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkObserverMediator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkObserverMediator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkObserverMediator* SafeDownCast(vtkObjectBase * o)
// "static vtkObserverMediator* SafeDownCast(vtkObjectBase *o)"
public static vtkObserverMediator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObserverMediator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkObserverMediator)(IntPtr)returnPointer;
}


// vtkObserverMediator* NewInstance()
// "vtkObserverMediator *NewInstance()"
public vtkObserverMediator NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObserverMediator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkObserverMediator)(IntPtr)returnPointer;
}


// void SetInteractor(vtkRenderWindowInteractor * iren)
// "void SetInteractor(vtkRenderWindowInteractor* iren)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ iren) {
	VTK_API.API_vtkObserverMediator.SetInteractor_0(this, iren);
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor *GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkObserverMediator.GetInteractor_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// int RequestCursorShape(vtkInteractorObserver * ARG_0, int cursorShape)
// "int RequestCursorShape(vtkInteractorObserver*, int cursorShape)"
public int RequestCursorShape(vtkInteractorObserver /*(vtkInteractorObserver*)*/ ARG_0, int /*(int)*/ cursorShape) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkObserverMediator.RequestCursorShape_0(returnPointer.GetPtr(), this, ARG_0, cursorShape);
	return (int)returnPointer;
}


// void RemoveAllCursorShapeRequests(vtkInteractorObserver * ARG_0)
// "void RemoveAllCursorShapeRequests(vtkInteractorObserver*)"
public void RemoveAllCursorShapeRequests(vtkInteractorObserver /*(vtkInteractorObserver*)*/ ARG_0) {
	VTK_API.API_vtkObserverMediator.RemoveAllCursorShapeRequests_0(this, ARG_0);
}


}
};
