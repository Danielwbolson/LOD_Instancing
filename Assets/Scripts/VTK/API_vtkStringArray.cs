
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkStringArray {

//       Method: static vtkStringArray * vtkStringArray::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkStringArray_New_0")] public static extern 
bool New(IntPtr /*vtkStringArray** */ ret);

//       Method: virtual const char * vtkStringArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::GetDataType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetDataType_0")] public static extern 
bool GetDataType(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::IsNumeric()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_IsNumeric_0")] public static extern 
bool IsNumeric(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: void vtkStringArray::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::GetDataTypeSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetDataTypeSize_0")] public static extern 
bool GetDataTypeSize(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: void vtkStringArray::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::Resize(vtkIdType numTuples)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_Resize_0")] public static extern 
bool Resize(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj, long numTuples);

//       Method: void vtkStringArray::SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_SetTuple_0")] public static extern 
bool SetTuple(IntPtr /*vtkStringArray* */ obj, long i, long j, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkStringArray::InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertTuple_0")] public static extern 
bool InsertTuple(IntPtr /*vtkStringArray* */ obj, long i, long j, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkStringArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertTuples_0")] public static extern 
bool InsertTuples(IntPtr /*vtkStringArray* */ obj, IntPtr/*vtkIdList* */ dstIds, IntPtr/*vtkIdList* */ srcIds, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkStringArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertTuples_1")] public static extern 
bool InsertTuples(IntPtr /*vtkStringArray* */ obj, long dstStart, long n, long srcStart, IntPtr/*vtkAbstractArray* */ source);

//       Method: vtkIdType vtkStringArray::InsertNextTuple(vtkIdType j, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertNextTuple_0")] public static extern 
bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkStringArray* */ obj, long j, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkStringArray::InterpolateTuple(vtkIdType i, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InterpolateTuple_0")] public static extern 
bool InterpolateTuple(IntPtr /*vtkStringArray* */ obj, long i, IntPtr/*vtkIdList* */ ptIndices, IntPtr/*vtkAbstractArray* */ source, IntPtr/*double* */ weights);

//       Method: void vtkStringArray::InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InterpolateTuple_1")] public static extern 
bool InterpolateTuple(IntPtr /*vtkStringArray* */ obj, long i, long id1, IntPtr/*vtkAbstractArray* */ source1, long id2, IntPtr/*vtkAbstractArray* */ source2, double t);

//       Method: void vtkStringArray::GetTuples(vtkIdList* ptIds, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetTuples_0")] public static extern 
bool GetTuples(IntPtr /*vtkStringArray* */ obj, IntPtr/*vtkIdList* */ ptIds, IntPtr/*vtkAbstractArray* */ output);

//       Method: void vtkStringArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetTuples_1")] public static extern 
bool GetTuples(IntPtr /*vtkStringArray* */ obj, long p1, long p2, IntPtr/*vtkAbstractArray* */ output);

//       Method: int vtkStringArray::Allocate(vtkIdType sz, vtkIdType ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj, long sz, long ext);

//       Method: void vtkStringArray::SetValue(vtkIdType id, const char* value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_SetValue_0")] public static extern 
bool SetValue(IntPtr /*vtkStringArray* */ obj, long id, string/*const char* */ value);

//       Method: void vtkStringArray::SetNumberOfTuples(vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_SetNumberOfTuples_0")] public static extern 
bool SetNumberOfTuples(IntPtr /*vtkStringArray* */ obj, long number);

//       Method: void vtkStringArray::SetNumberOfValues(vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_SetNumberOfValues_0")] public static extern 
bool SetNumberOfValues(IntPtr /*vtkStringArray* */ obj, long number);

//       Method: vtkIdType vtkStringArray::GetNumberOfValues()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetNumberOfValues_0")] public static extern 
bool GetNumberOfValues(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::GetNumberOfElementComponents()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetNumberOfElementComponents_0")] public static extern 
bool GetNumberOfElementComponents(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: int vtkStringArray::GetElementComponentSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetElementComponentSize_0")] public static extern 
bool GetElementComponentSize(IntPtr /*int* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: void vtkStringArray::InsertValue(vtkIdType id, const char* val)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertValue_0")] public static extern 
bool InsertValue(IntPtr /*vtkStringArray* */ obj, long id, string/*const char* */ val);

//       Method: vtkIdType vtkStringArray::InsertNextValue(const char* f)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_InsertNextValue_0")] public static extern 
bool InsertNextValue(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkStringArray* */ obj, string/*const char* */ f);

//       Method: void * vtkStringArray::GetVoidPointer(vtkIdType id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetVoidPointer_0")] public static extern 
bool GetVoidPointer(IntPtr /*vtkStringArray* */ obj, long id);

//       Method: void vtkStringArray::DeepCopy(vtkAbstractArray* aa)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkStringArray* */ obj, IntPtr/*vtkAbstractArray* */ aa);

//       Method: void vtkStringArray::SetVoidArray(void* array, vtkIdType size, int save)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_SetVoidArray_0")] public static extern 
bool SetVoidArray(IntPtr /*vtkStringArray* */ obj, IntPtr/*void* */ array, long size, int save);

//       Method: vtkIdType vtkStringArray::GetDataSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_GetDataSize_0")] public static extern 
bool GetDataSize(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkStringArray* */ obj);

//       Method: vtkIdType vtkStringArray::LookupValue(const char* value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_LookupValue_0")] public static extern 
bool LookupValue(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkStringArray* */ obj, string/*const char* */ value);

//       Method: void vtkStringArray::LookupValue(const char* value, vtkIdList* ids)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_LookupValue_1")] public static extern 
bool LookupValue(IntPtr /*vtkStringArray* */ obj, string/*const char* */ value, IntPtr/*vtkIdList* */ ids);

//       Method: void vtkStringArray::DataChanged()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_DataChanged_0")] public static extern 
bool DataChanged(IntPtr /*vtkStringArray* */ obj);

//       Method: virtual void vtkStringArray::DataElementChanged(vtkIdType id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_DataElementChanged_0")] public static extern 
bool DataElementChanged(IntPtr /*vtkStringArray* */ obj, long id);

//       Method: void vtkStringArray::ClearLookup()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkStringArray_ClearLookup_0")] public static extern 
bool ClearLookup(IntPtr /*vtkStringArray* */ obj);

}
};
