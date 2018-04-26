
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkDataArray : vtkAbstractArray {

//       Method: virtual const char * vtkDataArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkDataArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDataArray * vtkDataArray::FastDownCast(vtkAbstractArray* source)
// 
public static vtkDataArray FastDownCast(vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.FastDownCast(p, source);
	vtkDataArray result = new vtkDataArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataArray::IsNumeric()
// 
public int IsNumeric() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.IsNumeric(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkDataArray::GetElementComponentSize()
// 
public int GetElementComponentSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetElementComponentSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkDataArray.InsertTuple(obj, dstTupleIdx, srcTupleIdx, source);
}


//       Method: vtkIdType vtkDataArray::InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public long InsertNextTuple(long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.InsertNextTuple(p,obj, srcTupleIdx, source);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
public void InsertTuples(vtkIdList/*vtkIdList* */ dstIds, vtkIdList/*vtkIdList* */ srcIds, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkDataArray.InsertTuples(obj, dstIds, srcIds, source);
}


//       Method: void vtkDataArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
public void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkDataArray.InsertTuples(obj, dstStart, n, srcStart, source);
}


//       Method: void vtkDataArray::GetTuples(vtkIdList* tupleIds, vtkAbstractArray* output)
// 
public void GetTuples(vtkIdList/*vtkIdList* */ tupleIds, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkDataArray.GetTuples(obj, tupleIds, output);
}


//       Method: void vtkDataArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
public void GetTuples(long p1, long p2, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkDataArray.GetTuples(obj, p1, p2, output);
}


//       Method: void vtkDataArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
public void InterpolateTuple(long dstTupleIdx, vtkIdList/*vtkIdList* */ ptIndices, vtkAbstractArray/*vtkAbstractArray* */ source, double/*double* */ weights) {
	VTK.API_vtkDataArray.InterpolateTuple(obj, dstTupleIdx, ptIndices, source, weights);
}


//       Method: void vtkDataArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
// 
public void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray/*vtkAbstractArray* */ source1, long srcTupleIdx2, vtkAbstractArray/*vtkAbstractArray* */ source2, double t) {
	VTK.API_vtkDataArray.InterpolateTuple(obj, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


//       Method: virtual double * vtkDataArray::GetTuple(vtkIdType tupleIdx)
// 
public double[] GetTuple(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataArray::GetTuple(vtkIdType tupleIdx, double* tuple)
// 
public void GetTuple(long tupleIdx, double/*double* */ tuple) {
	VTK.API_vtkDataArray.GetTuple(obj, tupleIdx, tuple);
}


//       Method: double vtkDataArray::GetTuple1(vtkIdType tupleIdx)
// 
public double GetTuple1(long tupleIdx) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple1(p,obj, tupleIdx);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetTuple2(vtkIdType tupleIdx)
// 
public double[] GetTuple2(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple2(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetTuple3(vtkIdType tupleIdx)
// 
public double[] GetTuple3(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple3(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetTuple4(vtkIdType tupleIdx)
// 
public double[] GetTuple4(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple4(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetTuple6(vtkIdType tupleIdx)
// 
public double[] GetTuple6(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple6(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetTuple9(vtkIdType tupleIdx)
// 
public double[] GetTuple9(long tupleIdx) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetTuple9(p,obj, tupleIdx);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkDataArray.SetTuple(obj, dstTupleIdx, srcTupleIdx, source);
}


//       Method: virtual void vtkDataArray::SetTuple(vtkIdType tupleIdx, const float* tuple)
// 
public void SetTuple(long tupleIdx, float/*const float* */ tuple) {
	VTK.API_vtkDataArray.SetTuple(obj, tupleIdx, tuple);
}


//       Method: virtual void vtkDataArray::SetTuple(vtkIdType tupleIdx, const double* tuple)
// 
public void SetTuple(long tupleIdx, double/*const double* */ tuple) {
	VTK.API_vtkDataArray.SetTuple(obj, tupleIdx, tuple);
}


//       Method: void vtkDataArray::SetTuple1(vtkIdType tupleIdx, double value)
// 
public void SetTuple1(long tupleIdx, double value) {
	VTK.API_vtkDataArray.SetTuple1(obj, tupleIdx, value);
}


//       Method: void vtkDataArray::SetTuple2(vtkIdType tupleIdx, double val0, double val1)
// 
public void SetTuple2(long tupleIdx, double val0, double val1) {
	VTK.API_vtkDataArray.SetTuple2(obj, tupleIdx, val0, val1);
}


//       Method: void vtkDataArray::SetTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// 
public void SetTuple3(long tupleIdx, double val0, double val1, double val2) {
	VTK.API_vtkDataArray.SetTuple3(obj, tupleIdx, val0, val1, val2);
}


//       Method: void vtkDataArray::SetTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// 
public void SetTuple4(long tupleIdx, double val0, double val1, double val2, double val3) {
	VTK.API_vtkDataArray.SetTuple4(obj, tupleIdx, val0, val1, val2, val3);
}


//       Method: void vtkDataArray::SetTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// 
public void SetTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5) {
	VTK.API_vtkDataArray.SetTuple6(obj, tupleIdx, val0, val1, val2, val3, val4, val5);
}


//       Method: void vtkDataArray::SetTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
public void SetTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8) {
	VTK.API_vtkDataArray.SetTuple9(obj, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


//       Method: virtual void vtkDataArray::InsertTuple(vtkIdType tupleIdx, const float* tuple)
// 
public void InsertTuple(long tupleIdx, float/*const float* */ tuple) {
	VTK.API_vtkDataArray.InsertTuple(obj, tupleIdx, tuple);
}


//       Method: virtual void vtkDataArray::InsertTuple(vtkIdType tupleIdx, const double* tuple)
// 
public void InsertTuple(long tupleIdx, double/*const double* */ tuple) {
	VTK.API_vtkDataArray.InsertTuple(obj, tupleIdx, tuple);
}


//       Method: void vtkDataArray::InsertTuple1(vtkIdType tupleIdx, double value)
// 
public void InsertTuple1(long tupleIdx, double value) {
	VTK.API_vtkDataArray.InsertTuple1(obj, tupleIdx, value);
}


//       Method: void vtkDataArray::InsertTuple2(vtkIdType tupleIdx, double val0, double val1)
// 
public void InsertTuple2(long tupleIdx, double val0, double val1) {
	VTK.API_vtkDataArray.InsertTuple2(obj, tupleIdx, val0, val1);
}


//       Method: void vtkDataArray::InsertTuple3(vtkIdType tupleIdx, double val0, double val1, double val2)
// 
public void InsertTuple3(long tupleIdx, double val0, double val1, double val2) {
	VTK.API_vtkDataArray.InsertTuple3(obj, tupleIdx, val0, val1, val2);
}


//       Method: void vtkDataArray::InsertTuple4(vtkIdType tupleIdx, double val0, double val1, double val2, double val3)
// 
public void InsertTuple4(long tupleIdx, double val0, double val1, double val2, double val3) {
	VTK.API_vtkDataArray.InsertTuple4(obj, tupleIdx, val0, val1, val2, val3);
}


//       Method: void vtkDataArray::InsertTuple6(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
// 
public void InsertTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5) {
	VTK.API_vtkDataArray.InsertTuple6(obj, tupleIdx, val0, val1, val2, val3, val4, val5);
}


//       Method: void vtkDataArray::InsertTuple9(vtkIdType tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
public void InsertTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8) {
	VTK.API_vtkDataArray.InsertTuple9(obj, tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


//       Method: virtual vtkIdType vtkDataArray::InsertNextTuple(const float* tuple)
// 
public long InsertNextTuple(float/*const float* */ tuple) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.InsertNextTuple(p,obj, tuple);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkDataArray::InsertNextTuple(const double* tuple)
// 
public long InsertNextTuple(double/*const double* */ tuple) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.InsertNextTuple(p,obj, tuple);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::InsertNextTuple1(double value)
// 
public void InsertNextTuple1(double value) {
	VTK.API_vtkDataArray.InsertNextTuple1(obj, value);
}


//       Method: void vtkDataArray::InsertNextTuple2(double val0, double val1)
// 
public void InsertNextTuple2(double val0, double val1) {
	VTK.API_vtkDataArray.InsertNextTuple2(obj, val0, val1);
}


//       Method: void vtkDataArray::InsertNextTuple3(double val0, double val1, double val2)
// 
public void InsertNextTuple3(double val0, double val1, double val2) {
	VTK.API_vtkDataArray.InsertNextTuple3(obj, val0, val1, val2);
}


//       Method: void vtkDataArray::InsertNextTuple4(double val0, double val1, double val2, double val3)
// 
public void InsertNextTuple4(double val0, double val1, double val2, double val3) {
	VTK.API_vtkDataArray.InsertNextTuple4(obj, val0, val1, val2, val3);
}


//       Method: void vtkDataArray::InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
// 
public void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5) {
	VTK.API_vtkDataArray.InsertNextTuple6(obj, val0, val1, val2, val3, val4, val5);
}


//       Method: void vtkDataArray::InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
// 
public void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8) {
	VTK.API_vtkDataArray.InsertNextTuple9(obj, val0, val1, val2, val3, val4, val5, val6, val7, val8);
}


//       Method: virtual void vtkDataArray::RemoveTuple(vtkIdType tupleIdx)
// 
public void RemoveTuple(long tupleIdx) {
	VTK.API_vtkDataArray.RemoveTuple(obj, tupleIdx);
}


//       Method: virtual void vtkDataArray::RemoveFirstTuple()
// 
public void RemoveFirstTuple() {
	VTK.API_vtkDataArray.RemoveFirstTuple(obj);
}


//       Method: virtual void vtkDataArray::RemoveLastTuple()
// 
public void RemoveLastTuple() {
	VTK.API_vtkDataArray.RemoveLastTuple(obj);
}


//       Method: virtual double vtkDataArray::GetComponent(vtkIdType tupleIdx, int compIdx)
// 
public double GetComponent(long tupleIdx, int compIdx) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetComponent(p,obj, tupleIdx, compIdx);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkDataArray::SetComponent(vtkIdType tupleIdx, int compIdx, double value)
// 
public void SetComponent(long tupleIdx, int compIdx, double value) {
	VTK.API_vtkDataArray.SetComponent(obj, tupleIdx, compIdx, value);
}


//       Method: virtual void vtkDataArray::InsertComponent(vtkIdType tupleIdx, int compIdx, double value)
// 
public void InsertComponent(long tupleIdx, int compIdx, double value) {
	VTK.API_vtkDataArray.InsertComponent(obj, tupleIdx, compIdx, value);
}


//       Method: virtual void vtkDataArray::GetData(vtkIdType tupleMin, vtkIdType tupleMax, int compMin, int compMax, vtkDoubleArray* data)
// 
public void GetData(long tupleMin, long tupleMax, int compMin, int compMax, vtkDoubleArray/*vtkDoubleArray* */ data) {
	VTK.API_vtkDataArray.GetData(obj, tupleMin, tupleMax, compMin, compMax, data);
}


//       Method: void vtkDataArray::DeepCopy(vtkAbstractArray* aa)
// 
public void DeepCopy(vtkAbstractArray/*vtkAbstractArray* */ aa) {
	VTK.API_vtkDataArray.DeepCopy(obj, aa);
}


//       Method: virtual void vtkDataArray::DeepCopy(vtkDataArray* da)
// 
public void DeepCopy(vtkDataArray/*vtkDataArray* */ da) {
	VTK.API_vtkDataArray.DeepCopy(obj, da);
}


//       Method: virtual void vtkDataArray::ShallowCopy(vtkDataArray* other)
// 
public void ShallowCopy(vtkDataArray/*vtkDataArray* */ other) {
	VTK.API_vtkDataArray.ShallowCopy(obj, other);
}


//       Method: virtual void vtkDataArray::FillComponent(int compIdx, double value)
// 
public void FillComponent(int compIdx, double value) {
	VTK.API_vtkDataArray.FillComponent(obj, compIdx, value);
}


//       Method: virtual void vtkDataArray::Fill(double value)
// 
public void Fill(double value) {
	VTK.API_vtkDataArray.Fill(obj, value);
}


//       Method: virtual void vtkDataArray::CopyComponent(int dstComponent, vtkDataArray* src, int srcComponent)
// 
public void CopyComponent(int dstComponent, vtkDataArray/*vtkDataArray* */ src, int srcComponent) {
	VTK.API_vtkDataArray.CopyComponent(obj, dstComponent, src, srcComponent);
}


//       Method: virtual void * vtkDataArray::WriteVoidPointer(vtkIdType valueIdx, vtkIdType numValues)
// 
public IntPtr WriteVoidPointer(long valueIdx, long numValues) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.WriteVoidPointer(p,obj, valueIdx, numValues);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::CreateDefaultLookupTable()
// 
public void CreateDefaultLookupTable() {
	VTK.API_vtkDataArray.CreateDefaultLookupTable(obj);
}


//       Method: void vtkDataArray::SetLookupTable(vtkLookupTable* lut)
// 
public void SetLookupTable(vtkLookupTable/*vtkLookupTable* */ lut) {
	VTK.API_vtkDataArray.SetLookupTable(obj, lut);
}


//       Method: void vtkDataArray::GetRange(double range[2], int comp)
// 
public void GetRange(double[] /*2*/ range, int comp) {
	VTK.API_vtkDataArray.GetRange(obj, range, comp);
}


//       Method: double * vtkDataArray::GetRange(int comp)
// 
public double[] GetRange(int comp) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetRange(p,obj, comp);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetRange()
// 
public double[] GetRange() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetRange(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::GetRange(double range[2])
// 
public void GetRange(double[] /*2*/ range) {
	VTK.API_vtkDataArray.GetRange(obj, range);
}


//       Method: void vtkDataArray::GetFiniteRange(double range[2], int comp)
// 
public void GetFiniteRange(double[] /*2*/ range, int comp) {
	VTK.API_vtkDataArray.GetFiniteRange(obj, range, comp);
}


//       Method: double * vtkDataArray::GetFiniteRange(int comp)
// 
public double[] GetFiniteRange(int comp) {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetFiniteRange(p,obj, comp);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double * vtkDataArray::GetFiniteRange()
// 
public double[] GetFiniteRange() {
	int numElements = 1;
	double[] example = new double[numElements];
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetFiniteRange(p,obj);
	double[] result = new double[numElements];
	Marshal.Copy (p, result, 0, numElements);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::GetFiniteRange(double range[2])
// 
public void GetFiniteRange(double[] /*2*/ range) {
	VTK.API_vtkDataArray.GetFiniteRange(obj, range);
}


//       Method: void vtkDataArray::GetDataTypeRange(double range[2])
// 
public void GetDataTypeRange(double[] /*2*/ range) {
	VTK.API_vtkDataArray.GetDataTypeRange(obj, range);
}


//       Method: double vtkDataArray::GetDataTypeMin()
// 
public double GetDataTypeMin() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetDataTypeMin(p,obj);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: double vtkDataArray::GetDataTypeMax()
// 
public double GetDataTypeMax() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetDataTypeMax(p,obj);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static void vtkDataArray::GetDataTypeRange(int type, double range[2])
// 
public static void GetDataTypeRange(int type, double[] /*2*/ range) {
	VTK.API_vtkDataArray.GetDataTypeRange(type, range);
}


//       Method: static double vtkDataArray::GetDataTypeMin(int type)
// 
public static double GetDataTypeMin(int type) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetDataTypeMin(p, type);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static double vtkDataArray::GetDataTypeMax(int type)
// 
public static double GetDataTypeMax(int type) {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetDataTypeMax(p, type);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual double vtkDataArray::GetMaxNorm()
// 
public double GetMaxNorm() {
	int numElements = 1;
	double example = new double();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetMaxNorm(p,obj);
	double result;
	Marshal.Copy (p, result, 0, 1);
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkDataArray * vtkDataArray::CreateDataArray(int dataType)
// 
public static vtkDataArray CreateDataArray(int dataType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.CreateDataArray(p, dataType);
	vtkDataArray result = new vtkDataArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::COMPONENT_RANGE()
// 
public static vtkInformationDoubleVectorKey COMPONENT_RANGE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.COMPONENT_RANGE(p);
	vtkInformationDoubleVectorKey result = new vtkInformationDoubleVectorKey();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::L2_NORM_RANGE()
// 
public static vtkInformationDoubleVectorKey L2_NORM_RANGE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.L2_NORM_RANGE(p);
	vtkInformationDoubleVectorKey result = new vtkInformationDoubleVectorKey();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkInformationDoubleVectorKey * vtkDataArray::L2_NORM_FINITE_RANGE()
// 
public static vtkInformationDoubleVectorKey L2_NORM_FINITE_RANGE() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.L2_NORM_FINITE_RANGE(p);
	vtkInformationDoubleVectorKey result = new vtkInformationDoubleVectorKey();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkDataArray::Modified()
// 
public void Modified() {
	VTK.API_vtkDataArray.Modified(obj);
}

//
////       Method: static vtkInformationStringKey * vtkDataArray::UNITS_LABEL()
//// 
//public static vtkInformationStringKey UNITS_LABEL() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkDataArray.UNITS_LABEL(p);
//	vtkInformationStringKey result = new vtkInformationStringKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//
//
////       Method: int vtkDataArray::CopyInformation(vtkInformation* infoFrom, int deep)
//// 
//public int CopyInformation(vtkInformation/*vtkInformation* */ infoFrom, int deep) {
//	int numElements = 1;
//	int example = new int();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkDataArray.CopyInformation(p,obj, infoFrom, deep);
//	int result = Convert.ToInt32(Marshal.ReadInt32(p));
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: int vtkDataArray::GetArrayType()
// 
public int GetArrayType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkDataArray.GetArrayType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
