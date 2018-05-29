

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTransform : vtkLinearTransform {
		public vtkTransform(IntPtr p) : base(p) {}
		public static implicit operator  vtkTransform(IntPtr p) {return new vtkTransform(p);}
		public static implicit operator  IntPtr(vtkTransform o) {return o.GetPtr();}

// static vtkTransform* New()
// "static vtkTransform *New()"
public static vtkTransform New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.New_0(returnPointer.GetPtr());
	return (vtkTransform)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTransform.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkTransform.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkTransform* SafeDownCast(vtkObjectBase * o)
// "static vtkTransform* SafeDownCast(vtkObjectBase *o)"
public static vtkTransform SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkTransform)(IntPtr)returnPointer;
}


// vtkTransform* NewInstance()
// "vtkTransform *NewInstance()"
public vtkTransform NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkTransform)(IntPtr)returnPointer;
}


// void Identity()
// "void Identity()"
public void Identity() {
	VTK_API.API_vtkTransform.Identity_0(this);
}


// void Inverse()
// "void Inverse()"
public void Inverse() {
	VTK_API.API_vtkTransform.Inverse_0(this);
}


// void Translate(double x, double y, double z)
// "void Translate(double x, double y, double z)"
public void Translate(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkTransform.Translate_0(this, x, y, z);
}


// void Translate(const double x[3])
// "void Translate(const double x[3])"
public void Translate(double /*(double[3])*/ []x) {
	VTK_API.API_vtkTransform.Translate_1(this, x);
}


// void Translate(const float x[3])
// "void Translate(const float x[3])"
public void Translate(float /*(float[3])*/ []x) {
	VTK_API.API_vtkTransform.Translate_2(this, x);
}


// void RotateWXYZ(double angle, double x, double y, double z)
// "void RotateWXYZ(double angle, double x, double y, double z)"
public void RotateWXYZ(double /*(double)*/ angle, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkTransform.RotateWXYZ_0(this, angle, x, y, z);
}


// void RotateWXYZ(double angle, const double axis[3])
// "void RotateWXYZ(double angle, const double axis[3])"
public void RotateWXYZ(double /*(double)*/ angle, double /*(double[3])*/ []axis) {
	VTK_API.API_vtkTransform.RotateWXYZ_1(this, angle, axis);
}


// void RotateWXYZ(double angle, const float axis[3])
// "void RotateWXYZ(double angle, const float axis[3])"
public void RotateWXYZ(double /*(double)*/ angle, float /*(float[3])*/ []axis) {
	VTK_API.API_vtkTransform.RotateWXYZ_2(this, angle, axis);
}


// void RotateX(double angle)
// "void RotateX(double angle)"
public void RotateX(double /*(double)*/ angle) {
	VTK_API.API_vtkTransform.RotateX_0(this, angle);
}


// void RotateY(double angle)
// "void RotateY(double angle)"
public void RotateY(double /*(double)*/ angle) {
	VTK_API.API_vtkTransform.RotateY_0(this, angle);
}


// void RotateZ(double angle)
// "void RotateZ(double angle)"
public void RotateZ(double /*(double)*/ angle) {
	VTK_API.API_vtkTransform.RotateZ_0(this, angle);
}


// void Scale(double x, double y, double z)
// "void Scale(double x, double y, double z)"
public void Scale(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkTransform.Scale_0(this, x, y, z);
}


// void Scale(const double s[3])
// "void Scale(const double s[3])"
public void Scale(double /*(double[3])*/ []s) {
	VTK_API.API_vtkTransform.Scale_1(this, s);
}


// void Scale(const float s[3])
// "void Scale(const float s[3])"
public void Scale(float /*(float[3])*/ []s) {
	VTK_API.API_vtkTransform.Scale_2(this, s);
}


// void SetMatrix(vtkMatrix4x4 * matrix)
// "void SetMatrix(vtkMatrix4x4 *matrix)"
public void SetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkTransform.SetMatrix_0(this, matrix);
}


// void SetMatrix(const double elements[16])
// "void SetMatrix(const double elements[16])"
public void SetMatrix(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkTransform.SetMatrix_1(this, elements);
}


// void Concatenate(vtkMatrix4x4 * matrix)
// "void Concatenate(vtkMatrix4x4 *matrix)"
public void Concatenate(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkTransform.Concatenate_0(this, matrix);
}


// void Concatenate(const double elements[16])
// "void Concatenate(const double elements[16])"
public void Concatenate(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkTransform.Concatenate_1(this, elements);
}


// void Concatenate(vtkLinearTransform * transform)
// "void Concatenate(vtkLinearTransform *transform)"
public void Concatenate(vtkLinearTransform /*(vtkLinearTransform*)*/ transform) {
	VTK_API.API_vtkTransform.Concatenate_2(this, transform);
}


// void PreMultiply()
// "void PreMultiply()"
public void PreMultiply() {
	VTK_API.API_vtkTransform.PreMultiply_0(this);
}


// void PostMultiply()
// "void PostMultiply()"
public void PostMultiply() {
	VTK_API.API_vtkTransform.PostMultiply_0(this);
}


