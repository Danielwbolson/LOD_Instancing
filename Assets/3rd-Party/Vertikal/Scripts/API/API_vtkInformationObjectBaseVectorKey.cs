
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationObjectBaseVectorKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationObjectBaseVectorKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationObjectBaseVectorKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationObjectBaseVectorKey* NewInstance()
// vtkInformationObjectBaseVectorKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject);

// void Clear(vtkInformation * info)
// void Clear(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Clear_0")] public static extern 
bool Clear_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Resize(vtkInformation * info, int n)
// void Resize(vtkInformation* info, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Resize_0")] public static extern 
bool Resize_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ n);

// int Size(vtkInformation * info)
// int Size(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Size_0")] public static extern 
bool Size_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Length_0")] public static extern 
bool Length_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Append(vtkInformation * info, vtkObjectBase * value)
// void Append(vtkInformation* info, vtkObjectBase *value)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Append_0")] public static extern 
bool Append_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ value);

// void Set(vtkInformation * info, vtkObjectBase * value, int i)
// void Set(vtkInformation* info, vtkObjectBase *value, int i)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Set_0")] public static extern 
bool Set_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ value, int /*(int)*/ i);

// void Remove(vtkInformation * info, vtkObjectBase * val)
// void Remove(vtkInformation *info, vtkObjectBase *val)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Remove_0")] public static extern 
bool Remove_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ val);

// void Remove(vtkInformation * info, int idx)
// void Remove(vtkInformation *info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Remove_1")] public static extern 
bool Remove_1(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void SetRange(vtkInformation * info, vtkObjectBase ** source, int from, int to, int n)
// void SetRange(vtkInformation* info, vtkObjectBase **source, int from, int to, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_SetRange_0")] public static extern 
bool SetRange_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase**)*/ source, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n);

// void GetRange(vtkInformation * info, vtkObjectBase ** dest, int from, int to, int n)
// void GetRange(vtkInformation *info, vtkObjectBase **dest, int from, int to, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase**)*/ dest, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n);

// vtkObjectBase* Get(vtkInformation * info, int idx)
// vtkObjectBase *Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Get_0")] public static extern 
bool Get_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
