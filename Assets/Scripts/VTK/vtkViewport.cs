

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkViewport : vtkObject {
		public vtkViewport(IntPtr p) : base(p) {}
		public static implicit operator  vtkViewport(IntPtr p) {return new vtkViewport(p);}
		public static implicit operator  IntPtr(vtkViewport o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkViewport.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkViewport.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkViewport* SafeDownCast(vtkObjectBase * o)
// "static vtkViewport* SafeDownCast(vtkObjectBase *o)"
public static vtkViewport SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkViewport)(IntPtr)returnPointer;
}


// vtkViewport* NewInstance()
// "vtkViewport *NewInstance()"
public vtkViewport NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkViewport)(IntPtr)returnPointer;
}


// void AddViewProp(vtkProp * ARG_0)
// "void AddViewProp(vtkProp *)"
public void AddViewProp(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkViewport.AddViewProp_0(this, ARG_0);
}


// vtkPropCollection* GetViewProps()
// "vtkPropCollection *GetViewProps()"
public vtkPropCollection GetViewProps() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetViewProps_0(returnPointer.GetPtr(), this);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// int HasViewProp(vtkProp * ARG_0)
// "int HasViewProp(vtkProp *)"
public int HasViewProp(vtkProp /*(vtkProp*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkViewport.HasViewProp_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// void RemoveViewProp(vtkProp * ARG_0)
// "void RemoveViewProp(vtkProp *)"
public void RemoveViewProp(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkViewport.RemoveViewProp_0(this, ARG_0);
}


// void RemoveAllViewProps()
// "void RemoveAllViewProps(void)"
public void RemoveAllViewProps() {
	VTK_API.API_vtkViewport.RemoveAllViewProps_0(this);
}


// void AddActor2D(vtkProp * p)
// "void AddActor2D(vtkProp* p)"
public void AddActor2D(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkViewport.AddActor2D_0(this, p);
}


// void RemoveActor2D(vtkProp * p)
// "void RemoveActor2D(vtkProp* p)"
public void RemoveActor2D(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkViewport.RemoveActor2D_0(this, p);
}


// vtkActor2DCollection* GetActors2D()
// "vtkActor2DCollection *GetActors2D()"
public vtkActor2DCollection GetActors2D() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetActors2D_0(returnPointer.GetPtr(), this);
	return (vtkActor2DCollection)(IntPtr)returnPointer;
}


// virtual void SetBackground(double _arg1, double _arg2, double _arg3)
// "virtual void SetBackground (double _arg1, double _arg2, double _arg3)"
public void SetBackground(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkViewport.SetBackground_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetBackground(double _arg[3])
// "virtual void SetBackground (double _arg[3])"
public void SetBackground(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.SetBackground_1(this, _arg);
}


// virtual double* GetBackground()
// "virtual double *GetBackground ()"
public IntPtr GetBackground() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetBackground_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetBackground(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetBackground (double &_arg1, double &_arg2, double &_arg3)"
public void GetBackground(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkViewport.GetBackground_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetBackground(double _arg[3])
// "virtual void GetBackground (double _arg[3])"
public void GetBackground(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.GetBackground_2(this, _arg);
}


// virtual void SetBackground2(double _arg1, double _arg2, double _arg3)
// "virtual void SetBackground2 (double _arg1, double _arg2, double _arg3)"
public void SetBackground2(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkViewport.SetBackground2_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetBackground2(double _arg[3])
// "virtual void SetBackground2 (double _arg[3])"
public void SetBackground2(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.SetBackground2_1(this, _arg);
}


// virtual double* GetBackground2()
// "virtual double *GetBackground2 ()"
public IntPtr GetBackground2() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetBackground2_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetBackground2(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetBackground2 (double &_arg1, double &_arg2, double &_arg3)"
public void GetBackground2(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkViewport.GetBackground2_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetBackground2(double _arg[3])
// "virtual void GetBackground2 (double _arg[3])"
public void GetBackground2(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.GetBackground2_2(this, _arg);
}


// virtual void SetBackgroundAlpha(double _arg)
// "virtual void SetBackgroundAlpha (double _arg)"
public void SetBackgroundAlpha(double /*(double)*/ _arg) {
	VTK_API.API_vtkViewport.SetBackgroundAlpha_0(this, _arg);
}


