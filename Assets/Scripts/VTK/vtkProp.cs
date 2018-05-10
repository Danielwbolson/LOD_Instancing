

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProp : vtkObject {
		public vtkProp(IntPtr p) : base(p) {}
		public static implicit operator  vtkProp(IntPtr p) {return new vtkProp(p);}
		public static implicit operator  IntPtr(vtkProp o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProp* SafeDownCast(vtkObjectBase * o)
// "static vtkProp* SafeDownCast(vtkObjectBase *o)"
public static vtkProp SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProp)(IntPtr)returnPointer;
}


// vtkProp* NewInstance()
// "vtkProp *NewInstance()"
public vtkProp NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProp)(IntPtr)returnPointer;
}


// virtual void GetActors(vtkPropCollection * ARG_0)
// "virtual void GetActors(vtkPropCollection *)"
public void GetActors(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetActors_0(this, ARG_0);
}


// virtual void GetActors2D(vtkPropCollection * ARG_0)
// "virtual void GetActors2D(vtkPropCollection *)"
public void GetActors2D(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetActors2D_0(this, ARG_0);
}


// virtual void GetVolumes(vtkPropCollection * ARG_0)
// "virtual void GetVolumes(vtkPropCollection *)"
public void GetVolumes(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkProp.GetVolumes_0(this, ARG_0);
}


// virtual void SetVisibility(int _arg)
// "virtual void SetVisibility (int _arg)"
public void SetVisibility(int /*(int)*/ _arg) {
	VTK_API.API_vtkProp.SetVisibility_0(this, _arg);
}


// virtual int GetVisibility()
// "virtual int GetVisibility ()"
public int GetVisibility() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.GetVisibility_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void VisibilityOn()
// "virtual void VisibilityOn ()"
public void VisibilityOn() {
	VTK_API.API_vtkProp.VisibilityOn_0(this);
}


// virtual void VisibilityOff()
// "virtual void VisibilityOff ()"
public void VisibilityOff() {
	VTK_API.API_vtkProp.VisibilityOff_0(this);
}


// virtual void SetPickable(int _arg)
// "virtual void SetPickable (int _arg)"
public void SetPickable(int /*(int)*/ _arg) {
	VTK_API.API_vtkProp.SetPickable_0(this, _arg);
}


// virtual int GetPickable()
// "virtual int GetPickable ()"
public int GetPickable() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.GetPickable_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PickableOn()
// "virtual void PickableOn ()"
public void PickableOn() {
	VTK_API.API_vtkProp.PickableOn_0(this);
}


// virtual void PickableOff()
// "virtual void PickableOff ()"
public void PickableOff() {
	VTK_API.API_vtkProp.PickableOff_0(this);
}


// virtual void Pick()
// "virtual void Pick()"
public void Pick() {
	VTK_API.API_vtkProp.Pick_0(this);
}


// virtual void SetDragable(int _arg)
// "virtual void SetDragable (int _arg)"
public void SetDragable(int /*(int)*/ _arg) {
	VTK_API.API_vtkProp.SetDragable_0(this, _arg);
}


// virtual int GetDragable()
// "virtual int GetDragable ()"
public int GetDragable() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.GetDragable_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void DragableOn()
// "virtual void DragableOn ()"
public void DragableOn() {
	VTK_API.API_vtkProp.DragableOn_0(this);
}


// virtual void DragableOff()
// "virtual void DragableOff ()"
public void DragableOff() {
	VTK_API.API_vtkProp.DragableOff_0(this);
}


// virtual vtkMTimeType GetRedrawMTime()
// "virtual vtkMTimeType GetRedrawMTime()"
public ulong GetRedrawMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkProp.GetRedrawMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void SetUseBounds(bool _arg)
// "virtual void SetUseBounds (bool _arg)"
public void SetUseBounds(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProp.SetUseBounds_0(this, _arg);
}


// virtual bool GetUseBounds()
// "virtual bool GetUseBounds ()"
public bool GetUseBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.GetUseBounds_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void UseBoundsOn()
// "virtual void UseBoundsOn ()"
public void UseBoundsOn() {
	VTK_API.API_vtkProp.UseBoundsOn_0(this);
}


// virtual void UseBoundsOff()
// "virtual void UseBoundsOff ()"
public void UseBoundsOff() {
	VTK_API.API_vtkProp.UseBoundsOff_0(this);
}


// virtual double* GetBounds()
// "virtual double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void ShallowCopy(vtkProp * prop)
// "virtual void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkProp.ShallowCopy_0(this, prop);
}


// virtual void InitPathTraversal()
// "virtual void InitPathTraversal()"
public void InitPathTraversal() {
	VTK_API.API_vtkProp.InitPathTraversal_0(this);
}


