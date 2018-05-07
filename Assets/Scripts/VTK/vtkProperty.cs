

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProperty : vtkObject {
		public vtkProperty(IntPtr p) : base(p) {}
		public static implicit operator  vtkProperty(IntPtr p) {return new vtkProperty(p);}
		public static implicit operator  IntPtr(vtkProperty o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProperty* SafeDownCast(vtkObjectBase * o)
// "static vtkProperty* SafeDownCast(vtkObjectBase *o)"
public static vtkProperty SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProperty)(IntPtr)returnPointer;
}


// vtkProperty* NewInstance()
// "vtkProperty *NewInstance()"
public vtkProperty NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProperty)(IntPtr)returnPointer;
}


// static vtkProperty* New()
// "static vtkProperty *New()"
public static vtkProperty New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.New_0(returnPointer.GetPtr());
	return (vtkProperty)(IntPtr)returnPointer;
}


// void DeepCopy(vtkProperty * p)
// "void DeepCopy(vtkProperty *p)"
public void DeepCopy(vtkProperty /*(vtkProperty*)*/ p) {
	VTK_API.API_vtkProperty.DeepCopy_0(this, p);
}


// virtual void Render(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void Render(vtkActor *, vtkRenderer *)"
public void Render(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.Render_0(this, ARG_0, ARG_1);
}


// virtual void BackfaceRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void BackfaceRender(vtkActor *, vtkRenderer *)"
public void BackfaceRender(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.BackfaceRender_0(this, ARG_0, ARG_1);
}


// virtual void PostRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void PostRender(vtkActor*, vtkRenderer*)"
public void PostRender(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.PostRender_0(this, ARG_0, ARG_1);
}


// virtual bool GetLighting()
// "virtual bool GetLighting ()"
public bool GetLighting() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty.GetLighting_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetLighting(bool _arg)
// "virtual void SetLighting (bool _arg)"
public void SetLighting(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetLighting_0(this, _arg);
}


// virtual void LightingOn()
// "virtual void LightingOn ()"
public void LightingOn() {
	VTK_API.API_vtkProperty.LightingOn_0(this);
}


// virtual void LightingOff()
// "virtual void LightingOff ()"
public void LightingOff() {
	VTK_API.API_vtkProperty.LightingOff_0(this);
}


// virtual bool GetRenderPointsAsSpheres()
// "virtual bool GetRenderPointsAsSpheres ()"
public bool GetRenderPointsAsSpheres() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty.GetRenderPointsAsSpheres_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetRenderPointsAsSpheres(bool _arg)
// "virtual void SetRenderPointsAsSpheres (bool _arg)"
public void SetRenderPointsAsSpheres(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetRenderPointsAsSpheres_0(this, _arg);
}


// virtual void RenderPointsAsSpheresOn()
// "virtual void RenderPointsAsSpheresOn ()"
public void RenderPointsAsSpheresOn() {
	VTK_API.API_vtkProperty.RenderPointsAsSpheresOn_0(this);
}


// virtual void RenderPointsAsSpheresOff()
// "virtual void RenderPointsAsSpheresOff ()"
public void RenderPointsAsSpheresOff() {
	VTK_API.API_vtkProperty.RenderPointsAsSpheresOff_0(this);
}


// virtual bool GetRenderLinesAsTubes()
// "virtual bool GetRenderLinesAsTubes ()"
public bool GetRenderLinesAsTubes() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProperty.GetRenderLinesAsTubes_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetRenderLinesAsTubes(bool _arg)
// "virtual void SetRenderLinesAsTubes (bool _arg)"
public void SetRenderLinesAsTubes(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetRenderLinesAsTubes_0(this, _arg);
}


// virtual void RenderLinesAsTubesOn()
// "virtual void RenderLinesAsTubesOn ()"
public void RenderLinesAsTubesOn() {
	VTK_API.API_vtkProperty.RenderLinesAsTubesOn_0(this);
}


// virtual void RenderLinesAsTubesOff()
// "virtual void RenderLinesAsTubesOff ()"
public void RenderLinesAsTubesOff() {
	VTK_API.API_vtkProperty.RenderLinesAsTubesOff_0(this);
}


// virtual void SetInterpolation(int _arg)
// "virtual void SetInterpolation (int _arg)"
public void SetInterpolation(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetInterpolation_0(this, _arg);
}


