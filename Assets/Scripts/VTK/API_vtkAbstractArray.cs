
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkAbstractArray {

//       Method: virtual const char * vtkAbstractArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual int vtkAbstractArray::Allocate(vtkIdType numValues, vtkIdType ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj, long numValues, long ext);

//       Method: virtual void vtkAbstractArray::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual int vtkAbstractArray::GetDataType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetDataType_0")] public static extern 
bool GetDataType(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual int vtkAbstractArray::GetDataTypeSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetDataTypeSize_0")] public static extern 
bool GetDataTypeSize(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: static int vtkAbstractArray::GetDataTypeSize(int type)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_GetDataTypeSize_1")] public static extern 
bool GetDataTypeSize(IntPtr /*int* */ ret, int type);

//       Method: virtual int vtkAbstractArray::GetElementComponentSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetElementComponentSize_0")] public static extern 
bool GetElementComponentSize(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: int vtkAbstractArray::GetNumberOfComponents()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetNumberOfComponents_0")] public static extern 
bool GetNumberOfComponents(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: void vtkAbstractArray::SetComponentName(vtkIdType component, const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_SetComponentName_0")] public static extern 
bool SetComponentName(IntPtr /*vtkAbstractArray* */ obj, long component, string/*const char* */ name);

//       Method: const char * vtkAbstractArray::GetComponentName(vtkIdType component)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetComponentName_0")] public static extern 
bool GetComponentName(IntPtr /*const char** */ ret, IntPtr /*vtkAbstractArray* */ obj, long component);

//       Method: bool vtkAbstractArray::HasAComponentName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_HasAComponentName_0")] public static extern 
bool HasAComponentName(IntPtr /*bool* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: int vtkAbstractArray::CopyComponentNames(vtkAbstractArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_CopyComponentNames_0")] public static extern 
bool CopyComponentNames(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj, IntPtr/*vtkAbstractArray* */ da);

//       Method: virtual void vtkAbstractArray::SetNumberOfTuples(vtkIdType numTuples)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_SetNumberOfTuples_0")] public static extern 
bool SetNumberOfTuples(IntPtr /*vtkAbstractArray* */ obj, long numTuples);

//       Method: virtual void vtkAbstractArray::SetNumberOfValues(vtkIdType numValues)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_SetNumberOfValues_0")] public static extern 
bool SetNumberOfValues(IntPtr /*vtkAbstractArray* */ obj, long numValues);

//       Method: vtkIdType vtkAbstractArray::GetNumberOfTuples()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetNumberOfTuples_0")] public static extern 
bool GetNumberOfTuples(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual void vtkAbstractArray::SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_SetTuple_0")] public static extern 
bool SetTuple(IntPtr /*vtkAbstractArray* */ obj, long dstTupleIdx, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual void vtkAbstractArray::InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InsertTuple_0")] public static extern 
bool InsertTuple(IntPtr /*vtkAbstractArray* */ obj, long dstTupleIdx, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual void vtkAbstractArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InsertTuples_0")] public static extern 
bool InsertTuples(IntPtr /*vtkAbstractArray* */ obj, IntPtr/*vtkIdList* */ dstIds, IntPtr/*vtkIdList* */ srcIds, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual void vtkAbstractArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InsertTuples_1")] public static extern 
bool InsertTuples(IntPtr /*vtkAbstractArray* */ obj, long dstStart, long n, long srcStart, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual vtkIdType vtkAbstractArray::InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InsertNextTuple_0")] public static extern 
bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractArray* */ obj, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual void vtkAbstractArray::GetTuples(vtkIdList* tupleIds, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetTuples_0")] public static extern 
bool GetTuples(IntPtr /*vtkAbstractArray* */ obj, IntPtr/*vtkIdList* */ tupleIds, IntPtr/*vtkAbstractArray* */ output);

//       Method: virtual void vtkAbstractArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetTuples_1")] public static extern 
bool GetTuples(IntPtr /*vtkAbstractArray* */ obj, long p1, long p2, IntPtr/*vtkAbstractArray* */ output);

//       Method: virtual bool vtkAbstractArray::HasStandardMemoryLayout()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_HasStandardMemoryLayout_0")] public static extern 
bool HasStandardMemoryLayout(IntPtr /*bool* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual void * vtkAbstractArray::GetVoidPointer(vtkIdType valueIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetVoidPointer_0")] public static extern 
bool GetVoidPointer(IntPtr /*vtkAbstractArray* */ obj, long valueIdx);

//       Method: virtual void vtkAbstractArray::DeepCopy(vtkAbstractArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkAbstractArray* */ obj, IntPtr/*vtkAbstractArray* */ da);

//       Method: virtual void vtkAbstractArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InterpolateTuple_0")] public static extern 
bool InterpolateTuple(IntPtr /*vtkAbstractArray* */ obj, long dstTupleIdx, IntPtr/*vtkIdList* */ ptIndices, IntPtr/*vtkAbstractArray* */ source, IntPtr/*double* */ weights);

//       Method: virtual void vtkAbstractArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_InterpolateTuple_1")] public static extern 
bool InterpolateTuple(IntPtr /*vtkAbstractArray* */ obj, long dstTupleIdx, long srcTupleIdx1, IntPtr/*vtkAbstractArray* */ source1, long srcTupleIdx2, IntPtr/*vtkAbstractArray* */ source2, double t);

//       Method: virtual void vtkAbstractArray::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual int vtkAbstractArray::Resize(vtkIdType numTuples)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Resize_0")] public static extern 
bool Resize(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj, long numTuples);

//       Method: void vtkAbstractArray::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkAbstractArray* */ obj);

//       Method: vtkIdType vtkAbstractArray::GetSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetSize_0")] public static extern 
bool GetSize(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: vtkIdType vtkAbstractArray::GetMaxId()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetMaxId_0")] public static extern 
bool GetMaxId(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual void vtkAbstractArray::ExportToVoidPointer(void* out_ptr)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_ExportToVoidPointer_0")] public static extern 
bool ExportToVoidPointer(IntPtr /*vtkAbstractArray* */ obj, IntPtr/*void* */ out_ptr);

//       Method: static vtkAbstractArray * vtkAbstractArray::CreateArray(int dataType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_CreateArray_0")] public static extern 
bool CreateArray(IntPtr /*vtkAbstractArray** */ ret, int dataType);

//       Method: virtual int vtkAbstractArray::IsNumeric()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_IsNumeric_0")] public static extern 
bool IsNumeric(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual vtkArrayIterator * vtkAbstractArray::NewIterator()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_NewIterator_0")] public static extern 
bool NewIterator(IntPtr /*vtkArrayIterator** */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual vtkIdType vtkAbstractArray::GetDataSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetDataSize_0")] public static extern 
bool GetDataSize(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual void vtkAbstractArray::DataChanged()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_DataChanged_0")] public static extern 
bool DataChanged(IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual void vtkAbstractArray::ClearLookup()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_ClearLookup_0")] public static extern 
bool ClearLookup(IntPtr /*vtkAbstractArray* */ obj);

//       Method: vtkInformation * vtkAbstractArray::GetInformation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetInformation_0")] public static extern 
bool GetInformation(IntPtr /*vtkInformation** */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: bool vtkAbstractArray::HasInformation()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_HasInformation_0")] public static extern 
bool HasInformation(IntPtr /*bool* */ ret, IntPtr /*vtkAbstractArray* */ obj);

//       Method: virtual int vtkAbstractArray::CopyInformation(vtkInformation* infoFrom, int deep)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_CopyInformation_0")] public static extern 
bool CopyInformation(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj, IntPtr/*vtkInformation* */ infoFrom, int deep);

//       Method: static vtkInformationIntegerKey * vtkAbstractArray::GUI_HIDE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_GUI_HIDE_0")] public static extern 
bool GUI_HIDE(IntPtr /*vtkInformationIntegerKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkAbstractArray::PER_COMPONENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_PER_COMPONENT_0")] public static extern 
bool PER_COMPONENT(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: static vtkInformationInformationVectorKey * vtkAbstractArray::PER_FINITE_COMPONENT()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_PER_FINITE_COMPONENT_0")] public static extern 
bool PER_FINITE_COMPONENT(IntPtr /*vtkInformationInformationVectorKey** */ ret);

//       Method: void vtkAbstractArray::Modified()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_Modified_0")] public static extern 
bool Modified(IntPtr /*vtkAbstractArray* */ obj);

//       Method: static vtkInformationVariantVectorKey * vtkAbstractArray::DISCRETE_VALUES()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_DISCRETE_VALUES_0")] public static extern 
bool DISCRETE_VALUES(IntPtr /*vtkInformationVariantVectorKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkAbstractArray::DISCRETE_VALUE_SAMPLE_PARAMETERS()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_0")] public static extern 
bool DISCRETE_VALUE_SAMPLE_PARAMETERS(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: virtual int vtkAbstractArray::GetArrayType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkAbstractArray_GetArrayType_0")] public static extern 
bool GetArrayType(IntPtr /*int* */ ret, IntPtr /*vtkAbstractArray* */ obj);

}
};
