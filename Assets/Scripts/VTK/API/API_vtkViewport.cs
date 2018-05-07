
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkViewport {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkViewport_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkViewport_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, string /*(char*)*/ type);

// static vtkViewport* SafeDownCast(vtkObjectBase * o)
// static vtkViewport* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkViewport* NewInstance()
// vtkViewport *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkViewport_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// void AddViewProp(vtkProp * ARG_0)
// void AddViewProp(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkViewport_AddViewProp_0")] public static extern 
bool AddViewProp_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// vtkPropCollection* GetViewProps()
// vtkPropCollection *GetViewProps()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetViewProps_0")] public static extern 
bool GetViewProps_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// int HasViewProp(vtkProp * ARG_0)
// int HasViewProp(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkViewport_HasViewProp_0")] public static extern 
bool HasViewProp_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// void RemoveViewProp(vtkProp * ARG_0)
// void RemoveViewProp(vtkProp *)
[DllImport("vtkplugin", EntryPoint="vtkViewport_RemoveViewProp_0")] public static extern 
bool RemoveViewProp_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(vtkProp*)*/ ARG_0);

// void RemoveAllViewProps()
// void RemoveAllViewProps(void)
[DllImport("vtkplugin", EntryPoint="vtkViewport_RemoveAllViewProps_0")] public static extern 
bool RemoveAllViewProps_0(IntPtr /*(vtkViewport*)*/ callingObject);

// void AddActor2D(vtkProp * p)
// void AddActor2D(vtkProp* p)
[DllImport("vtkplugin", EntryPoint="vtkViewport_AddActor2D_0")] public static extern 
bool AddActor2D_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// void RemoveActor2D(vtkProp * p)
// void RemoveActor2D(vtkProp* p)
[DllImport("vtkplugin", EntryPoint="vtkViewport_RemoveActor2D_0")] public static extern 
bool RemoveActor2D_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(vtkProp*)*/ p);

