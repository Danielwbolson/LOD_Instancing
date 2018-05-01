

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFieldData : vtkObject {

// static vtkFieldData* New()
// "static vtkFieldData *New()"
public new static vtkFieldData New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Initialize()
// "virtual void Initialize()"
public new void Initialize() {
	API_vtkFieldData.Initialize_0(this);
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate(vtkIdType sz, vtkIdType ext=1000)"
public new int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.Allocate_0(this, returnPointer, sz, ext);
	return Ptr.deref(returnPointer);
}


// void CopyStructure(vtkFieldData * ARG_0)
// "void CopyStructure(vtkFieldData*)"
public new void CopyStructure(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	API_vtkFieldData.CopyStructure_0(this, ARG_0);
}


// void AllocateArrays(int num)
// "void AllocateArrays(int num)"
public new void AllocateArrays(int /*(int)*/ num) {
	API_vtkFieldData.AllocateArrays_0(this, num);
}


// int GetNumberOfArrays()
// "int GetNumberOfArrays()"
public new int GetNumberOfArrays() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.GetNumberOfArrays_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// int AddArray(vtkAbstractArray * array)
// "int AddArray(vtkAbstractArray *array)"
public new int AddArray(vtkAbstractArray /*(vtkAbstractArray*)*/ array) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.AddArray_0(this, returnPointer, array);
	return Ptr.deref(returnPointer);
}


// virtual void RemoveArray(const char * name)
// "virtual void RemoveArray(const char *name)"
public new void RemoveArray(char /*(char*)*/ []name) {
	API_vtkFieldData.RemoveArray_0(this, name);
}


// virtual void RemoveArray(int index)
// "virtual void RemoveArray(int index)"
public new void RemoveArray(int /*(int)*/ index) {
	API_vtkFieldData.RemoveArray_1(this, index);
}


// vtkDataArray* GetArray(int i)
// "vtkDataArray *GetArray(int i)"
public new vtkDataArray GetArray(int /*(int)*/ i) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetArray_0(this, returnPointer, i);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetArray(const char * arrayName, int & index)
// "vtkDataArray *GetArray(const char *arrayName, int &index)"
public new vtkDataArray GetArray(char /*(char*)*/ []arrayName, int /*(int&)*/ []index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetArray_1(this, returnPointer, arrayName, *index);
	return Ptr.deref(returnPointer);
}


// vtkDataArray* GetArray(const char * arrayName)
// "vtkDataArray *GetArray(const char *arrayName)"
public new vtkDataArray GetArray(char /*(char*)*/ []arrayName) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetArray_2(this, returnPointer, arrayName);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetAbstractArray(int i)
// "vtkAbstractArray* GetAbstractArray(int i)"
public new vtkAbstractArray GetAbstractArray(int /*(int)*/ i) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetAbstractArray_0(this, returnPointer, i);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName, int & index)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName, int &index)"
public new vtkAbstractArray GetAbstractArray(char /*(char*)*/ []arrayName, int /*(int&)*/ []index) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetAbstractArray_1(this, returnPointer, arrayName, *index);
	return Ptr.deref(returnPointer);
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName)"
public new vtkAbstractArray GetAbstractArray(char /*(char*)*/ []arrayName) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkFieldData.GetAbstractArray_2(this, returnPointer, arrayName);
	return Ptr.deref(returnPointer);
}


// int HasArray(const char * name)
// "int HasArray(const char *name)"
public new int HasArray(char /*(char*)*/ []name) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.HasArray_0(this, returnPointer, name);
	return Ptr.deref(returnPointer);
}


// char* GetArrayName(int i)
// "const char* GetArrayName(int i)"
public new char GetArrayName(int /*(int)*/ i) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new char())*return_elements);
	API_vtkFieldData.GetArrayName_0(this, returnPointer, i);
	return Ptr.deref(returnPointer);
}


// virtual void PassData(vtkFieldData * fd)
// "virtual void PassData(vtkFieldData* fd)"
public new void PassData(vtkFieldData /*(vtkFieldData*)*/ fd) {
	API_vtkFieldData.PassData_0(this, fd);
}


// void CopyFieldOn(const char * name)
// "void CopyFieldOn(const char* name)"
public new void CopyFieldOn(char /*(char*)*/ []name) {
	API_vtkFieldData.CopyFieldOn_0(this, name);
}


// void CopyFieldOff(const char * name)
// "void CopyFieldOff(const char* name)"
public new void CopyFieldOff(char /*(char*)*/ []name) {
	API_vtkFieldData.CopyFieldOff_0(this, name);
}


// virtual void CopyAllOn(int unused = 0)
// "virtual void CopyAllOn(int unused=0)"
public new void CopyAllOn(int /*(int)*/ unused) {
	API_vtkFieldData.CopyAllOn_0(this, unused);
}


// virtual void CopyAllOff(int unused = 0)
// "virtual void CopyAllOff(int unused=0)"
public new void CopyAllOff(int /*(int)*/ unused) {
	API_vtkFieldData.CopyAllOff_0(this, unused);
}


// virtual void DeepCopy(vtkFieldData * da)
// "virtual void DeepCopy(vtkFieldData *da)"
public new void DeepCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	API_vtkFieldData.DeepCopy_0(this, da);
}


// virtual void ShallowCopy(vtkFieldData * da)
// "virtual void ShallowCopy(vtkFieldData *da)"
public new void ShallowCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	API_vtkFieldData.ShallowCopy_0(this, da);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkFieldData.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkFieldData.Reset_0(this);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkFieldData.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkFieldData.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetField(vtkIdList * ptId, vtkFieldData * f)
// "void GetField(vtkIdList *ptId, vtkFieldData *f)"
public new void GetField(vtkIdList /*(vtkIdList*)*/ ptId, vtkFieldData /*(vtkFieldData*)*/ f) {
	API_vtkFieldData.GetField_0(this, ptId, f);
}


// int GetArrayContainingComponent(int i, int & arrayComp)
// "int GetArrayContainingComponent(int i, int& arrayComp)"
public new int GetArrayContainingComponent(int /*(int)*/ i, int /*(int&)*/ []arrayComp) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.GetArrayContainingComponent_0(this, returnPointer, i, *arrayComp);
	return Ptr.deref(returnPointer);
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public new int GetNumberOfComponents() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkFieldData.GetNumberOfComponents_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public new long GetNumberOfTuples() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkFieldData.GetNumberOfTuples_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void SetNumberOfTuples(const vtkIdType number)
// "void SetNumberOfTuples(const vtkIdType number)"
public new void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	API_vtkFieldData.SetNumberOfTuples_0(this, number);
}


// void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public new void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	API_vtkFieldData.SetTuple_0(this, i, j, source);
}


// void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public new void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	API_vtkFieldData.InsertTuple_0(this, i, j, source);
}


// vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData * source)
// "vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData* source)"
public new long InsertNextTuple(long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkFieldData.InsertNextTuple_0(this, returnPointer, j, source);
	return Ptr.deref(returnPointer);
}


}
};
