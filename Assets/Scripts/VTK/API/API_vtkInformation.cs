
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkInformation {

// static vtkInformation* New()
// static vtkInformation *New()
[DllImport("vtkplugin", EntryPoint="vtkInformation_New_0")] public static extern 
bool vtkInformation_New_0(IntPtr /*(vtkInformation**)*/ return_value);

// void Modified()
// void Modified()
[DllImport("vtkplugin", EntryPoint="vtkInformation_Modified_0")] public static extern 
bool vtkInformation_Modified_0(IntPtr /*(vtkInformation*)*/ callingObject);

// void Modified(vtkInformationKey * key)
// void Modified(vtkInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Modified_1")] public static extern 
bool vtkInformation_Modified_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKey*)*/ key);

// void Clear()
// void Clear()
[DllImport("vtkplugin", EntryPoint="vtkInformation_Clear_0")] public static extern 
bool vtkInformation_Clear_0(IntPtr /*(vtkInformation*)*/ callingObject);

// int GetNumberOfKeys()
// int GetNumberOfKeys()
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetNumberOfKeys_0")] public static extern 
bool vtkInformation_GetNumberOfKeys_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject);

// void Copy(vtkInformation * from, int deep = 0)
// void Copy(vtkInformation* from, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Copy_0")] public static extern 
bool vtkInformation_Copy_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, int /*(int)*/ deep);

// void Append(vtkInformation * from, int deep = 0)
// void Append(vtkInformation* from, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_0")] public static extern 
bool vtkInformation_Append_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_0")] public static extern 
bool vtkInformation_CopyEntry_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationDataObjectKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationDataObjectKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_1")] public static extern 
bool vtkInformation_CopyEntry_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationDataObjectKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationDoubleVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationDoubleVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_2")] public static extern 
bool vtkInformation_CopyEntry_2(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationVariantKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationVariantKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_3")] public static extern 
bool vtkInformation_CopyEntry_3(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationVariantKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationVariantVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationVariantVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_4")] public static extern 
bool vtkInformation_CopyEntry_4(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationVariantVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationInformationKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationInformationKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_5")] public static extern 
bool vtkInformation_CopyEntry_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationInformationKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationInformationVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationInformationVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_6")] public static extern 
bool vtkInformation_CopyEntry_6(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationInformationVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationIntegerKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationIntegerKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_7")] public static extern 
bool vtkInformation_CopyEntry_7(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationIntegerKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationIntegerVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationIntegerVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_8")] public static extern 
bool vtkInformation_CopyEntry_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationObjectBaseVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationObjectBaseVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_9")] public static extern 
bool vtkInformation_CopyEntry_9(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationRequestKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationRequestKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_10")] public static extern 
bool vtkInformation_CopyEntry_10(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationRequestKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationStringKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationStringKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_11")] public static extern 
bool vtkInformation_CopyEntry_11(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationStringKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationStringVectorKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationStringVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_12")] public static extern 
bool vtkInformation_CopyEntry_12(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationStringVectorKey*)*/ key, int /*(int)*/ deep);

// void CopyEntry(vtkInformation * from, vtkInformationUnsignedLongKey * key, int deep = 0)
// void CopyEntry(vtkInformation* from, vtkInformationUnsignedLongKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntry_13")] public static extern 
bool vtkInformation_CopyEntry_13(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key, int /*(int)*/ deep);

// void CopyEntries(vtkInformation * from, vtkInformationKeyVectorKey * key, int deep = 0)
// void CopyEntries(vtkInformation* from, vtkInformationKeyVectorKey* key, int deep=0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_CopyEntries_0")] public static extern 
bool vtkInformation_CopyEntries_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformation*)*/ from, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, int /*(int)*/ deep);

// int Has(vtkInformationKey * key)
// int Has(vtkInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_0")] public static extern 
bool vtkInformation_Has_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKey*)*/ key);

// void Remove(vtkInformationKey * key)
// void Remove(vtkInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_0")] public static extern 
bool vtkInformation_Remove_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKey*)*/ key);

// void Set(vtkInformationRequestKey * key)
// void Set(vtkInformationRequestKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_0")] public static extern 
bool vtkInformation_Set_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationRequestKey*)*/ key);

