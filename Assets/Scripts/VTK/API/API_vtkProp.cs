
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProp {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, string /*(char*)*/ type);

// static vtkProp* SafeDownCast(vtkObjectBase * o)
// static vtkProp* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProp_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProp* NewInstance()
// vtkProp *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProp_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void GetActors(vtkPropCollection * ARG_0)
// virtual void GetActors(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkProp_GetActors_0")] public static extern 
bool GetActors_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// virtual void GetActors2D(vtkPropCollection * ARG_0)
// virtual void GetActors2D(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkProp_GetActors2D_0")] public static extern 
bool GetActors2D_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// virtual void GetVolumes(vtkPropCollection * ARG_0)
// virtual void GetVolumes(vtkPropCollection *)
[DllImport("vtkplugin", EntryPoint="vtkProp_GetVolumes_0")] public static extern 
bool GetVolumes_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// virtual void SetVisibility(int _arg)
// virtual void SetVisibility (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetVisibility_0")] public static extern 
bool SetVisibility_0(IntPtr /*(vtkProp*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetVisibility()
// virtual int GetVisibility ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetVisibility_0")] public static extern 
bool GetVisibility_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void VisibilityOn()
// virtual void VisibilityOn ()
[DllImport("vtkplugin", EntryPoint="vtkProp_VisibilityOn_0")] public static extern 
bool VisibilityOn_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void VisibilityOff()
// virtual void VisibilityOff ()
[DllImport("vtkplugin", EntryPoint="vtkProp_VisibilityOff_0")] public static extern 
bool VisibilityOff_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void SetPickable(int _arg)
// virtual void SetPickable (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetPickable_0")] public static extern 
bool SetPickable_0(IntPtr /*(vtkProp*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPickable()
// virtual int GetPickable ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetPickable_0")] public static extern 
bool GetPickable_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void PickableOn()
// virtual void PickableOn ()
[DllImport("vtkplugin", EntryPoint="vtkProp_PickableOn_0")] public static extern 
bool PickableOn_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void PickableOff()
// virtual void PickableOff ()
[DllImport("vtkplugin", EntryPoint="vtkProp_PickableOff_0")] public static extern 
bool PickableOff_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void Pick()
// virtual void Pick()
[DllImport("vtkplugin", EntryPoint="vtkProp_Pick_0")] public static extern 
bool Pick_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void SetDragable(int _arg)
// virtual void SetDragable (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetDragable_0")] public static extern 
bool SetDragable_0(IntPtr /*(vtkProp*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDragable()
// virtual int GetDragable ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetDragable_0")] public static extern 
bool GetDragable_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void DragableOn()
// virtual void DragableOn ()
[DllImport("vtkplugin", EntryPoint="vtkProp_DragableOn_0")] public static extern 
bool DragableOn_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void DragableOff()
// virtual void DragableOff ()
[DllImport("vtkplugin", EntryPoint="vtkProp_DragableOff_0")] public static extern 
bool DragableOff_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual vtkMTimeType GetRedrawMTime()
// virtual vtkMTimeType GetRedrawMTime()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetRedrawMTime_0")] public static extern 
bool GetRedrawMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void SetUseBounds(bool _arg)
// virtual void SetUseBounds (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetUseBounds_0")] public static extern 
bool SetUseBounds_0(IntPtr /*(vtkProp*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseBounds()
// virtual bool GetUseBounds ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetUseBounds_0")] public static extern 
bool GetUseBounds_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void UseBoundsOn()
// virtual void UseBoundsOn ()
[DllImport("vtkplugin", EntryPoint="vtkProp_UseBoundsOn_0")] public static extern 
bool UseBoundsOn_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void UseBoundsOff()
// virtual void UseBoundsOff ()
[DllImport("vtkplugin", EntryPoint="vtkProp_UseBoundsOff_0")] public static extern 
bool UseBoundsOff_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual double* GetBounds()
// virtual double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void ShallowCopy(vtkProp * prop)
// virtual void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkProp_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// virtual void InitPathTraversal()
// virtual void InitPathTraversal()
[DllImport("vtkplugin", EntryPoint="vtkProp_InitPathTraversal_0")] public static extern 
bool InitPathTraversal_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual vtkAssemblyPath* GetNextPath()
// virtual vtkAssemblyPath *GetNextPath()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetNextPath_0")] public static extern 
bool GetNextPath_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual int GetNumberOfPaths()
// virtual int GetNumberOfPaths()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetNumberOfPaths_0")] public static extern 
bool GetNumberOfPaths_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void PokeMatrix(vtkMatrix4x4 * ARG_0)
// virtual void PokeMatrix(vtkMatrix4x4 *)
[DllImport("vtkplugin", EntryPoint="vtkProp_PokeMatrix_0")] public static extern 
bool PokeMatrix_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ ARG_0);

// virtual vtkMatrix4x4* GetMatrix()
// virtual vtkMatrix4x4 *GetMatrix()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetMatrix_0")] public static extern 
bool GetMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual vtkInformation* GetPropertyKeys()
// virtual vtkInformation *GetPropertyKeys ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetPropertyKeys_0")] public static extern 
bool GetPropertyKeys_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void SetPropertyKeys(vtkInformation * keys)
// virtual void SetPropertyKeys(vtkInformation *keys)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetPropertyKeys_0")] public static extern 
bool SetPropertyKeys_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkInformation*)*/ keys);

