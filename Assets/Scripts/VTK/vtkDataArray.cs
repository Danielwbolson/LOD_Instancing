

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataArray : vtkAbstractArray {

// static vtkDataArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDataArray* FastDownCast(vtkAbstractArray *source)"
public new static vtkDataArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataArray.FastDownCast_0(returnPointer, source);
	return Ptr.deref(returnPointer);
}


// int IsNumeric()
// "int IsNumeric()"
public new int IsNumeric() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataArray.IsNumeric_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetElementComponentSize()
// "int GetElementComponentSize()"
public new int GetElementComponentSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataArray.GetElementComponentSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public new void InsertTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkDataArray.InsertTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public new long InsertNextTuple(long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataArray.InsertNextTuple_0(this, returnPointer, srcTupleIdx, source);
	return Ptr.deref(returnPointer);
}


// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)"
public new void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkDataArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public new void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkDataArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// "void GetTuples(vtkIdList *tupleIds, vtkAbstractArray *output)"
public new void GetTuples(vtkIdList /*(vtkIdList*)*/ tupleIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkDataArray.GetTuples_0(this, tupleIds, output);
}


// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public new void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkDataArray.GetTuples_1(this, p1, p2, output);
}


// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public new void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, double /*(double*)*/ []weights) {
	API_vtkDataArray.InterpolateTuple_0(this, dstTupleIdx, ptIndices, source, weights);
}


// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// "void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)"
public new void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	API_vtkDataArray.InterpolateTuple_1(this, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


// virtual double* GetTuple(vtkIdType tupleIdx)
// "virtual double *GetTuple(vtkIdType tupleIdx)"
public new double GetTuple(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// virtual void GetTuple(vtkIdType tupleIdx, double * tuple)
// "virtual void GetTuple(vtkIdType tupleIdx, double * tuple)"
public new void GetTuple(long /*(vtkIdType)*/ tupleIdx, double /*(double*)*/ []tuple) {
	API_vtkDataArray.GetTuple_1(this, tupleIdx, tuple);
}


// double GetTuple1(vtkIdType tupleIdx)
// "double GetTuple1(vtkIdType tupleIdx)"
public new double GetTuple1(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple1_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// double* GetTuple2(vtkIdType tupleIdx)
// "double* GetTuple2(vtkIdType tupleIdx)"
public new double GetTuple2(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple2_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// double* GetTuple3(vtkIdType tupleIdx)
// "double* GetTuple3(vtkIdType tupleIdx)"
public new double GetTuple3(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple3_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// double* GetTuple4(vtkIdType tupleIdx)
// "double* GetTuple4(vtkIdType tupleIdx)"
public new double GetTuple4(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple4_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// double* GetTuple6(vtkIdType tupleIdx)
// "double* GetTuple6(vtkIdType tupleIdx)"
public new double GetTuple6(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple6_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// double* GetTuple9(vtkIdType tupleIdx)
// "double* GetTuple9(vtkIdType tupleIdx)"
public new double GetTuple9(long /*(vtkIdType)*/ tupleIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetTuple9_0(this, returnPointer, tupleIdx);
	return Ptr.deref(returnPointer);
}


// void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public new void SetTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkDataArray.SetTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)
// "virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)"
public new void SetTuple(long /*(vtkIdType)*/ tupleIdx, float /*(float*)*/ []tuple) {
	API_vtkDataArray.SetTuple_1(this, tupleIdx, tuple);
}


// virtual void SetTuple(vtkIdType tupleIdx, const double * tuple)
// "virtual void SetTuple(vtkIdType tupleIdx, const double * tuple)"
public new void SetTuple(long /*(vtkIdType)*/ tupleIdx, double /*(double*)*/ []tuple) {
	API_vtkDataArray.SetTuple_2(this, tupleIdx, tuple);
}


// void SetTuple1(vtkIdType tupleIdx, double value)
// "void SetTuple1(vtkIdType tupleIdx, double value)"
public new void SetTuple1(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value) {
	API_vtkDataArray.SetTuple1_0(this, tupleIdx, value);
}


// void SetTuple2(vtkIdType tupleIdx, double val0, double val1)
// "void SetTuple2(vtkIdType tupleIdx, double val0, double val1)"
public new void SetTuple2(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1) {
	API_vtkDataArray.SetTuple2_0(this, tupleIdx, val0, val1);
}


// void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// "void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)"
public new void SetTuple3(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	API_vtkDataArray.SetTuple3_0(this, tupleIdx, val0, val1, val2);
}


// void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// "void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)"
public new void SetTuple4(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	API_vtkDataArray.SetTuple4_0(this, tupleIdx, val0, val1, val2, val3);
}


// void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// "void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)"
public new void SetTuple6(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	API_vtkDataArray.SetTuple6_0(this, tupleIdx, val0, val1, val2, val3, val4, val5);
}


// void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public new void SetTuple9(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	API_vtkDataArray.SetTuple9_0(this, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)
// "virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)"
public new void InsertTuple(long /*(vtkIdType)*/ tupleIdx, float /*(float*)*/ []tuple) {
	API_vtkDataArray.InsertTuple_1(this, tupleIdx, tuple);
}


// virtual void InsertTuple(vtkIdType tupleIdx, const double * tuple)
// "virtual void InsertTuple(vtkIdType tupleIdx, const double * tuple)"
public new void InsertTuple(long /*(vtkIdType)*/ tupleIdx, double /*(double*)*/ []tuple) {
	API_vtkDataArray.InsertTuple_2(this, tupleIdx, tuple);
}


// void InsertTuple1(vtkIdType tupleIdx, double value)
// "void InsertTuple1(vtkIdType tupleIdx, double value)"
public new void InsertTuple1(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value) {
	API_vtkDataArray.InsertTuple1_0(this, tupleIdx, value);
}


// void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
// "void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)"
public new void InsertTuple2(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1) {
	API_vtkDataArray.InsertTuple2_0(this, tupleIdx, val0, val1);
}


// void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// "void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)"
public new void InsertTuple3(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	API_vtkDataArray.InsertTuple3_0(this, tupleIdx, val0, val1, val2);
}


// void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// "void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)"
public new void InsertTuple4(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	API_vtkDataArray.InsertTuple4_0(this, tupleIdx, val0, val1, val2, val3);
}


// void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// "void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)"
public new void InsertTuple6(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	API_vtkDataArray.InsertTuple6_0(this, tupleIdx, val0, val1, val2, val3, val4, val5);
}


// void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public new void InsertTuple9(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	API_vtkDataArray.InsertTuple9_0(this, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual vtkIdType InsertNextTuple(const float * tuple)
// "virtual vtkIdType InsertNextTuple(const float * tuple)"
public new long InsertNextTuple(float /*(float*)*/ []tuple) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataArray.InsertNextTuple_1(this, returnPointer, tuple);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType InsertNextTuple(const double * tuple)
// "virtual vtkIdType InsertNextTuple(const double * tuple)"
public new long InsertNextTuple(double /*(double*)*/ []tuple) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkDataArray.InsertNextTuple_2(this, returnPointer, tuple);
	return Ptr.deref(returnPointer);
}


// void InsertNextTuple1(double value)
// "void InsertNextTuple1(double value)"
public new void InsertNextTuple1(double /*(double)*/ value) {
	API_vtkDataArray.InsertNextTuple1_0(this, value);
}


// void InsertNextTuple2(double val0, double val1)
// "void InsertNextTuple2(double val0, double val1)"
public new void InsertNextTuple2(double /*(double)*/ val0, double /*(double)*/ val1) {
	API_vtkDataArray.InsertNextTuple2_0(this, val0, val1);
}


// void InsertNextTuple3(double val0, double val1, double val2)
// "void InsertNextTuple3(double val0, double val1, double val2)"
public new void InsertNextTuple3(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	API_vtkDataArray.InsertNextTuple3_0(this, val0, val1, val2);
}


// void InsertNextTuple4(double val0, double val1, double val2, double val3)
// "void InsertNextTuple4(double val0, double val1, double val2, double val3)"
public new void InsertNextTuple4(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	API_vtkDataArray.InsertNextTuple4_0(this, val0, val1, val2, val3);
}


// void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
// "void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)"
public new void InsertNextTuple6(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	API_vtkDataArray.InsertNextTuple6_0(this, val0, val1, val2, val3, val4, val5);
}


// void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public new void InsertNextTuple9(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	API_vtkDataArray.InsertNextTuple9_0(this, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual void RemoveTuple(vtkIdType tupleIdx)
// "virtual void RemoveTuple(vtkIdType tupleIdx)"
public new void RemoveTuple(long /*(vtkIdType)*/ tupleIdx) {
	API_vtkDataArray.RemoveTuple_0(this, tupleIdx);
}


// virtual void RemoveFirstTuple()
// "virtual void RemoveFirstTuple()"
public new void RemoveFirstTuple() {
	API_vtkDataArray.RemoveFirstTuple_0(this);
}


// virtual void RemoveLastTuple()
// "virtual void RemoveLastTuple()"
public new void RemoveLastTuple() {
	API_vtkDataArray.RemoveLastTuple_0(this);
}


// virtual double GetComponent(vtkIdType tupleIdx, int compIdx)
// "virtual double GetComponent(vtkIdType tupleIdx, int compIdx)"
public new double GetComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetComponent_0(this, returnPointer, tupleIdx, compIdx);
	return Ptr.deref(returnPointer);
}


// virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)
// "virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)"
public new void SetComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value) {
	API_vtkDataArray.SetComponent_0(this, tupleIdx, compIdx, value);
}


// virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
// "virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)"
public new void InsertComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value) {
	API_vtkDataArray.InsertComponent_0(this, tupleIdx, compIdx, value);
}


// virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray * data)
// "virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray* data)"
public new void GetData(long /*(vtkIdType)*/ tupleMin, long /*(vtkIdType)*/ tupleMax, int /*(int)*/ compMin, int /*(int)*/ compMax, vtkDoubleArray /*(vtkDoubleArray*)*/ data) {
	API_vtkDataArray.GetData_0(this, tupleMin, tupleMax, compMin, compMax, data);
}


// void DeepCopy(vtkAbstractArray * aa)
// "void DeepCopy(vtkAbstractArray *aa)"
public new void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ aa) {
	API_vtkDataArray.DeepCopy_0(this, aa);
}


// virtual void DeepCopy(vtkDataArray * da)
// "virtual void DeepCopy(vtkDataArray *da)"
public new void DeepCopy(vtkDataArray /*(vtkDataArray*)*/ da) {
	API_vtkDataArray.DeepCopy_1(this, da);
}


// virtual void ShallowCopy(vtkDataArray * other)
// "virtual void ShallowCopy(vtkDataArray *other)"
public new void ShallowCopy(vtkDataArray /*(vtkDataArray*)*/ other) {
	API_vtkDataArray.ShallowCopy_0(this, other);
}


// virtual void FillComponent(int compIdx, double value)
// "virtual void FillComponent(int compIdx, double value)"
public new void FillComponent(int /*(int)*/ compIdx, double /*(double)*/ value) {
	API_vtkDataArray.FillComponent_0(this, compIdx, value);
}


// virtual void Fill(double value)
// "virtual void Fill(double value)"
public new void Fill(double /*(double)*/ value) {
	API_vtkDataArray.Fill_0(this, value);
}


// virtual void CopyComponent(int dstComponent, vtkDataArray * src, int srcComponent)
// "virtual void CopyComponent(int dstComponent, vtkDataArray *src, int srcComponent)"
public new void CopyComponent(int /*(int)*/ dstComponent, vtkDataArray /*(vtkDataArray*)*/ src, int /*(int)*/ srcComponent) {
	API_vtkDataArray.CopyComponent_0(this, dstComponent, src, srcComponent);
}


// virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
// "virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)"
public new IntPtr WriteVoidPointer(long /*(vtkIdType)*/ valueIdx, long /*(vtkIdType)*/ numValues) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkDataArray.WriteVoidPointer_0(this, returnPointer, valueIdx, numValues);
	return Ptr.deref(returnPointer);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkDataArray.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void CreateDefaultLookupTable()
// "void CreateDefaultLookupTable()"
public new void CreateDefaultLookupTable() {
	API_vtkDataArray.CreateDefaultLookupTable_0(this);
}


// void SetLookupTable(vtkLookupTable * lut)
// "void SetLookupTable(vtkLookupTable *lut)"
public new void SetLookupTable(vtkLookupTable /*(vtkLookupTable*)*/ lut) {
	API_vtkDataArray.SetLookupTable_0(this, lut);
}


// void GetRange(double range[2], int comp)
// "void GetRange(double range[2], int comp)"
public new void GetRange(double /*(double[2])*/ []range, int /*(int)*/ comp) {
	API_vtkDataArray.GetRange_0(this, range, comp);
}


// double* GetRange(int comp)
// "double* GetRange(int comp)"
public new double GetRange(int /*(int)*/ comp) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetRange_1(this, returnPointer, comp);
	return Ptr.deref(returnPointer);
}


// double* GetRange()
// "double* GetRange()"
public new double GetRange() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetRange_2(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetRange(double range[2])
// "void GetRange(double range[2])"
public new void GetRange(double /*(double[2])*/ []range) {
	API_vtkDataArray.GetRange_3(this, range);
}


// void GetFiniteRange(double range[2], int comp)
// "void GetFiniteRange(double range[2], int comp)"
public new void GetFiniteRange(double /*(double[2])*/ []range, int /*(int)*/ comp) {
	API_vtkDataArray.GetFiniteRange_0(this, range, comp);
}


// double* GetFiniteRange(int comp)
// "double *GetFiniteRange(int comp)"
public new double GetFiniteRange(int /*(int)*/ comp) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetFiniteRange_1(this, returnPointer, comp);
	return Ptr.deref(returnPointer);
}


// double* GetFiniteRange()
// "double *GetFiniteRange()"
public new double GetFiniteRange() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetFiniteRange_2(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetFiniteRange(double range[2])
// "void GetFiniteRange(double range[2])"
public new void GetFiniteRange(double /*(double[2])*/ []range) {
	API_vtkDataArray.GetFiniteRange_3(this, range);
}


// void GetDataTypeRange(double range[2])
// "void GetDataTypeRange(double range[2])"
public new void GetDataTypeRange(double /*(double[2])*/ []range) {
	API_vtkDataArray.GetDataTypeRange_0(this, range);
}


// double GetDataTypeMin()
// "double GetDataTypeMin()"
public new double GetDataTypeMin() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetDataTypeMin_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// double GetDataTypeMax()
// "double GetDataTypeMax()"
public new double GetDataTypeMax() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetDataTypeMax_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static void GetDataTypeRange(int type, double range[2])
// "static void GetDataTypeRange(int type, double range[2])"
public new static void GetDataTypeRange(int /*(int)*/ type, double /*(double[2])*/ []range) {
	API_vtkDataArray.GetDataTypeRange_1(type, range);
}


// static double GetDataTypeMin(int type)
// "static double GetDataTypeMin(int type)"
public new static double GetDataTypeMin(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetDataTypeMin_1(returnPointer, type);
	return Ptr.deref(returnPointer);
}


// static double GetDataTypeMax(int type)
// "static double GetDataTypeMax(int type)"
public new static double GetDataTypeMax(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetDataTypeMax_1(returnPointer, type);
	return Ptr.deref(returnPointer);
}


// virtual double GetMaxNorm()
// "virtual double GetMaxNorm()"
public new double GetMaxNorm() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkDataArray.GetMaxNorm_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Modified()
// "void Modified()"
public new void Modified() {
	API_vtkDataArray.Modified_0(this);
}


// int GetArrayType()
// "int GetArrayType()"
public new int GetArrayType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkDataArray.GetArrayType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