// void Remove(vtkInformationRequestKey * key)
// void Remove(vtkInformationRequestKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_1")] public static extern 
bool vtkInformation_Remove_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationRequestKey*)*/ key);

// int Has(vtkInformationRequestKey * key)
// int Has(vtkInformationRequestKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_1")] public static extern 
bool vtkInformation_Has_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationRequestKey*)*/ key);

// void Set(vtkInformationIntegerKey * key, int value)
// void Set(vtkInformationIntegerKey* key, int value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_1")] public static extern 
bool vtkInformation_Set_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerKey*)*/ key, int /*(int)*/ value);

// int Get(vtkInformationIntegerKey * key)
// int Get(vtkInformationIntegerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_0")] public static extern 
bool vtkInformation_Get_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerKey*)*/ key);

// void Remove(vtkInformationIntegerKey * key)
// void Remove(vtkInformationIntegerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_2")] public static extern 
bool vtkInformation_Remove_2(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerKey*)*/ key);

// int Has(vtkInformationIntegerKey * key)
// int Has(vtkInformationIntegerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_2")] public static extern 
bool vtkInformation_Has_2(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerKey*)*/ key);

// void Set(vtkInformationIdTypeKey * key, vtkIdType value)
// void Set(vtkInformationIdTypeKey* key, vtkIdType value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_2")] public static extern 
bool vtkInformation_Set_2(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIdTypeKey*)*/ key, long /*(vtkIdType)*/ value);

// vtkIdType Get(vtkInformationIdTypeKey * key)
// vtkIdType Get(vtkInformationIdTypeKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_1")] public static extern 
bool vtkInformation_Get_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIdTypeKey*)*/ key);

// void Remove(vtkInformationIdTypeKey * key)
// void Remove(vtkInformationIdTypeKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_3")] public static extern 
bool vtkInformation_Remove_3(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIdTypeKey*)*/ key);

// int Has(vtkInformationIdTypeKey * key)
// int Has(vtkInformationIdTypeKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_3")] public static extern 
bool vtkInformation_Has_3(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIdTypeKey*)*/ key);

// void Set(vtkInformationDoubleKey * key, double value)
// void Set(vtkInformationDoubleKey* key, double value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_3")] public static extern 
bool vtkInformation_Set_3(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleKey*)*/ key, double /*(double)*/ value);

// double Get(vtkInformationDoubleKey * key)
// double Get(vtkInformationDoubleKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_2")] public static extern 
bool vtkInformation_Get_2(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleKey*)*/ key);

// void Remove(vtkInformationDoubleKey * key)
// void Remove(vtkInformationDoubleKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_4")] public static extern 
bool vtkInformation_Remove_4(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleKey*)*/ key);

// int Has(vtkInformationDoubleKey * key)
// int Has(vtkInformationDoubleKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_4")] public static extern 
bool vtkInformation_Has_4(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleKey*)*/ key);

// void Remove(vtkInformationVariantKey * key)
// void Remove(vtkInformationVariantKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_5")] public static extern 
bool vtkInformation_Remove_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationVariantKey*)*/ key);

// int Has(vtkInformationVariantKey * key)
// int Has(vtkInformationVariantKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_5")] public static extern 
bool vtkInformation_Has_5(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationVariantKey*)*/ key);

// void Append(vtkInformationIntegerVectorKey * key, int value)
// void Append(vtkInformationIntegerVectorKey* key, int value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_1")] public static extern 
bool vtkInformation_Append_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value);

// void Set(vtkInformationIntegerVectorKey * key, const int * value, int length)
// void Set(vtkInformationIntegerVectorKey* key, const int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_4")] public static extern 
bool vtkInformation_Set_4(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// void Set(vtkInformationIntegerVectorKey * key, int value1, int value2, int value3)
// void Set(vtkInformationIntegerVectorKey* key, int value1, int value2, int value3)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_5")] public static extern 
bool vtkInformation_Set_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value1, int /*(int)*/ value2, int /*(int)*/ value3);

