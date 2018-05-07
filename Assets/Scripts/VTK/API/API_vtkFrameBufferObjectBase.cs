
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkFrameBufferObjectBase {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkFrameBufferObjectBase*)*/ callingObject, string /*(char*)*/ type);

// static vtkFrameBufferObjectBase* SafeDownCast(vtkObjectBase * o)
// static vtkFrameBufferObjectBase* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkFrameBufferObjectBase* NewInstance()
// vtkFrameBufferObjectBase *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFrameBufferObjectBase*)*/ callingObject);

// virtual int* GetLastSize()
// virtual int *GetLastSize()
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_GetLastSize_0")] public static extern 
bool GetLastSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkFrameBufferObjectBase*)*/ callingObject);

// virtual void GetLastSize(int & _arg1, int & _arg2)
// virtual void GetLastSize (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_GetLastSize_1")] public static extern 
bool GetLastSize_1(IntPtr /*(vtkFrameBufferObjectBase*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetLastSize(int _arg[2])
// virtual void GetLastSize (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkFrameBufferObjectBase_GetLastSize_2")] public static extern 
bool GetLastSize_2(IntPtr /*(vtkFrameBufferObjectBase*)*/ callingObject, int /*(int[2])*/ []_arg);

}
};
