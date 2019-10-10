
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRenderWindow {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, string /*(char*)*/ type);

// static vtkRenderWindow* SafeDownCast(vtkObjectBase * o)
// static vtkRenderWindow* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkRenderWindow* NewInstance()
// vtkRenderWindow *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// static vtkRenderWindow* New()
// static vtkRenderWindow *New()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual void AddRenderer(vtkRenderer * ARG_0)
// virtual void AddRenderer(vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_AddRenderer_0")] public static extern 
bool AddRenderer_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// void RemoveRenderer(vtkRenderer * ARG_0)
// void RemoveRenderer(vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_RemoveRenderer_0")] public static extern 
bool RemoveRenderer_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// int HasRenderer(vtkRenderer * ARG_0)
// int HasRenderer(vtkRenderer *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_HasRenderer_0")] public static extern 
bool HasRenderer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ARG_0);

// static char* GetRenderLibrary()
// static const char *GetRenderLibrary()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRenderLibrary_0")] public static extern 
bool GetRenderLibrary_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual char* GetRenderingBackend()
// virtual const char *GetRenderingBackend()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRenderingBackend_0")] public static extern 
bool GetRenderingBackend_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual vtkRenderTimerLog* GetRenderTimer()
// virtual vtkRenderTimerLog *GetRenderTimer ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRenderTimer_0")] public static extern 
bool GetRenderTimer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// vtkRendererCollection* GetRenderers()
// vtkRendererCollection *GetRenderers()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRenderers_0")] public static extern 
bool GetRenderers_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void CaptureGL2PSSpecialProps(vtkCollection * specialProps)
// void CaptureGL2PSSpecialProps(vtkCollection *specialProps)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_CaptureGL2PSSpecialProps_0")] public static extern 
bool CaptureGL2PSSpecialProps_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkCollection*)*/ specialProps);

// virtual int GetCapturingGL2PSSpecialProps()
// virtual int GetCapturingGL2PSSpecialProps ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetCapturingGL2PSSpecialProps_0")] public static extern 
bool GetCapturingGL2PSSpecialProps_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void Render()
// void Render()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void Start()
// virtual void Start()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_Start_0")] public static extern 
bool Start_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void Finalize()
// virtual void Finalize()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_Finalize_0")] public static extern 
bool Finalize_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void Frame()
// virtual void Frame()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_Frame_0")] public static extern 
bool Frame_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void WaitForCompletion()
// virtual void WaitForCompletion()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_WaitForCompletion_0")] public static extern 
bool WaitForCompletion_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void CopyResultFrame()
// virtual void CopyResultFrame()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_CopyResultFrame_0")] public static extern 
bool CopyResultFrame_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual vtkRenderWindowInteractor* MakeRenderWindowInteractor()
// virtual vtkRenderWindowInteractor *MakeRenderWindowInteractor()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_MakeRenderWindowInteractor_0")] public static extern 
bool MakeRenderWindowInteractor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void HideCursor()
// virtual void HideCursor()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_HideCursor_0")] public static extern 
bool HideCursor_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void ShowCursor()
// virtual void ShowCursor()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_ShowCursor_0")] public static extern 
bool ShowCursor_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetCursorPosition(int ARG_0, int ARG_1)
// virtual void SetCursorPosition(int , int )
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetCursorPosition_0")] public static extern 
bool SetCursorPosition_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1);

// virtual void SetCurrentCursor(int _arg)
// virtual void SetCurrentCursor (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetCurrentCursor_0")] public static extern 
bool SetCurrentCursor_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetCurrentCursor()
// virtual int GetCurrentCursor ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetCurrentCursor_0")] public static extern 
bool GetCurrentCursor_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetFullScreen(int ARG_0)
// virtual void SetFullScreen(int)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetFullScreen_0")] public static extern 
bool SetFullScreen_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual int GetFullScreen()
// virtual int GetFullScreen ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetFullScreen_0")] public static extern 
bool GetFullScreen_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void FullScreenOn()
// virtual void FullScreenOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_FullScreenOn_0")] public static extern 
bool FullScreenOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void FullScreenOff()
// virtual void FullScreenOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_FullScreenOff_0")] public static extern 
bool FullScreenOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetBorders(int _arg)
// virtual void SetBorders (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetBorders_0")] public static extern 
bool SetBorders_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetBorders()
// virtual int GetBorders ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetBorders_0")] public static extern 
bool GetBorders_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void BordersOn()
// virtual void BordersOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_BordersOn_0")] public static extern 
bool BordersOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void BordersOff()
// virtual void BordersOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_BordersOff_0")] public static extern 
bool BordersOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetStereoCapableWindow()
// virtual int GetStereoCapableWindow ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetStereoCapableWindow_0")] public static extern 
bool GetStereoCapableWindow_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoCapableWindowOn()
// virtual void StereoCapableWindowOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoCapableWindowOn_0")] public static extern 
bool StereoCapableWindowOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoCapableWindowOff()
// virtual void StereoCapableWindowOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoCapableWindowOff_0")] public static extern 
bool StereoCapableWindowOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetStereoCapableWindow(int capable)
// virtual void SetStereoCapableWindow(int capable)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoCapableWindow_0")] public static extern 
bool SetStereoCapableWindow_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ capable);

