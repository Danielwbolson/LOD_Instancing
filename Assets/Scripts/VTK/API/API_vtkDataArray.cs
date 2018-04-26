
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataArray {

// static vtkDataArray* FastDownCast(vtkAbstractArray * source)
// static vtkDataArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_FastDownCast_0")] public static extern 
bool vtkDataArray_FastDownCast_0(IntPtr /*(vtkDataArray**)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// int IsNumeric()
// int IsNumeric()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_IsNumeric_0")] public static extern 
bool vtkDataArray_IsNumeric_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// int GetElementComponentSize()
// int GetElementComponentSize()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetElementComponentSize_0")] public static extern 
bool vtkDataArray_GetElementComponentSize_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple_0")] public static extern 
bool vtkDataArray_InsertTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple_0")] public static extern 
bool vtkDataArray_InsertNextTuple_0(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuples_0")] public static extern 
bool vtkDataArray_InsertTuples_0(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ dstIds, IntPtr /*(vtkIdList*)*/ srcIds, IntPtr /*(vtkAbstractArray*)*/ source);

// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuples_1")] public static extern 
bool vtkDataArray_InsertTuples_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, IntPtr /*(vtkAbstractArray*)*/ source);

// void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// void GetTuples(vtkIdList *tupleIds, vtkAbstractArray *output)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuples_0")] public static extern 
bool vtkDataArray_GetTuples_0(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkIdList*)*/ tupleIds, IntPtr /*(vtkAbstractArray*)*/ output);

// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuples_1")] public static extern 
bool vtkDataArray_GetTuples_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, IntPtr /*(vtkAbstractArray*)*/ output);

// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InterpolateTuple_0")] public static extern 
bool vtkDataArray_InterpolateTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, IntPtr /*(vtkIdList*)*/ ptIndices, IntPtr /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights);

// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InterpolateTuple_1")] public static extern 
bool vtkDataArray_InterpolateTuple_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, IntPtr /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, IntPtr /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t);

// virtual double* GetTuple(vtkIdType tupleIdx)
// virtual double *GetTuple(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple_0")] public static extern 
bool vtkDataArray_GetTuple_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// virtual void GetTuple(vtkIdType tupleIdx, double * tuple)
// virtual void GetTuple(vtkIdType tupleIdx, double * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple_1")] public static extern 
bool vtkDataArray_GetTuple_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, IntPtr /*(double*)*/ tuple);

// double GetTuple1(vtkIdType tupleIdx)
// double GetTuple1(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple1_0")] public static extern 
bool vtkDataArray_GetTuple1_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// double* GetTuple2(vtkIdType tupleIdx)
// double* GetTuple2(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple2_0")] public static extern 
bool vtkDataArray_GetTuple2_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// double* GetTuple3(vtkIdType tupleIdx)
// double* GetTuple3(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple3_0")] public static extern 
bool vtkDataArray_GetTuple3_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// double* GetTuple4(vtkIdType tupleIdx)
// double* GetTuple4(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple4_0")] public static extern 
bool vtkDataArray_GetTuple4_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// double* GetTuple6(vtkIdType tupleIdx)
// double* GetTuple6(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple6_0")] public static extern 
bool vtkDataArray_GetTuple6_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// double* GetTuple9(vtkIdType tupleIdx)
// double* GetTuple9(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetTuple9_0")] public static extern 
bool vtkDataArray_GetTuple9_0(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple_0")] public static extern 
bool vtkDataArray_SetTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, IntPtr /*(vtkAbstractArray*)*/ source);

// virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)
// virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple_1")] public static extern 
bool vtkDataArray_SetTuple_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, IntPtr /*(float*)*/ tuple);

// virtual void SetTuple(vtkIdType tupleIdx, const double * tuple)
// virtual void SetTuple(vtkIdType tupleIdx, const double * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple_2")] public static extern 
bool vtkDataArray_SetTuple_2(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, IntPtr /*(double*)*/ tuple);

// void SetTuple1(vtkIdType tupleIdx, double value)
// void SetTuple1(vtkIdType tupleIdx, double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple1_0")] public static extern 
bool vtkDataArray_SetTuple1_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value);

