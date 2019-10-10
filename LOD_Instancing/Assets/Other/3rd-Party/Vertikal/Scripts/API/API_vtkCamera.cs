
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCamera {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCamera_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCamera_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject, string /*(char*)*/ type);

// static vtkCamera* SafeDownCast(vtkObjectBase * o)
// static vtkCamera* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCamera* NewInstance()
// vtkCamera *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCamera_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// static vtkCamera* New()
// static vtkCamera *New()
[DllImport("vtkplugin", EntryPoint="vtkCamera_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// void SetPosition(double x, double y, double z)
// void SetPosition(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetPosition_0")] public static extern 
bool SetPosition_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetPosition(const double a[3])
// void SetPosition(const double a[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetPosition_1")] public static extern 
bool SetPosition_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []a);

// virtual double* GetPosition()
// virtual double *GetPosition ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetPosition(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetPosition (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetPosition_1")] public static extern 
bool GetPosition_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetPosition(double _arg[3])
// virtual void GetPosition (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetPosition_2")] public static extern 
bool GetPosition_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// void SetFocalPoint(double x, double y, double z)
// void SetFocalPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetFocalPoint_0")] public static extern 
bool SetFocalPoint_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetFocalPoint(const double a[3])
// void SetFocalPoint(const double a[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetFocalPoint_1")] public static extern 
bool SetFocalPoint_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []a);

// virtual double* GetFocalPoint()
// virtual double *GetFocalPoint ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFocalPoint_0")] public static extern 
bool GetFocalPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetFocalPoint(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetFocalPoint (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFocalPoint_1")] public static extern 
bool GetFocalPoint_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetFocalPoint(double _arg[3])
// virtual void GetFocalPoint (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFocalPoint_2")] public static extern 
bool GetFocalPoint_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// void SetViewUp(double vx, double vy, double vz)
// void SetViewUp(double vx, double vy, double vz)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetViewUp_0")] public static extern 
bool SetViewUp_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ vx, double /*(double)*/ vy, double /*(double)*/ vz);

// void SetViewUp(const double a[3])
// void SetViewUp(const double a[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetViewUp_1")] public static extern 
bool SetViewUp_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []a);

