
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRenderWindowInteractor {

// static vtkRenderWindowInteractor* New()
// static vtkRenderWindowInteractor *New()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, string /*(char*)*/ type);

// static vtkRenderWindowInteractor* SafeDownCast(vtkObjectBase * o)
// static vtkRenderWindowInteractor* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRenderWindowInteractor* NewInstance()
// vtkRenderWindowInteractor *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void ReInitialize()
// void ReInitialize()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ReInitialize_0")] public static extern 
bool ReInitialize_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// virtual void Start()
// virtual void Start()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_Start_0")] public static extern 
bool Start_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void Enable()
// virtual void Enable()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_Enable_0")] public static extern 
bool Enable_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void Disable()
// virtual void Disable()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_Disable_0")] public static extern 
bool Disable_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int GetEnabled()
// virtual int GetEnabled ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEnabled_0")] public static extern 
bool GetEnabled_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EnableRenderOn()
// virtual void EnableRenderOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EnableRenderOn_0")] public static extern 
bool EnableRenderOn_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EnableRenderOff()
// virtual void EnableRenderOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EnableRenderOff_0")] public static extern 
bool EnableRenderOff_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetEnableRender(bool _arg)
// virtual void SetEnableRender (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEnableRender_0")] public static extern 
bool SetEnableRender_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetEnableRender()
// virtual bool GetEnableRender ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEnableRender_0")] public static extern 
bool GetEnableRender_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void SetRenderWindow(vtkRenderWindow * aren)
// void SetRenderWindow(vtkRenderWindow *aren)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetRenderWindow_0")] public static extern 
bool SetRenderWindow_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkRenderWindow*)*/ aren);

// virtual vtkRenderWindow* GetRenderWindow()
// virtual vtkRenderWindow *GetRenderWindow ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetRenderWindow_0")] public static extern 
bool GetRenderWindow_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void UpdateSize(int x, int y)
// virtual void UpdateSize(int x,int y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_UpdateSize_0")] public static extern 
bool UpdateSize_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// virtual int CreateTimer(int timerType)
// virtual int CreateTimer(int timerType)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_CreateTimer_0")] public static extern 
bool CreateTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ timerType);

// virtual int DestroyTimer()
// virtual int DestroyTimer()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_DestroyTimer_0")] public static extern 
bool DestroyTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// int CreateRepeatingTimer(unsigned long duration)
// int CreateRepeatingTimer(unsigned long duration)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_CreateRepeatingTimer_0")] public static extern 
bool CreateRepeatingTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(unsigned long)*/ duration);

// int CreateOneShotTimer(unsigned long duration)
// int CreateOneShotTimer(unsigned long duration)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_CreateOneShotTimer_0")] public static extern 
bool CreateOneShotTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(unsigned long)*/ duration);

// int IsOneShotTimer(int timerId)
// int IsOneShotTimer(int timerId)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_IsOneShotTimer_0")] public static extern 
bool IsOneShotTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ timerId);

// long GetTimerDuration(int timerId)
// unsigned long GetTimerDuration(int timerId)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerDuration_0")] public static extern 
bool GetTimerDuration_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ timerId);

// int ResetTimer(int timerId)
// int ResetTimer(int timerId)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ResetTimer_0")] public static extern 
bool ResetTimer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ timerId);

// int DestroyTimer(int timerId)
// int DestroyTimer(int timerId)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_DestroyTimer_1")] public static extern 
bool DestroyTimer_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ timerId);

// virtual int GetVTKTimerId(int platformTimerId)
// virtual int GetVTKTimerId(int platformTimerId)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetVTKTimerId_0")] public static extern 
bool GetVTKTimerId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ platformTimerId);

// virtual void SetTimerDuration(unsigned long _arg)
// virtual void SetTimerDuration (unsigned long _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTimerDuration_0")] public static extern 
bool SetTimerDuration_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(unsigned long)*/ _arg);

