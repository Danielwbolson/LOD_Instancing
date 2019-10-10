

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkColorTransferFunction : vtkScalarsToColors {
		public vtkColorTransferFunction(IntPtr p) : base(p) {}
		public static implicit operator  vtkColorTransferFunction(IntPtr p) {return new vtkColorTransferFunction(p);}
		public static implicit operator  IntPtr(vtkColorTransferFunction o) {return o.GetPtr();}

// static vtkColorTransferFunction* New()
// "static vtkColorTransferFunction *New()"
public static vtkColorTransferFunction New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.New_0(returnPointer.GetPtr());
	return (vtkColorTransferFunction)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkColorTransferFunction.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkColorTransferFunction.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkColorTransferFunction* SafeDownCast(vtkObjectBase * o)
// "static vtkColorTransferFunction* SafeDownCast(vtkObjectBase *o)"
public static vtkColorTransferFunction SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkColorTransferFunction)(IntPtr)returnPointer;
}


// vtkColorTransferFunction* NewInstance()
// "vtkColorTransferFunction *NewInstance()"
public vtkColorTransferFunction NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkColorTransferFunction)(IntPtr)returnPointer;
}


// void DeepCopy(vtkScalarsToColors * f)
// "void DeepCopy( vtkScalarsToColors *f )"
public void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ f) {
	VTK_API.API_vtkColorTransferFunction.DeepCopy_0(this, f);
}


// void ShallowCopy(vtkColorTransferFunction * f)
// "void ShallowCopy( vtkColorTransferFunction *f )"
public void ShallowCopy(vtkColorTransferFunction /*(vtkColorTransferFunction*)*/ f) {
	VTK_API.API_vtkColorTransferFunction.ShallowCopy_0(this, f);
}


// int GetSize()
// "int GetSize()"
public int GetSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int AddRGBPoint(double x, double r, double g, double b)
// "int AddRGBPoint( double x, double r, double g, double b )"
public int AddRGBPoint(double /*(double)*/ x, double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.AddRGBPoint_0(returnPointer.GetPtr(), this, x, r, g, b);
	return (int)returnPointer;
}


// int AddRGBPoint(double x, double r, double g, double b, double midpoint, double sharpness)
// "int AddRGBPoint( double x, double r, double g, double b, double midpoint, double sharpness )"
public int AddRGBPoint(double /*(double)*/ x, double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b, double /*(double)*/ midpoint, double /*(double)*/ sharpness) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.AddRGBPoint_1(returnPointer.GetPtr(), this, x, r, g, b, midpoint, sharpness);
	return (int)returnPointer;
}


// int AddHSVPoint(double x, double h, double s, double v)
// "int AddHSVPoint( double x, double h, double s, double v )"
public int AddHSVPoint(double /*(double)*/ x, double /*(double)*/ h, double /*(double)*/ s, double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.AddHSVPoint_0(returnPointer.GetPtr(), this, x, h, s, v);
	return (int)returnPointer;
}


// int AddHSVPoint(double x, double h, double s, double v, double midpoint, double sharpness)
// "int AddHSVPoint( double x, double h, double s, double v, double midpoint, double sharpness )"
public int AddHSVPoint(double /*(double)*/ x, double /*(double)*/ h, double /*(double)*/ s, double /*(double)*/ v, double /*(double)*/ midpoint, double /*(double)*/ sharpness) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.AddHSVPoint_1(returnPointer.GetPtr(), this, x, h, s, v, midpoint, sharpness);
	return (int)returnPointer;
}


// int RemovePoint(double x)
// "int RemovePoint( double x )"
public int RemovePoint(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.RemovePoint_0(returnPointer.GetPtr(), this, x);
	return (int)returnPointer;
}


// void AddRGBSegment(double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2)
// "void AddRGBSegment( double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2 )"
public void AddRGBSegment(double /*(double)*/ x1, double /*(double)*/ r1, double /*(double)*/ g1, double /*(double)*/ b1, double /*(double)*/ x2, double /*(double)*/ r2, double /*(double)*/ g2, double /*(double)*/ b2) {
	VTK_API.API_vtkColorTransferFunction.AddRGBSegment_0(this, x1, r1, g1, b1, x2, r2, g2, b2);
}


// void AddHSVSegment(double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2)
// "void AddHSVSegment( double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2 )"
public void AddHSVSegment(double /*(double)*/ x1, double /*(double)*/ h1, double /*(double)*/ s1, double /*(double)*/ v1, double /*(double)*/ x2, double /*(double)*/ h2, double /*(double)*/ s2, double /*(double)*/ v2) {
	VTK_API.API_vtkColorTransferFunction.AddHSVSegment_0(this, x1, h1, s1, v1, x2, h2, s2, v2);
}