// virtual double* GetViewUp()
// virtual double *GetViewUp ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewUp_0")] public static extern 
bool GetViewUp_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetViewUp(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetViewUp (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewUp_1")] public static extern 
bool GetViewUp_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetViewUp(double _arg[3])
// virtual void GetViewUp (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewUp_2")] public static extern 
bool GetViewUp_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// void OrthogonalizeViewUp()
// void OrthogonalizeViewUp()
[DllImport("vtkplugin", EntryPoint="vtkCamera_OrthogonalizeViewUp_0")] public static extern 
bool OrthogonalizeViewUp_0(IntPtr /*(vtkCamera*)*/ callingObject);

// void SetDistance(double ARG_0)
// void SetDistance(double)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetDistance_0")] public static extern 
bool SetDistance_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ ARG_0);

// virtual double GetDistance()
// virtual double GetDistance ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetDistance_0")] public static extern 
bool GetDistance_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual double* GetDirectionOfProjection()
// virtual double *GetDirectionOfProjection ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetDirectionOfProjection_0")] public static extern 
bool GetDirectionOfProjection_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetDirectionOfProjection(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetDirectionOfProjection (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetDirectionOfProjection_1")] public static extern 
bool GetDirectionOfProjection_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetDirectionOfProjection(double _arg[3])
// virtual void GetDirectionOfProjection (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetDirectionOfProjection_2")] public static extern 
bool GetDirectionOfProjection_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// void Dolly(double value)
// void Dolly(double value)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Dolly_0")] public static extern 
bool Dolly_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ value);

// void SetRoll(double angle)
// void SetRoll(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetRoll_0")] public static extern 
bool SetRoll_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// double GetRoll()
// double GetRoll()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetRoll_0")] public static extern 
bool GetRoll_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void Roll(double angle)
// void Roll(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Roll_0")] public static extern 
bool Roll_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// void Azimuth(double angle)
// void Azimuth(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Azimuth_0")] public static extern 
bool Azimuth_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// void Yaw(double angle)
// void Yaw(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Yaw_0")] public static extern 
bool Yaw_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// void Elevation(double angle)
// void Elevation(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Elevation_0")] public static extern 
bool Elevation_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// void Pitch(double angle)
// void Pitch(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Pitch_0")] public static extern 
bool Pitch_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// void SetParallelProjection(int flag)
// void SetParallelProjection(int flag)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetParallelProjection_0")] public static extern 
bool SetParallelProjection_0(IntPtr /*(vtkCamera*)*/ callingObject, int /*(int)*/ flag);

// virtual int GetParallelProjection()
// virtual int GetParallelProjection ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetParallelProjection_0")] public static extern 
bool GetParallelProjection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void ParallelProjectionOn()
// virtual void ParallelProjectionOn ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_ParallelProjectionOn_0")] public static extern 
bool ParallelProjectionOn_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void ParallelProjectionOff()
// virtual void ParallelProjectionOff ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_ParallelProjectionOff_0")] public static extern 
bool ParallelProjectionOff_0(IntPtr /*(vtkCamera*)*/ callingObject);

// void SetUseHorizontalViewAngle(int flag)
// void SetUseHorizontalViewAngle(int flag)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUseHorizontalViewAngle_0")] public static extern 
bool SetUseHorizontalViewAngle_0(IntPtr /*(vtkCamera*)*/ callingObject, int /*(int)*/ flag);

// virtual int GetUseHorizontalViewAngle()
// virtual int GetUseHorizontalViewAngle ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUseHorizontalViewAngle_0")] public static extern 
bool GetUseHorizontalViewAngle_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseHorizontalViewAngleOn()
// virtual void UseHorizontalViewAngleOn ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseHorizontalViewAngleOn_0")] public static extern 
bool UseHorizontalViewAngleOn_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseHorizontalViewAngleOff()
// virtual void UseHorizontalViewAngleOff ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseHorizontalViewAngleOff_0")] public static extern 
bool UseHorizontalViewAngleOff_0(IntPtr /*(vtkCamera*)*/ callingObject);

// void SetViewAngle(double angle)
// void SetViewAngle(double angle)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetViewAngle_0")] public static extern 
bool SetViewAngle_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ angle);

// virtual double GetViewAngle()
// virtual double GetViewAngle ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewAngle_0")] public static extern 
bool GetViewAngle_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetParallelScale(double scale)
// void SetParallelScale(double scale)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetParallelScale_0")] public static extern 
bool SetParallelScale_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ scale);

// virtual double GetParallelScale()
// virtual double GetParallelScale ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetParallelScale_0")] public static extern 
bool GetParallelScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void Zoom(double factor)
// void Zoom(double factor)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Zoom_0")] public static extern 
bool Zoom_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ factor);

// void SetClippingRange(double dNear, double dFar)
// void SetClippingRange(double dNear, double dFar)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetClippingRange_0")] public static extern 
bool SetClippingRange_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ dNear, double /*(double)*/ dFar);

// void SetClippingRange(const double a[2])
// void SetClippingRange(const double a[2])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetClippingRange_1")] public static extern 
bool SetClippingRange_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[2])*/ []a);

// virtual double* GetClippingRange()
// virtual double *GetClippingRange ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetClippingRange_0")] public static extern 
bool GetClippingRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetClippingRange(double & _arg1, double & _arg2)
// virtual void GetClippingRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetClippingRange_1")] public static extern 
bool GetClippingRange_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetClippingRange(double _arg[2])
// virtual void GetClippingRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetClippingRange_2")] public static extern 
bool GetClippingRange_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[2])*/ []_arg);

// void SetThickness(double ARG_0)
// void SetThickness(double)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetThickness_0")] public static extern 
bool SetThickness_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ ARG_0);

// virtual double GetThickness()
// virtual double GetThickness ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetThickness_0")] public static extern 
bool GetThickness_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetWindowCenter(double x, double y)
// void SetWindowCenter(double x, double y)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetWindowCenter_0")] public static extern 
bool SetWindowCenter_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y);

