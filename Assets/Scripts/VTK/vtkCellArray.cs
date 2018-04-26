
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkCellArray : vtkObject {

//       Method: virtual const char * vtkCellArray::GetClassName()
// 
public string GetClassName() {
	IntPtr p =  Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr()));
	VTK.API_vtkCellArray.GetClassName(p,obj);
	string result = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkCellArray * vtkCellArray::New()
// 
public static vtkCellArray New() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.New(p);
	vtkCellArray result = new vtkCellArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkCellArray::Allocate(vtkIdType sz, vtkIdType ext)
// 
public int Allocate(long sz, long ext) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.Allocate(p,obj, sz, ext);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::Initialize()
// 
public void Initialize() {
	VTK.API_vtkCellArray.Initialize(obj);
}


//       Method: vtkIdType vtkCellArray::EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// 
public long EstimateSize(long numCells, int maxPtsPerCell) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.EstimateSize(p,obj, numCells, maxPtsPerCell);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::InitTraversal()
// 
public void InitTraversal() {
	VTK.API_vtkCellArray.InitTraversal(obj);
}


//       Method: int vtkCellArray::GetNextCell(vtkIdList* pts)
// 
public int GetNextCell(vtkIdList/*vtkIdList* */ pts) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetNextCell(p,obj, pts);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::GetSize()
// 
public long GetSize() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetSize(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::GetNumberOfConnectivityEntries()
// 
public long GetNumberOfConnectivityEntries() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetNumberOfConnectivityEntries(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::GetCell(vtkIdType loc, vtkIdList* pts)
// 
public void GetCell(long loc, vtkIdList/*vtkIdList* */ pts) {
	VTK.API_vtkCellArray.GetCell(obj, loc, pts);
}


//       Method: vtkIdType vtkCellArray::InsertNextCell(vtkCell* cell)
// 
public long InsertNextCell(vtkCell/*vtkCell* */ cell) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.InsertNextCell(p,obj, cell);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::InsertNextCell(vtkIdType npts, const vtkIdType* pts)
// 
public long InsertNextCell(long npts, long/*const vtkIdType* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.InsertNextCell(p,obj, npts, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::InsertNextCell(vtkIdList* pts)
// 
public long InsertNextCell(vtkIdList/*vtkIdList* */ pts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.InsertNextCell(p,obj, pts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::InsertNextCell(int npts)
// 
public long InsertNextCell(int npts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.InsertNextCell(p,obj, npts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::InsertCellPoint(vtkIdType id)
// 
public void InsertCellPoint(long id) {
	VTK.API_vtkCellArray.InsertCellPoint(obj, id);
}


//       Method: void vtkCellArray::UpdateCellCount(int npts)
// 
public void UpdateCellCount(int npts) {
	VTK.API_vtkCellArray.UpdateCellCount(obj, npts);
}


//       Method: vtkIdType vtkCellArray::GetInsertLocation(int npts)
// 
public long GetInsertLocation(int npts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetInsertLocation(p,obj, npts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellArray::GetTraversalLocation()
// 
public long GetTraversalLocation() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetTraversalLocation(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::SetTraversalLocation(vtkIdType loc)
// 
public void SetTraversalLocation(long loc) {
	VTK.API_vtkCellArray.SetTraversalLocation(obj, loc);
}


//       Method: vtkIdType vtkCellArray::GetTraversalLocation(vtkIdType npts)
// 
public long GetTraversalLocation(long npts) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetTraversalLocation(p,obj, npts);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::ReverseCell(vtkIdType loc)
// 
public void ReverseCell(long loc) {
	VTK.API_vtkCellArray.ReverseCell(obj, loc);
}


//       Method: void vtkCellArray::ReplaceCell(vtkIdType loc, int npts, const vtkIdType* pts)
// 
public void ReplaceCell(long loc, int npts, long/*const vtkIdType* */ pts) {
	VTK.API_vtkCellArray.ReplaceCell(obj, loc, npts, pts);
}


//       Method: int vtkCellArray::GetMaxCellSize()
// 
public int GetMaxCellSize() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetMaxCellSize(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType * vtkCellArray::GetPointer()
// 
public long GetPointer() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetPointer(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType * vtkCellArray::WritePointer(const vtkIdType ncells, const vtkIdType size)
// 
public long WritePointer(long ncells, long size) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.WritePointer(p,obj, ncells, size);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::SetCells(vtkIdType ncells, vtkIdTypeArray* cells)
// 
public void SetCells(long ncells, vtkIdTypeArray/*vtkIdTypeArray* */ cells) {
	VTK.API_vtkCellArray.SetCells(obj, ncells, cells);
}


//       Method: void vtkCellArray::DeepCopy(vtkCellArray* ca)
// 
public void DeepCopy(vtkCellArray/*vtkCellArray* */ ca) {
	VTK.API_vtkCellArray.DeepCopy(obj, ca);
}


//       Method: vtkIdTypeArray * vtkCellArray::GetData()
// 
public vtkIdTypeArray GetData() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellArray.GetData(p,obj);
	vtkIdTypeArray result = new vtkIdTypeArray();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellArray::Reset()
// 
public void Reset() {
	VTK.API_vtkCellArray.Reset(obj);
}


//       Method: void vtkCellArray::Squeeze()
// 
public void Squeeze() {
	VTK.API_vtkCellArray.Squeeze(obj);
}


}
};
