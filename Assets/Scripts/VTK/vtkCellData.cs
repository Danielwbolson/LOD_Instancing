

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellData : vtkDataSetAttributes {
		public vtkCellData(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellData(IntPtr p) {return new vtkCellData(p);}
		public static implicit operator  IntPtr(vtkCellData o) {return o.GetPtr();}

// static vtkCellData* New()
// "static vtkCellData *New()"
public static vtkCellData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellData.New_0(returnPointer.GetPtr());
	return (vtkCellData)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkCellData.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkCellData.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCellData* SafeDownCast(vtkObjectBase * o)
// "static vtkCellData* SafeDownCast(vtkObjectBase *o)"
public static vtkCellData SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellData.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCellData)(IntPtr)returnPointer;
}


// vtkCellData* NewInstance()
// "vtkCellData *NewInstance()"
public vtkCellData NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkCellData.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCellData)(IntPtr)returnPointer;
}


}
};