// void Set(vtkInformationIntegerVectorKey * key, int value1, int value2, int value3, int value4, int value5, int value6)
// void Set(vtkInformationIntegerVectorKey* key, int value1, int value2, int value3, int value4, int value5, int value6)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_6")] public static extern 
bool vtkInformation_Set_6(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ value1, int /*(int)*/ value2, int /*(int)*/ value3, int /*(int)*/ value4, int /*(int)*/ value5, int /*(int)*/ value6);

// int* Get(vtkInformationIntegerVectorKey * key)
// int* Get(vtkInformationIntegerVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_3")] public static extern 
bool vtkInformation_Get_3(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key);

// int Get(vtkInformationIntegerVectorKey * key, int idx)
// int Get(vtkInformationIntegerVectorKey* key, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_4")] public static extern 
bool vtkInformation_Get_4(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, int /*(int)*/ idx);

// void Get(vtkInformationIntegerVectorKey * key, int * value)
// void Get(vtkInformationIntegerVectorKey* key, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_5")] public static extern 
bool vtkInformation_Get_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key, IntPtr /*(int*)*/ value);

// int Length(vtkInformationIntegerVectorKey * key)
// int Length(vtkInformationIntegerVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_0")] public static extern 
bool vtkInformation_Length_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key);

// void Remove(vtkInformationIntegerVectorKey * key)
// void Remove(vtkInformationIntegerVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_6")] public static extern 
bool vtkInformation_Remove_6(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key);

// int Has(vtkInformationIntegerVectorKey * key)
// int Has(vtkInformationIntegerVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_6")] public static extern 
bool vtkInformation_Has_6(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key);

// void Append(vtkInformationStringVectorKey * key, const char * value)
// void Append(vtkInformationStringVectorKey* key, const char* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_2")] public static extern 
bool vtkInformation_Append_2(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key, IntPtr /*(char*)*/ value);

// void Set(vtkInformationStringVectorKey * key, const char * value, int idx = 0)
// void Set(vtkInformationStringVectorKey* key, const char* value, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_7")] public static extern 
bool vtkInformation_Set_7(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key, IntPtr /*(char*)*/ value, int /*(int)*/ idx);

// char* Get(vtkInformationStringVectorKey * key, int idx = 0)
// const char* Get(vtkInformationStringVectorKey* key, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_6")] public static extern 
bool vtkInformation_Get_6(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key, int /*(int)*/ idx);

// int Length(vtkInformationStringVectorKey * key)
// int Length(vtkInformationStringVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_1")] public static extern 
bool vtkInformation_Length_1(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key);

// void Remove(vtkInformationStringVectorKey * key)
// void Remove(vtkInformationStringVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_7")] public static extern 
bool vtkInformation_Remove_7(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key);

// int Has(vtkInformationStringVectorKey * key)
// int Has(vtkInformationStringVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_7")] public static extern 
bool vtkInformation_Has_7(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringVectorKey*)*/ key);

// void Set(vtkInformationIntegerPointerKey * key, int * value, int length)
// void Set(vtkInformationIntegerPointerKey* key, int* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_8")] public static extern 
bool vtkInformation_Set_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key, IntPtr /*(int*)*/ value, int /*(int)*/ length);

// int* Get(vtkInformationIntegerPointerKey * key)
// int* Get(vtkInformationIntegerPointerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_7")] public static extern 
bool vtkInformation_Get_7(IntPtr /*(int**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key);

// void Get(vtkInformationIntegerPointerKey * key, int * value)
// void Get(vtkInformationIntegerPointerKey* key, int* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_8")] public static extern 
bool vtkInformation_Get_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key, IntPtr /*(int*)*/ value);

// int Length(vtkInformationIntegerPointerKey * key)
// int Length(vtkInformationIntegerPointerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_2")] public static extern 
bool vtkInformation_Length_2(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key);

// void Remove(vtkInformationIntegerPointerKey * key)
// void Remove(vtkInformationIntegerPointerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_8")] public static extern 
bool vtkInformation_Remove_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key);

