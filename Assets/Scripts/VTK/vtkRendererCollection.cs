

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRendererCollection : vtkCollection {
		public vtkRendererCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkRendererCollection(IntPtr p) {return new vtkRendererCollection(p);}
		public static implicit operator  IntPtr(vtkRendererCollection o) {return o.GetPtr();}

// static vtkRendererCollection* New()
// "static vtkRendererCollection *New()"
public static vtkRendererCollection New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererCollection.New_0(returnPointer.GetPtr());
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRendererCollection.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRendererCollection.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkRendererCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkRendererCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkRendererCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererCollection.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// vtkRendererCollection* NewInstance()
// "vtkRendererCollection *NewInstance()"
public vtkRendererCollection NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererCollection.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkRenderer * a)
// "void AddItem(vtkRenderer *a)"
public void AddItem(vtkRenderer /*(vtkRenderer*)*/ a) {
	VTK_API.API_vtkRendererCollection.AddItem_0(this, a);
}


// vtkRenderer* GetNextItem()
// "vtkRenderer *GetNextItem()"
public vtkRenderer GetNextItem() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererCollection.GetNextItem_0(returnPointer.GetPtr(), this);
	return (vtkRenderer)(IntPtr)returnPointer;
}


// void Render()
// "void Render()"
public void Render() {
	VTK_API.API_vtkRendererCollection.Render_0(this);
}


// vtkRenderer* GetFirstRenderer()
// "vtkRenderer *GetFirstRenderer()"
public vtkRenderer GetFirstRenderer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRendererCollection.GetFirstRenderer_0(returnPointer.GetPtr(), this);
	return (vtkRenderer)(IntPtr)returnPointer;
}


}
};