// vtkActor2DCollection* GetActors2D()
// vtkActor2DCollection *GetActors2D()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetActors2D_0")] public static extern 
bool GetActors2D_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void SetBackground(double _arg1, double _arg2, double _arg3)
// virtual void SetBackground (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetBackground_0")] public static extern 
bool SetBackground_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetBackground(double _arg[3])
// virtual void SetBackground (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetBackground_1")] public static extern 
bool SetBackground_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetBackground()
// virtual double *GetBackground ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground_0")] public static extern 
bool GetBackground_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetBackground(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetBackground (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground_1")] public static extern 
bool GetBackground_1(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetBackground(double _arg[3])
// virtual void GetBackground (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground_2")] public static extern 
bool GetBackground_2(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetBackground2(double _arg1, double _arg2, double _arg3)
// virtual void SetBackground2 (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetBackground2_0")] public static extern 
bool SetBackground2_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetBackground2(double _arg[3])
// virtual void SetBackground2 (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetBackground2_1")] public static extern 
bool SetBackground2_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetBackground2()
// virtual double *GetBackground2 ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground2_0")] public static extern 
bool GetBackground2_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetBackground2(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetBackground2 (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground2_1")] public static extern 
bool GetBackground2_1(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetBackground2(double _arg[3])
// virtual void GetBackground2 (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackground2_2")] public static extern 
bool GetBackground2_2(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetBackgroundAlpha(double _arg)
// virtual void SetBackgroundAlpha (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetBackgroundAlpha_0")] public static extern 
bool SetBackgroundAlpha_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetBackgroundAlphaMinValue()
// virtual double GetBackgroundAlphaMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackgroundAlphaMinValue_0")] public static extern 
bool GetBackgroundAlphaMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual double GetBackgroundAlphaMaxValue()
// virtual double GetBackgroundAlphaMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackgroundAlphaMaxValue_0")] public static extern 
bool GetBackgroundAlphaMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual double GetBackgroundAlpha()
// virtual double GetBackgroundAlpha ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetBackgroundAlpha_0")] public static extern 
bool GetBackgroundAlpha_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void SetGradientBackground(bool _arg)
// virtual void SetGradientBackground (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetGradientBackground_0")] public static extern 
bool SetGradientBackground_0(IntPtr /*(vtkViewport*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetGradientBackground()
// virtual bool GetGradientBackground ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetGradientBackground_0")] public static extern 
bool GetGradientBackground_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GradientBackgroundOn()
// virtual void GradientBackgroundOn ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GradientBackgroundOn_0")] public static extern 
bool GradientBackgroundOn_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GradientBackgroundOff()
// virtual void GradientBackgroundOff ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GradientBackgroundOff_0")] public static extern 
bool GradientBackgroundOff_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void SetAspect(double _arg1, double _arg2)
// virtual void SetAspect (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetAspect_0")] public static extern 
bool SetAspect_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetAspect(double _arg[2])
// void SetAspect (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetAspect_1")] public static extern 
bool SetAspect_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetAspect()
// virtual double *GetAspect ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetAspect_0")] public static extern 
bool GetAspect_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetAspect(double data[2])
// virtual void GetAspect (double data[2])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetAspect_1")] public static extern 
bool GetAspect_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[2])*/ []data);

// virtual void ComputeAspect()
// virtual void ComputeAspect()
[DllImport("vtkplugin", EntryPoint="vtkViewport_ComputeAspect_0")] public static extern 
bool ComputeAspect_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void SetPixelAspect(double _arg1, double _arg2)
// virtual void SetPixelAspect (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetPixelAspect_0")] public static extern 
bool SetPixelAspect_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetPixelAspect(double _arg[2])
// void SetPixelAspect (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetPixelAspect_1")] public static extern 
bool SetPixelAspect_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetPixelAspect()
// virtual double *GetPixelAspect ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPixelAspect_0")] public static extern 
bool GetPixelAspect_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetPixelAspect(double data[2])
// virtual void GetPixelAspect (double data[2])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPixelAspect_1")] public static extern 
bool GetPixelAspect_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[2])*/ []data);

// virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetViewport (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetViewport_0")] public static extern 
bool SetViewport_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetViewport(double _arg[4])
// virtual void SetViewport (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetViewport_1")] public static extern 
bool SetViewport_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetViewport()
// virtual double *GetViewport ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetViewport_0")] public static extern 
bool GetViewport_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetViewport(double data[4])
// virtual void GetViewport (double data[4])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetViewport_1")] public static extern 
bool GetViewport_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[4])*/ []data);

// virtual void SetDisplayPoint(double _arg1, double _arg2, double _arg3)
// virtual void SetDisplayPoint (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetDisplayPoint_0")] public static extern 
bool SetDisplayPoint_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetDisplayPoint(double _arg[3])
// virtual void SetDisplayPoint (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetDisplayPoint_1")] public static extern 
bool SetDisplayPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetDisplayPoint()
// virtual double *GetDisplayPoint ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetDisplayPoint_0")] public static extern 
bool GetDisplayPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetDisplayPoint(double data[3])
// virtual void GetDisplayPoint (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetDisplayPoint_1")] public static extern 
bool GetDisplayPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetViewPoint(double _arg1, double _arg2, double _arg3)
// virtual void SetViewPoint (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetViewPoint_0")] public static extern 
bool SetViewPoint_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetViewPoint(double _arg[3])
// virtual void SetViewPoint (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetViewPoint_1")] public static extern 
bool SetViewPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetViewPoint()
// virtual double *GetViewPoint ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetViewPoint_0")] public static extern 
bool GetViewPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetViewPoint(double data[3])
// virtual void GetViewPoint (double data[3])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetViewPoint_1")] public static extern 
bool GetViewPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[3])*/ []data);

// virtual void SetWorldPoint(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetWorldPoint (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetWorldPoint_0")] public static extern 
bool SetWorldPoint_0(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetWorldPoint(double _arg[4])
// virtual void SetWorldPoint (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetWorldPoint_1")] public static extern 
bool SetWorldPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetWorldPoint()
// virtual double *GetWorldPoint ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetWorldPoint_0")] public static extern 
bool GetWorldPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void GetWorldPoint(double data[4])
// virtual void GetWorldPoint (double data[4])
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetWorldPoint_1")] public static extern 
bool GetWorldPoint_1(IntPtr /*(vtkViewport*)*/ callingObject, double /*(double[4])*/ []data);

// virtual double* GetCenter()
// virtual double *GetCenter()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetCenter_0")] public static extern 
bool GetCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual int IsInViewport(int x, int y)
// virtual int IsInViewport(int x,int y)
[DllImport("vtkplugin", EntryPoint="vtkViewport_IsInViewport_0")] public static extern 
bool IsInViewport_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// virtual vtkWindow* GetVTKWindow()
// virtual vtkWindow *GetVTKWindow()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetVTKWindow_0")] public static extern 
bool GetVTKWindow_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void DisplayToView()
// virtual void DisplayToView()
[DllImport("vtkplugin", EntryPoint="vtkViewport_DisplayToView_0")] public static extern 
bool DisplayToView_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void ViewToDisplay()
// virtual void ViewToDisplay()
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewToDisplay_0")] public static extern 
bool ViewToDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void WorldToView()
// virtual void WorldToView()
[DllImport("vtkplugin", EntryPoint="vtkViewport_WorldToView_0")] public static extern 
bool WorldToView_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void ViewToWorld()
// virtual void ViewToWorld()
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewToWorld_0")] public static extern 
bool ViewToWorld_0(IntPtr /*(vtkViewport*)*/ callingObject);

// void DisplayToWorld()
// void DisplayToWorld()
[DllImport("vtkplugin", EntryPoint="vtkViewport_DisplayToWorld_0")] public static extern 
bool DisplayToWorld_0(IntPtr /*(vtkViewport*)*/ callingObject);

// void WorldToDisplay()
// void WorldToDisplay()
[DllImport("vtkplugin", EntryPoint="vtkViewport_WorldToDisplay_0")] public static extern 
bool WorldToDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject);

// virtual void LocalDisplayToDisplay(double & x, double & y)
// virtual void LocalDisplayToDisplay(double &x, double &y)
[DllImport("vtkplugin", EntryPoint="vtkViewport_LocalDisplayToDisplay_0")] public static extern 
bool LocalDisplayToDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y);

// virtual void DisplayToNormalizedDisplay(double & u, double & v)
// virtual void DisplayToNormalizedDisplay(double &u, double &v)
[DllImport("vtkplugin", EntryPoint="vtkViewport_DisplayToNormalizedDisplay_0")] public static extern 
bool DisplayToNormalizedDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v);