// virtual int GetInterpolationMinValue()
// "virtual int GetInterpolationMinValue ()"
public int GetInterpolationMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetInterpolationMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetInterpolationMaxValue()
// "virtual int GetInterpolationMaxValue ()"
public int GetInterpolationMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetInterpolationMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetInterpolation()
// "virtual int GetInterpolation ()"
public int GetInterpolation() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetInterpolation_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetInterpolationToFlat()
// "void SetInterpolationToFlat()"
public void SetInterpolationToFlat() {
	VTK_API.API_vtkProperty.SetInterpolationToFlat_0(this);
}


// void SetInterpolationToGouraud()
// "void SetInterpolationToGouraud()"
public void SetInterpolationToGouraud() {
	VTK_API.API_vtkProperty.SetInterpolationToGouraud_0(this);
}


// void SetInterpolationToPhong()
// "void SetInterpolationToPhong()"
public void SetInterpolationToPhong() {
	VTK_API.API_vtkProperty.SetInterpolationToPhong_0(this);
}


// char* GetInterpolationAsString()
// "const char *GetInterpolationAsString()"
public string GetInterpolationAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetInterpolationAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetRepresentation(int _arg)
// "virtual void SetRepresentation (int _arg)"
public void SetRepresentation(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetRepresentation_0(this, _arg);
}


// virtual int GetRepresentationMinValue()
// "virtual int GetRepresentationMinValue ()"
public int GetRepresentationMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetRepresentationMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetRepresentationMaxValue()
// "virtual int GetRepresentationMaxValue ()"
public int GetRepresentationMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetRepresentationMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetRepresentation()
// "virtual int GetRepresentation ()"
public int GetRepresentation() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetRepresentation_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetRepresentationToPoints()
// "void SetRepresentationToPoints()"
public void SetRepresentationToPoints() {
	VTK_API.API_vtkProperty.SetRepresentationToPoints_0(this);
}


// void SetRepresentationToWireframe()
// "void SetRepresentationToWireframe()"
public void SetRepresentationToWireframe() {
	VTK_API.API_vtkProperty.SetRepresentationToWireframe_0(this);
}


// void SetRepresentationToSurface()
// "void SetRepresentationToSurface()"
public void SetRepresentationToSurface() {
	VTK_API.API_vtkProperty.SetRepresentationToSurface_0(this);
}


// char* GetRepresentationAsString()
// "const char *GetRepresentationAsString()"
public string GetRepresentationAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetRepresentationAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetColor(double r, double g, double b)
// "virtual void SetColor(double r, double g, double b)"
public void SetColor(double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b) {
	VTK_API.API_vtkProperty.SetColor_0(this, r, g, b);
}


// virtual void SetColor(double a[3])
// "virtual void SetColor(double a[3])"
public void SetColor(double /*(double[3])*/ []a) {
	VTK_API.API_vtkProperty.SetColor_1(this, a);
}


// double* GetColor()
// "double *GetColor()"
public IntPtr GetColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetColor(double rgb[3])
// "void GetColor(double rgb[3])"
public void GetColor(double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkProperty.GetColor_1(this, rgb);
}


// void GetColor(double & r, double & g, double & b)
// "void GetColor(double &r, double &g, double &b)"
public void GetColor(IntPtr /*(double&)*/ r, IntPtr /*(double&)*/ g, IntPtr /*(double&)*/ b) {
	VTK_API.API_vtkProperty.GetColor_2(this, r, g, b);
}


// virtual void SetAmbient(double _arg)
// "virtual void SetAmbient (double _arg)"
public void SetAmbient(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetAmbient_0(this, _arg);
}


// virtual double GetAmbientMinValue()
// "virtual double GetAmbientMinValue ()"
public double GetAmbientMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetAmbientMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetAmbientMaxValue()
// "virtual double GetAmbientMaxValue ()"
public double GetAmbientMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetAmbientMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetAmbient()
// "virtual double GetAmbient ()"
public double GetAmbient() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetAmbient_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetDiffuse(double _arg)
// "virtual void SetDiffuse (double _arg)"
public void SetDiffuse(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetDiffuse_0(this, _arg);
}


// virtual double GetDiffuseMinValue()
// "virtual double GetDiffuseMinValue ()"
public double GetDiffuseMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetDiffuseMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetDiffuseMaxValue()
// "virtual double GetDiffuseMaxValue ()"
public double GetDiffuseMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetDiffuseMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetDiffuse()
// "virtual double GetDiffuse ()"
public double GetDiffuse() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetDiffuse_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetSpecular(double _arg)
// "virtual void SetSpecular (double _arg)"
public void SetSpecular(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetSpecular_0(this, _arg);
}


