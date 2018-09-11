

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkMatrix4x4 : vtkObject {
		public vtkMatrix4x4(IntPtr p) : base(p) {}
		public static implicit operator  vtkMatrix4x4(IntPtr p) {return new vtkMatrix4x4(p);}
		public static implicit operator  IntPtr(vtkMatrix4x4 o) {return o.GetPtr();}

// static vtkMatrix4x4* New()
// "static vtkMatrix4x4 *New()"
public static vtkMatrix4x4 New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.New_0(returnPointer.GetPtr());
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkMatrix4x4.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkMatrix4x4.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkMatrix4x4* SafeDownCast(vtkObjectBase * o)
// "static vtkMatrix4x4* SafeDownCast(vtkObjectBase *o)"
public static vtkMatrix4x4 SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// vtkMatrix4x4* NewInstance()
// "vtkMatrix4x4 *NewInstance()"
public vtkMatrix4x4 NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// void DeepCopy(const vtkMatrix4x4 * source)
// "void DeepCopy(const vtkMatrix4x4 *source)"
public void DeepCopy(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ source) {
	VTK_API.API_vtkMatrix4x4.DeepCopy_0(this, source);
}


// static void DeepCopy(double destination[16], const vtkMatrix4x4 * source)
// "static void DeepCopy(double destination[16], const vtkMatrix4x4 *source)"
public static void DeepCopy(double /*(double[16])*/ []destination, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ source) {
	VTK_API.API_vtkMatrix4x4.DeepCopy_1(destination, source);
}


// static void DeepCopy(double destination[16], const double source[16])
// "static void DeepCopy(double destination[16], const double source[16])"
public static void DeepCopy(double /*(double[16])*/ []destination, double /*(double[16])*/ []source) {
	VTK_API.API_vtkMatrix4x4.DeepCopy_2(destination, source);
}


// void DeepCopy(const double elements[16])
// "void DeepCopy(const double elements[16])"
public void DeepCopy(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkMatrix4x4.DeepCopy_3(this, elements);
}


// void Zero()
// "void Zero()"
public void Zero() {
	VTK_API.API_vtkMatrix4x4.Zero_0(this);
}


// static void Zero(double elements[16])
// "static void Zero(double elements[16])"
public static void Zero(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkMatrix4x4.Zero_1(elements);
}


// void Identity()
// "void Identity()"
public void Identity() {
	VTK_API.API_vtkMatrix4x4.Identity_0(this);
}


// static void Identity(double elements[16])
// "static void Identity(double elements[16])"
public static void Identity(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkMatrix4x4.Identity_1(elements);
}


// static void Invert(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// "static void Invert(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)"
public static void Invert(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ in_var, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ out_var) {
	VTK_API.API_vtkMatrix4x4.Invert_0(in_var, out_var);
}


// void Invert()
// "void Invert()"
public void Invert() {
	VTK_API.API_vtkMatrix4x4.Invert_1(this);
}


// static void Invert(const double inElements[16], double outElements[16])
// "static void Invert(const double inElements[16], double outElements[16])"
public static void Invert(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements) {
	VTK_API.API_vtkMatrix4x4.Invert_2(inElements, outElements);
}


// static void Transpose(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// "static void Transpose(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)"
public static void Transpose(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ in_var, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ out_var) {
	VTK_API.API_vtkMatrix4x4.Transpose_0(in_var, out_var);
}


// void Transpose()
// "void Transpose()"
public void Transpose() {
	VTK_API.API_vtkMatrix4x4.Transpose_1(this);
}


// static void Transpose(const double inElements[16], double outElements[16])
// "static void Transpose(const double inElements[16], double outElements[16])"
public static void Transpose(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements) {
	VTK_API.API_vtkMatrix4x4.Transpose_2(inElements, outElements);
}


// void MultiplyPoint(const float in[4], float out[4])
// "void MultiplyPoint(const float in[4], float out[4])"
public void MultiplyPoint(float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var) {
	VTK_API.API_vtkMatrix4x4.MultiplyPoint_0(this, in_var, out_var);
}


// void MultiplyPoint(const double in[4], double out[4])
// "void MultiplyPoint(const double in[4], double out[4])"
public void MultiplyPoint(double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var) {
	VTK_API.API_vtkMatrix4x4.MultiplyPoint_1(this, in_var, out_var);
}


// static void MultiplyPoint(const double elements[16], const float in[4], float out[4])
// "static void MultiplyPoint(const double elements[16], const float in[4], float out[4])"
public static void MultiplyPoint(double /*(double[16])*/ []elements, float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var) {
	VTK_API.API_vtkMatrix4x4.MultiplyPoint_2(elements, in_var, out_var);
}


// static void MultiplyPoint(const double elements[16], const double in[4], double out[4])
// "static void MultiplyPoint(const double elements[16], const double in[4], double out[4])"
public static void MultiplyPoint(double /*(double[16])*/ []elements, double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var) {
	VTK_API.API_vtkMatrix4x4.MultiplyPoint_3(elements, in_var, out_var);
}


// float* MultiplyPoint(const float in[4])
// "float *MultiplyPoint(const float in[4])"
public IntPtr MultiplyPoint(float /*(float[4])*/ []in_var) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.MultiplyPoint_4(returnPointer.GetPtr(), this, in_var);
	return (IntPtr)returnPointer;
}