// int Has(vtkInformationIntegerPointerKey * key)
// int Has(vtkInformationIntegerPointerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_8")] public static extern 
bool vtkInformation_Has_8(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationIntegerPointerKey*)*/ key);

// void Set(vtkInformationUnsignedLongKey * key, unsigned long value)
// void Set(vtkInformationUnsignedLongKey* key, unsigned long value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_9")] public static extern 
bool vtkInformation_Set_9(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key, long /*(long)*/ value);

// long Get(vtkInformationUnsignedLongKey * key)
// unsigned long Get(vtkInformationUnsignedLongKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_9")] public static extern 
bool vtkInformation_Get_9(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key);

// void Remove(vtkInformationUnsignedLongKey * key)
// void Remove(vtkInformationUnsignedLongKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_9")] public static extern 
bool vtkInformation_Remove_9(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key);

// int Has(vtkInformationUnsignedLongKey * key)
// int Has(vtkInformationUnsignedLongKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_9")] public static extern 
bool vtkInformation_Has_9(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key);

// void Append(vtkInformationDoubleVectorKey * key, double value)
// void Append(vtkInformationDoubleVectorKey* key, double value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_3")] public static extern 
bool vtkInformation_Append_3(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value);

// void Set(vtkInformationDoubleVectorKey * key, const double * value, int length)
// void Set(vtkInformationDoubleVectorKey* key, const double* value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_10")] public static extern 
bool vtkInformation_Set_10(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, IntPtr /*(double*)*/ value, int /*(int)*/ length);

// void Set(vtkInformationDoubleVectorKey * key, double value1, double value2, double value3)
// void Set(vtkInformationDoubleVectorKey* key, double value1, double value2, double value3)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_11")] public static extern 
bool vtkInformation_Set_11(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value1, double /*(double)*/ value2, double /*(double)*/ value3);

// void Set(vtkInformationDoubleVectorKey * key, double value1, double value2, double value3, double value4, double value5, double value6)
// void Set(vtkInformationDoubleVectorKey* key, double value1, double value2, double value3, double value4, double value5, double value6)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_12")] public static extern 
bool vtkInformation_Set_12(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, double /*(double)*/ value1, double /*(double)*/ value2, double /*(double)*/ value3, double /*(double)*/ value4, double /*(double)*/ value5, double /*(double)*/ value6);

// double* Get(vtkInformationDoubleVectorKey * key)
// double* Get(vtkInformationDoubleVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_10")] public static extern 
bool vtkInformation_Get_10(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key);

// double Get(vtkInformationDoubleVectorKey * key, int idx)
// double Get(vtkInformationDoubleVectorKey* key, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_11")] public static extern 
bool vtkInformation_Get_11(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, int /*(int)*/ idx);

// void Get(vtkInformationDoubleVectorKey * key, double * value)
// void Get(vtkInformationDoubleVectorKey* key, double* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_12")] public static extern 
bool vtkInformation_Get_12(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key, IntPtr /*(double*)*/ value);

// int Length(vtkInformationDoubleVectorKey * key)
// int Length(vtkInformationDoubleVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_3")] public static extern 
bool vtkInformation_Length_3(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key);

// void Remove(vtkInformationDoubleVectorKey * key)
// void Remove(vtkInformationDoubleVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_10")] public static extern 
bool vtkInformation_Remove_10(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key);

// int Has(vtkInformationDoubleVectorKey * key)
// int Has(vtkInformationDoubleVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_10")] public static extern 
bool vtkInformation_Has_10(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key);

// int Length(vtkInformationVariantVectorKey * key)
// int Length(vtkInformationVariantVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_4")] public static extern 
bool vtkInformation_Length_4(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationVariantVectorKey*)*/ key);

// void Remove(vtkInformationVariantVectorKey * key)
// void Remove(vtkInformationVariantVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_11")] public static extern 
bool vtkInformation_Remove_11(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationVariantVectorKey*)*/ key);

