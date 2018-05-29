

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLookupTable : vtkScalarsToColors {
		public vtkLookupTable(IntPtr p) : base(p) {}
		public static implicit operator  vtkLookupTable(IntPtr p) {return new vtkLookupTable(p);}
		public static implicit operator  IntPtr(vtkLookupTable o) {return o.GetPtr();}

// static vtkLookupTable* New()
// "static vtkLookupTable *New()"
public static vtkLookupTable New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.New_0(returnPointer.GetPtr());
	return (vtkLookupTable)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLookupTable.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLookupTable.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkLookupTable* SafeDownCast(vtkObjectBase * o)
// "static vtkLookupTable* SafeDownCast(vtkObjectBase *o)"
public static vtkLookupTable SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkLookupTable)(IntPtr)returnPointer;
}


// vtkLookupTable* NewInstance()
// "vtkLookupTable *NewInstance()"
public vtkLookupTable NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkLookupTable)(IntPtr)returnPointer;
}


// int IsOpaque()
// "int IsOpaque()"
public int IsOpaque() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.IsOpaque_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int Allocate(int sz = 256, int ext = 256)
// "int Allocate(int sz=256, int ext=256)"
public int Allocate(int /*(int)*/ sz, int /*(int)*/ ext) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void Build()
// "void Build()"
public void Build() {
	VTK_API.API_vtkLookupTable.Build_0(this);
}


// virtual void ForceBuild()
// "virtual void ForceBuild()"
public void ForceBuild() {
	VTK_API.API_vtkLookupTable.ForceBuild_0(this);
}


// void BuildSpecialColors()
// "void BuildSpecialColors()"
public void BuildSpecialColors() {
	VTK_API.API_vtkLookupTable.BuildSpecialColors_0(this);
}


// virtual void SetRamp(int _arg)
// "virtual void SetRamp (int _arg)"
public void SetRamp(int /*(int)*/ _arg) {
	VTK_API.API_vtkLookupTable.SetRamp_0(this, _arg);
}


// void SetRampToLinear()
// "void SetRampToLinear()"
public void SetRampToLinear() {
	VTK_API.API_vtkLookupTable.SetRampToLinear_0(this);
}


// void SetRampToSCurve()
// "void SetRampToSCurve()"
public void SetRampToSCurve() {
	VTK_API.API_vtkLookupTable.SetRampToSCurve_0(this);
}


// void SetRampToSQRT()
// "void SetRampToSQRT()"
public void SetRampToSQRT() {
	VTK_API.API_vtkLookupTable.SetRampToSQRT_0(this);
}


// virtual int GetRamp()
// "virtual int GetRamp ()"
public int GetRamp() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.GetRamp_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetScale(int scale)
// "void SetScale(int scale)"
public void SetScale(int /*(int)*/ scale) {
	VTK_API.API_vtkLookupTable.SetScale_0(this, scale);
}


// void SetScaleToLinear()
// "void SetScaleToLinear()"
public void SetScaleToLinear() {
	VTK_API.API_vtkLookupTable.SetScaleToLinear_0(this);
}


// void SetScaleToLog10()
// "void SetScaleToLog10()"
public void SetScaleToLog10() {
	VTK_API.API_vtkLookupTable.SetScaleToLog10_0(this);
}


// virtual int GetScale()
// "virtual int GetScale ()"
public int GetScale() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.GetScale_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetTableRange(const double r[2])
// "virtual void SetTableRange(const double r[2])"
public void SetTableRange(double /*(double[2])*/ []r) {
	VTK_API.API_vtkLookupTable.SetTableRange_0(this, r);
}


// virtual void SetTableRange(double min, double max)
// "virtual void SetTableRange(double min, double max)"
public void SetTableRange(double /*(double)*/ min, double /*(double)*/ max) {
	VTK_API.API_vtkLookupTable.SetTableRange_1(this, min, max);
}


// virtual double* GetTableRange()
// "virtual double *GetTableRange ()"
public IntPtr GetTableRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetTableRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetTableRange(double data[2])
// "virtual void GetTableRange (double data[2])"
public void GetTableRange(double /*(double[2])*/ []data) {
	VTK_API.API_vtkLookupTable.GetTableRange_1(this, data);
}


// virtual void SetHueRange(double _arg1, double _arg2)
// "virtual void SetHueRange (double _arg1, double _arg2)"
public void SetHueRange(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkLookupTable.SetHueRange_0(this, _arg1, _arg2);
}


// void SetHueRange(double _arg[2])
// "void SetHueRange (double _arg[2])"
public void SetHueRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetHueRange_1(this, _arg);
}