// float* MultiplyFloatPoint(const float in[4])
// "float *MultiplyFloatPoint(const float in[4])"
public IntPtr MultiplyFloatPoint(float /*(float[4])*/ []in_var) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.MultiplyFloatPoint_0(returnPointer.GetPtr(), this, in_var);
	return (IntPtr)returnPointer;
}


// double* MultiplyDoublePoint(const double in[4])
// "double *MultiplyDoublePoint(const double in[4])"
public IntPtr MultiplyDoublePoint(double /*(double[4])*/ []in_var) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.MultiplyDoublePoint_0(returnPointer.GetPtr(), this, in_var);
	return (IntPtr)returnPointer;
}


// static void Multiply4x4(const vtkMatrix4x4 * a, const vtkMatrix4x4 * b, vtkMatrix4x4 * c)
// "static void Multiply4x4(const vtkMatrix4x4 *a, const vtkMatrix4x4 *b, vtkMatrix4x4 *c)"
public static void Multiply4x4(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ a, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ b, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ c) {
	VTK_API.API_vtkMatrix4x4.Multiply4x4_0(a, b, c);
}


// static void Multiply4x4(const double a[16], const double b[16], double c[16])
// "static void Multiply4x4(const double a[16], const double b[16], double c[16])"
public static void Multiply4x4(double /*(double[16])*/ []a, double /*(double[16])*/ []b, double /*(double[16])*/ []c) {
	VTK_API.API_vtkMatrix4x4.Multiply4x4_1(a, b, c);
}


// void Adjoint(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// "void Adjoint(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)"
public void Adjoint(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ in_var, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ out_var) {
	VTK_API.API_vtkMatrix4x4.Adjoint_0(this, in_var, out_var);
}


// static void Adjoint(const double inElements[16], double outElements[16])
// "static void Adjoint(const double inElements[16], double outElements[16])"
public static void Adjoint(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements) {
	VTK_API.API_vtkMatrix4x4.Adjoint_1(inElements, outElements);
}


// double Determinant()
// "double Determinant()"
public double Determinant() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkMatrix4x4.Determinant_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// static double Determinant(const double elements[16])
// "static double Determinant(const double elements[16])"
public static double Determinant(double /*(double[16])*/ []elements) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkMatrix4x4.Determinant_1(returnPointer.GetPtr(), elements);
	return (double)returnPointer;
}


// void SetElement(int i, int j, double value)
// "void SetElement(int i, int j, double value)"
public void SetElement(int /*(int)*/ i, int /*(int)*/ j, double /*(double)*/ value) {
	VTK_API.API_vtkMatrix4x4.SetElement_0(this, i, j, value);
}


// double GetElement(int i, int j)
// "double GetElement(int i, int j)"
public double GetElement(int /*(int)*/ i, int /*(int)*/ j) {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkMatrix4x4.GetElement_0(returnPointer.GetPtr(), this, i, j);
	return (double)returnPointer;
}


// double* GetData()
// "double *GetData()"
public IntPtr GetData() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkMatrix4x4.GetData_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


}
};