// virtual double GetSpecularMinValue()
// "virtual double GetSpecularMinValue ()"
public double GetSpecularMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecularMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetSpecularMaxValue()
// "virtual double GetSpecularMaxValue ()"
public double GetSpecularMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecularMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetSpecular()
// "virtual double GetSpecular ()"
public double GetSpecular() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecular_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetSpecularPower(double _arg)
// "virtual void SetSpecularPower (double _arg)"
public void SetSpecularPower(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetSpecularPower_0(this, _arg);
}


// virtual double GetSpecularPowerMinValue()
// "virtual double GetSpecularPowerMinValue ()"
public double GetSpecularPowerMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecularPowerMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetSpecularPowerMaxValue()
// "virtual double GetSpecularPowerMaxValue ()"
public double GetSpecularPowerMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecularPowerMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetSpecularPower()
// "virtual double GetSpecularPower ()"
public double GetSpecularPower() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetSpecularPower_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetOpacity(double _arg)
// "virtual void SetOpacity (double _arg)"
public void SetOpacity(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetOpacity_0(this, _arg);
}


// virtual double GetOpacityMinValue()
// "virtual double GetOpacityMinValue ()"
public double GetOpacityMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetOpacityMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetOpacityMaxValue()
// "virtual double GetOpacityMaxValue ()"
public double GetOpacityMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetOpacityMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetOpacity()
// "virtual double GetOpacity ()"
public double GetOpacity() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProperty.GetOpacity_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetAmbientColor (double _arg1, double _arg2, double _arg3)"
public void SetAmbientColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetAmbientColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAmbientColor(double _arg[3])
// "virtual void SetAmbientColor (double _arg[3])"
public void SetAmbientColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetAmbientColor_1(this, _arg);
}


// virtual double* GetAmbientColor()
// "virtual double *GetAmbientColor ()"
public IntPtr GetAmbientColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetAmbientColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAmbientColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetAmbientColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetAmbientColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetAmbientColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetAmbientColor(double _arg[3])
// "virtual void GetAmbientColor (double _arg[3])"
public void GetAmbientColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetAmbientColor_2(this, _arg);
}


// virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetDiffuseColor (double _arg1, double _arg2, double _arg3)"
public void SetDiffuseColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetDiffuseColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetDiffuseColor(double _arg[3])
// "virtual void SetDiffuseColor (double _arg[3])"
public void SetDiffuseColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetDiffuseColor_1(this, _arg);
}


// virtual double* GetDiffuseColor()
// "virtual double *GetDiffuseColor ()"
public IntPtr GetDiffuseColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetDiffuseColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetDiffuseColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetDiffuseColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetDiffuseColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetDiffuseColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetDiffuseColor(double _arg[3])
// "virtual void GetDiffuseColor (double _arg[3])"
public void GetDiffuseColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetDiffuseColor_2(this, _arg);
}


// virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetSpecularColor (double _arg1, double _arg2, double _arg3)"
public void SetSpecularColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetSpecularColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetSpecularColor(double _arg[3])
// "virtual void SetSpecularColor (double _arg[3])"
public void SetSpecularColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetSpecularColor_1(this, _arg);
}


// virtual double* GetSpecularColor()
// "virtual double *GetSpecularColor ()"
public IntPtr GetSpecularColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetSpecularColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetSpecularColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetSpecularColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetSpecularColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetSpecularColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetSpecularColor(double _arg[3])
// "virtual void GetSpecularColor (double _arg[3])"
public void GetSpecularColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetSpecularColor_2(this, _arg);
}


// virtual int GetEdgeVisibility()
// "virtual int GetEdgeVisibility ()"
public int GetEdgeVisibility() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetEdgeVisibility_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetEdgeVisibility(int _arg)
// "virtual void SetEdgeVisibility (int _arg)"
public void SetEdgeVisibility(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetEdgeVisibility_0(this, _arg);
}


// virtual void EdgeVisibilityOn()
// "virtual void EdgeVisibilityOn ()"
public void EdgeVisibilityOn() {
	VTK_API.API_vtkProperty.EdgeVisibilityOn_0(this);
}


