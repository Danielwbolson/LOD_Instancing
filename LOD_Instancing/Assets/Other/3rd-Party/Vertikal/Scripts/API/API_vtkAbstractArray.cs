
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractArray* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractArray* NewInstance()
// vtkAbstractArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int Allocate(vtkIdType numValues, vtkIdType ext = 1000)
// virtual int Allocate(vtkIdType numValues, vtkIdType ext=1000)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ numValues, long /*(vtkIdType)*/ ext);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int GetDataType()
// virtual int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetDataType_0")] public static extern 
bool GetDataType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int GetDataTypeSize()
// virtual int GetDataTypeSize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetDataTypeSize_0")] public static extern 
bool GetDataTypeSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// static int GetDataTypeSize(int type)
// static int GetDataTypeSize(int type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetDataTypeSize_1")] public static extern 
bool GetDataTypeSize_1(IntPtr /*(IntPtr*)*/ return_value, int /*(int)*/ type);

// virtual int GetElementComponentSize()
// virtual int GetElementComponentSize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetElementComponentSize_0")] public static extern 
bool GetElementComponentSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void SetNumberOfComponents(int _arg)
// virtual void SetNumberOfComponents (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetNumberOfComponents_0")] public static extern 
bool SetNumberOfComponents_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfComponentsMinValue()
// virtual int GetNumberOfComponentsMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetNumberOfComponentsMinValue_0")] public static extern 
bool GetNumberOfComponentsMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int GetNumberOfComponentsMaxValue()
// virtual int GetNumberOfComponentsMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetNumberOfComponentsMaxValue_0")] public static extern 
bool GetNumberOfComponentsMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// int GetNumberOfComponents()
// int GetNumberOfComponents()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetNumberOfComponents_0")] public static extern 
bool GetNumberOfComponents_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// void SetComponentName(vtkIdType component, const char * name)
// void SetComponentName( vtkIdType component, const char *name )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetComponentName_0")] public static extern 
bool SetComponentName_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ component, string /*(char*)*/ name);

// char* GetComponentName(vtkIdType component)
// const char* GetComponentName( vtkIdType component )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetComponentName_0")] public static extern 
bool GetComponentName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ component);

// bool HasAComponentName()
// bool HasAComponentName()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_HasAComponentName_0")] public static extern 
bool HasAComponentName_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// int CopyComponentNames(vtkAbstractArray * da)
// int CopyComponentNames( vtkAbstractArray *da )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_CopyComponentNames_0")] public static extern 
bool CopyComponentNames_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ da);

// virtual void SetNumberOfTuples(vtkIdType numTuples)
// virtual void SetNumberOfTuples(vtkIdType numTuples)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetNumberOfTuples_0")] public static extern 
bool SetNumberOfTuples_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ numTuples);

// virtual void SetNumberOfValues(vtkIdType numValues)
// virtual void SetNumberOfValues(vtkIdType numValues)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetNumberOfValues_0")] public static extern 
bool SetNumberOfValues_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ numValues);

// vtkIdType GetNumberOfTuples()
// vtkIdType GetNumberOfTuples()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetNumberOfTuples_0")] public static extern 
bool GetNumberOfTuples_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetTuple_0")] public static extern 
bool SetTuple_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InsertTuple_0")] public static extern 
bool InsertTuple_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// virtual void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InsertTuples_0")] public static extern 
bool InsertTuples_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ dstIds, IntPtr /*(vtkIdList*)*/ srcIds, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InsertTuples_1")] public static extern 
bool InsertTuples_1(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InsertNextTuple_0")] public static extern 
bool InsertNextTuple_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// virtual void GetTuples(vtkIdList *tupleIds, vtkAbstractArray* output)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetTuples_0")] public static extern 
bool GetTuples_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ tupleIds, IntPtr /*(vtkAbstractArray*)*/ output);

// virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetTuples_1")] public static extern 
bool GetTuples_1(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, IntPtr /*(vtkAbstractArray*)*/ output);

// virtual bool HasStandardMemoryLayout()
// virtual bool HasStandardMemoryLayout()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_HasStandardMemoryLayout_0")] public static extern 
bool HasStandardMemoryLayout_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void* GetVoidPointer(vtkIdType valueIdx)
// virtual void *GetVoidPointer(vtkIdType valueIdx)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetVoidPointer_0")] public static extern 
bool GetVoidPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ valueIdx);

// virtual void DeepCopy(vtkAbstractArray * da)
// virtual void DeepCopy(vtkAbstractArray* da)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ da);

// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InterpolateTuple_0")] public static extern 
bool InterpolateTuple_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, IntPtr /*(vtkIdList*)*/ ptIndices, IntPtr /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights);

// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_InterpolateTuple_1")] public static extern 
bool InterpolateTuple_1(IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, IntPtr /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, IntPtr /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t);

// virtual void Squeeze()
// virtual void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int Resize(vtkIdType numTuples)
// virtual int Resize(vtkIdType numTuples)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Resize_0")] public static extern 
bool Resize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, long /*(vtkIdType)*/ numTuples);

