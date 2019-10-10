

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderPass : vtkObject {
		public vtkRenderPass(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderPass(IntPtr p) {return new vtkRenderPass(p);}
		public static implicit operator  IntPtr(vtkRenderPass o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderPass.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderPass.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkRenderPass* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderPass* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderPass SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderPass.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkRenderPass)(IntPtr)returnPointer;
}


// vtkRenderPass* NewInstance()
// "vtkRenderPass *NewInstance()"
public vtkRenderPass NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderPass.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkRenderPass)(IntPtr)returnPointer;
}


// virtual int GetNumberOfRenderedProps()
// "virtual int GetNumberOfRenderedProps ()"
public int GetNumberOfRenderedProps() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderPass.GetNumberOfRenderedProps_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * w)
// "virtual void ReleaseGraphicsResources(vtkWindow *w)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ w) {
	VTK_API.API_vtkRenderPass.ReleaseGraphicsResources_0(this, w);
}


}
};