// int GetNumberOfConcatenatedTransforms()
// "int GetNumberOfConcatenatedTransforms()"
public int GetNumberOfConcatenatedTransforms() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTransform.GetNumberOfConcatenatedTransforms_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkLinearTransform* GetConcatenatedTransform(int i)
// "vtkLinearTransform *GetConcatenatedTransform(int i)"
public vtkLinearTransform GetConcatenatedTransform(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetConcatenatedTransform_0(returnPointer.GetPtr(), this, i);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// void GetOrientation(double orient[3])
// "void GetOrientation(double orient[3])"
public void GetOrientation(double /*(double[3])*/ []orient) {
	VTK_API.API_vtkTransform.GetOrientation_0(this, orient);
}


// void GetOrientation(float orient[3])
// "void GetOrientation(float orient[3])"
public void GetOrientation(float /*(float[3])*/ []orient) {
	VTK_API.API_vtkTransform.GetOrientation_1(this, orient);
}


// double* GetOrientation()
// "double *GetOrientation()"
public IntPtr GetOrientation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetOrientation_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// static void GetOrientation(double orient[3], vtkMatrix4x4 * matrix)
// "static void GetOrientation(double orient[3], vtkMatrix4x4 *matrix)"
public static void GetOrientation(double /*(double[3])*/ []orient, vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkTransform.GetOrientation_3(orient, matrix);
}


// void GetOrientationWXYZ(double wxyz[4])
// "void GetOrientationWXYZ(double wxyz[4])"
public void GetOrientationWXYZ(double /*(double[4])*/ []wxyz) {
	VTK_API.API_vtkTransform.GetOrientationWXYZ_0(this, wxyz);
}


// void GetOrientationWXYZ(float wxyz[4])
// "void GetOrientationWXYZ(float wxyz[4])"
public void GetOrientationWXYZ(float /*(float[4])*/ []wxyz) {
	VTK_API.API_vtkTransform.GetOrientationWXYZ_1(this, wxyz);
}


// double* GetOrientationWXYZ()
// "double *GetOrientationWXYZ()"
public IntPtr GetOrientationWXYZ() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetOrientationWXYZ_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetPosition(double pos[3])
// "void GetPosition(double pos[3])"
public void GetPosition(double /*(double[3])*/ []pos) {
	VTK_API.API_vtkTransform.GetPosition_0(this, pos);
}


// void GetPosition(float pos[3])
// "void GetPosition(float pos[3])"
public void GetPosition(float /*(float[3])*/ []pos) {
	VTK_API.API_vtkTransform.GetPosition_1(this, pos);
}


// double* GetPosition()
// "double *GetPosition()"
public IntPtr GetPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetPosition_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetScale(double scale[3])
// "void GetScale(double scale[3])"
public void GetScale(double /*(double[3])*/ []scale) {
	VTK_API.API_vtkTransform.GetScale_0(this, scale);
}


// void GetScale(float scale[3])
// "void GetScale(float scale[3])"
public void GetScale(float /*(float[3])*/ []scale) {
	VTK_API.API_vtkTransform.GetScale_1(this, scale);
}


// double* GetScale()
// "double *GetScale()"
public IntPtr GetScale() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetScale_2(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetInverse(vtkMatrix4x4 * inverse)
// "void GetInverse(vtkMatrix4x4 *inverse)"
public void GetInverse(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ inverse) {
	VTK_API.API_vtkTransform.GetInverse_0(this, inverse);
}


// void GetTranspose(vtkMatrix4x4 * transpose)
// "void GetTranspose(vtkMatrix4x4 *transpose)"
public void GetTranspose(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ transpose) {
	VTK_API.API_vtkTransform.GetTranspose_0(this, transpose);
}


// void SetInput(vtkLinearTransform * input)
// "void SetInput(vtkLinearTransform *input)"
public void SetInput(vtkLinearTransform /*(vtkLinearTransform*)*/ input) {
	VTK_API.API_vtkTransform.SetInput_0(this, input);
}


// vtkLinearTransform* GetInput()
// "vtkLinearTransform *GetInput()"
public vtkLinearTransform GetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetInput_0(returnPointer.GetPtr(), this);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// int GetInverseFlag()
// "int GetInverseFlag()"
public int GetInverseFlag() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTransform.GetInverseFlag_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Push()
// "void Push()"
public void Push() {
	VTK_API.API_vtkTransform.Push_0(this);
}


// void Pop()
// "void Pop()"
public void Pop() {
	VTK_API.API_vtkTransform.Pop_0(this);
}


// int CircuitCheck(vtkAbstractTransform * transform)
// "int CircuitCheck(vtkAbstractTransform *transform)"
public int CircuitCheck(vtkAbstractTransform /*(vtkAbstractTransform*)*/ transform) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkTransform.CircuitCheck_0(returnPointer.GetPtr(), this, transform);
	return (int)returnPointer;
}


// vtkAbstractTransform* GetInverse()
// "vtkAbstractTransform *GetInverse()"
public vtkAbstractTransform GetInverse() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.GetInverse_1(returnPointer.GetPtr(), this);
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// vtkAbstractTransform* MakeTransform()
// "vtkAbstractTransform *MakeTransform()"
public vtkAbstractTransform MakeTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkTransform.MakeTransform_0(returnPointer.GetPtr(), this);
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkTransform.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// void MultiplyPoint(const float in[4], float out[4])
// "void MultiplyPoint(const float in[4], float out[4])"
public void MultiplyPoint(float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var) {
	VTK_API.API_vtkTransform.MultiplyPoint_0(this, in_var, out_var);
}


// void MultiplyPoint(const double in[4], double out[4])
// "void MultiplyPoint(const double in[4], double out[4])"
public void MultiplyPoint(double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var) {
	VTK_API.API_vtkTransform.MultiplyPoint_1(this, in_var, out_var);
}


}
};
