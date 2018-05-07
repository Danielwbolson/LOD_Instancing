

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataArray : vtkAbstractArray {
		public vtkDataArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataArray(IntPtr p) {return new vtkDataArray(p);}
		public static implicit operator  IntPtr(vtkDataArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkDataArray* SafeDownCast(vtkObjectBase * o)
// "static vtkDataArray* SafeDownCast(vtkObjectBase *o)"
public static vtkDataArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* NewInstance()
// "vtkDataArray *NewInstance()"
public vtkDataArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// static vtkDataArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDataArray* FastDownCast(vtkAbstractArray *source)"
public static vtkDataArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.FastDownCast_0(returnPointer.GetPtr(), source);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// int IsNumeric()
// "int IsNumeric()"
public int IsNumeric() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArray.IsNumeric_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetElementComponentSize()
// "int GetElementComponentSize()"
public int GetElementComponentSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArray.GetElementComponentSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public void InsertTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkDataArray.InsertTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkDataArray.InsertNextTuple_0(returnPointer.GetPtr(), this, srcTupleIdx, source);
	return (long)returnPointer;
}


// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)"
public void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkDataArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkDataArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// "void GetTuples(vtkIdList *tupleIds, vtkAbstractArray *output)"
public void GetTuples(vtkIdList /*(vtkIdList*)*/ tupleIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkDataArray.GetTuples_0(this, tupleIds, output);
}


// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkDataArray.GetTuples_1(this, p1, p2, output);
}


// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights) {
	VTK_API.API_vtkDataArray.InterpolateTuple_0(this, dstTupleIdx, ptIndices, source, weights);
}


// void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// "void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	VTK_API.API_vtkDataArray.InterpolateTuple_1(this, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