// virtual int GetStereoRender()
// virtual int GetStereoRender ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetStereoRender_0")] public static extern 
bool GetStereoRender_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoRender(int stereo)
// void SetStereoRender(int stereo)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoRender_0")] public static extern 
bool SetStereoRender_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ stereo);

// virtual void StereoRenderOn()
// virtual void StereoRenderOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoRenderOn_0")] public static extern 
bool StereoRenderOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoRenderOff()
// virtual void StereoRenderOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoRenderOff_0")] public static extern 
bool StereoRenderOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetAlphaBitPlanes(int _arg)
// virtual void SetAlphaBitPlanes (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetAlphaBitPlanes_0")] public static extern 
bool SetAlphaBitPlanes_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAlphaBitPlanes()
// virtual int GetAlphaBitPlanes ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAlphaBitPlanes_0")] public static extern 
bool GetAlphaBitPlanes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void AlphaBitPlanesOn()
// virtual void AlphaBitPlanesOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_AlphaBitPlanesOn_0")] public static extern 
bool AlphaBitPlanesOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void AlphaBitPlanesOff()
// virtual void AlphaBitPlanesOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_AlphaBitPlanesOff_0")] public static extern 
bool AlphaBitPlanesOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetPointSmoothing(int _arg)
// virtual void SetPointSmoothing (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetPointSmoothing_0")] public static extern 
bool SetPointSmoothing_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPointSmoothing()
// virtual int GetPointSmoothing ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetPointSmoothing_0")] public static extern 
bool GetPointSmoothing_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void PointSmoothingOn()
// virtual void PointSmoothingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_PointSmoothingOn_0")] public static extern 
bool PointSmoothingOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void PointSmoothingOff()
// virtual void PointSmoothingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_PointSmoothingOff_0")] public static extern 
bool PointSmoothingOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetLineSmoothing(int _arg)
// virtual void SetLineSmoothing (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetLineSmoothing_0")] public static extern 
bool SetLineSmoothing_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLineSmoothing()
// virtual int GetLineSmoothing ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetLineSmoothing_0")] public static extern 
bool GetLineSmoothing_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void LineSmoothingOn()
// virtual void LineSmoothingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_LineSmoothingOn_0")] public static extern 
bool LineSmoothingOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void LineSmoothingOff()
// virtual void LineSmoothingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_LineSmoothingOff_0")] public static extern 
bool LineSmoothingOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetPolygonSmoothing(int _arg)
// virtual void SetPolygonSmoothing (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetPolygonSmoothing_0")] public static extern 
bool SetPolygonSmoothing_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetPolygonSmoothing()
// virtual int GetPolygonSmoothing ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetPolygonSmoothing_0")] public static extern 
bool GetPolygonSmoothing_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void PolygonSmoothingOn()
// virtual void PolygonSmoothingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_PolygonSmoothingOn_0")] public static extern 
bool PolygonSmoothingOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void PolygonSmoothingOff()
// virtual void PolygonSmoothingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_PolygonSmoothingOff_0")] public static extern 
bool PolygonSmoothingOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetStereoType()
// virtual int GetStereoType ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetStereoType_0")] public static extern 
bool GetStereoType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetStereoType(int _arg)
// virtual void SetStereoType (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoType_0")] public static extern 
bool SetStereoType_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// void SetStereoTypeToCrystalEyes()
// void SetStereoTypeToCrystalEyes()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToCrystalEyes_0")] public static extern 
bool SetStereoTypeToCrystalEyes_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToRedBlue()
// void SetStereoTypeToRedBlue()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToRedBlue_0")] public static extern 
bool SetStereoTypeToRedBlue_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToInterlaced()
// void SetStereoTypeToInterlaced()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToInterlaced_0")] public static extern 
bool SetStereoTypeToInterlaced_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToLeft()
// void SetStereoTypeToLeft()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToLeft_0")] public static extern 
bool SetStereoTypeToLeft_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToRight()
// void SetStereoTypeToRight()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToRight_0")] public static extern 
bool SetStereoTypeToRight_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToDresden()
// void SetStereoTypeToDresden()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToDresden_0")] public static extern 
bool SetStereoTypeToDresden_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToAnaglyph()
// void SetStereoTypeToAnaglyph()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToAnaglyph_0")] public static extern 
bool SetStereoTypeToAnaglyph_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToCheckerboard()
// void SetStereoTypeToCheckerboard()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToCheckerboard_0")] public static extern 
bool SetStereoTypeToCheckerboard_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToSplitViewportHorizontal()
// void SetStereoTypeToSplitViewportHorizontal()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToSplitViewportHorizontal_0")] public static extern 
bool SetStereoTypeToSplitViewportHorizontal_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetStereoTypeToFake()
// void SetStereoTypeToFake()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStereoTypeToFake_0")] public static extern 
bool SetStereoTypeToFake_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// char* GetStereoTypeAsString()
// const char *GetStereoTypeAsString()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetStereoTypeAsString_0")] public static extern 
bool GetStereoTypeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoUpdate()
// virtual void StereoUpdate()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoUpdate_0")] public static extern 
bool StereoUpdate_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoMidpoint()
// virtual void StereoMidpoint()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoMidpoint_0")] public static extern 
bool StereoMidpoint_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StereoRenderComplete()
// virtual void StereoRenderComplete()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StereoRenderComplete_0")] public static extern 
bool StereoRenderComplete_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetAnaglyphColorSaturation(float _arg)
// virtual void SetAnaglyphColorSaturation (float _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetAnaglyphColorSaturation_0")] public static extern 
bool SetAnaglyphColorSaturation_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, float /*(float)*/ _arg);