// virtual long GetTimerDurationMinValue()
// virtual unsigned long GetTimerDurationMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerDurationMinValue_0")] public static extern 
bool GetTimerDurationMinValue_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual long GetTimerDurationMaxValue()
// virtual unsigned long GetTimerDurationMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerDurationMaxValue_0")] public static extern 
bool GetTimerDurationMaxValue_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual long GetTimerDuration()
// virtual unsigned long GetTimerDuration ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerDuration_1")] public static extern 
bool GetTimerDuration_1(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetTimerEventId(int _arg)
// virtual void SetTimerEventId (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTimerEventId_0")] public static extern 
bool SetTimerEventId_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTimerEventId()
// virtual int GetTimerEventId ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerEventId_0")] public static extern 
bool GetTimerEventId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetTimerEventType(int _arg)
// virtual void SetTimerEventType (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTimerEventType_0")] public static extern 
bool SetTimerEventType_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTimerEventType()
// virtual int GetTimerEventType ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerEventType_0")] public static extern 
bool GetTimerEventType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetTimerEventDuration(int _arg)
// virtual void SetTimerEventDuration (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTimerEventDuration_0")] public static extern 
bool SetTimerEventDuration_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTimerEventDuration()
// virtual int GetTimerEventDuration ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerEventDuration_0")] public static extern 
bool GetTimerEventDuration_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetTimerEventPlatformId(int _arg)
// virtual void SetTimerEventPlatformId (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTimerEventPlatformId_0")] public static extern 
bool SetTimerEventPlatformId_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetTimerEventPlatformId()
// virtual int GetTimerEventPlatformId ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTimerEventPlatformId_0")] public static extern 
bool GetTimerEventPlatformId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void TerminateApp()
// virtual void TerminateApp(void)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_TerminateApp_0")] public static extern 
bool TerminateApp_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetInteractorStyle(vtkInteractorObserver * ARG_0)
// virtual void SetInteractorStyle(vtkInteractorObserver *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetInteractorStyle_0")] public static extern 
bool SetInteractorStyle_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkInteractorObserver*)*/ ARG_0);

// virtual vtkInteractorObserver* GetInteractorStyle()
// virtual vtkInteractorObserver *GetInteractorStyle ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetInteractorStyle_0")] public static extern 
bool GetInteractorStyle_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetLightFollowCamera(int _arg)
// virtual void SetLightFollowCamera (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetLightFollowCamera_0")] public static extern 
bool SetLightFollowCamera_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLightFollowCamera()
// virtual int GetLightFollowCamera ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLightFollowCamera_0")] public static extern 
bool GetLightFollowCamera_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LightFollowCameraOn()
// virtual void LightFollowCameraOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LightFollowCameraOn_0")] public static extern 
bool LightFollowCameraOn_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LightFollowCameraOff()
// virtual void LightFollowCameraOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LightFollowCameraOff_0")] public static extern 
bool LightFollowCameraOff_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetDesiredUpdateRate(double _arg)
// virtual void SetDesiredUpdateRate (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetDesiredUpdateRate_0")] public static extern 
bool SetDesiredUpdateRate_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetDesiredUpdateRateMinValue()
// virtual double GetDesiredUpdateRateMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_0")] public static extern 
bool GetDesiredUpdateRateMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetDesiredUpdateRateMaxValue()
// virtual double GetDesiredUpdateRateMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_0")] public static extern 
bool GetDesiredUpdateRateMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetDesiredUpdateRate()
// virtual double GetDesiredUpdateRate ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetDesiredUpdateRate_0")] public static extern 
bool GetDesiredUpdateRate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetStillUpdateRate(double _arg)
// virtual void SetStillUpdateRate (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetStillUpdateRate_0")] public static extern 
bool SetStillUpdateRate_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetStillUpdateRateMinValue()
// virtual double GetStillUpdateRateMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetStillUpdateRateMinValue_0")] public static extern 
bool GetStillUpdateRateMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetStillUpdateRateMaxValue()
// virtual double GetStillUpdateRateMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_0")] public static extern 
bool GetStillUpdateRateMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetStillUpdateRate()
// virtual double GetStillUpdateRate ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetStillUpdateRate_0")] public static extern 
bool GetStillUpdateRate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int GetInitialized()
// virtual int GetInitialized ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetInitialized_0")] public static extern 
bool GetInitialized_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetPicker(vtkAbstractPicker * ARG_0)
// virtual void SetPicker(vtkAbstractPicker*)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetPicker_0")] public static extern 
bool SetPicker_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkAbstractPicker*)*/ ARG_0);

