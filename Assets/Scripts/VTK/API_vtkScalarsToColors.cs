
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkScalarsToColors {

//       Method: virtual const char * vtkScalarsToColors::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: static vtkScalarsToColors * vtkScalarsToColors::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkScalarsToColors_New_0")] public static extern 
bool New(IntPtr /*vtkScalarsToColors** */ ret);

//       Method: virtual int vtkScalarsToColors::IsOpaque()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_IsOpaque_0")] public static extern 
bool IsOpaque(IntPtr /*int* */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual void vtkScalarsToColors::Build()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_Build_0")] public static extern 
bool Build(IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual double * vtkScalarsToColors::GetRange()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetRange_0")] public static extern 
bool GetRange(IntPtr /*double** */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual void vtkScalarsToColors::SetRange(double min, double max)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetRange_0")] public static extern 
bool SetRange(IntPtr /*vtkScalarsToColors* */ obj, double min, double max);

//       Method: virtual void vtkScalarsToColors::SetRange(const double rng[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetRange_1")] public static extern 
bool SetRange(IntPtr /*vtkScalarsToColors* */ obj, double[] /*2*/ rng);

//       Method: virtual void vtkScalarsToColors::GetColor(double v, double rgb[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetColor_0")] public static extern 
bool GetColor(IntPtr /*vtkScalarsToColors* */ obj, double v, double[] /*3*/ rgb);

//       Method: double * vtkScalarsToColors::GetColor(double v)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetColor_1")] public static extern 
bool GetColor(IntPtr /*double** */ ret, IntPtr /*vtkScalarsToColors* */ obj, double v);

//       Method: virtual double vtkScalarsToColors::GetOpacity(double v)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetOpacity_0")] public static extern 
bool GetOpacity(IntPtr /*double* */ ret, IntPtr /*vtkScalarsToColors* */ obj, double v);

//       Method: double vtkScalarsToColors::GetLuminance(double x)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetLuminance_0")] public static extern 
bool GetLuminance(IntPtr /*double* */ ret, IntPtr /*vtkScalarsToColors* */ obj, double x);

//       Method: virtual void vtkScalarsToColors::SetAlpha(double alpha)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetAlpha_0")] public static extern 
bool SetAlpha(IntPtr /*vtkScalarsToColors* */ obj, double alpha);

//       Method: virtual vtkUnsignedCharArray * vtkScalarsToColors::MapScalars(vtkDataArray* scalars, int colorMode, int component)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalars_0")] public static extern 
bool MapScalars(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkDataArray* */ scalars, int colorMode, int component);

//       Method: virtual vtkUnsignedCharArray * vtkScalarsToColors::MapScalars(vtkAbstractArray* scalars, int colorMode, int component)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalars_1")] public static extern 
//bool MapScalars(IntPtr /*vtkUnsignedCharArray** */ ret, IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkAbstractArray* */ scalars, int colorMode, int component);

//       Method: void vtkScalarsToColors::SetVectorModeToMagnitude()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetVectorModeToMagnitude_0")] public static extern 
bool SetVectorModeToMagnitude(IntPtr /*vtkScalarsToColors* */ obj);

//       Method: void vtkScalarsToColors::SetVectorModeToComponent()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetVectorModeToComponent_0")] public static extern 
bool SetVectorModeToComponent(IntPtr /*vtkScalarsToColors* */ obj);

//       Method: void vtkScalarsToColors::SetVectorModeToRGBColors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetVectorModeToRGBColors_0")] public static extern 
bool SetVectorModeToRGBColors(IntPtr /*vtkScalarsToColors* */ obj);

//       Method: void vtkScalarsToColors::MapVectorsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapVectorsThroughTable_0")] public static extern 
bool MapVectorsThroughTable(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*void* */ input, IntPtr/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize);

//       Method: void vtkScalarsToColors::MapVectorsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapVectorsThroughTable_1")] public static extern 
bool MapVectorsThroughTable(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*void* */ input, IntPtr/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

//       Method: void vtkScalarsToColors::MapScalarsThroughTable(vtkDataArray* scalars, unsigned char* output, int outputFormat)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalarsThroughTable_0")] public static extern 
bool MapScalarsThroughTable(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkDataArray* */ scalars, IntPtr/*unsigned char* */ output, int outputFormat);

//       Method: void vtkScalarsToColors::MapScalarsThroughTable(vtkDataArray* scalars, unsigned char* output)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalarsThroughTable_1")] public static extern 
bool MapScalarsThroughTable(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkDataArray* */ scalars, IntPtr/*unsigned char* */ output);

//       Method: void vtkScalarsToColors::MapScalarsThroughTable(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalarsThroughTable_2")] public static extern 
bool MapScalarsThroughTable(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*void* */ input, IntPtr/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

//       Method: virtual void vtkScalarsToColors::MapScalarsThroughTable2(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*void* */ input, IntPtr/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

//       Method: virtual void vtkScalarsToColors::DeepCopy(vtkScalarsToColors* o)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkScalarsToColors* */ o);

//       Method: virtual int vtkScalarsToColors::UsingLogScale()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_UsingLogScale_0")] public static extern 
bool UsingLogScale(IntPtr /*int* */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual vtkIdType vtkScalarsToColors::GetNumberOfAvailableColors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual void vtkScalarsToColors::SetAnnotations(vtkAbstractArray* values, vtkStringArray* annotations)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_SetAnnotations_0")] public static extern 
bool SetAnnotations(IntPtr /*vtkScalarsToColors* */ obj, IntPtr/*vtkAbstractArray* */ values, IntPtr/*vtkStringArray* */ annotations);

//       Method: vtkIdType vtkScalarsToColors::GetNumberOfAnnotatedValues()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetNumberOfAnnotatedValues_0")] public static extern 
bool GetNumberOfAnnotatedValues(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkScalarsToColors* */ obj);

//       Method: virtual void vtkScalarsToColors::GetIndexedColor(vtkIdType i, double rgba[4])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_GetIndexedColor_0")] public static extern 
bool GetIndexedColor(IntPtr /*vtkScalarsToColors* */ obj, long i, double[] /*4*/ rgba);

//       Method: virtual void vtkScalarsToColors::ResetAnnotations()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_ResetAnnotations_0")] public static extern 
bool ResetAnnotations(IntPtr /*vtkScalarsToColors* */ obj);

////       Method: void vtkScalarsToColors::ColorToUChar(T t, unsigned char* dest)
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkScalarsToColors_ColorToUChar_0")] public static extern 
//bool ColorToUChar(IntPtr /*vtkScalarsToColors* */ obj, T t, IntPtr/*unsigned char* */ dest);
//
}
};
