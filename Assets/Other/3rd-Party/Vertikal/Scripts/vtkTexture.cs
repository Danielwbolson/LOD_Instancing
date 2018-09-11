

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTexture : vtkImageAlgorithm {
		public vtkTexture(IntPtr p) : base(p) {}
		public static implicit operator  vtkTexture(IntPtr p) {return new vtkTexture(p);}
		public static implicit operator  IntPtr(vtkTexture o) {return o.GetPtr();}

// static vtkTexture* New()
// "static vtkTexture* New()"
public static vtkTexture New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.New_0(returnPointer.GetPtr());
	return (vtkTexture)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkTexture* SafeDownCast(vtkObjectBase * o)
// "static vtkTexture* SafeDownCast(vtkObjectBase *o)"
public static vtkTexture SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkTexture)(IntPtr)returnPointer;
}


// vtkTexture* NewInstance()
// "vtkTexture *NewInstance()"
public vtkTexture NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void Render(vtkRenderer * ren)
// "virtual void Render(vtkRenderer* ren)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ren) {
	VTK_API.API_vtkTexture.Render_0(this, ren);
}


// virtual void PostRender(vtkRenderer * ARG_0)
// "virtual void PostRender(vtkRenderer*)"
public void PostRender(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkTexture.PostRender_0(this, ARG_0);
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow*)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkTexture.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual void Load(vtkRenderer * ARG_0)
// "virtual void Load(vtkRenderer*)"
public void Load(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkTexture.Load_0(this, ARG_0);
}


// virtual int GetRepeat()
// "virtual int GetRepeat ()"
public int GetRepeat() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetRepeat_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetRepeat(int _arg)
// "virtual void SetRepeat (int _arg)"
public void SetRepeat(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetRepeat_0(this, _arg);
}


// virtual void RepeatOn()
// "virtual void RepeatOn ()"
public void RepeatOn() {
	VTK_API.API_vtkTexture.RepeatOn_0(this);
}


// virtual void RepeatOff()
// "virtual void RepeatOff ()"
public void RepeatOff() {
	VTK_API.API_vtkTexture.RepeatOff_0(this);
}


// virtual int GetEdgeClamp()
// "virtual int GetEdgeClamp ()"
public int GetEdgeClamp() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetEdgeClamp_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetEdgeClamp(int _arg)
// "virtual void SetEdgeClamp (int _arg)"
public void SetEdgeClamp(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetEdgeClamp_0(this, _arg);
}


// virtual void EdgeClampOn()
// "virtual void EdgeClampOn ()"
public void EdgeClampOn() {
	VTK_API.API_vtkTexture.EdgeClampOn_0(this);
}


// virtual void EdgeClampOff()
// "virtual void EdgeClampOff ()"
public void EdgeClampOff() {
	VTK_API.API_vtkTexture.EdgeClampOff_0(this);
}


// virtual int GetInterpolate()
// "virtual int GetInterpolate ()"
public int GetInterpolate() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetInterpolate_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetInterpolate(int _arg)
// "virtual void SetInterpolate (int _arg)"
public void SetInterpolate(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetInterpolate_0(this, _arg);
}


// virtual void InterpolateOn()
// "virtual void InterpolateOn ()"
public void InterpolateOn() {
	VTK_API.API_vtkTexture.InterpolateOn_0(this);
}


// virtual void InterpolateOff()
// "virtual void InterpolateOff ()"
public void InterpolateOff() {
	VTK_API.API_vtkTexture.InterpolateOff_0(this);
}


// virtual bool GetMipmap()
// "virtual bool GetMipmap ()"
public bool GetMipmap() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.GetMipmap_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetMipmap(bool _arg)
// "virtual void SetMipmap (bool _arg)"
public void SetMipmap(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetMipmap_0(this, _arg);
}


// virtual void MipmapOn()
// "virtual void MipmapOn ()"
public void MipmapOn() {
	VTK_API.API_vtkTexture.MipmapOn_0(this);
}