// int Has(vtkInformationVariantVectorKey * key)
// int Has(vtkInformationVariantVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_11")] public static extern 
bool vtkInformation_Has_11(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationVariantVectorKey*)*/ key);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_4")] public static extern 
bool vtkInformation_Append_4(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_0")] public static extern 
bool vtkInformation_AppendUnique_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationKey*)*/ value);

// void Set(vtkInformationKeyVectorKey * key, vtkInformationKey *const* value, int length)
// void Set(vtkInformationKeyVectorKey* key, vtkInformationKey*const * value, int length)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_13")] public static extern 
bool vtkInformation_Set_13(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationKey*const*)*/ value, int /*(int)*/ length);

// void Remove(vtkInformationKeyVectorKey * key, vtkInformationKey * value)
// void Remove(vtkInformationKeyVectorKey* key, vtkInformationKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_12")] public static extern 
bool vtkInformation_Remove_12(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationKey*)*/ value);

// vtkInformationKey** Get(vtkInformationKeyVectorKey * key)
// vtkInformationKey** Get(vtkInformationKeyVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_13")] public static extern 
bool vtkInformation_Get_13(IntPtr /*(vtkInformationKey***)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key);

// vtkInformationKey* Get(vtkInformationKeyVectorKey * key, int idx)
// vtkInformationKey* Get(vtkInformationKeyVectorKey* key, int idx)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_14")] public static extern 
bool vtkInformation_Get_14(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, int /*(int)*/ idx);

// void Get(vtkInformationKeyVectorKey * key, vtkInformationKey ** value)
// void Get(vtkInformationKeyVectorKey* key, vtkInformationKey** value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_15")] public static extern 
bool vtkInformation_Get_15(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationKey**)*/ value);

// int Length(vtkInformationKeyVectorKey * key)
// int Length(vtkInformationKeyVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_5")] public static extern 
bool vtkInformation_Length_5(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key);

// void Remove(vtkInformationKeyVectorKey * key)
// void Remove(vtkInformationKeyVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_13")] public static extern 
bool vtkInformation_Remove_13(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key);

