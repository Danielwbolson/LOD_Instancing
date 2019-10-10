

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPerspectiveTransform : vtkHomogeneousTransform {
		public vtkPerspectiveTransform(IntPtr p) : base(p) {}
		public static implicit operator  vtkPerspectiveTransform(IntPtr p) {return new vtkPerspectiveTransform(p);}
		public static implicit operator  IntPtr(vtkPerspectiveTransform o) {return o.GetPtr();}

// static vtkPerspectiveTransform* New()
// "static vtkPerspectiveTransform *New()"
public static vtkPerspectiveTransform New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.New_0(returnPointer.GetPtr());
	return (vtkPerspectiveTransform)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPerspectiveTransform.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkPerspectiveTransform.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkPerspectiveTransform* SafeDownCast(vtkObjectBase * o)
// "static vtkPerspectiveTransform* SafeDownCast(vtkObjectBase *o)"
public static vtkPerspectiveTransform SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkPerspectiveTransform)(IntPtr)returnPointer;
}


// vtkPerspectiveTransform* NewInstance()
// "vtkPerspectiveTransform *NewInstance()"
public vtkPerspectiveTransform NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkPerspectiveTransform)(IntPtr)returnPointer;
}


// void Identity()
// "void Identity()"
public void Identity() {
	VTK_API.API_vtkPerspectiveTransform.Identity_0(this);
}


// void Inverse()
// "void Inverse()"
public void Inverse() {
	VTK_API.API_vtkPerspectiveTransform.Inverse_0(this);
}


// void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
// "void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)"
public void AdjustViewport(double /*(double)*/ oldXMin, double /*(double)*/ oldXMax, double /*(double)*/ oldYMin, double /*(double)*/ oldYMax, double /*(double)*/ newXMin, double /*(double)*/ newXMax, double /*(double)*/ newYMin, double /*(double)*/ newYMax) {
	VTK_API.API_vtkPerspectiveTransform.AdjustViewport_0(this, oldXMin, oldXMax, oldYMin, oldYMax, newXMin, newXMax, newYMin, newYMax);
}


// void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
// "void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)"
public void AdjustZBuffer(double /*(double)*/ oldNearZ, double /*(double)*/ oldFarZ, double /*(double)*/ newNearZ, double /*(double)*/ newFarZ) {
	VTK_API.API_vtkPerspectiveTransform.AdjustZBuffer_0(this, oldNearZ, oldFarZ, newNearZ, newFarZ);
}


// void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
// "void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)"
public void Ortho(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ znear, double /*(double)*/ zfar) {
	VTK_API.API_vtkPerspectiveTransform.Ortho_0(this, xmin, xmax, ymin, ymax, znear, zfar);
}


// void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
// "void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)"
public void Frustum(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ znear, double /*(double)*/ zfar) {
	VTK_API.API_vtkPerspectiveTransform.Frustum_0(this, xmin, xmax, ymin, ymax, znear, zfar);
}


// void Perspective(double angle, double aspect, double znear, double zfar)
// "void Perspective(double angle, double aspect, double znear, double zfar)"
public void Perspective(double /*(double)*/ angle, double /*(double)*/ aspect, double /*(double)*/ znear, double /*(double)*/ zfar) {
	VTK_API.API_vtkPerspectiveTransform.Perspective_0(this, angle, aspect, znear, zfar);
}


// void Shear(double dxdz, double dydz, double zplane)
// "void Shear(double dxdz, double dydz, double zplane)"
public void Shear(double /*(double)*/ dxdz, double /*(double)*/ dydz, double /*(double)*/ zplane) {
	VTK_API.API_vtkPerspectiveTransform.Shear_0(this, dxdz, dydz, zplane);
}


// void Stereo(double angle, double focaldistance)
// "void Stereo(double angle, double focaldistance)"
public void Stereo(double /*(double)*/ angle, double /*(double)*/ focaldistance) {
	VTK_API.API_vtkPerspectiveTransform.Stereo_0(this, angle, focaldistance);
}


// void SetupCamera(const double position[3], const double focalpoint[3], const double viewup[3])
// "void SetupCamera(const double position[3], const double focalpoint[3], const double viewup[3])"
public void SetupCamera(double /*(double[3])*/ []position, double /*(double[3])*/ []focalpoint, double /*(double[3])*/ []viewup) {
	VTK_API.API_vtkPerspectiveTransform.SetupCamera_0(this, position, focalpoint, viewup);
}


// void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
// "void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)"
public void SetupCamera(double /*(double)*/ p0, double /*(double)*/ p1, double /*(double)*/ p2, double /*(double)*/ fp0, double /*(double)*/ fp1, double /*(double)*/ fp2, double /*(double)*/ vup0, double /*(double)*/ vup1, double /*(double)*/ vup2) {
	VTK_API.API_vtkPerspectiveTransform.SetupCamera_1(this, p0, p1, p2, fp0, fp1, fp2, vup0, vup1, vup2);
}


// void Translate(double x, double y, double z)
// "void Translate(double x, double y, double z)"
public void Translate(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkPerspectiveTransform.Translate_0(this, x, y, z);
}


// void Translate(const double x[3])
// "void Translate(const double x[3])"
public void Translate(double /*(double[3])*/ []x) {
	VTK_API.API_vtkPerspectiveTransform.Translate_1(this, x);
}


// void Translate(const float x[3])
// "void Translate(const float x[3])"
public void Translate(float /*(float[3])*/ []x) {
	VTK_API.API_vtkPerspectiveTransform.Translate_2(this, x);
}


// void RotateWXYZ(double angle, double x, double y, double z)
// "void RotateWXYZ(double angle, double x, double y, double z)"
public void RotateWXYZ(double /*(double)*/ angle, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkPerspectiveTransform.RotateWXYZ_0(this, angle, x, y, z);
}