// virtual double* GetWindowCenter()
// virtual double *GetWindowCenter ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetWindowCenter_0")] public static extern 
bool GetWindowCenter_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetWindowCenter(double & _arg1, double & _arg2)
// virtual void GetWindowCenter (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetWindowCenter_1")] public static extern 
bool GetWindowCenter_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetWindowCenter(double _arg[2])
// virtual void GetWindowCenter (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetWindowCenter_2")] public static extern 
bool GetWindowCenter_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[2])*/ []_arg);

// void SetObliqueAngles(double alpha, double beta)
// void SetObliqueAngles(double alpha, double beta)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetObliqueAngles_0")] public static extern 
bool SetObliqueAngles_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ alpha, double /*(double)*/ beta);

// void ApplyTransform(vtkTransform * t)
// void ApplyTransform(vtkTransform *t)
[DllImport("vtkplugin", EntryPoint="vtkCamera_ApplyTransform_0")] public static extern 
bool ApplyTransform_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkTransform*)*/ t);

// virtual double* GetViewPlaneNormal()
// virtual double *GetViewPlaneNormal ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewPlaneNormal_0")] public static extern 
bool GetViewPlaneNormal_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetViewPlaneNormal(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetViewPlaneNormal (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewPlaneNormal_1")] public static extern 
bool GetViewPlaneNormal_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetViewPlaneNormal(double _arg[3])
// virtual void GetViewPlaneNormal (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewPlaneNormal_2")] public static extern 
bool GetViewPlaneNormal_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// void SetViewShear(double dxdz, double dydz, double center)
// void SetViewShear(double dxdz, double dydz, double center)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetViewShear_0")] public static extern 
bool SetViewShear_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ dxdz, double /*(double)*/ dydz, double /*(double)*/ center);

// void SetViewShear(double d[3])
// void SetViewShear(double d[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetViewShear_1")] public static extern 
bool SetViewShear_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []d);

