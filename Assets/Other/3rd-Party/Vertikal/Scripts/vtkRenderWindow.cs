

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderWindow : vtkWindow {
		public vtkRenderWindow(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderWindow(IntPtr p) {return new vtkRenderWindow(p);}
		public static implicit operator  IntPtr(vtkRenderWindow o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.IsTypeOf_0(returnPointer.GetPtr(), type);
	return (bool)returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.IsA_0(returnPointer.GetPtr(), this, type);
	return (bool)returnPointer;
}


// static vtkRenderWindow* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderWindow* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderWindow SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.SafeDownCast_0(returnPointer.GetPtr(), o);
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// vtkRenderWindow* NewInstance()
// "vtkRenderWindow *NewInstance()"
public vtkRenderWindow NewInstance() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.NewInstance_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// static vtkRenderWindow* New()
// "static vtkRenderWindow *New()"
public static vtkRenderWindow New() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.New_0(returnPointer.GetPtr());
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// virtual void AddRenderer(vtkRenderer * ARG_0)
// "virtual void AddRenderer(vtkRenderer *)"
public void AddRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.AddRenderer_0(this, ARG_0);
}


// void RemoveRenderer(vtkRenderer * ARG_0)
// "void RemoveRenderer(vtkRenderer *)"
public void RemoveRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.RemoveRenderer_0(this, ARG_0);
}


// int HasRenderer(vtkRenderer * ARG_0)
// "int HasRenderer(vtkRenderer *)"
public int HasRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.HasRenderer_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// static char* GetRenderLibrary()
// "static const char *GetRenderLibrary()"
public static string GetRenderLibrary() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRenderLibrary_0(returnPointer.GetPtr());
	return (string)returnPointer;
}


// virtual char* GetRenderingBackend()
// "virtual const char *GetRenderingBackend()"
public string GetRenderingBackend() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRenderingBackend_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual vtkRenderTimerLog* GetRenderTimer()
// "virtual vtkRenderTimerLog *GetRenderTimer ()"
public vtkRenderTimerLog GetRenderTimer() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRenderTimer_0(returnPointer.GetPtr(), this);
	return (vtkRenderTimerLog)(IntPtr)returnPointer;
}


// vtkRendererCollection* GetRenderers()
// "vtkRendererCollection *GetRenderers()"
public vtkRendererCollection GetRenderers() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRenderers_0(returnPointer.GetPtr(), this);
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// void CaptureGL2PSSpecialProps(vtkCollection * specialProps)
// "void CaptureGL2PSSpecialProps(vtkCollection *specialProps)"
public void CaptureGL2PSSpecialProps(vtkCollection /*(vtkCollection*)*/ specialProps) {
	VTK_API.API_vtkRenderWindow.CaptureGL2PSSpecialProps_0(this, specialProps);
}


// virtual int GetCapturingGL2PSSpecialProps()
// "virtual int GetCapturingGL2PSSpecialProps ()"
public int GetCapturingGL2PSSpecialProps() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetCapturingGL2PSSpecialProps_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void Render()
// "void Render()"
public void Render() {
	VTK_API.API_vtkRenderWindow.Render_0(this);
}


// virtual void Start()
// "virtual void Start()"
public void Start() {
	VTK_API.API_vtkRenderWindow.Start_0(this);
}


// virtual void Finalize()
// "virtual void Finalize()"
public void Finalize() {
	VTK_API.API_vtkRenderWindow.Finalize_0(this);
}


// virtual void Frame()
// "virtual void Frame()"
public void Frame() {
	VTK_API.API_vtkRenderWindow.Frame_0(this);
}


// virtual void WaitForCompletion()
// "virtual void WaitForCompletion()"
public void WaitForCompletion() {
	VTK_API.API_vtkRenderWindow.WaitForCompletion_0(this);
}


// virtual void CopyResultFrame()
// "virtual void CopyResultFrame()"
public void CopyResultFrame() {
	VTK_API.API_vtkRenderWindow.CopyResultFrame_0(this);
}