// virtual void EdgeVisibilityOff()
// "virtual void EdgeVisibilityOff ()"
public void EdgeVisibilityOff() {
	VTK_API.API_vtkProperty.EdgeVisibilityOff_0(this);
}


// virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetEdgeColor (double _arg1, double _arg2, double _arg3)"
public void SetEdgeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetEdgeColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetEdgeColor(double _arg[3])
// "virtual void SetEdgeColor (double _arg[3])"
public void SetEdgeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetEdgeColor_1(this, _arg);
}


// virtual double* GetEdgeColor()
// "virtual double *GetEdgeColor ()"
public IntPtr GetEdgeColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetEdgeColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetEdgeColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetEdgeColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetEdgeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetEdgeColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetEdgeColor(double _arg[3])
// "virtual void GetEdgeColor (double _arg[3])"
public void GetEdgeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetEdgeColor_2(this, _arg);
}


// virtual int GetVertexVisibility()
// "virtual int GetVertexVisibility ()"
public int GetVertexVisibility() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetVertexVisibility_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetVertexVisibility(int _arg)
// "virtual void SetVertexVisibility (int _arg)"
public void SetVertexVisibility(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetVertexVisibility_0(this, _arg);
}


// virtual void VertexVisibilityOn()
// "virtual void VertexVisibilityOn ()"
public void VertexVisibilityOn() {
	VTK_API.API_vtkProperty.VertexVisibilityOn_0(this);
}


// virtual void VertexVisibilityOff()
// "virtual void VertexVisibilityOff ()"
public void VertexVisibilityOff() {
	VTK_API.API_vtkProperty.VertexVisibilityOff_0(this);
}


// virtual void SetVertexColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetVertexColor (double _arg1, double _arg2, double _arg3)"
public void SetVertexColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetVertexColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetVertexColor(double _arg[3])
// "virtual void SetVertexColor (double _arg[3])"
public void SetVertexColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetVertexColor_1(this, _arg);
}


// virtual double* GetVertexColor()
// "virtual double *GetVertexColor ()"
public IntPtr GetVertexColor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetVertexColor_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetVertexColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetVertexColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetVertexColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetVertexColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetVertexColor(double _arg[3])
// "virtual void GetVertexColor (double _arg[3])"
public void GetVertexColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetVertexColor_2(this, _arg);
}


// virtual void SetLineWidth(float _arg)
// "virtual void SetLineWidth (float _arg)"
public void SetLineWidth(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineWidth_0(this, _arg);
}


// virtual float GetLineWidthMinValue()
// "virtual float GetLineWidthMinValue ()"
public float GetLineWidthMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetLineWidthMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetLineWidthMaxValue()
// "virtual float GetLineWidthMaxValue ()"
public float GetLineWidthMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetLineWidthMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetLineWidth()
// "virtual float GetLineWidth ()"
public float GetLineWidth() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetLineWidth_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetLineStipplePattern(int _arg)
// "virtual void SetLineStipplePattern (int _arg)"
public void SetLineStipplePattern(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineStipplePattern_0(this, _arg);
}


// virtual int GetLineStipplePattern()
// "virtual int GetLineStipplePattern ()"
public int GetLineStipplePattern() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetLineStipplePattern_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetLineStippleRepeatFactor(int _arg)
// "virtual void SetLineStippleRepeatFactor (int _arg)"
public void SetLineStippleRepeatFactor(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineStippleRepeatFactor_0(this, _arg);
}


// virtual int GetLineStippleRepeatFactorMinValue()
// "virtual int GetLineStippleRepeatFactorMinValue ()"
public int GetLineStippleRepeatFactorMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactorMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLineStippleRepeatFactorMaxValue()
// "virtual int GetLineStippleRepeatFactorMaxValue ()"
public int GetLineStippleRepeatFactorMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactorMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLineStippleRepeatFactor()
// "virtual int GetLineStippleRepeatFactor ()"
public int GetLineStippleRepeatFactor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetPointSize(float _arg)
// "virtual void SetPointSize (float _arg)"
public void SetPointSize(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty.SetPointSize_0(this, _arg);
}


