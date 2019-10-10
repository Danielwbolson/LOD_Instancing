
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkColorTransferFunction {

// static vtkColorTransferFunction* New()
// static vtkColorTransferFunction *New()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, string /*(char*)*/ type);

// static vtkColorTransferFunction* SafeDownCast(vtkObjectBase * o)
// static vtkColorTransferFunction* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkColorTransferFunction* NewInstance()
// vtkColorTransferFunction *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void DeepCopy(vtkScalarsToColors * f)
// void DeepCopy( vtkScalarsToColors *f )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ f);

// void ShallowCopy(vtkColorTransferFunction * f)
// void ShallowCopy( vtkColorTransferFunction *f )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(vtkColorTransferFunction*)*/ f);

// int GetSize()
// int GetSize()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// int AddRGBPoint(double x, double r, double g, double b)
// int AddRGBPoint( double x, double r, double g, double b )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddRGBPoint_0")] public static extern 
bool AddRGBPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b);

// int AddRGBPoint(double x, double r, double g, double b, double midpoint, double sharpness)
// int AddRGBPoint( double x, double r, double g, double b, double midpoint, double sharpness )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddRGBPoint_1")] public static extern 
bool AddRGBPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b, double /*(double)*/ midpoint, double /*(double)*/ sharpness);

// int AddHSVPoint(double x, double h, double s, double v)
// int AddHSVPoint( double x, double h, double s, double v )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddHSVPoint_0")] public static extern 
bool AddHSVPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ h, double /*(double)*/ s, double /*(double)*/ v);

// int AddHSVPoint(double x, double h, double s, double v, double midpoint, double sharpness)
// int AddHSVPoint( double x, double h, double s, double v, double midpoint, double sharpness )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddHSVPoint_1")] public static extern 
bool AddHSVPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ h, double /*(double)*/ s, double /*(double)*/ v, double /*(double)*/ midpoint, double /*(double)*/ sharpness);

// int RemovePoint(double x)
// int RemovePoint( double x )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_RemovePoint_0")] public static extern 
bool RemovePoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x);

// void AddRGBSegment(double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2)
// void AddRGBSegment( double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2 )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddRGBSegment_0")] public static extern 
bool AddRGBSegment_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ r1, double /*(double)*/ g1, double /*(double)*/ b1, double /*(double)*/ x2, double /*(double)*/ r2, double /*(double)*/ g2, double /*(double)*/ b2);

// void AddHSVSegment(double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2)
// void AddHSVSegment( double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2 )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AddHSVSegment_0")] public static extern 
bool AddHSVSegment_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ h1, double /*(double)*/ s1, double /*(double)*/ v1, double /*(double)*/ x2, double /*(double)*/ h2, double /*(double)*/ s2, double /*(double)*/ v2);

// void RemoveAllPoints()
// void RemoveAllPoints()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_RemoveAllPoints_0")] public static extern 
bool RemoveAllPoints_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// double* GetColor(double x)
// double *GetColor(double x)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x);

// void GetColor(double x, double rgb[3])
// void GetColor(double x, double rgb[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetColor_1")] public static extern 
bool GetColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x, double /*(double[3])*/ []rgb);

// double GetRedValue(double x)
// double GetRedValue( double x )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetRedValue_0")] public static extern 
bool GetRedValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x);

// double GetGreenValue(double x)
// double GetGreenValue( double x )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetGreenValue_0")] public static extern 
bool GetGreenValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x);

// double GetBlueValue(double x)
// double GetBlueValue( double x )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetBlueValue_0")] public static extern 
bool GetBlueValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x);

// int GetNodeValue(int index, double val[6])
// int GetNodeValue( int index, double val[6] )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetNodeValue_0")] public static extern 
bool GetNodeValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ index, double /*(double[6])*/ []val);

// int SetNodeValue(int index, double val[6])
// int SetNodeValue( int index, double val[6] )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetNodeValue_0")] public static extern 
bool SetNodeValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ index, double /*(double[6])*/ []val);

// char* MapValue(double v)
// unsigned char *MapValue(double v)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_MapValue_0")] public static extern 
bool MapValue_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ v);

// double* GetRange()
// double* GetRange()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void GetRange(double & arg1, double & arg2)
// virtual void GetRange(double& arg1, double& arg2)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetRange_1")] public static extern 
bool GetRange_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(double&)*/ arg1, IntPtr /*(double&)*/ arg2);

// virtual void GetRange(double _arg[2])
// virtual void GetRange(double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetRange_2")] public static extern 
bool GetRange_2(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[2])*/ []_arg);

// int AdjustRange(double range[2])
// int AdjustRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AdjustRange_0")] public static extern 
bool AdjustRange_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[2])*/ []range);

