
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLookupTable {

// static vtkLookupTable* New()
// static vtkLookupTable *New()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, string /*(char*)*/ type);

// static vtkLookupTable* SafeDownCast(vtkObjectBase * o)
// static vtkLookupTable* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkLookupTable* NewInstance()
// vtkLookupTable *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// int IsOpaque()
// int IsOpaque()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_IsOpaque_0")] public static extern 
bool IsOpaque_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// int Allocate(int sz = 256, int ext = 256)
// int Allocate(int sz=256, int ext=256)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ sz, int /*(int)*/ ext);

// void Build()
// void Build()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_Build_0")] public static extern 
bool Build_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void ForceBuild()
// virtual void ForceBuild()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_ForceBuild_0")] public static extern 
bool ForceBuild_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void BuildSpecialColors()
// void BuildSpecialColors()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_BuildSpecialColors_0")] public static extern 
bool BuildSpecialColors_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetRamp(int _arg)
// virtual void SetRamp (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRamp_0")] public static extern 
bool SetRamp_0(IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ _arg);

// void SetRampToLinear()
// void SetRampToLinear()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToLinear_0")] public static extern 
bool SetRampToLinear_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRampToSCurve()
// void SetRampToSCurve()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToSCurve_0")] public static extern 
bool SetRampToSCurve_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRampToSQRT()
// void SetRampToSQRT()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToSQRT_0")] public static extern 
bool SetRampToSQRT_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual int GetRamp()
// virtual int GetRamp ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetRamp_0")] public static extern 
bool GetRamp_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetScale(int scale)
// void SetScale(int scale)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScale_0")] public static extern 
bool SetScale_0(IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ scale);

// void SetScaleToLinear()
// void SetScaleToLinear()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScaleToLinear_0")] public static extern 
bool SetScaleToLinear_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetScaleToLog10()
// void SetScaleToLog10()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScaleToLog10_0")] public static extern 
bool SetScaleToLog10_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual int GetScale()
// virtual int GetScale ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetScale_0")] public static extern 
bool GetScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetTableRange(const double r[2])
// virtual void SetTableRange(const double r[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableRange_0")] public static extern 
bool SetTableRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []r);

// virtual void SetTableRange(double min, double max)
// virtual void SetTableRange(double min, double max)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableRange_1")] public static extern 
bool SetTableRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ min, double /*(double)*/ max);

// virtual double* GetTableRange()
// virtual double *GetTableRange ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableRange_0")] public static extern 
bool GetTableRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetTableRange(double data[2])
// virtual void GetTableRange (double data[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableRange_1")] public static extern 
bool GetTableRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []data);

