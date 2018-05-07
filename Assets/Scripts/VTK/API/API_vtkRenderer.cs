
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRenderer {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject, string /*(char*)*/ type);

// static vtkRenderer* SafeDownCast(vtkObjectBase * o)
// static vtkRenderer* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRenderer* NewInstance()
// vtkRenderer *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// static vtkRenderer* New()
// static vtkRenderer *New()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void AddActor(vtkProp * p)
// void AddActor(vtkProp *p)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AddActor_0")] public static extern 
bool AddActor_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// void AddVolume(vtkProp * p)
// void AddVolume(vtkProp *p)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AddVolume_0")] public static extern 
bool AddVolume_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// void RemoveActor(vtkProp * p)
// void RemoveActor(vtkProp *p)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_RemoveActor_0")] public static extern 
bool RemoveActor_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// void RemoveVolume(vtkProp * p)
// void RemoveVolume(vtkProp *p)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_RemoveVolume_0")] public static extern 
bool RemoveVolume_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// void AddLight(vtkLight * ARG_0)
// void AddLight(vtkLight *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AddLight_0")] public static extern 
bool AddLight_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkLight*)*/ ARG_0);

// void RemoveLight(vtkLight * ARG_0)
// void RemoveLight(vtkLight *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_RemoveLight_0")] public static extern 
bool RemoveLight_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkLight*)*/ ARG_0);

// void RemoveAllLights()
// void RemoveAllLights()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_RemoveAllLights_0")] public static extern 
bool RemoveAllLights_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// vtkLightCollection* GetLights()
// vtkLightCollection *GetLights()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetLights_0")] public static extern 
bool GetLights_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// void SetLightCollection(vtkLightCollection * lights)
// void SetLightCollection(vtkLightCollection *lights)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetLightCollection_0")] public static extern 
bool SetLightCollection_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkLightCollection*)*/ lights);

// void CreateLight()
// void CreateLight(void)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_CreateLight_0")] public static extern 
bool CreateLight_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual vtkLight* MakeLight()
// virtual vtkLight *MakeLight()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_MakeLight_0")] public static extern 
bool MakeLight_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int GetTwoSidedLighting()
// virtual int GetTwoSidedLighting ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetTwoSidedLighting_0")] public static extern 
bool GetTwoSidedLighting_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetTwoSidedLighting(int _arg)
// virtual void SetTwoSidedLighting (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetTwoSidedLighting_0")] public static extern 
bool SetTwoSidedLighting_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual void TwoSidedLightingOn()
// virtual void TwoSidedLightingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_TwoSidedLightingOn_0")] public static extern 
bool TwoSidedLightingOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void TwoSidedLightingOff()
// virtual void TwoSidedLightingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_TwoSidedLightingOff_0")] public static extern 
bool TwoSidedLightingOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetLightFollowCamera(int _arg)
// virtual void SetLightFollowCamera (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetLightFollowCamera_0")] public static extern 
bool SetLightFollowCamera_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLightFollowCamera()
// virtual int GetLightFollowCamera ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetLightFollowCamera_0")] public static extern 
bool GetLightFollowCamera_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void LightFollowCameraOn()
// virtual void LightFollowCameraOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_LightFollowCameraOn_0")] public static extern 
bool LightFollowCameraOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void LightFollowCameraOff()
// virtual void LightFollowCameraOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_LightFollowCameraOff_0")] public static extern 
bool LightFollowCameraOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int GetAutomaticLightCreation()
// virtual int GetAutomaticLightCreation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetAutomaticLightCreation_0")] public static extern 
bool GetAutomaticLightCreation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetAutomaticLightCreation(int _arg)
// virtual void SetAutomaticLightCreation (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetAutomaticLightCreation_0")] public static extern 
bool SetAutomaticLightCreation_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual void AutomaticLightCreationOn()
// virtual void AutomaticLightCreationOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AutomaticLightCreationOn_0")] public static extern 
bool AutomaticLightCreationOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void AutomaticLightCreationOff()
// virtual void AutomaticLightCreationOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AutomaticLightCreationOff_0")] public static extern 
bool AutomaticLightCreationOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int UpdateLightsGeometryToFollowCamera()
// virtual int UpdateLightsGeometryToFollowCamera(void)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UpdateLightsGeometryToFollowCamera_0")] public static extern 
bool UpdateLightsGeometryToFollowCamera_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// vtkVolumeCollection* GetVolumes()
// vtkVolumeCollection *GetVolumes()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetVolumes_0")] public static extern 
bool GetVolumes_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// vtkActorCollection* GetActors()
// vtkActorCollection *GetActors()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetActors_0")] public static extern 
bool GetActors_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// void SetActiveCamera(vtkCamera * ARG_0)
// void SetActiveCamera(vtkCamera *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetActiveCamera_0")] public static extern 
bool SetActiveCamera_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkCamera*)*/ ARG_0);