// virtual vtkRenderWindowInteractor* MakeRenderWindowInteractor()
// "virtual vtkRenderWindowInteractor *MakeRenderWindowInteractor()"
public vtkRenderWindowInteractor MakeRenderWindowInteractor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.MakeRenderWindowInteractor_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// virtual void HideCursor()
// "virtual void HideCursor()"
public void HideCursor() {
	VTK_API.API_vtkRenderWindow.HideCursor_0(this);
}


// virtual void ShowCursor()
// "virtual void ShowCursor()"
public void ShowCursor() {
	VTK_API.API_vtkRenderWindow.ShowCursor_0(this);
}


// virtual void SetCursorPosition(int ARG_0, int ARG_1)
// "virtual void SetCursorPosition(int , int )"
public void SetCursorPosition(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkRenderWindow.SetCursorPosition_0(this, ARG_0, ARG_1);
}


// virtual void SetCurrentCursor(int _arg)
// "virtual void SetCurrentCursor (int _arg)"
public void SetCurrentCursor(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetCurrentCursor_0(this, _arg);
}


// virtual int GetCurrentCursor()
// "virtual int GetCurrentCursor ()"
public int GetCurrentCursor() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetCurrentCursor_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetFullScreen(int ARG_0)
// "virtual void SetFullScreen(int)"
public void SetFullScreen(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetFullScreen_0(this, ARG_0);
}


// virtual int GetFullScreen()
// "virtual int GetFullScreen ()"
public int GetFullScreen() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetFullScreen_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void FullScreenOn()
// "virtual void FullScreenOn ()"
public void FullScreenOn() {
	VTK_API.API_vtkRenderWindow.FullScreenOn_0(this);
}


// virtual void FullScreenOff()
// "virtual void FullScreenOff ()"
public void FullScreenOff() {
	VTK_API.API_vtkRenderWindow.FullScreenOff_0(this);
}


// virtual void SetBorders(int _arg)
// "virtual void SetBorders (int _arg)"
public void SetBorders(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetBorders_0(this, _arg);
}


// virtual int GetBorders()
// "virtual int GetBorders ()"
public int GetBorders() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetBorders_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void BordersOn()
// "virtual void BordersOn ()"
public void BordersOn() {
	VTK_API.API_vtkRenderWindow.BordersOn_0(this);
}


// virtual void BordersOff()
// "virtual void BordersOff ()"
public void BordersOff() {
	VTK_API.API_vtkRenderWindow.BordersOff_0(this);
}


// virtual int GetStereoCapableWindow()
// "virtual int GetStereoCapableWindow ()"
public int GetStereoCapableWindow() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetStereoCapableWindow_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void StereoCapableWindowOn()
// "virtual void StereoCapableWindowOn ()"
public void StereoCapableWindowOn() {
	VTK_API.API_vtkRenderWindow.StereoCapableWindowOn_0(this);
}


// virtual void StereoCapableWindowOff()
// "virtual void StereoCapableWindowOff ()"
public void StereoCapableWindowOff() {
	VTK_API.API_vtkRenderWindow.StereoCapableWindowOff_0(this);
}


// virtual void SetStereoCapableWindow(int capable)
// "virtual void SetStereoCapableWindow(int capable)"
public void SetStereoCapableWindow(int /*(int)*/ capable) {
	VTK_API.API_vtkRenderWindow.SetStereoCapableWindow_0(this, capable);
}


// virtual int GetStereoRender()
// "virtual int GetStereoRender ()"
public int GetStereoRender() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetStereoRender_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// void SetStereoRender(int stereo)
// "void SetStereoRender(int stereo)"
public void SetStereoRender(int /*(int)*/ stereo) {
	VTK_API.API_vtkRenderWindow.SetStereoRender_0(this, stereo);
}


// virtual void StereoRenderOn()
// "virtual void StereoRenderOn ()"
public void StereoRenderOn() {
	VTK_API.API_vtkRenderWindow.StereoRenderOn_0(this);
}


// virtual void StereoRenderOff()
// "virtual void StereoRenderOff ()"
public void StereoRenderOff() {
	VTK_API.API_vtkRenderWindow.StereoRenderOff_0(this);
}