// virtual float GetAnaglyphColorSaturationMinValue()
// virtual float GetAnaglyphColorSaturationMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAnaglyphColorSaturationMinValue_0")] public static extern 
bool GetAnaglyphColorSaturationMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual float GetAnaglyphColorSaturationMaxValue()
// virtual float GetAnaglyphColorSaturationMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_0")] public static extern 
bool GetAnaglyphColorSaturationMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual float GetAnaglyphColorSaturation()
// virtual float GetAnaglyphColorSaturation ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAnaglyphColorSaturation_0")] public static extern 
bool GetAnaglyphColorSaturation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
// virtual void SetAnaglyphColorMask (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetAnaglyphColorMask_0")] public static extern 
bool SetAnaglyphColorMask_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetAnaglyphColorMask(int _arg[2])
// void SetAnaglyphColorMask (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetAnaglyphColorMask_1")] public static extern 
bool SetAnaglyphColorMask_1(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual int* GetAnaglyphColorMask()
// virtual int *GetAnaglyphColorMask ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAnaglyphColorMask_0")] public static extern 
bool GetAnaglyphColorMask_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void GetAnaglyphColorMask(int data[2])
// virtual void GetAnaglyphColorMask (int data[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAnaglyphColorMask_1")] public static extern 
bool GetAnaglyphColorMask_1(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int[2])*/ []data);

// virtual void WindowRemap()
// virtual void WindowRemap()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_WindowRemap_0")] public static extern 
bool WindowRemap_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetSwapBuffers(int _arg)
// virtual void SetSwapBuffers (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetSwapBuffers_0")] public static extern 
bool SetSwapBuffers_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetSwapBuffers()
// virtual int GetSwapBuffers ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetSwapBuffers_0")] public static extern 
bool GetSwapBuffers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SwapBuffersOn()
// virtual void SwapBuffersOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SwapBuffersOn_0")] public static extern 
bool SwapBuffersOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SwapBuffersOff()
// virtual void SwapBuffersOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SwapBuffersOff_0")] public static extern 
bool SwapBuffersOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int right = 0)
// virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char *data, int front, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetPixelData_0")] public static extern 
bool SetPixelData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ right);

// virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int right = 0)
// virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetPixelData_1")] public static extern 
bool SetPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ right);

// virtual float* GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// virtual float *GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRGBAPixelData_0")] public static extern 
bool GetRGBAPixelData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right);

// virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray * data, int right = 0)
// virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray *data, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRGBAPixelData_1")] public static extern 
bool GetRGBAPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, IntPtr /*(vtkFloatArray*)*/ data, int /*(int)*/ right);

// virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float * ARG_0, int front, int blend = 0, int right = 0)
// virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float *, int front, int blend=0, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetRGBAPixelData_0")] public static extern 
bool SetRGBAPixelData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ ARG_0, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right);

// virtual int SetRGBAPixelData(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkFloatArray * ARG_4, int ARG_5, int blend = 0, int right = 0)
// virtual int SetRGBAPixelData(int, int, int, int, vtkFloatArray*, int, int blend=0, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetRGBAPixelData_1")] public static extern 
bool SetRGBAPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, IntPtr /*(vtkFloatArray*)*/ ARG_4, int /*(int)*/ ARG_5, int /*(int)*/ blend, int /*(int)*/ right);

// virtual void ReleaseRGBAPixelData(float * data)
// virtual void ReleaseRGBAPixelData(float *data)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_ReleaseRGBAPixelData_0")] public static extern 
bool ReleaseRGBAPixelData_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(float*)*/ data);

// virtual char* GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// virtual unsigned char *GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRGBACharPixelData_0")] public static extern 
bool GetRGBACharPixelData_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right);

// virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray * data, int right = 0)
// virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray *data, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetRGBACharPixelData_1")] public static extern 
bool GetRGBACharPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, IntPtr /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ right);

// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int blend = 0, int right = 0)
// virtual int SetRGBACharPixelData(int x,int y, int x2, int y2, unsigned char *data, int front, int blend=0, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetRGBACharPixelData_0")] public static extern 
bool SetRGBACharPixelData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right);

// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int blend = 0, int right = 0)
// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int blend=0, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetRGBACharPixelData_1")] public static extern 
bool SetRGBACharPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right);

// virtual float* GetZbufferData(int x, int y, int x2, int y2)
// virtual float *GetZbufferData(int x, int y, int x2, int y2)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetZbufferData_0")] public static extern 
bool GetZbufferData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2);

// virtual int GetZbufferData(int x, int y, int x2, int y2, float * z)
// virtual int GetZbufferData(int x, int y, int x2, int y2, float *z)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetZbufferData_1")] public static extern 
bool GetZbufferData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ z);

// virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetZbufferData_2")] public static extern 
bool GetZbufferData_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(vtkFloatArray*)*/ z);

// virtual int SetZbufferData(int x, int y, int x2, int y2, float * z)
// virtual int SetZbufferData(int x, int y, int x2, int y2, float *z)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetZbufferData_0")] public static extern 
bool SetZbufferData_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ z);

// virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetZbufferData_1")] public static extern 
bool SetZbufferData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(vtkFloatArray*)*/ z);

// float GetZbufferDataAtPoint(int x, int y)
// float GetZbufferDataAtPoint(int x, int y)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetZbufferDataAtPoint_0")] public static extern 
bool GetZbufferDataAtPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y);

// virtual int GetNeverRendered()
// virtual int GetNeverRendered ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetNeverRendered_0")] public static extern 
bool GetNeverRendered_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetAbortRender()
// virtual int GetAbortRender ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetAbortRender_0")] public static extern 
bool GetAbortRender_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetAbortRender(int _arg)
// virtual void SetAbortRender (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetAbortRender_0")] public static extern 
bool SetAbortRender_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetInAbortCheck()
// virtual int GetInAbortCheck ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetInAbortCheck_0")] public static extern 
bool GetInAbortCheck_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetInAbortCheck(int _arg)
// virtual void SetInAbortCheck (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetInAbortCheck_0")] public static extern 
bool SetInAbortCheck_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int CheckAbortStatus()
// virtual int CheckAbortStatus()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_CheckAbortStatus_0")] public static extern 
bool CheckAbortStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetIsPicking()
// virtual int GetIsPicking ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetIsPicking_0")] public static extern 
bool GetIsPicking_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetIsPicking(int _arg)
// virtual void SetIsPicking (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetIsPicking_0")] public static extern 
bool SetIsPicking_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual void IsPickingOn()
// virtual void IsPickingOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsPickingOn_0")] public static extern 
bool IsPickingOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void IsPickingOff()
// virtual void IsPickingOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsPickingOff_0")] public static extern 
bool IsPickingOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetEventPending()
// virtual int GetEventPending()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetEventPending_0")] public static extern 
bool GetEventPending_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int CheckInRenderStatus()
// virtual int CheckInRenderStatus()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_CheckInRenderStatus_0")] public static extern 
bool CheckInRenderStatus_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void ClearInRenderStatus()
// virtual void ClearInRenderStatus()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_ClearInRenderStatus_0")] public static extern 
bool ClearInRenderStatus_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetDesiredUpdateRate(double ARG_0)
// virtual void SetDesiredUpdateRate(double)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetDesiredUpdateRate_0")] public static extern 
bool SetDesiredUpdateRate_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, double /*(double)*/ ARG_0);

