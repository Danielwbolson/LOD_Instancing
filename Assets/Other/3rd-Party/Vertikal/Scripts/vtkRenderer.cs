

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderer : vtkViewport {
		public vtkRenderer(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderer(IntPtr p) {return new vtkRenderer(p);}
		public static implicit operator  IntPtr(vtkRenderer o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderer.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderer.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkRenderer* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderer* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderer SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkRenderer)(IntPtr)returnPointer;
}


// vtkRenderer* NewInstance()
// "vtkRenderer *NewInstance()"
public vtkRenderer NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkRenderer)(IntPtr)returnPointer;
}


// static vtkRenderer* New()
// "static vtkRenderer *New()"
public static vtkRenderer New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.New_0(returnPointer.GetPtr());
	return (vtkRenderer)(IntPtr)returnPointer;
}


// void AddActor(vtkProp * p)
// "void AddActor(vtkProp *p)"
public void AddActor(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.AddActor_0(this, p);
}


// void AddVolume(vtkProp * p)
// "void AddVolume(vtkProp *p)"
public void AddVolume(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.AddVolume_0(this, p);
}


// void RemoveActor(vtkProp * p)
// "void RemoveActor(vtkProp *p)"
public void RemoveActor(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.RemoveActor_0(this, p);
}


// void RemoveVolume(vtkProp * p)
// "void RemoveVolume(vtkProp *p)"
public void RemoveVolume(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.RemoveVolume_0(this, p);
}


// void AddLight(vtkLight * ARG_0)
// "void AddLight(vtkLight *)"
public void AddLight(vtkLight /*(vtkLight*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.AddLight_0(this, ARG_0);
}


// void RemoveLight(vtkLight * ARG_0)
// "void RemoveLight(vtkLight *)"
public void RemoveLight(vtkLight /*(vtkLight*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.RemoveLight_0(this, ARG_0);
}


// void RemoveAllLights()
// "void RemoveAllLights()"
public void RemoveAllLights() {
	VTK_API.API_vtkRenderer.RemoveAllLights_0(this);
}


// vtkLightCollection* GetLights()
// "vtkLightCollection *GetLights()"
public vtkLightCollection GetLights() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetLights_0(returnPointer.GetPtr(), this);
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// void SetLightCollection(vtkLightCollection * lights)
// "void SetLightCollection(vtkLightCollection *lights)"
public void SetLightCollection(vtkLightCollection /*(vtkLightCollection*)*/ lights) {
	VTK_API.API_vtkRenderer.SetLightCollection_0(this, lights);
}


// void CreateLight()
// "void CreateLight(void)"
public void CreateLight() {
	VTK_API.API_vtkRenderer.CreateLight_0(this);
}


// virtual vtkLight* MakeLight()
// "virtual vtkLight *MakeLight()"
public vtkLight MakeLight() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.MakeLight_0(returnPointer.GetPtr(), this);
	return (vtkLight)(IntPtr)returnPointer;
}


// virtual int GetTwoSidedLighting()
// "virtual int GetTwoSidedLighting ()"
public int GetTwoSidedLighting() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetTwoSidedLighting_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetTwoSidedLighting(int _arg)
// "virtual void SetTwoSidedLighting (int _arg)"
public void SetTwoSidedLighting(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetTwoSidedLighting_0(this, _arg);
}


// virtual void TwoSidedLightingOn()
// "virtual void TwoSidedLightingOn ()"
public void TwoSidedLightingOn() {
	VTK_API.API_vtkRenderer.TwoSidedLightingOn_0(this);
}


// virtual void TwoSidedLightingOff()
// "virtual void TwoSidedLightingOff ()"
public void TwoSidedLightingOff() {
	VTK_API.API_vtkRenderer.TwoSidedLightingOff_0(this);
}


// virtual void SetLightFollowCamera(int _arg)
// "virtual void SetLightFollowCamera (int _arg)"
public void SetLightFollowCamera(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetLightFollowCamera_0(this, _arg);
}


// virtual int GetLightFollowCamera()
// "virtual int GetLightFollowCamera ()"
public int GetLightFollowCamera() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetLightFollowCamera_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void LightFollowCameraOn()
// "virtual void LightFollowCameraOn ()"
public void LightFollowCameraOn() {
	VTK_API.API_vtkRenderer.LightFollowCameraOn_0(this);
}


