

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractCellLinks : vtkObject {
		public vtkAbstractCellLinks(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractCellLinks(IntPtr p) {return new vtkAbstractCellLinks(p);}
		public static implicit operator  IntPtr(vtkAbstractCellLinks o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractCellLinks SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
}


// vtkAbstractCellLinks* NewInstance()
// "vtkAbstractCellLinks *NewInstance()"
public vtkAbstractCellLinks NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
}


// virtual void BuildLinks(vtkDataSet * data)
// "virtual void BuildLinks(vtkDataSet *data)"
public void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data) {
	VTK_API.API_vtkAbstractCellLinks.BuildLinks_0(this, data);
}


// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// "static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)"
public static int GetIdType(long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, vtkCellArray /*(vtkCellArray*)*/ ca) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkAbstractCellLinks.GetIdType_0(returnPointer.GetPtr(), maxPtId, maxCellId, ca);
	return (int)returnPointer;
}


}
};
