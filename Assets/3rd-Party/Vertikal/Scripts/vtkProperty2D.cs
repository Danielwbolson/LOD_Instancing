

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProperty2D : vtkObject {
		public vtkProperty2D(IntPtr p) : base(p) {}
		public static implicit operator  vtkProperty2D(IntPtr p) {return new vtkProperty2D(p);}
		public static implicit operator  IntPtr(vtkProperty2D o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty2D.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty2D.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProperty2D* SafeDownCast(vtkObjectBase * o)
// "static vtkProperty2D* SafeDownCast(vtkObjectBase *o)"
public static vtkProperty2D SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty2D.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProperty2D)(IntPtr)returnPointer;
}


// vtkProperty2D* NewInstance()
// "vtkProperty2D *NewInstance()"
public vtkProperty2D NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty2D.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProperty2D)(IntPtr)returnPointer;
}


// static vtkProperty2D* New()
// "static vtkProperty2D *New()"
public static vtkProperty2D New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty2D.New_0(returnPointer.GetPtr());
	return (vtkProperty2D)(IntPtr)returnPointer;
}


// void DeepCopy(vtkProperty2D * p)
// "void DeepCopy(vtkProperty2D *p)"
public void DeepCopy(vtkProperty2D /*(vtkProperty2D*)*/ p) {
	VTK_API.API_vtkProperty2D.DeepCopy_0(this, p);
}


// virtual void SetColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetColor (double _arg1, double _arg2, double _arg3)"
public void SetColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty2D.SetColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetColor(double _arg[3])
// "virtual void SetColor (double _arg[3])"
public void SetColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty2D.SetColor_1(this, _arg);
}


// virtual double* GetColor()
// "virtual double *GetColor ()"
public IntPtr GetColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty2D.GetColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty2D.GetColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetColor(double _arg[3])
// "virtual void GetColor (double _arg[3])"
public void GetColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty2D.GetColor_2(this, _arg);
}


// virtual double GetOpacity()
// "virtual double GetOpacity ()"
public double GetOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty2D.GetOpacity_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetOpacity(double _arg)
// "virtual void SetOpacity (double _arg)"
public void SetOpacity(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetOpacity_0(this, _arg);
}


// virtual void SetPointSize(float _arg)
// "virtual void SetPointSize (float _arg)"
public void SetPointSize(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetPointSize_0(this, _arg);
}


// virtual float GetPointSizeMinValue()
// "virtual float GetPointSizeMinValue ()"
public float GetPointSizeMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetPointSizeMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetPointSizeMaxValue()
// "virtual float GetPointSizeMaxValue ()"
public float GetPointSizeMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetPointSizeMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetPointSize()
// "virtual float GetPointSize ()"
public float GetPointSize() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetPointSize_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetLineWidth(float _arg)
// "virtual void SetLineWidth (float _arg)"
public void SetLineWidth(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetLineWidth_0(this, _arg);
}


// virtual float GetLineWidthMinValue()
// "virtual float GetLineWidthMinValue ()"
public float GetLineWidthMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetLineWidthMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetLineWidthMaxValue()
// "virtual float GetLineWidthMaxValue ()"
public float GetLineWidthMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetLineWidthMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetLineWidth()
// "virtual float GetLineWidth ()"
public float GetLineWidth() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty2D.GetLineWidth_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetLineStipplePattern(int _arg)
// "virtual void SetLineStipplePattern (int _arg)"
public void SetLineStipplePattern(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetLineStipplePattern_0(this, _arg);
}


// virtual int GetLineStipplePattern()
// "virtual int GetLineStipplePattern ()"
public int GetLineStipplePattern() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetLineStipplePattern_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetLineStippleRepeatFactor(int _arg)
// "virtual void SetLineStippleRepeatFactor (int _arg)"
public void SetLineStippleRepeatFactor(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetLineStippleRepeatFactor_0(this, _arg);
}


// virtual int GetLineStippleRepeatFactorMinValue()
// "virtual int GetLineStippleRepeatFactorMinValue ()"
public int GetLineStippleRepeatFactorMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetLineStippleRepeatFactorMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLineStippleRepeatFactorMaxValue()
// "virtual int GetLineStippleRepeatFactorMaxValue ()"
public int GetLineStippleRepeatFactorMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetLineStippleRepeatFactorMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLineStippleRepeatFactor()
// "virtual int GetLineStippleRepeatFactor ()"
public int GetLineStippleRepeatFactor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetLineStippleRepeatFactor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetDisplayLocation(int _arg)
// "virtual void SetDisplayLocation (int _arg)"
public void SetDisplayLocation(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty2D.SetDisplayLocation_0(this, _arg);
}


// virtual int GetDisplayLocationMinValue()
// "virtual int GetDisplayLocationMinValue ()"
public int GetDisplayLocationMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetDisplayLocationMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetDisplayLocationMaxValue()
// "virtual int GetDisplayLocationMaxValue ()"
public int GetDisplayLocationMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetDisplayLocationMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetDisplayLocation()
// "virtual int GetDisplayLocation ()"
public int GetDisplayLocation() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty2D.GetDisplayLocation_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetDisplayLocationToBackground()
// "void SetDisplayLocationToBackground()"
public void SetDisplayLocationToBackground() {
	VTK_API.API_vtkProperty2D.SetDisplayLocationToBackground_0(this);
}


// void SetDisplayLocationToForeground()
// "void SetDisplayLocationToForeground()"
public void SetDisplayLocationToForeground() {
	VTK_API.API_vtkProperty2D.SetDisplayLocationToForeground_0(this);
}


// virtual void Render(vtkViewport * ARG_0)
// "virtual void Render (vtkViewport* )"
public void Render(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	VTK_API.API_vtkProperty2D.Render_0(this, ARG_0);
}


}
};
