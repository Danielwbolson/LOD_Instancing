

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractArray : vtkObject {

// virtual int Allocate(vtkIdType numValues, vtkIdType ext = 1000)
// "virtual int Allocate(vtkIdType numValues, vtkIdType ext=1000)"
public new int Allocate(long /*(vtkIdType)*/ numValues, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.Allocate_0(this, returnPointer, numValues, ext);
	return Ptr.deref(returnPointer);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkAbstractArray.Initialize_0(this);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public new int GetDataType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetDataType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int GetDataTypeSize()
// "virtual int GetDataTypeSize()"
public new int GetDataTypeSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetDataTypeSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// static int GetDataTypeSize(int type)
// "static int GetDataTypeSize(int type)"
public new static int GetDataTypeSize(int /*(int)*/ type) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetDataTypeSize_1(returnPointer, type);
	return Ptr.deref(returnPointer);
}


// virtual int GetElementComponentSize()
// "virtual int GetElementComponentSize()"
public new int GetElementComponentSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetElementComponentSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public new int GetNumberOfComponents() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetNumberOfComponents_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetComponentName(vtkIdType component, const char * name)
// "void SetComponentName( vtkIdType component, const char *name )"
public new void SetComponentName(long /*(vtkIdType)*/ component, char /*(char*)*/ []name) {
	API_vtkAbstractArray.SetComponentName_0(this, component, name);
}


// char* GetComponentName(vtkIdType component)
// "const char* GetComponentName( vtkIdType component )"
public new char GetComponentName(long /*(vtkIdType)*/ component) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkAbstractArray.GetComponentName_0(this, returnPointer, component);
	return Ptr.deref(returnPointer);
}


// bool HasAComponentName()
// "bool HasAComponentName()"
public new bool HasAComponentName() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkAbstractArray.HasAComponentName_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int CopyComponentNames(vtkAbstractArray * da)
// "int CopyComponentNames( vtkAbstractArray *da )"
public new int CopyComponentNames(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.CopyComponentNames_0(this, returnPointer, da);
	return Ptr.deref(returnPointer);
}


// virtual void SetNumberOfTuples(vtkIdType numTuples)
// "virtual void SetNumberOfTuples(vtkIdType numTuples)"
public new void SetNumberOfTuples(long /*(vtkIdType)*/ numTuples) {
	API_vtkAbstractArray.SetNumberOfTuples_0(this, numTuples);
}


// virtual void SetNumberOfValues(vtkIdType numValues)
// "virtual void SetNumberOfValues(vtkIdType numValues)"
public new void SetNumberOfValues(long /*(vtkIdType)*/ numValues) {
	API_vtkAbstractArray.SetNumberOfValues_0(this, numValues);
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public new long GetNumberOfTuples() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractArray.GetNumberOfTuples_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray *source)"
public new void SetTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkAbstractArray.SetTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public new void InsertTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkAbstractArray.InsertTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray* source)"
public new void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkAbstractArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public new void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkAbstractArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public new long InsertNextTuple(long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractArray.InsertNextTuple_0(this, returnPointer, srcTupleIdx, source);
	return Ptr.deref(returnPointer);
}


// virtual void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdList *tupleIds, vtkAbstractArray* output)"
public new void GetTuples(vtkIdList /*(vtkIdList*)*/ tupleIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkAbstractArray.GetTuples_0(this, tupleIds, output);
}


// virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public new void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkAbstractArray.GetTuples_1(this, p1, p2, output);
}


// virtual bool HasStandardMemoryLayout()
// "virtual bool HasStandardMemoryLayout()"
public new bool HasStandardMemoryLayout() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkAbstractArray.HasStandardMemoryLayout_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void* GetVoidPointer(vtkIdType valueIdx)
// "virtual void *GetVoidPointer(vtkIdType valueIdx)"
public new IntPtr GetVoidPointer(long /*(vtkIdType)*/ valueIdx) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkAbstractArray.GetVoidPointer_0(this, returnPointer, valueIdx);
	return Ptr.deref(returnPointer);
}


// virtual void DeepCopy(vtkAbstractArray * da)
// "virtual void DeepCopy(vtkAbstractArray* da)"
public new void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	API_vtkAbstractArray.DeepCopy_0(this, da);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public new void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, double /*(double*)*/ []weights) {
	API_vtkAbstractArray.InterpolateTuple_0(this, dstTupleIdx, ptIndices, source, weights);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)"
public new void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	API_vtkAbstractArray.InterpolateTuple_1(this, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public new void Squeeze() {
	API_vtkAbstractArray.Squeeze_0(this);
}


// virtual int Resize(vtkIdType numTuples)
// "virtual int Resize(vtkIdType numTuples)"
public new int Resize(long /*(vtkIdType)*/ numTuples) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.Resize_0(this, returnPointer, numTuples);
	return Ptr.deref(returnPointer);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkAbstractArray.Reset_0(this);
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public new long GetSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractArray.GetSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetMaxId()
// "vtkIdType GetMaxId()"
public new long GetMaxId() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractArray.GetMaxId_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void ExportToVoidPointer(void * out_ptr)
// "virtual void ExportToVoidPointer(void *out_ptr)"
public new void ExportToVoidPointer(IntPtr /*(void*)*/ []out_ptr) {
	API_vtkAbstractArray.ExportToVoidPointer_0(this, out_ptr);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkAbstractArray.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual char* GetDataTypeAsString()
// "virtual const char *GetDataTypeAsString( void )"
public new char GetDataTypeAsString() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkAbstractArray.GetDataTypeAsString_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual int IsNumeric()
// "virtual int IsNumeric()"
public new int IsNumeric() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.IsNumeric_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType GetDataSize()
// "virtual vtkIdType GetDataSize()"
public new long GetDataSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkAbstractArray.GetDataSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void DataChanged()
// "virtual void DataChanged()"
public new void DataChanged() {
	API_vtkAbstractArray.DataChanged_0(this);
}


// virtual void ClearLookup()
// "virtual void ClearLookup()"
public new void ClearLookup() {
	API_vtkAbstractArray.ClearLookup_0(this);
}


// bool HasInformation()
// "bool HasInformation()"
public new bool HasInformation() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new bool())*return_elements);
	API_vtkAbstractArray.HasInformation_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Modified()
// "void Modified()"
public new void Modified() {
	API_vtkAbstractArray.Modified_0(this);
}


// virtual int GetArrayType()
// "virtual int GetArrayType()"
public new int GetArrayType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkAbstractArray.GetArrayType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