// virtual float GetPointSizeMinValue()
// "virtual float GetPointSizeMinValue ()"
public float GetPointSizeMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetPointSizeMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetPointSizeMaxValue()
// "virtual float GetPointSizeMaxValue ()"
public float GetPointSizeMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetPointSizeMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetPointSize()
// "virtual float GetPointSize ()"
public float GetPointSize() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkProperty.GetPointSize_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual int GetBackfaceCulling()
// "virtual int GetBackfaceCulling ()"
public int GetBackfaceCulling() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetBackfaceCulling_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetBackfaceCulling(int _arg)
// "virtual void SetBackfaceCulling (int _arg)"
public void SetBackfaceCulling(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetBackfaceCulling_0(this, _arg);
}


// virtual void BackfaceCullingOn()
// "virtual void BackfaceCullingOn ()"
public void BackfaceCullingOn() {
	VTK_API.API_vtkProperty.BackfaceCullingOn_0(this);
}


// virtual void BackfaceCullingOff()
// "virtual void BackfaceCullingOff ()"
public void BackfaceCullingOff() {
	VTK_API.API_vtkProperty.BackfaceCullingOff_0(this);
}


// virtual int GetFrontfaceCulling()
// "virtual int GetFrontfaceCulling ()"
public int GetFrontfaceCulling() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetFrontfaceCulling_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetFrontfaceCulling(int _arg)
// "virtual void SetFrontfaceCulling (int _arg)"
public void SetFrontfaceCulling(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetFrontfaceCulling_0(this, _arg);
}


// virtual void FrontfaceCullingOn()
// "virtual void FrontfaceCullingOn ()"
public void FrontfaceCullingOn() {
	VTK_API.API_vtkProperty.FrontfaceCullingOn_0(this);
}


// virtual void FrontfaceCullingOff()
// "virtual void FrontfaceCullingOff ()"
public void FrontfaceCullingOff() {
	VTK_API.API_vtkProperty.FrontfaceCullingOff_0(this);
}


// virtual void SetMaterialName(const char * _arg)
// "virtual void SetMaterialName (const char* _arg)"
public void SetMaterialName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkProperty.SetMaterialName_0(this, _arg);
}


// virtual char* GetMaterialName()
// "virtual char* GetMaterialName ()"
public string GetMaterialName() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetMaterialName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void SetShading(int _arg)
// "virtual void SetShading (int _arg)"
public void SetShading(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetShading_0(this, _arg);
}


// virtual int GetShading()
// "virtual int GetShading ()"
public int GetShading() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetShading_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ShadingOn()
// "virtual void ShadingOn ()"
public void ShadingOn() {
	VTK_API.API_vtkProperty.ShadingOn_0(this);
}


// virtual void ShadingOff()
// "virtual void ShadingOff ()"
public void ShadingOff() {
	VTK_API.API_vtkProperty.ShadingOff_0(this);
}


// virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()
// "virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()"
public vtkShaderDeviceAdapter2 GetShaderDeviceAdapter2() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetShaderDeviceAdapter2_0(returnPointer.GetPtr(), this);
	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
}


// virtual void AddShaderVariable(const char * name, int numVars, int * x)
// "virtual void AddShaderVariable(const char *name, int numVars, int *x)"
public void AddShaderVariable(string /*(char*)*/ name, int /*(int)*/ numVars, IntPtr /*(int*)*/ x) {
	VTK_API.API_vtkProperty.AddShaderVariable_0(this, name, numVars, x);
}


// void AddShaderVariable(const char * name, int v)
// "void AddShaderVariable(const char* name, int v)"
public void AddShaderVariable(string /*(char*)*/ name, int /*(int)*/ v) {
	VTK_API.API_vtkProperty.AddShaderVariable_3(this, name, v);
}


// void AddShaderVariable(const char * name, float v)
// "void AddShaderVariable(const char* name, float v)"
public void AddShaderVariable(string /*(char*)*/ name, float /*(float)*/ v) {
	VTK_API.API_vtkProperty.AddShaderVariable_4(this, name, v);
}


// void AddShaderVariable(const char * name, double v)
// "void AddShaderVariable(const char* name, double v)"
public void AddShaderVariable(string /*(char*)*/ name, double /*(double)*/ v) {
	VTK_API.API_vtkProperty.AddShaderVariable_5(this, name, v);
}


// void AddShaderVariable(const char * name, int v1, int v2)
// "void AddShaderVariable(const char* name, int v1, int v2)"
public void AddShaderVariable(string /*(char*)*/ name, int /*(int)*/ v1, int /*(int)*/ v2) {
	VTK_API.API_vtkProperty.AddShaderVariable_6(this, name, v1, v2);
}


