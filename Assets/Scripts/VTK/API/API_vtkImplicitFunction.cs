
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkImplicitFunction {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, string /*(char*)*/ type);

// static vtkImplicitFunction* SafeDownCast(vtkObjectBase * o)
// static vtkImplicitFunction* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkImplicitFunction* NewInstance()
// vtkImplicitFunction *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject);

// virtual void FunctionValue(vtkDataArray * input, vtkDataArray * output)
// virtual void FunctionValue(vtkDataArray* input, vtkDataArray* output)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionValue_0")] public static extern 
bool FunctionValue_0(IntPtr /*(vtkImplicitFunction*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ input, IntPtr /*(vtkDataArray*)*/ output);

// double FunctionValue(const double x[3])
// double FunctionValue(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionValue_1")] public static extern 
bool FunctionValue_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[3])*/ []x);

// double FunctionValue(double x, double y, double z)
// double FunctionValue(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionValue_2")] public static extern 
bool FunctionValue_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void FunctionGradient(const double x[3], double g[3])
// void FunctionGradient(const double x[3], double g[3])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionGradient_0")] public static extern 
bool FunctionGradient_0(IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []g);

// double* FunctionGradient(const double x[3])
// double *FunctionGradient(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionGradient_1")] public static extern 
bool FunctionGradient_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[3])*/ []x);

// double* FunctionGradient(double x, double y, double z)
// double *FunctionGradient(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_FunctionGradient_2")] public static extern 
bool FunctionGradient_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual void SetTransform(vtkAbstractTransform * ARG_0)
// virtual void SetTransform(vtkAbstractTransform*)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_SetTransform_0")] public static extern 
bool SetTransform_0(IntPtr /*(vtkImplicitFunction*)*/ callingObject, IntPtr /*(vtkAbstractTransform*)*/ ARG_0);

// virtual void SetTransform(const double elements[16])
// virtual void SetTransform(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_SetTransform_1")] public static extern 
bool SetTransform_1(IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[16])*/ []elements);

// virtual vtkAbstractTransform* GetTransform()
// virtual vtkAbstractTransform *GetTransform ()
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_GetTransform_0")] public static extern 
bool GetTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject);

// virtual double EvaluateFunction(double x[3])
// virtual double EvaluateFunction(double x[3])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_EvaluateFunction_0")] public static extern 
bool EvaluateFunction_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[3])*/ []x);

// virtual void EvaluateFunction(vtkDataArray * input, vtkDataArray * output)
// virtual void EvaluateFunction(vtkDataArray* input, vtkDataArray* output)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_EvaluateFunction_1")] public static extern 
bool EvaluateFunction_1(IntPtr /*(vtkImplicitFunction*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ input, IntPtr /*(vtkDataArray*)*/ output);

// virtual double EvaluateFunction(double x, double y, double z)
// virtual double EvaluateFunction(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_EvaluateFunction_2")] public static extern 
bool EvaluateFunction_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// virtual void EvaluateGradient(double x[3], double g[3])
// virtual void EvaluateGradient(double x[3], double g[3])
[DllImport("vtkplugin", EntryPoint="vtkImplicitFunction_EvaluateGradient_0")] public static extern 
bool EvaluateGradient_0(IntPtr /*(vtkImplicitFunction*)*/ callingObject, double /*(double[3])*/ []x, double /*(double[3])*/ []g);

}
};
