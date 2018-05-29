
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractMapper {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractMapper* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractMapper* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractMapper* NewInstance()
// vtkAbstractMapper *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject);

// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// virtual void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// virtual double GetTimeToDraw()
// virtual double GetTimeToDraw ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetTimeToDraw_0")] public static extern 
bool GetTimeToDraw_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject);

// void AddClippingPlane(vtkPlane * plane)
// void AddClippingPlane(vtkPlane *plane)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_AddClippingPlane_0")] public static extern 
bool AddClippingPlane_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkPlane*)*/ plane);

// void RemoveClippingPlane(vtkPlane * plane)
// void RemoveClippingPlane(vtkPlane *plane)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_RemoveClippingPlane_0")] public static extern 
bool RemoveClippingPlane_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkPlane*)*/ plane);

// void RemoveAllClippingPlanes()
// void RemoveAllClippingPlanes()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_RemoveAllClippingPlanes_0")] public static extern 
bool RemoveAllClippingPlanes_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject);

// virtual void SetClippingPlanes(vtkPlaneCollection * ARG_0)
// virtual void SetClippingPlanes(vtkPlaneCollection*)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_SetClippingPlanes_0")] public static extern 
bool SetClippingPlanes_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkPlaneCollection*)*/ ARG_0);

// virtual vtkPlaneCollection* GetClippingPlanes()
// virtual vtkPlaneCollection *GetClippingPlanes ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetClippingPlanes_0")] public static extern 
bool GetClippingPlanes_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject);

// void SetClippingPlanes(vtkPlanes * planes)
// void SetClippingPlanes(vtkPlanes *planes)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_SetClippingPlanes_1")] public static extern 
bool SetClippingPlanes_1(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkPlanes*)*/ planes);

// void ShallowCopy(vtkAbstractMapper * m)
// void ShallowCopy(vtkAbstractMapper *m)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkAbstractMapper*)*/ callingObject, IntPtr /*(vtkAbstractMapper*)*/ m);

// static vtkDataArray* GetScalars(vtkDataSet * input, int scalarMode, int arrayAccessMode, int arrayId, const char * arrayName, int & cellFlag)
// static vtkDataArray *GetScalars(vtkDataSet *input, int scalarMode, int arrayAccessMode, int arrayId, const char *arrayName, int& cellFlag)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetScalars_0")] public static extern 
bool GetScalars_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ input, int /*(int)*/ scalarMode, int /*(int)*/ arrayAccessMode, int /*(int)*/ arrayId, string /*(char*)*/ arrayName, IntPtr /*(int&)*/ cellFlag);

// static vtkAbstractArray* GetAbstractScalars(vtkDataSet * input, int scalarMode, int arrayAccessMode, int arrayId, const char * arrayName, int & cellFlag)
// static vtkAbstractArray *GetAbstractScalars(vtkDataSet *input, int scalarMode, int arrayAccessMode, int arrayId, const char *arrayName, int& cellFlag)
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetAbstractScalars_0")] public static extern 
bool GetAbstractScalars_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkDataSet*)*/ input, int /*(int)*/ scalarMode, int /*(int)*/ arrayAccessMode, int /*(int)*/ arrayId, string /*(char*)*/ arrayName, IntPtr /*(int&)*/ cellFlag);

// int GetNumberOfClippingPlanes()
// int GetNumberOfClippingPlanes()
[DllImport("vtkplugin", EntryPoint="vtkAbstractMapper_GetNumberOfClippingPlanes_0")] public static extern 
bool GetNumberOfClippingPlanes_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractMapper*)*/ callingObject);

}
};
