
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkStringArray {

// static vtkStringArray* New()
// static vtkStringArray* New()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_New_0")] public static extern 
bool New_0(IntPtr /*(vtkStringArray**)*/ return_value);

// int GetDataType()
// int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetDataType_0")] public static extern 
bool GetDataType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// int IsNumeric()
// int IsNumeric()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_IsNumeric_0")] public static extern 
bool IsNumeric_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkStringArray*)*/ callingObject);

// int GetDataTypeSize()
// int GetDataTypeSize()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetDataTypeSize_0")] public static extern 
bool GetDataTypeSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// void Squeeze()
// void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkStringArray*)*/ callingObject);

// int Resize(vtkIdType numTuples)
// int Resize(vtkIdType numTuples)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_Resize_0")] public static extern 
bool Resize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ numTuples);

// void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetTuple_0")] public static extern 
bool SetTuple_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, IntPtr /*(vtkAbstractArray*)*/ source);

// void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertTuple_0")] public static extern 
bool InsertTuple_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, IntPtr /*(vtkAbstractArray*)*/ source);

// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertTuples_0")] public static extern 
bool InsertTuples_0(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ dstIds, IntPtr /*(vtkIdList*)*/ srcIds, IntPtr /*(vtkAbstractArray*)*/ source);

// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertTuples_1")] public static extern 
bool InsertTuples_1(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, IntPtr /*(vtkAbstractArray*)*/ source);

// vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray * source)
// vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertNextTuple_0")] public static extern 
bool InsertNextTuple_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ j, IntPtr /*(vtkAbstractArray*)*/ source);

// void InterpolateTuple(vtkIdType i, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// void InterpolateTuple(vtkIdType i, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InterpolateTuple_0")] public static extern 
bool InterpolateTuple_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ i, IntPtr /*(vtkIdList*)*/ ptIndices, IntPtr /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights);

// void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray * source1, vtkIdType id2, vtkAbstractArray * source2, double t)
// void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InterpolateTuple_1")] public static extern 
bool InterpolateTuple_1(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ id1, IntPtr /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ id2, IntPtr /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t);

// void GetTuples(vtkIdList * ptIds, vtkAbstractArray * output)
// void GetTuples(vtkIdList *ptIds, vtkAbstractArray *output)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetTuples_0")] public static extern 
bool GetTuples_0(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ ptIds, IntPtr /*(vtkAbstractArray*)*/ output);

// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetTuples_1")] public static extern 
bool GetTuples_1(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, IntPtr /*(vtkAbstractArray*)*/ output);

// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// int Allocate( vtkIdType sz, vtkIdType ext=1000 )
[DllImport("vtkplugin", EntryPoint="vtkStringArray_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext);

// vtkStdString& GetValue(vtkIdType id)
// vtkStdString &GetValue(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetValue_0")] public static extern 
bool GetValue_0(IntPtr /*(vtkStdString*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void SetValue(vtkIdType id, vtkStdString value)
// void SetValue(vtkIdType id, vtkStdString value)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetValue_0")] public static extern 
bool SetValue_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ value);

// void SetValue(vtkIdType id, const char * value)
// void SetValue(vtkIdType id, const char *value)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetValue_1")] public static extern 
bool SetValue_1(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id, IntPtr /*(char*)*/ value);

// void SetNumberOfTuples(vtkIdType number)
// void SetNumberOfTuples(vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetNumberOfTuples_0")] public static extern 
bool SetNumberOfTuples_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ number);

// void SetNumberOfValues(vtkIdType number)
// void SetNumberOfValues(vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetNumberOfValues_0")] public static extern 
bool SetNumberOfValues_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ number);

// vtkIdType GetNumberOfValues()
// vtkIdType GetNumberOfValues()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetNumberOfValues_0")] public static extern 
bool GetNumberOfValues_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// int GetNumberOfElementComponents()
// int GetNumberOfElementComponents()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetNumberOfElementComponents_0")] public static extern 
bool GetNumberOfElementComponents_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// int GetElementComponentSize()
// int GetElementComponentSize()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetElementComponentSize_0")] public static extern 
bool GetElementComponentSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// void InsertValue(vtkIdType id, vtkStdString f)
// void InsertValue(vtkIdType id, vtkStdString f)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertValue_0")] public static extern 
bool InsertValue_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ f);

