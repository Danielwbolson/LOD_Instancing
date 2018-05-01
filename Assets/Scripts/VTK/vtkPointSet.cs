

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointSet : vtkDataSet {

// void Initialize()
// "void Initialize()"
public new void Initialize() {
	API_vtkPointSet.Initialize_0(this);
}


// void CopyStructure(vtkDataSet * pd)
// "void CopyStructure(vtkDataSet *pd)"
public new void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ pd) {
	API_vtkPointSet.CopyStructure_0(this, pd);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public new long GetNumberOfPoints() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPointSet.GetNumberOfPoints_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void GetPoint(vtkIdType ptId, double x[3])
// "void GetPoint(vtkIdType ptId, double x[3])"
public new void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	API_vtkPointSet.GetPoint_0(this, ptId, x);
}


// vtkIdType FindPoint(double x[3])
// "vtkIdType FindPoint(double x[3])"
public new long FindPoint(double /*(double[3])*/ []x) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPointSet.FindPoint_0(this, returnPointer, x);
	return Ptr.deref(returnPointer);
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public new long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPointSet.FindPoint_1(this, returnPointer, x, y, z);
	return Ptr.deref(returnPointer);
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public new long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPointSet.FindCell_0(this, returnPointer, x, cell, cellId, tol2, *subId, pcoords, weights);
	return Ptr.deref(returnPointer);
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public new long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, int /*(int&)*/ []subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new long())*return_elements);
	API_vtkPointSet.FindCell_1(this, returnPointer, x, cell, gencell, cellId, tol2, *subId, pcoords, weights);
	return Ptr.deref(returnPointer);
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public new double GetPoint(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new double())*return_elements);
	API_vtkPointSet.GetPoint_1(this, returnPointer, ptId);
	return Ptr.deref(returnPointer);
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public new vtkCellIterator NewCellIterator() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new IntPtr())*return_elements);
	API_vtkPointSet.NewCellIterator_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public new ulong GetMTime() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPointSet.GetMTime_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ComputeBounds()
// "void ComputeBounds()"
public new void ComputeBounds() {
	API_vtkPointSet.ComputeBounds_0(this);
}


// void Squeeze()
// "void Squeeze()"
public new void Squeeze() {
	API_vtkPointSet.Squeeze_0(this);
}


// virtual void SetPoints(vtkPoints * ARG_0)
// "virtual void SetPoints(vtkPoints*)"
public new void SetPoints(vtkPoints /*(vtkPoints*)*/ ARG_0) {
	API_vtkPointSet.SetPoints_0(this, ARG_0);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public new ulong GetActualMemorySize() {
	int return_elements = 1;
	IntPtr returnPointer = Marshal.AllocHGlobal(Marshal.SizeOf(new ulong())*return_elements);
	API_vtkPointSet.GetActualMemorySize_0(this, returnPointer);
	return Ptr.deref(returnPointer);
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public new void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkPointSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public new void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	API_vtkPointSet.DeepCopy_0(this, src);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public new void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkPointSet.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public new void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	API_vtkPointSet.UnRegister_0(this, o);
}


}
};