// virtual void SetAlphaBitPlanes(int _arg)
// "virtual void SetAlphaBitPlanes (int _arg)"
public void SetAlphaBitPlanes(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAlphaBitPlanes_0(this, _arg);
}


// virtual int GetAlphaBitPlanes()
// "virtual int GetAlphaBitPlanes ()"
public int GetAlphaBitPlanes() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetAlphaBitPlanes_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void AlphaBitPlanesOn()
// "virtual void AlphaBitPlanesOn ()"
public void AlphaBitPlanesOn() {
	VTK_API.API_vtkRenderWindow.AlphaBitPlanesOn_0(this);
}


// virtual void AlphaBitPlanesOff()
// "virtual void AlphaBitPlanesOff ()"
public void AlphaBitPlanesOff() {
	VTK_API.API_vtkRenderWindow.AlphaBitPlanesOff_0(this);
}


// virtual void SetPointSmoothing(int _arg)
// "virtual void SetPointSmoothing (int _arg)"
public void SetPointSmoothing(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetPointSmoothing_0(this, _arg);
}


// virtual int GetPointSmoothing()
// "virtual int GetPointSmoothing ()"
public int GetPointSmoothing() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetPointSmoothing_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PointSmoothingOn()
// "virtual void PointSmoothingOn ()"
public void PointSmoothingOn() {
	VTK_API.API_vtkRenderWindow.PointSmoothingOn_0(this);
}


// virtual void PointSmoothingOff()
// "virtual void PointSmoothingOff ()"
public void PointSmoothingOff() {
	VTK_API.API_vtkRenderWindow.PointSmoothingOff_0(this);
}


// virtual void SetLineSmoothing(int _arg)
// "virtual void SetLineSmoothing (int _arg)"
public void SetLineSmoothing(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetLineSmoothing_0(this, _arg);
}


// virtual int GetLineSmoothing()
// "virtual int GetLineSmoothing ()"
public int GetLineSmoothing() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetLineSmoothing_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void LineSmoothingOn()
// "virtual void LineSmoothingOn ()"
public void LineSmoothingOn() {
	VTK_API.API_vtkRenderWindow.LineSmoothingOn_0(this);
}


// virtual void LineSmoothingOff()
// "virtual void LineSmoothingOff ()"
public void LineSmoothingOff() {
	VTK_API.API_vtkRenderWindow.LineSmoothingOff_0(this);
}


// virtual void SetPolygonSmoothing(int _arg)
// "virtual void SetPolygonSmoothing (int _arg)"
public void SetPolygonSmoothing(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetPolygonSmoothing_0(this, _arg);
}


// virtual int GetPolygonSmoothing()
// "virtual int GetPolygonSmoothing ()"
public int GetPolygonSmoothing() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetPolygonSmoothing_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void PolygonSmoothingOn()
// "virtual void PolygonSmoothingOn ()"
public void PolygonSmoothingOn() {
	VTK_API.API_vtkRenderWindow.PolygonSmoothingOn_0(this);
}


// virtual void PolygonSmoothingOff()
// "virtual void PolygonSmoothingOff ()"
public void PolygonSmoothingOff() {
	VTK_API.API_vtkRenderWindow.PolygonSmoothingOff_0(this);
}


// virtual int GetStereoType()
// "virtual int GetStereoType ()"
public int GetStereoType() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetStereoType_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetStereoType(int _arg)
// "virtual void SetStereoType (int _arg)"
public void SetStereoType(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetStereoType_0(this, _arg);
}


// void SetStereoTypeToCrystalEyes()
// "void SetStereoTypeToCrystalEyes()"
public void SetStereoTypeToCrystalEyes() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToCrystalEyes_0(this);
}


// void SetStereoTypeToRedBlue()
// "void SetStereoTypeToRedBlue()"
public void SetStereoTypeToRedBlue() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToRedBlue_0(this);
}


// void SetStereoTypeToInterlaced()
// "void SetStereoTypeToInterlaced()"
public void SetStereoTypeToInterlaced() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToInterlaced_0(this);
}


// void SetStereoTypeToLeft()
// "void SetStereoTypeToLeft()"
public void SetStereoTypeToLeft() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToLeft_0(this);
}


