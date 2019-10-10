

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStringArray : vtkAbstractArray {
		public vtkStringArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkStringArray(IntPtr p) {return new vtkStringArray(p);}
		public static implicit operator  IntPtr(vtkStringArray o) {return o.GetPtr();}

// static vtkStringArray* New()
// "static vtkStringArray* New()"
public static vtkStringArray New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.New_0(returnPointer.GetPtr());
	return (vtkStringArray)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkStringArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkStringArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkStringArray* SafeDownCast(vtkObjectBase * o)
// "static vtkStringArray* SafeDownCast(vtkObjectBase *o)"
public static vtkStringArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkStringArray)(IntPtr)returnPointer;
}


// vtkStringArray* NewInstance()
// "vtkStringArray *NewInstance()"
public vtkStringArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkStringArray)(IntPtr)returnPointer;
}


// int GetDataType()
// "int GetDataType()"
public int GetDataType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.GetDataType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int IsNumeric()
// "int IsNumeric()"
public int IsNumeric() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.IsNumeric_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkStringArray.Initialize_0(this);
}


// int GetDataTypeSize()
// "int GetDataTypeSize()"
public int GetDataTypeSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.GetDataTypeSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkStringArray.Squeeze_0(this);
}


// int Resize(vtkIdType numTuples)
// "int Resize(vtkIdType numTuples)"
public int Resize(long /*(vtkIdType)*/ numTuples) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.Resize_0(returnPointer.GetPtr(), this, numTuples);
	return (int)returnPointer;
}


// void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.SetTuple_0(this, i, j, source);
}


// void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuple_0(this, i, j, source);
}


// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)"
public void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray * source)
// "vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.InsertNextTuple_0(returnPointer.GetPtr(), this, j, source);
	return (long)returnPointer;
}


// void InterpolateTuple(vtkIdType i, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "void InterpolateTuple(vtkIdType i, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public void InterpolateTuple(long /*(vtkIdType)*/ i, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights) {
	VTK_API.API_vtkStringArray.InterpolateTuple_0(this, i, ptIndices, source, weights);
}


// void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray * source1, vtkIdType id2, vtkAbstractArray * source2, double t)
// "void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)"
public void InterpolateTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ id1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ id2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	VTK_API.API_vtkStringArray.InterpolateTuple_1(this, i, id1, source1, id2, source2, t);
}


// void GetTuples(vtkIdList * ptIds, vtkAbstractArray * output)
// "void GetTuples(vtkIdList *ptIds, vtkAbstractArray *output)"
public void GetTuples(vtkIdList /*(vtkIdList*)*/ ptIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkStringArray.GetTuples_0(this, ptIds, output);
}


// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkStringArray.GetTuples_1(this, p1, p2, output);
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate( vtkIdType sz, vtkIdType ext=1000 )"
public int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// vtkStdString& GetValue(vtkIdType id)
// "vtkStdString &GetValue(vtkIdType id)"
public IntPtr GetValue(long /*(vtkIdType)*/ id) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.GetValue_0(returnPointer.GetPtr(), this, id);
	return (IntPtr)returnPointer;
}


// void SetValue(vtkIdType id, vtkStdString value)
// "void SetValue(vtkIdType id, vtkStdString value)"
public void SetValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ value) {
	VTK_API.API_vtkStringArray.SetValue_0(this, id, value);
}


// void SetNumberOfTuples(vtkIdType number)
// "void SetNumberOfTuples(vtkIdType number)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkStringArray.SetNumberOfTuples_0(this, number);
}


// void SetNumberOfValues(vtkIdType number)
// "void SetNumberOfValues(vtkIdType number)"
public void SetNumberOfValues(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkStringArray.SetNumberOfValues_0(this, number);
}


// vtkIdType GetNumberOfValues()
// "vtkIdType GetNumberOfValues()"
public long GetNumberOfValues() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.GetNumberOfValues_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// int GetNumberOfElementComponents()
// "int GetNumberOfElementComponents()"
public int GetNumberOfElementComponents() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.GetNumberOfElementComponents_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetElementComponentSize()
// "int GetElementComponentSize()"
public int GetElementComponentSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkStringArray.GetElementComponentSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void InsertValue(vtkIdType id, vtkStdString f)
// "void InsertValue(vtkIdType id, vtkStdString f)"
public void InsertValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ f) {
	VTK_API.API_vtkStringArray.InsertValue_0(this, id, f);
}


