
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkHomogeneousTransform {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, string /*(char*)*/ type);

// static vtkHomogeneousTransform* SafeDownCast(vtkObjectBase * o)
// static vtkHomogeneousTransform* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkHomogeneousTransform* NewInstance()
// vtkHomogeneousTransform *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkHomogeneousTransform*)*/ callingObject);

// void TransformPoints(vtkPoints * inPts, vtkPoints * outPts)
// void TransformPoints(vtkPoints *inPts, vtkPoints *outPts)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_TransformPoints_0")] public static extern 
bool TransformPoints_0(IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts);

// void TransformPointsNormalsVectors(vtkPoints * inPts, vtkPoints * outPts, vtkDataArray * inNms, vtkDataArray * outNms, vtkDataArray * inVrs, vtkDataArray * outVrs)
// void TransformPointsNormalsVectors(vtkPoints *inPts, vtkPoints *outPts, vtkDataArray *inNms, vtkDataArray *outNms, vtkDataArray *inVrs, vtkDataArray *outVrs)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_TransformPointsNormalsVectors_0")] public static extern 
bool TransformPointsNormalsVectors_0(IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, IntPtr /*(vtkPoints*)*/ inPts, IntPtr /*(vtkPoints*)*/ outPts, IntPtr /*(vtkDataArray*)*/ inNms, IntPtr /*(vtkDataArray*)*/ outNms, IntPtr /*(vtkDataArray*)*/ inVrs, IntPtr /*(vtkDataArray*)*/ outVrs);

// void GetMatrix(vtkMatrix4x4 * m)
// void GetMatrix(vtkMatrix4x4 *m)
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_GetMatrix_0")] public static extern 
bool GetMatrix_0(IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ m);

// vtkMatrix4x4* GetMatrix()
// vtkMatrix4x4 *GetMatrix()
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_GetMatrix_1")] public static extern 
bool GetMatrix_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkHomogeneousTransform*)*/ callingObject);

// vtkHomogeneousTransform* GetHomogeneousInverse()
// vtkHomogeneousTransform *GetHomogeneousInverse()
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_GetHomogeneousInverse_0")] public static extern 
bool GetHomogeneousInverse_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkHomogeneousTransform*)*/ callingObject);

// void InternalTransformPoint(const float in[3], float out[3])
// void InternalTransformPoint(const float in[3], float out[3])
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_InternalTransformPoint_0")] public static extern 
bool InternalTransformPoint_0(IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, float /*(float[3])*/ []in_var, float /*(float[3])*/ []out_var);

// void InternalTransformPoint(const double in[3], double out[3])
// void InternalTransformPoint(const double in[3], double out[3])
[DllImport("vtkplugin", EntryPoint="vtkHomogeneousTransform_InternalTransformPoint_1")] public static extern 
bool InternalTransformPoint_1(IntPtr /*(vtkHomogeneousTransform*)*/ callingObject, double /*(double[3])*/ []in_var, double /*(double[3])*/ []out_var);

}
};