// void SetStereoTypeToRight()
// "void SetStereoTypeToRight()"
public void SetStereoTypeToRight() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToRight_0(this);
}


// void SetStereoTypeToDresden()
// "void SetStereoTypeToDresden()"
public void SetStereoTypeToDresden() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToDresden_0(this);
}


// void SetStereoTypeToAnaglyph()
// "void SetStereoTypeToAnaglyph()"
public void SetStereoTypeToAnaglyph() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToAnaglyph_0(this);
}


// void SetStereoTypeToCheckerboard()
// "void SetStereoTypeToCheckerboard()"
public void SetStereoTypeToCheckerboard() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToCheckerboard_0(this);
}


// void SetStereoTypeToSplitViewportHorizontal()
// "void SetStereoTypeToSplitViewportHorizontal()"
public void SetStereoTypeToSplitViewportHorizontal() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToSplitViewportHorizontal_0(this);
}


// void SetStereoTypeToFake()
// "void SetStereoTypeToFake()"
public void SetStereoTypeToFake() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToFake_0(this);
}


// char* GetStereoTypeAsString()
// "const char *GetStereoTypeAsString()"
public string GetStereoTypeAsString() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetStereoTypeAsString_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual void StereoUpdate()
// "virtual void StereoUpdate()"
public void StereoUpdate() {
	VTK_API.API_vtkRenderWindow.StereoUpdate_0(this);
}


// virtual void StereoMidpoint()
// "virtual void StereoMidpoint()"
public void StereoMidpoint() {
	VTK_API.API_vtkRenderWindow.StereoMidpoint_0(this);
}


// virtual void StereoRenderComplete()
// "virtual void StereoRenderComplete()"
public void StereoRenderComplete() {
	VTK_API.API_vtkRenderWindow.StereoRenderComplete_0(this);
}


// virtual void SetAnaglyphColorSaturation(float _arg)
// "virtual void SetAnaglyphColorSaturation (float _arg)"
public void SetAnaglyphColorSaturation(float /*(float)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorSaturation_0(this, _arg);
}


// virtual float GetAnaglyphColorSaturationMinValue()
// "virtual float GetAnaglyphColorSaturationMinValue ()"
public float GetAnaglyphColorSaturationMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturationMinValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetAnaglyphColorSaturationMaxValue()
// "virtual float GetAnaglyphColorSaturationMaxValue ()"
public float GetAnaglyphColorSaturationMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturationMaxValue_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual float GetAnaglyphColorSaturation()
// "virtual float GetAnaglyphColorSaturation ()"
public float GetAnaglyphColorSaturation() {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturation_0(returnPointer.GetPtr(), this);
	return (float)returnPointer;
}


// virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
// "virtual void SetAnaglyphColorMask (int _arg1, int _arg2)"
public void SetAnaglyphColorMask(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorMask_0(this, _arg1, _arg2);
}


// void SetAnaglyphColorMask(int _arg[2])
// "void SetAnaglyphColorMask (int _arg[2])"
public void SetAnaglyphColorMask(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorMask_1(this, _arg);
}


// virtual int* GetAnaglyphColorMask()
// "virtual int *GetAnaglyphColorMask ()"
public IntPtr GetAnaglyphColorMask() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorMask_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// virtual void GetAnaglyphColorMask(int data[2])
// "virtual void GetAnaglyphColorMask (int data[2])"
public void GetAnaglyphColorMask(int /*(int[2])*/ []data) {
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorMask_1(this, data);
}


// virtual void WindowRemap()
// "virtual void WindowRemap()"
public void WindowRemap() {
	VTK_API.API_vtkRenderWindow.WindowRemap_0(this);
}


// virtual void SetSwapBuffers(int _arg)
// "virtual void SetSwapBuffers (int _arg)"
public void SetSwapBuffers(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetSwapBuffers_0(this, _arg);
}


// virtual int GetSwapBuffers()
// "virtual int GetSwapBuffers ()"
public int GetSwapBuffers() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetSwapBuffers_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SwapBuffersOn()
// "virtual void SwapBuffersOn ()"
public void SwapBuffersOn() {
	VTK_API.API_vtkRenderWindow.SwapBuffersOn_0(this);
}