// vtkCamera* GetActiveCamera()
// vtkCamera *GetActiveCamera()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetActiveCamera_0")] public static extern 
bool GetActiveCamera_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual vtkCamera* MakeCamera()
// virtual vtkCamera *MakeCamera()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_MakeCamera_0")] public static extern 
bool MakeCamera_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetErase(int _arg)
// virtual void SetErase (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetErase_0")] public static extern 
bool SetErase_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetErase()
// virtual int GetErase ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetErase_0")] public static extern 
bool GetErase_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void EraseOn()
// virtual void EraseOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_EraseOn_0")] public static extern 
bool EraseOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void EraseOff()
// virtual void EraseOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_EraseOff_0")] public static extern 
bool EraseOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetDraw(int _arg)
// virtual void SetDraw (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetDraw_0")] public static extern 
bool SetDraw_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDraw()
// virtual int GetDraw ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetDraw_0")] public static extern 
bool GetDraw_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void DrawOn()
// virtual void DrawOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_DrawOn_0")] public static extern 
bool DrawOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void DrawOff()
// virtual void DrawOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_DrawOff_0")] public static extern 
bool DrawOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// int CaptureGL2PSSpecialProp(vtkProp * ARG_0)
// int CaptureGL2PSSpecialProp(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_CaptureGL2PSSpecialProp_0")] public static extern 
bool CaptureGL2PSSpecialProp_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// void SetGL2PSSpecialPropCollection(vtkPropCollection * ARG_0)
// void SetGL2PSSpecialPropCollection(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetGL2PSSpecialPropCollection_0")] public static extern 
bool SetGL2PSSpecialPropCollection_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// void AddCuller(vtkCuller * ARG_0)
// void AddCuller(vtkCuller *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_AddCuller_0")] public static extern 
bool AddCuller_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkCuller*)*/ ARG_0);

// void RemoveCuller(vtkCuller * ARG_0)
// void RemoveCuller(vtkCuller *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_RemoveCuller_0")] public static extern 
bool RemoveCuller_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkCuller*)*/ ARG_0);

