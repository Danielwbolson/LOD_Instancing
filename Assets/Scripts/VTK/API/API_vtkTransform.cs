
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkTransform {

// static vtkTransform* New()
// static vtkTransform *New()
[DllImport("vtkplugin", EntryPoint="vtkTransform_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTransform_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTransform_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject, string /*(char*)*/ type);

// static vtkTransform* SafeDownCast(vtkObjectBase * o)
// static vtkTransform* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkTransform_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkTransform* NewInstance()
// vtkTransform *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkTransform_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void Identity()
// void Identity()
[DllImport("vtkplugin", EntryPoint="vtkTransform_Identity_0")] public static extern 
bool Identity_0(IntPtr /*(vtkTransform*)*/ callingObject);

// void Inverse()
// void Inverse()
[DllImport("vtkplugin", EntryPoint="vtkTransform_Inverse_0")] public static extern 
bool Inverse_0(IntPtr /*(vtkTransform*)*/ callingObject);

// void Translate(double x, double y, double z)
// void Translate(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkTransform_Translate_0")] public static extern 
bool Translate_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void Translate(const double x[3])
// void Translate(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_Translate_1")] public static extern 
bool Translate_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[3])*/ []x);

// void Translate(const float x[3])
// void Translate(const float x[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_Translate_2")] public static extern 
bool Translate_2(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[3])*/ []x);

// void RotateWXYZ(double angle, double x, double y, double z)
// void RotateWXYZ(double angle, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateWXYZ_0")] public static extern 
bool RotateWXYZ_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void RotateWXYZ(double angle, const double axis[3])
// void RotateWXYZ(double angle, const double axis[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateWXYZ_1")] public static extern 
bool RotateWXYZ_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double[3])*/ []axis);

// void RotateWXYZ(double angle, const float axis[3])
// void RotateWXYZ(double angle, const float axis[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateWXYZ_2")] public static extern 
bool RotateWXYZ_2(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle, float /*(float[3])*/ []axis);

// void RotateX(double angle)
// void RotateX(double angle)
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateX_0")] public static extern 
bool RotateX_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle);

// void RotateY(double angle)
// void RotateY(double angle)
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateY_0")] public static extern 
bool RotateY_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle);

// void RotateZ(double angle)
// void RotateZ(double angle)
[DllImport("vtkplugin", EntryPoint="vtkTransform_RotateZ_0")] public static extern 
bool RotateZ_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ angle);

// void Scale(double x, double y, double z)
// void Scale(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkTransform_Scale_0")] public static extern 
bool Scale_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void Scale(const double s[3])
// void Scale(const double s[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_Scale_1")] public static extern 
bool Scale_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[3])*/ []s);

// void Scale(const float s[3])
// void Scale(const float s[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_Scale_2")] public static extern 
bool Scale_2(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[3])*/ []s);

// void SetMatrix(vtkMatrix4x4 * matrix)
// void SetMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkTransform_SetMatrix_0")] public static extern 
bool SetMatrix_0(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void SetMatrix(const double elements[16])
// void SetMatrix(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkTransform_SetMatrix_1")] public static extern 
bool SetMatrix_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[16])*/ []elements);

// void Concatenate(vtkMatrix4x4 * matrix)
// void Concatenate(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkTransform_Concatenate_0")] public static extern 
bool Concatenate_0(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void Concatenate(const double elements[16])
// void Concatenate(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkTransform_Concatenate_1")] public static extern 
bool Concatenate_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[16])*/ []elements);

// void Concatenate(vtkLinearTransform * transform)
// void Concatenate(vtkLinearTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkTransform_Concatenate_2")] public static extern 
bool Concatenate_2(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkLinearTransform*)*/ transform);

// void PreMultiply()
// void PreMultiply()
[DllImport("vtkplugin", EntryPoint="vtkTransform_PreMultiply_0")] public static extern 
bool PreMultiply_0(IntPtr /*(vtkTransform*)*/ callingObject);

// void PostMultiply()
// void PostMultiply()
[DllImport("vtkplugin", EntryPoint="vtkTransform_PostMultiply_0")] public static extern 
bool PostMultiply_0(IntPtr /*(vtkTransform*)*/ callingObject);

// int GetNumberOfConcatenatedTransforms()
// int GetNumberOfConcatenatedTransforms()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetNumberOfConcatenatedTransforms_0")] public static extern 
bool GetNumberOfConcatenatedTransforms_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// vtkLinearTransform* GetConcatenatedTransform(int i)
// vtkLinearTransform *GetConcatenatedTransform(int i)
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetConcatenatedTransform_0")] public static extern 
bool GetConcatenatedTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject, int /*(int)*/ i);

// void GetOrientation(double orient[3])
// void GetOrientation(double orient[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientation_0")] public static extern 
bool GetOrientation_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[3])*/ []orient);

