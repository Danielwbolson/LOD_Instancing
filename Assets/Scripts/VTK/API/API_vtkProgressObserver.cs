
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProgressObserver {

// static vtkProgressObserver* New()
// static vtkProgressObserver *New()
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProgressObserver*)*/ callingObject, string /*(char*)*/ type);

// static vtkProgressObserver* SafeDownCast(vtkObjectBase * o)
// static vtkProgressObserver* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProgressObserver* NewInstance()
// vtkProgressObserver *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProgressObserver*)*/ callingObject);

// virtual void UpdateProgress(double amount)
// virtual void UpdateProgress(double amount)
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_UpdateProgress_0")] public static extern 
bool UpdateProgress_0(IntPtr /*(vtkProgressObserver*)*/ callingObject, double /*(double)*/ amount);

// virtual double GetProgress()
// virtual double GetProgress ()
[DllImport("vtkplugin", EntryPoint="vtkProgressObserver_GetProgress_0")] public static extern 
bool GetProgress_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProgressObserver*)*/ callingObject);

}
};
