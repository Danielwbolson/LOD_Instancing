
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRendererDelegate {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRendererDelegate*)*/ callingObject, string /*(char*)*/ type);

// static vtkRendererDelegate* SafeDownCast(vtkObjectBase * o)
// static vtkRendererDelegate* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRendererDelegate* NewInstance()
// vtkRendererDelegate *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRendererDelegate*)*/ callingObject);

// virtual void Render(vtkRenderer * r)
// virtual void Render(vtkRenderer *r)
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkRendererDelegate*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ r);

// virtual void SetUsed(bool _arg)
// virtual void SetUsed (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_SetUsed_0")] public static extern 
bool SetUsed_0(IntPtr /*(vtkRendererDelegate*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUsed()
// virtual bool GetUsed ()
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_GetUsed_0")] public static extern 
bool GetUsed_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRendererDelegate*)*/ callingObject);

// virtual void UsedOn()
// virtual void UsedOn ()
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_UsedOn_0")] public static extern 
bool UsedOn_0(IntPtr /*(vtkRendererDelegate*)*/ callingObject);

// virtual void UsedOff()
// virtual void UsedOff ()
[DllImport("vtkplugin", EntryPoint="vtkRendererDelegate_UsedOff_0")] public static extern 
bool UsedOff_0(IntPtr /*(vtkRendererDelegate*)*/ callingObject);

}
};