// virtual double GetBackgroundAlphaMinValue()
// "virtual double GetBackgroundAlphaMinValue ()"
public double GetBackgroundAlphaMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetBackgroundAlphaMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetBackgroundAlphaMaxValue()
// "virtual double GetBackgroundAlphaMaxValue ()"
public double GetBackgroundAlphaMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetBackgroundAlphaMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetBackgroundAlpha()
// "virtual double GetBackgroundAlpha ()"
public double GetBackgroundAlpha() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetBackgroundAlpha_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetGradientBackground(bool _arg)
// "virtual void SetGradientBackground (bool _arg)"
public void SetGradientBackground(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkViewport.SetGradientBackground_0(this, _arg);
}


// virtual bool GetGradientBackground()
// "virtual bool GetGradientBackground ()"
public bool GetGradientBackground() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkViewport.GetGradientBackground_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void GradientBackgroundOn()
// "virtual void GradientBackgroundOn ()"
public void GradientBackgroundOn() {
	VTK_API.API_vtkViewport.GradientBackgroundOn_0(this);
}


// virtual void GradientBackgroundOff()
// "virtual void GradientBackgroundOff ()"
public void GradientBackgroundOff() {
	VTK_API.API_vtkViewport.GradientBackgroundOff_0(this);
}


// virtual void SetAspect(double _arg1, double _arg2)
// "virtual void SetAspect (double _arg1, double _arg2)"
public void SetAspect(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkViewport.SetAspect_0(this, _arg1, _arg2);
}


// void SetAspect(double _arg[2])
// "void SetAspect (double _arg[2])"
public void SetAspect(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkViewport.SetAspect_1(this, _arg);
}


// virtual double* GetAspect()
// "virtual double *GetAspect ()"
public IntPtr GetAspect() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetAspect_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAspect(double data[2])
// "virtual void GetAspect (double data[2])"
public void GetAspect(double /*(double[2])*/ []data) {
	VTK_API.API_vtkViewport.GetAspect_1(this, data);
}


// virtual void ComputeAspect()
// "virtual void ComputeAspect()"
public void ComputeAspect() {
	VTK_API.API_vtkViewport.ComputeAspect_0(this);
}


// virtual void SetPixelAspect(double _arg1, double _arg2)
// "virtual void SetPixelAspect (double _arg1, double _arg2)"
public void SetPixelAspect(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkViewport.SetPixelAspect_0(this, _arg1, _arg2);
}


// void SetPixelAspect(double _arg[2])
// "void SetPixelAspect (double _arg[2])"
public void SetPixelAspect(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkViewport.SetPixelAspect_1(this, _arg);
}


// virtual double* GetPixelAspect()
// "virtual double *GetPixelAspect ()"
public IntPtr GetPixelAspect() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetPixelAspect_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetPixelAspect(double data[2])
// "virtual void GetPixelAspect (double data[2])"
public void GetPixelAspect(double /*(double[2])*/ []data) {
	VTK_API.API_vtkViewport.GetPixelAspect_1(this, data);
}


// virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetViewport (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetViewport(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkViewport.SetViewport_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetViewport(double _arg[4])
// "virtual void SetViewport (double _arg[4])"
public void SetViewport(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkViewport.SetViewport_1(this, _arg);
}


// virtual double* GetViewport()
// "virtual double *GetViewport ()"
public IntPtr GetViewport() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetViewport_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetViewport(double data[4])
// "virtual void GetViewport (double data[4])"
public void GetViewport(double /*(double[4])*/ []data) {
	VTK_API.API_vtkViewport.GetViewport_1(this, data);
}


