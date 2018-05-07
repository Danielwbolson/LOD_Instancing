
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPiecewiseFunction {

// static vtkPiecewiseFunction* New()
// static vtkPiecewiseFunction *New()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, string /*(char*)*/ type);

// static vtkPiecewiseFunction* SafeDownCast(vtkObjectBase * o)
// static vtkPiecewiseFunction* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPiecewiseFunction* NewInstance()
// vtkPiecewiseFunction *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// void DeepCopy(vtkDataObject * f)
// void DeepCopy( vtkDataObject *f )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ f);

// void ShallowCopy(vtkDataObject * f)
// void ShallowCopy( vtkDataObject *f )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ f);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// int GetSize()
// int GetSize()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetSize_0")] public static extern 
bool GetSize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// int AddPoint(double x, double y)
// int AddPoint( double x, double y )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AddPoint_0")] public static extern 
bool AddPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y);

// int AddPoint(double x, double y, double midpoint, double sharpness)
// int AddPoint( double x, double y, double midpoint, double sharpness )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AddPoint_1")] public static extern 
bool AddPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ midpoint, double /*(double)*/ sharpness);

// int RemovePoint(double x)
// int RemovePoint( double x )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_RemovePoint_0")] public static extern 
bool RemovePoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x);

// void RemoveAllPoints()
// void RemoveAllPoints()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_RemoveAllPoints_0")] public static extern 
bool RemoveAllPoints_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// void AddSegment(double x1, double y1, double x2, double y2)
// void AddSegment( double x1, double y1, double x2, double y2 )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AddSegment_0")] public static extern 
bool AddSegment_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ y1, double /*(double)*/ x2, double /*(double)*/ y2);

// double GetValue(double x)
// double GetValue( double x )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetValue_0")] public static extern 
bool GetValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x);

// int GetNodeValue(int index, double val[4])
// int GetNodeValue( int index, double val[4] )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetNodeValue_0")] public static extern 
bool GetNodeValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, int /*(int)*/ index, double /*(double[4])*/ []val);

// int SetNodeValue(int index, double val[4])
// int SetNodeValue( int index, double val[4] )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_SetNodeValue_0")] public static extern 
bool SetNodeValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, int /*(int)*/ index, double /*(double[4])*/ []val);

// double* GetDataPointer()
// double *GetDataPointer()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetDataPointer_0")] public static extern 
bool GetDataPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// void FillFromDataPointer(int ARG_0, double * ARG_1)
// void FillFromDataPointer(int, double*)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_FillFromDataPointer_0")] public static extern 
bool FillFromDataPointer_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, int /*(int)*/ ARG_0, IntPtr /*(double*)*/ ARG_1);

// virtual double* GetRange()
// virtual double *GetRange ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void GetRange(double & _arg1, double & _arg2)
// virtual void GetRange (double &_arg1, double &_arg2)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetRange_1")] public static extern 
bool GetRange_1(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2);

// virtual void GetRange(double _arg[2])
// virtual void GetRange (double _arg[2])
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetRange_2")] public static extern 
bool GetRange_2(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double[2])*/ []_arg);

// int AdjustRange(double range[2])
// int AdjustRange(double range[2])
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AdjustRange_0")] public static extern 
bool AdjustRange_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double[2])*/ []range);

// void GetTable(double x1, double x2, int size, float * table, int stride = 1)
// void GetTable( double x1, double x2, int size, float *table, int stride=1 )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetTable_0")] public static extern 
bool GetTable_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, IntPtr /*(float*)*/ table, int /*(int)*/ stride);

// void GetTable(double x1, double x2, int size, double * table, int stride = 1)
// void GetTable( double x1, double x2, int size, double *table, int stride=1 )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetTable_1")] public static extern 
bool GetTable_1(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, IntPtr /*(double*)*/ table, int /*(int)*/ stride);

// void BuildFunctionFromTable(double x1, double x2, int size, double * table, int stride = 1)
// void BuildFunctionFromTable( double x1, double x2, int size, double *table, int stride=1 )
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_BuildFunctionFromTable_0")] public static extern 
bool BuildFunctionFromTable_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, IntPtr /*(double*)*/ table, int /*(int)*/ stride);

// virtual void SetClamping(int _arg)
// virtual void SetClamping (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_SetClamping_0")] public static extern 
bool SetClamping_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetClamping()
// virtual int GetClamping ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetClamping_0")] public static extern 
bool GetClamping_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void ClampingOn()
// virtual void ClampingOn ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_ClampingOn_0")] public static extern 
bool ClampingOn_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void ClampingOff()
// virtual void ClampingOff ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_ClampingOff_0")] public static extern 
bool ClampingOff_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void SetUseLogScale(bool _arg)
// virtual void SetUseLogScale (bool _arg)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_SetUseLogScale_0")] public static extern 
bool SetUseLogScale_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, bool /*(bool)*/ _arg);

// virtual bool GetUseLogScale()
// virtual bool GetUseLogScale ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetUseLogScale_0")] public static extern 
bool GetUseLogScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void UseLogScaleOn()
// virtual void UseLogScaleOn ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_UseLogScaleOn_0")] public static extern 
bool UseLogScaleOn_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void UseLogScaleOff()
// virtual void UseLogScaleOff ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_UseLogScaleOff_0")] public static extern 
bool UseLogScaleOff_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// char* GetType()
// const char *GetType()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetType_0")] public static extern 
bool GetType_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// double GetFirstNonZeroValue()
// double GetFirstNonZeroValue()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetFirstNonZeroValue_0")] public static extern 
bool GetFirstNonZeroValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void SetAllowDuplicateScalars(int _arg)
// virtual void SetAllowDuplicateScalars (int _arg)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_SetAllowDuplicateScalars_0")] public static extern 
bool SetAllowDuplicateScalars_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, int /*(int)*/ _arg);

// virtual int GetAllowDuplicateScalars()
// virtual int GetAllowDuplicateScalars ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_GetAllowDuplicateScalars_0")] public static extern 
bool GetAllowDuplicateScalars_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void AllowDuplicateScalarsOn()
// virtual void AllowDuplicateScalarsOn ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AllowDuplicateScalarsOn_0")] public static extern 
bool AllowDuplicateScalarsOn_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// virtual void AllowDuplicateScalarsOff()
// virtual void AllowDuplicateScalarsOff ()
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_AllowDuplicateScalarsOff_0")] public static extern 
bool AllowDuplicateScalarsOff_0(IntPtr /*(vtkPiecewiseFunction*)*/ callingObject);

// int EstimateMinNumberOfSamples(double const& x1, double const& x2)
// int EstimateMinNumberOfSamples(double const & x1, double const & x2)
[DllImport("vtkplugin", EntryPoint="vtkPiecewiseFunction_EstimateMinNumberOfSamples_0")] public static extern 
bool EstimateMinNumberOfSamples_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPiecewiseFunction*)*/ callingObject, IntPtr /*(doubleconst&)*/ x1, IntPtr /*(doubleconst&)*/ x2);

}
};