// void SetTuple2(vtkIdType tupleIdx, double val0, double val1)
// void SetTuple2(vtkIdType tupleIdx, double val0, double val1)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple2_0")] public static extern 
bool vtkDataArray_SetTuple2_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1);

// void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple3_0")] public static extern 
bool vtkDataArray_SetTuple3_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2);

// void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple4_0")] public static extern 
bool vtkDataArray_SetTuple4_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3);

// void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple6_0")] public static extern 
bool vtkDataArray_SetTuple6_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5);

// void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetTuple9_0")] public static extern 
bool vtkDataArray_SetTuple9_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8);

// virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)
// virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple_1")] public static extern 
bool vtkDataArray_InsertTuple_1(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, IntPtr /*(float*)*/ tuple);

// virtual void InsertTuple(vtkIdType tupleIdx, const double * tuple)
// virtual void InsertTuple(vtkIdType tupleIdx, const double * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple_2")] public static extern 
bool vtkDataArray_InsertTuple_2(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, IntPtr /*(double*)*/ tuple);

// void InsertTuple1(vtkIdType tupleIdx, double value)
// void InsertTuple1(vtkIdType tupleIdx, double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple1_0")] public static extern 
bool vtkDataArray_InsertTuple1_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value);

// void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
// void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple2_0")] public static extern 
bool vtkDataArray_InsertTuple2_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1);

// void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple3_0")] public static extern 
bool vtkDataArray_InsertTuple3_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2);

// void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple4_0")] public static extern 
bool vtkDataArray_InsertTuple4_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3);

// void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple6_0")] public static extern 
bool vtkDataArray_InsertTuple6_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5);

// void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertTuple9_0")] public static extern 
bool vtkDataArray_InsertTuple9_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8);

// virtual vtkIdType InsertNextTuple(const float * tuple)
// virtual vtkIdType InsertNextTuple(const float * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple_1")] public static extern 
bool vtkDataArray_InsertNextTuple_1(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(float*)*/ tuple);

// virtual vtkIdType InsertNextTuple(const double * tuple)
// virtual vtkIdType InsertNextTuple(const double * tuple)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple_2")] public static extern 
bool vtkDataArray_InsertNextTuple_2(IntPtr /*(vtkIdType*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(double*)*/ tuple);

// void InsertNextTuple1(double value)
// void InsertNextTuple1(double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple1_0")] public static extern 
bool vtkDataArray_InsertNextTuple1_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ value);

// void InsertNextTuple2(double val0, double val1)
// void InsertNextTuple2(double val0, double val1)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple2_0")] public static extern 
bool vtkDataArray_InsertNextTuple2_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ val0, double /*(double)*/ val1);

// void InsertNextTuple3(double val0, double val1, double val2)
// void InsertNextTuple3(double val0, double val1, double val2)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple3_0")] public static extern 
bool vtkDataArray_InsertNextTuple3_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2);

// void InsertNextTuple4(double val0, double val1, double val2, double val3)
// void InsertNextTuple4(double val0, double val1, double val2, double val3)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple4_0")] public static extern 
bool vtkDataArray_InsertNextTuple4_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3);

// void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
// void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple6_0")] public static extern 
bool vtkDataArray_InsertNextTuple6_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5);

// void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertNextTuple9_0")] public static extern 
bool vtkDataArray_InsertNextTuple9_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8);

// virtual void RemoveTuple(vtkIdType tupleIdx)
// virtual void RemoveTuple(vtkIdType tupleIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_RemoveTuple_0")] public static extern 
bool vtkDataArray_RemoveTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx);

// virtual void RemoveFirstTuple()
// virtual void RemoveFirstTuple()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_RemoveFirstTuple_0")] public static extern 
bool vtkDataArray_RemoveFirstTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject);

// virtual void RemoveLastTuple()
// virtual void RemoveLastTuple()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_RemoveLastTuple_0")] public static extern 
bool vtkDataArray_RemoveLastTuple_0(IntPtr /*(vtkDataArray*)*/ callingObject);