// virtual void SwapBuffersOff()
// "virtual void SwapBuffersOff ()"
public void SwapBuffersOff() {
	VTK_API.API_vtkRenderWindow.SwapBuffersOff_0(this);
}


// virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int right = 0)
// "virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char *data, int front, int right=0)"
public int SetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetPixelData_0(returnPointer.GetPtr(), this, x, y, x2, y2, data, front, right);
	return (int)returnPointer;
}


// virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int right = 0)
// "virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int right=0)"
public int SetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetPixelData_1(returnPointer.GetPtr(), this, x, y, x2, y2, data, front, right);
	return (int)returnPointer;
}


// virtual float* GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// "virtual float *GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right=0)"
public IntPtr GetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRGBAPixelData_0(returnPointer.GetPtr(), this, x, y, x2, y2, front, right);
	return (IntPtr)returnPointer;
}


// virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray * data, int right = 0)
// "virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray *data, int right=0)"
public int GetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, vtkFloatArray /*(vtkFloatArray*)*/ data, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetRGBAPixelData_1(returnPointer.GetPtr(), this, x, y, x2, y2, front, data, right);
	return (int)returnPointer;
}


// virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float * ARG_0, int front, int blend = 0, int right = 0)
// "virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float *, int front, int blend=0, int right=0)"
public int SetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ ARG_0, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetRGBAPixelData_0(returnPointer.GetPtr(), this, x, y, x2, y2, ARG_0, front, blend, right);
	return (int)returnPointer;
}


// virtual int SetRGBAPixelData(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkFloatArray * ARG_4, int ARG_5, int blend = 0, int right = 0)
// "virtual int SetRGBAPixelData(int, int, int, int, vtkFloatArray*, int, int blend=0, int right=0)"
public int SetRGBAPixelData(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, vtkFloatArray /*(vtkFloatArray*)*/ ARG_4, int /*(int)*/ ARG_5, int /*(int)*/ blend, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetRGBAPixelData_1(returnPointer.GetPtr(), this, ARG_0, ARG_1, ARG_2, ARG_3, ARG_4, ARG_5, blend, right);
	return (int)returnPointer;
}


// virtual void ReleaseRGBAPixelData(float * data)
// "virtual void ReleaseRGBAPixelData(float *data)"
public void ReleaseRGBAPixelData(IntPtr /*(float*)*/ data) {
	VTK_API.API_vtkRenderWindow.ReleaseRGBAPixelData_0(this, data);
}


// virtual char* GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// "virtual unsigned char *GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right=0)"
public string GetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetRGBACharPixelData_0(returnPointer.GetPtr(), this, x, y, x2, y2, front, right);
	return (string)returnPointer;
}


// virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray * data, int right = 0)
// "virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray *data, int right=0)"
public int GetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetRGBACharPixelData_1(returnPointer.GetPtr(), this, x, y, x2, y2, front, data, right);
	return (int)returnPointer;
}


// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int blend = 0, int right = 0)
// "virtual int SetRGBACharPixelData(int x,int y, int x2, int y2, unsigned char *data, int front, int blend=0, int right=0)"
public int SetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetRGBACharPixelData_0(returnPointer.GetPtr(), this, x, y, x2, y2, data, front, blend, right);
	return (int)returnPointer;
}


// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int blend = 0, int right = 0)
// "virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int blend=0, int right=0)"
public int SetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetRGBACharPixelData_1(returnPointer.GetPtr(), this, x, y, x2, y2, data, front, blend, right);
	return (int)returnPointer;
}


// virtual float* GetZbufferData(int x, int y, int x2, int y2)
// "virtual float *GetZbufferData(int x, int y, int x2, int y2)"
public IntPtr GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2) {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetZbufferData_0(returnPointer.GetPtr(), this, x, y, x2, y2);
	return (IntPtr)returnPointer;
}


