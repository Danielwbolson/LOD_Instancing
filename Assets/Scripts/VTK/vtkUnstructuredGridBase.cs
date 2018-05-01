

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGridBase : vtkPointSet {

// int GetDataObjectType()
// "int GetDataObjectType()"
public new int GetDataObjectType() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGridBase.GetDataObjectType_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public new void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	API_vtkUnstructuredGridBase.Allocate_0(this, numCells, extSize);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkUnstructuredGridBase.DeepCopy_0(this, src);
}


// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// "virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)"
public new long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, long /*(vtkIdType*)*/ []ptIds) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGridBase.InsertNextCell_0(this, returnPointer, type, npts, ptIds);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// "virtual vtkIdType InsertNextCell(int type, vtkIdList *ptIds)"
public new long InsertNextCell(int /*(int)*/ type, vtkIdList /*(vtkIdList*)*/ ptIds) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGridBase.InsertNextCell_1(this, returnPointer, type, ptIds);
	return Ptr.deref(returnPointer);
}


// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// "virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)"
public new long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, long /*(vtkIdType*)*/ []ptIds, long /*(vtkIdType)*/ nfaces, long /*(vtkIdType*)*/ []faces) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkUnstructuredGridBase.InsertNextCell_2(this, returnPointer, type, npts, ptIds, nfaces, faces);
	return Ptr.deref(returnPointer);
}


// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public new void ReplaceCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts) {
	API_vtkUnstructuredGridBase.ReplaceCell_0(this, cellId, npts, pts);
}


// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public new void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	API_vtkUnstructuredGridBase.GetIdsOfCellsOfType_0(this, type, array);
}


// virtual int IsHomogeneous()
// "virtual int IsHomogeneous()"
public new int IsHomogeneous() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new int())*return_elements);
	API_vtkUnstructuredGridBase.IsHomogeneous_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


}
};
