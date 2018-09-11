
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkMapper {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMapper_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkMapper_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, string /*(char*)*/ type);

// static vtkMapper* SafeDownCast(vtkObjectBase * o)
// static vtkMapper* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkMapper* NewInstance()
// vtkMapper *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkMapper_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// void ShallowCopy(vtkAbstractMapper * m)
// void ShallowCopy(vtkAbstractMapper *m)
[DllImport("vtkplugin", EntryPoint="vtkMapper_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkAbstractMapper*)*/ m);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void Render(vtkRenderer * ren, vtkActor * a)
// virtual void Render(vtkRenderer *ren, vtkActor *a)
[DllImport("vtkplugin", EntryPoint="vtkMapper_Render_0")] public static extern 
bool Render_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkRenderer*)*/ ren, IntPtr /*(vtkActor*)*/ a);

// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// void ReleaseGraphicsResources(vtkWindow *)
[DllImport("vtkplugin", EntryPoint="vtkMapper_ReleaseGraphicsResources_0")] public static extern 
bool ReleaseGraphicsResources_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkWindow*)*/ ARG_0);

// void SetLookupTable(vtkScalarsToColors * lut)
// void SetLookupTable(vtkScalarsToColors *lut)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetLookupTable_0")] public static extern 
bool SetLookupTable_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ lut);

// vtkScalarsToColors* GetLookupTable()
// vtkScalarsToColors *GetLookupTable()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetLookupTable_0")] public static extern 
bool GetLookupTable_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void CreateDefaultLookupTable()
// virtual void CreateDefaultLookupTable()
[DllImport("vtkplugin", EntryPoint="vtkMapper_CreateDefaultLookupTable_0")] public static extern 
bool CreateDefaultLookupTable_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetScalarVisibility(int _arg)
// virtual void SetScalarVisibility (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarVisibility_0")] public static extern 
bool SetScalarVisibility_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetScalarVisibility()
// virtual int GetScalarVisibility ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetScalarVisibility_0")] public static extern 
bool GetScalarVisibility_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void ScalarVisibilityOn()
// virtual void ScalarVisibilityOn ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_ScalarVisibilityOn_0")] public static extern 
bool ScalarVisibilityOn_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void ScalarVisibilityOff()
// virtual void ScalarVisibilityOff ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_ScalarVisibilityOff_0")] public static extern 
bool ScalarVisibilityOff_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetStatic(int _arg)
// virtual void SetStatic (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetStatic_0")] public static extern 
bool SetStatic_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetStatic()
// virtual int GetStatic ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetStatic_0")] public static extern 
bool GetStatic_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void StaticOn()
// virtual void StaticOn ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_StaticOn_0")] public static extern 
bool StaticOn_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void StaticOff()
// virtual void StaticOff ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_StaticOff_0")] public static extern 
bool StaticOff_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetColorMode(int _arg)
// virtual void SetColorMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetColorMode_0")] public static extern 
bool SetColorMode_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetColorMode()
// virtual int GetColorMode ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetColorMode_0")] public static extern 
bool GetColorMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// void SetColorModeToDefault()
// void SetColorModeToDefault()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetColorModeToDefault_0")] public static extern 
bool SetColorModeToDefault_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetColorModeToMapScalars()
// void SetColorModeToMapScalars()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetColorModeToMapScalars_0")] public static extern 
bool SetColorModeToMapScalars_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetColorModeToDirectScalars()
// void SetColorModeToDirectScalars()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetColorModeToDirectScalars_0")] public static extern 
bool SetColorModeToDirectScalars_0(IntPtr /*(vtkMapper*)*/ callingObject);

