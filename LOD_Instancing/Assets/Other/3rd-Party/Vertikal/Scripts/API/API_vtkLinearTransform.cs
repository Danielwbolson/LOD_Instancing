
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLinearTransform {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, string /*(char*)*/ type);

// static vtkLinearTransform* SafeDownCast(vtkObjectBase * o)
// static vtkLinearTransform* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkLinearTransform* NewInstance()
// vtkLinearTransform *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject);

// void TransformNormal(const float in[3], float out[3])
// void TransformNormal(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformNormal_0")] public static extern 
bool TransformNormal_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void TransformNormal(const double in[3], double out[3])
// void TransformNormal(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformNormal_1")] public static extern 
bool TransformNormal_1(IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// double* TransformNormal(double x, double y, double z)
// double *TransformNormal(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformNormal_2")] public static extern 
bool TransformNormal_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformNormal(const double normal[3])
// double *TransformNormal(const double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformNormal_3")] public static extern 
bool TransformNormal_3(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []normal);

// float* TransformFloatNormal(float x, float y, float z)
// float *TransformFloatNormal(float x, float y, float z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformFloatNormal_0")] public static extern 
bool TransformFloatNormal_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z);

// float* TransformFloatNormal(const float normal[3])
// float *TransformFloatNormal(const float normal[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformFloatNormal_1")] public static extern 
bool TransformFloatNormal_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []normal);

// double* TransformDoubleNormal(double x, double y, double z)
// double *TransformDoubleNormal(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformDoubleNormal_0")] public static extern 
bool TransformDoubleNormal_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformDoubleNormal(const double normal[3])
// double *TransformDoubleNormal(const double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformDoubleNormal_1")] public static extern 
bool TransformDoubleNormal_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []normal);

// double* TransformVector(double x, double y, double z)
// double *TransformVector(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformVector_0")] public static extern 
bool TransformVector_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformVector(const double normal[3])
// double *TransformVector(const double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformVector_1")] public static extern 
bool TransformVector_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []normal);

// void TransformVector(const float in[3], float out[3])
// void TransformVector(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformVector_2")] public static extern 
bool TransformVector_2(IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void TransformVector(const double in[3], double out[3])
// void TransformVector(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformVector_3")] public static extern 
bool TransformVector_3(IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// float* TransformFloatVector(float x, float y, float z)
// float *TransformFloatVector(float x, float y, float z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformFloatVector_0")] public static extern 
bool TransformFloatVector_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z);

// float* TransformFloatVector(const float vec[3])
// float *TransformFloatVector(const float vec[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformFloatVector_1")] public static extern 
bool TransformFloatVector_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []vec);

// double* TransformDoubleVector(double x, double y, double z)
// double *TransformDoubleVector(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformDoubleVector_0")] public static extern 
bool TransformDoubleVector_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformDoubleVector(const double vec[3])
// double *TransformDoubleVector(const double vec[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformDoubleVector_1")] public static extern 
bool TransformDoubleVector_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []vec);

// void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformPoints_0")] public static extern 
bool TransformPoints_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts);

// virtual void TransformNormals(vtkDataArray * inNms, vtkDataArray * outNms)
// virtual void TransformNormals(vtkDataArray *inNms, vtkDataArray *outNms)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformNormals_0")] public static extern 
bool TransformNormals_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ inNms, IntPtr /*(vtkDataArray*)*/ outNms);

// virtual void TransformVectors(vtkDataArray * inVrs, vtkDataArray * outVrs)
// virtual void TransformVectors(vtkDataArray *inVrs, vtkDataArray *outVrs)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformVectors_0")] public static extern 
bool TransformVectors_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ inVrs, IntPtr /*(vtkDataArray*)*/ outVrs);

// void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs)
// void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs)
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_TransformPointsNormalsVectors_0")] public static extern 
bool TransformPointsNormalsVectors_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts, IntPtr /*(vtkDataArray*)*/ inNms, IntPtr /*(vtkDataArray*)*/ outNms, IntPtr /*(vtkDataArray*)*/ inVrs, IntPtr /*(vtkDataArray*)*/ outVrs);

// vtkLinearTransform* GetLinearInverse()
// vtkLinearTransform *GetLinearInverse()
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_GetLinearInverse_0")] public static extern 
bool GetLinearInverse_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLinearTransform*)*/ callingObject);

// void InternalTransformPoint(const float in[3], float out[3])
// void InternalTransformPoint(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformPoint_0")] public static extern 
bool InternalTransformPoint_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void InternalTransformPoint(const double in[3], double out[3])
// void InternalTransformPoint(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformPoint_1")] public static extern 
bool InternalTransformPoint_1(IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// virtual void InternalTransformNormal(const float in[3], float out[3])
// virtual void InternalTransformNormal(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformNormal_0")] public static extern 
bool InternalTransformNormal_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// virtual void InternalTransformNormal(const double in[3], double out[3])
// virtual void InternalTransformNormal(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformNormal_1")] public static extern 
bool InternalTransformNormal_1(IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// virtual void InternalTransformVector(const float in[3], float out[3])
// virtual void InternalTransformVector(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformVector_0")] public static extern 
bool InternalTransformVector_0(IntPtr /*(vtkLinearTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// virtual void InternalTransformVector(const double in[3], double out[3])
// virtual void InternalTransformVector(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkLinearTransform_InternalTransformVector_1")] public static extern 
bool InternalTransformVector_1(IntPtr /*(vtkLinearTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

}
};
