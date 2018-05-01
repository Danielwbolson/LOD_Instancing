

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStringArray : vtkAbstractArray {

// static vtkStringArray* New()
// "static vtkStringArray* New()"
public new static vtkStringArray New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkStringArray.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetDataType()
// "int GetDataType()"
public new int GetDataType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.GetDataType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int IsNumeric()
// "int IsNumeric()"
public new int IsNumeric() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.IsNumeric_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkStringArray.Initialize_0(this);
}


// int GetDataTypeSize()
// "int GetDataTypeSize()"
public new int GetDataTypeSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.GetDataTypeSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkStringArray.Squeeze_0(this);
}


// int Resize(vtkIdType numTuples)
// "int Resize(vtkIdType numTuples)"
public new int Resize(long /*(vtkIdType)*/ numTuples) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.Resize_0(this, returnPointer, numTuples);
	return Ptr.deref(returnPointer);
}


// void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public new void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkStringArray.SetTuple_0(this, i, j, source);
}


// void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public new void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkStringArray.InsertTuple_0(this, i, j, source);
}


// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)"
public new void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkStringArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public new void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	API_vtkStringArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray * source)
// "vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray* source)"
public new long InsertNextTuple(long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.InsertNextTuple_0(this, returnPointer, j, source);
	return Ptr.deref(returnPointer);
}


// void InterpolateTuple(vtkIdType i, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "void InterpolateTuple(vtkIdType i, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public new void InterpolateTuple(long /*(vtkIdType)*/ i, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, double /*(double*)*/ []weights) {
	API_vtkStringArray.InterpolateTuple_0(this, i, ptIndices, source, weights);
}


// void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray * source1, vtkIdType id2, vtkAbstractArray * source2, double t)
// "void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)"
public new void InterpolateTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ id1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ id2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	API_vtkStringArray.InterpolateTuple_1(this, i, id1, source1, id2, source2, t);
}


// void GetTuples(vtkIdList * ptIds, vtkAbstractArray * output)
// "void GetTuples(vtkIdList *ptIds, vtkAbstractArray *output)"
public new void GetTuples(vtkIdList /*(vtkIdList*)*/ ptIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkStringArray.GetTuples_0(this, ptIds, output);
}


// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public new void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	API_vtkStringArray.GetTuples_1(this, p1, p2, output);
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate( vtkIdType sz, vtkIdType ext=1000 )"
public new int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// vtkStdString& GetValue(vtkIdType id)
// "vtkStdString &GetValue(vtkIdType id)"
public new string GetValue(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new string())*return_elements);
	API_vtkStringArray.GetValue_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// void SetValue(vtkIdType id, vtkStdString value)
// "void SetValue(vtkIdType id, vtkStdString value)"
public new void SetValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ value) {
	API_vtkStringArray.SetValue_0(this, id, value);
}


// void SetValue(vtkIdType id, const char * value)
// "void SetValue(vtkIdType id, const char *value)"
public new void SetValue(long /*(vtkIdType)*/ id, char /*(char*)*/ []value) {
	API_vtkStringArray.SetValue_1(this, id, value);
}


// void SetNumberOfTuples(vtkIdType number)
// "void SetNumberOfTuples(vtkIdType number)"
public new void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	API_vtkStringArray.SetNumberOfTuples_0(this, number);
}


// void SetNumberOfValues(vtkIdType number)
// "void SetNumberOfValues(vtkIdType number)"
public new void SetNumberOfValues(long /*(vtkIdType)*/ number) {
	API_vtkStringArray.SetNumberOfValues_0(this, number);
}


// vtkIdType GetNumberOfValues()
// "vtkIdType GetNumberOfValues()"
public new long GetNumberOfValues() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.GetNumberOfValues_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfElementComponents()
// "int GetNumberOfElementComponents()"
public new int GetNumberOfElementComponents() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.GetNumberOfElementComponents_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int GetElementComponentSize()
// "int GetElementComponentSize()"
public new int GetElementComponentSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkStringArray.GetElementComponentSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void InsertValue(vtkIdType id, vtkStdString f)
// "void InsertValue(vtkIdType id, vtkStdString f)"
public new void InsertValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ f) {
	API_vtkStringArray.InsertValue_0(this, id, f);
}


// void InsertValue(vtkIdType id, const char * val)
// "void InsertValue(vtkIdType id, const char *val)"
public new void InsertValue(long /*(vtkIdType)*/ id, char /*(char*)*/ []val) {
	API_vtkStringArray.InsertValue_1(this, id, val);
}