// char* GetColorModeAsString()
// const char *GetColorModeAsString()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetColorModeAsString_0")] public static extern 
bool GetColorModeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetInterpolateScalarsBeforeMapping(int _arg)
// virtual void SetInterpolateScalarsBeforeMapping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetInterpolateScalarsBeforeMapping_0")] public static extern 
bool SetInterpolateScalarsBeforeMapping_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetInterpolateScalarsBeforeMapping()
// virtual int GetInterpolateScalarsBeforeMapping ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetInterpolateScalarsBeforeMapping_0")] public static extern 
bool GetInterpolateScalarsBeforeMapping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void InterpolateScalarsBeforeMappingOn()
// virtual void InterpolateScalarsBeforeMappingOn ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_InterpolateScalarsBeforeMappingOn_0")] public static extern 
bool InterpolateScalarsBeforeMappingOn_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void InterpolateScalarsBeforeMappingOff()
// virtual void InterpolateScalarsBeforeMappingOff ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_InterpolateScalarsBeforeMappingOff_0")] public static extern 
bool InterpolateScalarsBeforeMappingOff_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetUseLookupTableScalarRange(int _arg)
// virtual void SetUseLookupTableScalarRange (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetUseLookupTableScalarRange_0")] public static extern 
bool SetUseLookupTableScalarRange_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetUseLookupTableScalarRange()
// virtual int GetUseLookupTableScalarRange ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetUseLookupTableScalarRange_0")] public static extern 
bool GetUseLookupTableScalarRange_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void UseLookupTableScalarRangeOn()
// virtual void UseLookupTableScalarRangeOn ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_UseLookupTableScalarRangeOn_0")] public static extern 
bool UseLookupTableScalarRangeOn_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void UseLookupTableScalarRangeOff()
// virtual void UseLookupTableScalarRangeOff ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_UseLookupTableScalarRangeOff_0")] public static extern 
bool UseLookupTableScalarRangeOff_0(IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetScalarRange(double _arg1, double _arg2)
// virtual void SetScalarRange (double _arg1, double _arg2)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarRange_0")] public static extern 
bool SetScalarRange_0(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ _arg1, double /*(double)*/ _arg2);

// void SetScalarRange(double _arg[2])
// void SetScalarRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarRange_1")] public static extern 
bool SetScalarRange_1(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double[2])*/ []_arg);

// virtual double* GetScalarRange()
// virtual double *GetScalarRange ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetScalarRange_0")] public static extern 
bool GetScalarRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void GetScalarRange(double data[2])
// virtual void GetScalarRange (double data[2])
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetScalarRange_1")] public static extern 
bool GetScalarRange_1(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double[2])*/ []data);

// virtual void SetScalarMode(int _arg)
// virtual void SetScalarMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarMode_0")] public static extern 
bool SetScalarMode_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetScalarMode()
// virtual int GetScalarMode ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetScalarMode_0")] public static extern 
bool GetScalarMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToDefault()
// void SetScalarModeToDefault()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToDefault_0")] public static extern 
bool SetScalarModeToDefault_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToUsePointData()
// void SetScalarModeToUsePointData()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToUsePointData_0")] public static extern 
bool SetScalarModeToUsePointData_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToUseCellData()
// void SetScalarModeToUseCellData()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToUseCellData_0")] public static extern 
bool SetScalarModeToUseCellData_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToUsePointFieldData()
// void SetScalarModeToUsePointFieldData()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToUsePointFieldData_0")] public static extern 
bool SetScalarModeToUsePointFieldData_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToUseCellFieldData()
// void SetScalarModeToUseCellFieldData()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToUseCellFieldData_0")] public static extern 
bool SetScalarModeToUseCellFieldData_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SetScalarModeToUseFieldData()
// void SetScalarModeToUseFieldData()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetScalarModeToUseFieldData_0")] public static extern 
bool SetScalarModeToUseFieldData_0(IntPtr /*(vtkMapper*)*/ callingObject);

// void SelectColorArray(int arrayNum)
// void SelectColorArray(int arrayNum)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SelectColorArray_0")] public static extern 
bool SelectColorArray_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ arrayNum);

// void SelectColorArray(const char * arrayName)
// void SelectColorArray(const char* arrayName)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SelectColorArray_1")] public static extern 
bool SelectColorArray_1(IntPtr /*(vtkMapper*)*/ callingObject, string /*(char*)*/ arrayName);

// virtual void SetFieldDataTupleId(vtkIdType _arg)
// virtual void SetFieldDataTupleId (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetFieldDataTupleId_0")] public static extern 
bool SetFieldDataTupleId_0(IntPtr /*(vtkMapper*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetFieldDataTupleId()
// virtual vtkIdType GetFieldDataTupleId ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetFieldDataTupleId_0")] public static extern 
bool GetFieldDataTupleId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// void ColorByArrayComponent(int arrayNum, int component)
// void ColorByArrayComponent(int arrayNum, int component)
[DllImport("vtkplugin", EntryPoint="vtkMapper_ColorByArrayComponent_0")] public static extern 
bool ColorByArrayComponent_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ arrayNum, int /*(int)*/ component);

