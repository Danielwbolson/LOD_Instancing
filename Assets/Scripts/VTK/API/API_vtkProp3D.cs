
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkProp3D {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject, string /*(char*)*/ type);

// static vtkProp3D* SafeDownCast(vtkObjectBase * o)
// static vtkProp3D* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkProp3D* NewInstance()
// vtkProp3D *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// void ShallowCopy(vtkProp * prop)
// void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkProp3D*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// virtual void SetPosition(double x, double y, double z)
// virtual void SetPosition(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetPosition_0")] public static extern 
bool SetPosition_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual void SetPosition(double pos[3])
// virtual void SetPosition(double pos[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetPosition_1")] public static extern 
bool SetPosition_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []pos);

// virtual double* GetPosition()
// virtual double *GetPosition ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual void GetPosition(double data[3])
// virtual void GetPosition (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetPosition_1")] public static extern 
bool GetPosition_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []data);

// void AddPosition(double deltaPosition[3])
// void AddPosition(double deltaPosition[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_AddPosition_0")] public static extern 
bool AddPosition_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []deltaPosition);

// void AddPosition(double deltaX, double deltaY, double deltaZ)
// void AddPosition(double deltaX, double deltaY, double deltaZ)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_AddPosition_1")] public static extern 
bool AddPosition_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ deltaX, double /*(double)*/ deltaY, double /*(double)*/ deltaZ);

// virtual void SetOrigin(double x, double y, double z)
// virtual void SetOrigin(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetOrigin_0")] public static extern 
bool SetOrigin_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual void SetOrigin(const double pos[3])
// virtual void SetOrigin(const double pos[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetOrigin_1")] public static extern 
bool SetOrigin_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []pos);

// virtual double* GetOrigin()
// virtual double *GetOrigin ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetOrigin_0")] public static extern 
bool GetOrigin_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual void GetOrigin(double data[3])
// virtual void GetOrigin (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetOrigin_1")] public static extern 
bool GetOrigin_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetScale(double x, double y, double z)
// virtual void SetScale(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetScale_0")] public static extern 
bool SetScale_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual void SetScale(double scale[3])
// virtual void SetScale(double scale[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetScale_1")] public static extern 
bool SetScale_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []scale);

// virtual double* GetScale()
// virtual double *GetScale ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetScale_0")] public static extern 
bool GetScale_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual void GetScale(double data[3])
// virtual void GetScale (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetScale_1")] public static extern 
bool GetScale_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []data);

// void SetScale(double s)
// void SetScale(double s)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetScale_2")] public static extern 
bool SetScale_2(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ s);

// void SetUserTransform(vtkLinearTransform * transform)
// void SetUserTransform(vtkLinearTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetUserTransform_0")] public static extern 
bool SetUserTransform_0(IntPtr /*(vtkProp3D*)*/ callingObject, IntPtr /*(vtkLinearTransform*)*/ transform);

// virtual vtkLinearTransform* GetUserTransform()
// virtual vtkLinearTransform *GetUserTransform ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetUserTransform_0")] public static extern 
bool GetUserTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// void SetUserMatrix(vtkMatrix4x4 * matrix)
// void SetUserMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetUserMatrix_0")] public static extern 
bool SetUserMatrix_0(IntPtr /*(vtkProp3D*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// vtkMatrix4x4* GetUserMatrix()
// vtkMatrix4x4 *GetUserMatrix()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetUserMatrix_0")] public static extern 
bool GetUserMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual void GetMatrix(vtkMatrix4x4 * m)
// virtual void GetMatrix(vtkMatrix4x4 *m)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetMatrix_0")] public static extern 
bool GetMatrix_0(IntPtr /*(vtkProp3D*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ m);

// virtual void GetMatrix(double m[16])
// virtual void GetMatrix(double m[16])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetMatrix_1")] public static extern 
bool GetMatrix_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[16])*/ []m);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[6])*/ []bounds);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// double* GetCenter()
// double *GetCenter()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetCenter_0")] public static extern 
bool GetCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// double* GetXRange()
// double *GetXRange()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetXRange_0")] public static extern 
bool GetXRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// double* GetYRange()
// double *GetYRange()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetYRange_0")] public static extern 
bool GetYRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// double* GetZRange()
// double *GetZRange()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetZRange_0")] public static extern 
bool GetZRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// double GetLength()
// double GetLength()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetLength_0")] public static extern 
bool GetLength_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// void RotateX(double ARG_0)
// void RotateX(double)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_RotateX_0")] public static extern 
bool RotateX_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ ARG_0);

// void RotateY(double ARG_0)
// void RotateY(double)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_RotateY_0")] public static extern 
bool RotateY_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ ARG_0);

// void RotateZ(double ARG_0)
// void RotateZ(double)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_RotateZ_0")] public static extern 
bool RotateZ_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ ARG_0);

// void RotateWXYZ(double w, double x, double y, double z)
// void RotateWXYZ(double w, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_RotateWXYZ_0")] public static extern 
bool RotateWXYZ_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ w, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetOrientation(double x, double y, double z)
// void SetOrientation(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetOrientation_0")] public static extern 
bool SetOrientation_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetOrientation(double orientation[3])
// void SetOrientation(double orientation[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_SetOrientation_1")] public static extern 
bool SetOrientation_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []orientation);

// double* GetOrientation()
// double *GetOrientation()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetOrientation_0")] public static extern 
bool GetOrientation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// void GetOrientation(double orentation[3])
// void GetOrientation(double orentation[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetOrientation_1")] public static extern 
bool GetOrientation_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []orentation);

// double* GetOrientationWXYZ()
// double *GetOrientationWXYZ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetOrientationWXYZ_0")] public static extern 
bool GetOrientationWXYZ_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// void AddOrientation(double x, double y, double z)
// void AddOrientation(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_AddOrientation_0")] public static extern 
bool AddOrientation_0(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void AddOrientation(double orentation[3])
// void AddOrientation(double orentation[3])
[DllImport("vtkplugin", EntryPoint="vtkProp3D_AddOrientation_1")] public static extern 
bool AddOrientation_1(IntPtr /*(vtkProp3D*)*/ callingObject, double /*(double[3])*/ []orentation);

// void PokeMatrix(vtkMatrix4x4 * matrix)
// void PokeMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkProp3D_PokeMatrix_0")] public static extern 
bool PokeMatrix_0(IntPtr /*(vtkProp3D*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// void InitPathTraversal()
// void InitPathTraversal()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_InitPathTraversal_0")] public static extern 
bool InitPathTraversal_0(IntPtr /*(vtkProp3D*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// vtkMTimeType GetUserTransformMatrixMTime()
// vtkMTimeType GetUserTransformMatrixMTime()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetUserTransformMatrixMTime_0")] public static extern 
bool GetUserTransformMatrixMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual void ComputeMatrix()
// virtual void ComputeMatrix()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_ComputeMatrix_0")] public static extern 
bool ComputeMatrix_0(IntPtr /*(vtkProp3D*)*/ callingObject);

// vtkMatrix4x4* GetMatrix()
// vtkMatrix4x4 *GetMatrix()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetMatrix_2")] public static extern 
bool GetMatrix_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

// virtual int GetIsIdentity()
// virtual int GetIsIdentity ()
[DllImport("vtkplugin", EntryPoint="vtkProp3D_GetIsIdentity_0")] public static extern 
bool GetIsIdentity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkProp3D*)*/ callingObject);

}
};
