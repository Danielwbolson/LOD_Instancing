

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFrameBufferObjectBase : vtkObject {
		public vtkFrameBufferObjectBase(IntPtr p) : base(p) {}
		public static implicit operator  vtkFrameBufferObjectBase(IntPtr p) {return new vtkFrameBufferObjectBase(p);}
		public static implicit operator  IntPtr(vtkFrameBufferObjectBase o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFrameBufferObjectBase.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkFrameBufferObjectBase.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkFrameBufferObjectBase* SafeDownCast(vtkObjectBase * o)
// "static vtkFrameBufferObjectBase* SafeDownCast(vtkObjectBase *o)"
public static vtkFrameBufferObjectBase SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFrameBufferObjectBase.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkFrameBufferObjectBase)(IntPtr)returnPointer;
}


// vtkFrameBufferObjectBase* NewInstance()
// "vtkFrameBufferObjectBase *NewInstance()"
public vtkFrameBufferObjectBase NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFrameBufferObjectBase.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkFrameBufferObjectBase)(IntPtr)returnPointer;
}


// virtual int* GetLastSize()
// "virtual int *GetLastSize()"
public IntPtr GetLastSize() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkFrameBufferObjectBase.GetLastSize_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetLastSize(int & _arg1, int & _arg2)
// "virtual void GetLastSize (int &_arg1, int &_arg2)"
public void GetLastSize(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkFrameBufferObjectBase.GetLastSize_1(this, _arg1, _arg2);
}


// virtual void GetLastSize(int _arg[2])
// "virtual void GetLastSize (int _arg[2])"
public void GetLastSize(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkFrameBufferObjectBase.GetLastSize_2(this, _arg);
}


}
};