// virtual double GetDesiredUpdateRate()
// virtual double GetDesiredUpdateRate ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetDesiredUpdateRate_0")] public static extern 
bool GetDesiredUpdateRate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetNumberOfLayers()
// virtual int GetNumberOfLayers ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetNumberOfLayers_0")] public static extern 
bool GetNumberOfLayers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetNumberOfLayers(int _arg)
// virtual void SetNumberOfLayers (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetNumberOfLayers_0")] public static extern 
bool SetNumberOfLayers_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetNumberOfLayersMinValue()
// virtual int GetNumberOfLayersMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetNumberOfLayersMinValue_0")] public static extern 
bool GetNumberOfLayersMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetNumberOfLayersMaxValue()
// virtual int GetNumberOfLayersMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetNumberOfLayersMaxValue_0")] public static extern 
bool GetNumberOfLayersMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual vtkRenderWindowInteractor* GetInteractor()
// virtual vtkRenderWindowInteractor *GetInteractor ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetInteractor_0")] public static extern 
bool GetInteractor_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetInteractor(vtkRenderWindowInteractor * ARG_0)
// void SetInteractor(vtkRenderWindowInteractor *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetInteractor_0")] public static extern 
bool SetInteractor_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkRenderWindowInteractor*)*/ ARG_0);

// void UnRegister(vtkObjectBase * o)
// void UnRegister(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_UnRegister_0")] public static extern 
bool UnRegister_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(vtkObjectBase*)*/ o);

// void SetDisplayId(void * ARG_0)
// void SetDisplayId(void *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetDisplayId_0")] public static extern 
bool SetDisplayId_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// void SetWindowId(void * ARG_0)
// void SetWindowId(void *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetWindowId_0")] public static extern 
bool SetWindowId_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// virtual void SetNextWindowId(void * ARG_0)
// virtual void SetNextWindowId(void *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetNextWindowId_0")] public static extern 
bool SetNextWindowId_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// void SetParentId(void * ARG_0)
// void SetParentId(void *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetParentId_0")] public static extern 
bool SetParentId_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// void* GetGenericDisplayId()
// void *GetGenericDisplayId()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetGenericDisplayId_0")] public static extern 
bool GetGenericDisplayId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void* GetGenericWindowId()
// void *GetGenericWindowId()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetGenericWindowId_0")] public static extern 
bool GetGenericWindowId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void* GetGenericParentId()
// void *GetGenericParentId()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetGenericParentId_0")] public static extern 
bool GetGenericParentId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void* GetGenericContext()
// void *GetGenericContext()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetGenericContext_0")] public static extern 
bool GetGenericContext_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void* GetGenericDrawable()
// void *GetGenericDrawable()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetGenericDrawable_0")] public static extern 
bool GetGenericDrawable_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void SetWindowInfo(char * ARG_0)
// void SetWindowInfo(char *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetWindowInfo_0")] public static extern 
bool SetWindowInfo_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, string /*(char*)*/ ARG_0);

// virtual void SetNextWindowInfo(char * ARG_0)
// virtual void SetNextWindowInfo(char *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetNextWindowInfo_0")] public static extern 
bool SetNextWindowInfo_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, string /*(char*)*/ ARG_0);

// void SetParentInfo(char * ARG_0)
// void SetParentInfo(char *)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetParentInfo_0")] public static extern 
bool SetParentInfo_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, string /*(char*)*/ ARG_0);