// void RemoveAllPoints()
// "void RemoveAllPoints()"
public void RemoveAllPoints() {
	VTK_API.API_vtkColorTransferFunction.RemoveAllPoints_0(this);
}


// double* GetColor(double x)
// "double *GetColor(double x)"
public IntPtr GetColor(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetColor_0(returnPointer.GetPtr(), this, x);
	return (IntPtr)returnPointer;
}


// void GetColor(double x, double rgb[3])
// "void GetColor(double x, double rgb[3])"
public void GetColor(double /*(double)*/ x, double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkColorTransferFunction.GetColor_1(this, x, rgb);
}


// double GetRedValue(double x)
// "double GetRedValue( double x )"
public double GetRedValue(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkColorTransferFunction.GetRedValue_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// double GetGreenValue(double x)
// "double GetGreenValue( double x )"
public double GetGreenValue(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkColorTransferFunction.GetGreenValue_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// double GetBlueValue(double x)
// "double GetBlueValue( double x )"
public double GetBlueValue(double /*(double)*/ x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkColorTransferFunction.GetBlueValue_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// int GetNodeValue(int index, double val[6])
// "int GetNodeValue( int index, double val[6] )"
public int GetNodeValue(int /*(int)*/ index, double /*(double[6])*/ []val) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetNodeValue_0(returnPointer.GetPtr(), this, index, val);
	return (int)returnPointer;
}


// int SetNodeValue(int index, double val[6])
// "int SetNodeValue( int index, double val[6] )"
public int SetNodeValue(int /*(int)*/ index, double /*(double[6])*/ []val) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.SetNodeValue_0(returnPointer.GetPtr(), this, index, val);
	return (int)returnPointer;
}


// char* MapValue(double v)
// "unsigned char *MapValue(double v)"
public string MapValue(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.MapValue_0(returnPointer.GetPtr(), this, v);
	return (string)returnPointer;
}


// double* GetRange()
// "double* GetRange()"
public IntPtr GetRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetRange(double & arg1, double & arg2)
// "virtual void GetRange(double& arg1, double& arg2)"
public void GetRange(IntPtr /*(double&)*/ arg1, IntPtr /*(double&)*/ arg2) {
	VTK_API.API_vtkColorTransferFunction.GetRange_1(this, arg1, arg2);
}


// virtual void GetRange(double _arg[2])
// "virtual void GetRange(double _arg[2])"
public void GetRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.GetRange_2(this, _arg);
}


// int AdjustRange(double range[2])
// "int AdjustRange(double range[2])"
public int AdjustRange(double /*(double[2])*/ []range) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.AdjustRange_0(returnPointer.GetPtr(), this, range);
	return (int)returnPointer;
}


// void GetTable(double x1, double x2, int n, double * table)
// "void GetTable( double x1, double x2, int n, double* table )"
public void GetTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ n, IntPtr /*(double*)*/ table) {
	VTK_API.API_vtkColorTransferFunction.GetTable_0(this, x1, x2, n, table);
}


// char* GetTable(double x1, double x2, int n)
// "const unsigned char *GetTable( double x1, double x2, int n )"
public string GetTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ n) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetTable_2(returnPointer.GetPtr(), this, x1, x2, n);
	return (string)returnPointer;
}


// void BuildFunctionFromTable(double x1, double x2, int size, double * table)
// "void BuildFunctionFromTable( double x1, double x2, int size, double *table )"
public void BuildFunctionFromTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, IntPtr /*(double*)*/ table) {
	VTK_API.API_vtkColorTransferFunction.BuildFunctionFromTable_0(this, x1, x2, size, table);
}


// virtual void SetClamping(int _arg)
// "virtual void SetClamping (int _arg)"
public void SetClamping(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetClamping_0(this, _arg);
}


// virtual int GetClampingMinValue()
// "virtual int GetClampingMinValue ()"
public int GetClampingMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetClampingMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetClampingMaxValue()
// "virtual int GetClampingMaxValue ()"
public int GetClampingMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetClampingMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetClamping()
// "virtual int GetClamping ()"
public int GetClamping() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetClamping_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ClampingOn()
// "virtual void ClampingOn ()"
public void ClampingOn() {
	VTK_API.API_vtkColorTransferFunction.ClampingOn_0(this);
}


// virtual void ClampingOff()
// "virtual void ClampingOff ()"
public void ClampingOff() {
	VTK_API.API_vtkColorTransferFunction.ClampingOff_0(this);
}


// virtual void SetColorSpace(int _arg)
// "virtual void SetColorSpace (int _arg)"
public void SetColorSpace(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetColorSpace_0(this, _arg);
}


