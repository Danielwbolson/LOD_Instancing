
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkLookupTable {

//       Method: static vtkLookupTable * vtkLookupTable::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkLookupTable_New_0")] public static extern 
bool New(IntPtr /*vtkLookupTable** */ ret);

//       Method: virtual const char * vtkLookupTable::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: int vtkLookupTable::IsOpaque()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_IsOpaque_0")] public static extern 
bool IsOpaque(IntPtr /*int* */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: int vtkLookupTable::Allocate(int sz, int ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkLookupTable* */ obj, int sz, int ext);

//       Method: void vtkLookupTable::Build()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_Build_0")] public static extern 
bool Build(IntPtr /*vtkLookupTable* */ obj);

//       Method: virtual void vtkLookupTable::ForceBuild()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_ForceBuild_0")] public static extern 
bool ForceBuild(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::BuildSpecialColors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_BuildSpecialColors_0")] public static extern 
bool BuildSpecialColors(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetRampToLinear()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetRampToLinear_0")] public static extern 
bool SetRampToLinear(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetRampToSCurve()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetRampToSCurve_0")] public static extern 
bool SetRampToSCurve(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetRampToSQRT()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetRampToSQRT_0")] public static extern 
bool SetRampToSQRT(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetScale(int scale)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetScale_0")] public static extern 
bool SetScale(IntPtr /*vtkLookupTable* */ obj, int scale);

//       Method: void vtkLookupTable::SetScaleToLinear()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetScaleToLinear_0")] public static extern 
bool SetScaleToLinear(IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetScaleToLog10()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetScaleToLog10_0")] public static extern 
bool SetScaleToLog10(IntPtr /*vtkLookupTable* */ obj);

//       Method: virtual void vtkLookupTable::SetTableRange(const double r[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetTableRange_0")] public static extern 
bool SetTableRange(IntPtr /*vtkLookupTable* */ obj, double[] /*2*/ r);

//       Method: virtual void vtkLookupTable::SetTableRange(double min, double max)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetTableRange_1")] public static extern 
bool SetTableRange(IntPtr /*vtkLookupTable* */ obj, double min, double max);

//       Method: static void vtkLookupTable::GetColorAsUnsignedChars(const double colorIn[4], unsigned char colorOut[4])
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkLookupTable_GetColorAsUnsignedChars_0")] public static extern 
bool GetColorAsUnsignedChars(double[] /*4*/ colorIn, byte[] /*4*/ colorOut);

//       Method: void vtkLookupTable::GetColor(double x, double rgb[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetColor_0")] public static extern 
bool GetColor(IntPtr /*vtkLookupTable* */ obj, double x, double[] /*3*/ rgb);

//       Method: double vtkLookupTable::GetOpacity(double v)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetOpacity_0")] public static extern 
bool GetOpacity(IntPtr /*double* */ ret, IntPtr /*vtkLookupTable* */ obj, double v);

//       Method: virtual vtkIdType vtkLookupTable::GetIndex(double v)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetIndex_0")] public static extern 
bool GetIndex(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkLookupTable* */ obj, double v);

//       Method: void vtkLookupTable::SetNumberOfTableValues(vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetNumberOfTableValues_0")] public static extern 
bool SetNumberOfTableValues(IntPtr /*vtkLookupTable* */ obj, long number);

//       Method: vtkIdType vtkLookupTable::GetNumberOfTableValues()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetNumberOfTableValues_0")] public static extern 
bool GetNumberOfTableValues(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: virtual void vtkLookupTable::SetTableValue(vtkIdType indx, const double rgba[4])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetTableValue_0")] public static extern 
bool SetTableValue(IntPtr /*vtkLookupTable* */ obj, long indx, double[] /*4*/ rgba);

//       Method: virtual void vtkLookupTable::SetTableValue(vtkIdType indx, double r, double g, double b)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetTableValue_1")] public static extern 
bool SetTableValue(IntPtr /*vtkLookupTable* */ obj, long indx, double r, double g, double b);

//       Method: double * vtkLookupTable::GetTableValue(vtkIdType id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetTableValue_0")] public static extern 
bool GetTableValue(IntPtr /*double** */ ret, IntPtr /*vtkLookupTable* */ obj, long id);

//       Method: void vtkLookupTable::GetTableValue(vtkIdType id, double rgba[4])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetTableValue_1")] public static extern 
bool GetTableValue(IntPtr /*vtkLookupTable* */ obj, long id, double[] /*4*/ rgba);

//       Method: double * vtkLookupTable::GetRange()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetRange_0")] public static extern 
bool GetRange(IntPtr /*double** */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::SetRange(double min, double max)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetRange_0")] public static extern 
bool SetRange(IntPtr /*vtkLookupTable* */ obj, double min, double max);

//       Method: void vtkLookupTable::SetRange(const double rng[2])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_SetRange_1")] public static extern 
bool SetRange(IntPtr /*vtkLookupTable* */ obj, double[] /*2*/ rng);

//       Method: static void vtkLookupTable::GetLogRange(const double range[2], double log_range[2])
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkLookupTable_GetLogRange_0")] public static extern 
bool GetLogRange(double[] /*2*/ range, double[] /*2*/ log_range);

//       Method: static double vtkLookupTable::ApplyLogScale(double v, const double range[2], const double log_range[2])
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkLookupTable_ApplyLogScale_0")] public static extern 
bool ApplyLogScale(IntPtr /*double* */ ret, double v, double[] /*2*/ range, double[] /*2*/ log_range);

//       Method: void vtkLookupTable::MapScalarsThroughTable2(void* input, unsigned char* output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_MapScalarsThroughTable2_0")] public static extern 
bool MapScalarsThroughTable2(IntPtr /*vtkLookupTable* */ obj, IntPtr/*void* */ input, IntPtr/*unsigned char* */ output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

//       Method: void vtkLookupTable::DeepCopy(vtkScalarsToColors* lut)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkLookupTable* */ obj, IntPtr/*vtkScalarsToColors* */ lut);

//       Method: int vtkLookupTable::UsingLogScale()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_UsingLogScale_0")] public static extern 
bool UsingLogScale(IntPtr /*int* */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: vtkIdType vtkLookupTable::GetNumberOfAvailableColors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetNumberOfAvailableColors_0")] public static extern 
bool GetNumberOfAvailableColors(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkLookupTable* */ obj);

//       Method: void vtkLookupTable::GetIndexedColor(vtkIdType idx, double rgba[4])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkLookupTable_GetIndexedColor_0")] public static extern 
bool GetIndexedColor(IntPtr /*vtkLookupTable* */ obj, long idx, double[] /*4*/ rgba);

}
};
