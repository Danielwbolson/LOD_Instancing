
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkRenderState {

// bool IsValid()
// bool IsValid()
[DllImport("vtkplugin", EntryPoint="vtkRenderState_IsValid_0")] public static extern 
bool IsValid_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderState*)*/ callingObject);

// vtkRenderer* GetRenderer()
// vtkRenderer *GetRenderer()
[DllImport("vtkplugin", EntryPoint="vtkRenderState_GetRenderer_0")] public static extern 
bool GetRenderer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderState*)*/ callingObject);

// vtkFrameBufferObjectBase* GetFrameBuffer()
// vtkFrameBufferObjectBase *GetFrameBuffer()
[DllImport("vtkplugin", EntryPoint="vtkRenderState_GetFrameBuffer_0")] public static extern 
bool GetFrameBuffer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkRenderState*)*/ callingObject);

// void SetFrameBuffer(vtkFrameBufferObjectBase * fbo)
// void SetFrameBuffer(vtkFrameBufferObjectBase *fbo)
[DllImport("vtkplugin", EntryPoint="vtkRenderState_SetFrameBuffer_0")] public static extern 
bool SetFrameBuffer_0(IntPtr /*(vtkRenderState*)*/ callingObject, IntPtr /*(vtkFrameBufferObjectBase*)*/ fbo);

// void GetWindowSize(int size[2])
// void GetWindowSize(int size[2])
[DllImport("vtkplugin", EntryPoint="vtkRenderState_GetWindowSize_0")] public static extern 
bool GetWindowSize_0(IntPtr /*(vtkRenderState*)*/ callingObject, int /*(int[2])*/ []size);

// vtkProp** GetPropArray()
// vtkProp **GetPropArray()
[DllImport("vtkplugin", EntryPoint="vtkRenderState_GetPropArray_0")] public static extern 
bool GetPropArray_0(IntPtr /*(IntPtr***)*/ return_value, IntPtr /*(vtkRenderState*)*/ callingObject);

// int GetPropArrayCount()
// int GetPropArrayCount()
[DllImport("vtkplugin", EntryPoint="vtkRenderState_GetPropArrayCount_0")] public static extern 
bool GetPropArrayCount_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkRenderState*)*/ callingObject);

// void SetPropArrayAndCount(vtkProp ** propArray, int propArrayCount)
// void SetPropArrayAndCount(vtkProp **propArray, int propArrayCount)
[DllImport("vtkplugin", EntryPoint="vtkRenderState_SetPropArrayAndCount_0")] public static extern 
bool SetPropArrayAndCount_0(IntPtr /*(vtkRenderState*)*/ callingObject, IntPtr /*(vtkProp**)*/ propArray, int /*(int)*/ propArrayCount);

}
};
