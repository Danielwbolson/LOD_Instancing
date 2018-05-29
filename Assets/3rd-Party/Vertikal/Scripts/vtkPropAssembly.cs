

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPropAssembly : vtkProp {
		public vtkPropAssembly(IntPtr p) : base(p) {}
		public static implicit operator  vtkPropAssembly(IntPtr p) {return new vtkPropAssembly(p);}
		public static implicit operator  IntPtr(vtkPropAssembly o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPropAssembly.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPropAssembly.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPropAssembly* SafeDownCast(vtkObjectBase * o)
// "static vtkPropAssembly* SafeDownCast(vtkObjectBase *o)"
public static vtkPropAssembly SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPropAssembly)(IntPtr)returnPointer;
}


// vtkPropAssembly* NewInstance()
// "vtkPropAssembly *NewInstance()"
public vtkPropAssembly NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPropAssembly)(IntPtr)returnPointer;
}


// static vtkPropAssembly* New()
// "static vtkPropAssembly *New()"
public static vtkPropAssembly New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.New_0(returnPointer.GetPtr());
	return (vtkPropAssembly)(IntPtr)returnPointer;
}


// void AddPart(vtkProp * ARG_0)
// "void AddPart(vtkProp *)"
public void AddPart(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkPropAssembly.AddPart_0(this, ARG_0);
}


// void RemovePart(vtkProp * ARG_0)
// "void RemovePart(vtkProp *)"
public void RemovePart(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkPropAssembly.RemovePart_0(this, ARG_0);
}


// vtkPropCollection* GetParts()
// "vtkPropCollection *GetParts()"
public vtkPropCollection GetParts() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.GetParts_0(returnPointer.GetPtr(), this);
	return (vtkPropCollection)(IntPtr)returnPointer;
}


// int RenderOpaqueGeometry(vtkViewport * ren)
// "int RenderOpaqueGeometry(vtkViewport *ren)"
public int RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.RenderOpaqueGeometry_0(returnPointer.GetPtr(), this, ren);
	return (int)returnPointer;
}


// int RenderTranslucentPolygonalGeometry(vtkViewport * ren)
// "int RenderTranslucentPolygonalGeometry( vtkViewport *ren)"
public int RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.RenderTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this, ren);
	return (int)returnPointer;
}


// int RenderVolumetricGeometry(vtkViewport * ren)
// "int RenderVolumetricGeometry( vtkViewport *ren)"
public int RenderVolumetricGeometry(vtkViewport /*(vtkViewport*)*/ ren) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.RenderVolumetricGeometry_0(returnPointer.GetPtr(), this, ren);
	return (int)returnPointer;
}


// int RenderOverlay(vtkViewport * ren)
// "int RenderOverlay(vtkViewport *ren)"
public int RenderOverlay(vtkViewport /*(vtkViewport*)*/ ren) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.RenderOverlay_0(returnPointer.GetPtr(), this, ren);
	return (int)returnPointer;
}


// int HasTranslucentPolygonalGeometry()
// "int HasTranslucentPolygonalGeometry()"
public int HasTranslucentPolygonalGeometry() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.HasTranslucentPolygonalGeometry_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkPropAssembly.ReleaseGraphicsResources_0(this, ARG_0);
}


// double* GetBounds()
// "double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.GetBounds_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void ShallowCopy(vtkProp * Prop)
// "void ShallowCopy(vtkProp *Prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ Prop) {
	VTK_API.API_vtkPropAssembly.ShallowCopy_0(this, Prop);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkPropAssembly.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void InitPathTraversal()
// "void InitPathTraversal()"
public void InitPathTraversal() {
	VTK_API.API_vtkPropAssembly.InitPathTraversal_0(this);
}


// vtkAssemblyPath* GetNextPath()
// "vtkAssemblyPath *GetNextPath()"
public vtkAssemblyPath GetNextPath() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPropAssembly.GetNextPath_0(returnPointer.GetPtr(), this);
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// int GetNumberOfPaths()
// "int GetNumberOfPaths()"
public int GetNumberOfPaths() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPropAssembly.GetNumberOfPaths_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// "void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)"
public void BuildPaths(vtkAssemblyPaths /*(vtkAssemblyPaths*)*/ paths, vtkAssemblyPath /*(vtkAssemblyPath*)*/ path) {
	VTK_API.API_vtkPropAssembly.BuildPaths_0(this, paths, path);
}


}
};
