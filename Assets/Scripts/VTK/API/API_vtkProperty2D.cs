
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProperty2D {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject, string /*(char*)*/ type);

// static vtkProperty2D* SafeDownCast(vtkObjectBase * o)
// static vtkProperty2D* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProperty2D* NewInstance()
// vtkProperty2D *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// static vtkProperty2D* New()
// static vtkProperty2D *New()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void DeepCopy(vtkProperty2D * p)
// void DeepCopy(vtkProperty2D *p)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkProperty2D*)*/ callingObject, IntPtr /*(vtkProperty2D*)*/ p);

// virtual void SetColor(double _arg1, double _arg2, double _arg3)
// virtual void SetColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetColor_0")] public static extern 
bool SetColor_0(IntPtr /*(vtkProperty2D*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetColor(double _arg[3])
// virtual void SetColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetColor_1")] public static extern 
bool SetColor_1(IntPtr /*(vtkProperty2D*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetColor()
// virtual double *GetColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void GetColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetColor_1")] public static extern 
bool GetColor_1(IntPtr /*(vtkProperty2D*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetColor(double _arg[3])
// virtual void GetColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetColor_2")] public static extern 
bool GetColor_2(IntPtr /*(vtkProperty2D*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double GetOpacity()
// virtual double GetOpacity ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetOpacity_0")] public static extern 
bool GetOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void SetOpacity(double _arg)
// virtual void SetOpacity (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetOpacity_0")] public static extern 
bool SetOpacity_0(IntPtr /*(vtkProperty2D*)*/ callingObject, double /*(double)*/ _arg);

// virtual void SetPointSize(float _arg)
// virtual void SetPointSize (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetPointSize_0")] public static extern 
bool SetPointSize_0(IntPtr /*(vtkProperty2D*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetPointSizeMinValue()
// virtual float GetPointSizeMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetPointSizeMinValue_0")] public static extern 
bool GetPointSizeMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual float GetPointSizeMaxValue()
// virtual float GetPointSizeMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetPointSizeMaxValue_0")] public static extern 
bool GetPointSizeMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual float GetPointSize()
// virtual float GetPointSize ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetPointSize_0")] public static extern 
bool GetPointSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void SetLineWidth(float _arg)
// virtual void SetLineWidth (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetLineWidth_0")] public static extern 
bool SetLineWidth_0(IntPtr /*(vtkProperty2D*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetLineWidthMinValue()
// virtual float GetLineWidthMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineWidthMinValue_0")] public static extern 
bool GetLineWidthMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual float GetLineWidthMaxValue()
// virtual float GetLineWidthMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineWidthMaxValue_0")] public static extern 
bool GetLineWidthMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual float GetLineWidth()
// virtual float GetLineWidth ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineWidth_0")] public static extern 
bool GetLineWidth_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void SetLineStipplePattern(int _arg)
// virtual void SetLineStipplePattern (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetLineStipplePattern_0")] public static extern 
bool SetLineStipplePattern_0(IntPtr /*(vtkProperty2D*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLineStipplePattern()
// virtual int GetLineStipplePattern ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineStipplePattern_0")] public static extern 
bool GetLineStipplePattern_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void SetLineStippleRepeatFactor(int _arg)
// virtual void SetLineStippleRepeatFactor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetLineStippleRepeatFactor_0")] public static extern 
bool SetLineStippleRepeatFactor_0(IntPtr /*(vtkProperty2D*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLineStippleRepeatFactorMinValue()
// virtual int GetLineStippleRepeatFactorMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineStippleRepeatFactorMinValue_0")] public static extern 
bool GetLineStippleRepeatFactorMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual int GetLineStippleRepeatFactorMaxValue()
// virtual int GetLineStippleRepeatFactorMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineStippleRepeatFactorMaxValue_0")] public static extern 
bool GetLineStippleRepeatFactorMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual int GetLineStippleRepeatFactor()
// virtual int GetLineStippleRepeatFactor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetLineStippleRepeatFactor_0")] public static extern 
bool GetLineStippleRepeatFactor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void SetDisplayLocation(int _arg)
// virtual void SetDisplayLocation (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetDisplayLocation_0")] public static extern 
bool SetDisplayLocation_0(IntPtr /*(vtkProperty2D*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDisplayLocationMinValue()
// virtual int GetDisplayLocationMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetDisplayLocationMinValue_0")] public static extern 
bool GetDisplayLocationMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual int GetDisplayLocationMaxValue()
// virtual int GetDisplayLocationMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetDisplayLocationMaxValue_0")] public static extern 
bool GetDisplayLocationMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual int GetDisplayLocation()
// virtual int GetDisplayLocation ()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_GetDisplayLocation_0")] public static extern 
bool GetDisplayLocation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty2D*)*/ callingObject);

// void SetDisplayLocationToBackground()
// void SetDisplayLocationToBackground()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetDisplayLocationToBackground_0")] public static extern 
bool SetDisplayLocationToBackground_0(IntPtr /*(vtkProperty2D*)*/ callingObject);

// void SetDisplayLocationToForeground()
// void SetDisplayLocationToForeground()
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_SetDisplayLocationToForeground_0")] public static extern 
bool SetDisplayLocationToForeground_0(IntPtr /*(vtkProperty2D*)*/ callingObject);

// virtual void Render(vtkViewport * ARG_0)
// virtual void Render (vtkViewport* )
[DllImport("vtkplugin", EntryPoint="vtkProperty2D_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkProperty2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

}
};
