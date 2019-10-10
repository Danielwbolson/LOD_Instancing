

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCoordinate : vtkObject {
		public vtkCoordinate(IntPtr p) : base(p) {}
		public static implicit operator  vtkCoordinate(IntPtr p) {return new vtkCoordinate(p);}
		public static implicit operator  IntPtr(vtkCoordinate o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCoordinate.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCoordinate.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCoordinate* SafeDownCast(vtkObjectBase * o)
// "static vtkCoordinate* SafeDownCast(vtkObjectBase *o)"
public static vtkCoordinate SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// vtkCoordinate* NewInstance()
// "vtkCoordinate *NewInstance()"
public vtkCoordinate NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// static vtkCoordinate* New()
// "static vtkCoordinate* New()"
public static vtkCoordinate New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.New_0(returnPointer.GetPtr());
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// virtual void SetCoordinateSystem(int _arg)
// "virtual void SetCoordinateSystem (int _arg)"
public void SetCoordinateSystem(int /*(int)*/ _arg) {
	VTK_API.API_vtkCoordinate.SetCoordinateSystem_0(this, _arg);
}


// virtual int GetCoordinateSystem()
// "virtual int GetCoordinateSystem ()"
public int GetCoordinateSystem() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCoordinate.GetCoordinateSystem_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetCoordinateSystemToDisplay()
// "void SetCoordinateSystemToDisplay()"
public void SetCoordinateSystemToDisplay() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToDisplay_0(this);
}


// void SetCoordinateSystemToNormalizedDisplay()
// "void SetCoordinateSystemToNormalizedDisplay()"
public void SetCoordinateSystemToNormalizedDisplay() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToNormalizedDisplay_0(this);
}


// void SetCoordinateSystemToViewport()
// "void SetCoordinateSystemToViewport()"
public void SetCoordinateSystemToViewport() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToViewport_0(this);
}


// void SetCoordinateSystemToNormalizedViewport()
// "void SetCoordinateSystemToNormalizedViewport()"
public void SetCoordinateSystemToNormalizedViewport() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToNormalizedViewport_0(this);
}


// void SetCoordinateSystemToView()
// "void SetCoordinateSystemToView()"
public void SetCoordinateSystemToView() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToView_0(this);
}


// void SetCoordinateSystemToWorld()
// "void SetCoordinateSystemToWorld()"
public void SetCoordinateSystemToWorld() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToWorld_0(this);
}


// char* GetCoordinateSystemAsString()
// "const char *GetCoordinateSystemAsString ()"
public string GetCoordinateSystemAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetCoordinateSystemAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetValue(double _arg1, double _arg2, double _arg3)
// "virtual void SetValue (double _arg1, double _arg2, double _arg3)"
public void SetValue(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkCoordinate.SetValue_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetValue(double _arg[3])
// "virtual void SetValue (double _arg[3])"
public void SetValue(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCoordinate.SetValue_1(this, _arg);
}


// virtual double* GetValue()
// "virtual double *GetValue ()"
public IntPtr GetValue() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetValue_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetValue(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetValue (double &_arg1, double &_arg2, double &_arg3)"
public void GetValue(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCoordinate.GetValue_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetValue(double _arg[3])
// "virtual void GetValue (double _arg[3])"
public void GetValue(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCoordinate.GetValue_2(this, _arg);
}


// void SetValue(double a, double b)
// "void SetValue(double a, double b)"
public void SetValue(double /*(double)*/ a, double /*(double)*/ b) {
	VTK_API.API_vtkCoordinate.SetValue_2(this, a, b);
}


// virtual void SetReferenceCoordinate(vtkCoordinate * ARG_0)
// "virtual void SetReferenceCoordinate(vtkCoordinate*)"
public void SetReferenceCoordinate(vtkCoordinate /*(vtkCoordinate*)*/ ARG_0) {
	VTK_API.API_vtkCoordinate.SetReferenceCoordinate_0(this, ARG_0);
}


// virtual vtkCoordinate* GetReferenceCoordinate()
// "virtual vtkCoordinate *GetReferenceCoordinate ()"
public vtkCoordinate GetReferenceCoordinate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetReferenceCoordinate_0(returnPointer.GetPtr(), this);
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// void SetViewport(vtkViewport * viewport)
// "void SetViewport(vtkViewport *viewport)"
public void SetViewport(vtkViewport /*(vtkViewport*)*/ viewport) {
	VTK_API.API_vtkCoordinate.SetViewport_0(this, viewport);
}


// virtual vtkViewport* GetViewport()
// "virtual vtkViewport *GetViewport ()"
public vtkViewport GetViewport() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetViewport_0(returnPointer.GetPtr(), this);
	return (vtkViewport)(IntPtr)returnPointer;
}


// double* GetComputedWorldValue(vtkViewport * ARG_0)
// "double *GetComputedWorldValue(vtkViewport *)"
public IntPtr GetComputedWorldValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedWorldValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// int* GetComputedViewportValue(vtkViewport * ARG_0)
// "int *GetComputedViewportValue(vtkViewport *)"
public IntPtr GetComputedViewportValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedViewportValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// int* GetComputedDisplayValue(vtkViewport * ARG_0)
// "int *GetComputedDisplayValue(vtkViewport *)"
public IntPtr GetComputedDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedDisplayValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// int* GetComputedLocalDisplayValue(vtkViewport * ARG_0)
// "int *GetComputedLocalDisplayValue(vtkViewport *)"
public IntPtr GetComputedLocalDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedLocalDisplayValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// double* GetComputedDoubleViewportValue(vtkViewport * ARG_0)
// "double *GetComputedDoubleViewportValue(vtkViewport *)"
public IntPtr GetComputedDoubleViewportValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedDoubleViewportValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// double* GetComputedDoubleDisplayValue(vtkViewport * ARG_0)
// "double *GetComputedDoubleDisplayValue(vtkViewport *)"
public IntPtr GetComputedDoubleDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedDoubleDisplayValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// double* GetComputedValue(vtkViewport * ARG_0)
// "double *GetComputedValue(vtkViewport *)"
public IntPtr GetComputedValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// virtual double* GetComputedUserDefinedValue(vtkViewport * ARG_0)
// "virtual double *GetComputedUserDefinedValue(vtkViewport *)"
public IntPtr GetComputedUserDefinedValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCoordinate.GetComputedUserDefinedValue_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


}
};