// void ColorByArrayComponent(const char * arrayName, int component)
// void ColorByArrayComponent(const char* arrayName, int component)
[DllImport("vtkplugin", EntryPoint="vtkMapper_ColorByArrayComponent_1")] public static extern 
bool ColorByArrayComponent_1(IntPtr /*(vtkMapper*)*/ callingObject, string /*(char*)*/ arrayName, int /*(int)*/ component);

// virtual char* GetArrayName()
// virtual char* GetArrayName ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetArrayName_0")] public static extern 
bool GetArrayName_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetArrayName(const char * _arg)
// virtual void SetArrayName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetArrayName_0")] public static extern 
bool SetArrayName_0(IntPtr /*(vtkMapper*)*/ callingObject, string /*(char*)*/ _arg);

// virtual int GetArrayId()
// virtual int GetArrayId ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetArrayId_0")] public static extern 
bool GetArrayId_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetArrayId(int _arg)
// virtual void SetArrayId (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetArrayId_0")] public static extern 
bool SetArrayId_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetArrayAccessMode()
// virtual int GetArrayAccessMode ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetArrayAccessMode_0")] public static extern 
bool GetArrayAccessMode_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetArrayAccessMode(int _arg)
// virtual void SetArrayAccessMode (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetArrayAccessMode_0")] public static extern 
bool SetArrayAccessMode_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetArrayComponent()
// virtual int GetArrayComponent ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetArrayComponent_0")] public static extern 
bool GetArrayComponent_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual void SetArrayComponent(int _arg)
// virtual void SetArrayComponent (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetArrayComponent_0")] public static extern 
bool SetArrayComponent_0(IntPtr /*(vtkMapper*)*/ callingObject, int /*(int)*/ _arg);

// char* GetScalarModeAsString()
// const char *GetScalarModeAsString()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetScalarModeAsString_0")] public static extern 
bool GetScalarModeAsString_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// static void SetResolveCoincidentTopology(int val)
// static void SetResolveCoincidentTopology(int val)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopology_0")] public static extern 
bool SetResolveCoincidentTopology_0(int /*(int)*/ val);

// static int GetResolveCoincidentTopology()
// static int GetResolveCoincidentTopology()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopology_0")] public static extern 
bool GetResolveCoincidentTopology_0(IntPtr /*(IntPtr*)*/ return_value);

// static void SetResolveCoincidentTopologyToDefault()
// static void SetResolveCoincidentTopologyToDefault()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyToDefault_0")] public static extern 
bool SetResolveCoincidentTopologyToDefault_0();

// static void SetResolveCoincidentTopologyToOff()
// static void SetResolveCoincidentTopologyToOff()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyToOff_0")] public static extern 
bool SetResolveCoincidentTopologyToOff_0();

// static void SetResolveCoincidentTopologyToPolygonOffset()
// static void SetResolveCoincidentTopologyToPolygonOffset()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyToPolygonOffset_0")] public static extern 
bool SetResolveCoincidentTopologyToPolygonOffset_0();

// static void SetResolveCoincidentTopologyToShiftZBuffer()
// static void SetResolveCoincidentTopologyToShiftZBuffer()
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyToShiftZBuffer_0")] public static extern 
bool SetResolveCoincidentTopologyToShiftZBuffer_0();

// static void SetResolveCoincidentTopologyPolygonOffsetParameters(double factor, double units)
// static void SetResolveCoincidentTopologyPolygonOffsetParameters( double factor, double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyPolygonOffsetParameters_0")] public static extern 
bool SetResolveCoincidentTopologyPolygonOffsetParameters_0(double /*(double)*/ factor, double /*(double)*/ units);

