
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAssembly {

// static vtkAssembly* New()
// static vtkAssembly *New()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject, string /*(char*)*/ type);

// static vtkAssembly* SafeDownCast(vtkObjectBase * o)
// static vtkAssembly* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAssembly* NewInstance()
// vtkAssembly *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// void AddPart(vtkProp3D * ARG_0)
// void AddPart(vtkProp3D *)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_AddPart_0")] public static extern 
bool AddPart_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkProp3D*)*/ ARG_0);

// void RemovePart(vtkProp3D * ARG_0)
// void RemovePart(vtkProp3D *)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_RemovePart_0")] public static extern 
bool RemovePart_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkProp3D*)*/ ARG_0);

// vtkProp3DCollection* GetParts()
// vtkProp3DCollection *GetParts()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetParts_0")] public static extern 
bool GetParts_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// void GetActors(vtkPropCollection * ARG_0)
// void GetActors(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetActors_0")] public static extern 
bool GetActors_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// void GetVolumes(vtkPropCollection * ARG_0)
// void GetVolumes(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetVolumes_0")] public static extern 
bool GetVolumes_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// int RenderOpaqueGeometry(vtkViewport * ren)
// int RenderOpaqueGeometry(vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int RenderTranslucentPolygonalGeometry(vtkViewport * ren)
// int RenderTranslucentPolygonalGeometry(vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int RenderVolumetricGeometry(vtkViewport * ren)
// int RenderVolumetricGeometry(vtkViewport *ren)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_RenderVolumetricGeometry_0")] public static extern 
bool RenderVolumetricGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ren);

// int HasTranslucentPolygonalGeometry()
// int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// void InitPathTraversal()
// void InitPathTraversal()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_InitPathTraversal_0")] public static extern 
bool InitPathTraversal_0(IntPtr /*(vtkAssembly*)*/ callingObject);

// vtkAssemblyPath* GetNextPath()
// vtkAssemblyPath *GetNextPath()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetNextPath_0")] public static extern 
bool GetNextPath_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// int GetNumberOfPaths()
// int GetNumberOfPaths()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetNumberOfPaths_0")] public static extern 
bool GetNumberOfPaths_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(vtkAssembly*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAssembly_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAssembly*)*/ callingObject);

// void ShallowCopy(vtkProp * prop)
// void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)
[DllImport("vtkplugin", EntryPoint="vtkAssembly_BuildPaths_0")] public static extern 
bool BuildPaths_0(IntPtr /*(vtkAssembly*)*/ callingObject, IntPtr /*(vtkAssemblyPaths*)*/ paths, IntPtr /*(vtkAssemblyPath*)*/ path);

}
};
