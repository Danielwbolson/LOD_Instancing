
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkVolumeProperty {

// static vtkVolumeProperty* New()
// static vtkVolumeProperty *New()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, string /*(char*)*/ type);

// static vtkVolumeProperty* SafeDownCast(vtkObjectBase * o)
// static vtkVolumeProperty* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkVolumeProperty* NewInstance()
// vtkVolumeProperty *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void DeepCopy(vtkVolumeProperty * p)
// void DeepCopy(vtkVolumeProperty *p)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkVolumeProperty*)*/ p);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void SetIndependentComponents(int _arg)
// virtual void SetIndependentComponents (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetIndependentComponents_0")] public static extern 
bool SetIndependentComponents_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetIndependentComponentsMinValue()
// virtual int GetIndependentComponentsMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetIndependentComponentsMinValue_0")] public static extern 
bool GetIndependentComponentsMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetIndependentComponentsMaxValue()
// virtual int GetIndependentComponentsMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetIndependentComponentsMaxValue_0")] public static extern 
bool GetIndependentComponentsMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetIndependentComponents()
// virtual int GetIndependentComponents ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetIndependentComponents_0")] public static extern 
bool GetIndependentComponents_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void IndependentComponentsOn()
// virtual void IndependentComponentsOn ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_IndependentComponentsOn_0")] public static extern 
bool IndependentComponentsOn_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void IndependentComponentsOff()
// virtual void IndependentComponentsOff ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_IndependentComponentsOff_0")] public static extern 
bool IndependentComponentsOff_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void SetInterpolationType(int _arg)
// virtual void SetInterpolationType (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetInterpolationType_0")] public static extern 
bool SetInterpolationType_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetInterpolationTypeMinValue()
// virtual int GetInterpolationTypeMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetInterpolationTypeMinValue_0")] public static extern 
bool GetInterpolationTypeMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetInterpolationTypeMaxValue()
// virtual int GetInterpolationTypeMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetInterpolationTypeMaxValue_0")] public static extern 
bool GetInterpolationTypeMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetInterpolationType()
// virtual int GetInterpolationType ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetInterpolationType_0")] public static extern 
bool GetInterpolationType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetInterpolationTypeToNearest()
// void SetInterpolationTypeToNearest()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetInterpolationTypeToNearest_0")] public static extern 
bool SetInterpolationTypeToNearest_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetInterpolationTypeToLinear()
// void SetInterpolationTypeToLinear()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetInterpolationTypeToLinear_0")] public static extern 
bool SetInterpolationTypeToLinear_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// char* GetInterpolationTypeAsString()
// const char *GetInterpolationTypeAsString(void)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetInterpolationTypeAsString_0")] public static extern 
bool GetInterpolationTypeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void SetComponentWeight(int index, double value)
// virtual void SetComponentWeight(int index, double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetComponentWeight_0")] public static extern 
bool SetComponentWeight_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ value);

// virtual double GetComponentWeight(int index)
// virtual double GetComponentWeight(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetComponentWeight_0")] public static extern 
bool GetComponentWeight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// void SetColor(int index, vtkPiecewiseFunction * function)
// void SetColor(int index, vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetColor_0")] public static extern 
bool SetColor_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// void SetColor(vtkPiecewiseFunction * function)
// void SetColor(vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetColor_1")] public static extern 
bool SetColor_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// void SetColor(int index, vtkColorTransferFunction * function)
// void SetColor(int index, vtkColorTransferFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetColor_2")] public static extern 
bool SetColor_2(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkColorTransferFunction*)*/ function);

// void SetColor(vtkColorTransferFunction * function)
// void SetColor(vtkColorTransferFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetColor_3")] public static extern 
bool SetColor_3(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkColorTransferFunction*)*/ function);

// int GetColorChannels(int index)
// int GetColorChannels(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetColorChannels_0")] public static extern 
bool GetColorChannels_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// int GetColorChannels()
// int GetColorChannels()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetColorChannels_1")] public static extern 
bool GetColorChannels_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// vtkPiecewiseFunction* GetGrayTransferFunction(int index)
// vtkPiecewiseFunction *GetGrayTransferFunction(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetGrayTransferFunction_0")] public static extern 
bool GetGrayTransferFunction_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkPiecewiseFunction* GetGrayTransferFunction()
// vtkPiecewiseFunction *GetGrayTransferFunction()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetGrayTransferFunction_1")] public static extern 
bool GetGrayTransferFunction_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// vtkColorTransferFunction* GetRGBTransferFunction(int index)
// vtkColorTransferFunction *GetRGBTransferFunction(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetRGBTransferFunction_0")] public static extern 
bool GetRGBTransferFunction_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkColorTransferFunction* GetRGBTransferFunction()
// vtkColorTransferFunction *GetRGBTransferFunction()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetRGBTransferFunction_1")] public static extern 
bool GetRGBTransferFunction_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetScalarOpacity(int index, vtkPiecewiseFunction * function)
// void SetScalarOpacity(int index, vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetScalarOpacity_0")] public static extern 
bool SetScalarOpacity_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// void SetScalarOpacity(vtkPiecewiseFunction * function)
// void SetScalarOpacity(vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetScalarOpacity_1")] public static extern 
bool SetScalarOpacity_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// vtkPiecewiseFunction* GetScalarOpacity(int index)
// vtkPiecewiseFunction *GetScalarOpacity(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetScalarOpacity_0")] public static extern 
bool GetScalarOpacity_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkPiecewiseFunction* GetScalarOpacity()
// vtkPiecewiseFunction *GetScalarOpacity()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetScalarOpacity_1")] public static extern 
bool GetScalarOpacity_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetScalarOpacityUnitDistance(int index, double distance)
// void SetScalarOpacityUnitDistance(int index, double distance)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetScalarOpacityUnitDistance_0")] public static extern 
bool SetScalarOpacityUnitDistance_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ distance);

