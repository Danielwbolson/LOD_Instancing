

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractArray : vtkObject {
		public vtkAbstractArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractArray(IntPtr p) {return new vtkAbstractArray(p);}
		public static implicit operator  IntPtr(vtkAbstractArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAbstractArray* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractArray* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* NewInstance()
// "vtkAbstractArray *NewInstance()"
public vtkAbstractArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual int Allocate(vtkIdType numValues, vtkIdType ext = 1000)
// "virtual int Allocate(vtkIdType numValues, vtkIdType ext=1000)"
public int Allocate(long /*(vtkIdType)*/ numValues, long /*(vtkIdType)*/ ext) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.Allocate_0(returnPointer.GetPtr(), this, numValues, ext);
	return (int)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkAbstractArray.Initialize_0(this);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public int GetDataType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetDataType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetDataTypeSize()
// "virtual int GetDataTypeSize()"
public int GetDataTypeSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetDataTypeSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// static int GetDataTypeSize(int type)
// "static int GetDataTypeSize(int type)"
public static int GetDataTypeSize(int /*(int)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetDataTypeSize_1(returnPointer.GetPtr(), type);
	return (int)returnPointer;
}


// virtual int GetElementComponentSize()
// "virtual int GetElementComponentSize()"
public int GetElementComponentSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetElementComponentSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetNumberOfComponents(int _arg)
// "virtual void SetNumberOfComponents (int _arg)"
public void SetNumberOfComponents(int /*(int)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetNumberOfComponents_0(this, _arg);
}


// virtual int GetNumberOfComponentsMinValue()
// "virtual int GetNumberOfComponentsMinValue ()"
public int GetNumberOfComponentsMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetNumberOfComponentsMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetNumberOfComponentsMaxValue()
// "virtual int GetNumberOfComponentsMaxValue ()"
public int GetNumberOfComponentsMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetNumberOfComponentsMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public int GetNumberOfComponents() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetNumberOfComponents_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetComponentName(vtkIdType component, const char * name)
// "void SetComponentName( vtkIdType component, const char *name )"
public void SetComponentName(long /*(vtkIdType)*/ component, string /*(char*)*/ name) {
	VTK_API.API_vtkAbstractArray.SetComponentName_0(this, component, name);
}


// char* GetComponentName(vtkIdType component)
// "const char* GetComponentName( vtkIdType component )"
public string GetComponentName(long /*(vtkIdType)*/ component) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.GetComponentName_0(returnPointer.GetPtr(), this, component);
	return (string)returnPointer;
}


// bool HasAComponentName()
// "bool HasAComponentName()"
public bool HasAComponentName() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractArray.HasAComponentName_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// int CopyComponentNames(vtkAbstractArray * da)
// "int CopyComponentNames( vtkAbstractArray *da )"
public int CopyComponentNames(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.CopyComponentNames_0(returnPointer.GetPtr(), this, da);
	return (int)returnPointer;
}


// virtual void SetNumberOfTuples(vtkIdType numTuples)
// "virtual void SetNumberOfTuples(vtkIdType numTuples)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ numTuples) {
	VTK_API.API_vtkAbstractArray.SetNumberOfTuples_0(this, numTuples);
}


// virtual void SetNumberOfValues(vtkIdType numValues)
// "virtual void SetNumberOfValues(vtkIdType numValues)"
public void SetNumberOfValues(long /*(vtkIdType)*/ numValues) {
	VTK_API.API_vtkAbstractArray.SetNumberOfValues_0(this, numValues);
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public long GetNumberOfTuples() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkAbstractArray.GetNumberOfTuples_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray *source)"
public void SetTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.SetTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public void InsertTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray* source)"
public void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkAbstractArray.InsertNextTuple_0(returnPointer.GetPtr(), this, srcTupleIdx, source);
	return (long)returnPointer;
}


// virtual void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdList *tupleIds, vtkAbstractArray* output)"
public void GetTuples(vtkIdList /*(vtkIdList*)*/ tupleIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkAbstractArray.GetTuples_0(this, tupleIds, output);
}


// virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkAbstractArray.GetTuples_1(this, p1, p2, output);
}


// virtual bool HasStandardMemoryLayout()
// "virtual bool HasStandardMemoryLayout()"
public bool HasStandardMemoryLayout() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractArray.HasStandardMemoryLayout_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void* GetVoidPointer(vtkIdType valueIdx)
// "virtual void *GetVoidPointer(vtkIdType valueIdx)"
public IntPtr GetVoidPointer(long /*(vtkIdType)*/ valueIdx) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.GetVoidPointer_0(returnPointer.GetPtr(), this, valueIdx);
	return (IntPtr)returnPointer;
}


