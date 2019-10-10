
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkTexture {

// static vtkTexture* New()
// static vtkTexture* New()
[DllImport("vtkplugin", EntryPoint="vtkTexture_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTexture_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTexture_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject, string /*(char*)*/ type);

// static vtkTexture* SafeDownCast(vtkObjectBase * o)
// static vtkTexture* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkTexture* NewInstance()
// vtkTexture *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkTexture_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void Render(vtkRenderer * ren)
// virtual void Render(vtkRenderer* ren)
[DllImport("vtkplugin", EntryPoint="vtkTexture_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren);

// virtual void PostRender(vtkRenderer * ARG_0)
// virtual void PostRender(vtkRenderer*)
[DllImport("vtkplugin", EntryPoint="vtkTexture_PostRender_0")] public static extern 
bool PostRender_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// virtual void ReleaseGraphicsResources(vtkWindow*)
[DllImport("vtkplugin", EntryPoint="vtkTexture_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// virtual void Load(vtkRenderer * ARG_0)
// virtual void Load(vtkRenderer*)
[DllImport("vtkplugin", EntryPoint="vtkTexture_Load_0")] public static extern 
bool Load_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// virtual int GetRepeat()
// virtual int GetRepeat ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetRepeat_0")] public static extern 
bool GetRepeat_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetRepeat(int _arg)
// virtual void SetRepeat (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetRepeat_0")] public static extern 
bool SetRepeat_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual void RepeatOn()
// virtual void RepeatOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_RepeatOn_0")] public static extern 
bool RepeatOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void RepeatOff()
// virtual void RepeatOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_RepeatOff_0")] public static extern 
bool RepeatOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int GetEdgeClamp()
// virtual int GetEdgeClamp ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetEdgeClamp_0")] public static extern 
bool GetEdgeClamp_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetEdgeClamp(int _arg)
// virtual void SetEdgeClamp (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetEdgeClamp_0")] public static extern 
bool SetEdgeClamp_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual void EdgeClampOn()
// virtual void EdgeClampOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_EdgeClampOn_0")] public static extern 
bool EdgeClampOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void EdgeClampOff()
// virtual void EdgeClampOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_EdgeClampOff_0")] public static extern 
bool EdgeClampOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int GetInterpolate()
// virtual int GetInterpolate ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetInterpolate_0")] public static extern 
bool GetInterpolate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetInterpolate(int _arg)
// virtual void SetInterpolate (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetInterpolate_0")] public static extern 
bool SetInterpolate_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual void InterpolateOn()
// virtual void InterpolateOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_InterpolateOn_0")] public static extern 
bool InterpolateOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void InterpolateOff()
// virtual void InterpolateOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_InterpolateOff_0")] public static extern 
bool InterpolateOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual bool GetMipmap()
// virtual bool GetMipmap ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetMipmap_0")] public static extern 
bool GetMipmap_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetMipmap(bool _arg)
// virtual void SetMipmap (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetMipmap_0")] public static extern 
bool SetMipmap_0(IntPtr /*(vtkTexture*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void MipmapOn()
// virtual void MipmapOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_MipmapOn_0")] public static extern 
bool MipmapOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void MipmapOff()
// virtual void MipmapOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_MipmapOff_0")] public static extern 
bool MipmapOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetQuality(int _arg)
// virtual void SetQuality (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetQuality_0")] public static extern 
bool SetQuality_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetQuality()
// virtual int GetQuality ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetQuality_0")] public static extern 
bool GetQuality_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// void SetQualityToDefault()
// void SetQualityToDefault()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetQualityToDefault_0")] public static extern 
bool SetQualityToDefault_0(IntPtr /*(vtkTexture*)*/ callingObject);

// void SetQualityTo16Bit()
// void SetQualityTo16Bit()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetQualityTo16Bit_0")] public static extern 
bool SetQualityTo16Bit_0(IntPtr /*(vtkTexture*)*/ callingObject);

// void SetQualityTo32Bit()
// void SetQualityTo32Bit()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetQualityTo32Bit_0")] public static extern 
bool SetQualityTo32Bit_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetColorMode(int _arg)
// virtual void SetColorMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetColorMode_0")] public static extern 
bool SetColorMode_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetColorMode()
// virtual int GetColorMode ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetColorMode_0")] public static extern 
bool GetColorMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// void SetColorModeToDefault()
// void SetColorModeToDefault()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetColorModeToDefault_0")] public static extern 
bool SetColorModeToDefault_0(IntPtr /*(vtkTexture*)*/ callingObject);

// void SetColorModeToMapScalars()
// void SetColorModeToMapScalars()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetColorModeToMapScalars_0")] public static extern 
bool SetColorModeToMapScalars_0(IntPtr /*(vtkTexture*)*/ callingObject);

// void SetColorModeToDirectScalars()
// void SetColorModeToDirectScalars()
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetColorModeToDirectScalars_0")] public static extern 
bool SetColorModeToDirectScalars_0(IntPtr /*(vtkTexture*)*/ callingObject);

// vtkImageData* GetInput()
// vtkImageData* GetInput()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// void SetLookupTable(vtkScalarsToColors * ARG_0)
// void SetLookupTable(vtkScalarsToColors *)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetLookupTable_0")] public static extern 
bool SetLookupTable_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ ARG_0);

// virtual vtkScalarsToColors* GetLookupTable()
// virtual vtkScalarsToColors *GetLookupTable ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetLookupTable_0")] public static extern 
bool GetLookupTable_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual vtkUnsignedCharArray* GetMappedScalars()
// virtual vtkUnsignedCharArray *GetMappedScalars ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetMappedScalars_0")] public static extern 
bool GetMappedScalars_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// char* MapScalarsToColors(vtkDataArray * scalars)
// unsigned char* MapScalarsToColors(vtkDataArray* scalars)
[DllImport("vtkplugin", EntryPoint="vtkTexture_MapScalarsToColors_0")] public static extern 
bool MapScalarsToColors_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars);

// void SetTransform(vtkTransform * transform)
// void SetTransform(vtkTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetTransform_0")] public static extern 
bool SetTransform_0(IntPtr /*(vtkTexture*)*/ callingObject, IntPtr /*(vtkTransform*)*/ transform);

// virtual vtkTransform* GetTransform()
// virtual vtkTransform *GetTransform ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetTransform_0")] public static extern 
bool GetTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int GetBlendingMode()
// virtual int GetBlendingMode ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetBlendingMode_0")] public static extern 
bool GetBlendingMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetBlendingMode(int _arg)
// virtual void SetBlendingMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetBlendingMode_0")] public static extern 
bool SetBlendingMode_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual bool GetPremultipliedAlpha()
// virtual bool GetPremultipliedAlpha ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetPremultipliedAlpha_0")] public static extern 
bool GetPremultipliedAlpha_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetPremultipliedAlpha(bool _arg)
// virtual void SetPremultipliedAlpha (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetPremultipliedAlpha_0")] public static extern 
bool SetPremultipliedAlpha_0(IntPtr /*(vtkTexture*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void PremultipliedAlphaOn()
// virtual void PremultipliedAlphaOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_PremultipliedAlphaOn_0")] public static extern 
bool PremultipliedAlphaOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void PremultipliedAlphaOff()
// virtual void PremultipliedAlphaOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_PremultipliedAlphaOff_0")] public static extern 
bool PremultipliedAlphaOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int GetRestrictPowerOf2ImageSmaller()
// virtual int GetRestrictPowerOf2ImageSmaller ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetRestrictPowerOf2ImageSmaller_0")] public static extern 
bool GetRestrictPowerOf2ImageSmaller_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetRestrictPowerOf2ImageSmaller(int _arg)
// virtual void SetRestrictPowerOf2ImageSmaller (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetRestrictPowerOf2ImageSmaller_0")] public static extern 
bool SetRestrictPowerOf2ImageSmaller_0(IntPtr /*(vtkTexture*)*/ callingObject, int /*(int)*/ _arg);

// virtual void RestrictPowerOf2ImageSmallerOn()
// virtual void RestrictPowerOf2ImageSmallerOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_RestrictPowerOf2ImageSmallerOn_0")] public static extern 
bool RestrictPowerOf2ImageSmallerOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void RestrictPowerOf2ImageSmallerOff()
// virtual void RestrictPowerOf2ImageSmallerOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_RestrictPowerOf2ImageSmallerOff_0")] public static extern 
bool RestrictPowerOf2ImageSmallerOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int IsTranslucent()
// virtual int IsTranslucent()
[DllImport("vtkplugin", EntryPoint="vtkTexture_IsTranslucent_0")] public static extern 
bool IsTranslucent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual int GetTextureUnit()
// virtual int GetTextureUnit()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetTextureUnit_0")] public static extern 
bool GetTextureUnit_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual bool GetCubeMap()
// virtual bool GetCubeMap ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetCubeMap_0")] public static extern 
bool GetCubeMap_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void CubeMapOn()
// virtual void CubeMapOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_CubeMapOn_0")] public static extern 
bool CubeMapOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void CubeMapOff()
// virtual void CubeMapOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_CubeMapOff_0")] public static extern 
bool CubeMapOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

// void SetCubeMap(bool val)
// void SetCubeMap(bool val)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetCubeMap_0")] public static extern 
bool SetCubeMap_0(IntPtr /*(vtkTexture*)*/ callingObject, bool /*(bool)*/ val);

// virtual bool GetUseSRGBColorSpace()
// virtual bool GetUseSRGBColorSpace ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_GetUseSRGBColorSpace_0")] public static extern 
bool GetUseSRGBColorSpace_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void SetUseSRGBColorSpace(bool _arg)
// virtual void SetUseSRGBColorSpace (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkTexture_SetUseSRGBColorSpace_0")] public static extern 
bool SetUseSRGBColorSpace_0(IntPtr /*(vtkTexture*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void UseSRGBColorSpaceOn()
// virtual void UseSRGBColorSpaceOn ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_UseSRGBColorSpaceOn_0")] public static extern 
bool UseSRGBColorSpaceOn_0(IntPtr /*(vtkTexture*)*/ callingObject);

// virtual void UseSRGBColorSpaceOff()
// virtual void UseSRGBColorSpaceOff ()
[DllImport("vtkplugin", EntryPoint="vtkTexture_UseSRGBColorSpaceOff_0")] public static extern 
bool UseSRGBColorSpaceOff_0(IntPtr /*(vtkTexture*)*/ callingObject);

}
};