// virtual int GetColorSpaceMinValue()
// "virtual int GetColorSpaceMinValue ()"
public int GetColorSpaceMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetColorSpaceMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetColorSpaceMaxValue()
// "virtual int GetColorSpaceMaxValue ()"
public int GetColorSpaceMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetColorSpaceMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetColorSpaceToRGB()
// "void SetColorSpaceToRGB()"
public void SetColorSpaceToRGB() {
	VTK_API.API_vtkColorTransferFunction.SetColorSpaceToRGB_0(this);
}


// void SetColorSpaceToHSV()
// "void SetColorSpaceToHSV()"
public void SetColorSpaceToHSV() {
	VTK_API.API_vtkColorTransferFunction.SetColorSpaceToHSV_0(this);
}


// void SetColorSpaceToLab()
// "void SetColorSpaceToLab()"
public void SetColorSpaceToLab() {
	VTK_API.API_vtkColorTransferFunction.SetColorSpaceToLab_0(this);
}


// void SetColorSpaceToLabCIEDE2000()
// "void SetColorSpaceToLabCIEDE2000()"
public void SetColorSpaceToLabCIEDE2000() {
	VTK_API.API_vtkColorTransferFunction.SetColorSpaceToLabCIEDE2000_0(this);
}


// void SetColorSpaceToDiverging()
// "void SetColorSpaceToDiverging()"
public void SetColorSpaceToDiverging() {
	VTK_API.API_vtkColorTransferFunction.SetColorSpaceToDiverging_0(this);
}


// virtual int GetColorSpace()
// "virtual int GetColorSpace ()"
public int GetColorSpace() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetColorSpace_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetHSVWrap(int _arg)
// "virtual void SetHSVWrap (int _arg)"
public void SetHSVWrap(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetHSVWrap_0(this, _arg);
}


// virtual int GetHSVWrap()
// "virtual int GetHSVWrap ()"
public int GetHSVWrap() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetHSVWrap_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void HSVWrapOn()
// "virtual void HSVWrapOn ()"
public void HSVWrapOn() {
	VTK_API.API_vtkColorTransferFunction.HSVWrapOn_0(this);
}


// virtual void HSVWrapOff()
// "virtual void HSVWrapOff ()"
public void HSVWrapOff() {
	VTK_API.API_vtkColorTransferFunction.HSVWrapOff_0(this);
}


// virtual void SetScale(int _arg)
// "virtual void SetScale (int _arg)"
public void SetScale(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetScale_0(this, _arg);
}


// void SetScaleToLinear()
// "void SetScaleToLinear()"
public void SetScaleToLinear() {
	VTK_API.API_vtkColorTransferFunction.SetScaleToLinear_0(this);
}


// void SetScaleToLog10()
// "void SetScaleToLog10()"
public void SetScaleToLog10() {
	VTK_API.API_vtkColorTransferFunction.SetScaleToLog10_0(this);
}


// virtual int GetScale()
// "virtual int GetScale ()"
public int GetScale() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetScale_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetNanColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetNanColor (double _arg1, double _arg2, double _arg3)"
public void SetNanColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.SetNanColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetNanColor(double _arg[3])
// "virtual void SetNanColor (double _arg[3])"
public void SetNanColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.SetNanColor_1(this, _arg);
}


// virtual double* GetNanColor()
// "virtual double *GetNanColor ()"
public IntPtr GetNanColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetNanColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetNanColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetNanColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetNanColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.GetNanColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetNanColor(double _arg[3])
// "virtual void GetNanColor (double _arg[3])"
public void GetNanColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.GetNanColor_2(this, _arg);
}


// virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetBelowRangeColor (double _arg1, double _arg2, double _arg3)"
public void SetBelowRangeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.SetBelowRangeColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetBelowRangeColor(double _arg[3])
// "virtual void SetBelowRangeColor (double _arg[3])"
public void SetBelowRangeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.SetBelowRangeColor_1(this, _arg);
}


// virtual double* GetBelowRangeColor()
// "virtual double *GetBelowRangeColor ()"
public IntPtr GetBelowRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetBelowRangeColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetBelowRangeColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetBelowRangeColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetBelowRangeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.GetBelowRangeColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetBelowRangeColor(double _arg[3])
// "virtual void GetBelowRangeColor (double _arg[3])"
public void GetBelowRangeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.GetBelowRangeColor_2(this, _arg);
}


// virtual void SetUseBelowRangeColor(int _arg)
// "virtual void SetUseBelowRangeColor (int _arg)"
public void SetUseBelowRangeColor(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetUseBelowRangeColor_0(this, _arg);
}


// virtual int GetUseBelowRangeColor()
// "virtual int GetUseBelowRangeColor ()"
public int GetUseBelowRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetUseBelowRangeColor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseBelowRangeColorOn()
// "virtual void UseBelowRangeColorOn ()"
public void UseBelowRangeColorOn() {
	VTK_API.API_vtkColorTransferFunction.UseBelowRangeColorOn_0(this);
}