// virtual bool HasKeys(vtkInformation * requiredKeys)
// virtual bool HasKeys(vtkInformation *requiredKeys)
[DllImport("vtkplugin", EntryPoint="vtkProp_HasKeys_0")] public static extern 
bool HasKeys_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkInformation*)*/ requiredKeys);

// static vtkInformationIntegerKey* GeneralTextureUnit()
// static vtkInformationIntegerKey *GeneralTextureUnit()
[DllImport("vtkplugin", EntryPoint="vtkProp_GeneralTextureUnit_0")] public static extern 
bool GeneralTextureUnit_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* GeneralTextureTransform()
// static vtkInformationDoubleVectorKey *GeneralTextureTransform()
[DllImport("vtkplugin", EntryPoint="vtkProp_GeneralTextureTransform_0")] public static extern 
bool GeneralTextureTransform_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual int RenderOpaqueGeometry(vtkViewport * ARG_0)
// virtual int RenderOpaqueGeometry(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual int RenderTranslucentPolygonalGeometry(vtkViewport * ARG_0)
// virtual int RenderTranslucentPolygonalGeometry(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual int RenderVolumetricGeometry(vtkViewport * ARG_0)
// virtual int RenderVolumetricGeometry(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderVolumetricGeometry_0")] public static extern 
bool RenderVolumetricGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual int RenderOverlay(vtkViewport * ARG_0)
// virtual int RenderOverlay(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderOverlay_0")] public static extern 
bool RenderOverlay_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual bool RenderFilteredOpaqueGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// virtual bool RenderFilteredOpaqueGeometry(vtkViewport *v, vtkInformation *requiredKeys)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderFilteredOpaqueGeometry_0")] public static extern 
bool RenderFilteredOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ v, IntPtr /*(vtkInformation*)*/ requiredKeys);

// virtual bool RenderFilteredTranslucentPolygonalGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// virtual bool RenderFilteredTranslucentPolygonalGeometry( vtkViewport *v, vtkInformation *requiredKeys)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderFilteredTranslucentPolygonalGeometry_0")] public static extern 
bool RenderFilteredTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ v, IntPtr /*(vtkInformation*)*/ requiredKeys);

// virtual bool RenderFilteredVolumetricGeometry(vtkViewport * v, vtkInformation * requiredKeys)
// virtual bool RenderFilteredVolumetricGeometry(vtkViewport *v, vtkInformation *requiredKeys)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderFilteredVolumetricGeometry_0")] public static extern 
bool RenderFilteredVolumetricGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ v, IntPtr /*(vtkInformation*)*/ requiredKeys);

// virtual bool RenderFilteredOverlay(vtkViewport * v, vtkInformation * requiredKeys)
// virtual bool RenderFilteredOverlay(vtkViewport *v, vtkInformation *requiredKeys)
[DllImport("vtkplugin", EntryPoint="vtkProp_RenderFilteredOverlay_0")] public static extern 
bool RenderFilteredOverlay_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ v, IntPtr /*(vtkInformation*)*/ requiredKeys);

