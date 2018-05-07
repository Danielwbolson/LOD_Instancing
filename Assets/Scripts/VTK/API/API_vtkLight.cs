
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLight {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLight_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLight_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject, string /*(char*)*/ type);

// static vtkLight* SafeDownCast(vtkObjectBase * o)
// static vtkLight* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLight_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkLight* NewInstance()
// vtkLight *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkLight_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// static vtkLight* New()
// static vtkLight *New()
[DllImport("vtkplugin", EntryPoint="vtkLight_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual vtkLight* ShallowClone()
// virtual vtkLight *ShallowClone()
[DllImport("vtkplugin", EntryPoint="vtkLight_ShallowClone_0")] public static extern 
bool ShallowClone_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void Render(vtkRenderer * ARG_0, int ARG_1)
// virtual void Render(vtkRenderer *, int)
[DllImport("vtkplugin", EntryPoint="vtkLight_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0, int /*(int)*/ ARG_1);

// virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
// virtual void SetAmbientColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetAmbientColor_0")] public static extern 
bool SetAmbientColor_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetAmbientColor(double _arg[3])
// virtual void SetAmbientColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetAmbientColor_1")] public static extern 
bool SetAmbientColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetAmbientColor()
// virtual double *GetAmbientColor ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetAmbientColor_0")] public static extern 
bool GetAmbientColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetAmbientColor(double data[3])
// virtual void GetAmbientColor (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetAmbientColor_1")] public static extern 
bool GetAmbientColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
// virtual void SetDiffuseColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetDiffuseColor_0")] public static extern 
bool SetDiffuseColor_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetDiffuseColor(double _arg[3])
// virtual void SetDiffuseColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetDiffuseColor_1")] public static extern 
bool SetDiffuseColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetDiffuseColor()
// virtual double *GetDiffuseColor ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetDiffuseColor_0")] public static extern 
bool GetDiffuseColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetDiffuseColor(double data[3])
// virtual void GetDiffuseColor (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetDiffuseColor_1")] public static extern 
bool GetDiffuseColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
// virtual void SetSpecularColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetSpecularColor_0")] public static extern 
bool SetSpecularColor_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetSpecularColor(double _arg[3])
// virtual void SetSpecularColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetSpecularColor_1")] public static extern 
bool SetSpecularColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetSpecularColor()
// virtual double *GetSpecularColor ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetSpecularColor_0")] public static extern 
bool GetSpecularColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetSpecularColor(double data[3])
// virtual void GetSpecularColor (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetSpecularColor_1")] public static extern 
bool GetSpecularColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// void SetColor(double ARG_0, double ARG_1, double ARG_2)
// void SetColor(double, double, double)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetColor_0")] public static extern 
bool SetColor_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ ARG_0, double /*(double)*/ ARG_1, double /*(double)*/ ARG_2);

// void SetColor(const double a[3])
// void SetColor(const double a[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetColor_1")] public static extern 
bool SetColor_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []a);

// virtual void SetPosition(double _arg1, double _arg2, double _arg3)
// virtual void SetPosition (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetPosition_0")] public static extern 
bool SetPosition_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetPosition(double _arg[3])
// virtual void SetPosition (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetPosition_1")] public static extern 
bool SetPosition_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetPosition()
// virtual double *GetPosition ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetPosition(double data[3])
// virtual void GetPosition (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetPosition_1")] public static extern 
bool GetPosition_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// void SetPosition(const float * a)
// void SetPosition(const float *a)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetPosition_2")] public static extern 
bool SetPosition_2(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(float*)*/ a);

// virtual void SetFocalPoint(double _arg1, double _arg2, double _arg3)
// virtual void SetFocalPoint (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetFocalPoint_0")] public static extern 
bool SetFocalPoint_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetFocalPoint(double _arg[3])
// virtual void SetFocalPoint (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetFocalPoint_1")] public static extern 
bool SetFocalPoint_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetFocalPoint()
// virtual double *GetFocalPoint ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetFocalPoint_0")] public static extern 
bool GetFocalPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetFocalPoint(double data[3])
// virtual void GetFocalPoint (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetFocalPoint_1")] public static extern 
bool GetFocalPoint_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// void SetFocalPoint(const float * a)
// void SetFocalPoint(const float *a)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetFocalPoint_2")] public static extern 
bool SetFocalPoint_2(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(float*)*/ a);

// virtual void SetIntensity(double _arg)
// virtual void SetIntensity (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetIntensity_0")] public static extern 
bool SetIntensity_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetIntensity()
// virtual double GetIntensity ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetIntensity_0")] public static extern 
bool GetIntensity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetSwitch(int _arg)
// virtual void SetSwitch (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetSwitch_0")] public static extern 
bool SetSwitch_0(IntPtr /*(vtkLight*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetSwitch()
// virtual int GetSwitch ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetSwitch_0")] public static extern 
bool GetSwitch_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SwitchOn()
// virtual void SwitchOn ()
[DllImport("vtkplugin", EntryPoint="vtkLight_SwitchOn_0")] public static extern 
bool SwitchOn_0(IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SwitchOff()
// virtual void SwitchOff ()
[DllImport("vtkplugin", EntryPoint="vtkLight_SwitchOff_0")] public static extern 
bool SwitchOff_0(IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetPositional(int _arg)
// virtual void SetPositional (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetPositional_0")] public static extern 
bool SetPositional_0(IntPtr /*(vtkLight*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPositional()
// virtual int GetPositional ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetPositional_0")] public static extern 
bool GetPositional_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void PositionalOn()
// virtual void PositionalOn ()
[DllImport("vtkplugin", EntryPoint="vtkLight_PositionalOn_0")] public static extern 
bool PositionalOn_0(IntPtr /*(vtkLight*)*/ callingObject);

// virtual void PositionalOff()
// virtual void PositionalOff ()
[DllImport("vtkplugin", EntryPoint="vtkLight_PositionalOff_0")] public static extern 
bool PositionalOff_0(IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetExponent(double _arg)
// virtual void SetExponent (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetExponent_0")] public static extern 
bool SetExponent_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetExponentMinValue()
// virtual double GetExponentMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetExponentMinValue_0")] public static extern 
bool GetExponentMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual double GetExponentMaxValue()
// virtual double GetExponentMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetExponentMaxValue_0")] public static extern 
bool GetExponentMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual double GetExponent()
// virtual double GetExponent ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetExponent_0")] public static extern 
bool GetExponent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetConeAngle(double _arg)
// virtual void SetConeAngle (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetConeAngle_0")] public static extern 
bool SetConeAngle_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetConeAngle()
// virtual double GetConeAngle ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetConeAngle_0")] public static extern 
bool GetConeAngle_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetAttenuationValues(double _arg1, double _arg2, double _arg3)
// virtual void SetAttenuationValues (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetAttenuationValues_0")] public static extern 
bool SetAttenuationValues_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetAttenuationValues(double _arg[3])
// virtual void SetAttenuationValues (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetAttenuationValues_1")] public static extern 
bool SetAttenuationValues_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetAttenuationValues()
// virtual double *GetAttenuationValues ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetAttenuationValues_0")] public static extern 
bool GetAttenuationValues_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void GetAttenuationValues(double data[3])
// virtual void GetAttenuationValues (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetAttenuationValues_1")] public static extern 
bool GetAttenuationValues_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetTransformMatrix(vtkMatrix4x4 * ARG_0)
// virtual void SetTransformMatrix(vtkMatrix4x4*)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetTransformMatrix_0")] public static extern 
bool SetTransformMatrix_0(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ ARG_0);

// virtual vtkMatrix4x4* GetTransformMatrix()
// virtual vtkMatrix4x4 *GetTransformMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformMatrix_0")] public static extern 
bool GetTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// void GetTransformedPosition(double & a0, double & a1, double & a2)
// void GetTransformedPosition(double &a0, double &a1, double &a2)
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedPosition_0")] public static extern 
bool GetTransformedPosition_0(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(double&)*/ a0, IntPtr /*(double&)*/ a1, IntPtr /*(double&)*/ a2);

// void GetTransformedPosition(double a[3])
// void GetTransformedPosition(double a[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedPosition_1")] public static extern 
bool GetTransformedPosition_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []a);

// double* GetTransformedPosition()
// double *GetTransformedPosition()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedPosition_2")] public static extern 
bool GetTransformedPosition_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// void GetTransformedFocalPoint(double & a0, double & a1, double & a2)
// void GetTransformedFocalPoint(double &a0, double &a1, double &a2)
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedFocalPoint_0")] public static extern 
bool GetTransformedFocalPoint_0(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(double&)*/ a0, IntPtr /*(double&)*/ a1, IntPtr /*(double&)*/ a2);

// void GetTransformedFocalPoint(double a[3])
// void GetTransformedFocalPoint(double a[3])
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedFocalPoint_1")] public static extern 
bool GetTransformedFocalPoint_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[3])*/ []a);

