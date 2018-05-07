
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPropAssembly {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject, string /*(char*)*/ type);

// static vtkPropAssembly* SafeDownCast(vtkObjectBase * o)
// static vtkPropAssembly* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPropAssembly* NewInstance()
// vtkPropAssembly *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// static vtkPropAssembly* New()
// static vtkPropAssembly *New()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void AddPart(vtkProp * ARG_0)
// void AddPart(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_AddPart_0")] public static extern 
bool AddPart_0(IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// void RemovePart(vtkProp * ARG_0)
// void RemovePart(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_RemovePart_0")] public static extern 
bool RemovePart_0(IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// vtkPropCollection* GetParts()
// vtkPropCollection *GetParts()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_GetParts_0")] public static extern 
bool GetParts_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// int RenderOpaqueGeometry(vtkViewport * ren)
// int RenderOpaqueGeometry(vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int RenderTranslucentPolygonalGeometry(vtkViewport * ren)
// int RenderTranslucentPolygonalGeometry( vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int RenderVolumetricGeometry(vtkViewport * ren)
// int RenderVolumetricGeometry( vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_RenderVolumetricGeometry_0")] public static extern 
bool RenderVolumetricGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int RenderOverlay(vtkViewport * ren)
// int RenderOverlay(vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_RenderOverlay_0")] public static extern 
bool RenderOverlay_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int HasTranslucentPolygonalGeometry()
// int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// void ShallowCopy(vtkProp * Prop)
// void ShallowCopy(vtkProp *Prop)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkProp*)*/ Prop);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// void InitPathTraversal()
// void InitPathTraversal()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_InitPathTraversal_0")] public static extern 
bool InitPathTraversal_0(IntPtr /*(vtkPropAssembly*)*/ callingObject);

// vtkAssemblyPath* GetNextPath()
// vtkAssemblyPath *GetNextPath()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_GetNextPath_0")] public static extern 
bool GetNextPath_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// int GetNumberOfPaths()
// int GetNumberOfPaths()
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_GetNumberOfPaths_0")] public static extern 
bool GetNumberOfPaths_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPropAssembly*)*/ callingObject);

// void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)
[DllImport("vtkplugin", EntryPoint="vtkPropAssembly_BuildPaths_0")] public static extern 
bool BuildPaths_0(IntPtr /*(vtkPropAssembly*)*/ callingObject, IntPtr /*(vtkAssemblyPaths*)*/ paths, IntPtr /*(vtkAssemblyPath*)*/ path);

}
};
