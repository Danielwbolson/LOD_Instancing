

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkImplicitFunction : vtkObject {
		public vtkImplicitFunction(IntPtr p) : base(p) {}
		public static implicit operator  vtkImplicitFunction(IntPtr p) {return new vtkImplicitFunction(p);}
		public static implicit operator  IntPtr(vtkImplicitFunction o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkImplicitFunction.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkImplicitFunction.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkImplicitFunction* SafeDownCast(vtkObjectBase * o)
// "static vtkImplicitFunction* SafeDownCast(vtkObjectBase *o)"
public static vtkImplicitFunction SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkImplicitFunction.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkImplicitFunction)(IntPtr)returnPointer;
}


// vtkImplicitFunction* NewInstance()
// "vtkImplicitFunction *NewInstance()"
public vtkImplicitFunction NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkImplicitFunction.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkImplicitFunction)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkImplicitFunction.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void FunctionValue(vtkDataArray * input, vtkDataArray * output)
// "virtual void FunctionValue(vtkDataArray* input, vtkDataArray* output)"
public void FunctionValue(vtkDataArray /*(vtkDataArray*)*/ input, vtkDataArray /*(vtkDataArray*)*/ output) {
	VTK_API.API_vtkImplicitFunction.FunctionValue_0(this, input, output);
}


// double FunctionValue(const double x[3])
// "double FunctionValue(const double x[3])"
public double FunctionValue(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkImplicitFunction.FunctionValue_1(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// double FunctionValue(double x, double y, double z)
// "double FunctionValue(double x, double y, double z)"
public double FunctionValue(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkImplicitFunction.FunctionValue_2(returnPointer.GetPtr(), this, x, y, z);
	return (double)returnPointer;
}


// void FunctionGradient(const double x[3], double g[3])
// "void FunctionGradient(const double x[3], double g[3])"
public void FunctionGradient(double /*(double[3])*/ []x, double /*(double[3])*/ []g) {
	VTK_API.API_vtkImplicitFunction.FunctionGradient_0(this, x, g);
}


// double* FunctionGradient(const double x[3])
// "double *FunctionGradient(const double x[3])"
public IntPtr FunctionGradient(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkImplicitFunction.FunctionGradient_1(returnPointer.GetPtr(), this, x);
	return (IntPtr)returnPointer;
}


// double* FunctionGradient(double x, double y, double z)
// "double *FunctionGradient(double x, double y, double z)"
public IntPtr FunctionGradient(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkImplicitFunction.FunctionGradient_2(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// virtual void SetTransform(vtkAbstractTransform * ARG_0)
// "virtual void SetTransform(vtkAbstractTransform*)"
public void SetTransform(vtkAbstractTransform /*(vtkAbstractTransform*)*/ ARG_0) {
	VTK_API.API_vtkImplicitFunction.SetTransform_0(this, ARG_0);
}


// virtual void SetTransform(const double elements[16])
// "virtual void SetTransform(const double elements[16])"
public void SetTransform(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkImplicitFunction.SetTransform_1(this, elements);
}


// virtual vtkAbstractTransform* GetTransform()
// "virtual vtkAbstractTransform *GetTransform ()"
public vtkAbstractTransform GetTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkImplicitFunction.GetTransform_0(returnPointer.GetPtr(), this);
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// virtual double EvaluateFunction(double x[3])
// "virtual double EvaluateFunction(double x[3])"
public double EvaluateFunction(double /*(double[3])*/ []x) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkImplicitFunction.EvaluateFunction_0(returnPointer.GetPtr(), this, x);
	return (double)returnPointer;
}


// virtual void EvaluateFunction(vtkDataArray * input, vtkDataArray * output)
// "virtual void EvaluateFunction(vtkDataArray* input, vtkDataArray* output)"
public void EvaluateFunction(vtkDataArray /*(vtkDataArray*)*/ input, vtkDataArray /*(vtkDataArray*)*/ output) {
	VTK_API.API_vtkImplicitFunction.EvaluateFunction_1(this, input, output);
}


// virtual double EvaluateFunction(double x, double y, double z)
// "virtual double EvaluateFunction(double x, double y, double z)"
public double EvaluateFunction(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkImplicitFunction.EvaluateFunction_2(returnPointer.GetPtr(), this, x, y, z);
	return (double)returnPointer;
}


// virtual void EvaluateGradient(double x[3], double g[3])
// "virtual void EvaluateGradient(double x[3], double g[3])"
public void EvaluateGradient(double /*(double[3])*/ []x, double /*(double[3])*/ []g) {
	VTK_API.API_vtkImplicitFunction.EvaluateGradient_0(this, x, g);
}


}
};