// virtual double GetComponent(vtkIdType tupleIdx, int compIdx)
// virtual double GetComponent(vtkIdType tupleIdx, int compIdx)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetComponent_0")] public static extern 
bool vtkDataArray_GetComponent_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx);

// virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)
// virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetComponent_0")] public static extern 
bool vtkDataArray_SetComponent_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value);

// virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
// virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_InsertComponent_0")] public static extern 
bool vtkDataArray_InsertComponent_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value);

// virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray * data)
// virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray* data)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetData_0")] public static extern 
bool vtkDataArray_GetData_0(IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ tupleMin, long /*(vtkIdType)*/ tupleMax, int /*(int)*/ compMin, int /*(int)*/ compMax, IntPtr /*(vtkDoubleArray*)*/ data);

// void DeepCopy(vtkAbstractArray * aa)
// void DeepCopy(vtkAbstractArray *aa)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_DeepCopy_0")] public static extern 
bool vtkDataArray_DeepCopy_0(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ aa);

// virtual void DeepCopy(vtkDataArray * da)
// virtual void DeepCopy(vtkDataArray *da)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_DeepCopy_1")] public static extern 
bool vtkDataArray_DeepCopy_1(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ da);

// virtual void ShallowCopy(vtkDataArray * other)
// virtual void ShallowCopy(vtkDataArray *other)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_ShallowCopy_0")] public static extern 
bool vtkDataArray_ShallowCopy_0(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ other);

// virtual void FillComponent(int compIdx, double value)
// virtual void FillComponent(int compIdx, double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_FillComponent_0")] public static extern 
bool vtkDataArray_FillComponent_0(IntPtr /*(vtkDataArray*)*/ callingObject, int /*(int)*/ compIdx, double /*(double)*/ value);

// virtual void Fill(double value)
// virtual void Fill(double value)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_Fill_0")] public static extern 
bool vtkDataArray_Fill_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double)*/ value);

// virtual void CopyComponent(int dstComponent, vtkDataArray * src, int srcComponent)
// virtual void CopyComponent(int dstComponent, vtkDataArray *src, int srcComponent)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_CopyComponent_0")] public static extern 
bool vtkDataArray_CopyComponent_0(IntPtr /*(vtkDataArray*)*/ callingObject, int /*(int)*/ dstComponent, IntPtr /*(vtkDataArray*)*/ src, int /*(int)*/ srcComponent);

// virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
// virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_WriteVoidPointer_0")] public static extern 
bool vtkDataArray_WriteVoidPointer_0(IntPtr /*(void**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, long /*(vtkIdType)*/ valueIdx, long /*(vtkIdType)*/ numValues);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetActualMemorySize_0")] public static extern 
bool vtkDataArray_GetActualMemorySize_0(IntPtr /*(long*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// void CreateDefaultLookupTable()
// void CreateDefaultLookupTable()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_CreateDefaultLookupTable_0")] public static extern 
bool vtkDataArray_CreateDefaultLookupTable_0(IntPtr /*(vtkDataArray*)*/ callingObject);

// void SetLookupTable(vtkLookupTable * lut)
// void SetLookupTable(vtkLookupTable *lut)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_SetLookupTable_0")] public static extern 
bool vtkDataArray_SetLookupTable_0(IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkLookupTable*)*/ lut);

// void GetRange(double range[2], int comp)
// void GetRange(double range[2], int comp)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetRange_0")] public static extern 
bool vtkDataArray_GetRange_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double[2])*/ []range, int /*(int)*/ comp);

// double* GetRange(int comp)
// double* GetRange(int comp)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetRange_1")] public static extern 
bool vtkDataArray_GetRange_1(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, int /*(int)*/ comp);

// double* GetRange()
// double* GetRange()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetRange_2")] public static extern 
bool vtkDataArray_GetRange_2(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// void GetRange(double range[2])
// void GetRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetRange_3")] public static extern 
bool vtkDataArray_GetRange_3(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double[2])*/ []range);

// void GetFiniteRange(double range[2], int comp)
// void GetFiniteRange(double range[2], int comp)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetFiniteRange_0")] public static extern 
bool vtkDataArray_GetFiniteRange_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double[2])*/ []range, int /*(int)*/ comp);

