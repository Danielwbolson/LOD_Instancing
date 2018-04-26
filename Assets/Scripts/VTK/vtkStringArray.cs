
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkStringArray : vtkAbstractArray {

//       Method: static vtkStringArray * vtkStringArray::New()
// 
public static vtkStringArray New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.New(p);
	vtkStringArray result = new vtkStringArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkStringArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkStringArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkStringArray::GetDataType()
// 
public int GetDataType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetDataType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkStringArray::IsNumeric()
// 
public int IsNumeric() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.IsNumeric(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::Initialize()
// 
public void Initialize() {
	VTK.API_vtkStringArray.Initialize(obj);
}


//       Method: int vtkStringArray::GetDataTypeSize()
// 
public int GetDataTypeSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetDataTypeSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkStringArray.Squeeze(obj);
}


//       Method: int vtkStringArray::Resize(vtkIdType numTuples)
// 
public int Resize(long numTuples) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.Resize(p,obj, numTuples);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
// 
public void SetTuple(long i, long j, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkStringArray.SetTuple(obj, i, j, source);
}


//       Method: void vtkStringArray::InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)
// 
public void InsertTuple(long i, long j, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkStringArray.InsertTuple(obj, i, j, source);
}


//       Method: void vtkStringArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
public void InsertTuples(vtkIdList/*vtkIdList* */ dstIds, vtkIdList/*vtkIdList* */ srcIds, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkStringArray.InsertTuples(obj, dstIds, srcIds, source);
}


//       Method: void vtkStringArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
public void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkStringArray.InsertTuples(obj, dstStart, n, srcStart, source);
}


//       Method: vtkIdType vtkStringArray::InsertNextTuple(vtkIdType j, vtkAbstractArray* source)
// 
public long InsertNextTuple(long j, vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.InsertNextTuple(p,obj, j, source);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::InterpolateTuple(vtkIdType i, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
public void InterpolateTuple(long i, vtkIdList/*vtkIdList* */ ptIndices, vtkAbstractArray/*vtkAbstractArray* */ source, double/*double* */ weights) {
	VTK.API_vtkStringArray.InterpolateTuple(obj, i, ptIndices, source, weights);
}


//       Method: void vtkStringArray::InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)
// 
public void InterpolateTuple(long i, long id1, vtkAbstractArray/*vtkAbstractArray* */ source1, long id2, vtkAbstractArray/*vtkAbstractArray* */ source2, double t) {
	VTK.API_vtkStringArray.InterpolateTuple(obj, i, id1, source1, id2, source2, t);
}


//       Method: void vtkStringArray::GetTuples(vtkIdList* ptIds, vtkAbstractArray* output)
// 
public void GetTuples(vtkIdList/*vtkIdList* */ ptIds, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkStringArray.GetTuples(obj, ptIds, output);
}


//       Method: void vtkStringArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
public void GetTuples(long p1, long p2, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkStringArray.GetTuples(obj, p1, p2, output);
}


//       Method: int vtkStringArray::Allocate(vtkIdType sz, vtkIdType ext)
// 
public int Allocate(long sz, long ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.Allocate(p,obj, sz, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::SetValue(vtkIdType id, const char* value)
// 
public void SetValue(long id, string/*const char* */ value) {
	VTK.API_vtkStringArray.SetValue(obj, id, value);
}


//       Method: void vtkStringArray::SetNumberOfTuples(vtkIdType number)
// 
public void SetNumberOfTuples(long number) {
	VTK.API_vtkStringArray.SetNumberOfTuples(obj, number);
}


//       Method: void vtkStringArray::SetNumberOfValues(vtkIdType number)
// 
public void SetNumberOfValues(long number) {
	VTK.API_vtkStringArray.SetNumberOfValues(obj, number);
}


//       Method: vtkIdType vtkStringArray::GetNumberOfValues()
// 
public long GetNumberOfValues() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetNumberOfValues(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkStringArray::GetNumberOfElementComponents()
// 
public int GetNumberOfElementComponents() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetNumberOfElementComponents(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkStringArray::GetElementComponentSize()
// 
public int GetElementComponentSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetElementComponentSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::InsertValue(vtkIdType id, const char* val)
// 
public void InsertValue(long id, string/*const char* */ val) {
	VTK.API_vtkStringArray.InsertValue(obj, id, val);
}


//       Method: vtkIdType vtkStringArray::InsertNextValue(const char* f)
// 
public long InsertNextValue(string/*const char* */ f) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.InsertNextValue(p,obj, f);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void * vtkStringArray::GetVoidPointer(vtkIdType id)
// 
public IntPtr GetVoidPointer(long id) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetVoidPointer(p,obj, id);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::DeepCopy(vtkAbstractArray* aa)
// 
public void DeepCopy(vtkAbstractArray/*vtkAbstractArray* */ aa) {
	VTK.API_vtkStringArray.DeepCopy(obj, aa);
}


//       Method: void vtkStringArray::SetVoidArray(void* array, vtkIdType size, int save)
// 
public void SetVoidArray(IntPtr/*void* */ array, long size, int save) {
	VTK.API_vtkStringArray.SetVoidArray(obj, array, size, save);
}


//       Method: vtkIdType vtkStringArray::GetDataSize()
// 
public long GetDataSize() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.GetDataSize(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkStringArray::LookupValue(const char* value)
// 
public long LookupValue(string/*const char* */ value) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkStringArray.LookupValue(p,obj, value);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkStringArray::LookupValue(const char* value, vtkIdList* ids)
// 
public void LookupValue(string/*const char* */ value, vtkIdList/*vtkIdList* */ ids) {
	VTK.API_vtkStringArray.LookupValue(obj, value, ids);
}


//       Method: void vtkStringArray::DataChanged()
// 
public void DataChanged() {
	VTK.API_vtkStringArray.DataChanged(obj);
}


//       Method: virtual void vtkStringArray::DataElementChanged(vtkIdType id)
// 
public void DataElementChanged(long id) {
	VTK.API_vtkStringArray.DataElementChanged(obj, id);
}


//       Method: void vtkStringArray::ClearLookup()
// 
public void ClearLookup() {
	VTK.API_vtkStringArray.ClearLookup(obj);
}


}
};