// void GetOrientation(float orient[3])
// void GetOrientation(float orient[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientation_1")] public static extern 
bool GetOrientation_1(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[3])*/ []orient);

// double* GetOrientation()
// double *GetOrientation()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientation_2")] public static extern 
bool GetOrientation_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// static void GetOrientation(double orient[3], vtkMatrix4x4 * matrix)
// static void GetOrientation(double orient[3], vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientation_3")] public static extern 
bool GetOrientation_3(double /*(double[3])*/ []orient, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void GetOrientationWXYZ(double wxyz[4])
// void GetOrientationWXYZ(double wxyz[4])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientationWXYZ_0")] public static extern 
bool GetOrientationWXYZ_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[4])*/ []wxyz);

// void GetOrientationWXYZ(float wxyz[4])
// void GetOrientationWXYZ(float wxyz[4])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientationWXYZ_1")] public static extern 
bool GetOrientationWXYZ_1(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[4])*/ []wxyz);

// double* GetOrientationWXYZ()
// double *GetOrientationWXYZ()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetOrientationWXYZ_2")] public static extern 
bool GetOrientationWXYZ_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void GetPosition(double pos[3])
// void GetPosition(double pos[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[3])*/ []pos);

// void GetPosition(float pos[3])
// void GetPosition(float pos[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetPosition_1")] public static extern 
bool GetPosition_1(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[3])*/ []pos);

// double* GetPosition()
// double *GetPosition()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetPosition_2")] public static extern 
bool GetPosition_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void GetScale(double scale[3])
// void GetScale(double scale[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetScale_0")] public static extern 
bool GetScale_0(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[3])*/ []scale);

// void GetScale(float scale[3])
// void GetScale(float scale[3])
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetScale_1")] public static extern 
bool GetScale_1(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[3])*/ []scale);

// double* GetScale()
// double *GetScale()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetScale_2")] public static extern 
bool GetScale_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void GetInverse(vtkMatrix4x4 * inverse)
// void GetInverse(vtkMatrix4x4 *inverse)
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetInverse_0")] public static extern 
bool GetInverse_0(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ inverse);

// void GetTranspose(vtkMatrix4x4 * transpose)
// void GetTranspose(vtkMatrix4x4 *transpose)
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetTranspose_0")] public static extern 
bool GetTranspose_0(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ transpose);

// void SetInput(vtkLinearTransform * input)
// void SetInput(vtkLinearTransform *input)
[DllImport("vtkplugin", EntryPoint="vtkTransform_SetInput_0")] public static extern 
bool SetInput_0(IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkLinearTransform*)*/ input);

// vtkLinearTransform* GetInput()
// vtkLinearTransform *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// int GetInverseFlag()
// int GetInverseFlag()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetInverseFlag_0")] public static extern 
bool GetInverseFlag_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void Push()
// void Push()
[DllImport("vtkplugin", EntryPoint="vtkTransform_Push_0")] public static extern 
bool Push_0(IntPtr /*(vtkTransform*)*/ callingObject);

// void Pop()
// void Pop()
[DllImport("vtkplugin", EntryPoint="vtkTransform_Pop_0")] public static extern 
bool Pop_0(IntPtr /*(vtkTransform*)*/ callingObject);

// int CircuitCheck(vtkAbstractTransform * transform)
// int CircuitCheck(vtkAbstractTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkTransform_CircuitCheck_0")] public static extern 
bool CircuitCheck_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ transform);

// vtkAbstractTransform* GetInverse()
// vtkAbstractTransform *GetInverse()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetInverse_1")] public static extern 
bool GetInverse_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// vtkAbstractTransform* MakeTransform()
// vtkAbstractTransform *MakeTransform()
[DllImport("vtkplugin", EntryPoint="vtkTransform_MakeTransform_0")] public static extern 
bool MakeTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkTransform_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkTransform*)*/ callingObject);

// void MultiplyPoint(const float in[4], float out[4])
// void MultiplyPoint(const float in[4], float out[4])
[DllImport("vtkplugin", EntryPoint="vtkTransform_MultiplyPoint_0")] public static extern 
bool MultiplyPoint_0(IntPtr /*(vtkTransform*)*/ callingObject, float /*(float[4])*/ []in_var, float /*(float[4])*/ []out_var);

// void MultiplyPoint(const double in[4], double out[4])
// void MultiplyPoint(const double in[4], double out[4])
[DllImport("vtkplugin", EntryPoint="vtkTransform_MultiplyPoint_1")] public static extern 
bool MultiplyPoint_1(IntPtr /*(vtkTransform*)*/ callingObject, double /*(double[4])*/ []in_var, double /*(double[4])*/ []out_var);

}
};