// virtual void LightFollowCameraOff()
// "virtual void LightFollowCameraOff ()"
public void LightFollowCameraOff() {
	VTK_API.API_vtkRenderer.LightFollowCameraOff_0(this);
}


// virtual int GetAutomaticLightCreation()
// "virtual int GetAutomaticLightCreation ()"
public int GetAutomaticLightCreation() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetAutomaticLightCreation_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetAutomaticLightCreation(int _arg)
// "virtual void SetAutomaticLightCreation (int _arg)"
public void SetAutomaticLightCreation(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetAutomaticLightCreation_0(this, _arg);
}


// virtual void AutomaticLightCreationOn()
// "virtual void AutomaticLightCreationOn ()"
public void AutomaticLightCreationOn() {
	VTK_API.API_vtkRenderer.AutomaticLightCreationOn_0(this);
}


// virtual void AutomaticLightCreationOff()
// "virtual void AutomaticLightCreationOff ()"
public void AutomaticLightCreationOff() {
	VTK_API.API_vtkRenderer.AutomaticLightCreationOff_0(this);
}


// virtual int UpdateLightsGeometryToFollowCamera()
// "virtual int UpdateLightsGeometryToFollowCamera(void)"
public int UpdateLightsGeometryToFollowCamera() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.UpdateLightsGeometryToFollowCamera_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkVolumeCollection* GetVolumes()
// "vtkVolumeCollection *GetVolumes()"
public vtkVolumeCollection GetVolumes() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetVolumes_0(returnPointer.GetPtr(), this);
	return (vtkVolumeCollection)(IntPtr)returnPointer;
}


// vtkActorCollection* GetActors()
// "vtkActorCollection *GetActors()"
public vtkActorCollection GetActors() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetActors_0(returnPointer.GetPtr(), this);
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// void SetActiveCamera(vtkCamera * ARG_0)
// "void SetActiveCamera(vtkCamera *)"
public void SetActiveCamera(vtkCamera /*(vtkCamera*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetActiveCamera_0(this, ARG_0);
}


// vtkCamera* GetActiveCamera()
// "vtkCamera *GetActiveCamera()"
public vtkCamera GetActiveCamera() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetActiveCamera_0(returnPointer.GetPtr(), this);
	return (vtkCamera)(IntPtr)returnPointer;
}


// virtual vtkCamera* MakeCamera()
// "virtual vtkCamera *MakeCamera()"
public vtkCamera MakeCamera() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.MakeCamera_0(returnPointer.GetPtr(), this);
	return (vtkCamera)(IntPtr)returnPointer;
}


// virtual void SetErase(int _arg)
// "virtual void SetErase (int _arg)"
public void SetErase(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetErase_0(this, _arg);
}


// virtual int GetErase()
// "virtual int GetErase ()"
public int GetErase() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetErase_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void EraseOn()
// "virtual void EraseOn ()"
public void EraseOn() {
	VTK_API.API_vtkRenderer.EraseOn_0(this);
}


// virtual void EraseOff()
// "virtual void EraseOff ()"
public void EraseOff() {
	VTK_API.API_vtkRenderer.EraseOff_0(this);
}


// virtual void SetDraw(int _arg)
// "virtual void SetDraw (int _arg)"
public void SetDraw(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetDraw_0(this, _arg);
}


// virtual int GetDraw()
// "virtual int GetDraw ()"
public int GetDraw() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetDraw_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void DrawOn()
// "virtual void DrawOn ()"
public void DrawOn() {
	VTK_API.API_vtkRenderer.DrawOn_0(this);
}


// virtual void DrawOff()
// "virtual void DrawOff ()"
public void DrawOff() {
	VTK_API.API_vtkRenderer.DrawOff_0(this);
}


// int CaptureGL2PSSpecialProp(vtkProp * ARG_0)
// "int CaptureGL2PSSpecialProp(vtkProp *)"
public int CaptureGL2PSSpecialProp(vtkProp /*(vtkProp*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.CaptureGL2PSSpecialProp_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// void SetGL2PSSpecialPropCollection(vtkPropCollection * ARG_0)
// "void SetGL2PSSpecialPropCollection(vtkPropCollection *)"
public void SetGL2PSSpecialPropCollection(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetGL2PSSpecialPropCollection_0(this, ARG_0);
}


// void AddCuller(vtkCuller * ARG_0)
// "void AddCuller(vtkCuller *)"
public void AddCuller(vtkCuller /*(vtkCuller*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.AddCuller_0(this, ARG_0);
}


// void RemoveCuller(vtkCuller * ARG_0)
// "void RemoveCuller(vtkCuller *)"
public void RemoveCuller(vtkCuller /*(vtkCuller*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.RemoveCuller_0(this, ARG_0);
}


// vtkCullerCollection* GetCullers()
// "vtkCullerCollection *GetCullers()"
public vtkCullerCollection GetCullers() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetCullers_0(returnPointer.GetPtr(), this);
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
// "virtual void SetAmbient (double _arg1, double _arg2, double _arg3)"
public void SetAmbient(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkRenderer.SetAmbient_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAmbient(double _arg[3])
// "virtual void SetAmbient (double _arg[3])"
public void SetAmbient(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkRenderer.SetAmbient_1(this, _arg);
}


// virtual double* GetAmbient()
// "virtual double *GetAmbient ()"
public IntPtr GetAmbient() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetAmbient_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAmbient(double data[3])
// "virtual void GetAmbient (double data[3])"
public void GetAmbient(double /*(double[3])*/ []data) {
	VTK_API.API_vtkRenderer.GetAmbient_1(this, data);
}