// void GetTable(double x1, double x2, int n, double * table)
// void GetTable( double x1, double x2, int n, double* table )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetTable_0")] public static extern 
bool GetTable_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ n, IntPtr /*(double*)*/ table);

// void GetTable(double x1, double x2, int n, float * table)
// void GetTable( double x1, double x2, int n, float* table )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetTable_1")] public static extern 
bool GetTable_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ n, IntPtr /*(float*)*/ table);

// char* GetTable(double x1, double x2, int n)
// const unsigned char *GetTable( double x1, double x2, int n )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetTable_2")] public static extern 
bool GetTable_2(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ n);

// void BuildFunctionFromTable(double x1, double x2, int size, double * table)
// void BuildFunctionFromTable( double x1, double x2, int size, double *table )
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_BuildFunctionFromTable_0")] public static extern 
bool BuildFunctionFromTable_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, IntPtr /*(double*)*/ table);

// virtual void SetClamping(int _arg)
// virtual void SetClamping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetClamping_0")] public static extern 
bool SetClamping_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetClampingMinValue()
// virtual int GetClampingMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetClampingMinValue_0")] public static extern 
bool GetClampingMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual int GetClampingMaxValue()
// virtual int GetClampingMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetClampingMaxValue_0")] public static extern 
bool GetClampingMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual int GetClamping()
// virtual int GetClamping ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetClamping_0")] public static extern 
bool GetClamping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void ClampingOn()
// virtual void ClampingOn ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_ClampingOn_0")] public static extern 
bool ClampingOn_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void ClampingOff()
// virtual void ClampingOff ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_ClampingOff_0")] public static extern 
bool ClampingOff_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void SetColorSpace(int _arg)
// virtual void SetColorSpace (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpace_0")] public static extern 
bool SetColorSpace_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetColorSpaceMinValue()
// virtual int GetColorSpaceMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetColorSpaceMinValue_0")] public static extern 
bool GetColorSpaceMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual int GetColorSpaceMaxValue()
// virtual int GetColorSpaceMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetColorSpaceMaxValue_0")] public static extern 
bool GetColorSpaceMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetColorSpaceToRGB()
// void SetColorSpaceToRGB()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpaceToRGB_0")] public static extern 
bool SetColorSpaceToRGB_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetColorSpaceToHSV()
// void SetColorSpaceToHSV()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpaceToHSV_0")] public static extern 
bool SetColorSpaceToHSV_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetColorSpaceToLab()
// void SetColorSpaceToLab()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpaceToLab_0")] public static extern 
bool SetColorSpaceToLab_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetColorSpaceToLabCIEDE2000()
// void SetColorSpaceToLabCIEDE2000()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpaceToLabCIEDE2000_0")] public static extern 
bool SetColorSpaceToLabCIEDE2000_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetColorSpaceToDiverging()
// void SetColorSpaceToDiverging()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetColorSpaceToDiverging_0")] public static extern 
bool SetColorSpaceToDiverging_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual int GetColorSpace()
// virtual int GetColorSpace ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetColorSpace_0")] public static extern 
bool GetColorSpace_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void SetHSVWrap(int _arg)
// virtual void SetHSVWrap (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetHSVWrap_0")] public static extern 
bool SetHSVWrap_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetHSVWrap()
// virtual int GetHSVWrap ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetHSVWrap_0")] public static extern 
bool GetHSVWrap_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void HSVWrapOn()
// virtual void HSVWrapOn ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_HSVWrapOn_0")] public static extern 
bool HSVWrapOn_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void HSVWrapOff()
// virtual void HSVWrapOff ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_HSVWrapOff_0")] public static extern 
bool HSVWrapOff_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void SetScale(int _arg)
// virtual void SetScale (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetScale_0")] public static extern 
bool SetScale_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// void SetScaleToLinear()
// void SetScaleToLinear()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetScaleToLinear_0")] public static extern 
bool SetScaleToLinear_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void SetScaleToLog10()
// void SetScaleToLog10()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetScaleToLog10_0")] public static extern 
bool SetScaleToLog10_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual int GetScale()
// virtual int GetScale ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetScale_0")] public static extern 
bool GetScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void SetNanColor(double _arg1, double _arg2, double _arg3)
// virtual void SetNanColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetNanColor_0")] public static extern 
bool SetNanColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetNanColor(double _arg[3])
// virtual void SetNanColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetNanColor_1")] public static extern 
bool SetNanColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetNanColor()
// virtual double *GetNanColor ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetNanColor_0")] public static extern 
bool GetNanColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void GetNanColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetNanColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetNanColor_1")] public static extern 
bool GetNanColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetNanColor(double _arg[3])
// virtual void GetNanColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetNanColor_2")] public static extern 
bool GetNanColor_2(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3)
// virtual void SetBelowRangeColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetBelowRangeColor_0")] public static extern 
bool SetBelowRangeColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetBelowRangeColor(double _arg[3])
// virtual void SetBelowRangeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetBelowRangeColor_1")] public static extern 
bool SetBelowRangeColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetBelowRangeColor()
// virtual double *GetBelowRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetBelowRangeColor_0")] public static extern 
bool GetBelowRangeColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void GetBelowRangeColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetBelowRangeColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetBelowRangeColor_1")] public static extern 
bool GetBelowRangeColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetBelowRangeColor(double _arg[3])
// virtual void GetBelowRangeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetBelowRangeColor_2")] public static extern 
bool GetBelowRangeColor_2(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetUseBelowRangeColor(int _arg)
// virtual void SetUseBelowRangeColor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetUseBelowRangeColor_0")] public static extern 
bool SetUseBelowRangeColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseBelowRangeColor()
// virtual int GetUseBelowRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetUseBelowRangeColor_0")] public static extern 
bool GetUseBelowRangeColor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void UseBelowRangeColorOn()
// virtual void UseBelowRangeColorOn ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_UseBelowRangeColorOn_0")] public static extern 
bool UseBelowRangeColorOn_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void UseBelowRangeColorOff()
// virtual void UseBelowRangeColorOff ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_UseBelowRangeColorOff_0")] public static extern 
bool UseBelowRangeColorOff_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3)
// virtual void SetAboveRangeColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetAboveRangeColor_0")] public static extern 
bool SetAboveRangeColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetAboveRangeColor(double _arg[3])
// virtual void SetAboveRangeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetAboveRangeColor_1")] public static extern 
bool SetAboveRangeColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetAboveRangeColor()
// virtual double *GetAboveRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetAboveRangeColor_0")] public static extern 
bool GetAboveRangeColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void GetAboveRangeColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetAboveRangeColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetAboveRangeColor_1")] public static extern 
bool GetAboveRangeColor_1(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetAboveRangeColor(double _arg[3])
// virtual void GetAboveRangeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetAboveRangeColor_2")] public static extern 
bool GetAboveRangeColor_2(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetUseAboveRangeColor(int _arg)
// virtual void SetUseAboveRangeColor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetUseAboveRangeColor_0")] public static extern 
bool SetUseAboveRangeColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseAboveRangeColor()
// virtual int GetUseAboveRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetUseAboveRangeColor_0")] public static extern 
bool GetUseAboveRangeColor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void UseAboveRangeColorOn()
// virtual void UseAboveRangeColorOn ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_UseAboveRangeColorOn_0")] public static extern 
bool UseAboveRangeColorOn_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void UseAboveRangeColorOff()
// virtual void UseAboveRangeColorOff ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_UseAboveRangeColorOff_0")] public static extern 
bool UseAboveRangeColorOff_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// double* GetDataPointer()
// double* GetDataPointer()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetDataPointer_0")] public static extern 
bool GetDataPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void FillFromDataPointer(int n, double * ptr)
// void FillFromDataPointer(int n, double* ptr)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_FillFromDataPointer_0")] public static extern 
bool FillFromDataPointer_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ n, IntPtr /*(double*)*/ ptr);

// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement);

// virtual void SetAllowDuplicateScalars(int _arg)
// virtual void SetAllowDuplicateScalars (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_SetAllowDuplicateScalars_0")] public static extern 
bool SetAllowDuplicateScalars_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAllowDuplicateScalars()
// virtual int GetAllowDuplicateScalars ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetAllowDuplicateScalars_0")] public static extern 
bool GetAllowDuplicateScalars_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void AllowDuplicateScalarsOn()
// virtual void AllowDuplicateScalarsOn ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AllowDuplicateScalarsOn_0")] public static extern 
bool AllowDuplicateScalarsOn_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// virtual void AllowDuplicateScalarsOff()
// virtual void AllowDuplicateScalarsOff ()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_AllowDuplicateScalarsOff_0")] public static extern 
bool AllowDuplicateScalarsOff_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// vtkIdType GetNumberOfAvailableColors()
// vtkIdType GetNumberOfAvailableColors()
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject);

// void GetIndexedColor(vtkIdType idx, double rgba[4])
// void GetIndexedColor(vtkIdType idx, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_GetIndexedColor_0")] public static extern 
bool GetIndexedColor_0(IntPtr /*(vtkColorTransferFunction*)*/ callingObject, long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba);

// int EstimateMinNumberOfSamples(double const& x1, double const& x2)
// int EstimateMinNumberOfSamples(double const & x1, double const & x2)
[DllImport("vtkplugin", EntryPoint="vtkColorTransferFunction_EstimateMinNumberOfSamples_0")] public static extern 
bool EstimateMinNumberOfSamples_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkColorTransferFunction*)*/ callingObject, IntPtr /*(doubleconst&)*/ x1, IntPtr /*(doubleconst&)*/ x2);

}
};
