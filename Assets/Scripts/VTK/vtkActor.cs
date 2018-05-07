

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActor : vtkProp3D {
		public vtkActor(IntPtr p) : base(p) {}
		public static implicit operator  vtkActor(IntPtr p) {return new vtkActor(p);}
		public static implicit operator  IntPtr(vtkActor o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkActor* SafeDownCast(vtkObjectBase * o)
// "static vtkActor* SafeDownCast(vtkObjectBase *o)"
public static vtkActor SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* NewInstance()
// "vtkActor *NewInstance()"
public vtkActor NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkActor)(IntPtr)returnPointer;
}


// static vtkActor* New()
// "static vtkActor *New()"
public static vtkActor New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.New_0(returnPointer.GetPtr());
	return (vtkActor)(IntPtr)returnPointer;
}


// void GetActors(vtkPropCollection * ARG_0)
// "void GetActors(vtkPropCollection *)"
public void GetActors(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkActor.GetActors_0(this, ARG_0);
}


// int RenderOpaqueGeometry(vtkViewport * viewport)
// "int RenderOpaqueGeometry(vtkViewport *viewport)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor.RenderOpaqueGeometry_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// int RenderTranslucentPolygonalGeometry(vtkViewport * viewport)
// "int RenderTranslucentPolygonalGeometry(vtkViewport *viewport)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ viewport) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor.RenderTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this, viewport);
	return (int)returnPointer;
}


// int HasTranslucentPolygonalGeometry()
// "int HasTranslucentPolygonalGeometry()"
public int HasTranslucentPolygonalGeometry() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkActor.HasTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void Render(vtkRenderer * ARG_0, vtkMapper * ARG_1)
// "virtual void Render(vtkRenderer *, vtkMapper *)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ARG_0, vtkMapper /*(vtkMapper*)*/ ARG_1) {
	VTK_API.API_vtkActor.Render_0(this, ARG_0, ARG_1);
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkActor.ShallowCopy_0(this, prop);
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkActor.ReleaseGraphicsResources_0(this, ARG_0);
}


// void SetProperty(vtkProperty * lut)
// "void SetProperty(vtkProperty *lut)"
public void SetProperty(vtkProperty /*(vtkProperty*)*/ lut) {
	VTK_API.API_vtkActor.SetProperty_0(this, lut);
}


// vtkProperty* GetProperty()
// "vtkProperty *GetProperty()"
public vtkProperty GetProperty() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.GetProperty_0(returnPointer.GetPtr(), this);
	return (vtkProperty)(IntPtr)returnPointer;
}


// virtual vtkProperty* MakeProperty()
// "virtual vtkProperty* MakeProperty()"
public vtkProperty MakeProperty() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.MakeProperty_0(returnPointer.GetPtr(), this);
	return (vtkProperty)(IntPtr)returnPointer;
}


// void SetBackfaceProperty(vtkProperty * lut)
// "void SetBackfaceProperty(vtkProperty *lut)"
public void SetBackfaceProperty(vtkProperty /*(vtkProperty*)*/ lut) {
	VTK_API.API_vtkActor.SetBackfaceProperty_0(this, lut);
}


// virtual vtkProperty* GetBackfaceProperty()
// "virtual vtkProperty *GetBackfaceProperty ()"
public vtkProperty GetBackfaceProperty() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.GetBackfaceProperty_0(returnPointer.GetPtr(), this);
	return (vtkProperty)(IntPtr)returnPointer;
}


// virtual void SetTexture(vtkTexture * ARG_0)
// "virtual void SetTexture(vtkTexture*)"
public void SetTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkActor.SetTexture_0(this, ARG_0);
}


// virtual vtkTexture* GetTexture()
// "virtual vtkTexture *GetTexture ()"
public vtkTexture GetTexture() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.GetTexture_0(returnPointer.GetPtr(), this);
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetMapper(vtkMapper * ARG_0)
// "virtual void SetMapper(vtkMapper *)"
public void SetMapper(vtkMapper /*(vtkMapper*)*/ ARG_0) {
	VTK_API.API_vtkActor.SetMapper_0(this, ARG_0);
}


// virtual vtkMapper* GetMapper()
// "virtual vtkMapper *GetMapper ()"
public vtkMapper GetMapper() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.GetMapper_0(returnPointer.GetPtr(), this);
	return (vtkMapper)(IntPtr)returnPointer;
}


// double* GetBounds()
// "double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkActor.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void ApplyProperties()
// "virtual void ApplyProperties()"
public void ApplyProperties() {
	VTK_API.API_vtkActor.ApplyProperties_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkActor.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkMTimeType GetRedrawMTime()
// "vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkActor.GetRedrawMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual bool GetForceOpaque()
// "virtual bool GetForceOpaque ()"
public bool GetForceOpaque() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor.GetForceOpaque_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetForceOpaque(bool _arg)
// "virtual void SetForceOpaque (bool _arg)"
public void SetForceOpaque(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkActor.SetForceOpaque_0(this, _arg);
}


// virtual void ForceOpaqueOn()
// "virtual void ForceOpaqueOn ()"
public void ForceOpaqueOn() {
	VTK_API.API_vtkActor.ForceOpaqueOn_0(this);
}


// virtual void ForceOpaqueOff()
// "virtual void ForceOpaqueOff ()"
public void ForceOpaqueOff() {
	VTK_API.API_vtkActor.ForceOpaqueOff_0(this);
}


// virtual bool GetForceTranslucent()
// "virtual bool GetForceTranslucent ()"
public bool GetForceTranslucent() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor.GetForceTranslucent_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetForceTranslucent(bool _arg)
// "virtual void SetForceTranslucent (bool _arg)"
public void SetForceTranslucent(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkActor.SetForceTranslucent_0(this, _arg);
}


// virtual void ForceTranslucentOn()
// "virtual void ForceTranslucentOn ()"
public void ForceTranslucentOn() {
	VTK_API.API_vtkActor.ForceTranslucentOn_0(this);
}


// virtual void ForceTranslucentOff()
// "virtual void ForceTranslucentOff ()"
public void ForceTranslucentOff() {
	VTK_API.API_vtkActor.ForceTranslucentOff_0(this);
}


// bool GetSupportsSelection()
// "bool GetSupportsSelection()"
public bool GetSupportsSelection() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkActor.GetSupportsSelection_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


}
};