// virtual vtkAbstractPicker* GetPicker()
// virtual vtkAbstractPicker *GetPicker ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPicker_0")] public static extern 
bool GetPicker_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual vtkAbstractPropPicker* CreateDefaultPicker()
// virtual vtkAbstractPropPicker *CreateDefaultPicker()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_CreateDefaultPicker_0")] public static extern 
bool CreateDefaultPicker_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetPickingManager(vtkPickingManager * ARG_0)
// virtual void SetPickingManager(vtkPickingManager*)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetPickingManager_0")] public static extern 
bool SetPickingManager_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkPickingManager*)*/ ARG_0);

// virtual vtkPickingManager* GetPickingManager()
// virtual vtkPickingManager *GetPickingManager ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPickingManager_0")] public static extern 
bool GetPickingManager_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void ExitCallback()
// virtual void ExitCallback()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ExitCallback_0")] public static extern 
bool ExitCallback_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void UserCallback()
// virtual void UserCallback()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_UserCallback_0")] public static extern 
bool UserCallback_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void StartPickCallback()
// virtual void StartPickCallback()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_StartPickCallback_0")] public static extern 
bool StartPickCallback_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EndPickCallback()
// virtual void EndPickCallback()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EndPickCallback_0")] public static extern 
bool EndPickCallback_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetMousePosition(int * x, int * y)
// virtual void GetMousePosition(int *x, int *y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetMousePosition_0")] public static extern 
bool GetMousePosition_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(int*)*/ x, IntPtr /*(int*)*/ y);

// void HideCursor()
// void HideCursor()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_HideCursor_0")] public static extern 
bool HideCursor_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void ShowCursor()
// void ShowCursor()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ShowCursor_0")] public static extern 
bool ShowCursor_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void Render()
// virtual void Render()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void FlyTo(vtkRenderer * ren, double x, double y, double z)
// void FlyTo(vtkRenderer *ren, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FlyTo_0")] public static extern 
bool FlyTo_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void FlyTo(vtkRenderer * ren, double * x)
// void FlyTo(vtkRenderer *ren, double *x)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FlyTo_1")] public static extern 
bool FlyTo_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(double*)*/ x);

// void FlyToImage(vtkRenderer * ren, double x, double y)
// void FlyToImage(vtkRenderer *ren, double x, double y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FlyToImage_0")] public static extern 
bool FlyToImage_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y);

// void FlyToImage(vtkRenderer * ren, double * x)
// void FlyToImage(vtkRenderer *ren, double *x)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FlyToImage_1")] public static extern 
bool FlyToImage_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(double*)*/ x);

// virtual void SetNumberOfFlyFrames(int _arg)
// virtual void SetNumberOfFlyFrames (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetNumberOfFlyFrames_0")] public static extern 
bool SetNumberOfFlyFrames_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfFlyFramesMinValue()
// virtual int GetNumberOfFlyFramesMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_0")] public static extern 
bool GetNumberOfFlyFramesMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int GetNumberOfFlyFramesMaxValue()
// virtual int GetNumberOfFlyFramesMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_0")] public static extern 
bool GetNumberOfFlyFramesMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int GetNumberOfFlyFrames()
// virtual int GetNumberOfFlyFrames ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetNumberOfFlyFrames_0")] public static extern 
bool GetNumberOfFlyFrames_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetDolly(double _arg)
// virtual void SetDolly (double _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetDolly_0")] public static extern 
bool SetDolly_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double)*/ _arg);

