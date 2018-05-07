

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProp3D : vtkProp {
		public vtkProp3D(IntPtr p) : base(p) {}
		public static implicit operator  vtkProp3D(IntPtr p) {return new vtkProp3D(p);}
		public static implicit operator  IntPtr(vtkProp3D o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp3D.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkProp3D.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkProp3D* SafeDownCast(vtkObjectBase * o)
// "static vtkProp3D* SafeDownCast(vtkObjectBase *o)"
public static vtkProp3D SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkProp3D)(IntPtr)returnPointer;
}


// vtkProp3D* NewInstance()
// "vtkProp3D *NewInstance()"
public vtkProp3D NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkProp3D)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkProp * prop)
// "void ShallowCopy(vtkProp *prop)"
public void ShallowCopy(vtkProp /*(vtkProp*)*/ prop) {
	VTK_API.API_vtkProp3D.ShallowCopy_0(this, prop);
}


// virtual void SetPosition(double x, double y, double z)
// "virtual void SetPosition(double x, double y, double z)"
public void SetPosition(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.SetPosition_0(this, x, y, z);
}


// virtual void SetPosition(double pos[3])
// "virtual void SetPosition(double pos[3])"
public void SetPosition(double /*(double[3])*/ []pos) {
	VTK_API.API_vtkProp3D.SetPosition_1(this, pos);
}


// virtual double* GetPosition()
// "virtual double *GetPosition ()"
public IntPtr GetPosition() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetPosition_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetPosition(double data[3])
// "virtual void GetPosition (double data[3])"
public void GetPosition(double /*(double[3])*/ []data) {
	VTK_API.API_vtkProp3D.GetPosition_1(this, data);
}


// void AddPosition(double deltaPosition[3])
// "void AddPosition(double deltaPosition[3])"
public void AddPosition(double /*(double[3])*/ []deltaPosition) {
	VTK_API.API_vtkProp3D.AddPosition_0(this, deltaPosition);
}


// void AddPosition(double deltaX, double deltaY, double deltaZ)
// "void AddPosition(double deltaX, double deltaY, double deltaZ)"
public void AddPosition(double /*(double)*/ deltaX, double /*(double)*/ deltaY, double /*(double)*/ deltaZ) {
	VTK_API.API_vtkProp3D.AddPosition_1(this, deltaX, deltaY, deltaZ);
}


// virtual void SetOrigin(double x, double y, double z)
// "virtual void SetOrigin(double x, double y, double z)"
public void SetOrigin(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.SetOrigin_0(this, x, y, z);
}


// virtual void SetOrigin(const double pos[3])
// "virtual void SetOrigin(const double pos[3])"
public void SetOrigin(double /*(double[3])*/ []pos) {
	VTK_API.API_vtkProp3D.SetOrigin_1(this, pos);
}


// virtual double* GetOrigin()
// "virtual double *GetOrigin ()"
public IntPtr GetOrigin() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetOrigin_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetOrigin(double data[3])
// "virtual void GetOrigin (double data[3])"
public void GetOrigin(double /*(double[3])*/ []data) {
	VTK_API.API_vtkProp3D.GetOrigin_1(this, data);
}


// virtual void SetScale(double x, double y, double z)
// "virtual void SetScale(double x, double y, double z)"
public void SetScale(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.SetScale_0(this, x, y, z);
}


// virtual void SetScale(double scale[3])
// "virtual void SetScale(double scale[3])"
public void SetScale(double /*(double[3])*/ []scale) {
	VTK_API.API_vtkProp3D.SetScale_1(this, scale);
}


// virtual double* GetScale()
// "virtual double *GetScale ()"
public IntPtr GetScale() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetScale_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetScale(double data[3])
// "virtual void GetScale (double data[3])"
public void GetScale(double /*(double[3])*/ []data) {
	VTK_API.API_vtkProp3D.GetScale_1(this, data);
}


// void SetScale(double s)
// "void SetScale(double s)"
public void SetScale(double /*(double)*/ s) {
	VTK_API.API_vtkProp3D.SetScale_2(this, s);
}


// void SetUserTransform(vtkLinearTransform * transform)
// "void SetUserTransform(vtkLinearTransform *transform)"
public void SetUserTransform(vtkLinearTransform /*(vtkLinearTransform*)*/ transform) {
	VTK_API.API_vtkProp3D.SetUserTransform_0(this, transform);
}


// virtual vtkLinearTransform* GetUserTransform()
// "virtual vtkLinearTransform *GetUserTransform ()"
public vtkLinearTransform GetUserTransform() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetUserTransform_0(returnPointer.GetPtr(), this);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// void SetUserMatrix(vtkMatrix4x4 * matrix)
// "void SetUserMatrix(vtkMatrix4x4 *matrix)"
public void SetUserMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkProp3D.SetUserMatrix_0(this, matrix);
}