// vtkCullerCollection* GetCullers()
// vtkCullerCollection *GetCullers()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetCullers_0")] public static extern 
bool GetCullers_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
// virtual void SetAmbient (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetAmbient_0")] public static extern 
bool SetAmbient_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetAmbient(double _arg[3])
// virtual void SetAmbient (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetAmbient_1")] public static extern 
bool SetAmbient_1(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetAmbient()
// virtual double *GetAmbient ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetAmbient_0")] public static extern 
bool GetAmbient_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void GetAmbient(double data[3])
// virtual void GetAmbient (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetAmbient_1")] public static extern 
bool GetAmbient_1(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetAllocatedRenderTime(double _arg)
// virtual void SetAllocatedRenderTime (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetAllocatedRenderTime_0")] public static extern 
bool SetAllocatedRenderTime_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetAllocatedRenderTime()
// virtual double GetAllocatedRenderTime()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetAllocatedRenderTime_0")] public static extern 
bool GetAllocatedRenderTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetTimeFactor()
// virtual double GetTimeFactor()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetTimeFactor_0")] public static extern 
bool GetTimeFactor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void Render()
// virtual void Render()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void DeviceRender()
// virtual void DeviceRender()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_DeviceRender_0")] public static extern 
bool DeviceRender_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void DeviceRenderOpaqueGeometry()
// virtual void DeviceRenderOpaqueGeometry()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_DeviceRenderOpaqueGeometry_0")] public static extern 
bool DeviceRenderOpaqueGeometry_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void DeviceRenderTranslucentPolygonalGeometry()
// virtual void DeviceRenderTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_0")] public static extern 
bool DeviceRenderTranslucentPolygonalGeometry_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ClearLights()
// virtual void ClearLights(void)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ClearLights_0")] public static extern 
bool ClearLights_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void Clear()
// virtual void Clear()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_Clear_0")] public static extern 
bool Clear_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// int VisibleActorCount()
// int VisibleActorCount()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_VisibleActorCount_0")] public static extern 
bool VisibleActorCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// int VisibleVolumeCount()
// int VisibleVolumeCount()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_VisibleVolumeCount_0")] public static extern 
bool VisibleVolumeCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// void ComputeVisiblePropBounds(double bounds[6])
// void ComputeVisiblePropBounds( double bounds[6] )
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ComputeVisiblePropBounds_0")] public static extern 
bool ComputeVisiblePropBounds_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* ComputeVisiblePropBounds()
// double *ComputeVisiblePropBounds()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ComputeVisiblePropBounds_1")] public static extern 
bool ComputeVisiblePropBounds_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ResetCameraClippingRange()
// virtual void ResetCameraClippingRange()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCameraClippingRange_0")] public static extern 
bool ResetCameraClippingRange_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ResetCameraClippingRange(double bounds[6])
// virtual void ResetCameraClippingRange( double bounds[6] )
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCameraClippingRange_1")] public static extern 
bool ResetCameraClippingRange_1(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double[6])*/ []bounds);

// virtual void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// virtual void ResetCameraClippingRange( double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCameraClippingRange_2")] public static extern 
bool ResetCameraClippingRange_2(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax);

// virtual void SetNearClippingPlaneTolerance(double _arg)
// virtual void SetNearClippingPlaneTolerance (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetNearClippingPlaneTolerance_0")] public static extern 
bool SetNearClippingPlaneTolerance_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetNearClippingPlaneToleranceMinValue()
// virtual double GetNearClippingPlaneToleranceMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetNearClippingPlaneToleranceMinValue_0")] public static extern 
bool GetNearClippingPlaneToleranceMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetNearClippingPlaneToleranceMaxValue()
// virtual double GetNearClippingPlaneToleranceMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetNearClippingPlaneToleranceMaxValue_0")] public static extern 
bool GetNearClippingPlaneToleranceMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetNearClippingPlaneTolerance()
// virtual double GetNearClippingPlaneTolerance ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetNearClippingPlaneTolerance_0")] public static extern 
bool GetNearClippingPlaneTolerance_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetClippingRangeExpansion(double _arg)
// virtual void SetClippingRangeExpansion (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetClippingRangeExpansion_0")] public static extern 
bool SetClippingRangeExpansion_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetClippingRangeExpansionMinValue()
// virtual double GetClippingRangeExpansionMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetClippingRangeExpansionMinValue_0")] public static extern 
bool GetClippingRangeExpansionMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetClippingRangeExpansionMaxValue()
// virtual double GetClippingRangeExpansionMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetClippingRangeExpansionMaxValue_0")] public static extern 
bool GetClippingRangeExpansionMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetClippingRangeExpansion()
// virtual double GetClippingRangeExpansion ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetClippingRangeExpansion_0")] public static extern 
bool GetClippingRangeExpansion_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ResetCamera()
// virtual void ResetCamera()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCamera_0")] public static extern 
bool ResetCamera_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ResetCamera(double bounds[6])
// virtual void ResetCamera(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCamera_1")] public static extern 
bool ResetCamera_1(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double[6])*/ []bounds);

// virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ResetCamera_2")] public static extern 
bool ResetCamera_2(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax);

// void SetRenderWindow(vtkRenderWindow * ARG_0)
// void SetRenderWindow(vtkRenderWindow *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetRenderWindow_0")] public static extern 
bool SetRenderWindow_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkRenderWindow*)*/ ARG_0);

