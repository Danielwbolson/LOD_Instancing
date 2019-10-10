
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRenderPass {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderPass*)*/ callingObject, string /*(char*)*/ type);

// static vtkRenderPass* SafeDownCast(vtkObjectBase * o)
// static vtkRenderPass* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRenderPass* NewInstance()
// vtkRenderPass *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderPass*)*/ callingObject);

// virtual int GetNumberOfRenderedProps()
// virtual int GetNumberOfRenderedProps ()
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_GetNumberOfRenderedProps_0")] public static extern 
bool GetNumberOfRenderedProps_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderPass*)*/ callingObject);

// virtual void ReleaseGraphicsResources(vtkWindow * w)
// virtual void ReleaseGraphicsResources(vtkWindow *w)
[DllImport("vtkplugin", EntryPoint="vtkRenderPass_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkRenderPass*)*/ callingObject, IntPtr /*(vtkWindow*)*/ w);

}
};
