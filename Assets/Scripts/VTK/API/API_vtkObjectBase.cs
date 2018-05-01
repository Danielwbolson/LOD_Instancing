
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkObjectBase {

// char* GetClassName()
// const char* GetClassName()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_GetClassName_0")] public static extern 
bool GetClassName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ callingObject);

// char* GetClassName()
// const char* GetClassName()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_GetClassName_1")] public static extern 
bool GetClassName_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ callingObject);

// char* GetClassName()
// const char* GetClassName()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_GetClassName_2")] public static extern 
bool GetClassName_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ callingObject);

// static vtkTypeBool IsTypeOf(const char * name)
// static vtkTypeBool IsTypeOf(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ name);

// virtual vtkTypeBool IsA(const char * name)
// virtual vtkTypeBool IsA(const char *name)
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ callingObject, string /*(char*)*/ name);

// virtual void Delete()
// virtual void Delete()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_Delete_0")] public static extern 
bool Delete_0(IntPtr /*(vtkObjectBase*)*/ callingObject);

// virtual void FastDelete()
// virtual void FastDelete()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_FastDelete_0")] public static extern 
bool FastDelete_0(IntPtr /*(vtkObjectBase*)*/ callingObject);

// static vtkObjectBase* New()
// static vtkObjectBase *New()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void InitializeObjectBase()
// void InitializeObjectBase()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_InitializeObjectBase_0")] public static extern 
bool InitializeObjectBase_0(IntPtr /*(vtkObjectBase*)*/ callingObject);

// virtual void Register(vtkObjectBase * o)
// virtual void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkObjectBase*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// virtual void UnRegister(vtkObjectBase * o)
// virtual void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkObjectBase*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// int GetReferenceCount()
// int GetReferenceCount()
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_GetReferenceCount_0")] public static extern 
bool GetReferenceCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ callingObject);

// void SetReferenceCount(int ARG_0)
// void SetReferenceCount(int)
[DllImport("vtkplugin", EntryPoint="vtkObjectBase_SetReferenceCount_0")] public static extern 
bool SetReferenceCount_0(IntPtr /*(vtkObjectBase*)*/ callingObject, int /*(int)*/ ARG_0);

}
};