// vtkIdType InsertNextValue(vtkStdString f)
// "vtkIdType InsertNextValue(vtkStdString f)"
public long InsertNextValue(string /*(vtkStdString)*/ f) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.InsertNextValue_0(returnPointer.GetPtr(), this, f);
	return (long)returnPointer;
}


// vtkStdString* WritePointer(vtkIdType id, vtkIdType number)
// "vtkStdString* WritePointer(vtkIdType id, vtkIdType number)"
public IntPtr WritePointer(long /*(vtkIdType)*/ id, long /*(vtkIdType)*/ number) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.WritePointer_0(returnPointer.GetPtr(), this, id, number);
	return (IntPtr)returnPointer;
}


// vtkStdString* GetPointer(vtkIdType id)
// "vtkStdString* GetPointer(vtkIdType id)"
public IntPtr GetPointer(long /*(vtkIdType)*/ id) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.GetPointer_0(returnPointer.GetPtr(), this, id);
	return (IntPtr)returnPointer;
}


// void* GetVoidPointer(vtkIdType id)
// "void* GetVoidPointer(vtkIdType id)"
public IntPtr GetVoidPointer(long /*(vtkIdType)*/ id) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.GetVoidPointer_0(returnPointer.GetPtr(), this, id);
	return (IntPtr)returnPointer;
}


// void DeepCopy(vtkAbstractArray * aa)
// "void DeepCopy( vtkAbstractArray* aa )"
public void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ aa) {
	VTK_API.API_vtkStringArray.DeepCopy_0(this, aa);
}


// void SetArray(vtkStdString * array, vtkIdType size, int save)
// "void SetArray(vtkStdString* array, vtkIdType size, int save)"
public void SetArray(IntPtr /*(vtkStdString*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save) {
	VTK_API.API_vtkStringArray.SetArray_0(this, array, size, save);
}


// void SetVoidArray(void * array, vtkIdType size, int save)
// "void SetVoidArray(void* array, vtkIdType size, int save)"
public void SetVoidArray(IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save) {
	VTK_API.API_vtkStringArray.SetVoidArray_0(this, array, size, save);
}


// void SetVoidArray(void * array, vtkIdType size, int save, int ARG_0)
// "void SetVoidArray(void* array, vtkIdType size, int save, int )"
public void SetVoidArray(IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save, int /*(int)*/ ARG_0) {
	VTK_API.API_vtkStringArray.SetVoidArray_1(this, array, size, save, ARG_0);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkStringArray.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkArrayIterator* NewIterator()
// "vtkArrayIterator* NewIterator()"
public vtkArrayIterator NewIterator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkStringArray.NewIterator_0(returnPointer.GetPtr(), this);
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// vtkIdType GetDataSize()
// "vtkIdType GetDataSize()"
public long GetDataSize() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.GetDataSize_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType LookupValue(const vtkStdString & value)
// "vtkIdType LookupValue(const vtkStdString& value)"
public long LookupValue(IntPtr /*(vtkStdString&)*/ value) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.LookupValue_0(returnPointer.GetPtr(), this, value);
	return (long)returnPointer;
}


// void LookupValue(const vtkStdString & value, vtkIdList * ids)
// "void LookupValue(const vtkStdString& value, vtkIdList* ids)"
public void LookupValue(IntPtr /*(vtkStdString&)*/ value, vtkIdList /*(vtkIdList*)*/ ids) {
	VTK_API.API_vtkStringArray.LookupValue_1(this, value, ids);
}


// vtkIdType LookupValue(const char * value)
// "vtkIdType LookupValue(const char* value)"
public long LookupValue(string /*(char*)*/ value) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkStringArray.LookupValue_2(returnPointer.GetPtr(), this, value);
	return (long)returnPointer;
}


// void LookupValue(const char * value, vtkIdList * ids)
// "void LookupValue(const char* value, vtkIdList* ids)"
public void LookupValue(string /*(char*)*/ value, vtkIdList /*(vtkIdList*)*/ ids) {
	VTK_API.API_vtkStringArray.LookupValue_3(this, value, ids);
}


// void DataChanged()
// "void DataChanged()"
public void DataChanged() {
	VTK_API.API_vtkStringArray.DataChanged_0(this);
}


// virtual void DataElementChanged(vtkIdType id)
// "virtual void DataElementChanged(vtkIdType id)"
public void DataElementChanged(long /*(vtkIdType)*/ id) {
	VTK_API.API_vtkStringArray.DataElementChanged_0(this, id);
}


// void ClearLookup()
// "void ClearLookup()"
public void ClearLookup() {
	VTK_API.API_vtkStringArray.ClearLookup_0(this);
}


}
};