// int Has(vtkInformationKeyVectorKey * key)
// int Has(vtkInformationKeyVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_12")] public static extern 
bool vtkInformation_Has_12(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationDataObjectKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationDataObjectKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_5")] public static extern 
bool vtkInformation_Append_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDataObjectKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationDoubleKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationDoubleKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_6")] public static extern 
bool vtkInformation_Append_6(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDoubleKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationDoubleVectorKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationDoubleVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_7")] public static extern 
bool vtkInformation_Append_7(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDoubleVectorKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationInformationKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationInformationKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_8")] public static extern 
bool vtkInformation_Append_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationInformationKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationInformationVectorKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationInformationVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_9")] public static extern 
bool vtkInformation_Append_9(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationInformationVectorKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationIntegerKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationIntegerKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_10")] public static extern 
bool vtkInformation_Append_10(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationIntegerKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationIntegerVectorKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationIntegerVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_11")] public static extern 
bool vtkInformation_Append_11(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationIntegerVectorKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationStringKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationStringKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_12")] public static extern 
bool vtkInformation_Append_12(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationStringKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationStringVectorKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationStringVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_13")] public static extern 
bool vtkInformation_Append_13(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationStringVectorKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationObjectBaseKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationObjectBaseKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_14")] public static extern 
bool vtkInformation_Append_14(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationObjectBaseKey*)*/ value);

// void Append(vtkInformationKeyVectorKey * key, vtkInformationUnsignedLongKey * value)
// void Append(vtkInformationKeyVectorKey* key, vtkInformationUnsignedLongKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_15")] public static extern 
bool vtkInformation_Append_15(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationUnsignedLongKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDataObjectKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDataObjectKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_1")] public static extern 
bool vtkInformation_AppendUnique_1(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDataObjectKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDoubleKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDoubleKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_2")] public static extern 
bool vtkInformation_AppendUnique_2(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDoubleKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationDoubleVectorKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationDoubleVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_3")] public static extern 
bool vtkInformation_AppendUnique_3(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationDoubleVectorKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationInformationKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationInformationKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_4")] public static extern 
bool vtkInformation_AppendUnique_4(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationInformationKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationInformationVectorKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationInformationVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_5")] public static extern 
bool vtkInformation_AppendUnique_5(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationInformationVectorKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationIntegerKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationIntegerKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_6")] public static extern 
bool vtkInformation_AppendUnique_6(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationIntegerKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationIntegerVectorKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationIntegerVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_7")] public static extern 
bool vtkInformation_AppendUnique_7(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationIntegerVectorKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationStringKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationStringKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_8")] public static extern 
bool vtkInformation_AppendUnique_8(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationStringKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationStringVectorKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationStringVectorKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_9")] public static extern 
bool vtkInformation_AppendUnique_9(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationStringVectorKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationObjectBaseKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationObjectBaseKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_10")] public static extern 
bool vtkInformation_AppendUnique_10(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationObjectBaseKey*)*/ value);

// void AppendUnique(vtkInformationKeyVectorKey * key, vtkInformationUnsignedLongKey * value)
// void AppendUnique(vtkInformationKeyVectorKey* key, vtkInformationUnsignedLongKey* value)
[DllImport("vtkplugin", EntryPoint="vtkInformation_AppendUnique_11")] public static extern 
bool vtkInformation_AppendUnique_11(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationKeyVectorKey*)*/ key, IntPtr /*(vtkInformationUnsignedLongKey*)*/ value);

// void Set(vtkInformationStringKey * key, const char * ARG_0)
// void Set(vtkInformationStringKey* key, const char*)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_14")] public static extern 
bool vtkInformation_Set_14(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringKey*)*/ key, IntPtr /*(char*)*/ ARG_0);

// char* Get(vtkInformationStringKey * key)
// const char* Get(vtkInformationStringKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_16")] public static extern 
bool vtkInformation_Get_16(IntPtr /*(char**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringKey*)*/ key);

// void Remove(vtkInformationStringKey * key)
// void Remove(vtkInformationStringKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_14")] public static extern 
bool vtkInformation_Remove_14(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringKey*)*/ key);

// int Has(vtkInformationStringKey * key)
// int Has(vtkInformationStringKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_13")] public static extern 
bool vtkInformation_Has_13(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationStringKey*)*/ key);

// void Set(vtkInformationInformationKey * key, vtkInformation * ARG_0)
// void Set(vtkInformationInformationKey* key, vtkInformation*)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_15")] public static extern 
bool vtkInformation_Set_15(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationKey*)*/ key, IntPtr /*(vtkInformation*)*/ ARG_0);

// vtkInformation* Get(vtkInformationInformationKey * key)
// vtkInformation* Get(vtkInformationInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_17")] public static extern 
bool vtkInformation_Get_17(IntPtr /*(vtkInformation**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationKey*)*/ key);

// void Remove(vtkInformationInformationKey * key)
// void Remove(vtkInformationInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_15")] public static extern 
bool vtkInformation_Remove_15(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationKey*)*/ key);

// int Has(vtkInformationInformationKey * key)
// int Has(vtkInformationInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_14")] public static extern 
bool vtkInformation_Has_14(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationKey*)*/ key);

// void Set(vtkInformationInformationVectorKey * key, vtkInformationVector * ARG_0)
// void Set(vtkInformationInformationVectorKey* key, vtkInformationVector*)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_16")] public static extern 
bool vtkInformation_Set_16(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationVectorKey*)*/ key, IntPtr /*(vtkInformationVector*)*/ ARG_0);

// vtkInformationVector* Get(vtkInformationInformationVectorKey * key)
// vtkInformationVector* Get(vtkInformationInformationVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_18")] public static extern 
bool vtkInformation_Get_18(IntPtr /*(vtkInformationVector**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationVectorKey*)*/ key);

// void Remove(vtkInformationInformationVectorKey * key)
// void Remove(vtkInformationInformationVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_16")] public static extern 
bool vtkInformation_Remove_16(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationVectorKey*)*/ key);

// int Has(vtkInformationInformationVectorKey * key)
// int Has(vtkInformationInformationVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_15")] public static extern 
bool vtkInformation_Has_15(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationInformationVectorKey*)*/ key);

// void Set(vtkInformationObjectBaseKey * key, vtkObjectBase * ARG_0)
// void Set(vtkInformationObjectBaseKey* key, vtkObjectBase*)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_17")] public static extern 
bool vtkInformation_Set_17(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseKey*)*/ key, IntPtr /*(vtkObjectBase*)*/ ARG_0);

// vtkObjectBase* Get(vtkInformationObjectBaseKey * key)
// vtkObjectBase* Get(vtkInformationObjectBaseKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_19")] public static extern 
bool vtkInformation_Get_19(IntPtr /*(vtkObjectBase**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseKey*)*/ key);

// void Remove(vtkInformationObjectBaseKey * key)
// void Remove(vtkInformationObjectBaseKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_17")] public static extern 
bool vtkInformation_Remove_17(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseKey*)*/ key);

// int Has(vtkInformationObjectBaseKey * key)
// int Has(vtkInformationObjectBaseKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_16")] public static extern 
bool vtkInformation_Has_16(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseKey*)*/ key);

// void Append(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * data)
// void Append(vtkInformationObjectBaseVectorKey* key, vtkObjectBase *data)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Append_16")] public static extern 
bool vtkInformation_Append_16(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, IntPtr /*(vtkObjectBase*)*/ data);

// void Set(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * value, int idx = 0)
// void Set(vtkInformationObjectBaseVectorKey *key, vtkObjectBase* value, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_18")] public static extern 
bool vtkInformation_Set_18(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, IntPtr /*(vtkObjectBase*)*/ value, int /*(int)*/ idx);

// vtkObjectBase* Get(vtkInformationObjectBaseVectorKey * key, int idx = 0)
// vtkObjectBase* Get(vtkInformationObjectBaseVectorKey *key, int idx = 0)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Get_20")] public static extern 
bool vtkInformation_Get_20(IntPtr /*(vtkObjectBase**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ idx);

// int Length(vtkInformationObjectBaseVectorKey * key)
// int Length(vtkInformationObjectBaseVectorKey *key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Length_6")] public static extern 
bool vtkInformation_Length_6(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key);

// void Remove(vtkInformationObjectBaseVectorKey * key)
// void Remove(vtkInformationObjectBaseVectorKey *key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_18")] public static extern 
bool vtkInformation_Remove_18(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key);

// void Remove(vtkInformationObjectBaseVectorKey * key, vtkObjectBase * objectToRemove)
// void Remove(vtkInformationObjectBaseVectorKey *key, vtkObjectBase *objectToRemove)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_19")] public static extern 
bool vtkInformation_Remove_19(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, IntPtr /*(vtkObjectBase*)*/ objectToRemove);

// void Remove(vtkInformationObjectBaseVectorKey * key, int indexToRemove)
// void Remove(vtkInformationObjectBaseVectorKey *key, int indexToRemove)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_20")] public static extern 
bool vtkInformation_Remove_20(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key, int /*(int)*/ indexToRemove);

// int Has(vtkInformationObjectBaseVectorKey * key)
// int Has(vtkInformationObjectBaseVectorKey *key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_17")] public static extern 
bool vtkInformation_Has_17(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationObjectBaseVectorKey*)*/ key);

// void Set(vtkInformationDataObjectKey * key, vtkDataObject * ARG_0)
// void Set(vtkInformationDataObjectKey* key, vtkDataObject *)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Set_19")] public static extern 
bool vtkInformation_Set_19(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDataObjectKey*)*/ key, IntPtr /*(vtkDataObject*)*/ ARG_0);

// void Remove(vtkInformationDataObjectKey * key)
// void Remove(vtkInformationDataObjectKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Remove_21")] public static extern 
bool vtkInformation_Remove_21(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDataObjectKey*)*/ key);