// virtual void SetAllocatedRenderTime(double _arg)
// "virtual void SetAllocatedRenderTime (double _arg)"
public void SetAllocatedRenderTime(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetAllocatedRenderTime_0(this, _arg);
}


// virtual double GetAllocatedRenderTime()
// "virtual double GetAllocatedRenderTime()"
public double GetAllocatedRenderTime() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetAllocatedRenderTime_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetTimeFactor()
// "virtual double GetTimeFactor()"
public double GetTimeFactor() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetTimeFactor_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void Render()
// "virtual void Render()"
public void Render() {
	VTK_API.API_vtkRenderer.Render_0(this);
}


// virtual void DeviceRender()
// "virtual void DeviceRender()"
public void DeviceRender() {
	VTK_API.API_vtkRenderer.DeviceRender_0(this);
}


// virtual void DeviceRenderOpaqueGeometry()
// "virtual void DeviceRenderOpaqueGeometry()"
public void DeviceRenderOpaqueGeometry() {
	VTK_API.API_vtkRenderer.DeviceRenderOpaqueGeometry_0(this);
}


// virtual void DeviceRenderTranslucentPolygonalGeometry()
// "virtual void DeviceRenderTranslucentPolygonalGeometry()"
public void DeviceRenderTranslucentPolygonalGeometry() {
	VTK_API.API_vtkRenderer.DeviceRenderTranslucentPolygonalGeometry_0(this);
}


// virtual void ClearLights()
// "virtual void ClearLights(void)"
public void ClearLights() {
	VTK_API.API_vtkRenderer.ClearLights_0(this);
}


// virtual void Clear()
// "virtual void Clear()"
public void Clear() {
	VTK_API.API_vtkRenderer.Clear_0(this);
}


// int VisibleActorCount()
// "int VisibleActorCount()"
public int VisibleActorCount() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.VisibleActorCount_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int VisibleVolumeCount()
// "int VisibleVolumeCount()"
public int VisibleVolumeCount() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.VisibleVolumeCount_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void ComputeVisiblePropBounds(double bounds[6])
// "void ComputeVisiblePropBounds( double bounds[6] )"
public void ComputeVisiblePropBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ComputeVisiblePropBounds_0(this, bounds);
}


// double* ComputeVisiblePropBounds()
// "double *ComputeVisiblePropBounds()"
public IntPtr ComputeVisiblePropBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.ComputeVisiblePropBounds_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void ResetCameraClippingRange()
// "virtual void ResetCameraClippingRange()"
public void ResetCameraClippingRange() {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_0(this);
}


// virtual void ResetCameraClippingRange(double bounds[6])
// "virtual void ResetCameraClippingRange( double bounds[6] )"
public void ResetCameraClippingRange(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_1(this, bounds);
}


// virtual void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// "virtual void ResetCameraClippingRange( double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)"
public void ResetCameraClippingRange(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax) {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_2(this, xmin, xmax, ymin, ymax, zmin, zmax);
}


// virtual void SetNearClippingPlaneTolerance(double _arg)
// "virtual void SetNearClippingPlaneTolerance (double _arg)"
public void SetNearClippingPlaneTolerance(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetNearClippingPlaneTolerance_0(this, _arg);
}


