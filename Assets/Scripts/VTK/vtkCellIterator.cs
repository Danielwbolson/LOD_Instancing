
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public partial class vtkCellIterator : vtkObject {

//       Method: void vtkCellIterator::InitTraversal()
// 
public void InitTraversal() {
	VTK.API_vtkCellIterator.InitTraversal(obj);
}


//       Method: void vtkCellIterator::GoToNextCell()
// 
public void GoToNextCell() {
	VTK.API_vtkCellIterator.GoToNextCell(obj);
}


//       Method: virtual bool vtkCellIterator::IsDoneWithTraversal()
// 
public bool IsDoneWithTraversal() {
	int numElements = 1;
	bool example = new bool();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.IsDoneWithTraversal(p,obj);
	bool result = Convert.ToBoolean(Marshal.ReadByte(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkCellIterator::GetCellType()
// 
public int GetCellType() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetCellType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: int vtkCellIterator::GetCellDimension()
// 
public int GetCellDimension() {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetCellDimension(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkCellIterator::GetCellId()
// 
public long GetCellId() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetCellId(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdList * vtkCellIterator::GetPointIds()
// 
public vtkIdList GetPointIds() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetPointIds(p,obj);
	vtkIdList result = new vtkIdList();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkPoints * vtkCellIterator::GetPoints()
// 
public vtkPoints GetPoints() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetPoints(p,obj);
	vtkPoints result = new vtkPoints();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdList * vtkCellIterator::GetFaces()
// 
public vtkIdList GetFaces() {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetFaces(p,obj);
	vtkIdList result = new vtkIdList();
	unsafe {result.SetPtr(new IntPtr ((*(void**)p.ToPointer ())));}
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: void vtkCellIterator::GetCell(vtkGenericCell* cell)
// 
public void GetCell(vtkGenericCell/*vtkGenericCell* */ cell) {
	VTK.API_vtkCellIterator.GetCell(obj, cell);
}


//       Method: vtkIdType vtkCellIterator::GetNumberOfPoints()
// 
public long GetNumberOfPoints() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetNumberOfPoints(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: vtkIdType vtkCellIterator::GetNumberOfFaces()
// 
public long GetNumberOfFaces() {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkCellIterator.GetNumberOfFaces(p,obj);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
