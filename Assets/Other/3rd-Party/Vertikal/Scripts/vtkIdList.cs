

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdList : vtkObject {
		public vtkIdList(IntPtr p) : base(p) {}
		public static implicit operator  vtkIdList(IntPtr p) {return new vtkIdList(p);}
		public static implicit operator  IntPtr(vtkIdList o) {return o.GetPtr();}

// static vtkIdList* New()
// "static vtkIdList *New()"
public static vtkIdList New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.New_0(returnPointer.GetPtr());
	return (vtkIdList)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkIdList.Initialize_0(this);
}


// int Allocate(const vtkIdType sz, const int strategy = 0)
// "int Allocate(const vtkIdType sz, const int strategy=0)"
public int Allocate(long /*(vtkIdType)*/ sz, int /*(int)*/ strategy) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkIdList.Allocate_0(returnPointer.GetPtr(), this, sz, strategy);
	return (int)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkIdList.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkIdList.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkIdList* SafeDownCast(vtkObjectBase * o)
// "static vtkIdList* SafeDownCast(vtkObjectBase *o)"
public static vtkIdList SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkIdList* NewInstance()
// "vtkIdList *NewInstance()"
public vtkIdList NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfIds()
// "vtkIdType GetNumberOfIds()"
public long GetNumberOfIds() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIdList.GetNumberOfIds_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetId(const vtkIdType i)
// "vtkIdType GetId(const vtkIdType i)"
public long GetId(long /*(vtkIdType)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIdList.GetId_0(returnPointer.GetPtr(), this, i);
	return (long)returnPointer;
}


// void SetNumberOfIds(const vtkIdType number)
// "void SetNumberOfIds(const vtkIdType number)"
public void SetNumberOfIds(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkIdList.SetNumberOfIds_0(this, number);
}


// void SetId(const vtkIdType i, const vtkIdType vtkid)
// "void SetId(const vtkIdType i, const vtkIdType vtkid)"
public void SetId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.SetId_0(this, i, vtkid);
}


// void InsertId(const vtkIdType i, const vtkIdType vtkid)
// "void InsertId(const vtkIdType i, const vtkIdType vtkid)"
public void InsertId(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.InsertId_0(this, i, vtkid);
}


// vtkIdType InsertNextId(const vtkIdType vtkid)
// "vtkIdType InsertNextId(const vtkIdType vtkid)"
public long InsertNextId(long /*(vtkIdType)*/ vtkid) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIdList.InsertNextId_0(returnPointer.GetPtr(), this, vtkid);
	return (long)returnPointer;
}


// vtkIdType InsertUniqueId(const vtkIdType vtkid)
// "vtkIdType InsertUniqueId(const vtkIdType vtkid)"
public long InsertUniqueId(long /*(vtkIdType)*/ vtkid) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIdList.InsertUniqueId_0(returnPointer.GetPtr(), this, vtkid);
	return (long)returnPointer;
}


// vtkIdType* GetPointer(const vtkIdType i)
// "vtkIdType *GetPointer(const vtkIdType i)"
public IntPtr GetPointer(long /*(vtkIdType)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.GetPointer_0(returnPointer.GetPtr(), this, i);
	return (IntPtr)returnPointer;
}


// vtkIdType* WritePointer(const vtkIdType i, const vtkIdType number)
// "vtkIdType *WritePointer(const vtkIdType i, const vtkIdType number)"
public IntPtr WritePointer(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ number) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.WritePointer_0(returnPointer.GetPtr(), this, i, number);
	return (IntPtr)returnPointer;
}


// void SetArray(vtkIdType * array, vtkIdType size)
// "void SetArray(vtkIdType *array, vtkIdType size)"
public void SetArray(IntPtr /*(vtkIdType*)*/ array, long /*(vtkIdType)*/ size) {
	VTK_API.API_vtkIdList.SetArray_0(this, array, size);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkIdList.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkIdList.Squeeze_0(this);
}


// void DeepCopy(vtkIdList * ids)
// "void DeepCopy(vtkIdList *ids)"
public void DeepCopy(vtkIdList /*(vtkIdList*)*/ ids) {
	VTK_API.API_vtkIdList.DeepCopy_0(this, ids);
}


// void DeleteId(vtkIdType vtkid)
// "void DeleteId(vtkIdType vtkid)"
public void DeleteId(long /*(vtkIdType)*/ vtkid) {
	VTK_API.API_vtkIdList.DeleteId_0(this, vtkid);
}


// vtkIdType IsId(vtkIdType vtkid)
// "vtkIdType IsId(vtkIdType vtkid)"
public long IsId(long /*(vtkIdType)*/ vtkid) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkIdList.IsId_0(returnPointer.GetPtr(), this, vtkid);
	return (long)returnPointer;
}


// void IntersectWith(vtkIdList * otherIds)
// "void IntersectWith(vtkIdList* otherIds)"
public void IntersectWith(vtkIdList /*(vtkIdList*)*/ otherIds) {
	VTK_API.API_vtkIdList.IntersectWith_0(this, otherIds);
}


// vtkIdType* Resize(const vtkIdType sz)
// "vtkIdType *Resize(const vtkIdType sz)"
public IntPtr Resize(long /*(vtkIdType)*/ sz) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkIdList.Resize_0(returnPointer.GetPtr(), this, sz);
	return (IntPtr)returnPointer;
}


}
};
