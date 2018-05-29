

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLinearTransform : vtkHomogeneousTransform {
		public vtkLinearTransform(IntPtr p) : base(p) {}
		public static implicit operator  vtkLinearTransform(IntPtr p) {return new vtkLinearTransform(p);}
		public static implicit operator  IntPtr(vtkLinearTransform o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLinearTransform.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkLinearTransform.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkLinearTransform* SafeDownCast(vtkObjectBase * o)
// "static vtkLinearTransform* SafeDownCast(vtkObjectBase *o)"
public static vtkLinearTransform SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// vtkLinearTransform* NewInstance()
// "vtkLinearTransform *NewInstance()"
public vtkLinearTransform NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// void TransformNormal(const float in[3], float out[3])
// "void TransformNormal(const float in[3], float out[3])"
public void TransformNormal(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.TransformNormal_0(this, in_var, out_var);
}


// void TransformNormal(const double in[3], double out[3])
// "void TransformNormal(const double in[3], double out[3])"
public void TransformNormal(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.TransformNormal_1(this, in_var, out_var);
}


// double* TransformNormal(double x, double y, double z)
// "double *TransformNormal(double x, double y, double z)"
public IntPtr TransformNormal(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformNormal_2(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// double* TransformNormal(const double normal[3])
// "double *TransformNormal(const double normal[3])"
public IntPtr TransformNormal(double /*(double[3])*/ []normal) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformNormal_3(returnPointer.GetPtr(), this, normal);
	return (IntPtr)returnPointer;
}


// float* TransformFloatNormal(float x, float y, float z)
// "float *TransformFloatNormal(float x, float y, float z)"
public IntPtr TransformFloatNormal(float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformFloatNormal_0(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// float* TransformFloatNormal(const float normal[3])
// "float *TransformFloatNormal(const float normal[3])"
public IntPtr TransformFloatNormal(float /*(float[3])*/ []normal) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformFloatNormal_1(returnPointer.GetPtr(), this, normal);
	return (IntPtr)returnPointer;
}


// double* TransformDoubleNormal(double x, double y, double z)
// "double *TransformDoubleNormal(double x, double y, double z)"
public IntPtr TransformDoubleNormal(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformDoubleNormal_0(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// double* TransformDoubleNormal(const double normal[3])
// "double *TransformDoubleNormal(const double normal[3])"
public IntPtr TransformDoubleNormal(double /*(double[3])*/ []normal) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformDoubleNormal_1(returnPointer.GetPtr(), this, normal);
	return (IntPtr)returnPointer;
}


// double* TransformVector(double x, double y, double z)
// "double *TransformVector(double x, double y, double z)"
public IntPtr TransformVector(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformVector_0(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// double* TransformVector(const double normal[3])
// "double *TransformVector(const double normal[3])"
public IntPtr TransformVector(double /*(double[3])*/ []normal) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformVector_1(returnPointer.GetPtr(), this, normal);
	return (IntPtr)returnPointer;
}


// void TransformVector(const float in[3], float out[3])
// "void TransformVector(const float in[3], float out[3])"
public void TransformVector(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.TransformVector_2(this, in_var, out_var);
}


// void TransformVector(const double in[3], double out[3])
// "void TransformVector(const double in[3], double out[3])"
public void TransformVector(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.TransformVector_3(this, in_var, out_var);
}


// float* TransformFloatVector(float x, float y, float z)
// "float *TransformFloatVector(float x, float y, float z)"
public IntPtr TransformFloatVector(float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformFloatVector_0(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// float* TransformFloatVector(const float vec[3])
// "float *TransformFloatVector(const float vec[3])"
public IntPtr TransformFloatVector(float /*(float[3])*/ []vec) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformFloatVector_1(returnPointer.GetPtr(), this, vec);
	return (IntPtr)returnPointer;
}


// double* TransformDoubleVector(double x, double y, double z)
// "double *TransformDoubleVector(double x, double y, double z)"
public IntPtr TransformDoubleVector(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformDoubleVector_0(returnPointer.GetPtr(), this, x, y, z);
	return (IntPtr)returnPointer;
}


// double* TransformDoubleVector(const double vec[3])
// "double *TransformDoubleVector(const double vec[3])"
public IntPtr TransformDoubleVector(double /*(double[3])*/ []vec) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.TransformDoubleVector_1(returnPointer.GetPtr(), this, vec);
	return (IntPtr)returnPointer;
}


// void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// "void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)"
public void TransformPoints(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts) {
	VTK_API.API_vtkLinearTransform.TransformPoints_0(this, inPts, outPts);
}


// virtual void TransformNormals(vtkDataArray * inNms, vtkDataArray * outNms)
// "virtual void TransformNormals(vtkDataArray *inNms, vtkDataArray *outNms)"
public void TransformNormals(vtkDataArray /*(vtkDataArray*)*/ inNms, vtkDataArray /*(vtkDataArray*)*/ outNms) {
	VTK_API.API_vtkLinearTransform.TransformNormals_0(this, inNms, outNms);
}


// virtual void TransformVectors(vtkDataArray * inVrs, vtkDataArray * outVrs)
// "virtual void TransformVectors(vtkDataArray *inVrs, vtkDataArray *outVrs)"
public void TransformVectors(vtkDataArray /*(vtkDataArray*)*/ inVrs, vtkDataArray /*(vtkDataArray*)*/ outVrs) {
	VTK_API.API_vtkLinearTransform.TransformVectors_0(this, inVrs, outVrs);
}


// void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs)
// "void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs)"
public void TransformPointsNormalsVectors(vtkPoints /*(vtkPoints*)*/ inPts, vtkPoints /*(vtkPoints*)*/ outPts, vtkDataArray /*(vtkDataArray*)*/ inNms, vtkDataArray /*(vtkDataArray*)*/ outNms, vtkDataArray /*(vtkDataArray*)*/ inVrs, vtkDataArray /*(vtkDataArray*)*/ outVrs) {
	VTK_API.API_vtkLinearTransform.TransformPointsNormalsVectors_0(this, inPts, outPts, inNms, outNms, inVrs, outVrs);
}


// vtkLinearTransform* GetLinearInverse()
// "vtkLinearTransform *GetLinearInverse()"
public vtkLinearTransform GetLinearInverse() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkLinearTransform.GetLinearInverse_0(returnPointer.GetPtr(), this);
	return (vtkLinearTransform)(IntPtr)returnPointer;
}


// void InternalTransformPoint(const float in[3], float out[3])
// "void InternalTransformPoint(const float in[3], float out[3])"
public void InternalTransformPoint(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformPoint_0(this, in_var, out_var);
}


// void InternalTransformPoint(const double in[3], double out[3])
// "void InternalTransformPoint(const double in[3], double out[3])"
public void InternalTransformPoint(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformPoint_1(this, in_var, out_var);
}


// virtual void InternalTransformNormal(const float in[3], float out[3])
// "virtual void InternalTransformNormal(const float in[3], float out[3])"
public void InternalTransformNormal(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformNormal_0(this, in_var, out_var);
}


// virtual void InternalTransformNormal(const double in[3], double out[3])
// "virtual void InternalTransformNormal(const double in[3], double out[3])"
public void InternalTransformNormal(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformNormal_1(this, in_var, out_var);
}


// virtual void InternalTransformVector(const float in[3], float out[3])
// "virtual void InternalTransformVector(const float in[3], float out[3])"
public void InternalTransformVector(float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformVector_0(this, in_var, out_var);
}


// virtual void InternalTransformVector(const double in[3], double out[3])
// "virtual void InternalTransformVector(const double in[3], double out[3])"
public void InternalTransformVector(double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var) {
	VTK_API.API_vtkLinearTransform.InternalTransformVector_1(this, in_var, out_var);
}


}
};
