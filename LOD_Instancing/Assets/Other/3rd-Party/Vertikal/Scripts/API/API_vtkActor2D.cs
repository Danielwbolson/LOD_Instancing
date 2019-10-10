
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkActor2D {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject, string /*(char*)*/ type);

// static vtkActor2D* SafeDownCast(vtkObjectBase * o)
// static vtkActor2D* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkActor2D* NewInstance()
// vtkActor2D *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// static vtkActor2D* New()
// static vtkActor2D* New()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int RenderOverlay(vtkViewport * viewport)
// int RenderOverlay(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_RenderOverlay_0")] public static extern 
bool RenderOverlay_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// int RenderOpaqueGeometry(vtkViewport * viewport)
// int RenderOpaqueGeometry(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_RenderOpaqueGeometry_0")] public static extern 
bool RenderOpaqueGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// int RenderTranslucentPolygonalGeometry(vtkViewport * viewport)
// int RenderTranslucentPolygonalGeometry(vtkViewport *viewport)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_RenderTranslucentPolygonalGeometry_0")] public static extern 
bool RenderTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkViewport*)*/ viewport);

// int HasTranslucentPolygonalGeometry()
// int HasTranslucentPolygonalGeometry()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_HasTranslucentPolygonalGeometry_0")] public static extern 
bool HasTranslucentPolygonalGeometry_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual void SetMapper(vtkMapper2D * mapper)
// virtual void SetMapper(vtkMapper2D *mapper)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetMapper_0")] public static extern 
bool SetMapper_0(IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkMapper2D*)*/ mapper);

// virtual vtkMapper2D* GetMapper()
// virtual vtkMapper2D *GetMapper ()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetMapper_0")] public static extern 
bool GetMapper_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual void SetLayerNumber(int _arg)
// virtual void SetLayerNumber (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetLayerNumber_0")] public static extern 
bool SetLayerNumber_0(IntPtr /*(vtkActor2D*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetLayerNumber()
// virtual int GetLayerNumber ()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetLayerNumber_0")] public static extern 
bool GetLayerNumber_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// vtkProperty2D* GetProperty()
// vtkProperty2D* GetProperty()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetProperty_0")] public static extern 
bool GetProperty_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual void SetProperty(vtkProperty2D * ARG_0)
// virtual void SetProperty(vtkProperty2D*)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetProperty_0")] public static extern 
bool SetProperty_0(IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkProperty2D*)*/ ARG_0);

// virtual vtkCoordinate* GetPositionCoordinate()
// virtual vtkCoordinate *GetPositionCoordinate ()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetPositionCoordinate_0")] public static extern 
bool GetPositionCoordinate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual void SetPosition(double x[2])
// virtual void SetPosition(double x[2])
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetPosition_0")] public static extern 
bool SetPosition_0(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double[2])*/ []x);

// virtual void SetPosition(double x, double y)
// virtual void SetPosition(double x, double y)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetPosition_1")] public static extern 
bool SetPosition_1(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y);

// virtual double* GetPosition()
// virtual double *GetPosition()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetPosition_0")] public static extern 
bool GetPosition_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// void SetDisplayPosition(int ARG_0, int ARG_1)
// void SetDisplayPosition(int,int)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetDisplayPosition_0")] public static extern 
bool SetDisplayPosition_0(IntPtr /*(vtkActor2D*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1);

// virtual vtkCoordinate* GetPosition2Coordinate()
// virtual vtkCoordinate *GetPosition2Coordinate ()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetPosition2Coordinate_0")] public static extern 
bool GetPosition2Coordinate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual void SetPosition2(double x[2])
// virtual void SetPosition2(double x[2])
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetPosition2_0")] public static extern 
bool SetPosition2_0(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double[2])*/ []x);

// virtual void SetPosition2(double x, double y)
// virtual void SetPosition2(double x, double y)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetPosition2_1")] public static extern 
bool SetPosition2_1(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y);

// virtual double* GetPosition2()
// virtual double *GetPosition2()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetPosition2_0")] public static extern 
bool GetPosition2_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// void SetWidth(double w)
// void SetWidth(double w)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetWidth_0")] public static extern 
bool SetWidth_0(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double)*/ w);

// double GetWidth()
// double GetWidth()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetWidth_0")] public static extern 
bool GetWidth_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// void SetHeight(double h)
// void SetHeight(double h)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_SetHeight_0")] public static extern 
bool SetHeight_0(IntPtr /*(vtkActor2D*)*/ callingObject, double /*(double)*/ h);

// double GetHeight()
// double GetHeight()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetHeight_0")] public static extern 
bool GetHeight_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// void GetActors2D(vtkPropCollection * pc)
// void GetActors2D(vtkPropCollection *pc)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetActors2D_0")] public static extern 
bool GetActors2D_0(IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkPropCollection*)*/ pc);

// void ShallowCopy(vtkProp * prop)
// void ShallowCopy(vtkProp *prop)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkProp*)*/ prop);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkActor2D*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// virtual vtkCoordinate* GetActualPositionCoordinate()
// virtual vtkCoordinate *GetActualPositionCoordinate(void)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetActualPositionCoordinate_0")] public static extern 
bool GetActualPositionCoordinate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

// virtual vtkCoordinate* GetActualPosition2Coordinate()
// virtual vtkCoordinate *GetActualPosition2Coordinate(void)
[DllImport("vtkplugin", EntryPoint="vtkActor2D_GetActualPosition2Coordinate_0")] public static extern 
bool GetActualPosition2Coordinate_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkActor2D*)*/ callingObject);

}
};