// virtual double* GetViewShear()
// virtual double *GetViewShear ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewShear_0")] public static extern 
bool GetViewShear_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetViewShear(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetViewShear (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewShear_1")] public static extern 
bool GetViewShear_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetViewShear(double _arg[3])
// virtual void GetViewShear (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewShear_2")] public static extern 
bool GetViewShear_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetEyeAngle(double _arg)
// virtual void SetEyeAngle (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetEyeAngle_0")] public static extern 
bool SetEyeAngle_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetEyeAngle()
// virtual double GetEyeAngle ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetEyeAngle_0")] public static extern 
bool GetEyeAngle_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetFocalDisk(double _arg)
// virtual void SetFocalDisk (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetFocalDisk_0")] public static extern 
bool SetFocalDisk_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetFocalDisk()
// virtual double GetFocalDisk ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFocalDisk_0")] public static extern 
bool GetFocalDisk_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetUseOffAxisProjection(int _arg)
// virtual void SetUseOffAxisProjection (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUseOffAxisProjection_0")] public static extern 
bool SetUseOffAxisProjection_0(IntPtr /*(vtkCamera*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseOffAxisProjection()
// virtual int GetUseOffAxisProjection ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUseOffAxisProjection_0")] public static extern 
bool GetUseOffAxisProjection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseOffAxisProjectionOn()
// virtual void UseOffAxisProjectionOn ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseOffAxisProjectionOn_0")] public static extern 
bool UseOffAxisProjectionOn_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseOffAxisProjectionOff()
// virtual void UseOffAxisProjectionOff ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseOffAxisProjectionOff_0")] public static extern 
bool UseOffAxisProjectionOff_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetScreenBottomLeft(double _arg1, double _arg2, double _arg3)
// virtual void SetScreenBottomLeft (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenBottomLeft_0")] public static extern 
bool SetScreenBottomLeft_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetScreenBottomLeft(double _arg[3])
// virtual void SetScreenBottomLeft (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenBottomLeft_1")] public static extern 
bool SetScreenBottomLeft_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetScreenBottomLeft()
// virtual double *GetScreenBottomLeft ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomLeft_0")] public static extern 
bool GetScreenBottomLeft_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetScreenBottomLeft(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetScreenBottomLeft (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomLeft_1")] public static extern 
bool GetScreenBottomLeft_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetScreenBottomLeft(double _arg[3])
// virtual void GetScreenBottomLeft (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomLeft_2")] public static extern 
bool GetScreenBottomLeft_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetScreenBottomRight(double _arg1, double _arg2, double _arg3)
// virtual void SetScreenBottomRight (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenBottomRight_0")] public static extern 
bool SetScreenBottomRight_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetScreenBottomRight(double _arg[3])
// virtual void SetScreenBottomRight (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenBottomRight_1")] public static extern 
bool SetScreenBottomRight_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetScreenBottomRight()
// virtual double *GetScreenBottomRight ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomRight_0")] public static extern 
bool GetScreenBottomRight_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetScreenBottomRight(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetScreenBottomRight (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomRight_1")] public static extern 
bool GetScreenBottomRight_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetScreenBottomRight(double _arg[3])
// virtual void GetScreenBottomRight (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenBottomRight_2")] public static extern 
bool GetScreenBottomRight_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetScreenTopRight(double _arg1, double _arg2, double _arg3)
// virtual void SetScreenTopRight (double _arg1, double _arg2, double _arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenTopRight_0")] public static extern 
bool SetScreenTopRight_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3);

// virtual void SetScreenTopRight(double _arg[3])
// virtual void SetScreenTopRight (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetScreenTopRight_1")] public static extern 
bool SetScreenTopRight_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual double* GetScreenTopRight()
// virtual double *GetScreenTopRight ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenTopRight_0")] public static extern 
bool GetScreenTopRight_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetScreenTopRight(double & _arg1, double & _arg2, double & _arg3)
// virtual void GetScreenTopRight (double &_arg1, double &_arg2, double &_arg3)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenTopRight_1")] public static extern 
bool GetScreenTopRight_1(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3);

// virtual void GetScreenTopRight(double _arg[3])
// virtual void GetScreenTopRight (double _arg[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetScreenTopRight_2")] public static extern 
bool GetScreenTopRight_2(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []_arg);

// virtual void SetEyeSeparation(double _arg)
// virtual void SetEyeSeparation (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetEyeSeparation_0")] public static extern 
bool SetEyeSeparation_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetEyeSeparation()
// virtual double GetEyeSeparation ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetEyeSeparation_0")] public static extern 
bool GetEyeSeparation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetEyePosition(double eyePosition[3])
// void SetEyePosition(double eyePosition[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetEyePosition_0")] public static extern 
bool SetEyePosition_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []eyePosition);

// void GetEyePosition(double eyePosition[3])
// void GetEyePosition(double eyePosition[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetEyePosition_0")] public static extern 
bool GetEyePosition_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []eyePosition);

// void GetEyePlaneNormal(double normal[3])
// void GetEyePlaneNormal(double normal[3])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetEyePlaneNormal_0")] public static extern 
bool GetEyePlaneNormal_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[3])*/ []normal);

// void SetEyeTransformMatrix(vtkMatrix4x4 * matrix)
// void SetEyeTransformMatrix(vtkMatrix4x4* matrix)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetEyeTransformMatrix_0")] public static extern 
bool SetEyeTransformMatrix_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// virtual vtkMatrix4x4* GetEyeTransformMatrix()
// virtual vtkMatrix4x4 *GetEyeTransformMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetEyeTransformMatrix_0")] public static extern 
bool GetEyeTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetEyeTransformMatrix(const double elements[16])
// void SetEyeTransformMatrix(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetEyeTransformMatrix_1")] public static extern 
bool SetEyeTransformMatrix_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[16])*/ []elements);

// void SetModelTransformMatrix(vtkMatrix4x4 * matrix)
// void SetModelTransformMatrix(vtkMatrix4x4 *matrix)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetModelTransformMatrix_0")] public static extern 
bool SetModelTransformMatrix_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ matrix);