// virtual void MipmapOff()
// "virtual void MipmapOff ()"
public void MipmapOff() {
	VTK_API.API_vtkTexture.MipmapOff_0(this);
}


// virtual void SetQuality(int _arg)
// "virtual void SetQuality (int _arg)"
public void SetQuality(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetQuality_0(this, _arg);
}


// virtual int GetQuality()
// "virtual int GetQuality ()"
public int GetQuality() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetQuality_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetQualityToDefault()
// "void SetQualityToDefault()"
public void SetQualityToDefault() {
	VTK_API.API_vtkTexture.SetQualityToDefault_0(this);
}


// void SetQualityTo16Bit()
// "void SetQualityTo16Bit()"
public void SetQualityTo16Bit() {
	VTK_API.API_vtkTexture.SetQualityTo16Bit_0(this);
}


// void SetQualityTo32Bit()
// "void SetQualityTo32Bit()"
public void SetQualityTo32Bit() {
	VTK_API.API_vtkTexture.SetQualityTo32Bit_0(this);
}


// virtual void SetColorMode(int _arg)
// "virtual void SetColorMode (int _arg)"
public void SetColorMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetColorMode_0(this, _arg);
}


// virtual int GetColorMode()
// "virtual int GetColorMode ()"
public int GetColorMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetColorMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetColorModeToDefault()
// "void SetColorModeToDefault()"
public void SetColorModeToDefault() {
	VTK_API.API_vtkTexture.SetColorModeToDefault_0(this);
}


// void SetColorModeToMapScalars()
// "void SetColorModeToMapScalars()"
public void SetColorModeToMapScalars() {
	VTK_API.API_vtkTexture.SetColorModeToMapScalars_0(this);
}


// void SetColorModeToDirectScalars()
// "void SetColorModeToDirectScalars()"
public void SetColorModeToDirectScalars() {
	VTK_API.API_vtkTexture.SetColorModeToDirectScalars_0(this);
}


// vtkImageData* GetInput()
// "vtkImageData* GetInput()"
public vtkImageData GetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.GetInput_0(returnPointer.GetPtr(), this);
	return (vtkImageData)(IntPtr)returnPointer;
}


// void SetLookupTable(vtkScalarsToColors * ARG_0)
// "void SetLookupTable(vtkScalarsToColors *)"
public void SetLookupTable(vtkScalarsToColors /*(vtkScalarsToColors*)*/ ARG_0) {
	VTK_API.API_vtkTexture.SetLookupTable_0(this, ARG_0);
}


// virtual vtkScalarsToColors* GetLookupTable()
// "virtual vtkScalarsToColors *GetLookupTable ()"
public vtkScalarsToColors GetLookupTable() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.GetLookupTable_0(returnPointer.GetPtr(), this);
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* GetMappedScalars()
// "virtual vtkUnsignedCharArray *GetMappedScalars ()"
public vtkUnsignedCharArray GetMappedScalars() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.GetMappedScalars_0(returnPointer.GetPtr(), this);
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// char* MapScalarsToColors(vtkDataArray * scalars)
// "unsigned char* MapScalarsToColors(vtkDataArray* scalars)"
public string MapScalarsToColors(vtkDataArray /*(vtkDataArray*)*/ scalars) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.MapScalarsToColors_0(returnPointer.GetPtr(), this, scalars);
	return (string)returnPointer;
}


// void SetTransform(vtkTransform * transform)
// "void SetTransform(vtkTransform *transform)"
public void SetTransform(vtkTransform /*(vtkTransform*)*/ transform) {
	VTK_API.API_vtkTexture.SetTransform_0(this, transform);
}


// virtual vtkTransform* GetTransform()
// "virtual vtkTransform *GetTransform ()"
public vtkTransform GetTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTexture.GetTransform_0(returnPointer.GetPtr(), this);
	return (vtkTransform)(IntPtr)returnPointer;
}


// virtual int GetBlendingMode()
// "virtual int GetBlendingMode ()"
public int GetBlendingMode() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetBlendingMode_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetBlendingMode(int _arg)
// "virtual void SetBlendingMode (int _arg)"
public void SetBlendingMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetBlendingMode_0(this, _arg);
}