// int Has(vtkInformationDataObjectKey * key)
// int Has(vtkInformationDataObjectKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Has_18")] public static extern 
bool vtkInformation_Has_18(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationDataObjectKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationDataObjectKey * key)
// static vtkInformationKey* GetKey(vtkInformationDataObjectKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_0")] public static extern 
bool vtkInformation_GetKey_0(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationDataObjectKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationDoubleKey * key)
// static vtkInformationKey* GetKey(vtkInformationDoubleKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_1")] public static extern 
bool vtkInformation_GetKey_1(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationDoubleKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationDoubleVectorKey * key)
// static vtkInformationKey* GetKey(vtkInformationDoubleVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_2")] public static extern 
bool vtkInformation_GetKey_2(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationDoubleVectorKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationInformationKey * key)
// static vtkInformationKey* GetKey(vtkInformationInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_3")] public static extern 
bool vtkInformation_GetKey_3(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationInformationKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationInformationVectorKey * key)
// static vtkInformationKey* GetKey(vtkInformationInformationVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_4")] public static extern 
bool vtkInformation_GetKey_4(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationInformationVectorKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationIntegerKey * key)
// static vtkInformationKey* GetKey(vtkInformationIntegerKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_5")] public static extern 
bool vtkInformation_GetKey_5(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationIntegerKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationIntegerVectorKey * key)
// static vtkInformationKey* GetKey(vtkInformationIntegerVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_6")] public static extern 
bool vtkInformation_GetKey_6(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationIntegerVectorKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationRequestKey * key)
// static vtkInformationKey* GetKey(vtkInformationRequestKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_7")] public static extern 
bool vtkInformation_GetKey_7(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationRequestKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationStringKey * key)
// static vtkInformationKey* GetKey(vtkInformationStringKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_8")] public static extern 
bool vtkInformation_GetKey_8(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationStringKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationStringVectorKey * key)
// static vtkInformationKey* GetKey(vtkInformationStringVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_9")] public static extern 
bool vtkInformation_GetKey_9(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationStringVectorKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationKey * key)
// static vtkInformationKey* GetKey(vtkInformationKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_10")] public static extern 
bool vtkInformation_GetKey_10(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationUnsignedLongKey * key)
// static vtkInformationKey* GetKey(vtkInformationUnsignedLongKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_11")] public static extern 
bool vtkInformation_GetKey_11(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationUnsignedLongKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationVariantKey * key)
// static vtkInformationKey* GetKey(vtkInformationVariantKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_12")] public static extern 
bool vtkInformation_GetKey_12(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationVariantKey*)*/ key);

