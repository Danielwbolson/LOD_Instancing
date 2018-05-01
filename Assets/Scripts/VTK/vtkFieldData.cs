

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFieldData : vtkObject {
		public vtkFieldData(IntPtr p) : base(p) {}
		public static implicit operator  vtkFieldData(IntPtr p) {return new vtkFieldData(p);}
		public static implicit operator  IntPtr(vtkFieldData o) {return o.GetPtr();}

// static vtkFieldData* New()
// "static vtkFieldData *New()"
public static vtkFieldData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.New_0(returnPointer.GetPtr());
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	API_vtkFieldData.Initialize_0(this);
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate(vtkIdType sz, vtkIdType ext=1000)"
public int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void CopyStructure(vtkFieldData * ARG_0)
// "void CopyStructure(vtkFieldData*)"
public void CopyStructure(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	API_vtkFieldData.CopyStructure_0(this, ARG_0);
}


// void AllocateArrays(int num)
// "void AllocateArrays(int num)"
public void AllocateArrays(int /*(int)*/ num) {
	API_vtkFieldData.AllocateArrays_0(this, num);
}


// int GetNumberOfArrays()
// "int GetNumberOfArrays()"
public int GetNumberOfArrays() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.GetNumberOfArrays_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int AddArray(vtkAbstractArray * array)
// "int AddArray(vtkAbstractArray *array)"
public int AddArray(vtkAbstractArray /*(vtkAbstractArray*)*/ array) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.AddArray_0(returnPointer.GetPtr(), this, array);
	return (int)returnPointer;
}


// virtual void RemoveArray(const char * name)
// "virtual void RemoveArray(const char *name)"
public void RemoveArray(string /*(char*)*/ name) {
	API_vtkFieldData.RemoveArray_0(this, name);
}


// virtual void RemoveArray(int index)
// "virtual void RemoveArray(int index)"
public void RemoveArray(int /*(int)*/ index) {
	API_vtkFieldData.RemoveArray_1(this, index);
}


// vtkDataArray* GetArray(int i)
// "vtkDataArray *GetArray(int i)"
public vtkDataArray GetArray(int /*(int)*/ i) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetArray_0(returnPointer.GetPtr(), this, i);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetArray(const char * arrayName, int & index)
// "vtkDataArray *GetArray(const char *arrayName, int &index)"
public vtkDataArray GetArray(string /*(char*)*/ arrayName, IntPtr /*(int&)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetArray_1(returnPointer.GetPtr(), this, arrayName, index);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetArray(const char * arrayName)
// "vtkDataArray *GetArray(const char *arrayName)"
public vtkDataArray GetArray(string /*(char*)*/ arrayName) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetArray_2(returnPointer.GetPtr(), this, arrayName);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(int i)
// "vtkAbstractArray* GetAbstractArray(int i)"
public vtkAbstractArray GetAbstractArray(int /*(int)*/ i) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetAbstractArray_0(returnPointer.GetPtr(), this, i);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName, int & index)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName, int &index)"
public vtkAbstractArray GetAbstractArray(string /*(char*)*/ arrayName, IntPtr /*(int&)*/ index) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetAbstractArray_1(returnPointer.GetPtr(), this, arrayName, index);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName)"
public vtkAbstractArray GetAbstractArray(string /*(char*)*/ arrayName) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetAbstractArray_2(returnPointer.GetPtr(), this, arrayName);
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// int HasArray(const char * name)
// "int HasArray(const char *name)"
public int HasArray(string /*(char*)*/ name) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.HasArray_0(returnPointer.GetPtr(), this, name);
	return (int)returnPointer;
}


// char* GetArrayName(int i)
// "const char* GetArrayName(int i)"
public string GetArrayName(int /*(int)*/ i) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkFieldData.GetArrayName_0(returnPointer.GetPtr(), this, i);
	return (string)returnPointer;
}


// virtual void PassData(vtkFieldData * fd)
// "virtual void PassData(vtkFieldData* fd)"
public void PassData(vtkFieldData /*(vtkFieldData*)*/ fd) {
	API_vtkFieldData.PassData_0(this, fd);
}


// void CopyFieldOn(const char * name)
// "void CopyFieldOn(const char* name)"
public void CopyFieldOn(string /*(char*)*/ name) {
	API_vtkFieldData.CopyFieldOn_0(this, name);
}


// void CopyFieldOff(const char * name)
// "void CopyFieldOff(const char* name)"
public void CopyFieldOff(string /*(char*)*/ name) {
	API_vtkFieldData.CopyFieldOff_0(this, name);
}


// virtual void CopyAllOn(int unused = 0)
// "virtual void CopyAllOn(int unused=0)"
public void CopyAllOn(int /*(int)*/ unused) {
	API_vtkFieldData.CopyAllOn_0(this, unused);
}


// virtual void CopyAllOff(int unused = 0)
// "virtual void CopyAllOff(int unused=0)"
public void CopyAllOff(int /*(int)*/ unused) {
	API_vtkFieldData.CopyAllOff_0(this, unused);
}


// virtual void DeepCopy(vtkFieldData * da)
// "virtual void DeepCopy(vtkFieldData *da)"
public void DeepCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	API_vtkFieldData.DeepCopy_0(this, da);
}


// virtual void ShallowCopy(vtkFieldData * da)
// "virtual void ShallowCopy(vtkFieldData *da)"
public void ShallowCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	API_vtkFieldData.ShallowCopy_0(this, da);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	API_vtkFieldData.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public void Reset() {
	API_vtkFieldData.Reset_0(this);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkFieldData.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkFieldData.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void GetField(vtkIdList * ptId, vtkFieldData * f)
// "void GetField(vtkIdList *ptId, vtkFieldData *f)"
public void GetField(vtkIdList /*(vtkIdList*)*/ ptId, vtkFieldData /*(vtkFieldData*)*/ f) {
	API_vtkFieldData.GetField_0(this, ptId, f);
}


// int GetArrayContainingComponent(int i, int & arrayComp)
// "int GetArrayContainingComponent(int i, int& arrayComp)"
public int GetArrayContainingComponent(int /*(int)*/ i, IntPtr /*(int&)*/ arrayComp) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.GetArrayContainingComponent_0(returnPointer.GetPtr(), this, i, arrayComp);
	return (int)returnPointer;
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public int GetNumberOfComponents() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	API_vtkFieldData.GetNumberOfComponents_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public long GetNumberOfTuples() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkFieldData.GetNumberOfTuples_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SetNumberOfTuples(const vtkIdType number)
// "void SetNumberOfTuples(const vtkIdType number)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	API_vtkFieldData.SetNumberOfTuples_0(this, number);
}


// void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	API_vtkFieldData.SetTuple_0(this, i, j, source);
}


// void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	API_vtkFieldData.InsertTuple_0(this, i, j, source);
}


// vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData * source)
// "vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkFieldData.InsertNextTuple_0(returnPointer.GetPtr(), this, j, source);
	return (long)returnPointer;
}


}
};