// virtual void NormalizedDisplayToViewport(double & x, double & y)
// virtual void NormalizedDisplayToViewport(double &x, double &y)
[DllImport("vtkplugin", EntryPoint="vtkViewport_NormalizedDisplayToViewport_0")] public static extern 
bool NormalizedDisplayToViewport_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y);

// virtual void ViewportToNormalizedViewport(double & u, double & v)
// virtual void ViewportToNormalizedViewport(double &u, double &v)
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewportToNormalizedViewport_0")] public static extern 
bool ViewportToNormalizedViewport_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v);

// virtual void NormalizedViewportToView(double & x, double & y, double & z)
// virtual void NormalizedViewportToView(double &x, double &y, double &z)
[DllImport("vtkplugin", EntryPoint="vtkViewport_NormalizedViewportToView_0")] public static extern 
bool NormalizedViewportToView_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y, IntPtr /*(double&)*/ z);

// virtual void ViewToWorld(double & ARG_0, double & ARG_1, double & ARG_2)
// virtual void ViewToWorld(double &, double &, double &)
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewToWorld_1")] public static extern 
bool ViewToWorld_1(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ ARG_0, IntPtr /*(double&)*/ ARG_1, IntPtr /*(double&)*/ ARG_2);

// virtual void DisplayToLocalDisplay(double & x, double & y)
// virtual void DisplayToLocalDisplay(double &x, double &y)
[DllImport("vtkplugin", EntryPoint="vtkViewport_DisplayToLocalDisplay_0")] public static extern 
bool DisplayToLocalDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y);

// virtual void NormalizedDisplayToDisplay(double & u, double & v)
// virtual void NormalizedDisplayToDisplay(double &u, double &v)
[DllImport("vtkplugin", EntryPoint="vtkViewport_NormalizedDisplayToDisplay_0")] public static extern 
bool NormalizedDisplayToDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v);

// virtual void ViewportToNormalizedDisplay(double & x, double & y)
// virtual void ViewportToNormalizedDisplay(double &x, double &y)
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewportToNormalizedDisplay_0")] public static extern 
bool ViewportToNormalizedDisplay_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y);

// virtual void NormalizedViewportToViewport(double & u, double & v)
// virtual void NormalizedViewportToViewport(double &u, double &v)
[DllImport("vtkplugin", EntryPoint="vtkViewport_NormalizedViewportToViewport_0")] public static extern 
bool NormalizedViewportToViewport_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ u, IntPtr /*(double&)*/ v);

// virtual void ViewToNormalizedViewport(double & x, double & y, double & z)
// virtual void ViewToNormalizedViewport(double &x, double &y, double &z)
[DllImport("vtkplugin", EntryPoint="vtkViewport_ViewToNormalizedViewport_0")] public static extern 
bool ViewToNormalizedViewport_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ x, IntPtr /*(double&)*/ y, IntPtr /*(double&)*/ z);