// virtual double* GetHueRange()
// "virtual double *GetHueRange ()"
public IntPtr GetHueRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetHueRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetHueRange(double & _arg1, double & _arg2)
// "virtual void GetHueRange (double &_arg1, double &_arg2)"
public void GetHueRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkLookupTable.GetHueRange_1(this, _arg1, _arg2);
}


// virtual void GetHueRange(double _arg[2])
// "virtual void GetHueRange (double _arg[2])"
public void GetHueRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetHueRange_2(this, _arg);
}


// virtual void SetSaturationRange(double _arg1, double _arg2)
// "virtual void SetSaturationRange (double _arg1, double _arg2)"
public void SetSaturationRange(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkLookupTable.SetSaturationRange_0(this, _arg1, _arg2);
}


// void SetSaturationRange(double _arg[2])
// "void SetSaturationRange (double _arg[2])"
public void SetSaturationRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetSaturationRange_1(this, _arg);
}


// virtual double* GetSaturationRange()
// "virtual double *GetSaturationRange ()"
public IntPtr GetSaturationRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetSaturationRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetSaturationRange(double & _arg1, double & _arg2)
// "virtual void GetSaturationRange (double &_arg1, double &_arg2)"
public void GetSaturationRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkLookupTable.GetSaturationRange_1(this, _arg1, _arg2);
}


// virtual void GetSaturationRange(double _arg[2])
// "virtual void GetSaturationRange (double _arg[2])"
public void GetSaturationRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetSaturationRange_2(this, _arg);
}


// virtual void SetValueRange(double _arg1, double _arg2)
// "virtual void SetValueRange (double _arg1, double _arg2)"
public void SetValueRange(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkLookupTable.SetValueRange_0(this, _arg1, _arg2);
}


// void SetValueRange(double _arg[2])
// "void SetValueRange (double _arg[2])"
public void SetValueRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetValueRange_1(this, _arg);
}


// virtual double* GetValueRange()
// "virtual double *GetValueRange ()"
public IntPtr GetValueRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetValueRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetValueRange(double & _arg1, double & _arg2)
// "virtual void GetValueRange (double &_arg1, double &_arg2)"
public void GetValueRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkLookupTable.GetValueRange_1(this, _arg1, _arg2);
}


// virtual void GetValueRange(double _arg[2])
// "virtual void GetValueRange (double _arg[2])"
public void GetValueRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetValueRange_2(this, _arg);
}


// virtual void SetAlphaRange(double _arg1, double _arg2)
// "virtual void SetAlphaRange (double _arg1, double _arg2)"
public void SetAlphaRange(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkLookupTable.SetAlphaRange_0(this, _arg1, _arg2);
}


// void SetAlphaRange(double _arg[2])
// "void SetAlphaRange (double _arg[2])"
public void SetAlphaRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetAlphaRange_1(this, _arg);
}


// virtual double* GetAlphaRange()
// "virtual double *GetAlphaRange ()"
public IntPtr GetAlphaRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetAlphaRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAlphaRange(double & _arg1, double & _arg2)
// "virtual void GetAlphaRange (double &_arg1, double &_arg2)"
public void GetAlphaRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkLookupTable.GetAlphaRange_1(this, _arg1, _arg2);
}


// virtual void GetAlphaRange(double _arg[2])
// "virtual void GetAlphaRange (double _arg[2])"
public void GetAlphaRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetAlphaRange_2(this, _arg);
}


// virtual void SetNanColor(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetNanColor (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetNanColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkLookupTable.SetNanColor_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetNanColor(double _arg[4])
// "virtual void SetNanColor (double _arg[4])"
public void SetNanColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetNanColor_1(this, _arg);
}


// virtual double* GetNanColor()
// "virtual double *GetNanColor ()"
public IntPtr GetNanColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetNanColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetNanColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// "virtual void GetNanColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)"
public void GetNanColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4) {
	VTK_API.API_vtkLookupTable.GetNanColor_1(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void GetNanColor(double _arg[4])
// "virtual void GetNanColor (double _arg[4])"
public void GetNanColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetNanColor_2(this, _arg);
}


// char* GetNanColorAsUnsignedChars()
// "unsigned char* GetNanColorAsUnsignedChars()"
public string GetNanColorAsUnsignedChars() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetNanColorAsUnsignedChars_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// "static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])"
public static void GetColorAsUnsignedChars(double /*(double[4])*/ []colorIn, char /*(unsigned char[4])*/ []colorOut) {
	VTK_API.API_vtkLookupTable.GetColorAsUnsignedChars_0(colorIn, colorOut);
}


// virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetBelowRangeColor (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetBelowRangeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkLookupTable.SetBelowRangeColor_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetBelowRangeColor(double _arg[4])
// "virtual void SetBelowRangeColor (double _arg[4])"
public void SetBelowRangeColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetBelowRangeColor_1(this, _arg);
}