// virtual double* GetTuple(vtkIdType tupleIdx)
// "virtual double *GetTuple(vtkIdType tupleIdx)"
public IntPtr GetTuple(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// virtual void GetTuple(vtkIdType tupleIdx, double * tuple)
// "virtual void GetTuple(vtkIdType tupleIdx, double * tuple)"
public void GetTuple(long /*(vtkIdType)*/ tupleIdx, IntPtr /*(double*)*/ tuple) {
	VTK_API.API_vtkDataArray.GetTuple_1(this, tupleIdx, tuple);
}


// double GetTuple1(vtkIdType tupleIdx)
// "double GetTuple1(vtkIdType tupleIdx)"
public double GetTuple1(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetTuple1_0(returnPointer.GetPtr(), this, tupleIdx);
	return (double)returnPointer;
}


// double* GetTuple2(vtkIdType tupleIdx)
// "double* GetTuple2(vtkIdType tupleIdx)"
public IntPtr GetTuple2(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple2_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// double* GetTuple3(vtkIdType tupleIdx)
// "double* GetTuple3(vtkIdType tupleIdx)"
public IntPtr GetTuple3(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple3_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// double* GetTuple4(vtkIdType tupleIdx)
// "double* GetTuple4(vtkIdType tupleIdx)"
public IntPtr GetTuple4(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple4_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// double* GetTuple6(vtkIdType tupleIdx)
// "double* GetTuple6(vtkIdType tupleIdx)"
public IntPtr GetTuple6(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple6_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// double* GetTuple9(vtkIdType tupleIdx)
// "double* GetTuple9(vtkIdType tupleIdx)"
public IntPtr GetTuple9(long /*(vtkIdType)*/ tupleIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetTuple9_0(returnPointer.GetPtr(), this, tupleIdx);
	return (IntPtr)returnPointer;
}


// void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public void SetTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkDataArray.SetTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)
// "virtual void SetTuple(vtkIdType tupleIdx, const float * tuple)"
public void SetTuple(long /*(vtkIdType)*/ tupleIdx, IntPtr /*(float*)*/ tuple) {
	VTK_API.API_vtkDataArray.SetTuple_1(this, tupleIdx, tuple);
}


// void SetTuple1(vtkIdType tupleIdx, double value)
// "void SetTuple1(vtkIdType tupleIdx, double value)"
public void SetTuple1(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.SetTuple1_0(this, tupleIdx, value);
}


// void SetTuple2(vtkIdType tupleIdx, double val0, double val1)
// "void SetTuple2(vtkIdType tupleIdx, double val0, double val1)"
public void SetTuple2(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1) {
	VTK_API.API_vtkDataArray.SetTuple2_0(this, tupleIdx, val0, val1);
}


// void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// "void SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)"
public void SetTuple3(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	VTK_API.API_vtkDataArray.SetTuple3_0(this, tupleIdx, val0, val1, val2);
}


// void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// "void SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)"
public void SetTuple4(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	VTK_API.API_vtkDataArray.SetTuple4_0(this, tupleIdx, val0, val1, val2, val3);
}


// void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// "void SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)"
public void SetTuple6(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	VTK_API.API_vtkDataArray.SetTuple6_0(this, tupleIdx, val0, val1, val2, val3, val4, val5);
}


// void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public void SetTuple9(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	VTK_API.API_vtkDataArray.SetTuple9_0(this, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)
// "virtual void InsertTuple(vtkIdType tupleIdx, const float * tuple)"
public void InsertTuple(long /*(vtkIdType)*/ tupleIdx, IntPtr /*(float*)*/ tuple) {
	VTK_API.API_vtkDataArray.InsertTuple_1(this, tupleIdx, tuple);
}


// void InsertTuple1(vtkIdType tupleIdx, double value)
// "void InsertTuple1(vtkIdType tupleIdx, double value)"
public void InsertTuple1(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.InsertTuple1_0(this, tupleIdx, value);
}


// void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
// "void InsertTuple2(vtkIdType tupleIdx, double val0, double val1)"
public void InsertTuple2(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1) {
	VTK_API.API_vtkDataArray.InsertTuple2_0(this, tupleIdx, val0, val1);
}


// void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// "void InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)"
public void InsertTuple3(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	VTK_API.API_vtkDataArray.InsertTuple3_0(this, tupleIdx, val0, val1, val2);
}


// void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// "void InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)"
public void InsertTuple4(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	VTK_API.API_vtkDataArray.InsertTuple4_0(this, tupleIdx, val0, val1, val2, val3);
}


// void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// "void InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)"
public void InsertTuple6(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	VTK_API.API_vtkDataArray.InsertTuple6_0(this, tupleIdx, val0, val1, val2, val3, val4, val5);
}


// void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public void InsertTuple9(long /*(vtkIdType)*/ tupleIdx, double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	VTK_API.API_vtkDataArray.InsertTuple9_0(this, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual vtkIdType InsertNextTuple(const float * tuple)
// "virtual vtkIdType InsertNextTuple(const float * tuple)"
public long InsertNextTuple(IntPtr /*(float*)*/ tuple) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkDataArray.InsertNextTuple_1(returnPointer.GetPtr(), this, tuple);
	return (long)returnPointer;
}


// void InsertNextTuple1(double value)
// "void InsertNextTuple1(double value)"
public void InsertNextTuple1(double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.InsertNextTuple1_0(this, value);
}


// void InsertNextTuple2(double val0, double val1)
// "void InsertNextTuple2(double val0, double val1)"
public void InsertNextTuple2(double /*(double)*/ val0, double /*(double)*/ val1) {
	VTK_API.API_vtkDataArray.InsertNextTuple2_0(this, val0, val1);
}


// void InsertNextTuple3(double val0, double val1, double val2)
// "void InsertNextTuple3(double val0, double val1, double val2)"
public void InsertNextTuple3(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2) {
	VTK_API.API_vtkDataArray.InsertNextTuple3_0(this, val0, val1, val2);
}


// void InsertNextTuple4(double val0, double val1, double val2, double val3)
// "void InsertNextTuple4(double val0, double val1, double val2, double val3)"
public void InsertNextTuple4(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3) {
	VTK_API.API_vtkDataArray.InsertNextTuple4_0(this, val0, val1, val2, val3);
}


// void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
// "void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)"
public void InsertNextTuple6(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5) {
	VTK_API.API_vtkDataArray.InsertNextTuple6_0(this, val0, val1, val2, val3, val4, val5);
}


// void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// "void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)"
public void InsertNextTuple9(double /*(double)*/ val0, double /*(double)*/ val1, double /*(double)*/ val2, double /*(double)*/ val3, double /*(double)*/ val4, double /*(double)*/ val5, double /*(double)*/ val6, double /*(double)*/ val7, double /*(double)*/ val8) {
	VTK_API.API_vtkDataArray.InsertNextTuple9_0(this, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


// virtual void RemoveTuple(vtkIdType tupleIdx)
// "virtual void RemoveTuple(vtkIdType tupleIdx)"
public void RemoveTuple(long /*(vtkIdType)*/ tupleIdx) {
	VTK_API.API_vtkDataArray.RemoveTuple_0(this, tupleIdx);
}


// virtual void RemoveFirstTuple()
// "virtual void RemoveFirstTuple()"
public void RemoveFirstTuple() {
	VTK_API.API_vtkDataArray.RemoveFirstTuple_0(this);
}


// virtual void RemoveLastTuple()
// "virtual void RemoveLastTuple()"
public void RemoveLastTuple() {
	VTK_API.API_vtkDataArray.RemoveLastTuple_0(this);
}


// virtual double GetComponent(vtkIdType tupleIdx, int compIdx)
// "virtual double GetComponent(vtkIdType tupleIdx, int compIdx)"
public double GetComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetComponent_0(returnPointer.GetPtr(), this, tupleIdx, compIdx);
	return (double)returnPointer;
}


// virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)
// "virtual void SetComponent(vtkIdType tupleIdx, int compIdx, double value)"
public void SetComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.SetComponent_0(this, tupleIdx, compIdx, value);
}


// virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
// "virtual void InsertComponent(vtkIdType tupleIdx, int compIdx, double value)"
public void InsertComponent(long /*(vtkIdType)*/ tupleIdx, int /*(int)*/ compIdx, double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.InsertComponent_0(this, tupleIdx, compIdx, value);
}


// virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray * data)
// "virtual void GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray* data)"
public void GetData(long /*(vtkIdType)*/ tupleMin, long /*(vtkIdType)*/ tupleMax, int /*(int)*/ compMin, int /*(int)*/ compMax, vtkDoubleArray /*(vtkDoubleArray*)*/ data) {
	VTK_API.API_vtkDataArray.GetData_0(this, tupleMin, tupleMax, compMin, compMax, data);
}


// void DeepCopy(vtkAbstractArray * aa)
// "void DeepCopy(vtkAbstractArray *aa)"
public void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ aa) {
	VTK_API.API_vtkDataArray.DeepCopy_0(this, aa);
}


// virtual void DeepCopy(vtkDataArray * da)
// "virtual void DeepCopy(vtkDataArray *da)"
public void DeepCopy(vtkDataArray /*(vtkDataArray*)*/ da) {
	VTK_API.API_vtkDataArray.DeepCopy_1(this, da);
}


// virtual void ShallowCopy(vtkDataArray * other)
// "virtual void ShallowCopy(vtkDataArray *other)"
public void ShallowCopy(vtkDataArray /*(vtkDataArray*)*/ other) {
	VTK_API.API_vtkDataArray.ShallowCopy_0(this, other);
}


// virtual void FillComponent(int compIdx, double value)
// "virtual void FillComponent(int compIdx, double value)"
public void FillComponent(int /*(int)*/ compIdx, double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.FillComponent_0(this, compIdx, value);
}


// virtual void Fill(double value)
// "virtual void Fill(double value)"
public void Fill(double /*(double)*/ value) {
	VTK_API.API_vtkDataArray.Fill_0(this, value);
}


// virtual void CopyComponent(int dstComponent, vtkDataArray * src, int srcComponent)
// "virtual void CopyComponent(int dstComponent, vtkDataArray *src, int srcComponent)"
public void CopyComponent(int /*(int)*/ dstComponent, vtkDataArray /*(vtkDataArray*)*/ src, int /*(int)*/ srcComponent) {
	VTK_API.API_vtkDataArray.CopyComponent_0(this, dstComponent, src, srcComponent);
}


// virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
// "virtual void* WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)"
public IntPtr WriteVoidPointer(long /*(vtkIdType)*/ valueIdx, long /*(vtkIdType)*/ numValues) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.WriteVoidPointer_0(returnPointer.GetPtr(), this, valueIdx, numValues);
	return (IntPtr)returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkDataArray.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void CreateDefaultLookupTable()
// "void CreateDefaultLookupTable()"
public void CreateDefaultLookupTable() {
	VTK_API.API_vtkDataArray.CreateDefaultLookupTable_0(this);
}


// void SetLookupTable(vtkLookupTable * lut)
// "void SetLookupTable(vtkLookupTable *lut)"
public void SetLookupTable(vtkLookupTable /*(vtkLookupTable*)*/ lut) {
	VTK_API.API_vtkDataArray.SetLookupTable_0(this, lut);
}


// virtual vtkLookupTable* GetLookupTable()
// "virtual vtkLookupTable *GetLookupTable ()"
public vtkLookupTable GetLookupTable() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetLookupTable_0(returnPointer.GetPtr(), this);
	return (vtkLookupTable)(IntPtr)returnPointer;
}


// void GetRange(double range[2], int comp)
// "void GetRange(double range[2], int comp)"
public void GetRange(double /*(double[2])*/ []range, int /*(int)*/ comp) {
	VTK_API.API_vtkDataArray.GetRange_0(this, range, comp);
}


// double* GetRange(int comp)
// "double* GetRange(int comp)"
public IntPtr GetRange(int /*(int)*/ comp) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetRange_1(returnPointer.GetPtr(), this, comp);
	return (IntPtr)returnPointer;
}


// double* GetRange()
// "double* GetRange()"
public IntPtr GetRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetRange_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetRange(double range[2])
// "void GetRange(double range[2])"
public void GetRange(double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataArray.GetRange_3(this, range);
}


// void GetFiniteRange(double range[2], int comp)
// "void GetFiniteRange(double range[2], int comp)"
public void GetFiniteRange(double /*(double[2])*/ []range, int /*(int)*/ comp) {
	VTK_API.API_vtkDataArray.GetFiniteRange_0(this, range, comp);
}


// double* GetFiniteRange(int comp)
// "double *GetFiniteRange(int comp)"
public IntPtr GetFiniteRange(int /*(int)*/ comp) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetFiniteRange_1(returnPointer.GetPtr(), this, comp);
	return (IntPtr)returnPointer;
}