// virtual void WorldToView(double & ARG_0, double & ARG_1, double & ARG_2)
// virtual void WorldToView(double &, double &, double &)
[DllImport("vtkplugin", EntryPoint="vtkViewport_WorldToView_1")] public static extern 
bool WorldToView_1(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(double&)*/ ARG_0, IntPtr /*(double&)*/ ARG_1, IntPtr /*(double&)*/ ARG_2);

// virtual int* GetSize()
// virtual int *GetSize()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual int* GetOrigin()
// virtual int *GetOrigin()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetOrigin_0")] public static extern 
bool GetOrigin_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// void GetTiledSize(int * width, int * height)
// void GetTiledSize(int *width, int *height)
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetTiledSize_0")] public static extern 
bool GetTiledSize_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(int*)*/ width, IntPtr /*(int*)*/ height);

// virtual void GetTiledSizeAndOrigin(int * width, int * height, int * lowerLeftX, int * lowerLeftY)
// virtual void GetTiledSizeAndOrigin(int *width, int *height, int *lowerLeftX, int *lowerLeftY)
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetTiledSizeAndOrigin_0")] public static extern 
bool GetTiledSizeAndOrigin_0(IntPtr /*(vtkViewport*)*/ callingObject, IntPtr /*(int*)*/ width, IntPtr /*(int*)*/ height, IntPtr /*(int*)*/ lowerLeftX, IntPtr /*(int*)*/ lowerLeftY);

// virtual vtkAssemblyPath* PickProp(double selectionX, double selectionY)
// virtual vtkAssemblyPath* PickProp(double selectionX, double selectionY)
[DllImport("vtkplugin", EntryPoint="vtkViewport_PickProp_0")] public static extern 
bool PickProp_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ selectionX, double /*(double)*/ selectionY);

// virtual vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
// virtual vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
[DllImport("vtkplugin", EntryPoint="vtkViewport_PickProp_1")] public static extern 
bool PickProp_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2);

// vtkAssemblyPath* PickPropFrom(double selectionX, double selectionY, vtkPropCollection * ARG_0)
// vtkAssemblyPath* PickPropFrom(double selectionX, double selectionY, vtkPropCollection*)
[DllImport("vtkplugin", EntryPoint="vtkViewport_PickPropFrom_0")] public static extern 
bool PickPropFrom_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ selectionX, double /*(double)*/ selectionY, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// vtkAssemblyPath* PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection * ARG_0)
// vtkAssemblyPath* PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection*)
[DllImport("vtkplugin", EntryPoint="vtkViewport_PickPropFrom_1")] public static extern 
bool PickPropFrom_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject, double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2, IntPtr /*(vtkPropCollection*)*/ ARG_0);

// double GetPickX()
// double GetPickX()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickX_0")] public static extern 
bool GetPickX_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickY()
// double GetPickY()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickY_0")] public static extern 
bool GetPickY_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickWidth()
// double GetPickWidth()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickWidth_0")] public static extern 
bool GetPickWidth_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickHeight()
// double GetPickHeight()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickHeight_0")] public static extern 
bool GetPickHeight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickX1()
// double GetPickX1()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickX1_0")] public static extern 
bool GetPickX1_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickY1()
// double GetPickY1()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickY1_0")] public static extern 
bool GetPickY1_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickX2()
// double GetPickX2()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickX2_0")] public static extern 
bool GetPickX2_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// double GetPickY2()
// double GetPickY2()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickY2_0")] public static extern 
bool GetPickY2_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual int GetIsPicking()
// virtual int GetIsPicking ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetIsPicking_0")] public static extern 
bool GetIsPicking_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual int GetCurrentPickId()
// virtual unsigned int GetCurrentPickId ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetCurrentPickId_0")] public static extern 
bool GetCurrentPickId_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// void SetCurrentPickId(unsigned int a)
// void SetCurrentPickId(unsigned int a)
[DllImport("vtkplugin", EntryPoint="vtkViewport_SetCurrentPickId_0")] public static extern 
bool SetCurrentPickId_0(IntPtr /*(vtkViewport*)*/ callingObject, uint /*(unsigned int)*/ a);

// virtual vtkPropCollection* GetPickResultProps()
// virtual vtkPropCollection *GetPickResultProps ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickResultProps_0")] public static extern 
bool GetPickResultProps_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

// virtual double GetPickedZ()
// virtual double GetPickedZ()
[DllImport("vtkplugin", EntryPoint="vtkViewport_GetPickedZ_0")] public static extern 
bool GetPickedZ_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkViewport*)*/ callingObject);

}
};