// virtual double GetNearClippingPlaneToleranceMinValue()
// "virtual double GetNearClippingPlaneToleranceMinValue ()"
public double GetNearClippingPlaneToleranceMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetNearClippingPlaneToleranceMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetNearClippingPlaneToleranceMaxValue()
// "virtual double GetNearClippingPlaneToleranceMaxValue ()"
public double GetNearClippingPlaneToleranceMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetNearClippingPlaneToleranceMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetNearClippingPlaneTolerance()
// "virtual double GetNearClippingPlaneTolerance ()"
public double GetNearClippingPlaneTolerance() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetNearClippingPlaneTolerance_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetClippingRangeExpansion(double _arg)
// "virtual void SetClippingRangeExpansion (double _arg)"
public void SetClippingRangeExpansion(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetClippingRangeExpansion_0(this, _arg);
}


// virtual double GetClippingRangeExpansionMinValue()
// "virtual double GetClippingRangeExpansionMinValue ()"
public double GetClippingRangeExpansionMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetClippingRangeExpansionMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetClippingRangeExpansionMaxValue()
// "virtual double GetClippingRangeExpansionMaxValue ()"
public double GetClippingRangeExpansionMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetClippingRangeExpansionMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetClippingRangeExpansion()
// "virtual double GetClippingRangeExpansion ()"
public double GetClippingRangeExpansion() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetClippingRangeExpansion_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void ResetCamera()
// "virtual void ResetCamera()"
public void ResetCamera() {
	VTK_API.API_vtkRenderer.ResetCamera_0(this);
}


// virtual void ResetCamera(double bounds[6])
// "virtual void ResetCamera(double bounds[6])"
public void ResetCamera(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ResetCamera_1(this, bounds);
}


// virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// "virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)"
public void ResetCamera(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax) {
	VTK_API.API_vtkRenderer.ResetCamera_2(this, xmin, xmax, ymin, ymax, zmin, zmax);
}


// void SetRenderWindow(vtkRenderWindow * ARG_0)
// "void SetRenderWindow(vtkRenderWindow *)"
public void SetRenderWindow(vtkRenderWindow /*(vtkRenderWindow*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetRenderWindow_0(this, ARG_0);
}


// vtkRenderWindow* GetRenderWindow()
// "vtkRenderWindow *GetRenderWindow()"
public vtkRenderWindow GetRenderWindow() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetRenderWindow_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// vtkWindow* GetVTKWindow()
// "vtkWindow *GetVTKWindow()"
public vtkWindow GetVTKWindow() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetVTKWindow_0(returnPointer.GetPtr(), this);
	return (vtkWindow)(IntPtr)returnPointer;
}


// virtual void SetBackingStore(int _arg)
// "virtual void SetBackingStore (int _arg)"
public void SetBackingStore(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetBackingStore_0(this, _arg);
}


// virtual int GetBackingStore()
// "virtual int GetBackingStore ()"
public int GetBackingStore() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetBackingStore_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void BackingStoreOn()
// "virtual void BackingStoreOn ()"
public void BackingStoreOn() {
	VTK_API.API_vtkRenderer.BackingStoreOn_0(this);
}


// virtual void BackingStoreOff()
// "virtual void BackingStoreOff ()"
public void BackingStoreOff() {
	VTK_API.API_vtkRenderer.BackingStoreOff_0(this);
}


// virtual void SetInteractive(int _arg)
// "virtual void SetInteractive (int _arg)"
public void SetInteractive(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetInteractive_0(this, _arg);
}


// virtual int GetInteractive()
// "virtual int GetInteractive ()"
public int GetInteractive() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetInteractive_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void InteractiveOn()
// "virtual void InteractiveOn ()"
public void InteractiveOn() {
	VTK_API.API_vtkRenderer.InteractiveOn_0(this);
}


// virtual void InteractiveOff()
// "virtual void InteractiveOff ()"
public void InteractiveOff() {
	VTK_API.API_vtkRenderer.InteractiveOff_0(this);
}


// virtual void SetLayer(int layer)
// "virtual void SetLayer(int layer)"
public void SetLayer(int /*(int)*/ layer) {
	VTK_API.API_vtkRenderer.SetLayer_0(this, layer);
}


