

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellArray : vtkObject {
		public vtkCellArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellArray(IntPtr p) {return new vtkCellArray(p);}
		public static implicit operator  IntPtr(vtkCellArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCellArray.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCellArray.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCellArray* SafeDownCast(vtkObjectBase * o)
// "static vtkCellArray* SafeDownCast(vtkObjectBase *o)"
public static vtkCellArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCellArray)(IntPtr)returnPointer;
}


// vtkCellArray* NewInstance()
// "vtkCellArray *NewInstance()"
public vtkCellArray NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCellArray)(IntPtr)returnPointer;
}


// static vtkCellArray* New()
// "static vtkCellArray *New()"
public static vtkCellArray New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.New_0(returnPointer.GetPtr());
	return (vtkCellArray)(IntPtr)returnPointer;
}


// int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "int Allocate(vtkIdType sz, vtkIdType ext=1000)"
public int Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellArray.Allocate_0(returnPointer.GetPtr(), this, sz, ext);
	return (int)returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkCellArray.Initialize_0(this);
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells ()"
public long GetNumberOfCells() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetNumberOfCells_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// virtual void SetNumberOfCells(vtkIdType _arg)
// "virtual void SetNumberOfCells (vtkIdType _arg)"
public void SetNumberOfCells(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkCellArray.SetNumberOfCells_0(this, _arg);
}


// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// "vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)"
public long EstimateSize(long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.EstimateSize_0(returnPointer.GetPtr(), this, numCells, maxPtsPerCell);
	return (long)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCellArray.InitTraversal_0(this);
}


// int GetNextCell(vtkIdType & npts, vtkIdType *& pts)
// "int GetNextCell(vtkIdType& npts, vtkIdType* &pts)"
public int GetNextCell(IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellArray.GetNextCell_0(returnPointer.GetPtr(), this, npts, pts);
	return (int)returnPointer;
}


// int GetNextCell(vtkIdList * pts)
// "int GetNextCell(vtkIdList *pts)"
public int GetNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellArray.GetNextCell_1(returnPointer.GetPtr(), this, pts);
	return (int)returnPointer;
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public long GetSize() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetSize_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfConnectivityEntries()
// "vtkIdType GetNumberOfConnectivityEntries()"
public long GetNumberOfConnectivityEntries() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetNumberOfConnectivityEntries_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// "void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)"
public void GetCell(long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	VTK_API.API_vtkCellArray.GetCell_0(this, loc, npts, pts);
}


// void GetCell(vtkIdType loc, vtkIdList * pts)
// "void GetCell(vtkIdType loc, vtkIdList* pts)"
public void GetCell(long /*(vtkIdType)*/ loc, vtkIdList /*(vtkIdList*)*/ pts) {
	VTK_API.API_vtkCellArray.GetCell_1(this, loc, pts);
}


// vtkIdType InsertNextCell(vtkCell * cell)
// "vtkIdType InsertNextCell(vtkCell *cell)"
public long InsertNextCell(vtkCell /*(vtkCell*)*/ cell) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.InsertNextCell_0(returnPointer.GetPtr(), this, cell);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(vtkIdType npts, const vtkIdType * pts)
// "vtkIdType InsertNextCell(vtkIdType npts, const vtkIdType* pts)"
public long InsertNextCell(long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.InsertNextCell_1(returnPointer.GetPtr(), this, npts, pts);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(vtkIdList * pts)
// "vtkIdType InsertNextCell(vtkIdList *pts)"
public long InsertNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.InsertNextCell_2(returnPointer.GetPtr(), this, pts);
	return (long)returnPointer;
}


// vtkIdType InsertNextCell(int npts)
// "vtkIdType InsertNextCell(int npts)"
public long InsertNextCell(int /*(int)*/ npts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.InsertNextCell_3(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// void InsertCellPoint(vtkIdType id)
// "void InsertCellPoint(vtkIdType id)"
public void InsertCellPoint(long /*(vtkIdType)*/ id) {
	VTK_API.API_vtkCellArray.InsertCellPoint_0(this, id);
}


// void UpdateCellCount(int npts)
// "void UpdateCellCount(int npts)"
public void UpdateCellCount(int /*(int)*/ npts) {
	VTK_API.API_vtkCellArray.UpdateCellCount_0(this, npts);
}


// vtkIdType GetInsertLocation(int npts)
// "vtkIdType GetInsertLocation(int npts)"
public long GetInsertLocation(int /*(int)*/ npts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetInsertLocation_0(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// vtkIdType GetTraversalLocation()
// "vtkIdType GetTraversalLocation()"
public long GetTraversalLocation() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetTraversalLocation_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// void SetTraversalLocation(vtkIdType loc)
// "void SetTraversalLocation(vtkIdType loc)"
public void SetTraversalLocation(long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellArray.SetTraversalLocation_0(this, loc);
}


// vtkIdType GetTraversalLocation(vtkIdType npts)
// "vtkIdType GetTraversalLocation(vtkIdType npts)"
public long GetTraversalLocation(long /*(vtkIdType)*/ npts) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellArray.GetTraversalLocation_1(returnPointer.GetPtr(), this, npts);
	return (long)returnPointer;
}


// void ReverseCell(vtkIdType loc)
// "void ReverseCell(vtkIdType loc)"
public void ReverseCell(long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellArray.ReverseCell_0(this, loc);
}


// void ReplaceCell(vtkIdType loc, int npts, const vtkIdType * pts)
// "void ReplaceCell(vtkIdType loc, int npts, const vtkIdType *pts)"
public void ReplaceCell(long /*(vtkIdType)*/ loc, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	VTK_API.API_vtkCellArray.ReplaceCell_0(this, loc, npts, pts);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellArray.GetMaxCellSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkIdType* GetPointer()
// "vtkIdType *GetPointer()"
public IntPtr GetPointer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.GetPointer_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// "vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)"
public IntPtr WritePointer(long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.WritePointer_0(returnPointer.GetPtr(), this, ncells, size);
	return (IntPtr)returnPointer;
}


// void SetCells(vtkIdType ncells, vtkIdTypeArray * cells)
// "void SetCells(vtkIdType ncells, vtkIdTypeArray *cells)"
public void SetCells(long /*(vtkIdType)*/ ncells, vtkIdTypeArray /*(vtkIdTypeArray*)*/ cells) {
	VTK_API.API_vtkCellArray.SetCells_0(this, ncells, cells);
}


// void DeepCopy(vtkCellArray * ca)
// "void DeepCopy(vtkCellArray *ca)"
public void DeepCopy(vtkCellArray /*(vtkCellArray*)*/ ca) {
	VTK_API.API_vtkCellArray.DeepCopy_0(this, ca);
}


// vtkIdTypeArray* GetData()
// "vtkIdTypeArray* GetData()"
public vtkIdTypeArray GetData() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellArray.GetData_0(returnPointer.GetPtr(), this);
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkCellArray.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkCellArray.Squeeze_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkCellArray.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


}
};