// virtual void UseBelowRangeColorOff()
// "virtual void UseBelowRangeColorOff ()"
public void UseBelowRangeColorOff() {
	VTK_API.API_vtkColorTransferFunction.UseBelowRangeColorOff_0(this);
}


// virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetAboveRangeColor (double _arg1, double _arg2, double _arg3)"
public void SetAboveRangeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.SetAboveRangeColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAboveRangeColor(double _arg[3])
// "virtual void SetAboveRangeColor (double _arg[3])"
public void SetAboveRangeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.SetAboveRangeColor_1(this, _arg);
}


// virtual double* GetAboveRangeColor()
// "virtual double *GetAboveRangeColor ()"
public IntPtr GetAboveRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetAboveRangeColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAboveRangeColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetAboveRangeColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetAboveRangeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkColorTransferFunction.GetAboveRangeColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetAboveRangeColor(double _arg[3])
// "virtual void GetAboveRangeColor (double _arg[3])"
public void GetAboveRangeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkColorTransferFunction.GetAboveRangeColor_2(this, _arg);
}


// virtual void SetUseAboveRangeColor(int _arg)
// "virtual void SetUseAboveRangeColor (int _arg)"
public void SetUseAboveRangeColor(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetUseAboveRangeColor_0(this, _arg);
}


// virtual int GetUseAboveRangeColor()
// "virtual int GetUseAboveRangeColor ()"
public int GetUseAboveRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetUseAboveRangeColor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseAboveRangeColorOn()
// "virtual void UseAboveRangeColorOn ()"
public void UseAboveRangeColorOn() {
	VTK_API.API_vtkColorTransferFunction.UseAboveRangeColorOn_0(this);
}


// virtual void UseAboveRangeColorOff()
// "virtual void UseAboveRangeColorOff ()"
public void UseAboveRangeColorOff() {
	VTK_API.API_vtkColorTransferFunction.UseAboveRangeColorOff_0(this);
}


// double* GetDataPointer()
// "double* GetDataPointer()"
public IntPtr GetDataPointer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkColorTransferFunction.GetDataPointer_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void FillFromDataPointer(int n, double * ptr)
// "void FillFromDataPointer(int n, double* ptr)"
public void FillFromDataPointer(int /*(int)*/ n, IntPtr /*(double*)*/ ptr) {
	VTK_API.API_vtkColorTransferFunction.FillFromDataPointer_0(this, n, ptr);
}


// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// "void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)"
public void MapScalarsThroughTable2(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement) {
	VTK_API.API_vtkColorTransferFunction.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
}


// virtual void SetAllowDuplicateScalars(int _arg)
// "virtual void SetAllowDuplicateScalars (int _arg)"
public void SetAllowDuplicateScalars(int /*(int)*/ _arg) {
	VTK_API.API_vtkColorTransferFunction.SetAllowDuplicateScalars_0(this, _arg);
}


// virtual int GetAllowDuplicateScalars()
// "virtual int GetAllowDuplicateScalars ()"
public int GetAllowDuplicateScalars() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.GetAllowDuplicateScalars_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AllowDuplicateScalarsOn()
// "virtual void AllowDuplicateScalarsOn ()"
public void AllowDuplicateScalarsOn() {
	VTK_API.API_vtkColorTransferFunction.AllowDuplicateScalarsOn_0(this);
}


// virtual void AllowDuplicateScalarsOff()
// "virtual void AllowDuplicateScalarsOff ()"
public void AllowDuplicateScalarsOff() {
	VTK_API.API_vtkColorTransferFunction.AllowDuplicateScalarsOff_0(this);
}


// vtkIdType GetNumberOfAvailableColors()
// "vtkIdType GetNumberOfAvailableColors()"
public long GetNumberOfAvailableColors() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkColorTransferFunction.GetNumberOfAvailableColors_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetIndexedColor(vtkIdType idx, double rgba[4])
// "void GetIndexedColor(vtkIdType idx, double rgba[4])"
public void GetIndexedColor(long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkColorTransferFunction.GetIndexedColor_0(this, idx, rgba);
}


// int EstimateMinNumberOfSamples(double const& x1, double const& x2)
// "int EstimateMinNumberOfSamples(double const & x1, double const & x2)"
public int EstimateMinNumberOfSamples(IntPtr /*(doubleconst&)*/ x1, IntPtr /*(doubleconst&)*/ x2) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkColorTransferFunction.EstimateMinNumberOfSamples_0(returnPointer.GetPtr(), this, x1, x2);
	return (int)returnPointer;
}


}
};
