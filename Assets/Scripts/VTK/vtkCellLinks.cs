

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellLinks : vtkAbstractCellLinks {
		public vtkCellLinks(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellLinks(IntPtr p) {return new vtkCellLinks(p);}
		public static implicit operator  IntPtr(vtkCellLinks o) {return o.GetPtr();}

// static vtkCellLinks* New()
// "static vtkCellLinks *New()"
public static vtkCellLinks New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellLinks.New_0(returnPointer.GetPtr());
	return (vtkCellLinks)(IntPtr)returnPointer;
}


// void BuildLinks(vtkDataSet * data)
// "void BuildLinks(vtkDataSet *data)"
public void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data) {
	API_vtkCellLinks.BuildLinks_0(this, data);
}


// void BuildLinks(vtkDataSet * data, vtkCellArray * Connectivity)
// "void BuildLinks(vtkDataSet *data, vtkCellArray *Connectivity)"
public void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data, vtkCellArray /*(vtkCellArray*)*/ Connectivity) {
	API_vtkCellLinks.BuildLinks_1(this, data, Connectivity);
}


// void Allocate(vtkIdType numLinks, vtkIdType ext = 1000)
// "void Allocate(vtkIdType numLinks, vtkIdType ext=1000)"
public void Allocate(long /*(vtkIdType)*/ numLinks, long /*(vtkIdType)*/ ext) {
	API_vtkCellLinks.Allocate_0(this, numLinks, ext);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	API_vtkCellLinks.Initialize_0(this);
}


// short GetNcells(vtkIdType ptId)
// "unsigned short GetNcells(vtkIdType ptId)"
public short GetNcells(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new short(), return_elements);
	API_vtkCellLinks.GetNcells_0(returnPointer.GetPtr(), this, ptId);
	return (short)returnPointer;
}


// vtkIdType* GetCells(vtkIdType ptId)
// "vtkIdType *GetCells(vtkIdType ptId)"
public IntPtr GetCells(long /*(vtkIdType)*/ ptId) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	API_vtkCellLinks.GetCells_0(returnPointer.GetPtr(), this, ptId);
	return (IntPtr)returnPointer;
}


// vtkIdType InsertNextPoint(int numLinks)
// "vtkIdType InsertNextPoint(int numLinks)"
public long InsertNextPoint(int /*(int)*/ numLinks) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new long(), return_elements);
	API_vtkCellLinks.InsertNextPoint_0(returnPointer.GetPtr(), this, numLinks);
	return (long)returnPointer;
}


// void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)
// "void InsertNextCellReference(vtkIdType ptId, vtkIdType cellId)"
public void InsertNextCellReference(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	API_vtkCellLinks.InsertNextCellReference_0(this, ptId, cellId);
}


// void DeletePoint(vtkIdType ptId)
// "void DeletePoint(vtkIdType ptId)"
public void DeletePoint(long /*(vtkIdType)*/ ptId) {
	API_vtkCellLinks.DeletePoint_0(this, ptId);
}


// void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)
// "void RemoveCellReference(vtkIdType cellId, vtkIdType ptId)"
public void RemoveCellReference(long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId) {
	API_vtkCellLinks.RemoveCellReference_0(this, cellId, ptId);
}


// void AddCellReference(vtkIdType cellId, vtkIdType ptId)
// "void AddCellReference(vtkIdType cellId, vtkIdType ptId)"
public void AddCellReference(long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ ptId) {
	API_vtkCellLinks.AddCellReference_0(this, cellId, ptId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	API_vtkCellLinks.ResizeCellList_0(this, ptId, size);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	API_vtkCellLinks.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public void Reset() {
	API_vtkCellLinks.Reset_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new ulong(), return_elements);
	API_vtkCellLinks.GetActualMemorySize_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void DeepCopy(vtkCellLinks * src)
// "void DeepCopy(vtkCellLinks *src)"
public void DeepCopy(vtkCellLinks /*(vtkCellLinks*)*/ src) {
	API_vtkCellLinks.DeepCopy_0(this, src);
}


}
};