// virtual int GetZbufferData(int x, int y, int x2, int y2, float * z)
// "virtual int GetZbufferData(int x, int y, int x2, int y2, float *z)"
public int GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetZbufferData_1(returnPointer.GetPtr(), this, x, y, x2, y2, z);
	return (int)returnPointer;
}


// virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// "virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)"
public int GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkFloatArray /*(vtkFloatArray*)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetZbufferData_2(returnPointer.GetPtr(), this, x, y, x2, y2, z);
	return (int)returnPointer;
}


// virtual int SetZbufferData(int x, int y, int x2, int y2, float * z)
// "virtual int SetZbufferData(int x, int y, int x2, int y2, float *z)"
public int SetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, IntPtr /*(float*)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetZbufferData_0(returnPointer.GetPtr(), this, x, y, x2, y2, z);
	return (int)returnPointer;
}


// virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// "virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)"
public int SetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkFloatArray /*(vtkFloatArray*)*/ z) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetZbufferData_1(returnPointer.GetPtr(), this, x, y, x2, y2, z);
	return (int)returnPointer;
}


// float GetZbufferDataAtPoint(int x, int y)
// "float GetZbufferDataAtPoint(int x, int y)"
public float GetZbufferDataAtPoint(int /*(int)*/ x, int /*(int)*/ y) {
	ReturnPointer returnPointer = new ReturnPointer(new float());
	VTK_API.API_vtkRenderWindow.GetZbufferDataAtPoint_0(returnPointer.GetPtr(), this, x, y);
	return (float)returnPointer;
}


// virtual int GetNeverRendered()
// "virtual int GetNeverRendered ()"
public int GetNeverRendered() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetNeverRendered_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetAbortRender()
// "virtual int GetAbortRender ()"
public int GetAbortRender() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetAbortRender_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetAbortRender(int _arg)
// "virtual void SetAbortRender (int _arg)"
public void SetAbortRender(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAbortRender_0(this, _arg);
}


// virtual int GetInAbortCheck()
// "virtual int GetInAbortCheck ()"
public int GetInAbortCheck() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetInAbortCheck_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetInAbortCheck(int _arg)
// "virtual void SetInAbortCheck (int _arg)"
public void SetInAbortCheck(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetInAbortCheck_0(this, _arg);
}


// virtual int CheckAbortStatus()
// "virtual int CheckAbortStatus()"
public int CheckAbortStatus() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.CheckAbortStatus_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetIsPicking()
// "virtual int GetIsPicking ()"
public int GetIsPicking() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetIsPicking_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetIsPicking(int _arg)
// "virtual void SetIsPicking (int _arg)"
public void SetIsPicking(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetIsPicking_0(this, _arg);
}


// virtual void IsPickingOn()
// "virtual void IsPickingOn ()"
public void IsPickingOn() {
	VTK_API.API_vtkRenderWindow.IsPickingOn_0(this);
}


// virtual void IsPickingOff()
// "virtual void IsPickingOff ()"
public void IsPickingOff() {
	VTK_API.API_vtkRenderWindow.IsPickingOff_0(this);
}


// virtual int GetEventPending()
// "virtual int GetEventPending()"
public int GetEventPending() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetEventPending_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int CheckInRenderStatus()
// "virtual int CheckInRenderStatus()"
public int CheckInRenderStatus() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.CheckInRenderStatus_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void ClearInRenderStatus()
// "virtual void ClearInRenderStatus()"
public void ClearInRenderStatus() {
	VTK_API.API_vtkRenderWindow.ClearInRenderStatus_0(this);
}


// virtual void SetDesiredUpdateRate(double ARG_0)
// "virtual void SetDesiredUpdateRate(double)"
public void SetDesiredUpdateRate(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetDesiredUpdateRate_0(this, ARG_0);
}


// virtual double GetDesiredUpdateRate()
// "virtual double GetDesiredUpdateRate ()"
public double GetDesiredUpdateRate() {
	ReturnPointer returnPointer = new ReturnPointer(new double());
	VTK_API.API_vtkRenderWindow.GetDesiredUpdateRate_0(returnPointer.GetPtr(), this);
	return (double)returnPointer;
}