// virtual void SetHueRange(double _arg1, double _arg2)
// virtual void SetHueRange (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetHueRange_0")] public static extern 
bool SetHueRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetHueRange(double _arg[2])
// void SetHueRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetHueRange_1")] public static extern 
bool SetHueRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetHueRange()
// virtual double *GetHueRange ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetHueRange_0")] public static extern 
bool GetHueRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetHueRange(double & _arg1, double & _arg2)
// virtual void GetHueRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetHueRange_1")] public static extern 
bool GetHueRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetHueRange(double _arg[2])
// virtual void GetHueRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetHueRange_2")] public static extern 
bool GetHueRange_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual void SetSaturationRange(double _arg1, double _arg2)
// virtual void SetSaturationRange (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetSaturationRange_0")] public static extern 
bool SetSaturationRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetSaturationRange(double _arg[2])
// void SetSaturationRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetSaturationRange_1")] public static extern 
bool SetSaturationRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetSaturationRange()
// virtual double *GetSaturationRange ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetSaturationRange_0")] public static extern 
bool GetSaturationRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetSaturationRange(double & _arg1, double & _arg2)
// virtual void GetSaturationRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetSaturationRange_1")] public static extern 
bool GetSaturationRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetSaturationRange(double _arg[2])
// virtual void GetSaturationRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetSaturationRange_2")] public static extern 
bool GetSaturationRange_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual void SetValueRange(double _arg1, double _arg2)
// virtual void SetValueRange (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetValueRange_0")] public static extern 
bool SetValueRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetValueRange(double _arg[2])
// void SetValueRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetValueRange_1")] public static extern 
bool SetValueRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetValueRange()
// virtual double *GetValueRange ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetValueRange_0")] public static extern 
bool GetValueRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetValueRange(double & _arg1, double & _arg2)
// virtual void GetValueRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetValueRange_1")] public static extern 
bool GetValueRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetValueRange(double _arg[2])
// virtual void GetValueRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetValueRange_2")] public static extern 
bool GetValueRange_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual void SetAlphaRange(double _arg1, double _arg2)
// virtual void SetAlphaRange (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetAlphaRange_0")] public static extern 
bool SetAlphaRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetAlphaRange(double _arg[2])
// void SetAlphaRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetAlphaRange_1")] public static extern 
bool SetAlphaRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetAlphaRange()
// virtual double *GetAlphaRange ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAlphaRange_0")] public static extern 
bool GetAlphaRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetAlphaRange(double & _arg1, double & _arg2)
// virtual void GetAlphaRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAlphaRange_1")] public static extern 
bool GetAlphaRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetAlphaRange(double _arg[2])
// virtual void GetAlphaRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAlphaRange_2")] public static extern 
bool GetAlphaRange_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual void SetNanColor(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetNanColor (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetNanColor_0")] public static extern 
bool SetNanColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetNanColor(double _arg[4])
// virtual void SetNanColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetNanColor_1")] public static extern 
bool SetNanColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetNanColor()
// virtual double *GetNanColor ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNanColor_0")] public static extern 
bool GetNanColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetNanColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// virtual void GetNanColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNanColor_1")] public static extern 
bool GetNanColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4);

// virtual void GetNanColor(double _arg[4])
// virtual void GetNanColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNanColor_2")] public static extern 
bool GetNanColor_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// char* GetNanColorAsUnsignedChars()
// unsigned char* GetNanColorAsUnsignedChars()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNanColorAsUnsignedChars_0")] public static extern 
bool GetNanColorAsUnsignedChars_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetColorAsUnsignedChars_0")] public static extern 
bool GetColorAsUnsignedChars_0(double /*(double[4])*/ []colorIn, char /*(unsigned char[4])*/ []colorOut);

// virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetBelowRangeColor (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetBelowRangeColor_0")] public static extern 
bool SetBelowRangeColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetBelowRangeColor(double _arg[4])
// virtual void SetBelowRangeColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetBelowRangeColor_1")] public static extern 
bool SetBelowRangeColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetBelowRangeColor()
// virtual double *GetBelowRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetBelowRangeColor_0")] public static extern 
bool GetBelowRangeColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetBelowRangeColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// virtual void GetBelowRangeColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetBelowRangeColor_1")] public static extern 
bool GetBelowRangeColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4);

// virtual void GetBelowRangeColor(double _arg[4])
// virtual void GetBelowRangeColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetBelowRangeColor_2")] public static extern 
bool GetBelowRangeColor_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual void SetUseBelowRangeColor(int _arg)
// virtual void SetUseBelowRangeColor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetUseBelowRangeColor_0")] public static extern 
bool SetUseBelowRangeColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseBelowRangeColor()
// virtual int GetUseBelowRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetUseBelowRangeColor_0")] public static extern 
bool GetUseBelowRangeColor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void UseBelowRangeColorOn()
// virtual void UseBelowRangeColorOn ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UseBelowRangeColorOn_0")] public static extern 
bool UseBelowRangeColorOn_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void UseBelowRangeColorOff()
// virtual void UseBelowRangeColorOff ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UseBelowRangeColorOff_0")] public static extern 
bool UseBelowRangeColorOff_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetAboveRangeColor (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetAboveRangeColor_0")] public static extern 
bool SetAboveRangeColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetAboveRangeColor(double _arg[4])
// virtual void SetAboveRangeColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetAboveRangeColor_1")] public static extern 
bool SetAboveRangeColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetAboveRangeColor()
// virtual double *GetAboveRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAboveRangeColor_0")] public static extern 
bool GetAboveRangeColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void GetAboveRangeColor(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// virtual void GetAboveRangeColor (double &_arg1, double &_arg2, double &_arg3, double &_arg4)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAboveRangeColor_1")] public static extern 
bool GetAboveRangeColor_1(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4);

// virtual void GetAboveRangeColor(double _arg[4])
// virtual void GetAboveRangeColor (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetAboveRangeColor_2")] public static extern 
bool GetAboveRangeColor_2(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual void SetUseAboveRangeColor(int _arg)
// virtual void SetUseAboveRangeColor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetUseAboveRangeColor_0")] public static extern 
bool SetUseAboveRangeColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseAboveRangeColor()
// virtual int GetUseAboveRangeColor ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetUseAboveRangeColor_0")] public static extern 
bool GetUseAboveRangeColor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void UseAboveRangeColorOn()
// virtual void UseAboveRangeColorOn ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UseAboveRangeColorOn_0")] public static extern 
bool UseAboveRangeColorOn_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void UseAboveRangeColorOff()
// virtual void UseAboveRangeColorOff ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UseAboveRangeColorOff_0")] public static extern 
bool UseAboveRangeColorOff_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// char* MapValue(double v)
// unsigned char* MapValue(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_MapValue_0")] public static extern 
bool MapValue_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// void GetColor(double x, double rgb[3])
// void GetColor(double x, double rgb[3])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ x, double /*(double[3])*/ []rgb);

// double GetOpacity(double v)
// double GetOpacity(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetOpacity_0")] public static extern 
bool GetOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// virtual vtkIdType GetIndex(double v)
// virtual vtkIdType GetIndex(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetIndex_0")] public static extern 
bool GetIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// void SetNumberOfTableValues(vtkIdType number)
// void SetNumberOfTableValues(vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetNumberOfTableValues_0")] public static extern 
bool SetNumberOfTableValues_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ number);

// vtkIdType GetNumberOfTableValues()
// vtkIdType GetNumberOfTableValues()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfTableValues_0")] public static extern 
bool GetNumberOfTableValues_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableValue_0")] public static extern 
bool SetTableValue_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ indx, double /*(double[4])*/ []rgba);

// double* GetTableValue(vtkIdType id)
// double *GetTableValue(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableValue_0")] public static extern 
bool GetTableValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id);

