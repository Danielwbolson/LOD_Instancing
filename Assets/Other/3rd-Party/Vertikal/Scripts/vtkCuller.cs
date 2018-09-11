

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCuller : vtkObject {
		public vtkCuller(IntPtr p) : base(p) {}
		public static implicit operator  vtkCuller(IntPtr p) {return new vtkCuller(p);}
		public static implicit operator  IntPtr(vtkCuller o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCuller.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkCuller.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkCuller* SafeDownCast(vtkObjectBase * o)
// "static vtkCuller* SafeDownCast(vtkObjectBase *o)"
public static vtkCuller SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCuller.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkCuller)(IntPtr)returnPointer;
}


// vtkCuller* NewInstance()
// "vtkCuller *NewInstance()"
public vtkCuller NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkCuller.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkCuller)(IntPtr)returnPointer;
}


// virtual double Cull(vtkRenderer * ren, vtkProp ** propList, int & listLength, int & initialized)
// "virtual double Cull( vtkRenderer *ren, vtkProp **propList, int& listLength, int& initialized )"
public double Cull(vtkRenderer /*(vtkRenderer*)*/ ren, vtkProp /*(vtkProp**)*/ propList, IntPtr /*(int&)*/ listLength, IntPtr /*(int&)*/ initialized) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkCuller.Cull_0(returnPointer.GetPtr(), this, ren, propList, listLength, initialized);
	return (double)returnPointer;
}


}
};
