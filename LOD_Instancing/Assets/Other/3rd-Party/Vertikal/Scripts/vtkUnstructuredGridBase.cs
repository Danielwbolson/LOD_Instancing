

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGridBase : vtkPointSet {
		public vtkUnstructuredGridBase(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGridBase(IntPtr p) {return new vtkUnstructuredGridBase(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGridBase o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGridBase.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkUnstructuredGridBase.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGridBase SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridBase.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


// vtkUnstructuredGridBase* NewInstance()
// "vtkUnstructuredGridBase *NewInstance()"
public vtkUnstructuredGridBase NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridBase.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGridBase.GetDataObjectType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkUnstructuredGridBase.Allocate_0(this, numCells, extSize);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGridBase.DeepCopy_0(this, src);
}


// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds)
// "virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds)"
public long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGridBase.InsertNextCell_0(returnPointer.GetPtr(), this, type, npts, ptIds);
	return (long)returnPointer;
}


// virtual vtkIdType InsertNextCell(int type, vtkIdList * ptIds)
// "virtual vtkIdType InsertNextCell(int type, vtkIdList *ptIds)"
public long InsertNextCell(int /*(int)*/ type, vtkIdList /*(vtkIdList*)*/ ptIds) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGridBase.InsertNextCell_1(returnPointer.GetPtr(), this, type, ptIds);
	return (long)returnPointer;
}


// virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType * ptIds, vtkIdType nfaces, vtkIdType * faces)
// "virtual vtkIdType InsertNextCell(int type, vtkIdType npts, vtkIdType *ptIds, vtkIdType nfaces, vtkIdType *faces)"
public long InsertNextCell(int /*(int)*/ type, long /*(vtkIdType)*/ npts, IntPtr /*(vtkIdType*)*/ ptIds, long /*(vtkIdType)*/ nfaces, IntPtr /*(vtkIdType*)*/ faces) {
	ReturnPointer returnPointer = new ReturnPointer(new long());
	VTK_API.API_vtkUnstructuredGridBase.InsertNextCell_2(returnPointer.GetPtr(), this, type, npts, ptIds, nfaces, faces);
	return (long)returnPointer;
}


// virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType * pts)
// "virtual void ReplaceCell(vtkIdType cellId, int npts, vtkIdType *pts)"
public void ReplaceCell(long /*(vtkIdType)*/ cellId, int /*(int)*/ npts, IntPtr /*(vtkIdType*)*/ pts) {
	VTK_API.API_vtkUnstructuredGridBase.ReplaceCell_0(this, cellId, npts, pts);
}


// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	VTK_API.API_vtkUnstructuredGridBase.GetIdsOfCellsOfType_0(this, type, array);
}


// virtual int IsHomogeneous()
// "virtual int IsHomogeneous()"
public int IsHomogeneous() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkUnstructuredGridBase.IsHomogeneous_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// static vtkUnstructuredGridBase* GetData(vtkInformation * info)
// "static vtkUnstructuredGridBase* GetData(vtkInformation* info)"
public static vtkUnstructuredGridBase GetData(vtkInformation /*(vtkInformation*)*/ info) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridBase.GetData_0(returnPointer.GetPtr(), info);
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


// static vtkUnstructuredGridBase* GetData(vtkInformationVector * v, int i = 0)
// "static vtkUnstructuredGridBase* GetData(vtkInformationVector* v, int i=0)"
public static vtkUnstructuredGridBase GetData(vtkInformationVector /*(vtkInformationVector*)*/ v, int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkUnstructuredGridBase.GetData_1(returnPointer.GetPtr(), v, i);
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


}
};