// virtual int HasTranslucentPolygonalGeometry()
// virtual int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkProp_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// virtual void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkProp_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// virtual double GetEstimatedRenderTime(vtkViewport * ARG_0)
// virtual double GetEstimatedRenderTime( vtkViewport * )
[DllImport("vtkplugin", EntryPoint="vtkProp_GetEstimatedRenderTime_0")] public static extern 
bool GetEstimatedRenderTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual double GetEstimatedRenderTime()
// virtual double GetEstimatedRenderTime()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetEstimatedRenderTime_1")] public static extern 
bool GetEstimatedRenderTime_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void SetEstimatedRenderTime(double t)
// virtual void SetEstimatedRenderTime(double t)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetEstimatedRenderTime_0")] public static extern 
bool SetEstimatedRenderTime_0(IntPtr /*(vtkProp*)*/ callingObject, double /*(double)*/ t);

// virtual void RestoreEstimatedRenderTime()
// virtual void RestoreEstimatedRenderTime()
[DllImport("vtkplugin", EntryPoint="vtkProp_RestoreEstimatedRenderTime_0")] public static extern 
bool RestoreEstimatedRenderTime_0(IntPtr /*(vtkProp*)*/ callingObject);

// virtual void AddEstimatedRenderTime(double t, vtkViewport * ARG_0)
// virtual void AddEstimatedRenderTime(double t, vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_AddEstimatedRenderTime_0")] public static extern 
bool AddEstimatedRenderTime_0(IntPtr /*(vtkProp*)*/ callingObject, double /*(double)*/ t, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual void SetAllocatedRenderTime(double t, vtkViewport * ARG_0)
// virtual void SetAllocatedRenderTime(double t, vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkProp_SetAllocatedRenderTime_0")] public static extern 
bool SetAllocatedRenderTime_0(IntPtr /*(vtkProp*)*/ callingObject, double /*(double)*/ t, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual double GetAllocatedRenderTime()
// virtual double GetAllocatedRenderTime ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetAllocatedRenderTime_0")] public static extern 
bool GetAllocatedRenderTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// void SetRenderTimeMultiplier(double t)
// void SetRenderTimeMultiplier( double t )
[DllImport("vtkplugin", EntryPoint="vtkProp_SetRenderTimeMultiplier_0")] public static extern 
bool SetRenderTimeMultiplier_0(IntPtr /*(vtkProp*)*/ callingObject, double /*(double)*/ t);

// virtual double GetRenderTimeMultiplier()
// virtual double GetRenderTimeMultiplier ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetRenderTimeMultiplier_0")] public static extern 
bool GetRenderTimeMultiplier_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual void BuildPaths(vtkAssemblyPaths * paths, vtkAssemblyPath * path)
// virtual void BuildPaths(vtkAssemblyPaths *paths, vtkAssemblyPath *path)
[DllImport("vtkplugin", EntryPoint="vtkProp_BuildPaths_0")] public static extern 
bool BuildPaths_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkAssemblyPaths*)*/ paths, IntPtr /*(vtkAssemblyPath*)*/ path);

// virtual bool GetSupportsSelection()
// virtual bool GetSupportsSelection()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetSupportsSelection_0")] public static extern 
bool GetSupportsSelection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// virtual int GetNumberOfConsumers()
// virtual int GetNumberOfConsumers ()
[DllImport("vtkplugin", EntryPoint="vtkProp_GetNumberOfConsumers_0")] public static extern 
bool GetNumberOfConsumers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject);

// void AddConsumer(vtkObject * c)
// void AddConsumer(vtkObject *c)
[DllImport("vtkplugin", EntryPoint="vtkProp_AddConsumer_0")] public static extern 
bool AddConsumer_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkObject*)*/ c);

// void RemoveConsumer(vtkObject * c)
// void RemoveConsumer(vtkObject *c)
[DllImport("vtkplugin", EntryPoint="vtkProp_RemoveConsumer_0")] public static extern 
bool RemoveConsumer_0(IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkObject*)*/ c);

// vtkObject* GetConsumer(int i)
// vtkObject *GetConsumer(int i)
[DllImport("vtkplugin", EntryPoint="vtkProp_GetConsumer_0")] public static extern 
bool GetConsumer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, int /*(int)*/ i);

// int IsConsumer(vtkObject * c)
// int IsConsumer(vtkObject *c)
[DllImport("vtkplugin", EntryPoint="vtkProp_IsConsumer_0")] public static extern 
bool IsConsumer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp*)*/ callingObject, IntPtr /*(vtkObject*)*/ c);

}
};
