

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTriangleFilter : vtkPolyDataAlgorithm {
		public vtkTriangleFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkTriangleFilter(IntPtr p) {return new vtkTriangleFilter(p);}
		public static implicit operator  IntPtr(vtkTriangleFilter o) {return o.GetPtr();}

// static vtkTriangleFilter* New()
// "static vtkTriangleFilter *New()"
public static vtkTriangleFilter New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTriangleFilter.New_0(returnPointer.GetPtr());
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTriangleFilter.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTriangleFilter.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkTriangleFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkTriangleFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkTriangleFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTriangleFilter.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// vtkTriangleFilter* NewInstance()
// "vtkTriangleFilter *NewInstance()"
public vtkTriangleFilter NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTriangleFilter.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkTriangleFilter)(IntPtr)returnPointer;
}


// virtual void PassVertsOn()
// "virtual void PassVertsOn ()"
public void PassVertsOn() {
	VTK_API.API_vtkTriangleFilter.PassVertsOn_0(this);
}


// virtual void PassVertsOff()
// "virtual void PassVertsOff ()"
public void PassVertsOff() {
	VTK_API.API_vtkTriangleFilter.PassVertsOff_0(this);
}


// virtual void SetPassVerts(int _arg)
// "virtual void SetPassVerts (int _arg)"
public void SetPassVerts(int /*(int)*/ _arg) {
	VTK_API.API_vtkTriangleFilter.SetPassVerts_0(this, _arg);
}


// virtual int GetPassVerts()
// "virtual int GetPassVerts ()"
public int GetPassVerts() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTriangleFilter.GetPassVerts_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PassLinesOn()
// "virtual void PassLinesOn ()"
public void PassLinesOn() {
	VTK_API.API_vtkTriangleFilter.PassLinesOn_0(this);
}


// virtual void PassLinesOff()
// "virtual void PassLinesOff ()"
public void PassLinesOff() {
	VTK_API.API_vtkTriangleFilter.PassLinesOff_0(this);
}


// virtual void SetPassLines(int _arg)
// "virtual void SetPassLines (int _arg)"
public void SetPassLines(int /*(int)*/ _arg) {
	VTK_API.API_vtkTriangleFilter.SetPassLines_0(this, _arg);
}


// virtual int GetPassLines()
// "virtual int GetPassLines ()"
public int GetPassLines() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTriangleFilter.GetPassLines_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
