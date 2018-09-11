

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVolumeProperty : vtkObject {
		public vtkVolumeProperty(IntPtr p) : base(p) {}
		public static implicit operator  vtkVolumeProperty(IntPtr p) {return new vtkVolumeProperty(p);}
		public static implicit operator  IntPtr(vtkVolumeProperty o) {return o.GetPtr();}

// static vtkVolumeProperty* New()
// "static vtkVolumeProperty *New()"
public static vtkVolumeProperty New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.New_0(returnPointer.GetPtr());
	return (vtkVolumeProperty)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolumeProperty.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolumeProperty.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkVolumeProperty* SafeDownCast(vtkObjectBase * o)
// "static vtkVolumeProperty* SafeDownCast(vtkObjectBase *o)"
public static vtkVolumeProperty SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkVolumeProperty)(IntPtr)returnPointer;
}


// vtkVolumeProperty* NewInstance()
// "vtkVolumeProperty *NewInstance()"
public vtkVolumeProperty NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkVolumeProperty)(IntPtr)returnPointer;
}


// void DeepCopy(vtkVolumeProperty * p)
// "void DeepCopy(vtkVolumeProperty *p)"
public void DeepCopy(vtkVolumeProperty /*(vtkVolumeProperty*)*/ p) {
	VTK_API.API_vtkVolumeProperty.DeepCopy_0(this, p);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkVolumeProperty.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void SetIndependentComponents(int _arg)
// "virtual void SetIndependentComponents (int _arg)"
public void SetIndependentComponents(int /*(int)*/ _arg) {
	VTK_API.API_vtkVolumeProperty.SetIndependentComponents_0(this, _arg);
}


// virtual int GetIndependentComponentsMinValue()
// "virtual int GetIndependentComponentsMinValue ()"
public int GetIndependentComponentsMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetIndependentComponentsMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetIndependentComponentsMaxValue()
// "virtual int GetIndependentComponentsMaxValue ()"
public int GetIndependentComponentsMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetIndependentComponentsMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetIndependentComponents()
// "virtual int GetIndependentComponents ()"
public int GetIndependentComponents() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetIndependentComponents_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void IndependentComponentsOn()
// "virtual void IndependentComponentsOn ()"
public void IndependentComponentsOn() {
	VTK_API.API_vtkVolumeProperty.IndependentComponentsOn_0(this);
}


// virtual void IndependentComponentsOff()
// "virtual void IndependentComponentsOff ()"
public void IndependentComponentsOff() {
	VTK_API.API_vtkVolumeProperty.IndependentComponentsOff_0(this);
}


// virtual void SetInterpolationType(int _arg)
// "virtual void SetInterpolationType (int _arg)"
public void SetInterpolationType(int /*(int)*/ _arg) {
	VTK_API.API_vtkVolumeProperty.SetInterpolationType_0(this, _arg);
}


// virtual int GetInterpolationTypeMinValue()
// "virtual int GetInterpolationTypeMinValue ()"
public int GetInterpolationTypeMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetInterpolationTypeMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetInterpolationTypeMaxValue()
// "virtual int GetInterpolationTypeMaxValue ()"
public int GetInterpolationTypeMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetInterpolationTypeMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetInterpolationType()
// "virtual int GetInterpolationType ()"
public int GetInterpolationType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetInterpolationType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetInterpolationTypeToNearest()
// "void SetInterpolationTypeToNearest()"
public void SetInterpolationTypeToNearest() {
	VTK_API.API_vtkVolumeProperty.SetInterpolationTypeToNearest_0(this);
}


// void SetInterpolationTypeToLinear()
// "void SetInterpolationTypeToLinear()"
public void SetInterpolationTypeToLinear() {
	VTK_API.API_vtkVolumeProperty.SetInterpolationTypeToLinear_0(this);
}


// char* GetInterpolationTypeAsString()
// "const char *GetInterpolationTypeAsString(void)"
public string GetInterpolationTypeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetInterpolationTypeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetComponentWeight(int index, double value)
// "virtual void SetComponentWeight(int index, double value)"
public void SetComponentWeight(int /*(int)*/ index, double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetComponentWeight_0(this, index, value);
}


// virtual double GetComponentWeight(int index)
// "virtual double GetComponentWeight(int index)"
public double GetComponentWeight(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetComponentWeight_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// void SetColor(int index, vtkPiecewiseFunction * function)
// "void SetColor(int index, vtkPiecewiseFunction *function)"
public void SetColor(int /*(int)*/ index, vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetColor_0(this, index, function);
}


// void SetColor(vtkPiecewiseFunction * function)
// "void SetColor(vtkPiecewiseFunction *function)"
public void SetColor(vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetColor_1(this, function);
}


// void SetColor(int index, vtkColorTransferFunction * function)
// "void SetColor(int index, vtkColorTransferFunction *function)"
public void SetColor(int /*(int)*/ index, vtkColorTransferFunction /*(vtkColorTransferFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetColor_2(this, index, function);
}


// void SetColor(vtkColorTransferFunction * function)
// "void SetColor(vtkColorTransferFunction *function)"
public void SetColor(vtkColorTransferFunction /*(vtkColorTransferFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetColor_3(this, function);
}


// int GetColorChannels(int index)
// "int GetColorChannels(int index)"
public int GetColorChannels(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetColorChannels_0(returnPointer.GetPtr(), this, index);
	return (int)returnPointer;
}


// int GetColorChannels()
// "int GetColorChannels()"
public int GetColorChannels() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetColorChannels_1(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkPiecewiseFunction* GetGrayTransferFunction(int index)
// "vtkPiecewiseFunction *GetGrayTransferFunction(int index)"
public vtkPiecewiseFunction GetGrayTransferFunction(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetGrayTransferFunction_0(returnPointer.GetPtr(), this, index);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkPiecewiseFunction* GetGrayTransferFunction()
// "vtkPiecewiseFunction *GetGrayTransferFunction()"
public vtkPiecewiseFunction GetGrayTransferFunction() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetGrayTransferFunction_1(returnPointer.GetPtr(), this);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkColorTransferFunction* GetRGBTransferFunction(int index)
// "vtkColorTransferFunction *GetRGBTransferFunction(int index)"
public vtkColorTransferFunction GetRGBTransferFunction(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetRGBTransferFunction_0(returnPointer.GetPtr(), this, index);
	return (vtkColorTransferFunction)(IntPtr)returnPointer;
}


// vtkColorTransferFunction* GetRGBTransferFunction()
// "vtkColorTransferFunction *GetRGBTransferFunction()"
public vtkColorTransferFunction GetRGBTransferFunction() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetRGBTransferFunction_1(returnPointer.GetPtr(), this);
	return (vtkColorTransferFunction)(IntPtr)returnPointer;
}


// void SetScalarOpacity(int index, vtkPiecewiseFunction * function)
// "void SetScalarOpacity(int index, vtkPiecewiseFunction *function)"
public void SetScalarOpacity(int /*(int)*/ index, vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetScalarOpacity_0(this, index, function);
}


// void SetScalarOpacity(vtkPiecewiseFunction * function)
// "void SetScalarOpacity(vtkPiecewiseFunction *function)"
public void SetScalarOpacity(vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetScalarOpacity_1(this, function);
}


// vtkPiecewiseFunction* GetScalarOpacity(int index)
// "vtkPiecewiseFunction *GetScalarOpacity(int index)"
public vtkPiecewiseFunction GetScalarOpacity(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetScalarOpacity_0(returnPointer.GetPtr(), this, index);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkPiecewiseFunction* GetScalarOpacity()
// "vtkPiecewiseFunction *GetScalarOpacity()"
public vtkPiecewiseFunction GetScalarOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetScalarOpacity_1(returnPointer.GetPtr(), this);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// void SetScalarOpacityUnitDistance(int index, double distance)
// "void SetScalarOpacityUnitDistance(int index, double distance)"
public void SetScalarOpacityUnitDistance(int /*(int)*/ index, double /*(double)*/ distance) {
	VTK_API.API_vtkVolumeProperty.SetScalarOpacityUnitDistance_0(this, index, distance);
}


// void SetScalarOpacityUnitDistance(double distance)
// "void SetScalarOpacityUnitDistance(double distance)"
public void SetScalarOpacityUnitDistance(double /*(double)*/ distance) {
	VTK_API.API_vtkVolumeProperty.SetScalarOpacityUnitDistance_1(this, distance);
}


// double GetScalarOpacityUnitDistance(int index)
// "double GetScalarOpacityUnitDistance(int index)"
public double GetScalarOpacityUnitDistance(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetScalarOpacityUnitDistance_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// double GetScalarOpacityUnitDistance()
// "double GetScalarOpacityUnitDistance()"
public double GetScalarOpacityUnitDistance() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetScalarOpacityUnitDistance_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetGradientOpacity(int index, vtkPiecewiseFunction * function)
// "void SetGradientOpacity(int index, vtkPiecewiseFunction *function)"
public void SetGradientOpacity(int /*(int)*/ index, vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetGradientOpacity_0(this, index, function);
}


// void SetGradientOpacity(vtkPiecewiseFunction * function)
// "void SetGradientOpacity(vtkPiecewiseFunction *function)"
public void SetGradientOpacity(vtkPiecewiseFunction /*(vtkPiecewiseFunction*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetGradientOpacity_1(this, function);
}


// void SetTransferFunction2D(int index, vtkImageData * function)
// "void SetTransferFunction2D(int index, vtkImageData* function)"
public void SetTransferFunction2D(int /*(int)*/ index, vtkImageData /*(vtkImageData*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetTransferFunction2D_0(this, index, function);
}


// void SetTransferFunction2D(vtkImageData * function)
// "void SetTransferFunction2D(vtkImageData* function)"
public void SetTransferFunction2D(vtkImageData /*(vtkImageData*)*/ function) {
	VTK_API.API_vtkVolumeProperty.SetTransferFunction2D_1(this, function);
}


// vtkImageData* GetTransferFunction2D(int index)
// "vtkImageData* GetTransferFunction2D(int index)"
public vtkImageData GetTransferFunction2D(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetTransferFunction2D_0(returnPointer.GetPtr(), this, index);
	return (vtkImageData)(IntPtr)returnPointer;
}


// vtkImageData* GetTransferFunction2D()
// "vtkImageData* GetTransferFunction2D()"
public vtkImageData GetTransferFunction2D() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetTransferFunction2D_1(returnPointer.GetPtr(), this);
	return (vtkImageData)(IntPtr)returnPointer;
}


// virtual void SetTransferFunctionMode(int _arg)
// "virtual void SetTransferFunctionMode (int _arg)"
public void SetTransferFunctionMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkVolumeProperty.SetTransferFunctionMode_0(this, _arg);
}


// virtual int GetTransferFunctionModeMinValue()
// "virtual int GetTransferFunctionModeMinValue ()"
public int GetTransferFunctionModeMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetTransferFunctionModeMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetTransferFunctionModeMaxValue()
// "virtual int GetTransferFunctionModeMaxValue ()"
public int GetTransferFunctionModeMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetTransferFunctionModeMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetTransferFunctionMode()
// "virtual int GetTransferFunctionMode ()"
public int GetTransferFunctionMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetTransferFunctionMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkPiecewiseFunction* GetGradientOpacity(int index)
// "vtkPiecewiseFunction *GetGradientOpacity(int index)"
public vtkPiecewiseFunction GetGradientOpacity(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetGradientOpacity_0(returnPointer.GetPtr(), this, index);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkPiecewiseFunction* GetGradientOpacity()
// "vtkPiecewiseFunction *GetGradientOpacity()"
public vtkPiecewiseFunction GetGradientOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetGradientOpacity_1(returnPointer.GetPtr(), this);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// virtual void SetDisableGradientOpacity(int index, int value)
// "virtual void SetDisableGradientOpacity(int index, int value)"
public void SetDisableGradientOpacity(int /*(int)*/ index, int /*(int)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetDisableGradientOpacity_0(this, index, value);
}


// virtual void SetDisableGradientOpacity(int value)
// "virtual void SetDisableGradientOpacity(int value)"
public void SetDisableGradientOpacity(int /*(int)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetDisableGradientOpacity_1(this, value);
}


// virtual void DisableGradientOpacityOn(int index)
// "virtual void DisableGradientOpacityOn(int index )"
public void DisableGradientOpacityOn(int /*(int)*/ index) {
	VTK_API.API_vtkVolumeProperty.DisableGradientOpacityOn_0(this, index);
}


// virtual void DisableGradientOpacityOn()
// "virtual void DisableGradientOpacityOn()"
public void DisableGradientOpacityOn() {
	VTK_API.API_vtkVolumeProperty.DisableGradientOpacityOn_1(this);
}


// virtual void DisableGradientOpacityOff(int index)
// "virtual void DisableGradientOpacityOff(int index)"
public void DisableGradientOpacityOff(int /*(int)*/ index) {
	VTK_API.API_vtkVolumeProperty.DisableGradientOpacityOff_0(this, index);
}


// virtual void DisableGradientOpacityOff()
// "virtual void DisableGradientOpacityOff()"
public void DisableGradientOpacityOff() {
	VTK_API.API_vtkVolumeProperty.DisableGradientOpacityOff_1(this);
}


// virtual int GetDisableGradientOpacity(int index)
// "virtual int GetDisableGradientOpacity(int index)"
public int GetDisableGradientOpacity(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetDisableGradientOpacity_0(returnPointer.GetPtr(), this, index);
	return (int)returnPointer;
}


// virtual int GetDisableGradientOpacity()
// "virtual int GetDisableGradientOpacity()"
public int GetDisableGradientOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetDisableGradientOpacity_1(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkPiecewiseFunction* GetStoredGradientOpacity(int index)
// "vtkPiecewiseFunction *GetStoredGradientOpacity(int index)"
public vtkPiecewiseFunction GetStoredGradientOpacity(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetStoredGradientOpacity_0(returnPointer.GetPtr(), this, index);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkPiecewiseFunction* GetStoredGradientOpacity()
// "vtkPiecewiseFunction *GetStoredGradientOpacity()"
public vtkPiecewiseFunction GetStoredGradientOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolumeProperty.GetStoredGradientOpacity_1(returnPointer.GetPtr(), this);
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// bool HasGradientOpacity(int index = 0)
// "bool HasGradientOpacity(int index = 0)"
public bool HasGradientOpacity(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolumeProperty.HasGradientOpacity_0(returnPointer.GetPtr(), this, index);
	return (bool)returnPointer;
}


// void SetShade(int index, int value)
// "void SetShade(int index, int value)"
public void SetShade(int /*(int)*/ index, int /*(int)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetShade_0(this, index, value);
}


// void SetShade(int value)
// "void SetShade(int value)"
public void SetShade(int /*(int)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetShade_1(this, value);
}


// int GetShade(int index)
// "int GetShade(int index)"
public int GetShade(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetShade_0(returnPointer.GetPtr(), this, index);
	return (int)returnPointer;
}


// int GetShade()
// "int GetShade()"
public int GetShade() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolumeProperty.GetShade_1(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void ShadeOn(int index)
// "void ShadeOn(int index)"
public void ShadeOn(int /*(int)*/ index) {
	VTK_API.API_vtkVolumeProperty.ShadeOn_0(this, index);
}


// void ShadeOn()
// "void ShadeOn()"
public void ShadeOn() {
	VTK_API.API_vtkVolumeProperty.ShadeOn_1(this);
}


// void ShadeOff(int index)
// "void ShadeOff(int index)"
public void ShadeOff(int /*(int)*/ index) {
	VTK_API.API_vtkVolumeProperty.ShadeOff_0(this, index);
}


// void ShadeOff()
// "void ShadeOff()"
public void ShadeOff() {
	VTK_API.API_vtkVolumeProperty.ShadeOff_1(this);
}


// void SetAmbient(int index, double value)
// "void SetAmbient(int index, double value)"
public void SetAmbient(int /*(int)*/ index, double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetAmbient_0(this, index, value);
}


// void SetAmbient(double value)
// "void SetAmbient(double value)"
public void SetAmbient(double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetAmbient_1(this, value);
}


// double GetAmbient(int index)
// "double GetAmbient(int index)"
public double GetAmbient(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetAmbient_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// double GetAmbient()
// "double GetAmbient()"
public double GetAmbient() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetAmbient_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetDiffuse(int index, double value)
// "void SetDiffuse(int index, double value)"
public void SetDiffuse(int /*(int)*/ index, double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetDiffuse_0(this, index, value);
}


// void SetDiffuse(double value)
// "void SetDiffuse(double value)"
public void SetDiffuse(double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetDiffuse_1(this, value);
}


// double GetDiffuse(int index)
// "double GetDiffuse(int index)"
public double GetDiffuse(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetDiffuse_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// double GetDiffuse()
// "double GetDiffuse()"
public double GetDiffuse() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetDiffuse_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetSpecular(int index, double value)
// "void SetSpecular(int index, double value)"
public void SetSpecular(int /*(int)*/ index, double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetSpecular_0(this, index, value);
}


// void SetSpecular(double value)
// "void SetSpecular(double value)"
public void SetSpecular(double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetSpecular_1(this, value);
}


// double GetSpecular(int index)
// "double GetSpecular(int index)"
public double GetSpecular(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetSpecular_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// double GetSpecular()
// "double GetSpecular()"
public double GetSpecular() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetSpecular_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetSpecularPower(int index, double value)
// "void SetSpecularPower(int index, double value)"
public void SetSpecularPower(int /*(int)*/ index, double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetSpecularPower_0(this, index, value);
}


// void SetSpecularPower(double value)
// "void SetSpecularPower(double value)"
public void SetSpecularPower(double /*(double)*/ value) {
	VTK_API.API_vtkVolumeProperty.SetSpecularPower_1(this, value);
}


// double GetSpecularPower(int index)
// "double GetSpecularPower(int index)"
public double GetSpecularPower(int /*(int)*/ index) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetSpecularPower_0(returnPointer.GetPtr(), this, index);
	return (double)returnPointer;
}


// double GetSpecularPower()
// "double GetSpecularPower()"
public double GetSpecularPower() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolumeProperty.GetSpecularPower_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void UpdateMTimes()
// "void UpdateMTimes()"
public void UpdateMTimes() {
	VTK_API.API_vtkVolumeProperty.UpdateMTimes_0(this);
}


}
};
