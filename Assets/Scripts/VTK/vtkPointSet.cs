

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointSet : vtkDataSet {
		public vtkPointSet(IntPtr p) : base(p) {}
		public static implicit operator  vtkPointSet(IntPtr p) {return new vtkPointSet(p);}
		public static implicit operator  IntPtr(vtkPointSet o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPointSet.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPointSet.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPointSet* SafeDownCast(vtkObjectBase * o)
// "static vtkPointSet* SafeDownCast(vtkObjectBase *o)"
public static vtkPointSet SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPointSet.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPointSet)(IntPtr)returnPointer;
}


// vtkPointSet* NewInstance()
// "vtkPointSet *NewInstance()"
public vtkPointSet NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPointSet.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPointSet)(IntPtr)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkPointSet.Initialize_0(this);
}


// void CopyStructure(vtkDataSet * pd)
// "void CopyStructure(vtkDataSet *pd)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ pd) {
	VTK_API.API_vtkPointSet.CopyStructure_0(this, pd);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkPointSet.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetPoint(vtkIdType ptId, double x[3])
// "void GetPoint(vtkIdType ptId, double x[3])"
public void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	VTK_API.API_vtkPointSet.GetPoint_0(this, ptId, x);
}


// vtkIdType FindPoint(double x[3])
// "vtkIdType FindPoint(double x[3])"
public long FindPoint(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkPointSet.FindPoint_0(returnPointer.GetPtr(), this, x);
	return (long)returnPointer;
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkPointSet.FindPoint_1(returnPointer.GetPtr(), this, x, y, z);
	return (long)returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkPointSet.FindCell_0(returnPointer.GetPtr(), this, x, cell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, IntPtr /*(double*)*/ weights) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkPointSet.FindCell_1(returnPointer.GetPtr(), this, x, cell, gencell, cellId, tol2, subId, pcoords, weights);
	return (long)returnPointer;
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public IntPtr GetPoint(long /*(vtkIdType)*/ ptId) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPointSet.GetPoint_1(returnPointer.GetPtr(), this, ptId);
	return (IntPtr)returnPointer;
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPointSet.NewCellIterator_0(returnPointer.GetPtr(), this);
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkPointSet.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void ComputeBounds()
// "void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkPointSet.ComputeBounds_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkPointSet.Squeeze_0(this);
}


// virtual void SetPoints(vtkPoints * ARG_0)
// "virtual void SetPoints(vtkPoints*)"
public void SetPoints(vtkPoints /*(vtkPoints*)*/ ARG_0) {
	VTK_API.API_vtkPointSet.SetPoints_0(this, ARG_0);
}


// virtual vtkPoints* GetPoints()
// "virtual vtkPoints *GetPoints ()"
public vtkPoints GetPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPointSet.GetPoints_0(returnPointer.GetPtr(), this);
	return (vtkPoints)(IntPtr)returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkPointSet.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPointSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPointSet.DeepCopy_0(this, src);
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase* o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkPointSet.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase* o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkPointSet.UnRegister_0(this, o);
}


}
};
