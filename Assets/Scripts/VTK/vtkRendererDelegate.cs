

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRendererDelegate : vtkObject {
		public vtkRendererDelegate(IntPtr p) : base(p) {}
		public static implicit operator  vtkRendererDelegate(IntPtr p) {return new vtkRendererDelegate(p);}
		public static implicit operator  IntPtr(vtkRendererDelegate o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRendererDelegate.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRendererDelegate.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkRendererDelegate* SafeDownCast(vtkObjectBase * o)
// "static vtkRendererDelegate* SafeDownCast(vtkObjectBase *o)"
public static vtkRendererDelegate SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererDelegate.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkRendererDelegate)(IntPtr)returnPointer;
}


// vtkRendererDelegate* NewInstance()
// "vtkRendererDelegate *NewInstance()"
public vtkRendererDelegate NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererDelegate.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkRendererDelegate)(IntPtr)returnPointer;
}


// virtual void Render(vtkRenderer * r)
// "virtual void Render(vtkRenderer *r)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ r) {
	VTK_API.API_vtkRendererDelegate.Render_0(this, r);
}


// virtual void SetUsed(bool _arg)
// "virtual void SetUsed (bool _arg)"
public void SetUsed(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRendererDelegate.SetUsed_0(this, _arg);
}


// virtual bool GetUsed()
// "virtual bool GetUsed ()"
public bool GetUsed() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRendererDelegate.GetUsed_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void UsedOn()
// "virtual void UsedOn ()"
public void UsedOn() {
	VTK_API.API_vtkRendererDelegate.UsedOn_0(this);
}


// virtual void UsedOff()
// "virtual void UsedOff ()"
public void UsedOff() {
	VTK_API.API_vtkRendererDelegate.UsedOff_0(this);
}


}
};