// virtual double* GetBelowRangeColor()
// "virtual double *GetBelowRangeColor ()"
public IntPtr GetBelowRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetBelowRangeColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetBelowRangeColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// "virtual void GetBelowRangeColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)"
public void GetBelowRangeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4) {
	VTK_API.API_vtkLookupTable.GetBelowRangeColor_1(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void GetBelowRangeColor(double _arg[4])
// "virtual void GetBelowRangeColor (double _arg[4])"
public void GetBelowRangeColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetBelowRangeColor_2(this, _arg);
}


// virtual void SetUseBelowRangeColor(int _arg)
// "virtual void SetUseBelowRangeColor (int _arg)"
public void SetUseBelowRangeColor(int /*(int)*/ _arg) {
	VTK_API.API_vtkLookupTable.SetUseBelowRangeColor_0(this, _arg);
}


// virtual int GetUseBelowRangeColor()
// "virtual int GetUseBelowRangeColor ()"
public int GetUseBelowRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.GetUseBelowRangeColor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseBelowRangeColorOn()
// "virtual void UseBelowRangeColorOn ()"
public void UseBelowRangeColorOn() {
	VTK_API.API_vtkLookupTable.UseBelowRangeColorOn_0(this);
}


// virtual void UseBelowRangeColorOff()
// "virtual void UseBelowRangeColorOff ()"
public void UseBelowRangeColorOff() {
	VTK_API.API_vtkLookupTable.UseBelowRangeColorOff_0(this);
}


// virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetAboveRangeColor (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetAboveRangeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkLookupTable.SetAboveRangeColor_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetAboveRangeColor(double _arg[4])
// "virtual void SetAboveRangeColor (double _arg[4])"
public void SetAboveRangeColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.SetAboveRangeColor_1(this, _arg);
}


// virtual double* GetAboveRangeColor()
// "virtual double *GetAboveRangeColor ()"
public IntPtr GetAboveRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetAboveRangeColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAboveRangeColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// "virtual void GetAboveRangeColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)"
public void GetAboveRangeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4) {
	VTK_API.API_vtkLookupTable.GetAboveRangeColor_1(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void GetAboveRangeColor(double _arg[4])
// "virtual void GetAboveRangeColor (double _arg[4])"
public void GetAboveRangeColor(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkLookupTable.GetAboveRangeColor_2(this, _arg);
}


// virtual void SetUseAboveRangeColor(int _arg)
// "virtual void SetUseAboveRangeColor (int _arg)"
public void SetUseAboveRangeColor(int /*(int)*/ _arg) {
	VTK_API.API_vtkLookupTable.SetUseAboveRangeColor_0(this, _arg);
}


// virtual int GetUseAboveRangeColor()
// "virtual int GetUseAboveRangeColor ()"
public int GetUseAboveRangeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.GetUseAboveRangeColor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseAboveRangeColorOn()
// "virtual void UseAboveRangeColorOn ()"
public void UseAboveRangeColorOn() {
	VTK_API.API_vtkLookupTable.UseAboveRangeColorOn_0(this);
}


// virtual void UseAboveRangeColorOff()
// "virtual void UseAboveRangeColorOff ()"
public void UseAboveRangeColorOff() {
	VTK_API.API_vtkLookupTable.UseAboveRangeColorOff_0(this);
}


// char* MapValue(double v)
// "unsigned char* MapValue(double v)"
public string MapValue(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.MapValue_0(returnPointer.GetPtr(), this, v);
	return (string)returnPointer;
}


// void GetColor(double x, double rgb[3])
// "void GetColor(double x, double rgb[3])"
public void GetColor(double /*(double)*/ x, double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkLookupTable.GetColor_0(this, x, rgb);
}


// double GetOpacity(double v)
// "double GetOpacity(double v)"
public double GetOpacity(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLookupTable.GetOpacity_0(returnPointer.GetPtr(), this, v);
	return (double)returnPointer;
}


// virtual vtkIdType GetIndex(double v)
// "virtual vtkIdType GetIndex(double v)"
public long GetIndex(double /*(double)*/ v) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetIndex_0(returnPointer.GetPtr(), this, v);
	return (long)returnPointer;
}


// void SetNumberOfTableValues(vtkIdType number)
// "void SetNumberOfTableValues(vtkIdType number)"
public void SetNumberOfTableValues(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkLookupTable.SetNumberOfTableValues_0(this, number);
}


// vtkIdType GetNumberOfTableValues()
// "vtkIdType GetNumberOfTableValues()"
public long GetNumberOfTableValues() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetNumberOfTableValues_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
// "virtual void SetTableValue(vtkIdType indx, const double rgba[4])"
public void SetTableValue(long /*(vtkIdType)*/ indx, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkLookupTable.SetTableValue_0(this, indx, rgba);
}


// double* GetTableValue(vtkIdType id)
// "double *GetTableValue(vtkIdType id)"
public IntPtr GetTableValue(long /*(vtkIdType)*/ id) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetTableValue_0(returnPointer.GetPtr(), this, id);
	return (IntPtr)returnPointer;
}