// void RotateWXYZ(double angle, const double axis[3])
// "void RotateWXYZ(double angle, const double axis[3])"
public void RotateWXYZ(double /*(double)*/ angle, double /*(double[3])*/ []axis) {
	VTK_API.API_vtkPerspectiveTransform.RotateWXYZ_1(this, angle, axis);
}


// void RotateWXYZ(double angle, const float axis[3])
// "void RotateWXYZ(double angle, const float axis[3])"
public void RotateWXYZ(double /*(double)*/ angle, float /*(float[3])*/ []axis) {
	VTK_API.API_vtkPerspectiveTransform.RotateWXYZ_2(this, angle, axis);
}


// void RotateX(double angle)
// "void RotateX(double angle)"
public void RotateX(double /*(double)*/ angle) {
	VTK_API.API_vtkPerspectiveTransform.RotateX_0(this, angle);
}


// void RotateY(double angle)
// "void RotateY(double angle)"
public void RotateY(double /*(double)*/ angle) {
	VTK_API.API_vtkPerspectiveTransform.RotateY_0(this, angle);
}


// void RotateZ(double angle)
// "void RotateZ(double angle)"
public void RotateZ(double /*(double)*/ angle) {
	VTK_API.API_vtkPerspectiveTransform.RotateZ_0(this, angle);
}


// void Scale(double x, double y, double z)
// "void Scale(double x, double y, double z)"
public void Scale(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkPerspectiveTransform.Scale_0(this, x, y, z);
}


// void Scale(const double s[3])
// "void Scale(const double s[3])"
public void Scale(double /*(double[3])*/ []s) {
	VTK_API.API_vtkPerspectiveTransform.Scale_1(this, s);
}


// void Scale(const float s[3])
// "void Scale(const float s[3])"
public void Scale(float /*(float[3])*/ []s) {
	VTK_API.API_vtkPerspectiveTransform.Scale_2(this, s);
}


// void SetMatrix(vtkMatrix4x4 * matrix)
// "void SetMatrix(vtkMatrix4x4 *matrix)"
public void SetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkPerspectiveTransform.SetMatrix_0(this, matrix);
}


// void SetMatrix(const double elements[16])
// "void SetMatrix(const double elements[16])"
public void SetMatrix(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkPerspectiveTransform.SetMatrix_1(this, elements);
}


// void Concatenate(vtkMatrix4x4 * matrix)
// "void Concatenate(vtkMatrix4x4 *matrix)"
public void Concatenate(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkPerspectiveTransform.Concatenate_0(this, matrix);
}


// void Concatenate(const double elements[16])
// "void Concatenate(const double elements[16])"
public void Concatenate(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkPerspectiveTransform.Concatenate_1(this, elements);
}


// void Concatenate(vtkHomogeneousTransform * transform)
// "void Concatenate(vtkHomogeneousTransform *transform)"
public void Concatenate(vtkHomogeneousTransform /*(vtkHomogeneousTransform*)*/ transform) {
	VTK_API.API_vtkPerspectiveTransform.Concatenate_2(this, transform);
}


// void PreMultiply()
// "void PreMultiply()"
public void PreMultiply() {
	VTK_API.API_vtkPerspectiveTransform.PreMultiply_0(this);
}


// void PostMultiply()
// "void PostMultiply()"
public void PostMultiply() {
	VTK_API.API_vtkPerspectiveTransform.PostMultiply_0(this);
}


// int GetNumberOfConcatenatedTransforms()
// "int GetNumberOfConcatenatedTransforms()"
public int GetNumberOfConcatenatedTransforms() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPerspectiveTransform.GetNumberOfConcatenatedTransforms_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// vtkHomogeneousTransform* GetConcatenatedTransform(int i)
// "vtkHomogeneousTransform *GetConcatenatedTransform(int i)"
public vtkHomogeneousTransform GetConcatenatedTransform(int /*(int)*/ i) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.GetConcatenatedTransform_0(returnPointer.GetPtr(), this, i);
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// void SetInput(vtkHomogeneousTransform * input)
// "void SetInput(vtkHomogeneousTransform *input)"
public void SetInput(vtkHomogeneousTransform /*(vtkHomogeneousTransform*)*/ input) {
	VTK_API.API_vtkPerspectiveTransform.SetInput_0(this, input);
}


// vtkHomogeneousTransform* GetInput()
// "vtkHomogeneousTransform *GetInput()"
public vtkHomogeneousTransform GetInput() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.GetInput_0(returnPointer.GetPtr(), this);
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// int GetInverseFlag()
// "int GetInverseFlag()"
public int GetInverseFlag() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPerspectiveTransform.GetInverseFlag_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Push()
// "void Push()"
public void Push() {
	VTK_API.API_vtkPerspectiveTransform.Push_0(this);
}


// void Pop()
// "void Pop()"
public void Pop() {
	VTK_API.API_vtkPerspectiveTransform.Pop_0(this);
}


// vtkAbstractTransform* MakeTransform()
// "vtkAbstractTransform *MakeTransform()"
public vtkAbstractTransform MakeTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkPerspectiveTransform.MakeTransform_0(returnPointer.GetPtr(), this);
	return (vtkAbstractTransform)(IntPtr)returnPointer;
}


// int CircuitCheck(vtkAbstractTransform * transform)
// "int CircuitCheck(vtkAbstractTransform *transform)"
public int CircuitCheck(vtkAbstractTransform /*(vtkAbstractTransform*)*/ transform) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkPerspectiveTransform.CircuitCheck_0(returnPointer.GetPtr(), this, transform);
	return (int)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkPerspectiveTransform.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


}
};
