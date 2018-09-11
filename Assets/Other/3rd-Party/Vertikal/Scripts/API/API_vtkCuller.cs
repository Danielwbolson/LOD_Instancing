
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCuller {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCuller_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCuller_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCuller*)*/ callingObject, string /*(char*)*/ type);

// static vtkCuller* SafeDownCast(vtkObjectBase * o)
// static vtkCuller* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCuller_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCuller* NewInstance()
// vtkCuller *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCuller_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCuller*)*/ callingObject);

// virtual double Cull(vtkRenderer * ren, vtkProp ** propList, int & listLength, int & initialized)
// virtual double Cull( vtkRenderer *ren, vtkProp **propList, int& listLength, int& initialized )
[DllImport("vtkplugin", EntryPoint="vtkCuller_Cull_0")] public static extern 
bool Cull_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCuller*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(vtkProp**)*/ propList, IntPtr /*(int&)*/ listLength, IntPtr /*(int&)*/ initialized);

}
};