// static vtkInformationKey* GetKey(vtkInformationVariantVectorKey * key)
// static vtkInformationKey* GetKey(vtkInformationVariantVectorKey* key)
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetKey_13")] public static extern 
bool vtkInformation_GetKey_13(IntPtr /*(vtkInformationKey**)*/ return_value, IntPtr /*(vtkInformationVariantVectorKey*)*/ key);

// void Register(vtkObjectBase * o)
// void Register(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformation_Register_0")] public static extern 
bool vtkInformation_Register_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase* o)
[DllImport("vtkplugin", EntryPoint="vtkInformation_UnRegister_0")] public static extern 
bool vtkInformation_UnRegister_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void SetRequest(vtkInformationRequestKey * request)
// void SetRequest(vtkInformationRequestKey* request)
[DllImport("vtkplugin", EntryPoint="vtkInformation_SetRequest_0")] public static extern 
bool vtkInformation_SetRequest_0(IntPtr /*(vtkInformation*)*/ callingObject, IntPtr /*(vtkInformationRequestKey*)*/ request);

// vtkInformationRequestKey* GetRequest()
// vtkInformationRequestKey* GetRequest()
[DllImport("vtkplugin", EntryPoint="vtkInformation_GetRequest_0")] public static extern 
bool vtkInformation_GetRequest_0(IntPtr /*(vtkInformationRequestKey**)*/ return_value, IntPtr /*(vtkInformation*)*/ callingObject);

}
};
