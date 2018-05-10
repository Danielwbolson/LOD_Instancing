
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationDoubleVectorKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationDoubleVectorKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationDoubleVectorKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationDoubleVectorKey* NewInstance()
// vtkInformationDoubleVectorKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject);

// void Append(vtkInformation * info, double value)
// void Append(vtkInformation* info, double value)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, double /*(double)*/ value);

// void Set(vtkInformation * info, const double * value, int length)
// void Set(vtkInformation* info, const double* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value, int /*(int)*/ length);

// double* Get(vtkInformation * info)
// double* Get(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// double Get(vtkInformation * info, int idx)
// double Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_1")] public static extern 
bool Get_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void Get(vtkInformation * info, double * value)
// void Get(vtkInformation* info, double* value)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Get_2")] public static extern 
bool Get_2(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(double*)*/ value);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_Length_0")] public static extern 
bool Length_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationDoubleVectorKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationDoubleVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
