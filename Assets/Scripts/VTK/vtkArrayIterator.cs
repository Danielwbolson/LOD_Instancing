

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkArrayIterator : vtkObject {
		public vtkArrayIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkArrayIterator(IntPtr p) {return new vtkArrayIterator(p);}
		public static implicit operator  IntPtr(vtkArrayIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkArrayIterator.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new bool(), return_elements);
	VTK_API.API_vtkArrayIterator.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkArrayIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkArrayIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkArrayIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkArrayIterator.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// vtkArrayIterator* NewInstance()
// "vtkArrayIterator *NewInstance()"
public vtkArrayIterator NewInstance() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr(), return_elements);
	VTK_API.API_vtkArrayIterator.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// virtual void Initialize(vtkAbstractArray * array)
// "virtual void Initialize(vtkAbstractArray* array)"
public void Initialize(vtkAbstractArray /*(vtkAbstractArray*)*/ array) {
	VTK_API.API_vtkArrayIterator.Initialize_0(this, array);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public int GetDataType() {
	int return_elements = 1;
	ReturnPointer returnPointer = new ReturnPointer(new int(), return_elements);
	VTK_API.API_vtkArrayIterator.GetDataType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
