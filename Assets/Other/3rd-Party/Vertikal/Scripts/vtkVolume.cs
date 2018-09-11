

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkVolume : vtkProp3D {
		public vtkVolume(IntPtr p) : base(p) {}
		public static implicit operator  vtkVolume(IntPtr p) {return new vtkVolume(p);}
		public static implicit operator  IntPtr(vtkVolume o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolume.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolume.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkVolume* SafeDownCast(vtkObjectBase * o)
// "static vtkVolume* SafeDownCast(vtkObjectBase *o)"
public static vtkVolume SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkVolume)(IntPtr)returnPointer;
}


// vtkVolume* NewInstance()
// "vtkVolume *NewInstance()"
public vtkVolume NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkVolume)(IntPtr)returnPointer;
}


// static vtkVolume* New()
// "static vtkVolume *New()"
public static vtkVolume New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.New_0(returnPointer.GetPtr());
	return (vtkVolume)(IntPtr)returnPointer;
}


// void SetMapper(vtkAbstractVolumeMapper * mapper)
// "void SetMapper(vtkAbstractVolumeMapper *mapper)"
public void SetMapper(vtkAbstractVolumeMapper /*(vtkAbstractVolumeMapper*)*/ mapper) {
	VTK_API.API_vtkVolume.SetMapper_0(this, mapper);
}


// virtual vtkAbstractVolumeMapper* GetMapper()
// "virtual vtkAbstractVolumeMapper *GetMapper ()"
public vtkAbstractVolumeMapper GetMapper() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetMapper_0(returnPointer.GetPtr(), this);
	return (vtkAbstractVolumeMapper)(IntPtr)returnPointer;
}


// void SetProperty(vtkVolumeProperty * property)
// "void SetProperty(vtkVolumeProperty *property)"
public void SetProperty(vtkVolumeProperty /*(vtkVolumeProperty*)*/ property) {
	VTK_API.API_vtkVolume.SetProperty_0(this, property);
}


// vtkVolumeProperty* GetProperty()
// "vtkVolumeProperty *GetProperty()"
public vtkVolumeProperty GetProperty() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetProperty_0(returnPointer.GetPtr(), this);
	return (vtkVolumeProperty)(IntPtr)returnPointer;
}


// void GetVolumes(vtkPropCollection * vc)
// "void GetVolumes(vtkPropCollection *vc)"
public void GetVolumes(vtkPropCollection /*(vtkPropCollection*)*/ vc) {
	VTK_API.API_vtkVolume.GetVolumes_0(this, vc);
}


// void Update()
// "void Update()"
public void Update() {
	VTK_API.API_vtkVolume.Update_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkVolume.GetBounds_1(this, bounds);
}


// double GetMinXBound()
// "double GetMinXBound()"
public double GetMinXBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMinXBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetMaxXBound()
// "double GetMaxXBound()"
public double GetMaxXBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMaxXBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetMinYBound()
// "double GetMinYBound()"
public double GetMinYBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMinYBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetMaxYBound()
// "double GetMaxYBound()"
public double GetMaxYBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMaxYBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetMinZBound()
// "double GetMinZBound()"
public double GetMinZBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMinZBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetMaxZBound()
// "double GetMaxZBound()"
public double GetMaxZBound() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkVolume.GetMaxZBound_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkVolume.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkMTimeType GetRedrawMTime()
// "vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkVolume.GetRedrawMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkVolume.ShallowCopy_0(this, prop);
}


// int RenderVolumetricGeometry(vtkViewport * viewport)
// "int RenderVolumetricGeometry(vtkViewport *viewport)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkVolume.RenderVolumetricGeometry_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkVolume.ReleaseGraphicsResources_0(this, ARG_0);
}


// float* GetCorrectedScalarOpacityArray(int ARG_0)
// "float *GetCorrectedScalarOpacityArray(int)"
public IntPtr GetCorrectedScalarOpacityArray(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetCorrectedScalarOpacityArray_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// float* GetCorrectedScalarOpacityArray()
// "float *GetCorrectedScalarOpacityArray()"
public IntPtr GetCorrectedScalarOpacityArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetCorrectedScalarOpacityArray_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// float* GetScalarOpacityArray(int ARG_0)
// "float *GetScalarOpacityArray(int)"
public IntPtr GetScalarOpacityArray(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetScalarOpacityArray_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// float* GetScalarOpacityArray()
// "float *GetScalarOpacityArray()"
public IntPtr GetScalarOpacityArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetScalarOpacityArray_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// float* GetGradientOpacityArray(int ARG_0)
// "float *GetGradientOpacityArray(int)"
public IntPtr GetGradientOpacityArray(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetGradientOpacityArray_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// float* GetGradientOpacityArray()
// "float *GetGradientOpacityArray()"
public IntPtr GetGradientOpacityArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetGradientOpacityArray_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// float* GetGrayArray(int ARG_0)
// "float *GetGrayArray(int)"
public IntPtr GetGrayArray(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetGrayArray_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// float* GetGrayArray()
// "float *GetGrayArray()"
public IntPtr GetGrayArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetGrayArray_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// float* GetRGBArray(int ARG_0)
// "float *GetRGBArray(int)"
public IntPtr GetRGBArray(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetRGBArray_0(returnPointer.GetPtr(), this, ARG_0);
	return (IntPtr)returnPointer;
}


// float* GetRGBArray()
// "float *GetRGBArray()"
public IntPtr GetRGBArray() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkVolume.GetRGBArray_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// float GetGradientOpacityConstant(int ARG_0)
// "float GetGradientOpacityConstant(int)"
public float GetGradientOpacityConstant(int /*(int)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkVolume.GetGradientOpacityConstant_0(returnPointer.GetPtr(), this, ARG_0);
	return (float)returnPointer;
}


// float GetGradientOpacityConstant()
// "float GetGradientOpacityConstant()"
public float GetGradientOpacityConstant() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkVolume.GetGradientOpacityConstant_1(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// float GetArraySize()
// "float GetArraySize()"
public float GetArraySize() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkVolume.GetArraySize_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// void UpdateTransferFunctions(vtkRenderer * ren)
// "void UpdateTransferFunctions(vtkRenderer *ren)"
public void UpdateTransferFunctions(vtkRenderer /*(vtkRenderer*)*/ ren) {
	VTK_API.API_vtkVolume.UpdateTransferFunctions_0(this, ren);
}


// void UpdateScalarOpacityforSampleSize(vtkRenderer * ren, float sample_distance)
// "void UpdateScalarOpacityforSampleSize(vtkRenderer *ren, float sample_distance)"
public void UpdateScalarOpacityforSampleSize(vtkRenderer /*(vtkRenderer*)*/ ren, float /*(float)*/ sample_distance) {
	VTK_API.API_vtkVolume.UpdateScalarOpacityforSampleSize_0(this, ren, sample_distance);
}


// bool GetSupportsSelection()
// "bool GetSupportsSelection()"
public bool GetSupportsSelection() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkVolume.GetSupportsSelection_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


}
};