// void GetTableValue(vtkIdType id, double rgba[4])
// "void GetTableValue(vtkIdType id, double rgba[4])"
public void GetTableValue(long /*(vtkIdType)*/ id, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkLookupTable.GetTableValue_1(this, id, rgba);
}


// char* GetPointer(vtkIdType id)
// "unsigned char *GetPointer(vtkIdType id)"
public string GetPointer(long /*(vtkIdType)*/ id) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetPointer_0(returnPointer.GetPtr(), this, id);
	return (string)returnPointer;
}


// char* WritePointer(vtkIdType id, int number)
// "unsigned char *WritePointer(vtkIdType id, int number)"
public string WritePointer(long /*(vtkIdType)*/ id, int /*(int)*/ number) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.WritePointer_0(returnPointer.GetPtr(), this, id, number);
	return (string)returnPointer;
}


// double* GetRange()
// "double *GetRange()"
public IntPtr GetRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetRange(double min, double max)
// "void SetRange(double min, double max)"
public void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	VTK_API.API_vtkLookupTable.SetRange_0(this, min, max);
}


// void SetRange(const double rng[2])
// "void SetRange(const double rng[2])"
public void SetRange(double /*(double[2])*/ []rng) {
	VTK_API.API_vtkLookupTable.SetRange_1(this, rng);
}


// static void GetLogRange(const double range[2], double log_range[2])
// "static void GetLogRange(const double range[2], double log_range[2])"
public static void GetLogRange(double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	VTK_API.API_vtkLookupTable.GetLogRange_0(range, log_range);
}


// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
// "static double ApplyLogScale(double v, const double range[2], const double log_range[2])"
public static double ApplyLogScale(double /*(double)*/ v, double /*(double[2])*/ []range, double /*(double[2])*/ []log_range) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLookupTable.ApplyLogScale_0(returnPointer.GetPtr(), v, range, log_range);
	return (double)returnPointer;
}


// virtual void SetNumberOfColors(vtkIdType _arg)
// "virtual void SetNumberOfColors (vtkIdType _arg)"
public void SetNumberOfColors(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkLookupTable.SetNumberOfColors_0(this, _arg);
}


// virtual vtkIdType GetNumberOfColorsMinValue()
// "virtual vtkIdType GetNumberOfColorsMinValue ()"
public long GetNumberOfColorsMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetNumberOfColorsMinValue_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfColorsMaxValue()
// "virtual vtkIdType GetNumberOfColorsMaxValue ()"
public long GetNumberOfColorsMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetNumberOfColorsMaxValue_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual vtkIdType GetNumberOfColors()
// "virtual vtkIdType GetNumberOfColors ()"
public long GetNumberOfColors() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetNumberOfColors_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SetTable(vtkUnsignedCharArray * ARG_0)
// "void SetTable(vtkUnsignedCharArray *)"
public void SetTable(vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ ARG_0) {
	VTK_API.API_vtkLookupTable.SetTable_0(this, ARG_0);
}


// virtual vtkUnsignedCharArray* GetTable()
// "virtual vtkUnsignedCharArray *GetTable ()"
public vtkUnsignedCharArray GetTable() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLookupTable.GetTable_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// "void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)"
public void MapScalarsThroughTable2(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement) {
	VTK_API.API_vtkLookupTable.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
}


// void DeepCopy(vtkScalarsToColors * lut)
// "void DeepCopy(vtkScalarsToColors *lut)"
public void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ lut) {
	VTK_API.API_vtkLookupTable.DeepCopy_0(this, lut);
}


// int UsingLogScale()
// "int UsingLogScale()"
public int UsingLogScale() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLookupTable.UsingLogScale_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType GetNumberOfAvailableColors()
// "vtkIdType GetNumberOfAvailableColors()"
public long GetNumberOfAvailableColors() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkLookupTable.GetNumberOfAvailableColors_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetIndexedColor(vtkIdType idx, double rgba[4])
// "void GetIndexedColor(vtkIdType idx, double rgba[4])"
public void GetIndexedColor(long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkLookupTable.GetIndexedColor_0(this, idx, rgba);
}


}
};
