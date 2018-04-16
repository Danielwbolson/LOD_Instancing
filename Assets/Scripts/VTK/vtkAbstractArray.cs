
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkAbstractArray : vtkObject {

//       Method: virtual const char * vtkAbstractArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkAbstractArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAbstractArray::Allocate(vtkIdType numValues, vtkIdType ext)
// 
public int Allocate(long numValues, long ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.Allocate(p,obj, numValues, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::Initialize()
// 
public void Initialize() {
	VTK.API_vtkAbstractArray.Initialize(obj);
}


//       Method: virtual int vtkAbstractArray::GetDataType()
// 
public int GetDataType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetDataType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAbstractArray::GetDataTypeSize()
// 
public int GetDataTypeSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetDataTypeSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static int vtkAbstractArray::GetDataTypeSize(int type)
// 
public static int GetDataTypeSize(int type) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetDataTypeSize(p, type);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAbstractArray::GetElementComponentSize()
// 
public int GetElementComponentSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetElementComponentSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAbstractArray::GetNumberOfComponents()
// 
public int GetNumberOfComponents() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetNumberOfComponents(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAbstractArray::SetComponentName(vtkIdType component, const char* name)
// 
public void SetComponentName(long component, string/*const char* */ name) {
	VTK.API_vtkAbstractArray.SetComponentName(obj, component, name);
}


//       Method: const char * vtkAbstractArray::GetComponentName(vtkIdType component)
// 
public string GetComponentName(long component) {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkAbstractArray.GetComponentName(p,obj, component);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: bool vtkAbstractArray::HasAComponentName()
// 
public bool HasAComponentName() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.HasAComponentName(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkAbstractArray::CopyComponentNames(vtkAbstractArray* da)
// 
public int CopyComponentNames(vtkAbstractArray/*vtkAbstractArray* */ da) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.CopyComponentNames(p,obj, da);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::SetNumberOfTuples(vtkIdType numTuples)
// 
public void SetNumberOfTuples(long numTuples) {
	VTK.API_vtkAbstractArray.SetNumberOfTuples(obj, numTuples);
}


//       Method: virtual void vtkAbstractArray::SetNumberOfValues(vtkIdType numValues)
// 
public void SetNumberOfValues(long numValues) {
	VTK.API_vtkAbstractArray.SetNumberOfValues(obj, numValues);
}


//       Method: vtkIdType vtkAbstractArray::GetNumberOfTuples()
// 
public long GetNumberOfTuples() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetNumberOfTuples(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkAbstractArray.SetTuple(obj, dstTupleIdx, srcTupleIdx, source);
}


//       Method: virtual void vtkAbstractArray::InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkAbstractArray.InsertTuple(obj, dstTupleIdx, srcTupleIdx, source);
}


//       Method: virtual void vtkAbstractArray::InsertTuples(vtkIdList* dstIds, vtkIdList* srcIds, vtkAbstractArray* source)
// 
public void InsertTuples(vtkIdList/*vtkIdList* */ dstIds, vtkIdList/*vtkIdList* */ srcIds, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkAbstractArray.InsertTuples(obj, dstIds, srcIds, source);
}


//       Method: virtual void vtkAbstractArray::InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)
// 
public void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray/*vtkAbstractArray* */ source) {
	VTK.API_vtkAbstractArray.InsertTuples(obj, dstStart, n, srcStart, source);
}


//       Method: virtual vtkIdType vtkAbstractArray::InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)
// 
public long InsertNextTuple(long srcTupleIdx, vtkAbstractArray/*vtkAbstractArray* */ source) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.InsertNextTuple(p,obj, srcTupleIdx, source);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::GetTuples(vtkIdList* tupleIds, vtkAbstractArray* output)
// 
public void GetTuples(vtkIdList/*vtkIdList* */ tupleIds, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkAbstractArray.GetTuples(obj, tupleIds, output);
}


//       Method: virtual void vtkAbstractArray::GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray* output)
// 
public void GetTuples(long p1, long p2, vtkAbstractArray/*vtkAbstractArray* */ output) {
	VTK.API_vtkAbstractArray.GetTuples(obj, p1, p2, output);
}


//       Method: virtual bool vtkAbstractArray::HasStandardMemoryLayout()
// 
public bool HasStandardMemoryLayout() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.HasStandardMemoryLayout(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void * vtkAbstractArray::GetVoidPointer(vtkIdType valueIdx)
// 
public IntPtr GetVoidPointer(long valueIdx) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetVoidPointer(p,obj, valueIdx);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::DeepCopy(vtkAbstractArray* da)
// 
public void DeepCopy(vtkAbstractArray/*vtkAbstractArray* */ da) {
	VTK.API_vtkAbstractArray.DeepCopy(obj, da);
}


//       Method: virtual void vtkAbstractArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList* ptIndices, vtkAbstractArray* source, double* weights)
// 
public void InterpolateTuple(long dstTupleIdx, vtkIdList/*vtkIdList* */ ptIndices, vtkAbstractArray/*vtkAbstractArray* */ source, double/*double* */ weights) {
	VTK.API_vtkAbstractArray.InterpolateTuple(obj, dstTupleIdx, ptIndices, source, weights);
}


//       Method: virtual void vtkAbstractArray::InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)
// 
public void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray/*vtkAbstractArray* */ source1, long srcTupleIdx2, vtkAbstractArray/*vtkAbstractArray* */ source2, double t) {
	VTK.API_vtkAbstractArray.InterpolateTuple(obj, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


//       Method: virtual void vtkAbstractArray::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkAbstractArray.Squeeze(obj);
}


//       Method: virtual int vtkAbstractArray::Resize(vtkIdType numTuples)
// 
public int Resize(long numTuples) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.Resize(p,obj, numTuples);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkAbstractArray::Reset()
// 
public void Reset() {
	VTK.API_vtkAbstractArray.Reset(obj);
}


//       Method: vtkIdType vtkAbstractArray::GetSize()
// 
public long GetSize() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetSize(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkAbstractArray::GetMaxId()
// 
public long GetMaxId() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetMaxId(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::ExportToVoidPointer(void* out_ptr)
// 
public void ExportToVoidPointer(IntPtr/*void* */ out_ptr) {
	VTK.API_vtkAbstractArray.ExportToVoidPointer(obj, out_ptr);
}


//       Method: static vtkAbstractArray * vtkAbstractArray::CreateArray(int dataType)
// 
public static vtkAbstractArray CreateArray(int dataType) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.CreateArray(p, dataType);
	vtkAbstractArray result = new vtkAbstractArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual int vtkAbstractArray::IsNumeric()
// 
public int IsNumeric() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.IsNumeric(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


////       Method: virtual vtkArrayIterator * vtkAbstractArray::NewIterator()
//// 
//public vtkArrayIterator NewIterator() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.NewIterator(p,obj);
//	vtkArrayIterator result = new vtkArrayIterator();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: virtual vtkIdType vtkAbstractArray::GetDataSize()
// 
public long GetDataSize() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetDataSize(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkAbstractArray::DataChanged()
// 
public void DataChanged() {
	VTK.API_vtkAbstractArray.DataChanged(obj);
}


//       Method: virtual void vtkAbstractArray::ClearLookup()
// 
public void ClearLookup() {
	VTK.API_vtkAbstractArray.ClearLookup(obj);
}


////       Method: vtkInformation * vtkAbstractArray::GetInformation()
//// 
//public vtkInformation GetInformation() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.GetInformation(p,obj);
//	vtkInformation result = new vtkInformation();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: bool vtkAbstractArray::HasInformation()
// 
public bool HasInformation() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.HasInformation(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


////       Method: virtual int vtkAbstractArray::CopyInformation(vtkInformation* infoFrom, int deep)
//// 
//public int CopyInformation(vtkInformation/*vtkInformation* */ infoFrom, int deep) {
//	int numElements = 1;
//	int example = new int();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.CopyInformation(p,obj, infoFrom, deep);
//	int result = Convert.ToInt32(Marshal.ReadInt32(p));
//	Marshal.FreeHGlobal (p);
//	return result;
//}


////       Method: static vtkInformationIntegerKey * vtkAbstractArray::GUI_HIDE()
//// 
//public static vtkInformationIntegerKey GUI_HIDE() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.GUI_HIDE(p);
//	vtkInformationIntegerKey result = new vtkInformationIntegerKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}

//
////       Method: static vtkInformationInformationVectorKey * vtkAbstractArray::PER_COMPONENT()
//// 
//public static vtkInformationInformationVectorKey PER_COMPONENT() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.PER_COMPONENT(p);
//	vtkInformationInformationVectorKey result = new vtkInformationInformationVectorKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}

//
////       Method: static vtkInformationInformationVectorKey * vtkAbstractArray::PER_FINITE_COMPONENT()
//// 
//public static vtkInformationInformationVectorKey PER_FINITE_COMPONENT() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.PER_FINITE_COMPONENT(p);
//	vtkInformationInformationVectorKey result = new vtkInformationInformationVectorKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: void vtkAbstractArray::Modified()
// 
public void Modified() {
	VTK.API_vtkAbstractArray.Modified(obj);
}

//
////       Method: static vtkInformationVariantVectorKey * vtkAbstractArray::DISCRETE_VALUES()
//// 
//public static vtkInformationVariantVectorKey DISCRETE_VALUES() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.DISCRETE_VALUES(p);
//	vtkInformationVariantVectorKey result = new vtkInformationVariantVectorKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//
//
////       Method: static vtkInformationDoubleVectorKey * vtkAbstractArray::DISCRETE_VALUE_SAMPLE_PARAMETERS()
//// 
//public static vtkInformationDoubleVectorKey DISCRETE_VALUE_SAMPLE_PARAMETERS() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkAbstractArray.DISCRETE_VALUE_SAMPLE_PARAMETERS(p);
//	vtkInformationDoubleVectorKey result = new vtkInformationDoubleVectorKey();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}
//

//       Method: virtual int vtkAbstractArray::GetArrayType()
// 
public int GetArrayType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkAbstractArray.GetArrayType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