// void GetTableValue(vtkIdType id, double rgba[4])
// void GetTableValue(vtkIdType id, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableValue_1")] public static extern 
bool GetTableValue_1(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[4])*/ []rgba);

// char* GetPointer(vtkIdType id)
// unsigned char *GetPointer(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetPointer_0")] public static extern 
bool GetPointer_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id);

// char* WritePointer(vtkIdType id, int number)
// unsigned char *WritePointer(vtkIdType id, int number)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_WritePointer_0")] public static extern 
bool WritePointer_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id, int /*(int)*/ number);

// double* GetRange()
// double *GetRange()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRange(double min, double max)
// void SetRange(double min, double max)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRange_0")] public static extern 
bool SetRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ min, double /*(double)*/ max);

// void SetRange(const double rng[2])
// void SetRange(const double rng[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRange_1")] public static extern 
bool SetRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []rng);

// static void GetLogRange(const double range[2], double log_range[2])
// static void GetLogRange(const double range[2], double log_range[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetLogRange_0")] public static extern 
bool GetLogRange_0(double /*(double[2])*/ []range, double /*(double[2])*/ []log_range);

// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_ApplyLogScale_0")] public static extern 
bool ApplyLogScale_0(IntPtr /*(IntPtr*)*/ return_value, double /*(double)*/ v, double /*(double[2])*/ []range, double /*(double[2])*/ []log_range);

// virtual void SetNumberOfColors(vtkIdType _arg)
// virtual void SetNumberOfColors (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetNumberOfColors_0")] public static extern 
bool SetNumberOfColors_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetNumberOfColorsMinValue()
// virtual vtkIdType GetNumberOfColorsMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfColorsMinValue_0")] public static extern 
bool GetNumberOfColorsMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual vtkIdType GetNumberOfColorsMaxValue()
// virtual vtkIdType GetNumberOfColorsMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfColorsMaxValue_0")] public static extern 
bool GetNumberOfColorsMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual vtkIdType GetNumberOfColors()
// virtual vtkIdType GetNumberOfColors ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfColors_0")] public static extern 
bool GetNumberOfColors_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetTable(vtkUnsignedCharArray * ARG_0)
// void SetTable(vtkUnsignedCharArray *)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTable_0")] public static extern 
bool SetTable_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(vtkUnsignedCharArray*)*/ ARG_0);

// virtual vtkUnsignedCharArray* GetTable()
// virtual vtkUnsignedCharArray *GetTable ()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTable_0")] public static extern 
bool GetTable_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement);

// void DeepCopy(vtkScalarsToColors * lut)
// void DeepCopy(vtkScalarsToColors *lut)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ lut);

// int UsingLogScale()
// int UsingLogScale()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UsingLogScale_0")] public static extern 
bool UsingLogScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// vtkIdType GetNumberOfAvailableColors()
// vtkIdType GetNumberOfAvailableColors()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void GetIndexedColor(vtkIdType idx, double rgba[4])
// void GetIndexedColor(vtkIdType idx, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetIndexedColor_0")] public static extern 
bool GetIndexedColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba);

}
};