// virtual void DeepCopy(vtkAbstractArray * da)
// "virtual void DeepCopy(vtkAbstractArray* da)"
public void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	VTK_API.API_vtkAbstractArray.DeepCopy_0(this, da);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, IntPtr /*(double*)*/ weights) {
	VTK_API.API_vtkAbstractArray.InterpolateTuple_0(this, dstTupleIdx, ptIndices, source, weights);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	VTK_API.API_vtkAbstractArray.InterpolateTuple_1(this, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkAbstractArray.Squeeze_0(this);
}


// virtual int Resize(vtkIdType numTuples)
// "virtual int Resize(vtkIdType numTuples)"
public int Resize(long /*(vtkIdType)*/ numTuples) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.Resize_0(returnPointer.GetPtr(), this, numTuples);
	return (int)returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkAbstractArray.Reset_0(this);
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public long GetSize() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkAbstractArray.GetSize_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetMaxId()
// "vtkIdType GetMaxId()"
public long GetMaxId() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkAbstractArray.GetMaxId_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetVoidArray(void * ARG_0, vtkIdType ARG_1, int ARG_2)
// "virtual void SetVoidArray(void *, vtkIdType , int )"
public void SetVoidArray(IntPtr /*(void*)*/ ARG_0, long /*(vtkIdType)*/ ARG_1, int /*(int)*/ ARG_2) {
	VTK_API.API_vtkAbstractArray.SetVoidArray_0(this, ARG_0, ARG_1, ARG_2);
}


// virtual void SetVoidArray(void * array, vtkIdType size, int save, int ARG_0)
// "virtual void SetVoidArray(void *array, vtkIdType size, int save, int )"
public void SetVoidArray(IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save, int /*(int)*/ ARG_0) {
	VTK_API.API_vtkAbstractArray.SetVoidArray_1(this, array, size, save, ARG_0);
}


// virtual void ExportToVoidPointer(void * out_ptr)
// "virtual void ExportToVoidPointer(void *out_ptr)"
public void ExportToVoidPointer(IntPtr /*(void*)*/ out_ptr) {
	VTK_API.API_vtkAbstractArray.ExportToVoidPointer_0(this, out_ptr);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkAbstractArray.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void SetName(const char * _arg)
// "virtual void SetName (const char* _arg)"
public void SetName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetName_0(this, _arg);
}


// virtual char* GetName()
// "virtual char* GetName ()"
public string GetName() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.GetName_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual char* GetDataTypeAsString()
// "virtual const char *GetDataTypeAsString( void )"
public string GetDataTypeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.GetDataTypeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// static vtkAbstractArray* CreateArray(int dataType)
// "static vtkAbstractArray* CreateArray(int dataType)"
public static vtkAbstractArray CreateArray(int /*(int)*/ dataType) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.CreateArray_0(returnPointer.GetPtr(), dataType);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual int IsNumeric()
// "virtual int IsNumeric()"
public int IsNumeric() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.IsNumeric_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkArrayIterator* NewIterator()
// "virtual vtkArrayIterator* NewIterator()"
public vtkArrayIterator NewIterator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkAbstractArray.NewIterator_0(returnPointer.GetPtr(), this);
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// virtual vtkIdType GetDataSize()
// "virtual vtkIdType GetDataSize()"
public long GetDataSize() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkAbstractArray.GetDataSize_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void DataChanged()
// "virtual void DataChanged()"
public void DataChanged() {
	VTK_API.API_vtkAbstractArray.DataChanged_0(this);
}


// virtual void ClearLookup()
// "virtual void ClearLookup()"
public void ClearLookup() {
	VTK_API.API_vtkAbstractArray.ClearLookup_0(this);
}


// bool HasInformation()
// "bool HasInformation()"
public bool HasInformation() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkAbstractArray.HasInformation_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void Modified()
// "void Modified()"
public void Modified() {
	VTK_API.API_vtkAbstractArray.Modified_0(this);
}


// virtual int GetMaxDiscreteValues()
// "virtual unsigned int GetMaxDiscreteValues ()"
public uint GetMaxDiscreteValues() {
	ReturnPointer returnPointer = new ReturnPointer(new uint());
	VTK_API.API_vtkAbstractArray.GetMaxDiscreteValues_0(returnPointer.GetPtr(), this);
	return (uint)returnPointer;
}


// virtual void SetMaxDiscreteValues(unsigned int _arg)
// "virtual void SetMaxDiscreteValues (unsigned int _arg)"
public void SetMaxDiscreteValues(uint /*(unsigned int)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetMaxDiscreteValues_0(this, _arg);
}


// virtual int GetArrayType()
// "virtual int GetArrayType()"
public int GetArrayType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkAbstractArray.GetArrayType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
