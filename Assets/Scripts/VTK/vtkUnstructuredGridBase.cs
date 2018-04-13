
using System;
using UnityEngine;
using System.Runtime.InteropServices;


namespace VTK
{
public class vtkUnstructuredGridBase : vtkPointSet {

//       Method: int vtkUnstructuredGridBase::GetDataObjectType()
// 
public static int GetDataObjectType(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.GetDataObjectType(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkUnstructuredGridBase::Allocate(vtkIdType numCells, int extSize)
// 
public static void Allocate(IntPtr obj, long numCells, int extSize) {
	VTK.API_vtkUnstructuredGridBase.Allocate(obj, numCells, extSize);
}


//       Method: void vtkUnstructuredGridBase::DeepCopy(vtkDataObject* src)
// 
public static void DeepCopy(IntPtr obj, IntPtr/*vtkDataObject* */ src) {
	VTK.API_vtkUnstructuredGridBase.DeepCopy(obj, src);
}


//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds)
// 
public static long InsertNextCell(IntPtr obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.InsertNextCell(p,obj, type, npts, ptIds);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdList* ptIds)
// 
public static long InsertNextCell(IntPtr obj, int type, IntPtr/*vtkIdList* */ ptIds) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.InsertNextCell(p,obj, type, ptIds);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual vtkIdType vtkUnstructuredGridBase::InsertNextCell(int type, vtkIdType npts, vtkIdType* ptIds, vtkIdType nfaces, vtkIdType* faces)
// 
public static long InsertNextCell(IntPtr obj, int type, long npts, IntPtr/*vtkIdType* */ ptIds, long nfaces, IntPtr/*vtkIdType* */ faces) {
	int numElements = 1;
	long example = new long();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.InsertNextCell(p,obj, type, npts, ptIds, nfaces, faces);
	long result = Convert.ToInt64(Marshal.ReadInt64(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: virtual void vtkUnstructuredGridBase::ReplaceCell(vtkIdType cellId, int npts, vtkIdType* pts)
// 
public static void ReplaceCell(IntPtr obj, long cellId, int npts, IntPtr/*vtkIdType* */ pts) {
	VTK.API_vtkUnstructuredGridBase.ReplaceCell(obj, cellId, npts, pts);
}


//       Method: virtual void vtkUnstructuredGridBase::GetIdsOfCellsOfType(int type, vtkIdTypeArray* array)
// 
public static void GetIdsOfCellsOfType(IntPtr obj, int type, IntPtr/*vtkIdTypeArray* */ array) {
	VTK.API_vtkUnstructuredGridBase.GetIdsOfCellsOfType(obj, type, array);
}


//       Method: virtual int vtkUnstructuredGridBase::IsHomogeneous()
// 
public static int IsHomogeneous(IntPtr obj) {
	int numElements = 1;
	int example = new int();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.IsHomogeneous(p,obj);
	int result = Convert.ToInt32(Marshal.ReadInt32(p));
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkUnstructuredGridBase * vtkUnstructuredGridBase::GetData(vtkInformation* info)
// 
public static IntPtr GetData(IntPtr/*vtkInformation* */ info) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.GetData(p, info);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


//       Method: static vtkUnstructuredGridBase * vtkUnstructuredGridBase::GetData(vtkInformationVector* v, int i)
// 
public static IntPtr GetData(IntPtr/*vtkInformationVector* */ v, int i) {
	int numElements = 1;
	IntPtr example = new IntPtr();
	IntPtr p = Marshal.AllocHGlobal(Marshal.SizeOf(example)*numElements);
	VTK.API_vtkUnstructuredGridBase.GetData(p, v, i);
	IntPtr result = p;
	Marshal.FreeHGlobal (p);
	return result;
}


}
};
