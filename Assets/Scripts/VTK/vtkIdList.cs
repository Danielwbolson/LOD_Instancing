

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdList : vtkObject {

// static vtkIdList* New()
// "static vtkIdList *New()"
public new static vtkIdList New() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkIdList.New_0(returnPointer);
	return Ptr.deref(returnPointer);
}


// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkIdList.Initialize_0(this);
}


// int Allocate(const vtkIdType sz, const int strategy = 0)
// "int Allocate(const vtkIdType sz, const int strategy=0)"
public new int Allocate(long /*(vtkIdType)*/ sz, int /*(int)*/ strategy) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkIdList.Allocate_0(this, returnPointer, sz, strategy);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetNumberOfIds()
// "vtkIdType GetNumberOfIds()"
public new long GetNumberOfIds() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.GetNumberOfIds_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkIdType GetId(const vtkIdType i)
// "vtkIdType GetId(const vtkIdType i)"
public new long GetId(long /*(vtkIdType)*/ i) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.GetId_0(this, returnPointer, i);
	return Ptr.deref(returnPointer);
}


// void SetNumberOfIds(const vtkIdType number)
// "void SetNumberOfIds(const vtkIdType number)"
public new void SetNumberOfIds(long /*(vtkIdType)*/ number) {
	API_vtkIdList.SetNumberOfIds_0(this, number);
}


// void SetId(const vtkIdType i, const vtkIdType vtkid)
// "void SetId(const vtkIdType i, const vtkIdType vtkid)"
public new void SetId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	API_vtkIdList.SetId_0(this, i, vtkid);
}


// void InsertId(const vtkIdType i, const vtkIdType vtkid)
// "void InsertId(const vtkIdType i, const vtkIdType vtkid)"
public new void InsertId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	API_vtkIdList.InsertId_0(this, i, vtkid);
}


// vtkIdType InsertNextId(const vtkIdType vtkid)
// "vtkIdType InsertNextId(const vtkIdType vtkid)"
public new long InsertNextId(long /*(vtkIdType)*/ vtkid) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.InsertNextId_0(this, returnPointer, vtkid);
	return Ptr.deref(returnPointer);
}


// vtkIdType InsertUniqueId(const vtkIdType vtkid)
// "vtkIdType InsertUniqueId(const vtkIdType vtkid)"
public new long InsertUniqueId(long /*(vtkIdType)*/ vtkid) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.InsertUniqueId_0(this, returnPointer, vtkid);
	return Ptr.deref(returnPointer);
}


// vtkIdType* GetPointer(const vtkIdType i)
// "vtkIdType *GetPointer(const vtkIdType i)"
public new long GetPointer(long /*(vtkIdType)*/ i) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.GetPointer_0(this, returnPointer, i);
	return Ptr.deref(returnPointer);
}


// vtkIdType* WritePointer(const vtkIdType i, const vtkIdType number)
// "vtkIdType *WritePointer(const vtkIdType i, const vtkIdType number)"
public new long WritePointer(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ number) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.WritePointer_0(this, returnPointer, i, number);
	return Ptr.deref(returnPointer);
}


// void SetArray(vtkIdType * array, vtkIdType size)
// "void SetArray(vtkIdType *array, vtkIdType size)"
public new void SetArray(long /*(vtkIdType*)*/ []array, long /*(vtkIdType)*/ size) {
	API_vtkIdList.SetArray_0(this, array, size);
}


// void Reset()
// "void Reset()"
public new void Reset() {
	API_vtkIdList.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkIdList.Squeeze_0(this);
}


// void DeepCopy(vtkIdList * ids)
// "void DeepCopy(vtkIdList *ids)"
public new void DeepCopy(vtkIdList /*(vtkIdList*)*/ ids) {
	API_vtkIdList.DeepCopy_0(this, ids);
}


// void DeleteId(vtkIdType vtkid)
// "void DeleteId(vtkIdType vtkid)"
public new void DeleteId(long /*(vtkIdType)*/ vtkid) {
	API_vtkIdList.DeleteId_0(this, vtkid);
}


// vtkIdType IsId(vtkIdType vtkid)
// "vtkIdType IsId(vtkIdType vtkid)"
public new long IsId(long /*(vtkIdType)*/ vtkid) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.IsId_0(this, returnPointer, vtkid);
	return Ptr.deref(returnPointer);
}


// void IntersectWith(vtkIdList * otherIds)
// "void IntersectWith(vtkIdList* otherIds)"
public new void IntersectWith(vtkIdList /*(vtkIdList*)*/ otherIds) {
	API_vtkIdList.IntersectWith_0(this, otherIds);
}


// vtkIdType* Resize(const vtkIdType sz)
// "vtkIdType *Resize(const vtkIdType sz)"
public new long Resize(long /*(vtkIdType)*/ sz) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkIdList.Resize_0(this, returnPointer, sz);
	return Ptr.deref(returnPointer);
}


}
};