// double* GetFiniteRange(int comp)
// double *GetFiniteRange(int comp)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetFiniteRange_1")] public static extern 
bool vtkDataArray_GetFiniteRange_1(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, int /*(int)*/ comp);

// double* GetFiniteRange()
// double *GetFiniteRange()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetFiniteRange_2")] public static extern 
bool vtkDataArray_GetFiniteRange_2(IntPtr /*(double**)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// void GetFiniteRange(double range[2])
// void GetFiniteRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetFiniteRange_3")] public static extern 
bool vtkDataArray_GetFiniteRange_3(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double[2])*/ []range);

// void GetDataTypeRange(double range[2])
// void GetDataTypeRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeRange_0")] public static extern 
bool vtkDataArray_GetDataTypeRange_0(IntPtr /*(vtkDataArray*)*/ callingObject, double /*(double[2])*/ []range);

// double GetDataTypeMin()
// double GetDataTypeMin()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeMin_0")] public static extern 
bool vtkDataArray_GetDataTypeMin_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// double GetDataTypeMax()
// double GetDataTypeMax()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeMax_0")] public static extern 
bool vtkDataArray_GetDataTypeMax_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// static void GetDataTypeRange(int type, double range[2])
// static void GetDataTypeRange(int type, double range[2])
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeRange_1")] public static extern 
bool vtkDataArray_GetDataTypeRange_1(int /*(int)*/ type, double /*(double[2])*/ []range);

// static double GetDataTypeMin(int type)
// static double GetDataTypeMin(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeMin_1")] public static extern 
bool vtkDataArray_GetDataTypeMin_1(IntPtr /*(double*)*/ return_value, int /*(int)*/ type);

// static double GetDataTypeMax(int type)
// static double GetDataTypeMax(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetDataTypeMax_1")] public static extern 
bool vtkDataArray_GetDataTypeMax_1(IntPtr /*(double*)*/ return_value, int /*(int)*/ type);

// virtual double GetMaxNorm()
// virtual double GetMaxNorm()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetMaxNorm_0")] public static extern 
bool vtkDataArray_GetMaxNorm_0(IntPtr /*(double*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

// static vtkInformationDoubleVectorKey* COMPONENT_RANGE()
// static vtkInformationDoubleVectorKey* COMPONENT_RANGE()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_COMPONENT_RANGE_0")] public static extern 
bool vtkDataArray_COMPONENT_RANGE_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* L2_NORM_RANGE()
// static vtkInformationDoubleVectorKey* L2_NORM_RANGE()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_L2_NORM_RANGE_0")] public static extern 
bool vtkDataArray_L2_NORM_RANGE_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// static vtkInformationDoubleVectorKey* L2_NORM_FINITE_RANGE()
// static vtkInformationDoubleVectorKey* L2_NORM_FINITE_RANGE()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_L2_NORM_FINITE_RANGE_0")] public static extern 
bool vtkDataArray_L2_NORM_FINITE_RANGE_0(IntPtr /*(vtkInformationDoubleVectorKey**)*/ return_value);

// void Modified()
// void Modified()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_Modified_0")] public static extern 
bool vtkDataArray_Modified_0(IntPtr /*(vtkDataArray*)*/ callingObject);

// static vtkInformationStringKey* UNITS_LABEL()
// static vtkInformationStringKey *UNITS_LABEL()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_UNITS_LABEL_0")] public static extern 
bool vtkDataArray_UNITS_LABEL_0(IntPtr /*(vtkInformationStringKey**)*/ return_value);

// int CopyInformation(vtkInformation * infoFrom, int deep = 1)
// int CopyInformation(vtkInformation *infoFrom, int deep=1)
[DllImport("vtkplugin", EntryPoint="vtkDataArray_CopyInformation_0")] public static extern 
bool vtkDataArray_CopyInformation_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject, IntPtr /*(vtkInformation*)*/ infoFrom, int /*(int)*/ deep);

// int GetArrayType()
// int GetArrayType()
[DllImport("vtkplugin", EntryPoint="vtkDataArray_GetArrayType_0")] public static extern 
bool vtkDataArray_GetArrayType_0(IntPtr /*(int*)*/ return_value, IntPtr /*(vtkDataArray*)*/ callingObject);

}
};
