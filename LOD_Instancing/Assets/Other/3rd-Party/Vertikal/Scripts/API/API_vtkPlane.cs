
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPlane {

// static vtkPlane* New()
// static vtkPlane *New()
[DllImport("vtkplugin", EntryPoint="vtkPlane_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlane_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPlane_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject, string /*(char*)*/ type);

// static vtkPlane* SafeDownCast(vtkObjectBase * o)
// static vtkPlane* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPlane_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPlane* NewInstance()
// vtkPlane *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPlane_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject);

// void EvaluateFunction(vtkDataArray * input, vtkDataArray * output)
// void EvaluateFunction(vtkDataArray* input, vtkDataArray* output)
[DllImport("vtkplugin", EntryPoint="vtkPlane_EvaluateFunction_0")] public static extern 
bool EvaluateFunction_0(IntPtr /*(vtkPlane*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ input, IntPtr /*(vtkDataArray*)*/ output);

// double EvaluateFunction(double x[3])
// double EvaluateFunction(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_EvaluateFunction_1")] public static extern 
bool EvaluateFunction_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []x);

// void EvaluateGradient(double x[3], double g[3])
// void EvaluateGradient(double x[3], double g[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_EvaluateGradient_0")] public static extern 
bool EvaluateGradient_0(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []g);

// virtual void SetNormal(double _arg1, double _arg2, double _arg3)
// virtual void SetNormal (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkPlane_SetNormal_0")] public static extern 
bool SetNormal_0(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetNormal(double _arg[3])
// virtual void SetNormal (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_SetNormal_1")] public static extern 
bool SetNormal_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetNormal()
// virtual double *GetNormal ()
[DllImport("vtkplugin", EntryPoint="vtkPlane_GetNormal_0")] public static extern 
bool GetNormal_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject);

// virtual void GetNormal(double data[3])
// virtual void GetNormal (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_GetNormal_1")] public static extern 
bool GetNormal_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
// virtual void SetOrigin (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkPlane_SetOrigin_0")] public static extern 
bool SetOrigin_0(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetOrigin(double _arg[3])
// virtual void SetOrigin (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_SetOrigin_1")] public static extern 
bool SetOrigin_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetOrigin()
// virtual double *GetOrigin ()
[DllImport("vtkplugin", EntryPoint="vtkPlane_GetOrigin_0")] public static extern 
bool GetOrigin_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject);

// virtual void GetOrigin(double data[3])
// virtual void GetOrigin (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_GetOrigin_1")] public static extern 
bool GetOrigin_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []data);

// void Push(double distance)
// void Push(double distance)
[DllImport("vtkplugin", EntryPoint="vtkPlane_Push_0")] public static extern 
bool Push_0(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double)*/ distance);

// static void ProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
// static void ProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_ProjectPoint_0")] public static extern 
bool ProjectPoint_0(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj);

// void ProjectPoint(double x[3], double xproj[3])
// void ProjectPoint(double x[3], double xproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_ProjectPoint_1")] public static extern 
bool ProjectPoint_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []xproj);

// static void ProjectVector(double v[3], double origin[3], double normal[3], double vproj[3])
// static void ProjectVector(double v[3], double origin[3], double normal[3], double vproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_ProjectVector_0")] public static extern 
bool ProjectVector_0(double /*(double[3])*/ []v, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []vproj);

// void ProjectVector(double v[3], double vproj[3])
// void ProjectVector(double v[3], double vproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_ProjectVector_1")] public static extern 
bool ProjectVector_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []v, double /*(double[3])*/ []vproj);

// static void GeneralizedProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
// static void GeneralizedProjectPoint(double x[3], double origin[3], double normal[3], double xproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_GeneralizedProjectPoint_0")] public static extern 
bool GeneralizedProjectPoint_0(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj);

// void GeneralizedProjectPoint(double x[3], double xproj[3])
// void GeneralizedProjectPoint(double x[3], double xproj[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_GeneralizedProjectPoint_1")] public static extern 
bool GeneralizedProjectPoint_1(IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []xproj);

// static double Evaluate(double normal[3], double origin[3], double x[3])
// static double Evaluate(double normal[3], double origin[3], double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_Evaluate_0")] public static extern 
bool Evaluate_0(IntPtr /*(IntPtr*)*/ return_value, double /*(double[3])*/ []normal, double /*(double[3])*/ []origin, double /*(double[3])*/ []x);

// static double DistanceToPlane(double x[3], double n[3], double p0[3])
// static double DistanceToPlane(double x[3], double n[3], double p0[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_DistanceToPlane_0")] public static extern 
bool DistanceToPlane_0(IntPtr /*(IntPtr*)*/ return_value, double /*(double[3])*/ []x, double /*(double[3])*/ []n, double /*(double[3])*/ []p0);

// double DistanceToPlane(double x[3])
// double DistanceToPlane(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_DistanceToPlane_1")] public static extern 
bool DistanceToPlane_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []x);

// static int IntersectWithLine(double p1[3], double p2[3], double n[3], double p0[3], double & t, double x[3])
// static int IntersectWithLine(double p1[3], double p2[3], double n[3], double p0[3], double& t, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_IntersectWithLine_0")] public static extern 
bool IntersectWithLine_0(IntPtr /*(IntPtr*)*/ return_value, double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double[3])*/ []n, double /*(double[3])*/ []p0, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x);

// int IntersectWithLine(double p1[3], double p2[3], double & t, double x[3])
// int IntersectWithLine(double p1[3], double p2[3], double& t, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPlane_IntersectWithLine_1")] public static extern 
bool IntersectWithLine_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPlane*)*/ callingObject, double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x);

}
};
