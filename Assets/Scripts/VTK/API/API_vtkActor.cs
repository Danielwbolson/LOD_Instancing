
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkActor {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject, string /*(char*)*/ type);

// static vtkActor* SafeDownCast(vtkObjectBase * o)
// static vtkActor* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkActor_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkActor* NewInstance()
// vtkActor *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkActor_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// static vtkActor* New()
// static vtkActor *New()
[DllImport("vtkplugin", EntryPoint="vtkActor_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void GetActors(vtkPropCollection * ARG_0)
// void GetActors(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkActor_GetActors_0")] public static extern 
bool GetActors_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// int RenderOpaqueGeometry(vtkViewport * viewport)
// int RenderOpaqueGeometry(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// int RenderTranslucentPolygonalGeometry(vtkViewport * viewport)
// int RenderTranslucentPolygonalGeometry(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// int HasTranslucentPolygonalGeometry()
// int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkActor_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void Render(vtkRenderer * ARG_0, vtkMapper * ARG_1)
// virtual void Render(vtkRenderer *, vtkMapper *)
[DllImport("vtkplugin", EntryPoint="vtkActor_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0, IntPtr /*(vtkMapper*)*/ ARG_1);

// void ShallowCopy(vtkProp * prop)
// void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkActor_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkActor_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// void SetProperty(vtkProperty * lut)
// void SetProperty(vtkProperty *lut)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetProperty_0")] public static extern 
bool SetProperty_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkProperty*)*/ lut);

// vtkProperty* GetProperty()
// vtkProperty *GetProperty()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetProperty_0")] public static extern 
bool GetProperty_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual vtkProperty* MakeProperty()
// virtual vtkProperty* MakeProperty()
[DllImport("vtkplugin", EntryPoint="vtkActor_MakeProperty_0")] public static extern 
bool MakeProperty_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// void SetBackfaceProperty(vtkProperty * lut)
// void SetBackfaceProperty(vtkProperty *lut)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetBackfaceProperty_0")] public static extern 
bool SetBackfaceProperty_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkProperty*)*/ lut);

// virtual vtkProperty* GetBackfaceProperty()
// virtual vtkProperty *GetBackfaceProperty ()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetBackfaceProperty_0")] public static extern 
bool GetBackfaceProperty_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void SetTexture(vtkTexture * ARG_0)
// virtual void SetTexture(vtkTexture*)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetTexture_0")] public static extern 
bool SetTexture_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkTexture*)*/ ARG_0);

// virtual vtkTexture* GetTexture()
// virtual vtkTexture *GetTexture ()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetTexture_0")] public static extern 
bool GetTexture_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void SetMapper(vtkMapper * ARG_0)
// virtual void SetMapper(vtkMapper *)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetMapper_0")] public static extern 
bool SetMapper_0(IntPtr /*(vtkActor*)*/ callingObject, IntPtr /*(vtkMapper*)*/ ARG_0);

// virtual vtkMapper* GetMapper()
// virtual vtkMapper *GetMapper ()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetMapper_0")] public static extern 
bool GetMapper_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void ApplyProperties()
// virtual void ApplyProperties()
[DllImport("vtkplugin", EntryPoint="vtkActor_ApplyProperties_0")] public static extern 
bool ApplyProperties_0(IntPtr /*(vtkActor*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// vtkMTimeType GetRedrawMTime()
// vtkMTimeType GetRedrawMTime()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetRedrawMTime_0")] public static extern 
bool GetRedrawMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual bool GetForceOpaque()
// virtual bool GetForceOpaque ()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetForceOpaque_0")] public static extern 
bool GetForceOpaque_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void SetForceOpaque(bool _arg)
// virtual void SetForceOpaque (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetForceOpaque_0")] public static extern 
bool SetForceOpaque_0(IntPtr /*(vtkActor*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void ForceOpaqueOn()
// virtual void ForceOpaqueOn ()
[DllImport("vtkplugin", EntryPoint="vtkActor_ForceOpaqueOn_0")] public static extern 
bool ForceOpaqueOn_0(IntPtr /*(vtkActor*)*/ callingObject);

// virtual void ForceOpaqueOff()
// virtual void ForceOpaqueOff ()
[DllImport("vtkplugin", EntryPoint="vtkActor_ForceOpaqueOff_0")] public static extern 
bool ForceOpaqueOff_0(IntPtr /*(vtkActor*)*/ callingObject);

// virtual bool GetForceTranslucent()
// virtual bool GetForceTranslucent ()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetForceTranslucent_0")] public static extern 
bool GetForceTranslucent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

// virtual void SetForceTranslucent(bool _arg)
// virtual void SetForceTranslucent (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkActor_SetForceTranslucent_0")] public static extern 
bool SetForceTranslucent_0(IntPtr /*(vtkActor*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void ForceTranslucentOn()
// virtual void ForceTranslucentOn ()
[DllImport("vtkplugin", EntryPoint="vtkActor_ForceTranslucentOn_0")] public static extern 
bool ForceTranslucentOn_0(IntPtr /*(vtkActor*)*/ callingObject);

// virtual void ForceTranslucentOff()
// virtual void ForceTranslucentOff ()
[DllImport("vtkplugin", EntryPoint="vtkActor_ForceTranslucentOff_0")] public static extern 
bool ForceTranslucentOff_0(IntPtr /*(vtkActor*)*/ callingObject);

// bool GetSupportsSelection()
// bool GetSupportsSelection()
[DllImport("vtkplugin", EntryPoint="vtkActor_GetSupportsSelection_0")] public static extern 
bool GetSupportsSelection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor*)*/ callingObject);

}
};
