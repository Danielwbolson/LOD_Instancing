
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInformationKey {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject, string /*(char*)*/ type);

// static vtkInformationKey* SafeDownCast(vtkObjectBase * o)
// static vtkInformationKey* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInformationKey* NewInstance()
// vtkInformationKey *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject);

// void Register(vtkObjectBase * ARG_0)
// void Register(vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Register_0")] public static extern 
bool Register_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// void UnRegister(vtkObjectBase * ARG_0)
// void UnRegister(vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// char* GetName()
// const char* GetName()
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_GetName_0")] public static extern 
bool GetName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject);

// char* GetLocation()
// const char* GetLocation()
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_GetLocation_0")] public static extern 
bool GetLocation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject);

// virtual void ShallowCopy(vtkInformation * from, vtkInformation * to)
// virtual void ShallowCopy(vtkInformation* from, vtkInformation* to)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// virtual void DeepCopy(vtkInformation * from, vtkInformation * to)
// virtual void DeepCopy(vtkInformation *from, vtkInformation *to)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformation*)*/ to);

// virtual int Has(vtkInformation * info)
// virtual int Has(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Has_0")] public static extern 
bool Has_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// virtual void Remove(vtkInformation * info)
// virtual void Remove(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Remove_0")] public static extern 
bool Remove_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// virtual void Report(vtkInformation * info, vtkGarbageCollector * collector)
// virtual void Report(vtkInformation* info, vtkGarbageCollector* collector)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Report_0")] public static extern 
bool Report_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info, IntPtr /*(vtkGarbageCollector*)*/ collector);

// void Print(vtkInformation * info)
// void Print(vtkInformation* info)
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_Print_0")] public static extern 
bool Print_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ info);

// virtual bool NeedToExecute(vtkInformation * ARG_0, vtkInformation * ARG_1)
// virtual bool NeedToExecute(vtkInformation* , vtkInformation* )
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_NeedToExecute_0")] public static extern 
bool NeedToExecute_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0, IntPtr /*(vtkInformation*)*/ ARG_1);

// virtual void StoreMetaData(vtkInformation * ARG_0, vtkInformation * ARG_1, vtkInformation * ARG_2)
// virtual void StoreMetaData(vtkInformation* , vtkInformation* , vtkInformation* )
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_StoreMetaData_0")] public static extern 
bool StoreMetaData_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0, IntPtr /*(vtkInformation*)*/ ARG_1, IntPtr /*(vtkInformation*)*/ ARG_2);

// virtual void CopyDefaultInformation(vtkInformation * ARG_0, vtkInformation * ARG_1, vtkInformation * ARG_2)
// virtual void CopyDefaultInformation(vtkInformation* , vtkInformation* , vtkInformation* )
[DllImport("vtkplugin", EntryPoint="vtkInformationKey_CopyDefaultInformation_0")] public static extern 
bool CopyDefaultInformation_0(IntPtr /*(vtkInformationKey*)*/ callingObject, IntPtr /*(vtkInformation*)*/ ARG_0, IntPtr /*(vtkInformation*)*/ ARG_1, IntPtr /*(vtkInformation*)*/ ARG_2);

}
};
