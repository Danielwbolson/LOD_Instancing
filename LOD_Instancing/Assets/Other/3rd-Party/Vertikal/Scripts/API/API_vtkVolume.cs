
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkVolume {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolume_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVolume_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, string /*(char*)*/ type);

// static vtkVolume* SafeDownCast(vtkObjectBase * o)
// static vtkVolume* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkVolume_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkVolume* NewInstance()
// vtkVolume *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkVolume_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// static vtkVolume* New()
// static vtkVolume *New()
[DllImport("vtkplugin", EntryPoint="vtkVolume_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void SetMapper(vtkAbstractVolumeMapper * mapper)
// void SetMapper(vtkAbstractVolumeMapper *mapper)
[DllImport("vtkplugin", EntryPoint="vtkVolume_SetMapper_0")] public static extern 
bool SetMapper_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkAbstractVolumeMapper*)*/ mapper);

// virtual vtkAbstractVolumeMapper* GetMapper()
// virtual vtkAbstractVolumeMapper *GetMapper ()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMapper_0")] public static extern 
bool GetMapper_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// void SetProperty(vtkVolumeProperty * property)
// void SetProperty(vtkVolumeProperty *property)
[DllImport("vtkplugin", EntryPoint="vtkVolume_SetProperty_0")] public static extern 
bool SetProperty_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkVolumeProperty*)*/ property);

// vtkVolumeProperty* GetProperty()
// vtkVolumeProperty *GetProperty()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetProperty_0")] public static extern 
bool GetProperty_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// void GetVolumes(vtkPropCollection * vc)
// void GetVolumes(vtkPropCollection *vc)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetVolumes_0")] public static extern 
bool GetVolumes_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ vc);

// void Update()
// void Update()
[DllImport("vtkplugin", EntryPoint="vtkVolume_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkVolume*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkVolume*)*/ callingObject, double /*(double[6])*/ []bounds);

// double GetMinXBound()
// double GetMinXBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMinXBound_0")] public static extern 
bool GetMinXBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// double GetMaxXBound()
// double GetMaxXBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMaxXBound_0")] public static extern 
bool GetMaxXBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// double GetMinYBound()
// double GetMinYBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMinYBound_0")] public static extern 
bool GetMinYBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// double GetMaxYBound()
// double GetMaxYBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMaxYBound_0")] public static extern 
bool GetMaxYBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// double GetMinZBound()
// double GetMinZBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMinZBound_0")] public static extern 
bool GetMinZBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// double GetMaxZBound()
// double GetMaxZBound()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMaxZBound_0")] public static extern 
bool GetMaxZBound_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// vtkMTimeType GetRedrawMTime()
// vtkMTimeType GetRedrawMTime()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetRedrawMTime_0")] public static extern 
bool GetRedrawMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// void ShallowCopy(vtkProp * prop)
// void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkVolume_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// int RenderVolumetricGeometry(vtkViewport * viewport)
// int RenderVolumetricGeometry(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkVolume_RenderVolumetricGeometry_0")] public static extern 
bool RenderVolumetricGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkVolume_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// float* GetCorrectedScalarOpacityArray(int ARG_0)
// float *GetCorrectedScalarOpacityArray(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetCorrectedScalarOpacityArray_0")] public static extern 
bool GetCorrectedScalarOpacityArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float* GetCorrectedScalarOpacityArray()
// float *GetCorrectedScalarOpacityArray()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetCorrectedScalarOpacityArray_1")] public static extern 
bool GetCorrectedScalarOpacityArray_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float* GetScalarOpacityArray(int ARG_0)
// float *GetScalarOpacityArray(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetScalarOpacityArray_0")] public static extern 
bool GetScalarOpacityArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float* GetScalarOpacityArray()
// float *GetScalarOpacityArray()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetScalarOpacityArray_1")] public static extern 
bool GetScalarOpacityArray_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float* GetGradientOpacityArray(int ARG_0)
// float *GetGradientOpacityArray(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGradientOpacityArray_0")] public static extern 
bool GetGradientOpacityArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float* GetGradientOpacityArray()
// float *GetGradientOpacityArray()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGradientOpacityArray_1")] public static extern 
bool GetGradientOpacityArray_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float* GetGrayArray(int ARG_0)
// float *GetGrayArray(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGrayArray_0")] public static extern 
bool GetGrayArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float* GetGrayArray()
// float *GetGrayArray()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGrayArray_1")] public static extern 
bool GetGrayArray_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float* GetRGBArray(int ARG_0)
// float *GetRGBArray(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetRGBArray_0")] public static extern 
bool GetRGBArray_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float* GetRGBArray()
// float *GetRGBArray()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetRGBArray_1")] public static extern 
bool GetRGBArray_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float GetGradientOpacityConstant(int ARG_0)
// float GetGradientOpacityConstant(int)
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGradientOpacityConstant_0")] public static extern 
bool GetGradientOpacityConstant_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject, int /*(int)*/ ARG_0);

// float GetGradientOpacityConstant()
// float GetGradientOpacityConstant()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetGradientOpacityConstant_1")] public static extern 
bool GetGradientOpacityConstant_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// float GetArraySize()
// float GetArraySize()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetArraySize_0")] public static extern 
bool GetArraySize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

// void UpdateTransferFunctions(vtkRenderer * ren)
// void UpdateTransferFunctions(vtkRenderer *ren)
[DllImport("vtkplugin", EntryPoint="vtkVolume_UpdateTransferFunctions_0")] public static extern 
bool UpdateTransferFunctions_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren);

// void UpdateScalarOpacityforSampleSize(vtkRenderer * ren, float sample_distance)
// void UpdateScalarOpacityforSampleSize(vtkRenderer *ren, float sample_distance)
[DllImport("vtkplugin", EntryPoint="vtkVolume_UpdateScalarOpacityforSampleSize_0")] public static extern 
bool UpdateScalarOpacityforSampleSize_0(IntPtr /*(vtkVolume*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, float /*(float)*/ sample_distance);

// bool GetSupportsSelection()
// bool GetSupportsSelection()
[DllImport("vtkplugin", EntryPoint="vtkVolume_GetSupportsSelection_0")] public static extern 
bool GetSupportsSelection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkVolume*)*/ callingObject);

}
};
