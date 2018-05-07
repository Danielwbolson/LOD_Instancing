

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPlanes : vtkImplicitFunction {
		public vtkPlanes(IntPtr p) : base(p) {}
		public static implicit operator  vtkPlanes(IntPtr p) {return new vtkPlanes(p);}
		public static implicit operator  IntPtr(vtkPlanes o) {return o.GetPtr();}

// static vtkPlanes* New()
// "static vtkPlanes *New()"
public static vtkPlanes New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.New_0(returnPointer.GetPtr());
	return (vtkPlanes)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlanes.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlanes.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPlanes* SafeDownCast(vtkObjectBase * o)
// "static vtkPlanes* SafeDownCast(vtkObjectBase *o)"
public static vtkPlanes SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPlanes)(IntPtr)returnPointer;
}


// vtkPlanes* NewInstance()
// "vtkPlanes *NewInstance()"
public vtkPlanes NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPlanes)(IntPtr)returnPointer;
}


// double EvaluateFunction(double x[3])
// "double EvaluateFunction(double x[3])"
public double EvaluateFunction(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPlanes.EvaluateFunction_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// void EvaluateGradient(double x[3], double n[3])
// "void EvaluateGradient(double x[3], double n[3])"
public void EvaluateGradient(double /*(double[3])*/ []x, double /*(double[3])*/ []n) {
	VTK_API.API_vtkPlanes.EvaluateGradient_0(this, x, n);
}


// virtual void SetPoints(vtkPoints * ARG_0)
// "virtual void SetPoints(vtkPoints*)"
public void SetPoints(vtkPoints /*(vtkPoints*)*/ ARG_0) {
	VTK_API.API_vtkPlanes.SetPoints_0(this, ARG_0);
}


// virtual vtkPoints* GetPoints()
// "virtual vtkPoints *GetPoints ()"
public vtkPoints GetPoints() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.GetPoints_0(returnPointer.GetPtr(), this);
	return (vtkPoints)(IntPtr)returnPointer;
}


// void SetNormals(vtkDataArray * normals)
// "void SetNormals(vtkDataArray* normals)"
public void SetNormals(vtkDataArray /*(vtkDataArray*)*/ normals) {
	VTK_API.API_vtkPlanes.SetNormals_0(this, normals);
}


// virtual vtkDataArray* GetNormals()
// "virtual vtkDataArray *GetNormals ()"
public vtkDataArray GetNormals() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.GetNormals_0(returnPointer.GetPtr(), this);
	return (vtkDataArray)(IntPtr)returnPointer;
}


// void SetFrustumPlanes(double planes[24])
// "void SetFrustumPlanes(double planes[24])"
public void SetFrustumPlanes(double /*(double[24])*/ []planes) {
	VTK_API.API_vtkPlanes.SetFrustumPlanes_0(this, planes);
}


// void SetBounds(const double bounds[6])
// "void SetBounds(const double bounds[6])"
public void SetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkPlanes.SetBounds_0(this, bounds);
}


// void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// "void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)"
public void SetBounds(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax) {
	VTK_API.API_vtkPlanes.SetBounds_1(this, xmin, xmax, ymin, ymax, zmin, zmax);
}


// int GetNumberOfPlanes()
// "int GetNumberOfPlanes()"
public int GetNumberOfPlanes() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPlanes.GetNumberOfPlanes_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkPlane* GetPlane(int i)
// "vtkPlane *GetPlane(int i)"
public vtkPlane GetPlane(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlanes.GetPlane_0(returnPointer.GetPtr(), this, i);
	return (vtkPlane)(IntPtr)returnPointer;
}


// void GetPlane(int i, vtkPlane * plane)
// "void GetPlane(int i, vtkPlane *plane)"
public void GetPlane(int /*(int)*/ i, vtkPlane /*(vtkPlane*)*/ plane) {
	VTK_API.API_vtkPlanes.GetPlane_1(this, i, plane);
}


}
};
