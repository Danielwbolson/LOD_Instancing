
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPlanes {

// static vtkPlanes* New()
// static vtkPlanes *New()
[DllImport("vtkplugin", EntryPoint="vtkPlanes_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject, string /*(char*)*/ type);

// static vtkPlanes* SafeDownCast(vtkObjectBase * o)
// static vtkPlanes* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPlanes* NewInstance()
// vtkPlanes *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPlanes_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject);

// double EvaluateFunction(double x[3])
// double EvaluateFunction(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlanes_EvaluateFunction_0")] public static extern 
bool EvaluateFunction_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject, double /*(double[3])*/ []x);

// void EvaluateGradient(double x[3], double n[3])
// void EvaluateGradient(double x[3], double n[3])
[DllImport("vtkplugin", EntryPoint="vtkPlanes_EvaluateGradient_0")] public static extern 
bool EvaluateGradient_0(IntPtr /*(vtkPlanes*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []n);

// virtual void SetPoints(vtkPoints * ARG_0)
// virtual void SetPoints(vtkPoints*)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SetPoints_0")] public static extern 
bool SetPoints_0(IntPtr /*(vtkPlanes*)*/ callingObject, IntPtr /*(vtkPoints*)*/ ARG_0);

// virtual vtkPoints* GetPoints()
// virtual vtkPoints *GetPoints ()
[DllImport("vtkplugin", EntryPoint="vtkPlanes_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject);

// void SetNormals(vtkDataArray * normals)
// void SetNormals(vtkDataArray* normals)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SetNormals_0")] public static extern 
bool SetNormals_0(IntPtr /*(vtkPlanes*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ normals);

// virtual vtkDataArray* GetNormals()
// virtual vtkDataArray *GetNormals ()
[DllImport("vtkplugin", EntryPoint="vtkPlanes_GetNormals_0")] public static extern 
bool GetNormals_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject);

// void SetFrustumPlanes(double planes[24])
// void SetFrustumPlanes(double planes[24])
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SetFrustumPlanes_0")] public static extern 
bool SetFrustumPlanes_0(IntPtr /*(vtkPlanes*)*/ callingObject, double /*(double[24])*/ []planes);

// void SetBounds(const double bounds[6])
// void SetBounds(const double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SetBounds_0")] public static extern 
bool SetBounds_0(IntPtr /*(vtkPlanes*)*/ callingObject, double /*(double[6])*/ []bounds);

// void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_SetBounds_1")] public static extern 
bool SetBounds_1(IntPtr /*(vtkPlanes*)*/ callingObject, double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax);

// int GetNumberOfPlanes()
// int GetNumberOfPlanes()
[DllImport("vtkplugin", EntryPoint="vtkPlanes_GetNumberOfPlanes_0")] public static extern 
bool GetNumberOfPlanes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject);

// vtkPlane* GetPlane(int i)
// vtkPlane *GetPlane(int i)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_GetPlane_0")] public static extern 
bool GetPlane_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlanes*)*/ callingObject, int /*(int)*/ i);

// void GetPlane(int i, vtkPlane * plane)
// void GetPlane(int i, vtkPlane *plane)
[DllImport("vtkplugin", EntryPoint="vtkPlanes_GetPlane_1")] public static extern 
bool GetPlane_1(IntPtr /*(vtkPlanes*)*/ callingObject, int /*(int)*/ i, IntPtr /*(vtkPlane*)*/ plane);

}
};