// void SetScalarOpacityUnitDistance(double distance)
// void SetScalarOpacityUnitDistance(double distance)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetScalarOpacityUnitDistance_1")] public static extern 
bool SetScalarOpacityUnitDistance_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, double /*(double)*/ distance);

// double GetScalarOpacityUnitDistance(int index)
// double GetScalarOpacityUnitDistance(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetScalarOpacityUnitDistance_0")] public static extern 
bool GetScalarOpacityUnitDistance_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// double GetScalarOpacityUnitDistance()
// double GetScalarOpacityUnitDistance()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetScalarOpacityUnitDistance_1")] public static extern 
bool GetScalarOpacityUnitDistance_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetGradientOpacity(int index, vtkPiecewiseFunction * function)
// void SetGradientOpacity(int index, vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetGradientOpacity_0")] public static extern 
bool SetGradientOpacity_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// void SetGradientOpacity(vtkPiecewiseFunction * function)
// void SetGradientOpacity(vtkPiecewiseFunction *function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetGradientOpacity_1")] public static extern 
bool SetGradientOpacity_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkPiecewiseFunction*)*/ function);

// void SetTransferFunction2D(int index, vtkImageData * function)
// void SetTransferFunction2D(int index, vtkImageData* function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetTransferFunction2D_0")] public static extern 
bool SetTransferFunction2D_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkImageData*)*/ function);

// void SetTransferFunction2D(vtkImageData * function)
// void SetTransferFunction2D(vtkImageData* function)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetTransferFunction2D_1")] public static extern 
bool SetTransferFunction2D_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, IntPtr /*(vtkImageData*)*/ function);

// vtkImageData* GetTransferFunction2D(int index)
// vtkImageData* GetTransferFunction2D(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetTransferFunction2D_0")] public static extern 
bool GetTransferFunction2D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkImageData* GetTransferFunction2D()
// vtkImageData* GetTransferFunction2D()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetTransferFunction2D_1")] public static extern 
bool GetTransferFunction2D_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void SetTransferFunctionMode(int _arg)
// virtual void SetTransferFunctionMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetTransferFunctionMode_0")] public static extern 
bool SetTransferFunctionMode_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTransferFunctionModeMinValue()
// virtual int GetTransferFunctionModeMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetTransferFunctionModeMinValue_0")] public static extern 
bool GetTransferFunctionModeMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetTransferFunctionModeMaxValue()
// virtual int GetTransferFunctionModeMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetTransferFunctionModeMaxValue_0")] public static extern 
bool GetTransferFunctionModeMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetTransferFunctionMode()
// virtual int GetTransferFunctionMode ()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetTransferFunctionMode_0")] public static extern 
bool GetTransferFunctionMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// vtkPiecewiseFunction* GetGradientOpacity(int index)
// vtkPiecewiseFunction *GetGradientOpacity(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetGradientOpacity_0")] public static extern 
bool GetGradientOpacity_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkPiecewiseFunction* GetGradientOpacity()
// vtkPiecewiseFunction *GetGradientOpacity()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetGradientOpacity_1")] public static extern 
bool GetGradientOpacity_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void SetDisableGradientOpacity(int index, int value)
// virtual void SetDisableGradientOpacity(int index, int value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetDisableGradientOpacity_0")] public static extern 
bool SetDisableGradientOpacity_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, int /*(int)*/ value);

// virtual void SetDisableGradientOpacity(int value)
// virtual void SetDisableGradientOpacity(int value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetDisableGradientOpacity_1")] public static extern 
bool SetDisableGradientOpacity_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ value);

