

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLight : vtkObject {
		public vtkLight(IntPtr p) : base(p) {}
		public static implicit operator  vtkLight(IntPtr p) {return new vtkLight(p);}
		public static implicit operator  IntPtr(vtkLight o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLight.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLight.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkLight* SafeDownCast(vtkObjectBase * o)
// "static vtkLight* SafeDownCast(vtkObjectBase *o)"
public static vtkLight SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkLight)(IntPtr)returnPointer;
}


// vtkLight* NewInstance()
// "vtkLight *NewInstance()"
public vtkLight NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkLight)(IntPtr)returnPointer;
}


// static vtkLight* New()
// "static vtkLight *New()"
public static vtkLight New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.New_0(returnPointer.GetPtr());
	return (vtkLight)(IntPtr)returnPointer;
}


// virtual vtkLight* ShallowClone()
// "virtual vtkLight *ShallowClone()"
public vtkLight ShallowClone() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.ShallowClone_0(returnPointer.GetPtr(), this);
	return (vtkLight)(IntPtr)returnPointer;
}


// virtual void Render(vtkRenderer * ARG_0, int ARG_1)
// "virtual void Render(vtkRenderer *, int)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkLight.Render_0(this, ARG_0, ARG_1);
}


// virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetAmbientColor (double _arg1, double _arg2, double _arg3)"
public void SetAmbientColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetAmbientColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAmbientColor(double _arg[3])
// "virtual void SetAmbientColor (double _arg[3])"
public void SetAmbientColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetAmbientColor_1(this, _arg);
}


// virtual double* GetAmbientColor()
// "virtual double *GetAmbientColor ()"
public IntPtr GetAmbientColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetAmbientColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAmbientColor(double data[3])
// "virtual void GetAmbientColor (double data[3])"
public void GetAmbientColor(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetAmbientColor_1(this, data);
}


// virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetDiffuseColor (double _arg1, double _arg2, double _arg3)"
public void SetDiffuseColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetDiffuseColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetDiffuseColor(double _arg[3])
// "virtual void SetDiffuseColor (double _arg[3])"
public void SetDiffuseColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetDiffuseColor_1(this, _arg);
}


// virtual double* GetDiffuseColor()
// "virtual double *GetDiffuseColor ()"
public IntPtr GetDiffuseColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetDiffuseColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetDiffuseColor(double data[3])
// "virtual void GetDiffuseColor (double data[3])"
public void GetDiffuseColor(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetDiffuseColor_1(this, data);
}


// virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetSpecularColor (double _arg1, double _arg2, double _arg3)"
public void SetSpecularColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetSpecularColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetSpecularColor(double _arg[3])
// "virtual void SetSpecularColor (double _arg[3])"
public void SetSpecularColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetSpecularColor_1(this, _arg);
}


// virtual double* GetSpecularColor()
// "virtual double *GetSpecularColor ()"
public IntPtr GetSpecularColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetSpecularColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetSpecularColor(double data[3])
// "virtual void GetSpecularColor (double data[3])"
public void GetSpecularColor(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetSpecularColor_1(this, data);
}


// void SetColor(double ARG_0, double ARG_1, double ARG_2)
// "void SetColor(double, double, double)"
public void SetColor(double /*(double)*/ ARG_0, double /*(double)*/ ARG_1, double /*(double)*/ ARG_2) {
	VTK_API.API_vtkLight.SetColor_0(this, ARG_0, ARG_1, ARG_2);
}


// void SetColor(const double a[3])
// "void SetColor(const double a[3])"
public void SetColor(double /*(double[3])*/ []a) {
	VTK_API.API_vtkLight.SetColor_1(this, a);
}


