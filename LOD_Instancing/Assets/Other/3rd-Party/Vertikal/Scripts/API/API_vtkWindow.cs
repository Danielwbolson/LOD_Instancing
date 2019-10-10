
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkWindow {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkWindow_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkWindow_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject, string /*(char*)*/ type);

// static vtkWindow* SafeDownCast(vtkObjectBase * o)
// static vtkWindow* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkWindow* NewInstance()
// vtkWindow *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkWindow_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetDisplayId(void * ARG_0)
// virtual void SetDisplayId(void *)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetDisplayId_0")] public static extern 
bool SetDisplayId_0(IntPtr /*(vtkWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// virtual void SetWindowId(void * ARG_0)
// virtual void SetWindowId(void *)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetWindowId_0")] public static extern 
bool SetWindowId_0(IntPtr /*(vtkWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// virtual void SetParentId(void * ARG_0)
// virtual void SetParentId(void *)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetParentId_0")] public static extern 
bool SetParentId_0(IntPtr /*(vtkWindow*)*/ callingObject, IntPtr /*(void*)*/ ARG_0);

// virtual void* GetGenericDisplayId()
// virtual void *GetGenericDisplayId()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetGenericDisplayId_0")] public static extern 
bool GetGenericDisplayId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void* GetGenericWindowId()
// virtual void *GetGenericWindowId()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetGenericWindowId_0")] public static extern 
bool GetGenericWindowId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void* GetGenericParentId()
// virtual void *GetGenericParentId()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetGenericParentId_0")] public static extern 
bool GetGenericParentId_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void* GetGenericContext()
// virtual void *GetGenericContext()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetGenericContext_0")] public static extern 
bool GetGenericContext_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void* GetGenericDrawable()
// virtual void *GetGenericDrawable()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetGenericDrawable_0")] public static extern 
bool GetGenericDrawable_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetWindowInfo(char * ARG_0)
// virtual void SetWindowInfo(char *)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetWindowInfo_0")] public static extern 
bool SetWindowInfo_0(IntPtr /*(vtkWindow*)*/ callingObject, string /*(char*)*/ ARG_0);

// virtual void SetParentInfo(char * ARG_0)
// virtual void SetParentInfo(char *)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetParentInfo_0")] public static extern 
bool SetParentInfo_0(IntPtr /*(vtkWindow*)*/ callingObject, string /*(char*)*/ ARG_0);

// virtual int* GetPosition()
// virtual int *GetPosition()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetPosition(int ARG_0, int ARG_1)
// virtual void SetPosition(int,int)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetPosition_0")] public static extern 
bool SetPosition_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1);

// virtual void SetPosition(int a[2])
// virtual void SetPosition(int a[2])
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetPosition_1")] public static extern 
bool SetPosition_1(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int[2])*/ []a);

// virtual int* GetSize()
// virtual int *GetSize()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetSize(int ARG_0, int ARG_1)
// virtual void SetSize(int,int)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetSize_0")] public static extern 
bool SetSize_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1);

// virtual void SetSize(int a[2])
// virtual void SetSize(int a[2])
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetSize_1")] public static extern 
bool SetSize_1(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int[2])*/ []a);

// int* GetActualSize()
// int *GetActualSize()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetActualSize_0")] public static extern 
bool GetActualSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual int* GetScreenSize()
// virtual int *GetScreenSize()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetScreenSize_0")] public static extern 
bool GetScreenSize_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetMapped(int _arg)
// virtual void SetMapped (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetMapped_0")] public static extern 
bool SetMapped_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetMapped()
// virtual int GetMapped ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetMapped_0")] public static extern 
bool GetMapped_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void MappedOn()
// virtual void MappedOn ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_MappedOn_0")] public static extern 
bool MappedOn_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void MappedOff()
// virtual void MappedOff ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_MappedOff_0")] public static extern 
bool MappedOff_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetErase(int _arg)
// virtual void SetErase (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetErase_0")] public static extern 
bool SetErase_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetErase()
// virtual int GetErase ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetErase_0")] public static extern 
bool GetErase_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void EraseOn()
// virtual void EraseOn ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_EraseOn_0")] public static extern 
bool EraseOn_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void EraseOff()
// virtual void EraseOff ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_EraseOff_0")] public static extern 
bool EraseOff_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetDoubleBuffer(int _arg)
// virtual void SetDoubleBuffer (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetDoubleBuffer_0")] public static extern 
bool SetDoubleBuffer_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDoubleBuffer()
// virtual int GetDoubleBuffer ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetDoubleBuffer_0")] public static extern 
bool GetDoubleBuffer_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void DoubleBufferOn()
// virtual void DoubleBufferOn ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_DoubleBufferOn_0")] public static extern 
bool DoubleBufferOn_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void DoubleBufferOff()
// virtual void DoubleBufferOff ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_DoubleBufferOff_0")] public static extern 
bool DoubleBufferOff_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual char* GetWindowName()
// virtual char* GetWindowName ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetWindowName_0")] public static extern 
bool GetWindowName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetWindowName(const char * _arg)
// virtual void SetWindowName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetWindowName_0")] public static extern 
bool SetWindowName_0(IntPtr /*(vtkWindow*)*/ callingObject, string /*(char*)*/ _arg);