// virtual void SetDisplayPoint(double _arg1, double _arg2, double _arg3)
// "virtual void SetDisplayPoint (double _arg1, double _arg2, double _arg3)"
public void SetDisplayPoint(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkViewport.SetDisplayPoint_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetDisplayPoint(double _arg[3])
// "virtual void SetDisplayPoint (double _arg[3])"
public void SetDisplayPoint(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.SetDisplayPoint_1(this, _arg);
}


// virtual double* GetDisplayPoint()
// "virtual double *GetDisplayPoint ()"
public IntPtr GetDisplayPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetDisplayPoint_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetDisplayPoint(double data[3])
// "virtual void GetDisplayPoint (double data[3])"
public void GetDisplayPoint(double /*(double[3])*/ []data) {
	VTK_API.API_vtkViewport.GetDisplayPoint_1(this, data);
}


// virtual void SetViewPoint(double _arg1, double _arg2, double _arg3)
// "virtual void SetViewPoint (double _arg1, double _arg2, double _arg3)"
public void SetViewPoint(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkViewport.SetViewPoint_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetViewPoint(double _arg[3])
// "virtual void SetViewPoint (double _arg[3])"
public void SetViewPoint(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkViewport.SetViewPoint_1(this, _arg);
}


// virtual double* GetViewPoint()
// "virtual double *GetViewPoint ()"
public IntPtr GetViewPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetViewPoint_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetViewPoint(double data[3])
// "virtual void GetViewPoint (double data[3])"
public void GetViewPoint(double /*(double[3])*/ []data) {
	VTK_API.API_vtkViewport.GetViewPoint_1(this, data);
}


// virtual void SetWorldPoint(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetWorldPoint (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetWorldPoint(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkViewport.SetWorldPoint_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetWorldPoint(double _arg[4])
// "virtual void SetWorldPoint (double _arg[4])"
public void SetWorldPoint(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkViewport.SetWorldPoint_1(this, _arg);
}


// virtual double* GetWorldPoint()
// "virtual double *GetWorldPoint ()"
public IntPtr GetWorldPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetWorldPoint_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetWorldPoint(double data[4])
// "virtual void GetWorldPoint (double data[4])"
public void GetWorldPoint(double /*(double[4])*/ []data) {
	VTK_API.API_vtkViewport.GetWorldPoint_1(this, data);
}


// virtual double* GetCenter()
// "virtual double *GetCenter()"
public IntPtr GetCenter() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetCenter_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual int IsInViewport(int x, int y)
// "virtual int IsInViewport(int x,int y)"
public int IsInViewport(int /*(int)*/ x, int /*(int)*/ y) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkViewport.IsInViewport_0(returnPointer.GetPtr(), this, x, y);
	return (int)returnPointer;
}


// virtual vtkWindow* GetVTKWindow()
// "virtual vtkWindow *GetVTKWindow()"
public vtkWindow GetVTKWindow() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetVTKWindow_0(returnPointer.GetPtr(), this);
	return (vtkWindow)(IntPtr)returnPointer;
}


// virtual void DisplayToView()
// "virtual void DisplayToView()"
public void DisplayToView() {
	VTK_API.API_vtkViewport.DisplayToView_0(this);
}


// virtual void ViewToDisplay()
// "virtual void ViewToDisplay()"
public void ViewToDisplay() {
	VTK_API.API_vtkViewport.ViewToDisplay_0(this);
}


// virtual void WorldToView()
// "virtual void WorldToView()"
public void WorldToView() {
	VTK_API.API_vtkViewport.WorldToView_0(this);
}


// virtual void ViewToWorld()
// "virtual void ViewToWorld()"
public void ViewToWorld() {
	VTK_API.API_vtkViewport.ViewToWorld_0(this);
}


// void DisplayToWorld()
// "void DisplayToWorld()"
public void DisplayToWorld() {
	VTK_API.API_vtkViewport.DisplayToWorld_0(this);
}


// void WorldToDisplay()
// "void WorldToDisplay()"
public void WorldToDisplay() {
	VTK_API.API_vtkViewport.WorldToDisplay_0(this);
}


// virtual void LocalDisplayToDisplay(double & x, double & y)
// "virtual void LocalDisplayToDisplay(double &x, double &y)"
public void LocalDisplayToDisplay(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y) {
	VTK_API.API_vtkViewport.LocalDisplayToDisplay_0(this, x, y);
}