// static void GetResolveCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// static void GetResolveCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopologyPolygonOffsetParameters_0")] public static extern 
bool GetResolveCoincidentTopologyPolygonOffsetParameters_0(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// void SetRelativeCoincidentTopologyPolygonOffsetParameters(double factor, double units)
// void SetRelativeCoincidentTopologyPolygonOffsetParameters( double factor, double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetRelativeCoincidentTopologyPolygonOffsetParameters_0")] public static extern 
bool SetRelativeCoincidentTopologyPolygonOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ factor, double /*(double)*/ units);

// void GetRelativeCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// void GetRelativeCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetRelativeCoincidentTopologyPolygonOffsetParameters_0")] public static extern 
bool GetRelativeCoincidentTopologyPolygonOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// static void SetResolveCoincidentTopologyLineOffsetParameters(double factor, double units)
// static void SetResolveCoincidentTopologyLineOffsetParameters( double factor, double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyLineOffsetParameters_0")] public static extern 
bool SetResolveCoincidentTopologyLineOffsetParameters_0(double /*(double)*/ factor, double /*(double)*/ units);

// static void GetResolveCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// static void GetResolveCoincidentTopologyLineOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopologyLineOffsetParameters_0")] public static extern 
bool GetResolveCoincidentTopologyLineOffsetParameters_0(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// void SetRelativeCoincidentTopologyLineOffsetParameters(double factor, double units)
// void SetRelativeCoincidentTopologyLineOffsetParameters( double factor, double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetRelativeCoincidentTopologyLineOffsetParameters_0")] public static extern 
bool SetRelativeCoincidentTopologyLineOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ factor, double /*(double)*/ units);

// void GetRelativeCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// void GetRelativeCoincidentTopologyLineOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetRelativeCoincidentTopologyLineOffsetParameters_0")] public static extern 
bool GetRelativeCoincidentTopologyLineOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// static void SetResolveCoincidentTopologyPointOffsetParameter(double units)
// static void SetResolveCoincidentTopologyPointOffsetParameter( double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyPointOffsetParameter_0")] public static extern 
bool SetResolveCoincidentTopologyPointOffsetParameter_0(double /*(double)*/ units);

// static void GetResolveCoincidentTopologyPointOffsetParameter(double & units)
// static void GetResolveCoincidentTopologyPointOffsetParameter( double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopologyPointOffsetParameter_0")] public static extern 
bool GetResolveCoincidentTopologyPointOffsetParameter_0(IntPtr /*(double&)*/ units);

// void SetRelativeCoincidentTopologyPointOffsetParameter(double units)
// void SetRelativeCoincidentTopologyPointOffsetParameter(double units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetRelativeCoincidentTopologyPointOffsetParameter_0")] public static extern 
bool SetRelativeCoincidentTopologyPointOffsetParameter_0(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ units);

// void GetRelativeCoincidentTopologyPointOffsetParameter(double & units)
// void GetRelativeCoincidentTopologyPointOffsetParameter(double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetRelativeCoincidentTopologyPointOffsetParameter_0")] public static extern 
bool GetRelativeCoincidentTopologyPointOffsetParameter_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ units);

// void GetCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// void GetCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetCoincidentTopologyPolygonOffsetParameters_0")] public static extern 
bool GetCoincidentTopologyPolygonOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// void GetCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// void GetCoincidentTopologyLineOffsetParameters( double& factor, double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetCoincidentTopologyLineOffsetParameters_0")] public static extern 
bool GetCoincidentTopologyLineOffsetParameters_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units);

// void GetCoincidentTopologyPointOffsetParameter(double & units)
// void GetCoincidentTopologyPointOffsetParameter(double& units)
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetCoincidentTopologyPointOffsetParameter_0")] public static extern 
bool GetCoincidentTopologyPointOffsetParameter_0(IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(double&)*/ units);

// static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
// static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyPolygonOffsetFaces_0")] public static extern 
bool SetResolveCoincidentTopologyPolygonOffsetFaces_0(int /*(int)*/ faces);

// static int GetResolveCoincidentTopologyPolygonOffsetFaces()
// static int GetResolveCoincidentTopologyPolygonOffsetFaces()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopologyPolygonOffsetFaces_0")] public static extern 
bool GetResolveCoincidentTopologyPolygonOffsetFaces_0(IntPtr /*(IntPtr*)*/ return_value);

// static void SetResolveCoincidentTopologyZShift(double val)
// static void SetResolveCoincidentTopologyZShift(double val)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetResolveCoincidentTopologyZShift_0")] public static extern 
bool SetResolveCoincidentTopologyZShift_0(double /*(double)*/ val);

