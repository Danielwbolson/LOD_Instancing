
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformationObjectBaseVectorKey {

// static vtkInformationObjectBaseVectorKey* MakeKey(const char * name, const char * location, const char * requiredClass = nullptr)
// static vtkInformationObjectBaseVectorKey* MakeKey(const char* name, const char* location, const char* requiredClass=nullptr)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_MakeKey_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_MakeKey_0(IntPtr /*(vtkInformationObjectBaseVectorKey**)*/ return_value, IntPtr /*(char*)*/ name, IntPtr /*(char*)*/ location, IntPtr /*(char*)*/ requiredClass);

// void Clear(vtkInformation * info)
// void Clear(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Clear_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Clear_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Resize(vtkInformation * info, int n)
// void Resize(vtkInformation* info, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Resize_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Resize_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ n);

// int Size(vtkInformation * info)
// int Size(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Size_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Size_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// int Length(vtkInformation * info)
// int Length(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Length_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// void Append(vtkInformation * info, vtkObjectBase * value)
// void Append(vtkInformation* info, vtkObjectBase *value)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Append_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Append_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ value);

// void Set(vtkInformation * info, vtkObjectBase * value, int i)
// void Set(vtkInformation* info, vtkObjectBase *value, int i)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Set_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Set_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ value, int /*(int)*/ i);

// void Remove(vtkInformation * info, vtkObjectBase * val)
// void Remove(vtkInformation *info, vtkObjectBase *val)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Remove_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Remove_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase*)*/ val);

// void Remove(vtkInformation * info, int idx)
// void Remove(vtkInformation *info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Remove_1")] public static extern 
bool vtkInformationObjectBaseVectorKey_Remove_1(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void SetRange(vtkInformation * info, vtkObjectBase ** source, int from, int to, int n)
// void SetRange(vtkInformation* info, vtkObjectBase **source, int from, int to, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_SetRange_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_SetRange_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase**)*/ source, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n);

// void GetRange(vtkInformation * info, vtkObjectBase ** dest, int from, int to, int n)
// void GetRange(vtkInformation *info, vtkObjectBase **dest, int from, int to, int n)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_GetRange_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_GetRange_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkObjectBase**)*/ dest, int /*(int)*/ from, int /*(int)*/ to, int /*(int)*/ n);

// vtkObjectBase* Get(vtkInformation * info, int idx)
// vtkObjectBase *Get(vtkInformation* info, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_Get_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_Get_0(IntPtr /*(vtkObjectBase**)*/ return_value, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, int /*(int)*/ idx);

// void ShallowCopy(vtkInformation * from, vtkInformation * to)
// void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationObjectBaseVectorKey_ShallowCopy_0")] public static extern 
bool vtkInformationObjectBaseVectorKey_ShallowCopy_0(IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

}
};