// virtual bool GetPremultipliedAlpha()
// "virtual bool GetPremultipliedAlpha ()"
public bool GetPremultipliedAlpha() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.GetPremultipliedAlpha_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetPremultipliedAlpha(bool _arg)
// "virtual void SetPremultipliedAlpha (bool _arg)"
public void SetPremultipliedAlpha(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetPremultipliedAlpha_0(this, _arg);
}


// virtual void PremultipliedAlphaOn()
// "virtual void PremultipliedAlphaOn ()"
public void PremultipliedAlphaOn() {
	VTK_API.API_vtkTexture.PremultipliedAlphaOn_0(this);
}


// virtual void PremultipliedAlphaOff()
// "virtual void PremultipliedAlphaOff ()"
public void PremultipliedAlphaOff() {
	VTK_API.API_vtkTexture.PremultipliedAlphaOff_0(this);
}


// virtual int GetRestrictPowerOf2ImageSmaller()
// "virtual int GetRestrictPowerOf2ImageSmaller ()"
public int GetRestrictPowerOf2ImageSmaller() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetRestrictPowerOf2ImageSmaller_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetRestrictPowerOf2ImageSmaller(int _arg)
// "virtual void SetRestrictPowerOf2ImageSmaller (int _arg)"
public void SetRestrictPowerOf2ImageSmaller(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetRestrictPowerOf2ImageSmaller_0(this, _arg);
}


// virtual void RestrictPowerOf2ImageSmallerOn()
// "virtual void RestrictPowerOf2ImageSmallerOn ()"
public void RestrictPowerOf2ImageSmallerOn() {
	VTK_API.API_vtkTexture.RestrictPowerOf2ImageSmallerOn_0(this);
}


// virtual void RestrictPowerOf2ImageSmallerOff()
// "virtual void RestrictPowerOf2ImageSmallerOff ()"
public void RestrictPowerOf2ImageSmallerOff() {
	VTK_API.API_vtkTexture.RestrictPowerOf2ImageSmallerOff_0(this);
}


// virtual int IsTranslucent()
// "virtual int IsTranslucent()"
public int IsTranslucent() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.IsTranslucent_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetTextureUnit()
// "virtual int GetTextureUnit()"
public int GetTextureUnit() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTexture.GetTextureUnit_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual bool GetCubeMap()
// "virtual bool GetCubeMap ()"
public bool GetCubeMap() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.GetCubeMap_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void CubeMapOn()
// "virtual void CubeMapOn ()"
public void CubeMapOn() {
	VTK_API.API_vtkTexture.CubeMapOn_0(this);
}


// virtual void CubeMapOff()
// "virtual void CubeMapOff ()"
public void CubeMapOff() {
	VTK_API.API_vtkTexture.CubeMapOff_0(this);
}


// void SetCubeMap(bool val)
// "void SetCubeMap(bool val)"
public void SetCubeMap(bool /*(bool)*/ val) {
	VTK_API.API_vtkTexture.SetCubeMap_0(this, val);
}


// virtual bool GetUseSRGBColorSpace()
// "virtual bool GetUseSRGBColorSpace ()"
public bool GetUseSRGBColorSpace() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTexture.GetUseSRGBColorSpace_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetUseSRGBColorSpace(bool _arg)
// "virtual void SetUseSRGBColorSpace (bool _arg)"
public void SetUseSRGBColorSpace(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetUseSRGBColorSpace_0(this, _arg);
}


// virtual void UseSRGBColorSpaceOn()
// "virtual void UseSRGBColorSpaceOn ()"
public void UseSRGBColorSpaceOn() {
	VTK_API.API_vtkTexture.UseSRGBColorSpaceOn_0(this);
}


// virtual void UseSRGBColorSpaceOff()
// "virtual void UseSRGBColorSpaceOff ()"
public void UseSRGBColorSpaceOff() {
	VTK_API.API_vtkTexture.UseSRGBColorSpaceOff_0(this);
}


}
};