// double* GetTransformedFocalPoint()
// double *GetTransformedFocalPoint()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetTransformedFocalPoint_2")] public static extern 
bool GetTransformedFocalPoint_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// void SetDirectionAngle(double elevation, double azimuth)
// void SetDirectionAngle(double elevation, double azimuth)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetDirectionAngle_0")] public static extern 
bool SetDirectionAngle_0(IntPtr /*(vtkLight*)*/ callingObject, double /*(double)*/ elevation, double /*(double)*/ azimuth);

// void SetDirectionAngle(const double ang[2])
// void SetDirectionAngle(const double ang[2])
[DllImport("vtkplugin", EntryPoint="vtkLight_SetDirectionAngle_1")] public static extern 
bool SetDirectionAngle_1(IntPtr /*(vtkLight*)*/ callingObject, double /*(double[2])*/ []ang);

// void DeepCopy(vtkLight * light)
// void DeepCopy(vtkLight *light)
[DllImport("vtkplugin", EntryPoint="vtkLight_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkLight*)*/ callingObject, IntPtr /*(vtkLight*)*/ light);

// virtual void SetLightType(int ARG_0)
// virtual void SetLightType(int)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetLightType_0")] public static extern 
bool SetLightType_0(IntPtr /*(vtkLight*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual int GetLightType()
// virtual int GetLightType ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetLightType_0")] public static extern 
bool GetLightType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// void SetLightTypeToHeadlight()
// void SetLightTypeToHeadlight()
[DllImport("vtkplugin", EntryPoint="vtkLight_SetLightTypeToHeadlight_0")] public static extern 
bool SetLightTypeToHeadlight_0(IntPtr /*(vtkLight*)*/ callingObject);

// void SetLightTypeToSceneLight()
// void SetLightTypeToSceneLight()
[DllImport("vtkplugin", EntryPoint="vtkLight_SetLightTypeToSceneLight_0")] public static extern 
bool SetLightTypeToSceneLight_0(IntPtr /*(vtkLight*)*/ callingObject);

// void SetLightTypeToCameraLight()
// void SetLightTypeToCameraLight()
[DllImport("vtkplugin", EntryPoint="vtkLight_SetLightTypeToCameraLight_0")] public static extern 
bool SetLightTypeToCameraLight_0(IntPtr /*(vtkLight*)*/ callingObject);

// int LightTypeIsHeadlight()
// int LightTypeIsHeadlight()
[DllImport("vtkplugin", EntryPoint="vtkLight_LightTypeIsHeadlight_0")] public static extern 
bool LightTypeIsHeadlight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// int LightTypeIsSceneLight()
// int LightTypeIsSceneLight()
[DllImport("vtkplugin", EntryPoint="vtkLight_LightTypeIsSceneLight_0")] public static extern 
bool LightTypeIsSceneLight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// int LightTypeIsCameraLight()
// int LightTypeIsCameraLight()
[DllImport("vtkplugin", EntryPoint="vtkLight_LightTypeIsCameraLight_0")] public static extern 
bool LightTypeIsCameraLight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

// virtual void SetShadowAttenuation(float _arg)
// virtual void SetShadowAttenuation (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkLight_SetShadowAttenuation_0")] public static extern 
bool SetShadowAttenuation_0(IntPtr /*(vtkLight*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetShadowAttenuation()
// virtual float GetShadowAttenuation ()
[DllImport("vtkplugin", EntryPoint="vtkLight_GetShadowAttenuation_0")] public static extern 
bool GetShadowAttenuation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLight*)*/ callingObject);

}
};
