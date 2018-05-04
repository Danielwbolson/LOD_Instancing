

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPointData : vtkDataSetAttributes {
		public vtkPointData(IntPtr p) : base(p) {}
		public static implicit operator  vtkPointData(IntPtr p) {return new vtkPointData(p);}
		public static implicit operator  IntPtr(vtkPointData o) {return o.GetPtr();}

// static vtkPointData* New()
// "static vtkPointData *New()"
public static vtkPointData New() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkPointData.New_0(returnPointer.GetPtr());
	return (vtkPointData)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkPointData.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkPointData.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPointData* SafeDownCast(vtkObjectBase * o)
// "static vtkPointData* SafeDownCast(vtkObjectBase *o)"
public static vtkPointData SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkPointData.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPointData)(IntPtr)returnPointer;
}


// vtkPointData* NewInstance()
// "vtkPointData *NewInstance()"
public vtkPointData NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkPointData.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPointData)(IntPtr)returnPointer;
}


// void NullPoint(vtkIdType ptId)
// "void NullPoint(vtkIdType ptId)"
public void NullPoint(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkPointData.NullPoint_0(this, ptId);
}


}
};