// virtual vtkMatrix4x4* GetModelTransformMatrix()
// virtual vtkMatrix4x4 *GetModelTransformMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetModelTransformMatrix_0")] public static extern 
bool GetModelTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetModelTransformMatrix(const double elements[16])
// void SetModelTransformMatrix(const double elements[16])
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetModelTransformMatrix_1")] public static extern 
bool SetModelTransformMatrix_1(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double[16])*/ []elements);

// virtual vtkMatrix4x4* GetModelViewTransformMatrix()
// virtual vtkMatrix4x4 *GetModelViewTransformMatrix()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetModelViewTransformMatrix_0")] public static extern 
bool GetModelViewTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual vtkTransform* GetModelViewTransformObject()
// virtual vtkTransform *GetModelViewTransformObject()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetModelViewTransformObject_0")] public static extern 
bool GetModelViewTransformObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual vtkMatrix4x4* GetViewTransformMatrix()
// virtual vtkMatrix4x4 *GetViewTransformMatrix()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewTransformMatrix_0")] public static extern 
bool GetViewTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual vtkTransform* GetViewTransformObject()
// virtual vtkTransform *GetViewTransformObject()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewTransformObject_0")] public static extern 
bool GetViewTransformObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4 * ARG_0)
// virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4*)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetExplicitProjectionTransformMatrix_0")] public static extern 
bool SetExplicitProjectionTransformMatrix_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkMatrix4x4*)*/ ARG_0);

// virtual vtkMatrix4x4* GetExplicitProjectionTransformMatrix()
// virtual vtkMatrix4x4 *GetExplicitProjectionTransformMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetExplicitProjectionTransformMatrix_0")] public static extern 
bool GetExplicitProjectionTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetUseExplicitProjectionTransformMatrix(bool _arg)
// virtual void SetUseExplicitProjectionTransformMatrix (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUseExplicitProjectionTransformMatrix_0")] public static extern 
bool SetUseExplicitProjectionTransformMatrix_0(IntPtr /*(vtkCamera*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseExplicitProjectionTransformMatrix()
// virtual bool GetUseExplicitProjectionTransformMatrix ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUseExplicitProjectionTransformMatrix_0")] public static extern 
bool GetUseExplicitProjectionTransformMatrix_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseExplicitProjectionTransformMatrixOn()
// virtual void UseExplicitProjectionTransformMatrixOn ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseExplicitProjectionTransformMatrixOn_0")] public static extern 
bool UseExplicitProjectionTransformMatrixOn_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UseExplicitProjectionTransformMatrixOff()
// virtual void UseExplicitProjectionTransformMatrixOff ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_UseExplicitProjectionTransformMatrixOff_0")] public static extern 
bool UseExplicitProjectionTransformMatrixOff_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual vtkMatrix4x4* GetProjectionTransformMatrix(double aspect, double nearz, double farz)
// virtual vtkMatrix4x4 *GetProjectionTransformMatrix(double aspect, double nearz, double farz)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetProjectionTransformMatrix_0")] public static extern 
bool GetProjectionTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz);

// virtual vtkPerspectiveTransform* GetProjectionTransformObject(double aspect, double nearz, double farz)
// virtual vtkPerspectiveTransform *GetProjectionTransformObject(double aspect, double nearz, double farz)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetProjectionTransformObject_0")] public static extern 
bool GetProjectionTransformObject_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz);

// virtual vtkMatrix4x4* GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
// virtual vtkMatrix4x4 *GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetCompositeProjectionTransformMatrix_0")] public static extern 
bool GetCompositeProjectionTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz);

// virtual vtkMatrix4x4* GetProjectionTransformMatrix(vtkRenderer * ren)
// virtual vtkMatrix4x4 *GetProjectionTransformMatrix(vtkRenderer *ren)
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetProjectionTransformMatrix_1")] public static extern 
bool GetProjectionTransformMatrix_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren);

// void SetUserViewTransform(vtkHomogeneousTransform * transform)
// void SetUserViewTransform(vtkHomogeneousTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUserViewTransform_0")] public static extern 
bool SetUserViewTransform_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkHomogeneousTransform*)*/ transform);