// void InsertValue(vtkIdType id, const char * val)
// void InsertValue(vtkIdType id, const char *val)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertValue_1")] public static extern 
bool InsertValue_1(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id, IntPtr /*(char*)*/ val);

// vtkIdType InsertNextValue(vtkStdString f)
// vtkIdType InsertNextValue(vtkStdString f)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertNextValue_0")] public static extern 
bool InsertNextValue_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, string /*(vtkStdString)*/ f);

// vtkIdType InsertNextValue(const char * f)
// vtkIdType InsertNextValue(const char *f)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_InsertNextValue_1")] public static extern 
bool InsertNextValue_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(char*)*/ f);

// vtkStdString* WritePointer(vtkIdType id, vtkIdType number)
// vtkStdString* WritePointer(vtkIdType id, vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_WritePointer_0")] public static extern 
bool WritePointer_0(IntPtr /*(vtkStdString**)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id, long /*(vtkIdType)*/ number);

// vtkStdString* GetPointer(vtkIdType id)
// vtkStdString* GetPointer(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetPointer_0")] public static extern 
bool GetPointer_0(IntPtr /*(vtkStdString**)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void* GetVoidPointer(vtkIdType id)
// void* GetVoidPointer(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetVoidPointer_0")] public static extern 
bool GetVoidPointer_0(IntPtr /*(void**)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void DeepCopy(vtkAbstractArray * aa)
// void DeepCopy( vtkAbstractArray* aa )
[DllImport("vtkplugin", EntryPoint="vtkStringArray_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ aa);

// void SetArray(vtkStdString * array, vtkIdType size, int save)
// void SetArray(vtkStdString* array, vtkIdType size, int save)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetArray_0")] public static extern 
bool SetArray_0(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkStdString*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save);

// void SetVoidArray(void * array, vtkIdType size, int save)
// void SetVoidArray(void* array, vtkIdType size, int save)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_SetVoidArray_0")] public static extern 
bool SetVoidArray_0(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// vtkIdType GetDataSize()
// vtkIdType GetDataSize()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_GetDataSize_0")] public static extern 
bool GetDataSize_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject);

// vtkIdType LookupValue(const vtkStdString & value)
// vtkIdType LookupValue(const vtkStdString& value)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_LookupValue_0")] public static extern 
bool LookupValue_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkStdString&)*/ value);

// void LookupValue(const vtkStdString & value, vtkIdList * ids)
// void LookupValue(const vtkStdString& value, vtkIdList* ids)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_LookupValue_1")] public static extern 
bool LookupValue_1(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(vtkStdString&)*/ value, IntPtr /*(vtkIdList*)*/ ids);

// vtkIdType LookupValue(const char * value)
// vtkIdType LookupValue(const char* value)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_LookupValue_2")] public static extern 
bool LookupValue_2(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(char*)*/ value);

// void LookupValue(const char * value, vtkIdList * ids)
// void LookupValue(const char* value, vtkIdList* ids)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_LookupValue_3")] public static extern 
bool LookupValue_3(IntPtr /*(vtkStringArray*)*/ callingObject, IntPtr /*(char*)*/ value, IntPtr /*(vtkIdList*)*/ ids);

// void DataChanged()
// void DataChanged()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_DataChanged_0")] public static extern 
bool DataChanged_0(IntPtr /*(vtkStringArray*)*/ callingObject);

// virtual void DataElementChanged(vtkIdType id)
// virtual void DataElementChanged(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkStringArray_DataElementChanged_0")] public static extern 
bool DataElementChanged_0(IntPtr /*(vtkStringArray*)*/ callingObject, long /*(vtkIdType)*/ id);

// void ClearLookup()
// void ClearLookup()
[DllImport("vtkplugin", EntryPoint="vtkStringArray_ClearLookup_0")] public static extern 
bool ClearLookup_0(IntPtr /*(vtkStringArray*)*/ callingObject);

}
};