// vtkRenderWindow* GetRenderWindow()
// vtkRenderWindow *GetRenderWindow()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetRenderWindow_0")] public static extern 
bool GetRenderWindow_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// vtkWindow* GetVTKWindow()
// vtkWindow *GetVTKWindow()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetVTKWindow_0")] public static extern 
bool GetVTKWindow_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetBackingStore(int _arg)
// virtual void SetBackingStore (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetBackingStore_0")] public static extern 
bool SetBackingStore_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetBackingStore()
// virtual int GetBackingStore ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetBackingStore_0")] public static extern 
bool GetBackingStore_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void BackingStoreOn()
// virtual void BackingStoreOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_BackingStoreOn_0")] public static extern 
bool BackingStoreOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void BackingStoreOff()
// virtual void BackingStoreOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_BackingStoreOff_0")] public static extern 
bool BackingStoreOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetInteractive(int _arg)
// virtual void SetInteractive (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetInteractive_0")] public static extern 
bool SetInteractive_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetInteractive()
// virtual int GetInteractive ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetInteractive_0")] public static extern 
bool GetInteractive_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void InteractiveOn()
// virtual void InteractiveOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_InteractiveOn_0")] public static extern 
bool InteractiveOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void InteractiveOff()
// virtual void InteractiveOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_InteractiveOff_0")] public static extern 
bool InteractiveOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetLayer(int layer)
// virtual void SetLayer(int layer)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetLayer_0")] public static extern 
bool SetLayer_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ layer);

// virtual int GetLayer()
// virtual int GetLayer ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetLayer_0")] public static extern 
bool GetLayer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int GetPreserveColorBuffer()
// virtual int GetPreserveColorBuffer ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetPreserveColorBuffer_0")] public static extern 
bool GetPreserveColorBuffer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetPreserveColorBuffer(int _arg)
// virtual void SetPreserveColorBuffer (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetPreserveColorBuffer_0")] public static extern 
bool SetPreserveColorBuffer_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual void PreserveColorBufferOn()
// virtual void PreserveColorBufferOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PreserveColorBufferOn_0")] public static extern 
bool PreserveColorBufferOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void PreserveColorBufferOff()
// virtual void PreserveColorBufferOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PreserveColorBufferOff_0")] public static extern 
bool PreserveColorBufferOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetPreserveDepthBuffer(int _arg)
// virtual void SetPreserveDepthBuffer (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetPreserveDepthBuffer_0")] public static extern 
bool SetPreserveDepthBuffer_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPreserveDepthBuffer()
// virtual int GetPreserveDepthBuffer ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetPreserveDepthBuffer_0")] public static extern 
bool GetPreserveDepthBuffer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void PreserveDepthBufferOn()
// virtual void PreserveDepthBufferOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PreserveDepthBufferOn_0")] public static extern 
bool PreserveDepthBufferOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void PreserveDepthBufferOff()
// virtual void PreserveDepthBufferOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PreserveDepthBufferOff_0")] public static extern 
bool PreserveDepthBufferOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// int Transparent()
// int Transparent()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_Transparent_0")] public static extern 
bool Transparent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// void WorldToView()
// void WorldToView()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_WorldToView_0")] public static extern 
bool WorldToView_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// void ViewToWorld()
// void ViewToWorld()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ViewToWorld_0")] public static extern 
bool ViewToWorld_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// void ViewToWorld(double & wx, double & wy, double & wz)
// void ViewToWorld(double &wx, double &wy, double &wz)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ViewToWorld_1")] public static extern 
bool ViewToWorld_1(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz);

// void WorldToView(double & wx, double & wy, double & wz)
// void WorldToView(double &wx, double &wy, double &wz)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_WorldToView_1")] public static extern 
bool WorldToView_1(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz);

// double GetZ(int x, int y)
// double GetZ (int x, int y)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetZ_0")] public static extern 
bool GetZ_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetLastRenderTimeInSeconds()
// virtual double GetLastRenderTimeInSeconds ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetLastRenderTimeInSeconds_0")] public static extern 
bool GetLastRenderTimeInSeconds_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int GetNumberOfPropsRendered()
// virtual int GetNumberOfPropsRendered ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetNumberOfPropsRendered_0")] public static extern 
bool GetNumberOfPropsRendered_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// vtkAssemblyPath* PickProp(double selectionX, double selectionY)
// vtkAssemblyPath* PickProp(double selectionX, double selectionY)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PickProp_0")] public static extern 
bool PickProp_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ selectionX, double /*(double)*/ selectionY);

// vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
// vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_PickProp_1")] public static extern 
bool PickProp_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2);

// virtual void StereoMidpoint()
// virtual void StereoMidpoint()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_StereoMidpoint_0")] public static extern 
bool StereoMidpoint_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// double GetTiledAspectRatio()
// double GetTiledAspectRatio()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetTiledAspectRatio_0")] public static extern 
bool GetTiledAspectRatio_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// int IsActiveCameraCreated()
// int IsActiveCameraCreated()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_IsActiveCameraCreated_0")] public static extern 
bool IsActiveCameraCreated_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetUseDepthPeeling(int _arg)
// virtual void SetUseDepthPeeling (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetUseDepthPeeling_0")] public static extern 
bool SetUseDepthPeeling_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseDepthPeeling()
// virtual int GetUseDepthPeeling ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetUseDepthPeeling_0")] public static extern 
bool GetUseDepthPeeling_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseDepthPeelingOn()
// virtual void UseDepthPeelingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseDepthPeelingOn_0")] public static extern 
bool UseDepthPeelingOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseDepthPeelingOff()
// virtual void UseDepthPeelingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseDepthPeelingOff_0")] public static extern 
bool UseDepthPeelingOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetUseDepthPeelingForVolumes(bool _arg)
// virtual void SetUseDepthPeelingForVolumes (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetUseDepthPeelingForVolumes_0")] public static extern 
bool SetUseDepthPeelingForVolumes_0(IntPtr /*(vtkRenderer*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseDepthPeelingForVolumes()
// virtual bool GetUseDepthPeelingForVolumes ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetUseDepthPeelingForVolumes_0")] public static extern 
bool GetUseDepthPeelingForVolumes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseDepthPeelingForVolumesOn()
// virtual void UseDepthPeelingForVolumesOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseDepthPeelingForVolumesOn_0")] public static extern 
bool UseDepthPeelingForVolumesOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseDepthPeelingForVolumesOff()
// virtual void UseDepthPeelingForVolumesOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseDepthPeelingForVolumesOff_0")] public static extern 
bool UseDepthPeelingForVolumesOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetOcclusionRatio(double _arg)
// virtual void SetOcclusionRatio (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetOcclusionRatio_0")] public static extern 
bool SetOcclusionRatio_0(IntPtr /*(vtkRenderer*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetOcclusionRatioMinValue()
// virtual double GetOcclusionRatioMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetOcclusionRatioMinValue_0")] public static extern 
bool GetOcclusionRatioMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetOcclusionRatioMaxValue()
// virtual double GetOcclusionRatioMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetOcclusionRatioMaxValue_0")] public static extern 
bool GetOcclusionRatioMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual double GetOcclusionRatio()
// virtual double GetOcclusionRatio ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetOcclusionRatio_0")] public static extern 
bool GetOcclusionRatio_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetMaximumNumberOfPeels(int _arg)
// virtual void SetMaximumNumberOfPeels (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetMaximumNumberOfPeels_0")] public static extern 
bool SetMaximumNumberOfPeels_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetMaximumNumberOfPeels()
// virtual int GetMaximumNumberOfPeels ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetMaximumNumberOfPeels_0")] public static extern 
bool GetMaximumNumberOfPeels_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual int GetLastRenderingUsedDepthPeeling()
// virtual int GetLastRenderingUsedDepthPeeling ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetLastRenderingUsedDepthPeeling_0")] public static extern 
bool GetLastRenderingUsedDepthPeeling_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// void SetDelegate(vtkRendererDelegate * d)
// void SetDelegate(vtkRendererDelegate *d)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetDelegate_0")] public static extern 
bool SetDelegate_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkRendererDelegate*)*/ d);

// virtual vtkRendererDelegate* GetDelegate()
// virtual vtkRendererDelegate *GetDelegate ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetDelegate_0")] public static extern 
bool GetDelegate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual vtkHardwareSelector* GetSelector()
// virtual vtkHardwareSelector *GetSelector ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetSelector_0")] public static extern 
bool GetSelector_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetBackgroundTexture(vtkTexture * ARG_0)
// virtual void SetBackgroundTexture(vtkTexture*)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetBackgroundTexture_0")] public static extern 
bool SetBackgroundTexture_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkTexture*)*/ ARG_0);