// virtual bool InitializeFromCurrentContext()
// virtual bool InitializeFromCurrentContext()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_InitializeFromCurrentContext_0")] public static extern 
bool InitializeFromCurrentContext_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// void MakeCurrent()
// void MakeCurrent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_MakeCurrent_0")] public static extern 
bool MakeCurrent_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual bool IsCurrent()
// virtual bool IsCurrent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsCurrent_0")] public static extern 
bool IsCurrent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual bool IsDrawable()
// virtual bool IsDrawable()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsDrawable_0")] public static extern 
bool IsDrawable_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetForceMakeCurrent()
// virtual void SetForceMakeCurrent()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetForceMakeCurrent_0")] public static extern 
bool SetForceMakeCurrent_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual char* ReportCapabilities()
// virtual const char *ReportCapabilities()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_ReportCapabilities_0")] public static extern 
bool ReportCapabilities_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int SupportsOpenGL()
// virtual int SupportsOpenGL()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SupportsOpenGL_0")] public static extern 
bool SupportsOpenGL_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int IsDirect()
// virtual int IsDirect()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_IsDirect_0")] public static extern 
bool IsDirect_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetDepthBufferSize()
// virtual int GetDepthBufferSize()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetDepthBufferSize_0")] public static extern 
bool GetDepthBufferSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetColorBufferSizes(int * rgba)
// virtual int GetColorBufferSizes(int *rgba)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetColorBufferSizes_0")] public static extern 
bool GetColorBufferSizes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, IntPtr /*(int*)*/ rgba);

// virtual void SetMultiSamples(int _arg)
// virtual void SetMultiSamples (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetMultiSamples_0")] public static extern 
bool SetMultiSamples_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetMultiSamples()
// virtual int GetMultiSamples ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetMultiSamples_0")] public static extern 
bool GetMultiSamples_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetStencilCapable(int _arg)
// virtual void SetStencilCapable (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetStencilCapable_0")] public static extern 
bool SetStencilCapable_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetStencilCapable()
// virtual int GetStencilCapable ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetStencilCapable_0")] public static extern 
bool GetStencilCapable_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StencilCapableOn()
// virtual void StencilCapableOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StencilCapableOn_0")] public static extern 
bool StencilCapableOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void StencilCapableOff()
// virtual void StencilCapableOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_StencilCapableOff_0")] public static extern 
bool StencilCapableOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetDeviceIndex(int _arg)
// virtual void SetDeviceIndex (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetDeviceIndex_0")] public static extern 
bool SetDeviceIndex_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDeviceIndex()
// virtual int GetDeviceIndex ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetDeviceIndex_0")] public static extern 
bool GetDeviceIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int GetNumberOfDevices()
// virtual int GetNumberOfDevices()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetNumberOfDevices_0")] public static extern 
bool GetNumberOfDevices_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual int SetUseOffScreenBuffers(bool ARG_0)
// virtual int SetUseOffScreenBuffers(bool)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetUseOffScreenBuffers_0")] public static extern 
bool SetUseOffScreenBuffers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject, bool /*(bool)*/ ARG_0);

// virtual bool GetUseOffScreenBuffers()
// virtual bool GetUseOffScreenBuffers()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetUseOffScreenBuffers_0")] public static extern 
bool GetUseOffScreenBuffers_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual bool GetUseSRGBColorSpace()
// virtual bool GetUseSRGBColorSpace ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_GetUseSRGBColorSpace_0")] public static extern 
bool GetUseSRGBColorSpace_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void SetUseSRGBColorSpace(bool _arg)
// virtual void SetUseSRGBColorSpace (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_SetUseSRGBColorSpace_0")] public static extern 
bool SetUseSRGBColorSpace_0(IntPtr /*(vtkRenderWindow*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual void UseSRGBColorSpaceOn()
// virtual void UseSRGBColorSpaceOn ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_UseSRGBColorSpaceOn_0")] public static extern 
bool UseSRGBColorSpaceOn_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

// virtual void UseSRGBColorSpaceOff()
// virtual void UseSRGBColorSpaceOff ()
[DllImport("vtkplugin", EntryPoint="vtkRenderWindow_UseSRGBColorSpaceOff_0")] public static extern 
bool UseSRGBColorSpaceOff_0(IntPtr /*(vtkRenderWindow*)*/ callingObject);

}
};
