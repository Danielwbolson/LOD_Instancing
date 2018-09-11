

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPlane : vtkImplicitFunction {
		public vtkPlane(IntPtr p) : base(p) {}
		public static implicit operator  vtkPlane(IntPtr p) {return new vtkPlane(p);}
		public static implicit operator  IntPtr(vtkPlane o) {return o.GetPtr();}

// static vtkPlane* New()
// "static vtkPlane *New()"
public static vtkPlane New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlane.New_0(returnPointer.GetPtr());
	return (vtkPlane)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlane.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPlane.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPlane* SafeDownCast(vtkObjectBase * o)
// "static vtkPlane* SafeDownCast(vtkObjectBase *o)"
public static vtkPlane SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlane.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPlane)(IntPtr)returnPointer;
}


// vtkPlane* NewInstance()
// "vtkPlane *NewInstance()"
public vtkPlane NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlane.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPlane)(IntPtr)returnPointer;
}


// void EvaluateFunction(vtkDataArray * input, vtkDataArray * output)
// "void EvaluateFunction(vtkDataArray* input, vtkDataArray* output)"
public void EvaluateFunction(vtkDataArray /*(vtkDataArray*)*/ input, vtkDataArray /*(vtkDataArray*)*/ output) {
	VTK_API.API_vtkPlane.EvaluateFunction_0(this, input, output);
}


// double EvaluateFunction(double x[3])
// "double EvaluateFunction(double x[3])"
public double EvaluateFunction(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPlane.EvaluateFunction_1(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// void EvaluateGradient(double x[3], double g[3])
// "void EvaluateGradient(double x[3], double g[3])"
public void EvaluateGradient(double /*(double[3])*/ []x, double /*(double[3])*/ []g) {
	VTK_API.API_vtkPlane.EvaluateGradient_0(this, x, g);
}


// virtual void SetNormal(double _arg1, double _arg2, double _arg3)
// "virtual void SetNormal (double _arg1, double _arg2, double _arg3)"
public void SetNormal(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkPlane.SetNormal_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetNormal(double _arg[3])
// "virtual void SetNormal (double _arg[3])"
public void SetNormal(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkPlane.SetNormal_1(this, _arg);
}


// virtual double* GetNormal()
// "virtual double *GetNormal ()"
public IntPtr GetNormal() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlane.GetNormal_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetNormal(double data[3])
// "virtual void GetNormal (double data[3])"
public void GetNormal(double /*(double[3])*/ []data) {
	VTK_API.API_vtkPlane.GetNormal_1(this, data);
}


// virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
// "virtual void SetOrigin (double _arg1, double _arg2, double _arg3)"
public void SetOrigin(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkPlane.SetOrigin_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetOrigin(double _arg[3])
// "virtual void SetOrigin (double _arg[3])"
public void SetOrigin(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkPlane.SetOrigin_1(this, _arg);
}


// virtual double* GetOrigin()
// "virtual double *GetOrigin ()"
public IntPtr GetOrigin() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPlane.GetOrigin_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetOrigin(double data[3])
// "virtual void GetOrigin (double data[3])"
public void GetOrigin(double /*(double[3])*/ []data) {
	VTK_API.API_vtkPlane.GetOrigin_1(this, data);
}


// void Push(double distance)
// "void Push(double distance)"
public void Push(double /*(double)*/ distance) {
	VTK_API.API_vtkPlane.Push_0(this, distance);
}


// static void ProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
// "static void ProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])"
public static void ProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.ProjectPoint_0(x, origin, normal, xproj);
}


// void ProjectPoint(double x[3], double xproj[3])
// "void ProjectPoint(double x[3], double xproj[3])"
public void ProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.ProjectPoint_1(this, x, xproj);
}


// static void ProjectVector(double v[3], double origin[3], double normal[3], double vproj[3])
// "static void ProjectVector(double v[3], double origin[3], double normal[3], double vproj[3])"
public static void ProjectVector(double /*(double[3])*/ []v, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []vproj) {
	VTK_API.API_vtkPlane.ProjectVector_0(v, origin, normal, vproj);
}


// void ProjectVector(double v[3], double vproj[3])
// "void ProjectVector(double v[3], double vproj[3])"
public void ProjectVector(double /*(double[3])*/ []v, double /*(double[3])*/ []vproj) {
	VTK_API.API_vtkPlane.ProjectVector_1(this, v, vproj);
}


// static void GeneralizedProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
// "static void GeneralizedProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])"
public static void GeneralizedProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.GeneralizedProjectPoint_0(x, origin, normal, xproj);
}


// void GeneralizedProjectPoint(double x[3], double xproj[3])
// "void GeneralizedProjectPoint(double x[3], double xproj[3])"
public void GeneralizedProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.GeneralizedProjectPoint_1(this, x, xproj);
}


// static double Evaluate(double normal[3], double origin[3], double x[3])
// "static double Evaluate(double normal[3], double origin[3], double x[3])"
public static double Evaluate(double /*(double[3])*/ []normal, double /*(double[3])*/ []origin, double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPlane.Evaluate_0(returnPointer.GetPtr(), normal, origin, x);
	return (double)returnPointer;
}


// static double DistanceToPlane(double x[3], double n[3], double p0[3])
// "static double DistanceToPlane(double x[3], double n[3], double p0[3])"
public static double DistanceToPlane(double /*(double[3])*/ []x, double /*(double[3])*/ []n, double /*(double[3])*/ []p0) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPlane.DistanceToPlane_0(returnPointer.GetPtr(), x, n, p0);
	return (double)returnPointer;
}


// double DistanceToPlane(double x[3])
// "double DistanceToPlane(double x[3])"
public double DistanceToPlane(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkPlane.DistanceToPlane_1(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// static int IntersectWithLine(double p1[3], double p2[3], double n[3], double p0[3], double & t, double x[3])
// "static int IntersectWithLine(double p1[3], double p2[3], double n[3], double p0[3], double& t, double x[3])"
public static int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double[3])*/ []n, double /*(double[3])*/ []p0, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPlane.IntersectWithLine_0(returnPointer.GetPtr(), p1, p2, n, p0, t, x);
	return (int)returnPointer;
}


// int IntersectWithLine(double p1[3], double p2[3], double & t, double x[3])
// "int IntersectWithLine(double p1[3], double p2[3], double& t, double x[3])"
public int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPlane.IntersectWithLine_1(returnPointer.GetPtr(), this, p1, p2, t, x);
	return (int)returnPointer;
}


}
};