// vtkIdType InsertNextValue(vtkStdString f)
// "vtkIdType InsertNextValue(vtkStdString f)"
public new long InsertNextValue(string /*(vtkStdString)*/ f) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.InsertNextValue_0(this, returnPointer, f);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertNextValue(const char * f)
// "vtkIdType InsertNextValue(const char *f)"
public new long InsertNextValue(char /*(char*)*/ []f) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.InsertNextValue_1(this, returnPointer, f);
	return Ptr.deref(returnPointer);
}


// vtkStdString* WritePointer(vtkIdType id, vtkIdType number)
// "vtkStdString* WritePointer(vtkIdType id, vtkIdType number)"
public new string WritePointer(long /*(vtkIdType)*/ id, long /*(vtkIdType)*/ number) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new string())*return_elements);
	API_vtkStringArray.WritePointer_0(this, returnPointer, id, number);
	return Ptr.deref(returnPointer);
}


// vtkStdString* GetPointer(vtkIdType id)
// "vtkStdString* GetPointer(vtkIdType id)"
public new string GetPointer(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new string())*return_elements);
	API_vtkStringArray.GetPointer_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// void* GetVoidPointer(vtkIdType id)
// "void* GetVoidPointer(vtkIdType id)"
public new IntPtr GetVoidPointer(long /*(vtkIdType)*/ id) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkStringArray.GetVoidPointer_0(this, returnPointer, id);
	return Ptr.deref(returnPointer);
}


// void DeepCopy(vtkAbstractArray * aa)
// "void DeepCopy( vtkAbstractArray* aa )"
public new void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ aa) {
	API_vtkStringArray.DeepCopy_0(this, aa);
}


// void SetArray(vtkStdString * array, vtkIdType size, int save)
// "void SetArray(vtkStdString* array, vtkIdType size, int save)"
public new void SetArray(string /*(vtkStdString*)*/ []array, long /*(vtkIdType)*/ size, int /*(int)*/ save) {
	API_vtkStringArray.SetArray_0(this, array, size, save);
}


// void SetVoidArray(void * array, vtkIdType size, int save)
// "void SetVoidArray(void* array, vtkIdType size, int save)"
public new void SetVoidArray(IntPtr /*(void*)*/ []array, long /*(vtkIdType)*/ size, int /*(int)*/ save) {
	API_vtkStringArray.SetVoidArray_0(this, array, size, save);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkStringArray.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetDataSize()
// "vtkIdType GetDataSize()"
public new long GetDataSize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.GetDataSize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType LookupValue(const vtkStdString & value)
// "vtkIdType LookupValue(const vtkStdString& value)"
public new long LookupValue(string /*(vtkStdString&)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.LookupValue_0(this, returnPointer, *value);
	return Ptr.deref(returnPointer);
}


// void LookupValue(const vtkStdString & value, vtkIdList * ids)
// "void LookupValue(const vtkStdString& value, vtkIdList* ids)"
public new void LookupValue(string /*(vtkStdString&)*/ []value, vtkIdList /*(vtkIdList*)*/ ids) {
	API_vtkStringArray.LookupValue_1(this, *value, ids);
}


// vtkIdType LookupValue(const char * value)
// "vtkIdType LookupValue(const char* value)"
public new long LookupValue(char /*(char*)*/ []value) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkStringArray.LookupValue_2(this, returnPointer, value);
	return Ptr.deref(returnPointer);
}


// void LookupValue(const char * value, vtkIdList * ids)
// "void LookupValue(const char* value, vtkIdList* ids)"
public new void LookupValue(char /*(char*)*/ []value, vtkIdList /*(vtkIdList*)*/ ids) {
	API_vtkStringArray.LookupValue_3(this, value, ids);
}


// void DataChanged()
// "void DataChanged()"
public new void DataChanged() {
	API_vtkStringArray.DataChanged_0(this);
}


// virtual void DataElementChanged(vtkIdType id)
// "virtual void DataElementChanged(vtkIdType id)"
public new void DataElementChanged(long /*(vtkIdType)*/ id) {
	API_vtkStringArray.DataElementChanged_0(this, id);
}


// void ClearLookup()
// "void ClearLookup()"
public new void ClearLookup() {
	API_vtkStringArray.ClearLookup_0(this);
}


}
};