// virtual void DisplayToNormalizedDisplay(double & u, double & v)
// "virtual void DisplayToNormalizedDisplay(double &u, double &v)"
public void DisplayToNormalizedDisplay(IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v) {
	VTK_API.API_vtkViewport.DisplayToNormalizedDisplay_0(this, u, v);
}


// virtual void NormalizedDisplayToViewport(double & x, double & y)
// "virtual void NormalizedDisplayToViewport(double &x, double &y)"
public void NormalizedDisplayToViewport(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y) {
	VTK_API.API_vtkViewport.NormalizedDisplayToViewport_0(this, x, y);
}


// virtual void ViewportToNormalizedViewport(double & u, double & v)
// "virtual void ViewportToNormalizedViewport(double &u, double &v)"
public void ViewportToNormalizedViewport(IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v) {
	VTK_API.API_vtkViewport.ViewportToNormalizedViewport_0(this, u, v);
}


// virtual void NormalizedViewportToView(double & x, double & y, double & z)
// "virtual void NormalizedViewportToView(double &x, double &y, double &z)"
public void NormalizedViewportToView(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y, IntPtr /*(double&)*/ z) {
	VTK_API.API_vtkViewport.NormalizedViewportToView_0(this, x, y, z);
}


// virtual void ViewToWorld(double & ARG_0, double & ARG_1, double & ARG_2)
// "virtual void ViewToWorld(double &, double &, double &)"
public void ViewToWorld(IntPtr /*(double&)*/ ARG_0, IntPtr /*(double&)*/ ARG_1, IntPtr /*(double&)*/ ARG_2) {
	VTK_API.API_vtkViewport.ViewToWorld_1(this, ARG_0, ARG_1, ARG_2);
}


// virtual void DisplayToLocalDisplay(double & x, double & y)
// "virtual void DisplayToLocalDisplay(double &x, double &y)"
public void DisplayToLocalDisplay(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y) {
	VTK_API.API_vtkViewport.DisplayToLocalDisplay_0(this, x, y);
}


// virtual void NormalizedDisplayToDisplay(double & u, double & v)
// "virtual void NormalizedDisplayToDisplay(double &u, double &v)"
public void NormalizedDisplayToDisplay(IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v) {
	VTK_API.API_vtkViewport.NormalizedDisplayToDisplay_0(this, u, v);
}


// virtual void ViewportToNormalizedDisplay(double & x, double & y)
// "virtual void ViewportToNormalizedDisplay(double &x, double &y)"
public void ViewportToNormalizedDisplay(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y) {
	VTK_API.API_vtkViewport.ViewportToNormalizedDisplay_0(this, x, y);
}


// virtual void NormalizedViewportToViewport(double & u, double & v)
// "virtual void NormalizedViewportToViewport(double &u, double &v)"
public void NormalizedViewportToViewport(IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v) {
	VTK_API.API_vtkViewport.NormalizedViewportToViewport_0(this, u, v);
}


// virtual void ViewToNormalizedViewport(double & x, double & y, double & z)
// "virtual void ViewToNormalizedViewport(double &x, double &y, double &z)"
public void ViewToNormalizedViewport(IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y, IntPtr /*(double&)*/ z) {
	VTK_API.API_vtkViewport.ViewToNormalizedViewport_0(this, x, y, z);
}


// virtual void WorldToView(double & ARG_0, double & ARG_1, double & ARG_2)
// "virtual void WorldToView(double &, double &, double &)"
public void WorldToView(IntPtr /*(double&)*/ ARG_0, IntPtr /*(double&)*/ ARG_1, IntPtr /*(double&)*/ ARG_2) {
	VTK_API.API_vtkViewport.WorldToView_1(this, ARG_0, ARG_1, ARG_2);
}


