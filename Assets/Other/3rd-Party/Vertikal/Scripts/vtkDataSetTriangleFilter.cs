

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSetTriangleFilter : vtkUnstructuredGridAlgorithm {
		public vtkDataSetTriangleFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataSetTriangleFilter(IntPtr p) {return new vtkDataSetTriangleFilter(p);}
		public static implicit operator  IntPtr(vtkDataSetTriangleFilter o) {return o.GetPtr();}

// static vtkDataSetTriangleFilter* New()
// "static vtkDataSetTriangleFilter *New()"
public static vtkDataSetTriangleFilter New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataSetTriangleFilter.New_0(returnPointer.GetPtr());
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataSetTriangleFilter.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkDataSetTriangleFilter.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkDataSetTriangleFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkDataSetTriangleFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataSetTriangleFilter.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// vtkDataSetTriangleFilter* NewInstance()
// "vtkDataSetTriangleFilter *NewInstance()"
public vtkDataSetTriangleFilter NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkDataSetTriangleFilter.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkDataSetTriangleFilter)(IntPtr)returnPointer;
}


// virtual void SetTetrahedraOnly(int _arg)
// "virtual void SetTetrahedraOnly (int _arg)"
public void SetTetrahedraOnly(int /*(int)*/ _arg) {
	VTK_API.API_vtkDataSetTriangleFilter.SetTetrahedraOnly_0(this, _arg);
}


// virtual int GetTetrahedraOnly()
// "virtual int GetTetrahedraOnly ()"
public int GetTetrahedraOnly() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkDataSetTriangleFilter.GetTetrahedraOnly_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void TetrahedraOnlyOn()
// "virtual void TetrahedraOnlyOn ()"
public void TetrahedraOnlyOn() {
	VTK_API.API_vtkDataSetTriangleFilter.TetrahedraOnlyOn_0(this);
}


// virtual void TetrahedraOnlyOff()
// "virtual void TetrahedraOnlyOff ()"
public void TetrahedraOnlyOff() {
	VTK_API.API_vtkDataSetTriangleFilter.TetrahedraOnlyOff_0(this);
}


}
};