// virtual void Render()
// virtual void Render()
[DllImport("vtkplugin", EntryPoint="vtkWindow_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual char* GetPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// virtual unsigned char *GetPixelData(int x, int y, int x2, int y2, int front, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetPixelData_0")] public static extern 
bool GetPixelData_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right);

// virtual int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray * data, int right = 0)
// virtual int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray *data, int right=0)
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetPixelData_1")] public static extern 
bool GetPixelData_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, IntPtr /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ right);

// virtual int GetDPI()
// virtual int GetDPI ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetDPI_0")] public static extern 
bool GetDPI_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetDPI(int _arg)
// virtual void SetDPI (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetDPI_0")] public static extern 
bool SetDPI_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetDPIMinValue()
// virtual int GetDPIMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetDPIMinValue_0")] public static extern 
bool GetDPIMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual int GetDPIMaxValue()
// virtual int GetDPIMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetDPIMaxValue_0")] public static extern 
bool GetDPIMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual bool DetectDPI()
// virtual bool DetectDPI()
[DllImport("vtkplugin", EntryPoint="vtkWindow_DetectDPI_0")] public static extern 
bool DetectDPI_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetOffScreenRendering(int _arg)
// virtual void SetOffScreenRendering (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetOffScreenRendering_0")] public static extern 
bool SetOffScreenRendering_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetOffScreenRendering()
// virtual int GetOffScreenRendering ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetOffScreenRendering_0")] public static extern 
bool GetOffScreenRendering_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void OffScreenRenderingOn()
// virtual void OffScreenRenderingOn ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_OffScreenRenderingOn_0")] public static extern 
bool OffScreenRenderingOn_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void OffScreenRenderingOff()
// virtual void OffScreenRenderingOff ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_OffScreenRenderingOff_0")] public static extern 
bool OffScreenRenderingOff_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void MakeCurrent()
// virtual void MakeCurrent()
[DllImport("vtkplugin", EntryPoint="vtkWindow_MakeCurrent_0")] public static extern 
bool MakeCurrent_0(IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void SetTileScale(int _arg1, int _arg2)
// virtual void SetTileScale (int _arg1, int _arg2)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetTileScale_0")] public static extern 
bool SetTileScale_0(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ _arg1, int /*(int)*/ _arg2);

// void SetTileScale(int _arg[2])
// void SetTileScale (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetTileScale_1")] public static extern 
bool SetTileScale_1(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int[2])*/ []_arg);

// virtual int* GetTileScale()
// virtual int *GetTileScale ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileScale_0")] public static extern 
bool GetTileScale_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void GetTileScale(int & _arg1, int & _arg2)
// virtual void GetTileScale (int &_arg1, int &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileScale_1")] public static extern 
bool GetTileScale_1(IntPtr /*(vtkWindow*)*/ callingObject, IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2);

// virtual void GetTileScale(int _arg[2])
// virtual void GetTileScale (int _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileScale_2")] public static extern 
bool GetTileScale_2(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int[2])*/ []_arg);

// void SetTileScale(int s)
// void SetTileScale(int s)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetTileScale_2")] public static extern 
bool SetTileScale_2(IntPtr /*(vtkWindow*)*/ callingObject, int /*(int)*/ s);

// virtual void SetTileViewport(double _arg1, double _arg2, double _arg3, double _arg4)
// virtual void SetTileViewport (double _arg1, double _arg2, double _arg3, double _arg4)
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetTileViewport_0")] public static extern 
bool SetTileViewport_0(IntPtr /*(vtkWindow*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4);

// virtual void SetTileViewport(double _arg[4])
// virtual void SetTileViewport (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkWindow_SetTileViewport_1")] public static extern 
bool SetTileViewport_1(IntPtr /*(vtkWindow*)*/ callingObject, double /*(double[4])*/ []_arg);

// virtual double* GetTileViewport()
// virtual double *GetTileViewport ()
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileViewport_0")] public static extern 
bool GetTileViewport_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkWindow*)*/ callingObject);

// virtual void GetTileViewport(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// virtual void GetTileViewport (double &_arg1, double &_arg2, double &_arg3, double &_arg4)
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileViewport_1")] public static extern 
bool GetTileViewport_1(IntPtr /*(vtkWindow*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4);

// virtual void GetTileViewport(double _arg[4])
// virtual void GetTileViewport (double _arg[4])
[DllImport("vtkplugin", EntryPoint="vtkWindow_GetTileViewport_2")] public static extern 
bool GetTileViewport_2(IntPtr /*(vtkWindow*)*/ callingObject, double /*(double[4])*/ []_arg);

}
};
