

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellIterator : vtkObject {
		public vtkCellIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellIterator(IntPtr p) {return new vtkCellIterator(p);}
		public static implicit operator  IntPtr(vtkCellIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCellIterator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCellIterator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCellIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkCellIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkCellIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellIterator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// vtkCellIterator* NewInstance()
// "vtkCellIterator *NewInstance()"
public vtkCellIterator NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellIterator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCellIterator.InitTraversal_0(this);
}


// void GoToNextCell()
// "void GoToNextCell()"
public void GoToNextCell() {
	VTK_API.API_vtkCellIterator.GoToNextCell_0(this);
}


// virtual bool IsDoneWithTraversal()
// "virtual bool IsDoneWithTraversal()"
public bool IsDoneWithTraversal() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCellIterator.IsDoneWithTraversal_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// int GetCellType()
// "int GetCellType()"
public int GetCellType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellIterator.GetCellType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// int GetCellDimension()
// "int GetCellDimension()"
public int GetCellDimension() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkCellIterator.GetCellDimension_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkIdType GetCellId()
// "virtual vtkIdType GetCellId()"
public long GetCellId() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellIterator.GetCellId_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public vtkIdList GetPointIds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellIterator.GetPointIds_0(returnPointer.GetPtr(), this);
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public vtkPoints GetPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellIterator.GetPoints_0(returnPointer.GetPtr(), this);
	return (vtkPoints)(IntPtr)returnPointer;
}


// vtkIdList* GetFaces()
// "vtkIdList *GetFaces()"
public vtkIdList GetFaces() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCellIterator.GetFaces_0(returnPointer.GetPtr(), this);
	return (vtkIdList)(IntPtr)returnPointer;
}


// void GetCell(vtkGenericCell * cell)
// "void GetCell(vtkGenericCell *cell)"
public void GetCell(vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkCellIterator.GetCell_0(this, cell);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellIterator.GetNumberOfPoints_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


// vtkIdType GetNumberOfFaces()
// "vtkIdType GetNumberOfFaces()"
public long GetNumberOfFaces() {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkCellIterator.GetNumberOfFaces_0(returnPointer.GetPtr(), this);
	return (long)returnPointer;
}


}
};
