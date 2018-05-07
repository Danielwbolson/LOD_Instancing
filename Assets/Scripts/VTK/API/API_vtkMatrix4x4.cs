
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkMatrix4x4 {

// static vtkMatrix4x4* New()
// static vtkMatrix4x4 *New()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject, string /*(char*)*/ type);

// static vtkMatrix4x4* SafeDownCast(vtkObjectBase * o)
// static vtkMatrix4x4* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkMatrix4x4* NewInstance()
// vtkMatrix4x4 *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// void DeepCopy(const vtkMatrix4x4 * source)
// void DeepCopy(const vtkMatrix4x4 *source)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ source);

// static void DeepCopy(double destination[16], const vtkMatrix4x4 * source)
// static void DeepCopy(double destination[16], const vtkMatrix4x4 *source)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_DeepCopy_1")] public static extern 
bool DeepCopy_1(double /*(double[16])*/ []destination, IntPtr /*(vtkMatrix4x4*)*/ source);

// static void DeepCopy(double destination[16], const double source[16])
// static void DeepCopy(double destination[16], const double source[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_DeepCopy_2")] public static extern 
bool DeepCopy_2(double /*(double[16])*/ []destination, double /*(double[16])*/ []source);

// void DeepCopy(const double elements[16])
// void DeepCopy(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_DeepCopy_3")] public static extern 
bool DeepCopy_3(IntPtr /*(vtkMatrix4x4*)*/ callingObject, double /*(double[16])*/ []elements);

// void Zero()
// void Zero()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Zero_0")] public static extern 
bool Zero_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// static void Zero(double elements[16])
// static void Zero(double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Zero_1")] public static extern 
bool Zero_1(double /*(double[16])*/ []elements);

// void Identity()
// void Identity()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Identity_0")] public static extern 
bool Identity_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// static void Identity(double elements[16])
// static void Identity(double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Identity_1")] public static extern 
bool Identity_1(double /*(double[16])*/ []elements);

// static void Invert(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// static void Invert(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Invert_0")] public static extern 
bool Invert_0(IntPtr /*(vtkMatrix4x4*)*/ in_var, IntPtr /*(vtkMatrix4x4*)*/ out_var);

// void Invert()
// void Invert()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Invert_1")] public static extern 
bool Invert_1(IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// static void Invert(const double inElements[16], double outElements[16])
// static void Invert(const double inElements[16], double outElements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Invert_2")] public static extern 
bool Invert_2(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements);

// static void Transpose(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// static void Transpose(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Transpose_0")] public static extern 
bool Transpose_0(IntPtr /*(vtkMatrix4x4*)*/ in_var, IntPtr /*(vtkMatrix4x4*)*/ out_var);

// void Transpose()
// void Transpose()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Transpose_1")] public static extern 
bool Transpose_1(IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// static void Transpose(const double inElements[16], double outElements[16])
// static void Transpose(const double inElements[16], double outElements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Transpose_2")] public static extern 
bool Transpose_2(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements);

// void MultiplyPoint(const float in[4], float out[4])
// void MultiplyPoint(const float in[4], float out[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyPoint_0")] public static extern 
bool MultiplyPoint_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject, float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var);

// void MultiplyPoint(const double in[4], double out[4])
// void MultiplyPoint(const double in[4], double out[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyPoint_1")] public static extern 
bool MultiplyPoint_1(IntPtr /*(vtkMatrix4x4*)*/ callingObject, double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var);

// static void MultiplyPoint(const double elements[16], const float in[4], float out[4])
// static void MultiplyPoint(const double elements[16], const float in[4], float out[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyPoint_2")] public static extern 
bool MultiplyPoint_2(double /*(double[16])*/ []elements, float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var);

// static void MultiplyPoint(const double elements[16], const double in[4], double out[4])
// static void MultiplyPoint(const double elements[16], const double in[4], double out[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyPoint_3")] public static extern 
bool MultiplyPoint_3(double /*(double[16])*/ []elements, double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var);

// float* MultiplyPoint(const float in[4])
// float *MultiplyPoint(const float in[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyPoint_4")] public static extern 
bool MultiplyPoint_4(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject, float /*(float[4])*/ []in_var);

// float* MultiplyFloatPoint(const float in[4])
// float *MultiplyFloatPoint(const float in[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyFloatPoint_0")] public static extern 
bool MultiplyFloatPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject, float /*(float[4])*/ []in_var);

// double* MultiplyDoublePoint(const double in[4])
// double *MultiplyDoublePoint(const double in[4])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_MultiplyDoublePoint_0")] public static extern 
bool MultiplyDoublePoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject, double /*(double[4])*/ []in_var);

// static void Multiply4x4(const vtkMatrix4x4 * a, const vtkMatrix4x4 * b, vtkMatrix4x4 * c)
// static void Multiply4x4(const vtkMatrix4x4 *a, const vtkMatrix4x4 *b, vtkMatrix4x4 *c)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Multiply4x4_0")] public static extern 
bool Multiply4x4_0(IntPtr /*(vtkMatrix4x4*)*/ a, IntPtr /*(vtkMatrix4x4*)*/ b, IntPtr /*(vtkMatrix4x4*)*/ c);

// static void Multiply4x4(const double a[16], const double b[16], double c[16])
// static void Multiply4x4(const double a[16], const double b[16], double c[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Multiply4x4_1")] public static extern 
bool Multiply4x4_1(double /*(double[16])*/ []a, double /*(double[16])*/ []b, double /*(double[16])*/ []c);

// void Adjoint(const vtkMatrix4x4 * in, vtkMatrix4x4 * out)
// void Adjoint(const vtkMatrix4x4 *in, vtkMatrix4x4 *out)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Adjoint_0")] public static extern 
bool Adjoint_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ in_var, IntPtr /*(vtkMatrix4x4*)*/ out_var);

// static void Adjoint(const double inElements[16], double outElements[16])
// static void Adjoint(const double inElements[16], double outElements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Adjoint_1")] public static extern 
bool Adjoint_1(double /*(double[16])*/ []inElements, double /*(double[16])*/ []outElements);

// double Determinant()
// double Determinant()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Determinant_0")] public static extern 
bool Determinant_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject);

// static double Determinant(const double elements[16])
// static double Determinant(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_Determinant_1")] public static extern 
bool Determinant_1(IntPtr /*(IntPtr*)*/ return_value, double /*(double[16])*/ []elements);

// void SetElement(int i, int j, double value)
// void SetElement(int i, int j, double value)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_SetElement_0")] public static extern 
bool SetElement_0(IntPtr /*(vtkMatrix4x4*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j, double /*(double)*/ value);

// double GetElement(int i, int j)
// double GetElement(int i, int j)
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_GetElement_0")] public static extern 
bool GetElement_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject, int /*(int)*/ i, int /*(int)*/ j);

// double* GetData()
// double *GetData()
[DllImport("vtkplugin", EntryPoint="vtkMatrix4x4_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMatrix4x4*)*/ callingObject);

}
};