// virtual int* GetSize()
// "virtual int *GetSize()"
public IntPtr GetSize() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetSize_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual int* GetOrigin()
// "virtual int *GetOrigin()"
public IntPtr GetOrigin() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetOrigin_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetTiledSize(int * width, int * height)
// "void GetTiledSize(int *width, int *height)"
public void GetTiledSize(IntPtr /*(int*)*/ width, IntPtr /*(int*)*/ height) {
	VTK_API.API_vtkViewport.GetTiledSize_0(this, width, height);
}


// virtual void GetTiledSizeAndOrigin(int * width, int * height, int * lowerLeftX, int * lowerLeftY)
// "virtual void GetTiledSizeAndOrigin(int *width, int *height, int *lowerLeftX, int *lowerLeftY)"
public void GetTiledSizeAndOrigin(IntPtr /*(int*)*/ width, IntPtr /*(int*)*/ height, IntPtr /*(int*)*/ lowerLeftX, IntPtr /*(int*)*/ lowerLeftY) {
	VTK_API.API_vtkViewport.GetTiledSizeAndOrigin_0(this, width, height, lowerLeftX, lowerLeftY);
}


// virtual vtkAssemblyPath* PickProp(double selectionX, double selectionY)
// "virtual vtkAssemblyPath* PickProp(double selectionX, double selectionY)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX, double /*(double)*/ selectionY) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.PickProp_0(returnPointer.GetPtr(), this, selectionX, selectionY);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
// "virtual vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.PickProp_1(returnPointer.GetPtr(), this, selectionX1, selectionY1, selectionX2, selectionY2);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkAssemblyPath* PickPropFrom(double selectionX, double selectionY, vtkPropCollection * ARG_0)
// "vtkAssemblyPath* PickPropFrom(double selectionX, double selectionY, vtkPropCollection*)"
public vtkAssemblyPath PickPropFrom(double /*(double)*/ selectionX, double /*(double)*/ selectionY, vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.PickPropFrom_0(returnPointer.GetPtr(), this, selectionX, selectionY, ARG_0);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkAssemblyPath* PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection * ARG_0)
// "vtkAssemblyPath* PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection*)"
public vtkAssemblyPath PickPropFrom(double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2, vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.PickPropFrom_1(returnPointer.GetPtr(), this, selectionX1, selectionY1, selectionX2, selectionY2, ARG_0);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// double GetPickX()
// "double GetPickX()"
public double GetPickX() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickX_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickY()
// "double GetPickY()"
public double GetPickY() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickY_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickWidth()
// "double GetPickWidth()"
public double GetPickWidth() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickWidth_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickHeight()
// "double GetPickHeight()"
public double GetPickHeight() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickHeight_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickX1()
// "double GetPickX1()"
public double GetPickX1() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickX1_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickY1()
// "double GetPickY1()"
public double GetPickY1() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickY1_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickX2()
// "double GetPickX2()"
public double GetPickX2() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickX2_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetPickY2()
// "double GetPickY2()"
public double GetPickY2() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickY2_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual int GetIsPicking()
// "virtual int GetIsPicking ()"
public int GetIsPicking() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkViewport.GetIsPicking_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetCurrentPickId()
// "virtual unsigned int GetCurrentPickId ()"
public uint GetCurrentPickId() {
	ReturnPointer returnPointer = new ReturnPointer(new uint());
	VTK_API.API_vtkViewport.GetCurrentPickId_0(returnPointer.GetPtr(), this);
	return (uint)returnPointer;
}


// void SetCurrentPickId(unsigned int a)
// "void SetCurrentPickId(unsigned int a)"
public void SetCurrentPickId(uint /*(unsigned int)*/ a) {
	VTK_API.API_vtkViewport.SetCurrentPickId_0(this, a);
}


// virtual vtkPropCollection* GetPickResultProps()
// "virtual vtkPropCollection *GetPickResultProps ()"
public vtkPropCollection GetPickResultProps() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkViewport.GetPickResultProps_0(returnPointer.GetPtr(), this);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// virtual double GetPickedZ()
// "virtual double GetPickedZ()"
public double GetPickedZ() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkViewport.GetPickedZ_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


}
};
