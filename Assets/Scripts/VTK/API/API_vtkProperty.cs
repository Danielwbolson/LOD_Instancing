
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProperty {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProperty_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProperty_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ type);

// static vtkProperty* SafeDownCast(vtkObjectBase * o)
// static vtkProperty* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProperty* NewInstance()
// vtkProperty *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProperty_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// static vtkProperty* New()
// static vtkProperty *New()
[DllImport("vtkplugin", EntryPoint="vtkProperty_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void DeepCopy(vtkProperty * p)
// void DeepCopy(vtkProperty *p)
[DllImport("vtkplugin", EntryPoint="vtkProperty_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(vtkProperty*)*/ p);

// virtual void Render(vtkActor * ARG_0, vtkRenderer * ARG_1)
// virtual void Render(vtkActor *, vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkProperty_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(vtkActor*)*/ ARG_0, IntPtr /*(vtkRenderer*)*/ ARG_1);

// virtual void BackfaceRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// virtual void BackfaceRender(vtkActor *, vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkProperty_BackfaceRender_0")] public static extern 
bool BackfaceRender_0(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(vtkActor*)*/ ARG_0, IntPtr /*(vtkRenderer*)*/ ARG_1);

// virtual void PostRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// virtual void PostRender(vtkActor*, vtkRenderer*)
[DllImport("vtkplugin", EntryPoint="vtkProperty_PostRender_0")] public static extern 
bool PostRender_0(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(vtkActor*)*/ ARG_0, IntPtr /*(vtkRenderer*)*/ ARG_1);

// virtual bool GetLighting()
// virtual bool GetLighting ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLighting_0")] public static extern 
bool GetLighting_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetLighting(bool _arg)
// virtual void SetLighting (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetLighting_0")] public static extern 
bool SetLighting_0(IntPtr /*(vtkProperty*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void LightingOn()
// virtual void LightingOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_LightingOn_0")] public static extern 
bool LightingOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void LightingOff()
// virtual void LightingOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_LightingOff_0")] public static extern 
bool LightingOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual bool GetRenderPointsAsSpheres()
// virtual bool GetRenderPointsAsSpheres ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRenderPointsAsSpheres_0")] public static extern 
bool GetRenderPointsAsSpheres_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetRenderPointsAsSpheres(bool _arg)
// virtual void SetRenderPointsAsSpheres (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRenderPointsAsSpheres_0")] public static extern 
bool SetRenderPointsAsSpheres_0(IntPtr /*(vtkProperty*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void RenderPointsAsSpheresOn()
// virtual void RenderPointsAsSpheresOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_RenderPointsAsSpheresOn_0")] public static extern 
bool RenderPointsAsSpheresOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void RenderPointsAsSpheresOff()
// virtual void RenderPointsAsSpheresOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_RenderPointsAsSpheresOff_0")] public static extern 
bool RenderPointsAsSpheresOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual bool GetRenderLinesAsTubes()
// virtual bool GetRenderLinesAsTubes ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRenderLinesAsTubes_0")] public static extern 
bool GetRenderLinesAsTubes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetRenderLinesAsTubes(bool _arg)
// virtual void SetRenderLinesAsTubes (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRenderLinesAsTubes_0")] public static extern 
bool SetRenderLinesAsTubes_0(IntPtr /*(vtkProperty*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void RenderLinesAsTubesOn()
// virtual void RenderLinesAsTubesOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_RenderLinesAsTubesOn_0")] public static extern 
bool RenderLinesAsTubesOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void RenderLinesAsTubesOff()
// virtual void RenderLinesAsTubesOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_RenderLinesAsTubesOff_0")] public static extern 
bool RenderLinesAsTubesOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetInterpolation(int _arg)
// virtual void SetInterpolation (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetInterpolation_0")] public static extern 
bool SetInterpolation_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetInterpolationMinValue()
// virtual int GetInterpolationMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetInterpolationMinValue_0")] public static extern 
bool GetInterpolationMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetInterpolationMaxValue()
// virtual int GetInterpolationMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetInterpolationMaxValue_0")] public static extern 
bool GetInterpolationMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetInterpolation()
// virtual int GetInterpolation ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetInterpolation_0")] public static extern 
bool GetInterpolation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// void SetInterpolationToFlat()
// void SetInterpolationToFlat()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetInterpolationToFlat_0")] public static extern 
bool SetInterpolationToFlat_0(IntPtr /*(vtkProperty*)*/ callingObject);

// void SetInterpolationToGouraud()
// void SetInterpolationToGouraud()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetInterpolationToGouraud_0")] public static extern 
bool SetInterpolationToGouraud_0(IntPtr /*(vtkProperty*)*/ callingObject);

// void SetInterpolationToPhong()
// void SetInterpolationToPhong()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetInterpolationToPhong_0")] public static extern 
bool SetInterpolationToPhong_0(IntPtr /*(vtkProperty*)*/ callingObject);

// char* GetInterpolationAsString()
// const char *GetInterpolationAsString()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetInterpolationAsString_0")] public static extern 
bool GetInterpolationAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetRepresentation(int _arg)
// virtual void SetRepresentation (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRepresentation_0")] public static extern 
bool SetRepresentation_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetRepresentationMinValue()
// virtual int GetRepresentationMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRepresentationMinValue_0")] public static extern 
bool GetRepresentationMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetRepresentationMaxValue()
// virtual int GetRepresentationMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRepresentationMaxValue_0")] public static extern 
bool GetRepresentationMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetRepresentation()
// virtual int GetRepresentation ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRepresentation_0")] public static extern 
bool GetRepresentation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// void SetRepresentationToPoints()
// void SetRepresentationToPoints()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRepresentationToPoints_0")] public static extern 
bool SetRepresentationToPoints_0(IntPtr /*(vtkProperty*)*/ callingObject);

// void SetRepresentationToWireframe()
// void SetRepresentationToWireframe()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRepresentationToWireframe_0")] public static extern 
bool SetRepresentationToWireframe_0(IntPtr /*(vtkProperty*)*/ callingObject);

// void SetRepresentationToSurface()
// void SetRepresentationToSurface()
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetRepresentationToSurface_0")] public static extern 
bool SetRepresentationToSurface_0(IntPtr /*(vtkProperty*)*/ callingObject);

// char* GetRepresentationAsString()
// const char *GetRepresentationAsString()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetRepresentationAsString_0")] public static extern 
bool GetRepresentationAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetColor(double r, double g, double b)
// virtual void SetColor(double r, double g, double b)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetColor_0")] public static extern 
bool SetColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b);

// virtual void SetColor(double a[3])
// virtual void SetColor(double a[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetColor_1")] public static extern 
bool SetColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []a);

// double* GetColor()
// double *GetColor()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// void GetColor(double rgb[3])
// void GetColor(double rgb[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetColor_1")] public static extern 
bool GetColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []rgb);

// void GetColor(double & r, double & g, double & b)
// void GetColor(double &r, double &g, double &b)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetColor_2")] public static extern 
bool GetColor_2(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ r, IntPtr /*(double&)*/ g, IntPtr /*(double&)*/ b);

// virtual void SetAmbient(double _arg)
// virtual void SetAmbient (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetAmbient_0")] public static extern 
bool SetAmbient_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetAmbientMinValue()
// virtual double GetAmbientMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbientMinValue_0")] public static extern 
bool GetAmbientMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetAmbientMaxValue()
// virtual double GetAmbientMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbientMaxValue_0")] public static extern 
bool GetAmbientMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetAmbient()
// virtual double GetAmbient ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbient_0")] public static extern 
bool GetAmbient_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetDiffuse(double _arg)
// virtual void SetDiffuse (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetDiffuse_0")] public static extern 
bool SetDiffuse_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetDiffuseMinValue()
// virtual double GetDiffuseMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuseMinValue_0")] public static extern 
bool GetDiffuseMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetDiffuseMaxValue()
// virtual double GetDiffuseMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuseMaxValue_0")] public static extern 
bool GetDiffuseMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetDiffuse()
// virtual double GetDiffuse ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuse_0")] public static extern 
bool GetDiffuse_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetSpecular(double _arg)
// virtual void SetSpecular (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetSpecular_0")] public static extern 
bool SetSpecular_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetSpecularMinValue()
// virtual double GetSpecularMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularMinValue_0")] public static extern 
bool GetSpecularMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetSpecularMaxValue()
// virtual double GetSpecularMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularMaxValue_0")] public static extern 
bool GetSpecularMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetSpecular()
// virtual double GetSpecular ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecular_0")] public static extern 
bool GetSpecular_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetSpecularPower(double _arg)
// virtual void SetSpecularPower (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetSpecularPower_0")] public static extern 
bool SetSpecularPower_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetSpecularPowerMinValue()
// virtual double GetSpecularPowerMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularPowerMinValue_0")] public static extern 
bool GetSpecularPowerMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetSpecularPowerMaxValue()
// virtual double GetSpecularPowerMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularPowerMaxValue_0")] public static extern 
bool GetSpecularPowerMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetSpecularPower()
// virtual double GetSpecularPower ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularPower_0")] public static extern 
bool GetSpecularPower_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetOpacity(double _arg)
// virtual void SetOpacity (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetOpacity_0")] public static extern 
bool SetOpacity_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetOpacityMinValue()
// virtual double GetOpacityMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetOpacityMinValue_0")] public static extern 
bool GetOpacityMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetOpacityMaxValue()
// virtual double GetOpacityMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetOpacityMaxValue_0")] public static extern 
bool GetOpacityMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual double GetOpacity()
// virtual double GetOpacity ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetOpacity_0")] public static extern 
bool GetOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
// virtual void SetAmbientColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetAmbientColor_0")] public static extern 
bool SetAmbientColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetAmbientColor(double _arg[3])
// virtual void SetAmbientColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetAmbientColor_1")] public static extern 
bool SetAmbientColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetAmbientColor()
// virtual double *GetAmbientColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbientColor_0")] public static extern 
bool GetAmbientColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void GetAmbientColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetAmbientColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbientColor_1")] public static extern 
bool GetAmbientColor_1(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetAmbientColor(double _arg[3])
// virtual void GetAmbientColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetAmbientColor_2")] public static extern 
bool GetAmbientColor_2(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
// virtual void SetDiffuseColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetDiffuseColor_0")] public static extern 
bool SetDiffuseColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetDiffuseColor(double _arg[3])
// virtual void SetDiffuseColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetDiffuseColor_1")] public static extern 
bool SetDiffuseColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetDiffuseColor()
// virtual double *GetDiffuseColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuseColor_0")] public static extern 
bool GetDiffuseColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void GetDiffuseColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetDiffuseColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuseColor_1")] public static extern 
bool GetDiffuseColor_1(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetDiffuseColor(double _arg[3])
// virtual void GetDiffuseColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetDiffuseColor_2")] public static extern 
bool GetDiffuseColor_2(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
// virtual void SetSpecularColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetSpecularColor_0")] public static extern 
bool SetSpecularColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetSpecularColor(double _arg[3])
// virtual void SetSpecularColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetSpecularColor_1")] public static extern 
bool SetSpecularColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetSpecularColor()
// virtual double *GetSpecularColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularColor_0")] public static extern 
bool GetSpecularColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void GetSpecularColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetSpecularColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularColor_1")] public static extern 
bool GetSpecularColor_1(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetSpecularColor(double _arg[3])
// virtual void GetSpecularColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetSpecularColor_2")] public static extern 
bool GetSpecularColor_2(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual int GetEdgeVisibility()
// virtual int GetEdgeVisibility ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetEdgeVisibility_0")] public static extern 
bool GetEdgeVisibility_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetEdgeVisibility(int _arg)
// virtual void SetEdgeVisibility (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetEdgeVisibility_0")] public static extern 
bool SetEdgeVisibility_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual void EdgeVisibilityOn()
// virtual void EdgeVisibilityOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_EdgeVisibilityOn_0")] public static extern 
bool EdgeVisibilityOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void EdgeVisibilityOff()
// virtual void EdgeVisibilityOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_EdgeVisibilityOff_0")] public static extern 
bool EdgeVisibilityOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
// virtual void SetEdgeColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetEdgeColor_0")] public static extern 
bool SetEdgeColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetEdgeColor(double _arg[3])
// virtual void SetEdgeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetEdgeColor_1")] public static extern 
bool SetEdgeColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetEdgeColor()
// virtual double *GetEdgeColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetEdgeColor_0")] public static extern 
bool GetEdgeColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void GetEdgeColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetEdgeColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetEdgeColor_1")] public static extern 
bool GetEdgeColor_1(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetEdgeColor(double _arg[3])
// virtual void GetEdgeColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetEdgeColor_2")] public static extern 
bool GetEdgeColor_2(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual int GetVertexVisibility()
// virtual int GetVertexVisibility ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetVertexVisibility_0")] public static extern 
bool GetVertexVisibility_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetVertexVisibility(int _arg)
// virtual void SetVertexVisibility (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetVertexVisibility_0")] public static extern 
bool SetVertexVisibility_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual void VertexVisibilityOn()
// virtual void VertexVisibilityOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_VertexVisibilityOn_0")] public static extern 
bool VertexVisibilityOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void VertexVisibilityOff()
// virtual void VertexVisibilityOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_VertexVisibilityOff_0")] public static extern 
bool VertexVisibilityOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetVertexColor(double _arg1, double _arg2, double _arg3)
// virtual void SetVertexColor (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetVertexColor_0")] public static extern 
bool SetVertexColor_0(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetVertexColor(double _arg[3])
// virtual void SetVertexColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetVertexColor_1")] public static extern 
bool SetVertexColor_1(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetVertexColor()
// virtual double *GetVertexColor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetVertexColor_0")] public static extern 
bool GetVertexColor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void GetVertexColor(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetVertexColor (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetVertexColor_1")] public static extern 
bool GetVertexColor_1(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetVertexColor(double _arg[3])
// virtual void GetVertexColor (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetVertexColor_2")] public static extern 
bool GetVertexColor_2(IntPtr /*(vtkProperty*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetLineWidth(float _arg)
// virtual void SetLineWidth (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetLineWidth_0")] public static extern 
bool SetLineWidth_0(IntPtr /*(vtkProperty*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetLineWidthMinValue()
// virtual float GetLineWidthMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineWidthMinValue_0")] public static extern 
bool GetLineWidthMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual float GetLineWidthMaxValue()
// virtual float GetLineWidthMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineWidthMaxValue_0")] public static extern 
bool GetLineWidthMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual float GetLineWidth()
// virtual float GetLineWidth ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineWidth_0")] public static extern 
bool GetLineWidth_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetLineStipplePattern(int _arg)
// virtual void SetLineStipplePattern (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetLineStipplePattern_0")] public static extern 
bool SetLineStipplePattern_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLineStipplePattern()
// virtual int GetLineStipplePattern ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineStipplePattern_0")] public static extern 
bool GetLineStipplePattern_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetLineStippleRepeatFactor(int _arg)
// virtual void SetLineStippleRepeatFactor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetLineStippleRepeatFactor_0")] public static extern 
bool SetLineStippleRepeatFactor_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLineStippleRepeatFactorMinValue()
// virtual int GetLineStippleRepeatFactorMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineStippleRepeatFactorMinValue_0")] public static extern 
bool GetLineStippleRepeatFactorMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetLineStippleRepeatFactorMaxValue()
// virtual int GetLineStippleRepeatFactorMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineStippleRepeatFactorMaxValue_0")] public static extern 
bool GetLineStippleRepeatFactorMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetLineStippleRepeatFactor()
// virtual int GetLineStippleRepeatFactor ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetLineStippleRepeatFactor_0")] public static extern 
bool GetLineStippleRepeatFactor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetPointSize(float _arg)
// virtual void SetPointSize (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetPointSize_0")] public static extern 
bool SetPointSize_0(IntPtr /*(vtkProperty*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetPointSizeMinValue()
// virtual float GetPointSizeMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetPointSizeMinValue_0")] public static extern 
bool GetPointSizeMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual float GetPointSizeMaxValue()
// virtual float GetPointSizeMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetPointSizeMaxValue_0")] public static extern 
bool GetPointSizeMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual float GetPointSize()
// virtual float GetPointSize ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetPointSize_0")] public static extern 
bool GetPointSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetBackfaceCulling()
// virtual int GetBackfaceCulling ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetBackfaceCulling_0")] public static extern 
bool GetBackfaceCulling_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetBackfaceCulling(int _arg)
// virtual void SetBackfaceCulling (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetBackfaceCulling_0")] public static extern 
bool SetBackfaceCulling_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual void BackfaceCullingOn()
// virtual void BackfaceCullingOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_BackfaceCullingOn_0")] public static extern 
bool BackfaceCullingOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void BackfaceCullingOff()
// virtual void BackfaceCullingOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_BackfaceCullingOff_0")] public static extern 
bool BackfaceCullingOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual int GetFrontfaceCulling()
// virtual int GetFrontfaceCulling ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetFrontfaceCulling_0")] public static extern 
bool GetFrontfaceCulling_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetFrontfaceCulling(int _arg)
// virtual void SetFrontfaceCulling (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetFrontfaceCulling_0")] public static extern 
bool SetFrontfaceCulling_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual void FrontfaceCullingOn()
// virtual void FrontfaceCullingOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_FrontfaceCullingOn_0")] public static extern 
bool FrontfaceCullingOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void FrontfaceCullingOff()
// virtual void FrontfaceCullingOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_FrontfaceCullingOff_0")] public static extern 
bool FrontfaceCullingOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetMaterialName(const char * _arg)
// virtual void SetMaterialName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetMaterialName_0")] public static extern 
bool SetMaterialName_0(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetMaterialName()
// virtual char* GetMaterialName ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetMaterialName_0")] public static extern 
bool GetMaterialName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void SetShading(int _arg)
// virtual void SetShading (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetShading_0")] public static extern 
bool SetShading_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetShading()
// virtual int GetShading ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetShading_0")] public static extern 
bool GetShading_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void ShadingOn()
// virtual void ShadingOn ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_ShadingOn_0")] public static extern 
bool ShadingOn_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void ShadingOff()
// virtual void ShadingOff ()
[DllImport("vtkplugin", EntryPoint="vtkProperty_ShadingOff_0")] public static extern 
bool ShadingOff_0(IntPtr /*(vtkProperty*)*/ callingObject);

// virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()
// virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetShaderDeviceAdapter2_0")] public static extern 
bool GetShaderDeviceAdapter2_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void AddShaderVariable(const char * name, int numVars, int * x)
// virtual void AddShaderVariable(const char *name, int numVars, int *x)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_0")] public static extern 
bool AddShaderVariable_0(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ numVars, IntPtr /*(int*)*/ x);

// virtual void AddShaderVariable(const char * name, int numVars, float * x)
// virtual void AddShaderVariable(const char *name, int numVars, float *x)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_1")] public static extern 
bool AddShaderVariable_1(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ numVars, IntPtr /*(float*)*/ x);

// virtual void AddShaderVariable(const char * name, int numVars, double * x)
// virtual void AddShaderVariable(const char *name, int numVars, double *x)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_2")] public static extern 
bool AddShaderVariable_2(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ numVars, IntPtr /*(double*)*/ x);

// void AddShaderVariable(const char * name, int v)
// void AddShaderVariable(const char* name, int v)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_3")] public static extern 
bool AddShaderVariable_3(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ v);

// void AddShaderVariable(const char * name, float v)
// void AddShaderVariable(const char* name, float v)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_4")] public static extern 
bool AddShaderVariable_4(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, float /*(float)*/ v);

// void AddShaderVariable(const char * name, double v)
// void AddShaderVariable(const char* name, double v)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_5")] public static extern 
bool AddShaderVariable_5(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, double /*(double)*/ v);

// void AddShaderVariable(const char * name, int v1, int v2)
// void AddShaderVariable(const char* name, int v1, int v2)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_6")] public static extern 
bool AddShaderVariable_6(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ v1, int /*(int)*/ v2);

// void AddShaderVariable(const char * name, float v1, float v2)
// void AddShaderVariable(const char* name, float v1, float v2)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_7")] public static extern 
bool AddShaderVariable_7(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, float /*(float)*/ v1, float /*(float)*/ v2);

// void AddShaderVariable(const char * name, double v1, double v2)
// void AddShaderVariable(const char* name, double v1, double v2)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_8")] public static extern 
bool AddShaderVariable_8(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, double /*(double)*/ v1, double /*(double)*/ v2);

// void AddShaderVariable(const char * name, int v1, int v2, int v3)
// void AddShaderVariable(const char* name, int v1, int v2, int v3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_9")] public static extern 
bool AddShaderVariable_9(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, int /*(int)*/ v1, int /*(int)*/ v2, int /*(int)*/ v3);

// void AddShaderVariable(const char * name, float v1, float v2, float v3)
// void AddShaderVariable(const char* name, float v1, float v2, float v3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_10")] public static extern 
bool AddShaderVariable_10(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, float /*(float)*/ v1, float /*(float)*/ v2, float /*(float)*/ v3);

// void AddShaderVariable(const char * name, double v1, double v2, double v3)
// void AddShaderVariable(const char* name, double v1, double v2, double v3)
[DllImport("vtkplugin", EntryPoint="vtkProperty_AddShaderVariable_11")] public static extern 
bool AddShaderVariable_11(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, double /*(double)*/ v1, double /*(double)*/ v2, double /*(double)*/ v3);

// void SetTexture(const char * name, vtkTexture * texture)
// void SetTexture(const char* name, vtkTexture* texture)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetTexture_0")] public static extern 
bool SetTexture_0(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name, IntPtr /*(vtkTexture*)*/ texture);

// vtkTexture* GetTexture(const char * name)
// vtkTexture* GetTexture(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetTexture_0")] public static extern 
bool GetTexture_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name);

// void SetTexture(int unit, vtkTexture * texture)
// void SetTexture(int unit, vtkTexture* texture)
[DllImport("vtkplugin", EntryPoint="vtkProperty_SetTexture_1")] public static extern 
bool SetTexture_1(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ unit, IntPtr /*(vtkTexture*)*/ texture);

// vtkTexture* GetTexture(int unit)
// vtkTexture* GetTexture(int unit)
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetTexture_1")] public static extern 
bool GetTexture_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ unit);

// void RemoveTexture(int unit)
// void RemoveTexture(int unit)
[DllImport("vtkplugin", EntryPoint="vtkProperty_RemoveTexture_0")] public static extern 
bool RemoveTexture_0(IntPtr /*(vtkProperty*)*/ callingObject, int /*(int)*/ unit);

// void RemoveTexture(const char * name)
// void RemoveTexture(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkProperty_RemoveTexture_1")] public static extern 
bool RemoveTexture_1(IntPtr /*(vtkProperty*)*/ callingObject, string /*(char*)*/ name);

// void RemoveAllTextures()
// void RemoveAllTextures()
[DllImport("vtkplugin", EntryPoint="vtkProperty_RemoveAllTextures_0")] public static extern 
bool RemoveAllTextures_0(IntPtr /*(vtkProperty*)*/ callingObject);

// int GetNumberOfTextures()
// int GetNumberOfTextures()
[DllImport("vtkplugin", EntryPoint="vtkProperty_GetNumberOfTextures_0")] public static extern 
bool GetNumberOfTextures_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProperty*)*/ callingObject);

// virtual void ReleaseGraphicsResources(vtkWindow * win)
// virtual void ReleaseGraphicsResources(vtkWindow *win)
[DllImport("vtkplugin", EntryPoint="vtkProperty_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkProperty*)*/ callingObject, IntPtr /*(vtkWindow*)*/ win);

}
};