// virtual int GetLayer()
// "virtual int GetLayer ()"
public int GetLayer() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetLayer_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetPreserveColorBuffer()
// "virtual int GetPreserveColorBuffer ()"
public int GetPreserveColorBuffer() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetPreserveColorBuffer_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetPreserveColorBuffer(int _arg)
// "virtual void SetPreserveColorBuffer (int _arg)"
public void SetPreserveColorBuffer(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetPreserveColorBuffer_0(this, _arg);
}


// virtual void PreserveColorBufferOn()
// "virtual void PreserveColorBufferOn ()"
public void PreserveColorBufferOn() {
	VTK_API.API_vtkRenderer.PreserveColorBufferOn_0(this);
}


// virtual void PreserveColorBufferOff()
// "virtual void PreserveColorBufferOff ()"
public void PreserveColorBufferOff() {
	VTK_API.API_vtkRenderer.PreserveColorBufferOff_0(this);
}


// virtual void SetPreserveDepthBuffer(int _arg)
// "virtual void SetPreserveDepthBuffer (int _arg)"
public void SetPreserveDepthBuffer(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetPreserveDepthBuffer_0(this, _arg);
}


// virtual int GetPreserveDepthBuffer()
// "virtual int GetPreserveDepthBuffer ()"
public int GetPreserveDepthBuffer() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetPreserveDepthBuffer_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PreserveDepthBufferOn()
// "virtual void PreserveDepthBufferOn ()"
public void PreserveDepthBufferOn() {
	VTK_API.API_vtkRenderer.PreserveDepthBufferOn_0(this);
}


// virtual void PreserveDepthBufferOff()
// "virtual void PreserveDepthBufferOff ()"
public void PreserveDepthBufferOff() {
	VTK_API.API_vtkRenderer.PreserveDepthBufferOff_0(this);
}


// int Transparent()
// "int Transparent()"
public int Transparent() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.Transparent_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void WorldToView()
// "void WorldToView()"
public void WorldToView() {
	VTK_API.API_vtkRenderer.WorldToView_0(this);
}


// void ViewToWorld()
// "void ViewToWorld()"
public void ViewToWorld() {
	VTK_API.API_vtkRenderer.ViewToWorld_0(this);
}


// void ViewToWorld(double & wx, double & wy, double & wz)
// "void ViewToWorld(double &wx, double &wy, double &wz)"
public void ViewToWorld(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.ViewToWorld_1(this, wx, wy, wz);
}


// void WorldToView(double & wx, double & wy, double & wz)
// "void WorldToView(double &wx, double &wy, double &wz)"
public void WorldToView(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.WorldToView_1(this, wx, wy, wz);
}


// double GetZ(int x, int y)
// "double GetZ (int x, int y)"
public double GetZ(int /*(int)*/ x, int /*(int)*/ y) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetZ_0(returnPointer.GetPtr(), this, x, y);
	return (double)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkRenderer.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual double GetLastRenderTimeInSeconds()
// "virtual double GetLastRenderTimeInSeconds ()"
public double GetLastRenderTimeInSeconds() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetLastRenderTimeInSeconds_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual int GetNumberOfPropsRendered()
// "virtual int GetNumberOfPropsRendered ()"
public int GetNumberOfPropsRendered() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetNumberOfPropsRendered_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkAssemblyPath* PickProp(double selectionX, double selectionY)
// "vtkAssemblyPath* PickProp(double selectionX, double selectionY)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX, double /*(double)*/ selectionY) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.PickProp_0(returnPointer.GetPtr(), this, selectionX, selectionY);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
// "vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.PickProp_1(returnPointer.GetPtr(), this, selectionX1, selectionY1, selectionX2, selectionY2);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual void StereoMidpoint()
// "virtual void StereoMidpoint()"
public void StereoMidpoint() {
	VTK_API.API_vtkRenderer.StereoMidpoint_0(this);
}


// double GetTiledAspectRatio()
// "double GetTiledAspectRatio()"
public double GetTiledAspectRatio() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetTiledAspectRatio_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// int IsActiveCameraCreated()
// "int IsActiveCameraCreated()"
public int IsActiveCameraCreated() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.IsActiveCameraCreated_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetUseDepthPeeling(int _arg)
// "virtual void SetUseDepthPeeling (int _arg)"
public void SetUseDepthPeeling(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseDepthPeeling_0(this, _arg);
}


// virtual int GetUseDepthPeeling()
// "virtual int GetUseDepthPeeling ()"
public int GetUseDepthPeeling() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetUseDepthPeeling_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseDepthPeelingOn()
// "virtual void UseDepthPeelingOn ()"
public void UseDepthPeelingOn() {
	VTK_API.API_vtkRenderer.UseDepthPeelingOn_0(this);
}