// static double GetResolveCoincidentTopologyZShift()
// static double GetResolveCoincidentTopologyZShift()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetResolveCoincidentTopologyZShift_0")] public static extern 
bool GetResolveCoincidentTopologyZShift_0(IntPtr /*(IntPtr*)*/ return_value);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double[6])*/ []bounds);

// void SetRenderTime(double time)
// void SetRenderTime(double time)
[DllImport("vtkplugin", EntryPoint="vtkMapper_SetRenderTime_0")] public static extern 
bool SetRenderTime_0(IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ time);

// virtual double GetRenderTime()
// virtual double GetRenderTime ()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetRenderTime_0")] public static extern 
bool GetRenderTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// vtkDataSet* GetInput()
// vtkDataSet *GetInput()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetInput_0")] public static extern 
bool GetInput_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// vtkDataSet* GetInputAsDataSet()
// vtkDataSet *GetInputAsDataSet()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetInputAsDataSet_0")] public static extern 
bool GetInputAsDataSet_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual vtkUnsignedCharArray* MapScalars(double alpha)
// virtual vtkUnsignedCharArray *MapScalars(double alpha)
[DllImport("vtkplugin", EntryPoint="vtkMapper_MapScalars_0")] public static extern 
bool MapScalars_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ alpha);

// virtual vtkUnsignedCharArray* MapScalars(double alpha, int & cellFlag)
// virtual vtkUnsignedCharArray *MapScalars(double alpha, int &cellFlag)
[DllImport("vtkplugin", EntryPoint="vtkMapper_MapScalars_1")] public static extern 
bool MapScalars_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, double /*(double)*/ alpha, IntPtr /*(int&)*/ cellFlag);

// virtual vtkUnsignedCharArray* MapScalars(vtkDataSet * input, double alpha)
// virtual vtkUnsignedCharArray *MapScalars(vtkDataSet *input, double alpha)
[DllImport("vtkplugin", EntryPoint="vtkMapper_MapScalars_2")] public static extern 
bool MapScalars_2(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ input, double /*(double)*/ alpha);

// virtual vtkUnsignedCharArray* MapScalars(vtkDataSet * input, double alpha, int & cellFlag)
// virtual vtkUnsignedCharArray *MapScalars(vtkDataSet *input, double alpha, int &cellFlag)
[DllImport("vtkplugin", EntryPoint="vtkMapper_MapScalars_3")] public static extern 
bool MapScalars_3(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ input, double /*(double)*/ alpha, IntPtr /*(int&)*/ cellFlag);

// virtual bool GetIsOpaque()
// virtual bool GetIsOpaque()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetIsOpaque_0")] public static extern 
bool GetIsOpaque_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual bool GetSupportsSelection()
// virtual bool GetSupportsSelection()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetSupportsSelection_0")] public static extern 
bool GetSupportsSelection_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// virtual int CanUseTextureMapForColoring(vtkDataObject * input)
// virtual int CanUseTextureMapForColoring(vtkDataObject* input)
[DllImport("vtkplugin", EntryPoint="vtkMapper_CanUseTextureMapForColoring_0")] public static extern 
bool CanUseTextureMapForColoring_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ input);

// void ClearColorArrays()
// void ClearColorArrays()
[DllImport("vtkplugin", EntryPoint="vtkMapper_ClearColorArrays_0")] public static extern 
bool ClearColorArrays_0(IntPtr /*(vtkMapper*)*/ callingObject);

// vtkUnsignedCharArray* GetColorMapColors()
// vtkUnsignedCharArray *GetColorMapColors()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetColorMapColors_0")] public static extern 
bool GetColorMapColors_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// vtkFloatArray* GetColorCoordinates()
// vtkFloatArray *GetColorCoordinates()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetColorCoordinates_0")] public static extern 
bool GetColorCoordinates_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

// vtkImageData* GetColorTextureMap()
// vtkImageData* GetColorTextureMap()
[DllImport("vtkplugin", EntryPoint="vtkMapper_GetColorTextureMap_0")] public static extern 
bool GetColorTextureMap_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkMapper*)*/ callingObject);

}
};