// virtual int GetNumberOfLayers()
// "virtual int GetNumberOfLayers ()"
public int GetNumberOfLayers() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetNumberOfLayers_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetNumberOfLayers(int _arg)
// "virtual void SetNumberOfLayers (int _arg)"
public void SetNumberOfLayers(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetNumberOfLayers_0(this, _arg);
}


// virtual int GetNumberOfLayersMinValue()
// "virtual int GetNumberOfLayersMinValue ()"
public int GetNumberOfLayersMinValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetNumberOfLayersMinValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetNumberOfLayersMaxValue()
// "virtual int GetNumberOfLayersMaxValue ()"
public int GetNumberOfLayersMaxValue() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetNumberOfLayersMaxValue_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor *GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetInteractor_0(returnPointer.GetPtr(), this);
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// void SetInteractor(vtkRenderWindowInteractor * ARG_0)
// "void SetInteractor(vtkRenderWindowInteractor *)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetInteractor_0(this, ARG_0);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkRenderWindow.UnRegister_0(this, o);
}


// void SetDisplayId(void * ARG_0)
// "void SetDisplayId(void *)"
public void SetDisplayId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetDisplayId_0(this, ARG_0);
}


// void SetWindowId(void * ARG_0)
// "void SetWindowId(void *)"
public void SetWindowId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetWindowId_0(this, ARG_0);
}


// virtual void SetNextWindowId(void * ARG_0)
// "virtual void SetNextWindowId(void *)"
public void SetNextWindowId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetNextWindowId_0(this, ARG_0);
}


// void SetParentId(void * ARG_0)
// "void SetParentId(void *)"
public void SetParentId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetParentId_0(this, ARG_0);
}


// void* GetGenericDisplayId()
// "void *GetGenericDisplayId()"
public IntPtr GetGenericDisplayId() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetGenericDisplayId_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void* GetGenericWindowId()
// "void *GetGenericWindowId()"
public IntPtr GetGenericWindowId() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetGenericWindowId_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void* GetGenericParentId()
// "void *GetGenericParentId()"
public IntPtr GetGenericParentId() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetGenericParentId_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void* GetGenericContext()
// "void *GetGenericContext()"
public IntPtr GetGenericContext() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetGenericContext_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void* GetGenericDrawable()
// "void *GetGenericDrawable()"
public IntPtr GetGenericDrawable() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.GetGenericDrawable_0(returnPointer.GetPtr(), this);
	return (IntPtr)returnPointer;
}


// void SetWindowInfo(char * ARG_0)
// "void SetWindowInfo(char *)"
public void SetWindowInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetWindowInfo_0(this, ARG_0);
}


// virtual void SetNextWindowInfo(char * ARG_0)
// "virtual void SetNextWindowInfo(char *)"
public void SetNextWindowInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetNextWindowInfo_0(this, ARG_0);
}


// void SetParentInfo(char * ARG_0)
// "void SetParentInfo(char *)"
public void SetParentInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetParentInfo_0(this, ARG_0);
}


// virtual bool InitializeFromCurrentContext()
// "virtual bool InitializeFromCurrentContext()"
public bool InitializeFromCurrentContext() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.InitializeFromCurrentContext_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// void MakeCurrent()
// "void MakeCurrent()"
public void MakeCurrent() {
	VTK_API.API_vtkRenderWindow.MakeCurrent_0(this);
}


// virtual bool IsCurrent()
// "virtual bool IsCurrent()"
public bool IsCurrent() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.IsCurrent_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual bool IsDrawable()
// "virtual bool IsDrawable()"
public bool IsDrawable() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.IsDrawable_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetForceMakeCurrent()
// "virtual void SetForceMakeCurrent()"
public void SetForceMakeCurrent() {
	VTK_API.API_vtkRenderWindow.SetForceMakeCurrent_0(this);
}


// virtual char* ReportCapabilities()
// "virtual const char *ReportCapabilities()"
public string ReportCapabilities() {
	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	VTK_API.API_vtkRenderWindow.ReportCapabilities_0(returnPointer.GetPtr(), this);
	return (string)returnPointer;
}


