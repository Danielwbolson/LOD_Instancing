
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkFXAAOptions {

// static vtkFXAAOptions* New()
// static vtkFXAAOptions* New()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject, string /*(char*)*/ type);

// static vtkFXAAOptions* SafeDownCast(vtkObjectBase * o)
// static vtkFXAAOptions* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkFXAAOptions* NewInstance()
// vtkFXAAOptions *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetRelativeContrastThreshold(float _arg)
// virtual void SetRelativeContrastThreshold (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetRelativeContrastThreshold_0")] public static extern 
bool SetRelativeContrastThreshold_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetRelativeContrastThresholdMinValue()
// virtual float GetRelativeContrastThresholdMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetRelativeContrastThresholdMinValue_0")] public static extern 
bool GetRelativeContrastThresholdMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetRelativeContrastThresholdMaxValue()
// virtual float GetRelativeContrastThresholdMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetRelativeContrastThresholdMaxValue_0")] public static extern 
bool GetRelativeContrastThresholdMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetRelativeContrastThreshold()
// virtual float GetRelativeContrastThreshold ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetRelativeContrastThreshold_0")] public static extern 
bool GetRelativeContrastThreshold_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetHardContrastThreshold(float _arg)
// virtual void SetHardContrastThreshold (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetHardContrastThreshold_0")] public static extern 
bool SetHardContrastThreshold_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetHardContrastThresholdMinValue()
// virtual float GetHardContrastThresholdMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetHardContrastThresholdMinValue_0")] public static extern 
bool GetHardContrastThresholdMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetHardContrastThresholdMaxValue()
// virtual float GetHardContrastThresholdMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetHardContrastThresholdMaxValue_0")] public static extern 
bool GetHardContrastThresholdMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetHardContrastThreshold()
// virtual float GetHardContrastThreshold ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetHardContrastThreshold_0")] public static extern 
bool GetHardContrastThreshold_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetSubpixelBlendLimit(float _arg)
// virtual void SetSubpixelBlendLimit (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetSubpixelBlendLimit_0")] public static extern 
bool SetSubpixelBlendLimit_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetSubpixelBlendLimitMinValue()
// virtual float GetSubpixelBlendLimitMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelBlendLimitMinValue_0")] public static extern 
bool GetSubpixelBlendLimitMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetSubpixelBlendLimitMaxValue()
// virtual float GetSubpixelBlendLimitMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelBlendLimitMaxValue_0")] public static extern 
bool GetSubpixelBlendLimitMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetSubpixelBlendLimit()
// virtual float GetSubpixelBlendLimit ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelBlendLimit_0")] public static extern 
bool GetSubpixelBlendLimit_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetSubpixelContrastThreshold(float _arg)
// virtual void SetSubpixelContrastThreshold (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetSubpixelContrastThreshold_0")] public static extern 
bool SetSubpixelContrastThreshold_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetSubpixelContrastThresholdMinValue()
// virtual float GetSubpixelContrastThresholdMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelContrastThresholdMinValue_0")] public static extern 
bool GetSubpixelContrastThresholdMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetSubpixelContrastThresholdMaxValue()
// virtual float GetSubpixelContrastThresholdMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelContrastThresholdMaxValue_0")] public static extern 
bool GetSubpixelContrastThresholdMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual float GetSubpixelContrastThreshold()
// virtual float GetSubpixelContrastThreshold ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetSubpixelContrastThreshold_0")] public static extern 
bool GetSubpixelContrastThreshold_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetUseHighQualityEndpoints(bool _arg)
// virtual void SetUseHighQualityEndpoints (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetUseHighQualityEndpoints_0")] public static extern 
bool SetUseHighQualityEndpoints_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseHighQualityEndpoints()
// virtual bool GetUseHighQualityEndpoints ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetUseHighQualityEndpoints_0")] public static extern 
bool GetUseHighQualityEndpoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void UseHighQualityEndpointsOn()
// virtual void UseHighQualityEndpointsOn ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_UseHighQualityEndpointsOn_0")] public static extern 
bool UseHighQualityEndpointsOn_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void UseHighQualityEndpointsOff()
// virtual void UseHighQualityEndpointsOff ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_UseHighQualityEndpointsOff_0")] public static extern 
bool UseHighQualityEndpointsOff_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual void SetEndpointSearchIterations(int _arg)
// virtual void SetEndpointSearchIterations (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_SetEndpointSearchIterations_0")] public static extern 
bool SetEndpointSearchIterations_0(IntPtr /*(vtkFXAAOptions*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetEndpointSearchIterationsMinValue()
// virtual int GetEndpointSearchIterationsMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetEndpointSearchIterationsMinValue_0")] public static extern 
bool GetEndpointSearchIterationsMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual int GetEndpointSearchIterationsMaxValue()
// virtual int GetEndpointSearchIterationsMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetEndpointSearchIterationsMaxValue_0")] public static extern 
bool GetEndpointSearchIterationsMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

// virtual int GetEndpointSearchIterations()
// virtual int GetEndpointSearchIterations ()
[DllImport("vtkplugin", EntryPoint="vtkFXAAOptions_GetEndpointSearchIterations_0")] public static extern 
bool GetEndpointSearchIterations_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFXAAOptions*)*/ callingObject);

}
};
