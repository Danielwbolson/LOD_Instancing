
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationVector {

// static vtkInformationVector* New()
// static vtkInformationVector *New()
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_New_0")] public static extern 
bool vtkInformationVector_New_0(IntPtr /*(vtkInformationVector**)*/ return_value);

// int GetNumberOfInformationObjects()
// int GetNumberOfInformationObjects()
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_GetNumberOfInformationObjects_0")] public static extern 
bool vtkInformationVector_GetNumberOfInformationObjects_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject);

// void SetNumberOfInformationObjects(int n)
// void SetNumberOfInformationObjects(int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_SetNumberOfInformationObjects_0")] public static extern 
bool vtkInformationVector_SetNumberOfInformationObjects_0(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ n);

// void SetInformationObject(int index, vtkInformation * info)
// void SetInformationObject(int index, vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_SetInformationObject_0")] public static extern 
bool vtkInformationVector_SetInformationObject_0(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ index, IntPtr /*(vtkInformation*)*/ info);

// vtkInformation* GetInformationObject(int index)
// vtkInformation* GetInformationObject(int index)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_GetInformationObject_0")] public static extern 
bool vtkInformationVector_GetInformationObject_0(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ index);

// void Append(vtkInformation * info)
// void Append(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Append_0")] public static extern 
bool vtkInformationVector_Append_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Remove(vtkInformation * info)
// void Remove(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Remove_0")] public static extern 
bool vtkInformationVector_Remove_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Remove(int idx)
// void Remove(int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Remove_1")] public static extern 
bool vtkInformationVector_Remove_1(IntPtr /*(vtkInformationVector*)*/ callingObject, int /*(int)*/ idx);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Register_0")] public static extern 
bool vtkInformationVector_Register_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_UnRegister_0")] public static extern 
bool vtkInformationVector_UnRegister_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void Copy(vtkInformationVector * from, int deep = 0)
// void Copy(vtkInformationVector* from, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformationVector_Copy_0")] public static extern 
bool vtkInformationVector_Copy_0(IntPtr /*(vtkInformationVector*)*/ callingObject, IntPtr /*(vtkInformationVector*)*/ from, int /*(int)*/ deep);

}
};