// virtual double GetDolly()
// virtual double GetDolly ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetDolly_0")] public static extern 
bool GetDolly_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int* GetEventPosition()
// virtual int *GetEventPosition ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventPosition_0")] public static extern 
bool GetEventPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetEventPosition(int & _arg1, int & _arg2)
// virtual void GetEventPosition (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventPosition_1")] public static extern 
bool GetEventPosition_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetEventPosition(int _arg[2])
// virtual void GetEventPosition (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventPosition_2")] public static extern 
bool GetEventPosition_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual int* GetLastEventPosition()
// virtual int *GetLastEventPosition ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastEventPosition_0")] public static extern 
bool GetLastEventPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetLastEventPosition(int & _arg1, int & _arg2)
// virtual void GetLastEventPosition (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastEventPosition_1")] public static extern 
bool GetLastEventPosition_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetLastEventPosition(int _arg[2])
// virtual void GetLastEventPosition (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastEventPosition_2")] public static extern 
bool GetLastEventPosition_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual void SetLastEventPosition(int _arg1, int _arg2)
// virtual void SetLastEventPosition (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetLastEventPosition_0")] public static extern 
bool SetLastEventPosition_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetLastEventPosition(int _arg[2])
// void SetLastEventPosition (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetLastEventPosition_1")] public static extern 
bool SetLastEventPosition_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual void SetEventPosition(int x, int y)
// virtual void SetEventPosition(int x, int y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPosition_0")] public static extern 
bool SetEventPosition_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// virtual void SetEventPosition(int pos[2])
// virtual void SetEventPosition(int pos[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPosition_1")] public static extern 
bool SetEventPosition_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []pos);

// virtual void SetEventPositionFlipY(int x, int y)
// virtual void SetEventPositionFlipY(int x, int y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPositionFlipY_0")] public static extern 
bool SetEventPositionFlipY_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// virtual void SetEventPositionFlipY(int pos[2])
// virtual void SetEventPositionFlipY(int pos[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPositionFlipY_1")] public static extern 
bool SetEventPositionFlipY_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []pos);

// virtual int* GetEventPositions(int pointerIndex)
// virtual int *GetEventPositions(int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventPositions_0")] public static extern 
bool GetEventPositions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ pointerIndex);

// virtual int* GetLastEventPositions(int pointerIndex)
// virtual int *GetLastEventPositions(int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastEventPositions_0")] public static extern 
bool GetLastEventPositions_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ pointerIndex);

// virtual void SetEventPosition(int x, int y, int pointerIndex)
// virtual void SetEventPosition(int x, int y, int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPosition_2")] public static extern 
bool SetEventPosition_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ pointerIndex);

// virtual void SetEventPosition(int pos[2], int pointerIndex)
// virtual void SetEventPosition(int pos[2], int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPosition_3")] public static extern 
bool SetEventPosition_3(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []pos, int /*(int)*/ pointerIndex);

// virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)
// virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPositionFlipY_2")] public static extern 
bool SetEventPositionFlipY_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ pointerIndex);

// virtual void SetEventPositionFlipY(int pos[2], int pointerIndex)
// virtual void SetEventPositionFlipY(int pos[2], int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventPositionFlipY_3")] public static extern 
bool SetEventPositionFlipY_3(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []pos, int /*(int)*/ pointerIndex);