// double* GetFiniteRange()
// "double *GetFiniteRange()"
public IntPtr GetFiniteRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.GetFiniteRange_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetFiniteRange(double range[2])
// "void GetFiniteRange(double range[2])"
public void GetFiniteRange(double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataArray.GetFiniteRange_3(this, range);
}


// void GetDataTypeRange(double range[2])
// "void GetDataTypeRange(double range[2])"
public void GetDataTypeRange(double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataArray.GetDataTypeRange_0(this, range);
}


// double GetDataTypeMin()
// "double GetDataTypeMin()"
public double GetDataTypeMin() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetDataTypeMin_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// double GetDataTypeMax()
// "double GetDataTypeMax()"
public double GetDataTypeMax() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetDataTypeMax_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// static void GetDataTypeRange(int type, double range[2])
// "static void GetDataTypeRange(int type, double range[2])"
public static void GetDataTypeRange(int /*(int)*/ type, double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataArray.GetDataTypeRange_1(type, range);
}


// static double GetDataTypeMin(int type)
// "static double GetDataTypeMin(int type)"
public static double GetDataTypeMin(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetDataTypeMin_1(returnPointer.GetPtr(), type);
	return (double)returnPointer;
}


// static double GetDataTypeMax(int type)
// "static double GetDataTypeMax(int type)"
public static double GetDataTypeMax(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetDataTypeMax_1(returnPointer.GetPtr(), type);
	return (double)returnPointer;
}


// virtual double GetMaxNorm()
// "virtual double GetMaxNorm()"
public double GetMaxNorm() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkDataArray.GetMaxNorm_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// static vtkDataArray* CreateDataArray(int dataType)
// "static vtkDataArray* CreateDataArray(int dataType)"
public static vtkDataArray CreateDataArray(int /*(int)*/ dataType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataArray.CreateDataArray_0(returnPointer.GetPtr(), dataType);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// void Modified()
// "void Modified()"
public void Modified() {
	VTK_API.API_vtkDataArray.Modified_0(this);
}


// int GetArrayType()
// "int GetArrayType()"
public int GetArrayType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataArray.GetArrayType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
