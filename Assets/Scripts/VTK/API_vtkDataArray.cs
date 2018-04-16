
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataArray {

//       Method: virtual const char * vtkDataArray::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: static vtkDataArray * vtkDataArray::FastDownCast(vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_FastDownCast_0")] public static extern 
bool FastDownCast(IntPtr /*vtkDataArray** */ ret, IntPtr/*vtkAbstractArray* */ source);

//       Method: int vtkDataArray::IsNumeric()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_IsNumeric_0")] public static extern 
bool IsNumeric(IntPtr /*int* */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: int vtkDataArray::GetElementComponentSize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetElementComponentSize_0")] public static extern 
bool GetElementComponentSize(IntPtr /*int* */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: void vtkDataArray::InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple_0")] public static extern 
bool InsertTuple(IntPtr /*vtkDataArray* */ obj, long dstTupleIdx, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: vtkIdType vtkDataArray::InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple_0")] public static extern 
bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataArray* */ obj, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkDataArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuples_0")] public static extern 
bool InsertTuples(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkIdList* */ dstIds, IntPtr/*vtkIdList* */ srcIds, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkDataArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuples_1")] public static extern 
bool InsertTuples(IntPtr /*vtkDataArray* */ obj, long dstStart, long n, long srcStart, IntPtr/*vtkAbstractArray* */ source);

//       Method: void vtkDataArray::GetTuples(vtkIdList* tupleIds, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuples_0")] public static extern 
bool GetTuples(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkIdList* */ tupleIds, IntPtr/*vtkAbstractArray* */ output);

//       Method: void vtkDataArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuples_1")] public static extern 
bool GetTuples(IntPtr /*vtkDataArray* */ obj, long p1, long p2, IntPtr/*vtkAbstractArray* */ output);

//       Method: void vtkDataArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InterpolateTuple_0")] public static extern 
bool InterpolateTuple(IntPtr /*vtkDataArray* */ obj, long dstTupleIdx, IntPtr/*vtkIdList* */ ptIndices, IntPtr/*vtkAbstractArray* */ source, IntPtr/*double* */ weights);

//       Method: void vtkDataArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InterpolateTuple_1")] public static extern 
bool InterpolateTuple(IntPtr /*vtkDataArray* */ obj, long dstTupleIdx, long srcTupleIdx1, IntPtr/*vtkAbstractArray* */ source1, long srcTupleIdx2, IntPtr/*vtkAbstractArray* */ source2, double t);

//       Method: virtual double * vtkDataArray::GetTuple(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple_0")] public static extern 
bool GetTuple(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: virtual void vtkDataArray::GetTuple(vtkIdType tupleIdx, double* tuple)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple_1")] public static extern 
bool GetTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx, IntPtr/*double* */ tuple);

//       Method: double vtkDataArray::GetTuple1(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple1_0")] public static extern 
bool GetTuple1(IntPtr /*double* */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: double * vtkDataArray::GetTuple2(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple2_0")] public static extern 
bool GetTuple2(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: double * vtkDataArray::GetTuple3(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple3_0")] public static extern 
bool GetTuple3(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: double * vtkDataArray::GetTuple4(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple4_0")] public static extern 
bool GetTuple4(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: double * vtkDataArray::GetTuple6(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple6_0")] public static extern 
bool GetTuple6(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: double * vtkDataArray::GetTuple9(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetTuple9_0")] public static extern 
bool GetTuple9(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: void vtkDataArray::SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple_0")] public static extern 
bool SetTuple(IntPtr /*vtkDataArray* */ obj, long dstTupleIdx, long srcTupleIdx, IntPtr/*vtkAbstractArray* */ source);

//       Method: virtual void vtkDataArray::SetTuple(vtkIdType tupleIdx, const float* tuple)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple_1")] public static extern 
bool SetTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx, IntPtr/*const float* */ tuple);

////       Method: virtual void vtkDataArray::SetTuple(vtkIdType tupleIdx, const double* tuple)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple_2")] public static extern 
//bool SetTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx, IntPtr/*const double* */ tuple);
//
//       Method: void vtkDataArray::SetTuple1(vtkIdType tupleIdx, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple1_0")] public static extern 
bool SetTuple1(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double value);

//       Method: void vtkDataArray::SetTuple2(vtkIdType tupleIdx, double val0, double val1)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple2_0")] public static extern 
bool SetTuple2(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1);

//       Method: void vtkDataArray::SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple3_0")] public static extern 
bool SetTuple3(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2);

//       Method: void vtkDataArray::SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple4_0")] public static extern 
bool SetTuple4(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3);

//       Method: void vtkDataArray::SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple6_0")] public static extern 
bool SetTuple6(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

//       Method: void vtkDataArray::SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetTuple9_0")] public static extern 
bool SetTuple9(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

//       Method: virtual void vtkDataArray::InsertTuple(vtkIdType tupleIdx, const float* tuple)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple_1")] public static extern 
bool InsertTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx, IntPtr/*const float* */ tuple);

////       Method: virtual void vtkDataArray::InsertTuple(vtkIdType tupleIdx, const double* tuple)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple_2")] public static extern 
//bool InsertTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx, IntPtr/*const double* */ tuple);
//
//       Method: void vtkDataArray::InsertTuple1(vtkIdType tupleIdx, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple1_0")] public static extern 
bool InsertTuple1(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double value);

//       Method: void vtkDataArray::InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple2_0")] public static extern 
bool InsertTuple2(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1);

//       Method: void vtkDataArray::InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple3_0")] public static extern 
bool InsertTuple3(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2);

//       Method: void vtkDataArray::InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple4_0")] public static extern 
bool InsertTuple4(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3);

//       Method: void vtkDataArray::InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple6_0")] public static extern 
bool InsertTuple6(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

//       Method: void vtkDataArray::InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertTuple9_0")] public static extern 
bool InsertTuple9(IntPtr /*vtkDataArray* */ obj, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

//       Method: virtual vtkIdType vtkDataArray::InsertNextTuple(const float* tuple)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple_1")] public static extern 
bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataArray* */ obj, IntPtr/*const float* */ tuple);

////       Method: virtual vtkIdType vtkDataArray::InsertNextTuple(const double* tuple)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple_2")] public static extern 
//bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkDataArray* */ obj, IntPtr/*const double* */ tuple);
//
//       Method: void vtkDataArray::InsertNextTuple1(double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple1_0")] public static extern 
bool InsertNextTuple1(IntPtr /*vtkDataArray* */ obj, double value);

//       Method: void vtkDataArray::InsertNextTuple2(double val0, double val1)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple2_0")] public static extern 
bool InsertNextTuple2(IntPtr /*vtkDataArray* */ obj, double val0, double val1);

//       Method: void vtkDataArray::InsertNextTuple3(double val0, double val1, double val2)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple3_0")] public static extern 
bool InsertNextTuple3(IntPtr /*vtkDataArray* */ obj, double val0, double val1, double val2);

//       Method: void vtkDataArray::InsertNextTuple4(double val0, double val1, double val2, double val3)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple4_0")] public static extern 
bool InsertNextTuple4(IntPtr /*vtkDataArray* */ obj, double val0, double val1, double val2, double val3);

//       Method: void vtkDataArray::InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple6_0")] public static extern 
bool InsertNextTuple6(IntPtr /*vtkDataArray* */ obj, double val0, double val1, double val2, double val3, double val4, double val5);

//       Method: void vtkDataArray::InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertNextTuple9_0")] public static extern 
bool InsertNextTuple9(IntPtr /*vtkDataArray* */ obj, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

//       Method: virtual void vtkDataArray::RemoveTuple(vtkIdType tupleIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_RemoveTuple_0")] public static extern 
bool RemoveTuple(IntPtr /*vtkDataArray* */ obj, long tupleIdx);

//       Method: virtual void vtkDataArray::RemoveFirstTuple()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_RemoveFirstTuple_0")] public static extern 
bool RemoveFirstTuple(IntPtr /*vtkDataArray* */ obj);

//       Method: virtual void vtkDataArray::RemoveLastTuple()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_RemoveLastTuple_0")] public static extern 
bool RemoveLastTuple(IntPtr /*vtkDataArray* */ obj);

//       Method: virtual double vtkDataArray::GetComponent(vtkIdType tupleIdx, int compIdx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetComponent_0")] public static extern 
bool GetComponent(IntPtr /*double* */ ret, IntPtr /*vtkDataArray* */ obj, long tupleIdx, int compIdx);

//       Method: virtual void vtkDataArray::SetComponent(vtkIdType tupleIdx, int compIdx, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetComponent_0")] public static extern 
bool SetComponent(IntPtr /*vtkDataArray* */ obj, long tupleIdx, int compIdx, double value);

//       Method: virtual void vtkDataArray::InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_InsertComponent_0")] public static extern 
bool InsertComponent(IntPtr /*vtkDataArray* */ obj, long tupleIdx, int compIdx, double value);

//       Method: virtual void vtkDataArray::GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray* data)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkDataArray* */ obj, long tupleMin, long tupleMax, int compMin, int compMax, IntPtr/*vtkDoubleArray* */ data);

//       Method: void vtkDataArray::DeepCopy(vtkAbstractArray* aa)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkAbstractArray* */ aa);

////       Method: virtual void vtkDataArray::DeepCopy(vtkDataArray* da)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_DeepCopy_1")] public static extern 
//bool DeepCopy(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkDataArray* */ da);
//
//       Method: virtual void vtkDataArray::ShallowCopy(vtkDataArray* other)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkDataArray* */ other);

//       Method: virtual void vtkDataArray::FillComponent(int compIdx, double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_FillComponent_0")] public static extern 
bool FillComponent(IntPtr /*vtkDataArray* */ obj, int compIdx, double value);

//       Method: virtual void vtkDataArray::Fill(double value)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_Fill_0")] public static extern 
bool Fill(IntPtr /*vtkDataArray* */ obj, double value);

//       Method: virtual void vtkDataArray::CopyComponent(int dstComponent, vtkDataArray* src, int srcComponent)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_CopyComponent_0")] public static extern 
bool CopyComponent(IntPtr /*vtkDataArray* */ obj, int dstComponent, IntPtr/*vtkDataArray* */ src, int srcComponent);

//       Method: virtual void * vtkDataArray::WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_WriteVoidPointer_0")] public static extern 
bool WriteVoidPointer(IntPtr /*vtkDataArray* */ obj, long valueIdx, long numValues);

//       Method: void vtkDataArray::CreateDefaultLookupTable()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_CreateDefaultLookupTable_0")] public static extern 
bool CreateDefaultLookupTable(IntPtr /*vtkDataArray* */ obj);

//       Method: void vtkDataArray::SetLookupTable(vtkLookupTable* lut)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_SetLookupTable_0")] public static extern 
bool SetLookupTable(IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkLookupTable* */ lut);

//       Method: void vtkDataArray::GetRange(double range[2], int comp)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetRange_0")] public static extern 
bool GetRange(IntPtr /*vtkDataArray* */ obj, double[] /*2*/ range, int comp);

//       Method: double * vtkDataArray::GetRange(int comp)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetRange_1")] public static extern 
bool GetRange(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, int comp);

//       Method: double * vtkDataArray::GetRange()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetRange_2")] public static extern 
bool GetRange(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: void vtkDataArray::GetRange(double range[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetRange_3")] public static extern 
bool GetRange(IntPtr /*vtkDataArray* */ obj, double[] /*2*/ range);

//       Method: void vtkDataArray::GetFiniteRange(double range[2], int comp)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetFiniteRange_0")] public static extern 
bool GetFiniteRange(IntPtr /*vtkDataArray* */ obj, double[] /*2*/ range, int comp);

//       Method: double * vtkDataArray::GetFiniteRange(int comp)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetFiniteRange_1")] public static extern 
bool GetFiniteRange(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj, int comp);

//       Method: double * vtkDataArray::GetFiniteRange()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetFiniteRange_2")] public static extern 
bool GetFiniteRange(IntPtr /*double** */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: void vtkDataArray::GetFiniteRange(double range[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetFiniteRange_3")] public static extern 
bool GetFiniteRange(IntPtr /*vtkDataArray* */ obj, double[] /*2*/ range);

//       Method: void vtkDataArray::GetDataTypeRange(double range[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetDataTypeRange_0")] public static extern 
bool GetDataTypeRange(IntPtr /*vtkDataArray* */ obj, double[] /*2*/ range);

//       Method: double vtkDataArray::GetDataTypeMin()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetDataTypeMin_0")] public static extern 
bool GetDataTypeMin(IntPtr /*double* */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: double vtkDataArray::GetDataTypeMax()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetDataTypeMax_0")] public static extern 
bool GetDataTypeMax(IntPtr /*double* */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: static void vtkDataArray::GetDataTypeRange(int type, double range[2])
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_GetDataTypeRange_1")] public static extern 
bool GetDataTypeRange(int type, double[] /*2*/ range);

//       Method: static double vtkDataArray::GetDataTypeMin(int type)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_GetDataTypeMin_1")] public static extern 
bool GetDataTypeMin(IntPtr /*double* */ ret, int type);

//       Method: static double vtkDataArray::GetDataTypeMax(int type)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_GetDataTypeMax_1")] public static extern 
bool GetDataTypeMax(IntPtr /*double* */ ret, int type);

//       Method: virtual double vtkDataArray::GetMaxNorm()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetMaxNorm_0")] public static extern 
bool GetMaxNorm(IntPtr /*double* */ ret, IntPtr /*vtkDataArray* */ obj);

//       Method: static vtkDataArray * vtkDataArray::CreateDataArray(int dataType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_CreateDataArray_0")] public static extern 
bool CreateDataArray(IntPtr /*vtkDataArray** */ ret, int dataType);

//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::COMPONENT_RANGE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_COMPONENT_RANGE_0")] public static extern 
bool COMPONENT_RANGE(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::L2_NORM_RANGE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_L2_NORM_RANGE_0")] public static extern 
bool L2_NORM_RANGE(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::L2_NORM_FINITE_RANGE()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_L2_NORM_FINITE_RANGE_0")] public static extern 
bool L2_NORM_FINITE_RANGE(IntPtr /*vtkInformationDoubleVectorKey** */ ret);

//       Method: void vtkDataArray::Modified()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_Modified_0")] public static extern 
bool Modified(IntPtr /*vtkDataArray* */ obj);

//       Method: static vtkInformationStringKey * vtkDataArray::UNITS_LABEL()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataArray_UNITS_LABEL_0")] public static extern 
bool UNITS_LABEL(IntPtr /*vtkInformationStringKey** */ ret);

//       Method: int vtkDataArray::CopyInformation(vtkInformation* infoFrom, int deep)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_CopyInformation_0")] public static extern 
bool CopyInformation(IntPtr /*int* */ ret, IntPtr /*vtkDataArray* */ obj, IntPtr/*vtkInformation* */ infoFrom, int deep);

//       Method: int vtkDataArray::GetArrayType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataArray_GetArrayType_0")] public static extern 
bool GetArrayType(IntPtr /*int* */ ret, IntPtr /*vtkDataArray* */ obj);

}
};