// virtual void SetAltKey(int _arg)
// virtual void SetAltKey (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetAltKey_0")] public static extern 
bool SetAltKey_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAltKey()
// virtual int GetAltKey ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetAltKey_0")] public static extern 
bool GetAltKey_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetControlKey(int _arg)
// virtual void SetControlKey (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetControlKey_0")] public static extern 
bool SetControlKey_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetControlKey()
// virtual int GetControlKey ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetControlKey_0")] public static extern 
bool GetControlKey_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetShiftKey(int _arg)
// virtual void SetShiftKey (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetShiftKey_0")] public static extern 
bool SetShiftKey_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetShiftKey()
// virtual int GetShiftKey ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetShiftKey_0")] public static extern 
bool GetShiftKey_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetKeyCode(char _arg)
// virtual void SetKeyCode (char _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetKeyCode_0")] public static extern 
bool SetKeyCode_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, char /*(char)*/ _arg);

// virtual char GetKeyCode()
// virtual char GetKeyCode ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetKeyCode_0")] public static extern 
bool GetKeyCode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetRepeatCount(int _arg)
// virtual void SetRepeatCount (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetRepeatCount_0")] public static extern 
bool SetRepeatCount_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetRepeatCount()
// virtual int GetRepeatCount ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetRepeatCount_0")] public static extern 
bool GetRepeatCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetKeySym(const char * _arg)
// virtual void SetKeySym (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetKeySym_0")] public static extern 
bool SetKeySym_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetKeySym()
// virtual char* GetKeySym ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetKeySym_0")] public static extern 
bool GetKeySym_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetPointerIndex(int _arg)
// virtual void SetPointerIndex (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetPointerIndex_0")] public static extern 
bool SetPointerIndex_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPointerIndex()
// virtual int GetPointerIndex ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPointerIndex_0")] public static extern 
bool GetPointerIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void SetRotation(double val)
// void SetRotation(double val)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetRotation_0")] public static extern 
bool SetRotation_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double)*/ val);

// virtual double GetRotation()
// virtual double GetRotation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetRotation_0")] public static extern 
bool GetRotation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetLastRotation()
// virtual double GetLastRotation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastRotation_0")] public static extern 
bool GetLastRotation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void SetScale(double val)
// void SetScale(double val)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetScale_0")] public static extern 
bool SetScale_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double)*/ val);

// virtual double GetScale()
// virtual double GetScale ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetScale_0")] public static extern 
bool GetScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual double GetLastScale()
// virtual double GetLastScale ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastScale_0")] public static extern 
bool GetLastScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void SetTranslation(double val[2])
// void SetTranslation(double val[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetTranslation_0")] public static extern 
bool SetTranslation_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double[2])*/ []val);

// virtual double* GetTranslation()
// virtual double *GetTranslation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTranslation_0")] public static extern 
bool GetTranslation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetTranslation(double & _arg1, double & _arg2)
// virtual void GetTranslation (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTranslation_1")] public static extern 
bool GetTranslation_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetTranslation(double _arg[2])
// virtual void GetTranslation (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetTranslation_2")] public static extern 
bool GetTranslation_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetLastTranslation()
// virtual double *GetLastTranslation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastTranslation_0")] public static extern 
bool GetLastTranslation_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetLastTranslation(double & _arg1, double & _arg2)
// virtual void GetLastTranslation (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastTranslation_1")] public static extern 
bool GetLastTranslation_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetLastTranslation(double _arg[2])
// virtual void GetLastTranslation (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetLastTranslation_2")] public static extern 
bool GetLastTranslation_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, double /*(double[2])*/ []_arg);

// void SetEventInformation(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char * keysym, int pointerIndex)
// void SetEventInformation(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char* keysym, int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventInformation_0")] public static extern 
bool SetEventInformation_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym, int /*(int)*/ pointerIndex);

// void SetEventInformationFlipY(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char * keysym, int pointerIndex)
// void SetEventInformationFlipY(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char* keysym, int pointerIndex)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventInformationFlipY_0")] public static extern 
bool SetEventInformationFlipY_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym, int /*(int)*/ pointerIndex);