// virtual void DisableGradientOpacityOn(int index)
// virtual void DisableGradientOpacityOn(int index )
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_DisableGradientOpacityOn_0")] public static extern 
bool DisableGradientOpacityOn_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// virtual void DisableGradientOpacityOn()
// virtual void DisableGradientOpacityOn()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_DisableGradientOpacityOn_1")] public static extern 
bool DisableGradientOpacityOn_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual void DisableGradientOpacityOff(int index)
// virtual void DisableGradientOpacityOff(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_DisableGradientOpacityOff_0")] public static extern 
bool DisableGradientOpacityOff_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// virtual void DisableGradientOpacityOff()
// virtual void DisableGradientOpacityOff()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_DisableGradientOpacityOff_1")] public static extern 
bool DisableGradientOpacityOff_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// virtual int GetDisableGradientOpacity(int index)
// virtual int GetDisableGradientOpacity(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetDisableGradientOpacity_0")] public static extern 
bool GetDisableGradientOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// virtual int GetDisableGradientOpacity()
// virtual int GetDisableGradientOpacity()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetDisableGradientOpacity_1")] public static extern 
bool GetDisableGradientOpacity_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// vtkPiecewiseFunction* GetStoredGradientOpacity(int index)
// vtkPiecewiseFunction *GetStoredGradientOpacity(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetStoredGradientOpacity_0")] public static extern 
bool GetStoredGradientOpacity_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// vtkPiecewiseFunction* GetStoredGradientOpacity()
// vtkPiecewiseFunction *GetStoredGradientOpacity()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetStoredGradientOpacity_1")] public static extern 
bool GetStoredGradientOpacity_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// bool HasGradientOpacity(int index = 0)
// bool HasGradientOpacity(int index = 0)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_HasGradientOpacity_0")] public static extern 
bool HasGradientOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// void SetShade(int index, int value)
// void SetShade(int index, int value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetShade_0")] public static extern 
bool SetShade_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, int /*(int)*/ value);

// void SetShade(int value)
// void SetShade(int value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetShade_1")] public static extern 
bool SetShade_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ value);

// int GetShade(int index)
// int GetShade(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetShade_0")] public static extern 
bool GetShade_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// int GetShade()
// int GetShade()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetShade_1")] public static extern 
bool GetShade_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void ShadeOn(int index)
// void ShadeOn(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_ShadeOn_0")] public static extern 
bool ShadeOn_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// void ShadeOn()
// void ShadeOn()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_ShadeOn_1")] public static extern 
bool ShadeOn_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void ShadeOff(int index)
// void ShadeOff(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_ShadeOff_0")] public static extern 
bool ShadeOff_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// void ShadeOff()
// void ShadeOff()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_ShadeOff_1")] public static extern 
bool ShadeOff_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetAmbient(int index, double value)
// void SetAmbient(int index, double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetAmbient_0")] public static extern 
bool SetAmbient_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ value);

// void SetAmbient(double value)
// void SetAmbient(double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetAmbient_1")] public static extern 
bool SetAmbient_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, double /*(double)*/ value);

// double GetAmbient(int index)
// double GetAmbient(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetAmbient_0")] public static extern 
bool GetAmbient_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// double GetAmbient()
// double GetAmbient()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetAmbient_1")] public static extern 
bool GetAmbient_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetDiffuse(int index, double value)
// void SetDiffuse(int index, double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetDiffuse_0")] public static extern 
bool SetDiffuse_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ value);

// void SetDiffuse(double value)
// void SetDiffuse(double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetDiffuse_1")] public static extern 
bool SetDiffuse_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, double /*(double)*/ value);

// double GetDiffuse(int index)
// double GetDiffuse(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetDiffuse_0")] public static extern 
bool GetDiffuse_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// double GetDiffuse()
// double GetDiffuse()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetDiffuse_1")] public static extern 
bool GetDiffuse_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetSpecular(int index, double value)
// void SetSpecular(int index, double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetSpecular_0")] public static extern 
bool SetSpecular_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ value);

// void SetSpecular(double value)
// void SetSpecular(double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetSpecular_1")] public static extern 
bool SetSpecular_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, double /*(double)*/ value);

// double GetSpecular(int index)
// double GetSpecular(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetSpecular_0")] public static extern 
bool GetSpecular_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// double GetSpecular()
// double GetSpecular()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetSpecular_1")] public static extern 
bool GetSpecular_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void SetSpecularPower(int index, double value)
// void SetSpecularPower(int index, double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetSpecularPower_0")] public static extern 
bool SetSpecularPower_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index, double /*(double)*/ value);

// void SetSpecularPower(double value)
// void SetSpecularPower(double value)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_SetSpecularPower_1")] public static extern 
bool SetSpecularPower_1(IntPtr /*(vtkVolumeProperty*)*/ callingObject, double /*(double)*/ value);

// double GetSpecularPower(int index)
// double GetSpecularPower(int index)
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetSpecularPower_0")] public static extern 
bool GetSpecularPower_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject, int /*(int)*/ index);

// double GetSpecularPower()
// double GetSpecularPower()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_GetSpecularPower_1")] public static extern 
bool GetSpecularPower_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolumeProperty*)*/ callingObject);

// void UpdateMTimes()
// void UpdateMTimes()
[DllImport("vtkplugin", EntryPoint="vtkVolumeProperty_UpdateMTimes_0")] public static extern 
bool UpdateMTimes_0(IntPtr /*(vtkVolumeProperty*)*/ callingObject);

}
};