// virtual vtkAssemblyPath* GetNextPath()
// "virtual vtkAssemblyPath *GetNextPath()"
public vtkAssemblyPath GetNextPath() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GetNextPath_0(returnPointer.GetPtr(), this);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual int GetNumberOfPaths()
// "virtual int GetNumberOfPaths()"
public int GetNumberOfPaths() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.GetNumberOfPaths_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PokeMatrix(vtkMatrix4x4 * ARG_0)
// "virtual void PokeMatrix(vtkMatrix4x4 *)"
public void PokeMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ ARG_0) {
	VTK_API.API_vtkProp.PokeMatrix_0(this, ARG_0);
}


// virtual vtkMatrix4x4* GetMatrix()
// "virtual vtkMatrix4x4 *GetMatrix()"
public vtkMatrix4x4 GetMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GetMatrix_0(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual vtkInformation* GetPropertyKeys()
// "virtual vtkInformation *GetPropertyKeys ()"
public vtkInformation GetPropertyKeys() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GetPropertyKeys_0(returnPointer.GetPtr(), this);
	return (vtkInformation)(IntPtr)returnPointer;
}


// virtual void SetPropertyKeys(vtkInformation * keys)
// "virtual void SetPropertyKeys(vtkInformation *keys)"
public void SetPropertyKeys(vtkInformation /*(vtkInformation*)*/ keys) {
	VTK_API.API_vtkProp.SetPropertyKeys_0(this, keys);
}


// virtual bool HasKeys(vtkInformation * requiredKeys)
// "virtual bool HasKeys(vtkInformation *requiredKeys)"
public bool HasKeys(vtkInformation /*(vtkInformation*)*/ requiredKeys) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.HasKeys_0(returnPointer.GetPtr(), this, requiredKeys);
	return (bool)returnPointer;
}


// static vtkInformationIntegerKey* GeneralTextureUnit()
// "static vtkInformationIntegerKey *GeneralTextureUnit()"
public static vtkInformationIntegerKey GeneralTextureUnit() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GeneralTextureUnit_0(returnPointer.GetPtr());
	return (vtkInformationIntegerKey)(IntPtr)returnPointer;
}


// static vtkInformationDoubleVectorKey* GeneralTextureTransform()
// "static vtkInformationDoubleVectorKey *GeneralTextureTransform()"
public static vtkInformationDoubleVectorKey GeneralTextureTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GeneralTextureTransform_0(returnPointer.GetPtr());
	return (vtkInformationDoubleVectorKey)(IntPtr)returnPointer;
}


// virtual int RenderOpaqueGeometry(vtkViewport * ARG_0)
// "virtual int RenderOpaqueGeometry(vtkViewport *)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.RenderOpaqueGeometry_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// virtual int RenderTranslucentPolygonalGeometry(vtkViewport * ARG_0)
// "virtual int RenderTranslucentPolygonalGeometry(vtkViewport *)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.RenderTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// virtual int RenderVolumetricGeometry(vtkViewport * ARG_0)
// "virtual int RenderVolumetricGeometry(vtkViewport *)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.RenderVolumetricGeometry_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// virtual int RenderOverlay(vtkViewport * ARG_0)
// "virtual int RenderOverlay(vtkViewport *)"
public int RenderOverlay(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.RenderOverlay_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// virtual bool RenderFilteredOpaqueGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// "virtual bool RenderFilteredOpaqueGeometry(vtkViewport *v, vtkInformation *requiredKeys)"
public bool RenderFilteredOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ v, vtkInformation /*(vtkInformation*)*/ requiredKeys) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.RenderFilteredOpaqueGeometry_0(returnPointer.GetPtr(), this, v, requiredKeys);
	return (bool)returnPointer;
}


// virtual bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// "virtual bool RenderFilteredTranslucentPolygonalGeometry( vtkViewport *v, vtkInformation *requiredKeys)"
public bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ v, vtkInformation /*(vtkInformation*)*/ requiredKeys) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.RenderFilteredTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this, v, requiredKeys);
	return (bool)returnPointer;
}


// virtual bool RenderFilteredVolumetricGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// "virtual bool RenderFilteredVolumetricGeometry(vtkViewport *v, vtkInformation *requiredKeys)"
public bool RenderFilteredVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ v, vtkInformation /*(vtkInformation*)*/ requiredKeys) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.RenderFilteredVolumetricGeometry_0(returnPointer.GetPtr(), this, v, requiredKeys);
	return (bool)returnPointer;
}


