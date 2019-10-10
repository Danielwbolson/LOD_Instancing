
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkThreshold {

// static vtkThreshold* New()
// static vtkThreshold *New()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject, string /*(char*)*/ type);

// static vtkThreshold* SafeDownCast(vtkObjectBase * o)
// static vtkThreshold* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkThreshold* NewInstance()
// vtkThreshold *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// void ThresholdByLower(double lower)
// void ThresholdByLower(double lower)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_ThresholdByLower_0")] public static extern 
bool ThresholdByLower_0(IntPtr /*(vtkThreshold*)*/ callingObject, double /*(double)*/ lower);

// void ThresholdByUpper(double upper)
// void ThresholdByUpper(double upper)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_ThresholdByUpper_0")] public static extern 
bool ThresholdByUpper_0(IntPtr /*(vtkThreshold*)*/ callingObject, double /*(double)*/ upper);

// void ThresholdBetween(double lower, double upper)
// void ThresholdBetween(double lower, double upper)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_ThresholdBetween_0")] public static extern 
bool ThresholdBetween_0(IntPtr /*(vtkThreshold*)*/ callingObject, double /*(double)*/ lower, double /*(double)*/ upper);

// virtual double GetUpperThreshold()
// virtual double GetUpperThreshold ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetUpperThreshold_0")] public static extern 
bool GetUpperThreshold_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual double GetLowerThreshold()
// virtual double GetLowerThreshold ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetLowerThreshold_0")] public static extern 
bool GetLowerThreshold_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void SetAttributeMode(int _arg)
// virtual void SetAttributeMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetAttributeMode_0")] public static extern 
bool SetAttributeMode_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAttributeMode()
// virtual int GetAttributeMode ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetAttributeMode_0")] public static extern 
bool GetAttributeMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetAttributeModeToDefault()
// void SetAttributeModeToDefault()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetAttributeModeToDefault_0")] public static extern 
bool SetAttributeModeToDefault_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetAttributeModeToUsePointData()
// void SetAttributeModeToUsePointData()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetAttributeModeToUsePointData_0")] public static extern 
bool SetAttributeModeToUsePointData_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetAttributeModeToUseCellData()
// void SetAttributeModeToUseCellData()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetAttributeModeToUseCellData_0")] public static extern 
bool SetAttributeModeToUseCellData_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// char* GetAttributeModeAsString()
// const char *GetAttributeModeAsString()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetAttributeModeAsString_0")] public static extern 
bool GetAttributeModeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void SetComponentMode(int _arg)
// virtual void SetComponentMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetComponentMode_0")] public static extern 
bool SetComponentMode_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetComponentModeMinValue()
// virtual int GetComponentModeMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetComponentModeMinValue_0")] public static extern 
bool GetComponentModeMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual int GetComponentModeMaxValue()
// virtual int GetComponentModeMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetComponentModeMaxValue_0")] public static extern 
bool GetComponentModeMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual int GetComponentMode()
// virtual int GetComponentMode ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetComponentMode_0")] public static extern 
bool GetComponentMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetComponentModeToUseSelected()
// void SetComponentModeToUseSelected()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetComponentModeToUseSelected_0")] public static extern 
bool SetComponentModeToUseSelected_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetComponentModeToUseAll()
// void SetComponentModeToUseAll()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetComponentModeToUseAll_0")] public static extern 
bool SetComponentModeToUseAll_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetComponentModeToUseAny()
// void SetComponentModeToUseAny()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetComponentModeToUseAny_0")] public static extern 
bool SetComponentModeToUseAny_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// char* GetComponentModeAsString()
// const char *GetComponentModeAsString()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetComponentModeAsString_0")] public static extern 
bool GetComponentModeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void SetSelectedComponent(int _arg)
// virtual void SetSelectedComponent (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetSelectedComponent_0")] public static extern 
bool SetSelectedComponent_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetSelectedComponentMinValue()
// virtual int GetSelectedComponentMinValue ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetSelectedComponentMinValue_0")] public static extern 
bool GetSelectedComponentMinValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual int GetSelectedComponentMaxValue()
// virtual int GetSelectedComponentMaxValue ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetSelectedComponentMaxValue_0")] public static extern 
bool GetSelectedComponentMaxValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual int GetSelectedComponent()
// virtual int GetSelectedComponent ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetSelectedComponent_0")] public static extern 
bool GetSelectedComponent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void SetAllScalars(int _arg)
// virtual void SetAllScalars (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetAllScalars_0")] public static extern 
bool SetAllScalars_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAllScalars()
// virtual int GetAllScalars ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetAllScalars_0")] public static extern 
bool GetAllScalars_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void AllScalarsOn()
// virtual void AllScalarsOn ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_AllScalarsOn_0")] public static extern 
bool AllScalarsOn_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void AllScalarsOff()
// virtual void AllScalarsOff ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_AllScalarsOff_0")] public static extern 
bool AllScalarsOff_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void SetUseContinuousCellRange(int _arg)
// virtual void SetUseContinuousCellRange (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetUseContinuousCellRange_0")] public static extern 
bool SetUseContinuousCellRange_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseContinuousCellRange()
// virtual int GetUseContinuousCellRange ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetUseContinuousCellRange_0")] public static extern 
bool GetUseContinuousCellRange_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void UseContinuousCellRangeOn()
// virtual void UseContinuousCellRangeOn ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_UseContinuousCellRangeOn_0")] public static extern 
bool UseContinuousCellRangeOn_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// virtual void UseContinuousCellRangeOff()
// virtual void UseContinuousCellRangeOff ()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_UseContinuousCellRangeOff_0")] public static extern 
bool UseContinuousCellRangeOff_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetPointsDataTypeToDouble()
// void SetPointsDataTypeToDouble()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetPointsDataTypeToDouble_0")] public static extern 
bool SetPointsDataTypeToDouble_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetPointsDataTypeToFloat()
// void SetPointsDataTypeToFloat()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetPointsDataTypeToFloat_0")] public static extern 
bool SetPointsDataTypeToFloat_0(IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetPointsDataType(int type)
// void SetPointsDataType(int type)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetPointsDataType_0")] public static extern 
bool SetPointsDataType_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ type);

// int GetPointsDataType()
// int GetPointsDataType()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetPointsDataType_0")] public static extern 
bool GetPointsDataType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

// void SetOutputPointsPrecision(int precision)
// void SetOutputPointsPrecision(int precision)
[DllImport("vtkplugin", EntryPoint="vtkThreshold_SetOutputPointsPrecision_0")] public static extern 
bool SetOutputPointsPrecision_0(IntPtr /*(vtkThreshold*)*/ callingObject, int /*(int)*/ precision);

// int GetOutputPointsPrecision()
// int GetOutputPointsPrecision()
[DllImport("vtkplugin", EntryPoint="vtkThreshold_GetOutputPointsPrecision_0")] public static extern 
bool GetOutputPointsPrecision_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkThreshold*)*/ callingObject);

}
};
