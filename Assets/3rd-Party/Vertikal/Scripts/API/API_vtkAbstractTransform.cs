
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractTransform {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractTransform* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractTransform* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractTransform* NewInstance()
// vtkAbstractTransform *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// void TransformPoint(const float in[3], float out[3])
// void TransformPoint(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPoint_0")] public static extern 
bool TransformPoint_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void TransformPoint(const double in[3], double out[3])
// void TransformPoint(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPoint_1")] public static extern 
bool TransformPoint_1(IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// double* TransformPoint(double x, double y, double z)
// double *TransformPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPoint_2")] public static extern 
bool TransformPoint_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformPoint(const double point[3])
// double *TransformPoint(const double point[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPoint_3")] public static extern 
bool TransformPoint_3(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point);

// float* TransformFloatPoint(float x, float y, float z)
// float *TransformFloatPoint(float x, float y, float z)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformFloatPoint_0")] public static extern 
bool TransformFloatPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float)*/ x, float /*(float)*/ y, float /*(float)*/ z);

// float* TransformFloatPoint(const float point[3])
// float *TransformFloatPoint(const float point[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformFloatPoint_1")] public static extern 
bool TransformFloatPoint_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []point);

// double* TransformDoublePoint(double x, double y, double z)
// double *TransformDoublePoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformDoublePoint_0")] public static extern 
bool TransformDoublePoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// double* TransformDoublePoint(const double point[3])
// double *TransformDoublePoint(const double point[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformDoublePoint_1")] public static extern 
bool TransformDoublePoint_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point);

// void TransformNormalAtPoint(const float point[3], const float in[3], float out[3])
// void TransformNormalAtPoint(const float point[3], const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformNormalAtPoint_0")] public static extern 
bool TransformNormalAtPoint_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []point, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void TransformNormalAtPoint(const double point[3], const double in[3], double out[3])
// void TransformNormalAtPoint(const double point[3], const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformNormalAtPoint_1")] public static extern 
bool TransformNormalAtPoint_1(IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// double* TransformNormalAtPoint(const double point[3], const double normal[3])
// double *TransformNormalAtPoint(const double point[3], const double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformNormalAtPoint_2")] public static extern 
bool TransformNormalAtPoint_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []normal);

// double* TransformDoubleNormalAtPoint(const double point[3], const double normal[3])
// double *TransformDoubleNormalAtPoint(const double point[3], const double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformDoubleNormalAtPoint_0")] public static extern 
bool TransformDoubleNormalAtPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []normal);

// float* TransformFloatNormalAtPoint(const float point[3], const float normal[3])
// float *TransformFloatNormalAtPoint(const float point[3], const float normal[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformFloatNormalAtPoint_0")] public static extern 
bool TransformFloatNormalAtPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []point, float /*(float[3])*/ []normal);

// void TransformVectorAtPoint(const float point[3], const float in[3], float out[3])
// void TransformVectorAtPoint(const float point[3], const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformVectorAtPoint_0")] public static extern 
bool TransformVectorAtPoint_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []point, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void TransformVectorAtPoint(const double point[3], const double in[3], double out[3])
// void TransformVectorAtPoint(const double point[3], const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformVectorAtPoint_1")] public static extern 
bool TransformVectorAtPoint_1(IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// double* TransformVectorAtPoint(const double point[3], const double vector[3])
// double *TransformVectorAtPoint(const double point[3], const double vector[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformVectorAtPoint_2")] public static extern 
bool TransformVectorAtPoint_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []vector);

// double* TransformDoubleVectorAtPoint(const double point[3], const double vector[3])
// double *TransformDoubleVectorAtPoint(const double point[3], const double vector[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformDoubleVectorAtPoint_0")] public static extern 
bool TransformDoubleVectorAtPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []point, double /*(double[3])*/ []vector);

// float* TransformFloatVectorAtPoint(const float point[3], const float vector[3])
// float *TransformFloatVectorAtPoint(const float point[3], const float vector[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformFloatVectorAtPoint_0")] public static extern 
bool TransformFloatVectorAtPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []point, float /*(float[3])*/ []vector);

// virtual void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// virtual void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPoints_0")] public static extern 
bool TransformPoints_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts);

// virtual void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs)
// virtual void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_TransformPointsNormalsVectors_0")] public static extern 
bool TransformPointsNormalsVectors_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts, IntPtr /*(vtkDataArray*)*/ inNms, IntPtr /*(vtkDataArray*)*/ outNms, IntPtr /*(vtkDataArray*)*/ inVrs, IntPtr /*(vtkDataArray*)*/ outVrs);

// vtkAbstractTransform* GetInverse()
// vtkAbstractTransform *GetInverse()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_GetInverse_0")] public static extern 
bool GetInverse_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// void SetInverse(vtkAbstractTransform * transform)
// void SetInverse(vtkAbstractTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_SetInverse_0")] public static extern 
bool SetInverse_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ transform);

// virtual void Inverse()
// virtual void Inverse()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_Inverse_0")] public static extern 
bool Inverse_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// void DeepCopy(vtkAbstractTransform * ARG_0)
// void DeepCopy(vtkAbstractTransform *)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ ARG_0);

// void Update()
// void Update()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_Update_0")] public static extern 
bool Update_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// virtual void InternalTransformPoint(const float in[3], float out[3])
// virtual void InternalTransformPoint(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_InternalTransformPoint_0")] public static extern 
bool InternalTransformPoint_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// virtual void InternalTransformPoint(const double in[3], double out[3])
// virtual void InternalTransformPoint(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_InternalTransformPoint_1")] public static extern 
bool InternalTransformPoint_1(IntPtr /*(vtkAbstractTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

// virtual vtkAbstractTransform* MakeTransform()
// virtual vtkAbstractTransform *MakeTransform()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_MakeTransform_0")] public static extern 
bool MakeTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// virtual int CircuitCheck(vtkAbstractTransform * transform)
// virtual int CircuitCheck(vtkAbstractTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_CircuitCheck_0")] public static extern 
bool CircuitCheck_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ transform);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractTransform*)*/ callingObject);

// void UnRegister(vtkObjectBase * O)
// void UnRegister(vtkObjectBase *O)
[DllImport("vtkplugin", EntryPoint="vtkAbstractTransform_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkAbstractTransform*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ O);

}
};