// virtual void SetPosition(double _arg1, double _arg2, double _arg3)
// "virtual void SetPosition (double _arg1, double _arg2, double _arg3)"
public void SetPosition(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetPosition_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetPosition(double _arg[3])
// "virtual void SetPosition (double _arg[3])"
public void SetPosition(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetPosition_1(this, _arg);
}


// virtual double* GetPosition()
// "virtual double *GetPosition ()"
public IntPtr GetPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetPosition_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetPosition(double data[3])
// "virtual void GetPosition (double data[3])"
public void GetPosition(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetPosition_1(this, data);
}


// void SetPosition(const float * a)
// "void SetPosition(const float *a)"
public void SetPosition(IntPtr /*(float*)*/ a) {
	VTK_API.API_vtkLight.SetPosition_2(this, a);
}


// virtual void SetFocalPoint(double _arg1, double _arg2, double _arg3)
// "virtual void SetFocalPoint (double _arg1, double _arg2, double _arg3)"
public void SetFocalPoint(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetFocalPoint_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetFocalPoint(double _arg[3])
// "virtual void SetFocalPoint (double _arg[3])"
public void SetFocalPoint(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetFocalPoint_1(this, _arg);
}


// virtual double* GetFocalPoint()
// "virtual double *GetFocalPoint ()"
public IntPtr GetFocalPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetFocalPoint_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetFocalPoint(double data[3])
// "virtual void GetFocalPoint (double data[3])"
public void GetFocalPoint(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetFocalPoint_1(this, data);
}


// void SetFocalPoint(const float * a)
// "void SetFocalPoint(const float *a)"
public void SetFocalPoint(IntPtr /*(float*)*/ a) {
	VTK_API.API_vtkLight.SetFocalPoint_2(this, a);
}


// virtual void SetIntensity(double _arg)
// "virtual void SetIntensity (double _arg)"
public void SetIntensity(double /*(double)*/ _arg) {
	VTK_API.API_vtkLight.SetIntensity_0(this, _arg);
}


// virtual double GetIntensity()
// "virtual double GetIntensity ()"
public double GetIntensity() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLight.GetIntensity_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetSwitch(int _arg)
// "virtual void SetSwitch (int _arg)"
public void SetSwitch(int /*(int)*/ _arg) {
	VTK_API.API_vtkLight.SetSwitch_0(this, _arg);
}


// virtual int GetSwitch()
// "virtual int GetSwitch ()"
public int GetSwitch() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.GetSwitch_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SwitchOn()
// "virtual void SwitchOn ()"
public void SwitchOn() {
	VTK_API.API_vtkLight.SwitchOn_0(this);
}


// virtual void SwitchOff()
// "virtual void SwitchOff ()"
public void SwitchOff() {
	VTK_API.API_vtkLight.SwitchOff_0(this);
}


// virtual void SetPositional(int _arg)
// "virtual void SetPositional (int _arg)"
public void SetPositional(int /*(int)*/ _arg) {
	VTK_API.API_vtkLight.SetPositional_0(this, _arg);
}


// virtual int GetPositional()
// "virtual int GetPositional ()"
public int GetPositional() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.GetPositional_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PositionalOn()
// "virtual void PositionalOn ()"
public void PositionalOn() {
	VTK_API.API_vtkLight.PositionalOn_0(this);
}


// virtual void PositionalOff()
// "virtual void PositionalOff ()"
public void PositionalOff() {
	VTK_API.API_vtkLight.PositionalOff_0(this);
}


// virtual void SetExponent(double _arg)
// "virtual void SetExponent (double _arg)"
public void SetExponent(double /*(double)*/ _arg) {
	VTK_API.API_vtkLight.SetExponent_0(this, _arg);
}


// virtual double GetExponentMinValue()
// "virtual double GetExponentMinValue ()"
public double GetExponentMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLight.GetExponentMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetExponentMaxValue()
// "virtual double GetExponentMaxValue ()"
public double GetExponentMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLight.GetExponentMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetExponent()
// "virtual double GetExponent ()"
public double GetExponent() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLight.GetExponent_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetConeAngle(double _arg)
// "virtual void SetConeAngle (double _arg)"
public void SetConeAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkLight.SetConeAngle_0(this, _arg);
}


// virtual double GetConeAngle()
// "virtual double GetConeAngle ()"
public double GetConeAngle() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkLight.GetConeAngle_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetAttenuationValues(double _arg1, double _arg2, double _arg3)
// "virtual void SetAttenuationValues (double _arg1, double _arg2, double _arg3)"
public void SetAttenuationValues(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkLight.SetAttenuationValues_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAttenuationValues(double _arg[3])
// "virtual void SetAttenuationValues (double _arg[3])"
public void SetAttenuationValues(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkLight.SetAttenuationValues_1(this, _arg);
}


// virtual double* GetAttenuationValues()
// "virtual double *GetAttenuationValues ()"
public IntPtr GetAttenuationValues() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetAttenuationValues_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAttenuationValues(double data[3])
// "virtual void GetAttenuationValues (double data[3])"
public void GetAttenuationValues(double /*(double[3])*/ []data) {
	VTK_API.API_vtkLight.GetAttenuationValues_1(this, data);
}


// virtual void SetTransformMatrix(vtkMatrix4x4 * ARG_0)
// "virtual void SetTransformMatrix(vtkMatrix4x4*)"
public void SetTransformMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ ARG_0) {
	VTK_API.API_vtkLight.SetTransformMatrix_0(this, ARG_0);
}


// virtual vtkMatrix4x4* GetTransformMatrix()
// "virtual vtkMatrix4x4 *GetTransformMatrix ()"
public vtkMatrix4x4 GetTransformMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetTransformMatrix_0(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// void GetTransformedPosition(double & a0, double & a1, double & a2)
// "void GetTransformedPosition(double &a0, double &a1, double &a2)"
public void GetTransformedPosition(IntPtr /*(double&)*/ a0, IntPtr /*(double&)*/ a1, IntPtr /*(double&)*/ a2) {
	VTK_API.API_vtkLight.GetTransformedPosition_0(this, a0, a1, a2);
}


// void GetTransformedPosition(double a[3])
// "void GetTransformedPosition(double a[3])"
public void GetTransformedPosition(double /*(double[3])*/ []a) {
	VTK_API.API_vtkLight.GetTransformedPosition_1(this, a);
}


// double* GetTransformedPosition()
// "double *GetTransformedPosition()"
public IntPtr GetTransformedPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetTransformedPosition_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetTransformedFocalPoint(double & a0, double & a1, double & a2)
// "void GetTransformedFocalPoint(double &a0, double &a1, double &a2)"
public void GetTransformedFocalPoint(IntPtr /*(double&)*/ a0, IntPtr /*(double&)*/ a1, IntPtr /*(double&)*/ a2) {
	VTK_API.API_vtkLight.GetTransformedFocalPoint_0(this, a0, a1, a2);
}


// void GetTransformedFocalPoint(double a[3])
// "void GetTransformedFocalPoint(double a[3])"
public void GetTransformedFocalPoint(double /*(double[3])*/ []a) {
	VTK_API.API_vtkLight.GetTransformedFocalPoint_1(this, a);
}


// double* GetTransformedFocalPoint()
// "double *GetTransformedFocalPoint()"
public IntPtr GetTransformedFocalPoint() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetTransformedFocalPoint_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetDirectionAngle(double elevation, double azimuth)
// "void SetDirectionAngle(double elevation, double azimuth)"
public void SetDirectionAngle(double /*(double)*/ elevation, double /*(double)*/ azimuth) {
	VTK_API.API_vtkLight.SetDirectionAngle_0(this, elevation, azimuth);
}


// void SetDirectionAngle(const double ang[2])
// "void SetDirectionAngle(const double ang[2])"
public void SetDirectionAngle(double /*(double[2])*/ []ang) {
	VTK_API.API_vtkLight.SetDirectionAngle_1(this, ang);
}


// void DeepCopy(vtkLight * light)
// "void DeepCopy(vtkLight *light)"
public void DeepCopy(vtkLight /*(vtkLight*)*/ light) {
	VTK_API.API_vtkLight.DeepCopy_0(this, light);
}


// virtual void SetLightType(int ARG_0)
// "virtual void SetLightType(int)"
public void SetLightType(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkLight.SetLightType_0(this, ARG_0);
}


// virtual int GetLightType()
// "virtual int GetLightType ()"
public int GetLightType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.GetLightType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetLightTypeToHeadlight()
// "void SetLightTypeToHeadlight()"
public void SetLightTypeToHeadlight() {
	VTK_API.API_vtkLight.SetLightTypeToHeadlight_0(this);
}


// void SetLightTypeToSceneLight()
// "void SetLightTypeToSceneLight()"
public void SetLightTypeToSceneLight() {
	VTK_API.API_vtkLight.SetLightTypeToSceneLight_0(this);
}


// void SetLightTypeToCameraLight()
// "void SetLightTypeToCameraLight()"
public void SetLightTypeToCameraLight() {
	VTK_API.API_vtkLight.SetLightTypeToCameraLight_0(this);
}


// int LightTypeIsHeadlight()
// "int LightTypeIsHeadlight()"
public int LightTypeIsHeadlight() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.LightTypeIsHeadlight_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int LightTypeIsSceneLight()
// "int LightTypeIsSceneLight()"
public int LightTypeIsSceneLight() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.LightTypeIsSceneLight_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int LightTypeIsCameraLight()
// "int LightTypeIsCameraLight()"
public int LightTypeIsCameraLight() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkLight.LightTypeIsCameraLight_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetShadowAttenuation(float _arg)
// "virtual void SetShadowAttenuation (float _arg)"
public void SetShadowAttenuation(float /*(float)*/ _arg) {
	VTK_API.API_vtkLight.SetShadowAttenuation_0(this, _arg);
}


// virtual float GetShadowAttenuation()
// "virtual float GetShadowAttenuation ()"
public float GetShadowAttenuation() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkLight.GetShadowAttenuation_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual vtkInformation* GetInformation()
// "virtual vtkInformation *GetInformation ()"
public vtkInformation GetInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLight.GetInformation_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual void SetInformation(vtkInformation * ARG_0)
// "virtual void SetInformation(vtkInformation*)"
public void SetInformation(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkLight.SetInformation_0(this, ARG_0);
}


}
};
