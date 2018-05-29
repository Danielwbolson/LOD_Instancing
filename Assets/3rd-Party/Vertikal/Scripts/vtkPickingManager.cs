

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPickingManager : vtkObject {
		public vtkPickingManager(IntPtr p) : base(p) {}
		public static implicit operator  vtkPickingManager(IntPtr p) {return new vtkPickingManager(p);}
		public static implicit operator  IntPtr(vtkPickingManager o) {return o.GetPtr();}

// static vtkPickingManager* New()
// "static vtkPickingManager *New()"
public static vtkPickingManager New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPickingManager.New_0(returnPointer.GetPtr());
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPickingManager* SafeDownCast(vtkObjectBase * o)
// "static vtkPickingManager* SafeDownCast(vtkObjectBase *o)"
public static vtkPickingManager SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPickingManager.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// vtkPickingManager* NewInstance()
// "vtkPickingManager *NewInstance()"
public vtkPickingManager NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPickingManager.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// virtual void EnabledOn()
// "virtual void EnabledOn ()"
public void EnabledOn() {
	VTK_API.API_vtkPickingManager.EnabledOn_0(this);
}


// virtual void EnabledOff()
// "virtual void EnabledOff ()"
public void EnabledOff() {
	VTK_API.API_vtkPickingManager.EnabledOff_0(this);
}


// virtual void SetEnabled(bool _arg)
// "virtual void SetEnabled (bool _arg)"
public void SetEnabled(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkPickingManager.SetEnabled_0(this, _arg);
}


// virtual bool GetEnabled()
// "virtual bool GetEnabled ()"
public bool GetEnabled() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.GetEnabled_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void SetOptimizeOnInteractorEvents(bool optimize)
// "void SetOptimizeOnInteractorEvents(bool optimize)"
public void SetOptimizeOnInteractorEvents(bool /*(bool)*/ optimize) {
	VTK_API.API_vtkPickingManager.SetOptimizeOnInteractorEvents_0(this, optimize);
}


// virtual bool GetOptimizeOnInteractorEvents()
// "virtual bool GetOptimizeOnInteractorEvents ()"
public bool GetOptimizeOnInteractorEvents() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.GetOptimizeOnInteractorEvents_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void SetInteractor(vtkRenderWindowInteractor * iren)
// "void SetInteractor(vtkRenderWindowInteractor* iren)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ iren) {
	VTK_API.API_vtkPickingManager.SetInteractor_0(this, iren);
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor* GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPickingManager.GetInteractor_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// void RemoveObject(vtkObject * object)
// "void RemoveObject(vtkObject* object)"
public void RemoveObject(vtkObject /*(vtkObject*)*/ obj) {
	VTK_API.API_vtkPickingManager.RemoveObject_0(this, obj);
}


// bool Pick(vtkAbstractPicker * picker, vtkObject * object)
// "bool Pick(vtkAbstractPicker* picker, vtkObject* object)"
public bool Pick(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker, vtkObject /*(vtkObject*)*/ obj) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.Pick_0(returnPointer.GetPtr(), this, picker, obj);
	return (bool)returnPointer;
}


// bool Pick(vtkObject * object)
// "bool Pick(vtkObject* object)"
public bool Pick(vtkObject /*(vtkObject*)*/ obj) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.Pick_1(returnPointer.GetPtr(), this, obj);
	return (bool)returnPointer;
}


// bool Pick(vtkAbstractPicker * picker)
// "bool Pick(vtkAbstractPicker* picker)"
public bool Pick(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPickingManager.Pick_2(returnPointer.GetPtr(), this, picker);
	return (bool)returnPointer;
}


// vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker * picker, vtkRenderer * renderer, vtkObject * obj)
// "vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker* picker, vtkRenderer* renderer, vtkObject* obj)"
public vtkAssemblyPath GetAssemblyPath(double /*(double)*/ X, double /*(double)*/ Y, double /*(double)*/ Z, vtkAbstractPropPicker /*(vtkAbstractPropPicker*)*/ picker, vtkRenderer /*(vtkRenderer*)*/ renderer, vtkObject /*(vtkObject*)*/ obj) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPickingManager.GetAssemblyPath_0(returnPointer.GetPtr(), this, X, Y, Z, picker, renderer, obj);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// int GetNumberOfPickers()
// "int GetNumberOfPickers()"
public int GetNumberOfPickers() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPickingManager.GetNumberOfPickers_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfObjectsLinked(vtkAbstractPicker * picker)
// "int GetNumberOfObjectsLinked(vtkAbstractPicker* picker)"
public int GetNumberOfObjectsLinked(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPickingManager.GetNumberOfObjectsLinked_0(returnPointer.GetPtr(), this, picker);
	return (int)returnPointer;
}


}
};