// virtual void UseDepthPeelingOff()
// "virtual void UseDepthPeelingOff ()"
public void UseDepthPeelingOff() {
	VTK_API.API_vtkRenderer.UseDepthPeelingOff_0(this);
}


// virtual void SetUseDepthPeelingForVolumes(bool _arg)
// "virtual void SetUseDepthPeelingForVolumes (bool _arg)"
public void SetUseDepthPeelingForVolumes(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseDepthPeelingForVolumes_0(this, _arg);
}


// virtual bool GetUseDepthPeelingForVolumes()
// "virtual bool GetUseDepthPeelingForVolumes ()"
public bool GetUseDepthPeelingForVolumes() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderer.GetUseDepthPeelingForVolumes_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void UseDepthPeelingForVolumesOn()
// "virtual void UseDepthPeelingForVolumesOn ()"
public void UseDepthPeelingForVolumesOn() {
	VTK_API.API_vtkRenderer.UseDepthPeelingForVolumesOn_0(this);
}


// virtual void UseDepthPeelingForVolumesOff()
// "virtual void UseDepthPeelingForVolumesOff ()"
public void UseDepthPeelingForVolumesOff() {
	VTK_API.API_vtkRenderer.UseDepthPeelingForVolumesOff_0(this);
}


// virtual void SetOcclusionRatio(double _arg)
// "virtual void SetOcclusionRatio (double _arg)"
public void SetOcclusionRatio(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetOcclusionRatio_0(this, _arg);
}


// virtual double GetOcclusionRatioMinValue()
// "virtual double GetOcclusionRatioMinValue ()"
public double GetOcclusionRatioMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetOcclusionRatioMinValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetOcclusionRatioMaxValue()
// "virtual double GetOcclusionRatioMaxValue ()"
public double GetOcclusionRatioMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetOcclusionRatioMaxValue_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual double GetOcclusionRatio()
// "virtual double GetOcclusionRatio ()"
public double GetOcclusionRatio() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderer.GetOcclusionRatio_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetMaximumNumberOfPeels(int _arg)
// "virtual void SetMaximumNumberOfPeels (int _arg)"
public void SetMaximumNumberOfPeels(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetMaximumNumberOfPeels_0(this, _arg);
}


// virtual int GetMaximumNumberOfPeels()
// "virtual int GetMaximumNumberOfPeels ()"
public int GetMaximumNumberOfPeels() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetMaximumNumberOfPeels_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetLastRenderingUsedDepthPeeling()
// "virtual int GetLastRenderingUsedDepthPeeling ()"
public int GetLastRenderingUsedDepthPeeling() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetLastRenderingUsedDepthPeeling_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetDelegate(vtkRendererDelegate * d)
// "void SetDelegate(vtkRendererDelegate *d)"
public void SetDelegate(vtkRendererDelegate /*(vtkRendererDelegate*)*/ d) {
	VTK_API.API_vtkRenderer.SetDelegate_0(this, d);
}


// virtual vtkRendererDelegate* GetDelegate()
// "virtual vtkRendererDelegate *GetDelegate ()"
public vtkRendererDelegate GetDelegate() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetDelegate_0(returnPointer.GetPtr(), this);
	return (vtkRendererDelegate)(IntPtr)returnPointer;
}


// virtual vtkHardwareSelector* GetSelector()
// "virtual vtkHardwareSelector *GetSelector ()"
public vtkHardwareSelector GetSelector() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetSelector_0(returnPointer.GetPtr(), this);
	return (vtkHardwareSelector)(IntPtr)returnPointer;
}


// virtual void SetBackgroundTexture(vtkTexture * ARG_0)
// "virtual void SetBackgroundTexture(vtkTexture*)"
public void SetBackgroundTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetBackgroundTexture_0(this, ARG_0);
}


// virtual vtkTexture* GetBackgroundTexture()
// "virtual vtkTexture *GetBackgroundTexture ()"
public vtkTexture GetBackgroundTexture() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetBackgroundTexture_0(returnPointer.GetPtr(), this);
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetTexturedBackground(bool _arg)
// "virtual void SetTexturedBackground (bool _arg)"
public void SetTexturedBackground(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetTexturedBackground_0(this, _arg);
}


