
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPerspectiveTransform {

// static vtkPerspectiveTransform* New()
// static vtkPerspectiveTransform *New()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, string /*(char*)*/ type);

// static vtkPerspectiveTransform* SafeDownCast(vtkObjectBase * o)
// static vtkPerspectiveTransform* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPerspectiveTransform* NewInstance()
// vtkPerspectiveTransform *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void Identity()
// void Identity()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Identity_0")] public static extern 
bool Identity_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void Inverse()
// void Inverse()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Inverse_0")] public static extern 
bool Inverse_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
// void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_AdjustViewport_0")] public static extern 
bool AdjustViewport_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ oldXMin, double /*(double)*/ oldXMax, double /*(double)*/ oldYMin, double /*(double)*/ oldYMax, double /*(double)*/ newXMin, double /*(double)*/ newXMax, double /*(double)*/ newYMin, double /*(double)*/ newYMax);

// void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
// void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_AdjustZBuffer_0")] public static extern 
bool AdjustZBuffer_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ oldNearZ, double /*(double)*/ oldFarZ, double /*(double)*/ newNearZ, double /*(double)*/ newFarZ);

// void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
// void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Ortho_0")] public static extern 
bool Ortho_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ znear, double /*(double)*/ zfar);

// void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
// void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Frustum_0")] public static extern 
bool Frustum_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ znear, double /*(double)*/ zfar);

// void Perspective(double angle, double aspect, double znear, double zfar)
// void Perspective(double angle, double aspect, double znear, double zfar)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Perspective_0")] public static extern 
bool Perspective_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double)*/ aspect, double /*(double)*/ znear, double /*(double)*/ zfar);

// void Shear(double dxdz, double dydz, double zplane)
// void Shear(double dxdz, double dydz, double zplane)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Shear_0")] public static extern 
bool Shear_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ dxdz, double /*(double)*/ dydz, double /*(double)*/ zplane);

// void Stereo(double angle, double focaldistance)
// void Stereo(double angle, double focaldistance)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Stereo_0")] public static extern 
bool Stereo_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double)*/ focaldistance);

// void SetupCamera(const double position[3], const double focalpoint[3], const double viewup[3])
// void SetupCamera(const double position[3], const double focalpoint[3], const double viewup[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SetupCamera_0")] public static extern 
bool SetupCamera_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double[3])*/ []position, double /*(double[3])*/ []focalpoint, double /*(double[3])*/ []viewup);

// void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
// void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SetupCamera_1")] public static extern 
bool SetupCamera_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ p0, double /*(double)*/ p1, double /*(double)*/ p2, double /*(double)*/ fp0, double /*(double)*/ fp1, double /*(double)*/ fp2, double /*(double)*/ vup0, double /*(double)*/ vup1, double /*(double)*/ vup2);

// void Translate(double x, double y, double z)
// void Translate(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Translate_0")] public static extern 
bool Translate_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void Translate(const double x[3])
// void Translate(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Translate_1")] public static extern 
bool Translate_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double[3])*/ []x);

// void Translate(const float x[3])
// void Translate(const float x[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Translate_2")] public static extern 
bool Translate_2(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, float /*(float[3])*/ []x);

// void RotateWXYZ(double angle, double x, double y, double z)
// void RotateWXYZ(double angle, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateWXYZ_0")] public static extern 
bool RotateWXYZ_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void RotateWXYZ(double angle, const double axis[3])
// void RotateWXYZ(double angle, const double axis[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateWXYZ_1")] public static extern 
bool RotateWXYZ_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle, double /*(double[3])*/ []axis);

// void RotateWXYZ(double angle, const float axis[3])
// void RotateWXYZ(double angle, const float axis[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateWXYZ_2")] public static extern 
bool RotateWXYZ_2(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle, float /*(float[3])*/ []axis);

// void RotateX(double angle)
// void RotateX(double angle)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateX_0")] public static extern 
bool RotateX_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle);

// void RotateY(double angle)
// void RotateY(double angle)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateY_0")] public static extern 
bool RotateY_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle);

// void RotateZ(double angle)
// void RotateZ(double angle)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_RotateZ_0")] public static extern 
bool RotateZ_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ angle);

// void Scale(double x, double y, double z)
// void Scale(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Scale_0")] public static extern 
bool Scale_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void Scale(const double s[3])
// void Scale(const double s[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Scale_1")] public static extern 
bool Scale_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double[3])*/ []s);

// void Scale(const float s[3])
// void Scale(const float s[3])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Scale_2")] public static extern 
bool Scale_2(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, float /*(float[3])*/ []s);

// void SetMatrix(vtkMatrix4x4 * matrix)
// void SetMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SetMatrix_0")] public static extern 
bool SetMatrix_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void SetMatrix(const double elements[16])
// void SetMatrix(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SetMatrix_1")] public static extern 
bool SetMatrix_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double[16])*/ []elements);

// void Concatenate(vtkMatrix4x4 * matrix)
// void Concatenate(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Concatenate_0")] public static extern 
bool Concatenate_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void Concatenate(const double elements[16])
// void Concatenate(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Concatenate_1")] public static extern 
bool Concatenate_1(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, double /*(double[16])*/ []elements);

// void Concatenate(vtkHomogeneousTransform * transform)
// void Concatenate(vtkHomogeneousTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Concatenate_2")] public static extern 
bool Concatenate_2(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, IntPtr /*(vtkHomogeneousTransform*)*/ transform);

// void PreMultiply()
// void PreMultiply()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_PreMultiply_0")] public static extern 
bool PreMultiply_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void PostMultiply()
// void PostMultiply()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_PostMultiply_0")] public static extern 
bool PostMultiply_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// int GetNumberOfConcatenatedTransforms()
// int GetNumberOfConcatenatedTransforms()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_0")] public static extern 
bool GetNumberOfConcatenatedTransforms_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// vtkHomogeneousTransform* GetConcatenatedTransform(int i)
// vtkHomogeneousTransform *GetConcatenatedTransform(int i)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_GetConcatenatedTransform_0")] public static extern 
bool GetConcatenatedTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, int /*(int)*/ i);

// void SetInput(vtkHomogeneousTransform * input)
// void SetInput(vtkHomogeneousTransform *input)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_SetInput_0")] public static extern 
bool SetInput_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, IntPtr /*(vtkHomogeneousTransform*)*/ input);

// vtkHomogeneousTransform* GetInput()
// vtkHomogeneousTransform *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// int GetInverseFlag()
// int GetInverseFlag()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_GetInverseFlag_0")] public static extern 
bool GetInverseFlag_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void Push()
// void Push()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Push_0")] public static extern 
bool Push_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// void Pop()
// void Pop()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_Pop_0")] public static extern 
bool Pop_0(IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// vtkAbstractTransform* MakeTransform()
// vtkAbstractTransform *MakeTransform()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_MakeTransform_0")] public static extern 
bool MakeTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

// int CircuitCheck(vtkAbstractTransform * transform)
// int CircuitCheck(vtkAbstractTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_CircuitCheck_0")] public static extern 
bool CircuitCheck_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ transform);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkPerspectiveTransform_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPerspectiveTransform*)*/ callingObject);

}
};
