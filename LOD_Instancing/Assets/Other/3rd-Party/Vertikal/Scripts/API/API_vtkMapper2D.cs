
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkMapper2D {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper2D*)*/ callingObject, string /*(char*)*/ type);

// static vtkMapper2D* SafeDownCast(vtkObjectBase * o)
// static vtkMapper2D* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkMapper2D* NewInstance()
// vtkMapper2D *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper2D*)*/ callingObject);

// virtual void RenderOverlay(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// virtual void RenderOverlay(vtkViewport*, vtkActor2D*)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_RenderOverlay_0")] public static extern 
bool RenderOverlay_0(IntPtr /*(vtkMapper2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0, IntPtr /*(vtkActor2D*)*/ ARG_1);

// virtual void RenderOpaqueGeometry(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// virtual void RenderOpaqueGeometry(vtkViewport*, vtkActor2D*)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(vtkMapper2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0, IntPtr /*(vtkActor2D*)*/ ARG_1);

// virtual void RenderTranslucentPolygonalGeometry(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// virtual void RenderTranslucentPolygonalGeometry(vtkViewport*, vtkActor2D*)
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(vtkMapper2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0, IntPtr /*(vtkActor2D*)*/ ARG_1);

// virtual int HasTranslucentPolygonalGeometry()
// virtual int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkMapper2D_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper2D*)*/ callingObject);

}
};