// virtual vtkHomogeneousTransform* GetUserViewTransform()
// virtual vtkHomogeneousTransform *GetUserViewTransform ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUserViewTransform_0")] public static extern 
bool GetUserViewTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void SetUserTransform(vtkHomogeneousTransform * transform)
// void SetUserTransform(vtkHomogeneousTransform *transform)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUserTransform_0")] public static extern 
bool SetUserTransform_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkHomogeneousTransform*)*/ transform);

// virtual vtkHomogeneousTransform* GetUserTransform()
// virtual vtkHomogeneousTransform *GetUserTransform ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUserTransform_0")] public static extern 
bool GetUserTransform_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void Render(vtkRenderer * ARG_0)
// virtual void Render(vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkCamera_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// vtkMTimeType GetViewingRaysMTime()
// vtkMTimeType GetViewingRaysMTime()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetViewingRaysMTime_0")] public static extern 
bool GetViewingRaysMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void ViewingRaysModified()
// void ViewingRaysModified()
[DllImport("vtkplugin", EntryPoint="vtkCamera_ViewingRaysModified_0")] public static extern 
bool ViewingRaysModified_0(IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void GetFrustumPlanes(double aspect, double planes[24])
// virtual void GetFrustumPlanes(double aspect, double planes[24])
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFrustumPlanes_0")] public static extern 
bool GetFrustumPlanes_0(IntPtr /*(vtkCamera*)*/ callingObject, double /*(double)*/ aspect, double /*(double[24])*/ []planes);

// double* GetOrientation()
// double *GetOrientation()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetOrientation_0")] public static extern 
bool GetOrientation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// double* GetOrientationWXYZ()
// double *GetOrientationWXYZ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetOrientationWXYZ_0")] public static extern 
bool GetOrientationWXYZ_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void ComputeViewPlaneNormal()
// void ComputeViewPlaneNormal()
[DllImport("vtkplugin", EntryPoint="vtkCamera_ComputeViewPlaneNormal_0")] public static extern 
bool ComputeViewPlaneNormal_0(IntPtr /*(vtkCamera*)*/ callingObject);

// vtkMatrix4x4* GetCameraLightTransformMatrix()
// vtkMatrix4x4 *GetCameraLightTransformMatrix()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetCameraLightTransformMatrix_0")] public static extern 
bool GetCameraLightTransformMatrix_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void UpdateViewport(vtkRenderer * ARG_0)
// virtual void UpdateViewport(vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkCamera_UpdateViewport_0")] public static extern 
bool UpdateViewport_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// virtual void SetLeftEye(int _arg)
// virtual void SetLeftEye (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetLeftEye_0")] public static extern 
bool SetLeftEye_0(IntPtr /*(vtkCamera*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLeftEye()
// virtual int GetLeftEye ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetLeftEye_0")] public static extern 
bool GetLeftEye_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// void ShallowCopy(vtkCamera * source)
// void ShallowCopy(vtkCamera *source)
[DllImport("vtkplugin", EntryPoint="vtkCamera_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkCamera*)*/ source);

// void DeepCopy(vtkCamera * source)
// void DeepCopy(vtkCamera *source)
[DllImport("vtkplugin", EntryPoint="vtkCamera_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkCamera*)*/ callingObject, IntPtr /*(vtkCamera*)*/ source);

// virtual void SetFreezeFocalPoint(bool _arg)
// virtual void SetFreezeFocalPoint (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetFreezeFocalPoint_0")] public static extern 
bool SetFreezeFocalPoint_0(IntPtr /*(vtkCamera*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetFreezeFocalPoint()
// virtual bool GetFreezeFocalPoint ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetFreezeFocalPoint_0")] public static extern 
bool GetFreezeFocalPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

// virtual void SetUseScissor(bool _arg)
// virtual void SetUseScissor (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkCamera_SetUseScissor_0")] public static extern 
bool SetUseScissor_0(IntPtr /*(vtkCamera*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseScissor()
// virtual bool GetUseScissor ()
[DllImport("vtkplugin", EntryPoint="vtkCamera_GetUseScissor_0")] public static extern 
bool GetUseScissor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkCamera*)*/ callingObject);

}
};
