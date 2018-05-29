
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAbstractVolumeMapper {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, string /*(char*)*/ type);

// static vtkAbstractVolumeMapper* SafeDownCast(vtkObjectBase * o)
// static vtkAbstractVolumeMapper* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAbstractVolumeMapper* NewInstance()
// vtkAbstractVolumeMapper *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// vtkDataSet* GetDataSetInput()
// vtkDataSet *GetDataSetInput()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetDataSetInput_0")] public static extern 
bool GetDataSetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// vtkDataObject* GetDataObjectInput()
// vtkDataObject *GetDataObjectInput()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetDataObjectInput_0")] public static extern 
bool GetDataObjectInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, double /*(double[6])*/ []bounds);

// virtual void SetScalarMode(int _arg)
// virtual void SetScalarMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarMode_0")] public static extern 
bool SetScalarMode_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetScalarMode()
// virtual int GetScalarMode ()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetScalarMode_0")] public static extern 
bool GetScalarMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual void SetArrayAccessMode(int _arg)
// virtual void SetArrayAccessMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetArrayAccessMode_0")] public static extern 
bool SetArrayAccessMode_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, int /*(int)*/ _arg);

// void SetScalarModeToDefault()
// void SetScalarModeToDefault()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarModeToDefault_0")] public static extern 
bool SetScalarModeToDefault_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// void SetScalarModeToUsePointData()
// void SetScalarModeToUsePointData()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarModeToUsePointData_0")] public static extern 
bool SetScalarModeToUsePointData_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// void SetScalarModeToUseCellData()
// void SetScalarModeToUseCellData()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarModeToUseCellData_0")] public static extern 
bool SetScalarModeToUseCellData_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// void SetScalarModeToUsePointFieldData()
// void SetScalarModeToUsePointFieldData()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_0")] public static extern 
bool SetScalarModeToUsePointFieldData_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// void SetScalarModeToUseCellFieldData()
// void SetScalarModeToUseCellFieldData()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_0")] public static extern 
bool SetScalarModeToUseCellFieldData_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual void SelectScalarArray(int arrayNum)
// virtual void SelectScalarArray(int arrayNum)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SelectScalarArray_0")] public static extern 
bool SelectScalarArray_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, int /*(int)*/ arrayNum);

// virtual void SelectScalarArray(const char * arrayName)
// virtual void SelectScalarArray(const char* arrayName)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_SelectScalarArray_1")] public static extern 
bool SelectScalarArray_1(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, string /*(char*)*/ arrayName);

// virtual char* GetArrayName()
// virtual char* GetArrayName()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetArrayName_0")] public static extern 
bool GetArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual int GetArrayId()
// virtual int GetArrayId()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetArrayId_0")] public static extern 
bool GetArrayId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual int GetArrayAccessMode()
// virtual int GetArrayAccessMode()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetArrayAccessMode_0")] public static extern 
bool GetArrayAccessMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// char* GetScalarModeAsString()
// const char *GetScalarModeAsString()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetScalarModeAsString_0")] public static extern 
bool GetScalarModeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual float GetGradientMagnitudeScale()
// virtual float GetGradientMagnitudeScale()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetGradientMagnitudeScale_0")] public static extern 
bool GetGradientMagnitudeScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual float GetGradientMagnitudeBias()
// virtual float GetGradientMagnitudeBias()
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetGradientMagnitudeBias_0")] public static extern 
bool GetGradientMagnitudeBias_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject);

// virtual float GetGradientMagnitudeScale(int ARG_0)
// virtual float GetGradientMagnitudeScale(int)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetGradientMagnitudeScale_1")] public static extern 
bool GetGradientMagnitudeScale_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual float GetGradientMagnitudeBias(int ARG_0)
// virtual float GetGradientMagnitudeBias(int)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_GetGradientMagnitudeBias_1")] public static extern 
bool GetGradientMagnitudeBias_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, int /*(int)*/ ARG_0);

// virtual void Render(vtkRenderer * ren, vtkVolume * vol)
// virtual void Render(vtkRenderer *ren, vtkVolume *vol)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(vtkVolume*)*/ vol);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkAbstractVolumeMapper_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkAbstractVolumeMapper*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

}
};