// vtkMatrix4x4* GetUserMatrix()
// "vtkMatrix4x4 *GetUserMatrix()"
public vtkMatrix4x4 GetUserMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetUserMatrix_0(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual void GetMatrix(vtkMatrix4x4 * m)
// "virtual void GetMatrix(vtkMatrix4x4 *m)"
public void GetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ m) {
	VTK_API.API_vtkProp3D.GetMatrix_0(this, m);
}


// virtual void GetMatrix(double m[16])
// "virtual void GetMatrix(double m[16])"
public void GetMatrix(double /*(double[16])*/ []m) {
	VTK_API.API_vtkProp3D.GetMatrix_1(this, m);
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkProp3D.GetBounds_0(this, bounds);
}


// double* GetBounds()
// "double *GetBounds()"
public IntPtr GetBounds() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetBounds_1(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// double* GetCenter()
// "double *GetCenter()"
public IntPtr GetCenter() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetCenter_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// double* GetXRange()
// "double *GetXRange()"
public IntPtr GetXRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetXRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// double* GetYRange()
// "double *GetYRange()"
public IntPtr GetYRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetYRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// double* GetZRange()
// "double *GetZRange()"
public IntPtr GetZRange() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetZRange_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// double GetLength()
// "double GetLength()"
public double GetLength() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkProp3D.GetLength_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// void RotateX(double ARG_0)
// "void RotateX(double)"
public void RotateX(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkProp3D.RotateX_0(this, ARG_0);
}


// void RotateY(double ARG_0)
// "void RotateY(double)"
public void RotateY(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkProp3D.RotateY_0(this, ARG_0);
}


// void RotateZ(double ARG_0)
// "void RotateZ(double)"
public void RotateZ(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkProp3D.RotateZ_0(this, ARG_0);
}


// void RotateWXYZ(double w, double x, double y, double z)
// "void RotateWXYZ(double w, double x, double y, double z)"
public void RotateWXYZ(double /*(double)*/ w, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.RotateWXYZ_0(this, w, x, y, z);
}


// void SetOrientation(double x, double y, double z)
// "void SetOrientation(double x, double y, double z)"
public void SetOrientation(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.SetOrientation_0(this, x, y, z);
}


// void SetOrientation(double orientation[3])
// "void SetOrientation(double orientation[3])"
public void SetOrientation(double /*(double[3])*/ []orientation) {
	VTK_API.API_vtkProp3D.SetOrientation_1(this, orientation);
}


// double* GetOrientation()
// "double *GetOrientation()"
public IntPtr GetOrientation() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetOrientation_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void GetOrientation(double orentation[3])
// "void GetOrientation(double orentation[3])"
public void GetOrientation(double /*(double[3])*/ []orentation) {
	VTK_API.API_vtkProp3D.GetOrientation_1(this, orentation);
}


// double* GetOrientationWXYZ()
// "double *GetOrientationWXYZ()"
public IntPtr GetOrientationWXYZ() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetOrientationWXYZ_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void AddOrientation(double x, double y, double z)
// "void AddOrientation(double x, double y, double z)"
public void AddOrientation(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkProp3D.AddOrientation_0(this, x, y, z);
}


// void AddOrientation(double orentation[3])
// "void AddOrientation(double orentation[3])"
public void AddOrientation(double /*(double[3])*/ []orentation) {
	VTK_API.API_vtkProp3D.AddOrientation_1(this, orentation);
}


// void PokeMatrix(vtkMatrix4x4 * matrix)
// "void PokeMatrix(vtkMatrix4x4 *matrix)"
public void PokeMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkProp3D.PokeMatrix_0(this, matrix);
}


// void InitPathTraversal()
// "void InitPathTraversal()"
public void InitPathTraversal() {
	VTK_API.API_vtkProp3D.InitPathTraversal_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkProp3D.GetMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// vtkMTimeType GetUserTransformMatrixMTime()
// "vtkMTimeType GetUserTransformMatrixMTime()"
public ulong GetUserTransformMatrixMTime() {
	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	VTK_API.API_vtkProp3D.GetUserTransformMatrixMTime_0(returnPointer.GetPtr(), this);
	return (ulong)returnPointer;
}


// virtual void ComputeMatrix()
// "virtual void ComputeMatrix()"
public void ComputeMatrix() {
	VTK_API.API_vtkProp3D.ComputeMatrix_0(this);
}


// vtkMatrix4x4* GetMatrix()
// "vtkMatrix4x4 *GetMatrix()"
public vtkMatrix4x4 GetMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkProp3D.GetMatrix_2(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual int GetIsIdentity()
// "virtual int GetIsIdentity ()"
public int GetIsIdentity() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkProp3D.GetIsIdentity_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


}
};
