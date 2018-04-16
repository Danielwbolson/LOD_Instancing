
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPoints {

//       Method: static vtkPoints * vtkPoints::New(int dataType)
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPoints_New_0")] public static extern 
bool New(IntPtr /*vtkPoints** */ ret, int dataType);

//       Method: static vtkPoints * vtkPoints::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkPoints_New_1")] public static extern 
bool New(IntPtr /*vtkPoints** */ ret);

//       Method: virtual const char * vtkPoints::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: virtual int vtkPoints::Allocate(vtkIdType sz, vtkIdType ext)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkPoints* */ obj, long sz, long ext);

//       Method: virtual void vtkPoints::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkPoints* */ obj);

//       Method: virtual void vtkPoints::SetData(vtkDataArray* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetData_0")] public static extern 
bool SetData(IntPtr /*vtkPoints* */ obj, IntPtr/*vtkDataArray* */ ARG_0);

//       Method: vtkDataArray * vtkPoints::GetData()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetData_0")] public static extern 
bool GetData(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: virtual int vtkPoints::GetDataType()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetDataType_0")] public static extern 
bool GetDataType(IntPtr /*int* */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: virtual void vtkPoints::SetDataType(int dataType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataType_0")] public static extern 
bool SetDataType(IntPtr /*vtkPoints* */ obj, int dataType);

//       Method: void vtkPoints::SetDataTypeToBit()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToBit_0")] public static extern 
bool SetDataTypeToBit(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToChar()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToChar_0")] public static extern 
bool SetDataTypeToChar(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToUnsignedChar()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToUnsignedChar_0")] public static extern 
bool SetDataTypeToUnsignedChar(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToShort()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToShort_0")] public static extern 
bool SetDataTypeToShort(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToUnsignedShort()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToUnsignedShort_0")] public static extern 
bool SetDataTypeToUnsignedShort(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToInt()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToInt_0")] public static extern 
bool SetDataTypeToInt(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToUnsignedInt()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToUnsignedInt_0")] public static extern 
bool SetDataTypeToUnsignedInt(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToLong()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToLong_0")] public static extern 
bool SetDataTypeToLong(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToUnsignedLong()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToUnsignedLong_0")] public static extern 
bool SetDataTypeToUnsignedLong(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToFloat()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToFloat_0")] public static extern 
bool SetDataTypeToFloat(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::SetDataTypeToDouble()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetDataTypeToDouble_0")] public static extern 
bool SetDataTypeToDouble(IntPtr /*vtkPoints* */ obj);

//       Method: void * vtkPoints::GetVoidPointer(const int id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetVoidPointer_0")] public static extern 
bool GetVoidPointer(IntPtr /*vtkPoints* */ obj, int id);

//       Method: virtual void vtkPoints::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkPoints* */ obj);

//       Method: virtual void vtkPoints::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkPoints* */ obj);

//       Method: virtual void vtkPoints::DeepCopy(vtkPoints* ad)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkPoints* */ obj, IntPtr/*vtkPoints* */ ad);

//       Method: virtual void vtkPoints::ShallowCopy(vtkPoints* ad)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkPoints* */ obj, IntPtr/*vtkPoints* */ ad);

//       Method: vtkIdType vtkPoints::GetNumberOfPoints()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: double * vtkPoints::GetPoint(vtkIdType id)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetPoint_0")] public static extern 
bool GetPoint(IntPtr /*double** */ ret, IntPtr /*vtkPoints* */ obj, long id);

//       Method: void vtkPoints::GetPoint(vtkIdType id, double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetPoint_1")] public static extern 
bool GetPoint(IntPtr /*vtkPoints* */ obj, long id, double[] /*3*/ x);

//       Method: void vtkPoints::SetPoint(vtkIdType id, const float x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetPoint_0")] public static extern 
bool SetPoint(IntPtr /*vtkPoints* */ obj, long id, float[] /*3*/ x);

//       Method: void vtkPoints::SetPoint(vtkIdType id, const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetPoint_1")] public static extern 
bool SetPoint(IntPtr /*vtkPoints* */ obj, long id, double[] /*3*/ x);

//       Method: void vtkPoints::SetPoint(vtkIdType id, double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetPoint_2")] public static extern 
bool SetPoint(IntPtr /*vtkPoints* */ obj, long id, double x, double y, double z);

//       Method: void vtkPoints::InsertPoint(vtkIdType id, const float x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertPoint_0")] public static extern 
bool InsertPoint(IntPtr /*vtkPoints* */ obj, long id, float[] /*3*/ x);

//  Constructor: vtkPoints::VTK_EXPECTS()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_VTK_EXPECTS_0")] public static extern 
bool VTK_EXPECTS(IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::InsertPoint(vtkIdType id, const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertPoint_1")] public static extern 
bool InsertPoint(IntPtr /*vtkPoints* */ obj, long id, double[] /*3*/ x);

////  Constructor: vtkPoints::VTK_EXPECTS()
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkPoints_VTK_EXPECTS_1")] public static extern 
//bool VTK_EXPECTS(IntPtr /*vtkPoints* */ obj);
//
//       Method: void vtkPoints::InsertPoint(vtkIdType id, double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertPoint_2")] public static extern 
bool InsertPoint(IntPtr /*vtkPoints* */ obj, long id, double x, double y, double z);

////  Constructor: vtkPoints::VTK_EXPECTS()
//// 
//[DllImport("vtkplugin", EntryPoint="API_vtkPoints_VTK_EXPECTS_2")] public static extern 
//bool VTK_EXPECTS(IntPtr /*vtkPoints* */ obj);
//
//       Method: void vtkPoints::InsertPoints(vtkIdList* dstIds, vtkIdList* srcIds, vtkPoints* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertPoints_0")] public static extern 
bool InsertPoints(IntPtr /*vtkPoints* */ obj, IntPtr/*vtkIdList* */ dstIds, IntPtr/*vtkIdList* */ srcIds, IntPtr/*vtkPoints* */ source);

//       Method: void vtkPoints::InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertPoints_1")] public static extern 
bool InsertPoints(IntPtr /*vtkPoints* */ obj, long dstStart, long n, long srcStart, IntPtr/*vtkPoints* */ source);

//       Method: vtkIdType vtkPoints::InsertNextPoint(const float x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertNextPoint_0")] public static extern 
bool InsertNextPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPoints* */ obj, float[] /*3*/ x);

//       Method: vtkIdType vtkPoints::InsertNextPoint(const double x[3])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertNextPoint_1")] public static extern 
bool InsertNextPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPoints* */ obj, double[] /*3*/ x);

//       Method: vtkIdType vtkPoints::InsertNextPoint(double x, double y, double z)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_InsertNextPoint_2")] public static extern 
bool InsertNextPoint(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkPoints* */ obj, double x, double y, double z);

//       Method: void vtkPoints::SetNumberOfPoints(vtkIdType numPoints)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_SetNumberOfPoints_0")] public static extern 
bool SetNumberOfPoints(IntPtr /*vtkPoints* */ obj, long numPoints);

//       Method: int vtkPoints::Resize(vtkIdType numPoints)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Resize_0")] public static extern 
bool Resize(IntPtr /*int* */ ret, IntPtr /*vtkPoints* */ obj, long numPoints);

//       Method: void vtkPoints::GetPoints(vtkIdList* ptId, vtkPoints* fp)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetPoints_0")] public static extern 
bool GetPoints(IntPtr /*vtkPoints* */ obj, IntPtr/*vtkIdList* */ ptId, IntPtr/*vtkPoints* */ fp);

//       Method: virtual void vtkPoints::ComputeBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_ComputeBounds_0")] public static extern 
bool ComputeBounds(IntPtr /*vtkPoints* */ obj);

//       Method: double * vtkPoints::GetBounds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetBounds_0")] public static extern 
bool GetBounds(IntPtr /*double** */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::GetBounds(double bounds[6])
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetBounds_1")] public static extern 
bool GetBounds(IntPtr /*vtkPoints* */ obj, double[] /*6*/ bounds);

//       Method: vtkMTimeType vtkPoints::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkPoints* */ obj);

//       Method: void vtkPoints::Modified()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkPoints_Modified_0")] public static extern 
bool Modified(IntPtr /*vtkPoints* */ obj);

}
};
