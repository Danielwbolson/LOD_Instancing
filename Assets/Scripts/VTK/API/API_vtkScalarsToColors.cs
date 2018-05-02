
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkScalarsToColors {

// static vtkScalarsToColors* New()
// static vtkScalarsToColors *New()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// virtual int IsOpaque()
// virtual int IsOpaque()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_IsOpaque_0")] public static extern 
bool IsOpaque_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// virtual void Build()
// virtual void Build()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_Build_0")] public static extern 
bool Build_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// virtual double* GetRange()
// virtual double *GetRange()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetRange_0")] public static extern 
bool GetRange_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// virtual void SetRange(double min, double max)
// virtual void SetRange(double min, double max)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetRange_0")] public static extern 
bool SetRange_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ min, double /*(double)*/ max);

// virtual void SetRange(const double rng[2])
// virtual void SetRange(const double rng[2])
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetRange_1")] public static extern 
bool SetRange_1(IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double[2])*/ []rng);

// virtual char* MapValue(double v)
// virtual unsigned char *MapValue(double v)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapValue_0")] public static extern 
bool MapValue_0(IntPtr /*(unsigned IntPtr**)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ v);

// virtual void GetColor(double v, double rgb[3])
// virtual void GetColor(double v, double rgb[3])
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetColor_0")] public static extern 
bool GetColor_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ v, double /*(double[3])*/ []rgb);

// double* GetColor(double v)
// double *GetColor(double v)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetColor_1")] public static extern 
bool GetColor_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ v);

// virtual double GetOpacity(double v)
// virtual double GetOpacity(double v)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetOpacity_0")] public static extern 
bool GetOpacity_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ v);

// double GetLuminance(double x)
// double GetLuminance(double x)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetLuminance_0")] public static extern 
bool GetLuminance_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ x);

// virtual void SetAlpha(double alpha)
// virtual void SetAlpha(double alpha)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetAlpha_0")] public static extern 
bool SetAlpha_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, double /*(double)*/ alpha);

// virtual vtkUnsignedCharArray* MapScalars(vtkDataArray * scalars, int colorMode, int component)
// virtual vtkUnsignedCharArray *MapScalars(vtkDataArray *scalars, int colorMode, int component)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalars_0")] public static extern 
bool MapScalars_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component);

// virtual vtkUnsignedCharArray* MapScalars(vtkAbstractArray * scalars, int colorMode, int component)
// virtual vtkUnsignedCharArray *MapScalars(vtkAbstractArray *scalars, int colorMode, int component)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalars_1")] public static extern 
bool MapScalars_1(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component);

// void SetVectorModeToMagnitude()
// void SetVectorModeToMagnitude()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetVectorModeToMagnitude_0")] public static extern 
bool SetVectorModeToMagnitude_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// void SetVectorModeToComponent()
// void SetVectorModeToComponent()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetVectorModeToComponent_0")] public static extern 
bool SetVectorModeToComponent_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// void SetVectorModeToRGBColors()
// void SetVectorModeToRGBColors()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetVectorModeToRGBColors_0")] public static extern 
bool SetVectorModeToRGBColors_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapVectorsThroughTable_0")] public static extern 
bool MapVectorsThroughTable_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat, int /*(int)*/ vectorComponent, int /*(int)*/ vectorSize);

// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapVectorsThroughTable_1")] public static extern 
bool MapVectorsThroughTable_1(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat);

// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output, int outputFormat)
// void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output, int outputFormat)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalarsThroughTable_0")] public static extern 
bool MapScalarsThroughTable_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output, int /*(int)*/ outputFormat);

// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output)
// void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalarsThroughTable_1")] public static extern 
bool MapScalarsThroughTable_1(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output);

// void MapScalarsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// void MapScalarsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalarsThroughTable_2")] public static extern 
bool MapScalarsThroughTable_2(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat);

// virtual void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// virtual void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat);

// virtual void DeepCopy(vtkScalarsToColors * o)
// virtual void DeepCopy(vtkScalarsToColors *o)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkScalarsToColors*)*/ o);

// virtual int UsingLogScale()
// virtual int UsingLogScale()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_UsingLogScale_0")] public static extern 
bool UsingLogScale_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// virtual vtkIdType GetNumberOfAvailableColors()
// virtual vtkIdType GetNumberOfAvailableColors()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// virtual void SetAnnotations(vtkAbstractArray * values, vtkStringArray * annotations)
// virtual void SetAnnotations( vtkAbstractArray* values, vtkStringArray* annotations )
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetAnnotations_0")] public static extern 
bool SetAnnotations_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ values, IntPtr /*(vtkStringArray*)*/ annotations);

// virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)
// virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_SetAnnotation_0")] public static extern 
bool SetAnnotation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, string /*(vtkStdString)*/ value, string /*(vtkStdString)*/ annotation);

// vtkIdType GetNumberOfAnnotatedValues()
// vtkIdType GetNumberOfAnnotatedValues()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetNumberOfAnnotatedValues_0")] public static extern 
bool GetNumberOfAnnotatedValues_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject);

// vtkStdString GetAnnotation(vtkIdType idx)
// vtkStdString GetAnnotation(vtkIdType idx)
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetAnnotation_0")] public static extern 
bool GetAnnotation_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkScalarsToColors*)*/ callingObject, long /*(vtkIdType)*/ idx);

// virtual void GetIndexedColor(vtkIdType i, double rgba[4])
// virtual void GetIndexedColor(vtkIdType i, double rgba[4])
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_GetIndexedColor_0")] public static extern 
bool GetIndexedColor_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject, long /*(vtkIdType)*/ i, double /*(double[4])*/ []rgba);

// virtual void ResetAnnotations()
// virtual void ResetAnnotations()
[DllImport("vtkplugin", EntryPoint="vtkScalarsToColors_ResetAnnotations_0")] public static extern 
bool ResetAnnotations_0(IntPtr /*(vtkScalarsToColors*)*/ callingObject);

}
};
