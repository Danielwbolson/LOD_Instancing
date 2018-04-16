
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkIdList : vtkObject {

//       Method: static vtkIdList * vtkIdList::New()
// 
public static vtkIdList New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.New(p);
	vtkIdList result = new vtkIdList();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkIdList::Initialize()
// 
public void Initialize() {
	VTK.API_vtkIdList.Initialize(obj);
}


//       Method: int vtkIdList::Allocate(const vtkIdType sz, const int strategy)
// 
public int Allocate(long sz, int strategy) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.Allocate(p,obj, sz, strategy);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual const char * vtkIdList::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkIdList.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkIdList::GetNumberOfIds()
// 
public long GetNumberOfIds() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.GetNumberOfIds(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkIdList::GetId(const vtkIdType i)
// 
public long GetId(long i) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.GetId(p,obj, i);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkIdList::SetNumberOfIds(const vtkIdType number)
// 
public void SetNumberOfIds(long number) {
	VTK.API_vtkIdList.SetNumberOfIds(obj, number);
}


//       Method: void vtkIdList::SetId(const vtkIdType i, const vtkIdType vtkid)
// 
public void SetId(long i, long vtkid) {
	VTK.API_vtkIdList.SetId(obj, i, vtkid);
}


//       Method: void vtkIdList::InsertId(const vtkIdType i, const vtkIdType vtkid)
// 
public void InsertId(long i, long vtkid) {
	VTK.API_vtkIdList.InsertId(obj, i, vtkid);
}


////  Constructor: vtkIdList::VTK_EXPECTS()
//// 
//public  VTK_EXPECTS() {
//	int numElements = 1;
//	IntPtr example = new IntPtr();
//	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
//	VTK.API_vtkIdList.VTK_EXPECTS(p,obj);
//	 result = new ();
//	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
//	Marshal.FreeHGlobal (p);
//	return result;
//}


//       Method: vtkIdType vtkIdList::InsertNextId(const vtkIdType vtkid)
// 
public long InsertNextId(long vtkid) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.InsertNextId(p,obj, vtkid);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkIdList::InsertUniqueId(const vtkIdType vtkid)
// 
public long InsertUniqueId(long vtkid) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.InsertUniqueId(p,obj, vtkid);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType * vtkIdList::GetPointer(const vtkIdType i)
// 
public long GetPointer(long i) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.GetPointer(p,obj, i);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType * vtkIdList::WritePointer(const vtkIdType i, const vtkIdType number)
// 
public long WritePointer(long i, long number) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.WritePointer(p,obj, i, number);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkIdList::SetArray(vtkIdType* array, vtkIdType size)
// 
public void SetArray(long/*vtkIdType* */ array, long size) {
	VTK.API_vtkIdList.SetArray(obj, array, size);
}


//       Method: void vtkIdList::Reset()
// 
public void Reset() {
	VTK.API_vtkIdList.Reset(obj);
}


//       Method: void vtkIdList::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkIdList.Squeeze(obj);
}


//       Method: void vtkIdList::DeepCopy(vtkIdList* ids)
// 
public void DeepCopy(vtkIdList/*vtkIdList* */ ids) {
	VTK.API_vtkIdList.DeepCopy(obj, ids);
}


//       Method: void vtkIdList::DeleteId(vtkIdType vtkid)
// 
public void DeleteId(long vtkid) {
	VTK.API_vtkIdList.DeleteId(obj, vtkid);
}


//       Method: vtkIdType vtkIdList::IsId(vtkIdType vtkid)
// 
public long IsId(long vtkid) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.IsId(p,obj, vtkid);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkIdList::IntersectWith(vtkIdList* otherIds)
// 
public void IntersectWith(vtkIdList/*vtkIdList* */ otherIds) {
	VTK.API_vtkIdList.IntersectWith(obj, otherIds);
}


//       Method: vtkIdType * vtkIdList::Resize(const vtkIdType sz)
// 
public long Resize(long sz) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkIdList.Resize(p,obj, sz);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