// virtual void SetSize(int _arg1, int _arg2)
// virtual void SetSize (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetSize_0")] public static extern 
bool SetSize_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetSize(int _arg[2])
// void SetSize (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetSize_1")] public static extern 
bool SetSize_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual int* GetSize()
// virtual int *GetSize ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetSize(int & _arg1, int & _arg2)
// virtual void GetSize (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetSize_1")] public static extern 
bool GetSize_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetSize(int _arg[2])
// virtual void GetSize (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetSize_2")] public static extern 
bool GetSize_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual void SetEventSize(int _arg1, int _arg2)
// virtual void SetEventSize (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventSize_0")] public static extern 
bool SetEventSize_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetEventSize(int _arg[2])
// void SetEventSize (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetEventSize_1")] public static extern 
bool SetEventSize_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual int* GetEventSize()
// virtual int *GetEventSize ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventSize_0")] public static extern 
bool GetEventSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void GetEventSize(int & _arg1, int & _arg2)
// virtual void GetEventSize (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventSize_1")] public static extern 
bool GetEventSize_1(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetEventSize(int _arg[2])
// virtual void GetEventSize (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetEventSize_2")] public static extern 
bool GetEventSize_2(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual vtkRenderer* FindPokedRenderer(int ARG_0, int ARG_1)
// virtual vtkRenderer *FindPokedRenderer(int,int)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FindPokedRenderer_0")] public static extern 
bool FindPokedRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1);

// vtkObserverMediator* GetObserverMediator()
// vtkObserverMediator *GetObserverMediator()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetObserverMediator_0")] public static extern 
bool GetObserverMediator_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetUseTDx(bool _arg)
// virtual void SetUseTDx (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetUseTDx_0")] public static extern 
bool SetUseTDx_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseTDx()
// virtual bool GetUseTDx ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetUseTDx_0")] public static extern 
bool GetUseTDx_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void MouseMoveEvent()
// virtual void MouseMoveEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_MouseMoveEvent_0")] public static extern 
bool MouseMoveEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void RightButtonPressEvent()
// virtual void RightButtonPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_RightButtonPressEvent_0")] public static extern 
bool RightButtonPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void RightButtonReleaseEvent()
// virtual void RightButtonReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_RightButtonReleaseEvent_0")] public static extern 
bool RightButtonReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LeftButtonPressEvent()
// virtual void LeftButtonPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LeftButtonPressEvent_0")] public static extern 
bool LeftButtonPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LeftButtonReleaseEvent()
// virtual void LeftButtonReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LeftButtonReleaseEvent_0")] public static extern 
bool LeftButtonReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void MiddleButtonPressEvent()
// virtual void MiddleButtonPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_MiddleButtonPressEvent_0")] public static extern 
bool MiddleButtonPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void MiddleButtonReleaseEvent()
// virtual void MiddleButtonReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_MiddleButtonReleaseEvent_0")] public static extern 
bool MiddleButtonReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void MouseWheelForwardEvent()
// virtual void MouseWheelForwardEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_MouseWheelForwardEvent_0")] public static extern 
bool MouseWheelForwardEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void MouseWheelBackwardEvent()
// virtual void MouseWheelBackwardEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_MouseWheelBackwardEvent_0")] public static extern 
bool MouseWheelBackwardEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void ExposeEvent()
// virtual void ExposeEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ExposeEvent_0")] public static extern 
bool ExposeEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void ConfigureEvent()
// virtual void ConfigureEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ConfigureEvent_0")] public static extern 
bool ConfigureEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EnterEvent()
// virtual void EnterEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EnterEvent_0")] public static extern 
bool EnterEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LeaveEvent()
// virtual void LeaveEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LeaveEvent_0")] public static extern 
bool LeaveEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void KeyPressEvent()
// virtual void KeyPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_KeyPressEvent_0")] public static extern 
bool KeyPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void KeyReleaseEvent()
// virtual void KeyReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_KeyReleaseEvent_0")] public static extern 
bool KeyReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void CharEvent()
// virtual void CharEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_CharEvent_0")] public static extern 
bool CharEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void ExitEvent()
// virtual void ExitEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ExitEvent_0")] public static extern 
bool ExitEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void FourthButtonPressEvent()
// virtual void FourthButtonPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FourthButtonPressEvent_0")] public static extern 
bool FourthButtonPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void FourthButtonReleaseEvent()
// virtual void FourthButtonReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FourthButtonReleaseEvent_0")] public static extern 
bool FourthButtonReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void FifthButtonPressEvent()
// virtual void FifthButtonPressEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FifthButtonPressEvent_0")] public static extern 
bool FifthButtonPressEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void FifthButtonReleaseEvent()
// virtual void FifthButtonReleaseEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_FifthButtonReleaseEvent_0")] public static extern 
bool FifthButtonReleaseEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void StartPinchEvent()
// virtual void StartPinchEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_StartPinchEvent_0")] public static extern 
bool StartPinchEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void PinchEvent()
// virtual void PinchEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_PinchEvent_0")] public static extern 
bool PinchEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EndPinchEvent()
// virtual void EndPinchEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EndPinchEvent_0")] public static extern 
bool EndPinchEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void StartRotateEvent()
// virtual void StartRotateEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_StartRotateEvent_0")] public static extern 
bool StartRotateEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void RotateEvent()
// virtual void RotateEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_RotateEvent_0")] public static extern 
bool RotateEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EndRotateEvent()
// virtual void EndRotateEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EndRotateEvent_0")] public static extern 
bool EndRotateEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void StartPanEvent()
// virtual void StartPanEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_StartPanEvent_0")] public static extern 
bool StartPanEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void PanEvent()
// virtual void PanEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_PanEvent_0")] public static extern 
bool PanEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void EndPanEvent()
// virtual void EndPanEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_EndPanEvent_0")] public static extern 
bool EndPanEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void TapEvent()
// virtual void TapEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_TapEvent_0")] public static extern 
bool TapEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void LongTapEvent()
// virtual void LongTapEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_LongTapEvent_0")] public static extern 
bool LongTapEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SwipeEvent()
// virtual void SwipeEvent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SwipeEvent_0")] public static extern 
bool SwipeEvent_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual void SetRecognizeGestures(bool _arg)
// virtual void SetRecognizeGestures (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_SetRecognizeGestures_0")] public static extern 
bool SetRecognizeGestures_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetRecognizeGestures()
// virtual bool GetRecognizeGestures ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetRecognizeGestures_0")] public static extern 
bool GetRecognizeGestures_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// virtual int GetPointersDownCount()
// virtual int GetPointersDownCount ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPointersDownCount_0")] public static extern 
bool GetPointersDownCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject);

// void ClearContact(size_t contactID)
// void ClearContact(size_t contactID)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ClearContact_0")] public static extern 
bool ClearContact_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(size_t)*/ contactID);

// int GetPointerIndexForContact(size_t contactID)
// int GetPointerIndexForContact(size_t contactID)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPointerIndexForContact_0")] public static extern 
bool GetPointerIndexForContact_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(size_t)*/ contactID);

// int GetPointerIndexForExistingContact(size_t contactID)
// int GetPointerIndexForExistingContact(size_t contactID)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_GetPointerIndexForExistingContact_0")] public static extern 
bool GetPointerIndexForExistingContact_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, ulong /*(size_t)*/ contactID);

// bool IsPointerIndexSet(int i)
// bool IsPointerIndexSet(int i)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_IsPointerIndexSet_0")] public static extern 
bool IsPointerIndexSet_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ i);

// void ClearPointerIndex(int i)
// void ClearPointerIndex(int i)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindowInteractor_ClearPointerIndex_0")] public static extern 
bool ClearPointerIndex_0(IntPtr /*(vtkRenderWindowInteractor*)*/ callingObject, int /*(int)*/ i);

}
};