// virtual bool RenderFilteredOverlay(vtkViewport * v, vtkInformation * requiredKeys)
// "virtual bool RenderFilteredOverlay(vtkViewport *v, vtkInformation *requiredKeys)"
public bool RenderFilteredOverlay(vtkViewport /*(vtkViewport*)*/ v, vtkInformation /*(vtkInformation*)*/ requiredKeys) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.RenderFilteredOverlay_0(returnPointer.GetPtr(), this, v, requiredKeys);
	return (bool)returnPointer;
}


// virtual int HasTranslucentPolygonalGeometry()
// "virtual int HasTranslucentPolygonalGeometry()"
public int HasTranslucentPolygonalGeometry() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.HasTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkProp.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual double GetEstimatedRenderTime(vtkViewport * ARG_0)
// "virtual double GetEstimatedRenderTime( vtkViewport * )"
public double GetEstimatedRenderTime(vtkViewport /*(vtkViewport*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProp.GetEstimatedRenderTime_0(returnPointer.GetPtr(), this, ARG_0);
	return (double)returnPointer;
}


// virtual double GetEstimatedRenderTime()
// "virtual double GetEstimatedRenderTime()"
public double GetEstimatedRenderTime() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProp.GetEstimatedRenderTime_1(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void SetEstimatedRenderTime(double t)
// "virtual void SetEstimatedRenderTime(double t)"
public void SetEstimatedRenderTime(double /*(double)*/ t) {
	VTK_API.API_vtkProp.SetEstimatedRenderTime_0(this, t);
}


// virtual void RestoreEstimatedRenderTime()
// "virtual void RestoreEstimatedRenderTime()"
public void RestoreEstimatedRenderTime() {
	VTK_API.API_vtkProp.RestoreEstimatedRenderTime_0(this);
}


// virtual void AddEstimatedRenderTime(double t, vtkViewport * ARG_0)
// "virtual void AddEstimatedRenderTime(double t, vtkViewport *)"
public void AddEstimatedRenderTime(double /*(double)*/ t, vtkViewport /*(vtkViewport*)*/ ARG_0) {
	VTK_API.API_vtkProp.AddEstimatedRenderTime_0(this, t, ARG_0);
}


// virtual void SetAllocatedRenderTime(double t, vtkViewport * ARG_0)
// "virtual void SetAllocatedRenderTime(double t, vtkViewport *)"
public void SetAllocatedRenderTime(double /*(double)*/ t, vtkViewport /*(vtkViewport*)*/ ARG_0) {
	VTK_API.API_vtkProp.SetAllocatedRenderTime_0(this, t, ARG_0);
}


// virtual double GetAllocatedRenderTime()
// "virtual double GetAllocatedRenderTime ()"
public double GetAllocatedRenderTime() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProp.GetAllocatedRenderTime_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void SetRenderTimeMultiplier(double t)
// "void SetRenderTimeMultiplier( double t )"
public void SetRenderTimeMultiplier(double /*(double)*/ t) {
	VTK_API.API_vtkProp.SetRenderTimeMultiplier_0(this, t);
}


// virtual double GetRenderTimeMultiplier()
// "virtual double GetRenderTimeMultiplier ()"
public double GetRenderTimeMultiplier() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProp.GetRenderTimeMultiplier_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// "virtual void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)"
public void BuildPaths(vtkAssemblyPaths /*(vtkAssemblyPaths*)*/ paths, vtkAssemblyPath /*(vtkAssemblyPath*)*/ path) {
	VTK_API.API_vtkProp.BuildPaths_0(this, paths, path);
}


// virtual bool GetSupportsSelection()
// "virtual bool GetSupportsSelection()"
public bool GetSupportsSelection() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp.GetSupportsSelection_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual int GetNumberOfConsumers()
// "virtual int GetNumberOfConsumers ()"
public int GetNumberOfConsumers() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.GetNumberOfConsumers_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void AddConsumer(vtkObject * c)
// "void AddConsumer(vtkObject *c)"
public void AddConsumer(vtkObject /*(vtkObject*)*/ c) {
	VTK_API.API_vtkProp.AddConsumer_0(this, c);
}


// void RemoveConsumer(vtkObject * c)
// "void RemoveConsumer(vtkObject *c)"
public void RemoveConsumer(vtkObject /*(vtkObject*)*/ c) {
	VTK_API.API_vtkProp.RemoveConsumer_0(this, c);
}


// vtkObject* GetConsumer(int i)
// "vtkObject *GetConsumer(int i)"
public vtkObject GetConsumer(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp.GetConsumer_0(returnPointer.GetPtr(), this, i);
	return (vtkObject)(IntPtr)returnPointer;
}


// int IsConsumer(vtkObject * c)
// "int IsConsumer(vtkObject *c)"
public int IsConsumer(vtkObject /*(vtkObject*)*/ c) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp.IsConsumer_0(returnPointer.GetPtr(), this, c);
	return (int)returnPointer;
}


}
};
