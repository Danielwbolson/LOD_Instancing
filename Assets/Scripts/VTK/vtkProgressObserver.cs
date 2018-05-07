

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProgressObserver : vtkObject {
		public vtkProgressObserver(IntPtr p) : base(p) {}
		public static implicit operator  vtkProgressObserver(IntPtr p) {return new vtkProgressObserver(p);}
		public static implicit operator  IntPtr(vtkProgressObserver o) {return o.GetPtr();}

// static vtkProgressObserver* New()
// "static vtkProgressObserver *New()"
public static vtkProgressObserver New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProgressObserver.New_0(returnPointer.GetPtr());
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProgressObserver.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProgressObserver.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProgressObserver* SafeDownCast(vtkObjectBase * o)
// "static vtkProgressObserver* SafeDownCast(vtkObjectBase *o)"
public static vtkProgressObserver SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProgressObserver.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// vtkProgressObserver* NewInstance()
// "vtkProgressObserver *NewInstance()"
public vtkProgressObserver NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProgressObserver.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// virtual void UpdateProgress(double amount)
// "virtual void UpdateProgress(double amount)"
public void UpdateProgress(double /*(double)*/ amount) {
	VTK_API.API_vtkProgressObserver.UpdateProgress_0(this, amount);
}


// virtual double GetProgress()
// "virtual double GetProgress ()"
public double GetProgress() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProgressObserver.GetProgress_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


}
};
