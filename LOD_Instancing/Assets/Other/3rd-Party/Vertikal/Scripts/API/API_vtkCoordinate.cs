
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCoordinate {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, string /*(char*)*/ type);

// static vtkCoordinate* SafeDownCast(vtkObjectBase * o)
// static vtkCoordinate* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCoordinate* NewInstance()
// vtkCoordinate *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// static vtkCoordinate* New()
// static vtkCoordinate* New()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void SetCoordinateSystem(int _arg)
// virtual void SetCoordinateSystem (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystem_0")] public static extern 
bool SetCoordinateSystem_0(IntPtr /*(vtkCoordinate*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetCoordinateSystem()
// virtual int GetCoordinateSystem ()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetCoordinateSystem_0")] public static extern 
bool GetCoordinateSystem_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToDisplay()
// void SetCoordinateSystemToDisplay()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToDisplay_0")] public static extern 
bool SetCoordinateSystemToDisplay_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToNormalizedDisplay()
// void SetCoordinateSystemToNormalizedDisplay()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToNormalizedDisplay_0")] public static extern 
bool SetCoordinateSystemToNormalizedDisplay_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToViewport()
// void SetCoordinateSystemToViewport()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToViewport_0")] public static extern 
bool SetCoordinateSystemToViewport_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToNormalizedViewport()
// void SetCoordinateSystemToNormalizedViewport()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToNormalizedViewport_0")] public static extern 
bool SetCoordinateSystemToNormalizedViewport_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToView()
// void SetCoordinateSystemToView()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToView_0")] public static extern 
bool SetCoordinateSystemToView_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetCoordinateSystemToWorld()
// void SetCoordinateSystemToWorld()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetCoordinateSystemToWorld_0")] public static extern 
bool SetCoordinateSystemToWorld_0(IntPtr /*(vtkCoordinate*)*/ callingObject);

// char* GetCoordinateSystemAsString()
// const char *GetCoordinateSystemAsString ()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetCoordinateSystemAsString_0")] public static extern 
bool GetCoordinateSystemAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// virtual void SetValue(double _arg1, double _arg2, double _arg3)
// virtual void SetValue (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetValue_0")] public static extern 
bool SetValue_0(IntPtr /*(vtkCoordinate*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetValue(double _arg[3])
// virtual void SetValue (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetValue_1")] public static extern 
bool SetValue_1(IntPtr /*(vtkCoordinate*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetValue()
// virtual double *GetValue ()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetValue_0")] public static extern 
bool GetValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// virtual void GetValue(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetValue (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetValue_1")] public static extern 
bool GetValue_1(IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetValue(double _arg[3])
// virtual void GetValue (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetValue_2")] public static extern 
bool GetValue_2(IntPtr /*(vtkCoordinate*)*/ callingObject, double /*(double[3])*/ []_arg);

// void SetValue(double a, double b)
// void SetValue(double a, double b)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetValue_2")] public static extern 
bool SetValue_2(IntPtr /*(vtkCoordinate*)*/ callingObject, double /*(double)*/ a, double /*(double)*/ b);

// virtual void SetReferenceCoordinate(vtkCoordinate * ARG_0)
// virtual void SetReferenceCoordinate(vtkCoordinate*)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetReferenceCoordinate_0")] public static extern 
bool SetReferenceCoordinate_0(IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkCoordinate*)*/ ARG_0);

// virtual vtkCoordinate* GetReferenceCoordinate()
// virtual vtkCoordinate *GetReferenceCoordinate ()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetReferenceCoordinate_0")] public static extern 
bool GetReferenceCoordinate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// void SetViewport(vtkViewport * viewport)
// void SetViewport(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_SetViewport_0")] public static extern 
bool SetViewport_0(IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// virtual vtkViewport* GetViewport()
// virtual vtkViewport *GetViewport ()
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetViewport_0")] public static extern 
bool GetViewport_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject);

// double* GetComputedWorldValue(vtkViewport * ARG_0)
// double *GetComputedWorldValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedWorldValue_0")] public static extern 
bool GetComputedWorldValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// int* GetComputedViewportValue(vtkViewport * ARG_0)
// int *GetComputedViewportValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedViewportValue_0")] public static extern 
bool GetComputedViewportValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// int* GetComputedDisplayValue(vtkViewport * ARG_0)
// int *GetComputedDisplayValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedDisplayValue_0")] public static extern 
bool GetComputedDisplayValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// int* GetComputedLocalDisplayValue(vtkViewport * ARG_0)
// int *GetComputedLocalDisplayValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedLocalDisplayValue_0")] public static extern 
bool GetComputedLocalDisplayValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// double* GetComputedDoubleViewportValue(vtkViewport * ARG_0)
// double *GetComputedDoubleViewportValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedDoubleViewportValue_0")] public static extern 
bool GetComputedDoubleViewportValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// double* GetComputedDoubleDisplayValue(vtkViewport * ARG_0)
// double *GetComputedDoubleDisplayValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedDoubleDisplayValue_0")] public static extern 
bool GetComputedDoubleDisplayValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// double* GetComputedValue(vtkViewport * ARG_0)
// double *GetComputedValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedValue_0")] public static extern 
bool GetComputedValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

// virtual double* GetComputedUserDefinedValue(vtkViewport * ARG_0)
// virtual double *GetComputedUserDefinedValue(vtkViewport *)
[DllImport("vtkplugin", EntryPoint="vtkCoordinate_GetComputedUserDefinedValue_0")] public static extern 
bool GetComputedUserDefinedValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCoordinate*)*/ callingObject, IntPtr /*(vtkViewport*)*/ ARG_0);

}
};