// virtual int SupportsOpenGL()
// "virtual int SupportsOpenGL()"
public int SupportsOpenGL() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SupportsOpenGL_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int IsDirect()
// "virtual int IsDirect()"
public int IsDirect() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.IsDirect_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetDepthBufferSize()
// "virtual int GetDepthBufferSize()"
public int GetDepthBufferSize() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetDepthBufferSize_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetColorBufferSizes(int * rgba)
// "virtual int GetColorBufferSizes(int *rgba)"
public int GetColorBufferSizes(IntPtr /*(int*)*/ rgba) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetColorBufferSizes_0(returnPointer.GetPtr(), this, rgba);
	return (int)returnPointer;
}


// virtual void SetMultiSamples(int _arg)
// "virtual void SetMultiSamples (int _arg)"
public void SetMultiSamples(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetMultiSamples_0(this, _arg);
}


// virtual int GetMultiSamples()
// "virtual int GetMultiSamples ()"
public int GetMultiSamples() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetMultiSamples_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void SetStencilCapable(int _arg)
// "virtual void SetStencilCapable (int _arg)"
public void SetStencilCapable(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetStencilCapable_0(this, _arg);
}


// virtual int GetStencilCapable()
// "virtual int GetStencilCapable ()"
public int GetStencilCapable() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetStencilCapable_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual void StencilCapableOn()
// "virtual void StencilCapableOn ()"
public void StencilCapableOn() {
	VTK_API.API_vtkRenderWindow.StencilCapableOn_0(this);
}


// virtual void StencilCapableOff()
// "virtual void StencilCapableOff ()"
public void StencilCapableOff() {
	VTK_API.API_vtkRenderWindow.StencilCapableOff_0(this);
}


// virtual void SetDeviceIndex(int _arg)
// "virtual void SetDeviceIndex (int _arg)"
public void SetDeviceIndex(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetDeviceIndex_0(this, _arg);
}


// virtual int GetDeviceIndex()
// "virtual int GetDeviceIndex ()"
public int GetDeviceIndex() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetDeviceIndex_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int GetNumberOfDevices()
// "virtual int GetNumberOfDevices()"
public int GetNumberOfDevices() {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.GetNumberOfDevices_0(returnPointer.GetPtr(), this);
	return (int)returnPointer;
}


// virtual int SetUseOffScreenBuffers(bool ARG_0)
// "virtual int SetUseOffScreenBuffers(bool)"
public int SetUseOffScreenBuffers(bool /*(bool)*/ ARG_0) {
	ReturnPointer returnPointer = new ReturnPointer(new int());
	VTK_API.API_vtkRenderWindow.SetUseOffScreenBuffers_0(returnPointer.GetPtr(), this, ARG_0);
	return (int)returnPointer;
}


// virtual bool GetUseOffScreenBuffers()
// "virtual bool GetUseOffScreenBuffers()"
public bool GetUseOffScreenBuffers() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.GetUseOffScreenBuffers_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual bool GetUseSRGBColorSpace()
// "virtual bool GetUseSRGBColorSpace ()"
public bool GetUseSRGBColorSpace() {
	ReturnPointer returnPointer = new ReturnPointer(new bool());
	VTK_API.API_vtkRenderWindow.GetUseSRGBColorSpace_0(returnPointer.GetPtr(), this);
	return (bool)returnPointer;
}


// virtual void SetUseSRGBColorSpace(bool _arg)
// "virtual void SetUseSRGBColorSpace (bool _arg)"
public void SetUseSRGBColorSpace(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetUseSRGBColorSpace_0(this, _arg);
}


// virtual void UseSRGBColorSpaceOn()
// "virtual void UseSRGBColorSpaceOn ()"
public void UseSRGBColorSpaceOn() {
	VTK_API.API_vtkRenderWindow.UseSRGBColorSpaceOn_0(this);
}


// virtual void UseSRGBColorSpaceOff()
// "virtual void UseSRGBColorSpaceOff ()"
public void UseSRGBColorSpaceOff() {
	VTK_API.API_vtkRenderWindow.UseSRGBColorSpaceOff_0(this);
}


}
};