// void AddShaderVariable(const char * name, float v1, float v2)
// "void AddShaderVariable(const char* name, float v1, float v2)"
public void AddShaderVariable(string /*(char*)*/ name, float /*(float)*/ v1, float /*(float)*/ v2) {
	VTK_API.API_vtkProperty.AddShaderVariable_7(this, name, v1, v2);
}


// void AddShaderVariable(const char * name, double v1, double v2)
// "void AddShaderVariable(const char* name, double v1, double v2)"
public void AddShaderVariable(string /*(char*)*/ name, double /*(double)*/ v1, double /*(double)*/ v2) {
	VTK_API.API_vtkProperty.AddShaderVariable_8(this, name, v1, v2);
}


// void AddShaderVariable(const char * name, int v1, int v2, int v3)
// "void AddShaderVariable(const char* name, int v1, int v2, int v3)"
public void AddShaderVariable(string /*(char*)*/ name, int /*(int)*/ v1, int /*(int)*/ v2, int /*(int)*/ v3) {
	VTK_API.API_vtkProperty.AddShaderVariable_9(this, name, v1, v2, v3);
}


// void AddShaderVariable(const char * name, float v1, float v2, float v3)
// "void AddShaderVariable(const char* name, float v1, float v2, float v3)"
public void AddShaderVariable(string /*(char*)*/ name, float /*(float)*/ v1, float /*(float)*/ v2, float /*(float)*/ v3) {
	VTK_API.API_vtkProperty.AddShaderVariable_10(this, name, v1, v2, v3);
}


// void AddShaderVariable(const char * name, double v1, double v2, double v3)
// "void AddShaderVariable(const char* name, double v1, double v2, double v3)"
public void AddShaderVariable(string /*(char*)*/ name, double /*(double)*/ v1, double /*(double)*/ v2, double /*(double)*/ v3) {
	VTK_API.API_vtkProperty.AddShaderVariable_11(this, name, v1, v2, v3);
}


// void SetTexture(const char * name, vtkTexture * texture)
// "void SetTexture(const char* name, vtkTexture* texture)"
public void SetTexture(string /*(char*)*/ name, vtkTexture /*(vtkTexture*)*/ texture) {
	VTK_API.API_vtkProperty.SetTexture_0(this, name, texture);
}


// vtkTexture* GetTexture(const char * name)
// "vtkTexture* GetTexture(const char* name)"
public vtkTexture GetTexture(string /*(char*)*/ name) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetTexture_0(returnPointer.GetPtr(), this, name);
	return (vtkTexture)(IntPtr)returnPointer;
}


// void SetTexture(int unit, vtkTexture * texture)
// "void SetTexture(int unit, vtkTexture* texture)"
public void SetTexture(int /*(int)*/ unit, vtkTexture /*(vtkTexture*)*/ texture) {
	VTK_API.API_vtkProperty.SetTexture_1(this, unit, texture);
}


// vtkTexture* GetTexture(int unit)
// "vtkTexture* GetTexture(int unit)"
public vtkTexture GetTexture(int /*(int)*/ unit) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProperty.GetTexture_1(returnPointer.GetPtr(), this, unit);
	return (vtkTexture)(IntPtr)returnPointer;
}


// void RemoveTexture(int unit)
// "void RemoveTexture(int unit)"
public void RemoveTexture(int /*(int)*/ unit) {
	VTK_API.API_vtkProperty.RemoveTexture_0(this, unit);
}


// void RemoveTexture(const char * name)
// "void RemoveTexture(const char* name)"
public void RemoveTexture(string /*(char*)*/ name) {
	VTK_API.API_vtkProperty.RemoveTexture_1(this, name);
}


// void RemoveAllTextures()
// "void RemoveAllTextures()"
public void RemoveAllTextures() {
	VTK_API.API_vtkProperty.RemoveAllTextures_0(this);
}


// int GetNumberOfTextures()
// "int GetNumberOfTextures()"
public int GetNumberOfTextures() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProperty.GetNumberOfTextures_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * win)
// "virtual void ReleaseGraphicsResources(vtkWindow *win)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ win) {
	VTK_API.API_vtkProperty.ReleaseGraphicsResources_0(this, win);
}


}
};
