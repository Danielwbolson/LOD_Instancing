

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkHomogeneousTransform : vtkAbstractTransform {
		public vtkHomogeneousTransform(IntPtr p) : base(p) {}
		public static implicit operator  vtkHomogeneousTransform(IntPtr p) {return new vtkHomogeneousTransform(p);}
		public static implicit operator  IntPtr(vtkHomogeneousTransform o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkHomogeneousTransform.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkHomogeneousTransform.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkHomogeneousTransform* SafeDownCast(vtkObjectBase * o)
// "static vtkHomogeneousTransform* SafeDownCast(vtkObjectBase *o)"
public static vtkHomogeneousTransform SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkHomogeneousTransform.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// vtkHomogeneousTransform* NewInstance()
// "vtkHomogeneousTransform *NewInstance()"
public vtkHomogeneousTransform NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkHomogeneousTransform.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// "void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)"
public void TransformPoints(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts) {
	VTK_API.API_vtkHomogeneousTransform.TransformPoints_0(this, inPts, outPts);
}


// void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs)
// "void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs)"
public void TransformPointsNormalsVectors(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts, vtkDataArray /*(vtkDataArray*)*/ inNms, vtkDataArray /*(vtkDataArray*)*/ outNms, vtkDataArray /*(vtkDataArray*)*/ inVrs, vtkDataArray /*(vtkDataArray*)*/ outVrs) {
	VTK_API.API_vtkHomogeneousTransform.TransformPointsNormalsVectors_0(this, inPts, outPts, inNms, outNms, inVrs, outVrs);
}


// void GetMatrix(vtkMatrix4x4 * m)
// "void GetMatrix(vtkMatrix4x4 *m)"
public void GetMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ m) {
	VTK_API.API_vtkHomogeneousTransform.GetMatrix_0(this, m);
}


// vtkMatrix4x4* GetMatrix()
// "vtkMatrix4x4 *GetMatrix()"
public vtkMatrix4x4 GetMatrix() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkHomogeneousTransform.GetMatrix_1(returnPointer.GetPtr(), this);
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// vtkHomogeneousTransform* GetHomogeneousInverse()
// "vtkHomogeneousTransform *GetHomogeneousInverse()"
public vtkHomogeneousTransform GetHomogeneousInverse() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkHomogeneousTransform.GetHomogeneousInverse_0(returnPointer.GetPtr(), this);
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// void InternalTransformPoint(const float in[3], float out[3])
// "void InternalTransformPoint(const float in[3], float out[3])"
public void InternalTransformPoint(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkHomogeneousTransform.InternalTransformPoint_0(this, in_var, out_var);
}


// void InternalTransformPoint(const double in[3], double out[3])
// "void InternalTransformPoint(const double in[3], double out[3])"
public void InternalTransformPoint(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkHomogeneousTransform.InternalTransformPoint_1(this, in_var, out_var);
}


}
};