// virtual bool GetTexturedBackground()
// "virtual bool GetTexturedBackground ()"
public bool GetTexturedBackground() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderer.GetTexturedBackground_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void TexturedBackgroundOn()
// "virtual void TexturedBackgroundOn ()"
public void TexturedBackgroundOn() {
	VTK_API.API_vtkRenderer.TexturedBackgroundOn_0(this);
}


// virtual void TexturedBackgroundOff()
// "virtual void TexturedBackgroundOff ()"
public void TexturedBackgroundOff() {
	VTK_API.API_vtkRenderer.TexturedBackgroundOff_0(this);
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual void SetUseFXAA(bool _arg)
// "virtual void SetUseFXAA (bool _arg)"
public void SetUseFXAA(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseFXAA_0(this, _arg);
}


// virtual bool GetUseFXAA()
// "virtual bool GetUseFXAA ()"
public bool GetUseFXAA() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderer.GetUseFXAA_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void UseFXAAOn()
// "virtual void UseFXAAOn ()"
public void UseFXAAOn() {
	VTK_API.API_vtkRenderer.UseFXAAOn_0(this);
}


// virtual void UseFXAAOff()
// "virtual void UseFXAAOff ()"
public void UseFXAAOff() {
	VTK_API.API_vtkRenderer.UseFXAAOff_0(this);
}


// virtual vtkFXAAOptions* GetFXAAOptions()
// "virtual vtkFXAAOptions *GetFXAAOptions ()"
public vtkFXAAOptions GetFXAAOptions() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetFXAAOptions_0(returnPointer.GetPtr(), this);
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// virtual void SetFXAAOptions(vtkFXAAOptions * ARG_0)
// "virtual void SetFXAAOptions(vtkFXAAOptions*)"
public void SetFXAAOptions(vtkFXAAOptions /*(vtkFXAAOptions*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetFXAAOptions_0(this, ARG_0);
}


// virtual void SetUseShadows(int _arg)
// "virtual void SetUseShadows (int _arg)"
public void SetUseShadows(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseShadows_0(this, _arg);
}


// virtual int GetUseShadows()
// "virtual int GetUseShadows ()"
public int GetUseShadows() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetUseShadows_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseShadowsOn()
// "virtual void UseShadowsOn ()"
public void UseShadowsOn() {
	VTK_API.API_vtkRenderer.UseShadowsOn_0(this);
}


// virtual void UseShadowsOff()
// "virtual void UseShadowsOff ()"
public void UseShadowsOff() {
	VTK_API.API_vtkRenderer.UseShadowsOff_0(this);
}


// virtual void SetUseHiddenLineRemoval(int _arg)
// "virtual void SetUseHiddenLineRemoval (int _arg)"
public void SetUseHiddenLineRemoval(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseHiddenLineRemoval_0(this, _arg);
}


// virtual int GetUseHiddenLineRemoval()
// "virtual int GetUseHiddenLineRemoval ()"
public int GetUseHiddenLineRemoval() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderer.GetUseHiddenLineRemoval_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void UseHiddenLineRemovalOn()
// "virtual void UseHiddenLineRemovalOn ()"
public void UseHiddenLineRemovalOn() {
	VTK_API.API_vtkRenderer.UseHiddenLineRemovalOn_0(this);
}


// virtual void UseHiddenLineRemovalOff()
// "virtual void UseHiddenLineRemovalOff ()"
public void UseHiddenLineRemovalOff() {
	VTK_API.API_vtkRenderer.UseHiddenLineRemovalOff_0(this);
}


// void SetPass(vtkRenderPass * p)
// "void SetPass(vtkRenderPass *p)"
public void SetPass(vtkRenderPass /*(vtkRenderPass*)*/ p) {
	VTK_API.API_vtkRenderer.SetPass_0(this, p);
}


// virtual vtkRenderPass* GetPass()
// "virtual vtkRenderPass *GetPass ()"
public vtkRenderPass GetPass() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetPass_0(returnPointer.GetPtr(), this);
	return (vtkRenderPass)(IntPtr)returnPointer;
}


// virtual vtkInformation* GetInformation()
// "virtual vtkInformation *GetInformation ()"
public vtkInformation GetInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderer.GetInformation_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual void SetInformation(vtkInformation * ARG_0)
// "virtual void SetInformation(vtkInformation*)"
public void SetInformation(vtkInformation /*(vtkInformation*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetInformation_0(this, ARG_0);
}


}
};