// virtual vtkTexture* GetBackgroundTexture()
// virtual vtkTexture *GetBackgroundTexture ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetBackgroundTexture_0")] public static extern 
bool GetBackgroundTexture_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetTexturedBackground(bool _arg)
// virtual void SetTexturedBackground (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetTexturedBackground_0")] public static extern 
bool SetTexturedBackground_0(IntPtr /*(vtkRenderer*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetTexturedBackground()
// virtual bool GetTexturedBackground ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetTexturedBackground_0")] public static extern 
bool GetTexturedBackground_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void TexturedBackgroundOn()
// virtual void TexturedBackgroundOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_TexturedBackgroundOn_0")] public static extern 
bool TexturedBackgroundOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void TexturedBackgroundOff()
// virtual void TexturedBackgroundOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_TexturedBackgroundOff_0")] public static extern 
bool TexturedBackgroundOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// virtual void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// virtual void SetUseFXAA(bool _arg)
// virtual void SetUseFXAA (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetUseFXAA_0")] public static extern 
bool SetUseFXAA_0(IntPtr /*(vtkRenderer*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseFXAA()
// virtual bool GetUseFXAA ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetUseFXAA_0")] public static extern 
bool GetUseFXAA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseFXAAOn()
// virtual void UseFXAAOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseFXAAOn_0")] public static extern 
bool UseFXAAOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseFXAAOff()
// virtual void UseFXAAOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseFXAAOff_0")] public static extern 
bool UseFXAAOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual vtkFXAAOptions* GetFXAAOptions()
// virtual vtkFXAAOptions *GetFXAAOptions ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetFXAAOptions_0")] public static extern 
bool GetFXAAOptions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetFXAAOptions(vtkFXAAOptions * ARG_0)
// virtual void SetFXAAOptions(vtkFXAAOptions*)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetFXAAOptions_0")] public static extern 
bool SetFXAAOptions_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkFXAAOptions*)*/ ARG_0);

// virtual void SetUseShadows(int _arg)
// virtual void SetUseShadows (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetUseShadows_0")] public static extern 
bool SetUseShadows_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseShadows()
// virtual int GetUseShadows ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetUseShadows_0")] public static extern 
bool GetUseShadows_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseShadowsOn()
// virtual void UseShadowsOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseShadowsOn_0")] public static extern 
bool UseShadowsOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseShadowsOff()
// virtual void UseShadowsOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseShadowsOff_0")] public static extern 
bool UseShadowsOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void SetUseHiddenLineRemoval(int _arg)
// virtual void SetUseHiddenLineRemoval (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetUseHiddenLineRemoval_0")] public static extern 
bool SetUseHiddenLineRemoval_0(IntPtr /*(vtkRenderer*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseHiddenLineRemoval()
// virtual int GetUseHiddenLineRemoval ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetUseHiddenLineRemoval_0")] public static extern 
bool GetUseHiddenLineRemoval_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseHiddenLineRemovalOn()
// virtual void UseHiddenLineRemovalOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseHiddenLineRemovalOn_0")] public static extern 
bool UseHiddenLineRemovalOn_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// virtual void UseHiddenLineRemovalOff()
// virtual void UseHiddenLineRemovalOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_UseHiddenLineRemovalOff_0")] public static extern 
bool UseHiddenLineRemovalOff_0(IntPtr /*(vtkRenderer*)*/ callingObject);

// void SetPass(vtkRenderPass * p)
// void SetPass(vtkRenderPass *p)
[DllImport("vtkplugin", EntryPoint="vtkRenderer_SetPass_0")] public static extern 
bool SetPass_0(IntPtr /*(vtkRenderer*)*/ callingObject, IntPtr /*(vtkRenderPass*)*/ p);

// virtual vtkRenderPass* GetPass()
// virtual vtkRenderPass *GetPass ()
[DllImport("vtkplugin", EntryPoint="vtkRenderer_GetPass_0")] public static extern 
bool GetPass_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderer*)*/ callingObject);

}
};
