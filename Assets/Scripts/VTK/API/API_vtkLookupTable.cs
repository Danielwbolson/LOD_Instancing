
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkLookupTable {

// static vtkLookupTable* New()
// static vtkLookupTable *New()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// int IsOpaque()
// int IsOpaque()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_IsOpaque_0")] public static extern 
bool IsOpaque_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// int Allocate(int sz = 256, int ext = 256)
// int Allocate(int sz=256, int ext=256)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ sz, int /*(int)*/ ext);

// void Build()
// void Build()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_Build_0")] public static extern 
bool Build_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void ForceBuild()
// virtual void ForceBuild()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_ForceBuild_0")] public static extern 
bool ForceBuild_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void BuildSpecialColors()
// void BuildSpecialColors()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_BuildSpecialColors_0")] public static extern 
bool BuildSpecialColors_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRampToLinear()
// void SetRampToLinear()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToLinear_0")] public static extern 
bool SetRampToLinear_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRampToSCurve()
// void SetRampToSCurve()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToSCurve_0")] public static extern 
bool SetRampToSCurve_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRampToSQRT()
// void SetRampToSQRT()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRampToSQRT_0")] public static extern 
bool SetRampToSQRT_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetScale(int scale)
// void SetScale(int scale)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScale_0")] public static extern 
bool SetScale_0(IntPtr /*(vtkLookupTable*)*/ callingObject, int /*(int)*/ scale);

// void SetScaleToLinear()
// void SetScaleToLinear()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScaleToLinear_0")] public static extern 
bool SetScaleToLinear_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetScaleToLog10()
// void SetScaleToLog10()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetScaleToLog10_0")] public static extern 
bool SetScaleToLog10_0(IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetTableRange(const double r[2])
// virtual void SetTableRange(const double r[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableRange_0")] public static extern 
bool SetTableRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []r);

// virtual void SetTableRange(double min, double max)
// virtual void SetTableRange(double min, double max)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableRange_1")] public static extern 
bool SetTableRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ min, double /*(double)*/ max);

// char* GetNanColorAsUnsignedChars()
// unsigned char* GetNanColorAsUnsignedChars()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNanColorAsUnsignedChars_0")] public static extern 
bool GetNanColorAsUnsignedChars_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// static void GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetColorAsUnsignedChars_0")] public static extern 
bool GetColorAsUnsignedChars_0(double /*(double[4])*/ []colorIn, char /*(unsigned char[4])*/ []colorOut);

// char* MapValue(double v)
// unsigned char* MapValue(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_MapValue_0")] public static extern 
bool MapValue_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// void GetColor(double x, double rgb[3])
// void GetColor(double x, double rgb[3])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ x, double /*(double[3])*/ []rgb);

// double GetOpacity(double v)
// double GetOpacity(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetOpacity_0")] public static extern 
bool GetOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// virtual vtkIdType GetIndex(double v)
// virtual vtkIdType GetIndex(double v)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetIndex_0")] public static extern 
bool GetIndex_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ v);

// void SetNumberOfTableValues(vtkIdType number)
// void SetNumberOfTableValues(vtkIdType number)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetNumberOfTableValues_0")] public static extern 
bool SetNumberOfTableValues_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ number);

// vtkIdType GetNumberOfTableValues()
// vtkIdType GetNumberOfTableValues()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfTableValues_0")] public static extern 
bool GetNumberOfTableValues_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
// virtual void SetTableValue(vtkIdType indx, const double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTableValue_0")] public static extern 
bool SetTableValue_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ indx, double /*(double[4])*/ []rgba);

// double* GetTableValue(vtkIdType id)
// double *GetTableValue(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableValue_0")] public static extern 
bool GetTableValue_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id);

// void GetTableValue(vtkIdType id, double rgba[4])
// void GetTableValue(vtkIdType id, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetTableValue_1")] public static extern 
bool GetTableValue_1(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[4])*/ []rgba);

// char* GetPointer(vtkIdType id)
// unsigned char *GetPointer(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetPointer_0")] public static extern 
bool GetPointer_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id);

// char* WritePointer(vtkIdType id, int number)
// unsigned char *WritePointer(vtkIdType id, int number)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_WritePointer_0")] public static extern 
bool WritePointer_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ id, int /*(int)*/ number);

// double* GetRange()
// double *GetRange()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void SetRange(double min, double max)
// void SetRange(double min, double max)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRange_0")] public static extern 
bool SetRange_0(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double)*/ min, double /*(double)*/ max);

// void SetRange(const double rng[2])
// void SetRange(const double rng[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetRange_1")] public static extern 
bool SetRange_1(IntPtr /*(vtkLookupTable*)*/ callingObject, double /*(double[2])*/ []rng);

// static void GetLogRange(const double range[2], double log_range[2])
// static void GetLogRange(const double range[2], double log_range[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetLogRange_0")] public static extern 
bool GetLogRange_0(double /*(double[2])*/ []range, double /*(double[2])*/ []log_range);

// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
// static double ApplyLogScale(double v, const double range[2], const double log_range[2])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_ApplyLogScale_0")] public static extern 
bool ApplyLogScale_0(IntPtr /*(IntPtr*)*/ return_value, double /*(double)*/ v, double /*(double[2])*/ []range, double /*(double[2])*/ []log_range);

// void SetTable(vtkUnsignedCharArray * ARG_0)
// void SetTable(vtkUnsignedCharArray *)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_SetTable_0")] public static extern 
bool SetTable_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(vtkUnsignedCharArray*)*/ ARG_0);

// void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputIncrement);

// void DeepCopy(vtkScalarsToColors * lut)
// void DeepCopy(vtkScalarsToColors *lut)
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkLookupTable*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ lut);

// int UsingLogScale()
// int UsingLogScale()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_UsingLogScale_0")] public static extern 
bool UsingLogScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// vtkIdType GetNumberOfAvailableColors()
// vtkIdType GetNumberOfAvailableColors()
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkLookupTable*)*/ callingObject);

// void GetIndexedColor(vtkIdType idx, double rgba[4])
// void GetIndexedColor(vtkIdType idx, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkLookupTable_GetIndexedColor_0")] public static extern 
bool GetIndexedColor_0(IntPtr /*(vtkLookupTable*)*/ callingObject, long /*(vtkIdType)*/ idx, double /*(double[4])*/ []rgba);

}
};
