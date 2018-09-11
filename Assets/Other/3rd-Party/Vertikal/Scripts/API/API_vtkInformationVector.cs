
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationVector {

// static vtkInformationVector* New()
// static vtkInformationVector *New()
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationVector* SafeDownCast(vtkObjectBase * o)
// static vtkInformationVector* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationVector* NewInstance()
// vtkInformationVector *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject);

// int GetNumberOfInformationObjects()
// int GetNumberOfInformationObjects()
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_GetNumberOfInformationObjects_0")] public static extern 
bool GetNumberOfInformationObjects_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject);

// void SetNumberOfInformationObjects(int n)
// void SetNumberOfInformationObjects(int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_SetNumberOfInformationObjects_0")] public static extern 
bool SetNumberOfInformationObjects_0(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ n);

// void SetInformationObject(int index, vtkInformation * info)
// void SetInformationObject(int index, vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_SetInformationObject_0")] public static extern 
bool SetInformationObject_0(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkInformation*)*/ info);

// vtkInformation* GetInformationObject(int index)
// vtkInformation* GetInformationObject(int index)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_GetInformationObject_0")] public static extern 
bool GetInformationObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ index);

// void Append(vtkInformation * info)
// void Append(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Remove(vtkInformation * info)
// void Remove(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Remove_0")] public static extern 
bool Remove_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Remove(int idx)
// void Remove(int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Remove_1")] public static extern 
bool Remove_1(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ idx);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void Copy(vtkInformationVector * from, int deep = 0)
// void Copy(vtkInformationVector* from, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Copy_0")] public static extern 
bool Copy_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformationVector*)*/ from, int /*(int)*/ deep);

}
};