// void Reset()
// void Reset()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Reset_0")] public static extern 
bool Reset_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// vtkIdType GetSize()
// vtkIdType GetSize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// vtkIdType GetMaxId()
// vtkIdType GetMaxId()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetMaxId_0")] public static extern 
bool GetMaxId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void SetVoidArray(void * ARG_0, vtkIdType ARG_1, int ARG_2)
// virtual void SetVoidArray(void *, vtkIdType , int )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetVoidArray_0")] public static extern 
bool SetVoidArray_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(void*)*/ ARG_0, long /*(vtkIdType)*/ ARG_1, int /*(int)*/ ARG_2);

// virtual void SetVoidArray(void * array, vtkIdType size, int save, int ARG_0)
// virtual void SetVoidArray(void *array, vtkIdType size, int save, int )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetVoidArray_1")] public static extern 
bool SetVoidArray_1(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save, int /*(int)*/ ARG_0);

// virtual void ExportToVoidPointer(void * out_ptr)
// virtual void ExportToVoidPointer(void *out_ptr)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_ExportToVoidPointer_0")] public static extern 
bool ExportToVoidPointer_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(void*)*/ out_ptr);

// virtual long GetActualMemorySize()
// virtual unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void SetName(const char * _arg)
// virtual void SetName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetName_0")] public static extern 
bool SetName_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetName()
// virtual char* GetName ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetName_0")] public static extern 
bool GetName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual char* GetDataTypeAsString()
// virtual const char *GetDataTypeAsString( void )
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetDataTypeAsString_0")] public static extern 
bool GetDataTypeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// static vtkAbstractArray* CreateArray(int dataType)
// static vtkAbstractArray* CreateArray(int dataType)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_CreateArray_0")] public static extern 
bool CreateArray_0(IntPtr /*(IntPtr**)*/ return_value, int /*(int)*/ dataType);

// virtual int IsNumeric()
// virtual int IsNumeric()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_IsNumeric_0")] public static extern 
bool IsNumeric_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual vtkArrayIterator* NewIterator()
// virtual vtkArrayIterator* NewIterator()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_NewIterator_0")] public static extern 
bool NewIterator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual vtkIdType GetDataSize()
// virtual vtkIdType GetDataSize()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetDataSize_0")] public static extern 
bool GetDataSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void DataChanged()
// virtual void DataChanged()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_DataChanged_0")] public static extern 
bool DataChanged_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void ClearLookup()
// virtual void ClearLookup()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_ClearLookup_0")] public static extern 
bool ClearLookup_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// vtkInformation* GetInformation()
// vtkInformation* GetInformation()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetInformation_0")] public static extern 
bool GetInformation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// bool HasInformation()
// bool HasInformation()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_HasInformation_0")] public static extern 
bool HasInformation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual int CopyInformation(vtkInformation * infoFrom, int deep = 1)
// virtual int CopyInformation(vtkInformation *infoFrom, int deep=1)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_CopyInformation_0")] public static extern 
bool CopyInformation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject, IntPtr /*(vtkInformation*)*/ infoFrom, int /*(int)*/ deep);

// static vtkInformationIntegerKey* GUI_HIDE()
// static vtkInformationIntegerKey* GUI_HIDE()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GUI_HIDE_0")] public static extern 
bool GUI_HIDE_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* PER_COMPONENT()
// static vtkInformationInformationVectorKey* PER_COMPONENT()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_PER_COMPONENT_0")] public static extern 
bool PER_COMPONENT_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationInformationVectorKey* PER_FINITE_COMPONENT()
// static vtkInformationInformationVectorKey* PER_FINITE_COMPONENT()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_PER_FINITE_COMPONENT_0")] public static extern 
bool PER_FINITE_COMPONENT_0(IntPtr /*(IntPtr**)*/ return_value);

// void Modified()
// void Modified()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_Modified_0")] public static extern 
bool Modified_0(IntPtr /*(vtkAbstractArray*)*/ callingObject);

// static vtkInformationVariantVectorKey* DISCRETE_VALUES()
// static vtkInformationVariantVectorKey* DISCRETE_VALUES()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_DISCRETE_VALUES_0")] public static extern 
bool DISCRETE_VALUES_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkInformationDoubleVectorKey* DISCRETE_VALUE_SAMPLE_PARAMETERS()
// static vtkInformationDoubleVectorKey* DISCRETE_VALUE_SAMPLE_PARAMETERS()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_0")] public static extern 
bool DISCRETE_VALUE_SAMPLE_PARAMETERS_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual int GetMaxDiscreteValues()
// virtual unsigned int GetMaxDiscreteValues ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetMaxDiscreteValues_0")] public static extern 
bool GetMaxDiscreteValues_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

// virtual void SetMaxDiscreteValues(unsigned int _arg)
// virtual void SetMaxDiscreteValues (unsigned int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_SetMaxDiscreteValues_0")] public static extern 
bool SetMaxDiscreteValues_0(IntPtr /*(vtkAbstractArray*)*/ callingObject, uint /*(unsigned int)*/ _arg);

// virtual int GetArrayType()
// virtual int GetArrayType()
[DllImport("vtkplugin", EntryPoint="vtkAbstractArray_GetArrayType_0")] public static extern 
bool GetArrayType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ callingObject);

}
};
