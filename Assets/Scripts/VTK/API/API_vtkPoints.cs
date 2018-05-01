
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkPoints {

// static vtkPoints* New(int dataType)
// static vtkPoints *New(int dataType)
[DllImport("vtkplugin", EntryPoint="vtkPoints_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value, int /*(int)*/ dataType);

// static vtkPoints* New()
// static vtkPoints *New()
[DllImport("vtkplugin", EntryPoint="vtkPoints_New_1")] public static extern 
bool New_1(IntPtr /*(IntPtr**)*/ return_value);

// virtual int Allocate(vtkIdType sz, vtkIdType ext = 1000)
// virtual int Allocate(vtkIdType sz, vtkIdType ext = 1000)
[DllImport("vtkplugin", EntryPoint="vtkPoints_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkPoints_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkPoints*)*/ callingObject);

// virtual void SetData(vtkDataArray * ARG_0)
// virtual void SetData(vtkDataArray *)
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetData_0")] public static extern 
bool SetData_0(IntPtr /*(vtkPoints*)*/ callingObject, IntPtr /*(vtkDataArray*)*/ ARG_0);

// vtkDataArray* GetData()
// vtkDataArray *GetData()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetData_0")] public static extern 
bool GetData_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// virtual int GetDataType()
// virtual int GetDataType()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetDataType_0")] public static extern 
bool GetDataType_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// virtual void SetDataType(int dataType)
// virtual void SetDataType(int dataType)
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataType_0")] public static extern 
bool SetDataType_0(IntPtr /*(vtkPoints*)*/ callingObject, int /*(int)*/ dataType);

// void SetDataTypeToBit()
// void SetDataTypeToBit()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToBit_0")] public static extern 
bool SetDataTypeToBit_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToChar()
// void SetDataTypeToChar()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToChar_0")] public static extern 
bool SetDataTypeToChar_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToUnsignedChar()
// void SetDataTypeToUnsignedChar()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToUnsignedChar_0")] public static extern 
bool SetDataTypeToUnsignedChar_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToShort()
// void SetDataTypeToShort()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToShort_0")] public static extern 
bool SetDataTypeToShort_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToUnsignedShort()
// void SetDataTypeToUnsignedShort()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToUnsignedShort_0")] public static extern 
bool SetDataTypeToUnsignedShort_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToInt()
// void SetDataTypeToInt()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToInt_0")] public static extern 
bool SetDataTypeToInt_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToUnsignedInt()
// void SetDataTypeToUnsignedInt()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToUnsignedInt_0")] public static extern 
bool SetDataTypeToUnsignedInt_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToLong()
// void SetDataTypeToLong()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToLong_0")] public static extern 
bool SetDataTypeToLong_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToUnsignedLong()
// void SetDataTypeToUnsignedLong()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToUnsignedLong_0")] public static extern 
bool SetDataTypeToUnsignedLong_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToFloat()
// void SetDataTypeToFloat()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToFloat_0")] public static extern 
bool SetDataTypeToFloat_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void SetDataTypeToDouble()
// void SetDataTypeToDouble()
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetDataTypeToDouble_0")] public static extern 
bool SetDataTypeToDouble_0(IntPtr /*(vtkPoints*)*/ callingObject);

// void* GetVoidPointer(const int id)
// void *GetVoidPointer(const int id)
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetVoidPointer_0")] public static extern 
bool GetVoidPointer_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, int /*(int)*/ id);

// virtual void Squeeze()
// virtual void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkPoints_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkPoints*)*/ callingObject);

// virtual void Reset()
// virtual void Reset()
[DllImport("vtkplugin", EntryPoint="vtkPoints_Reset_0")] public static extern 
bool Reset_0(IntPtr /*(vtkPoints*)*/ callingObject);

// virtual void DeepCopy(vtkPoints * ad)
// virtual void DeepCopy(vtkPoints *ad)
[DllImport("vtkplugin", EntryPoint="vtkPoints_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkPoints*)*/ callingObject, IntPtr /*(vtkPoints*)*/ ad);

// virtual void ShallowCopy(vtkPoints * ad)
// virtual void ShallowCopy(vtkPoints *ad)
[DllImport("vtkplugin", EntryPoint="vtkPoints_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkPoints*)*/ callingObject, IntPtr /*(vtkPoints*)*/ ad);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(IntPtr /*(unsigned IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// double* GetPoint(vtkIdType id)
// double *GetPoint(vtkIdType id)
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetPoint_0")] public static extern 
bool GetPoint_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id);

// void GetPoint(vtkIdType id, double x[3])
// void GetPoint(vtkIdType id, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[3])*/ []x);

// void SetPoint(vtkIdType id, const float x[3])
// void SetPoint(vtkIdType id, const float x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetPoint_0")] public static extern 
bool SetPoint_0(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, float /*(float[3])*/ []x);

// void SetPoint(vtkIdType id, const double x[3])
// void SetPoint(vtkIdType id, const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetPoint_1")] public static extern 
bool SetPoint_1(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[3])*/ []x);

// void SetPoint(vtkIdType id, double x, double y, double z)
// void SetPoint(vtkIdType id, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetPoint_2")] public static extern 
bool SetPoint_2(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void InsertPoint(vtkIdType id, const float x[3])
// void InsertPoint(vtkIdType id, const float x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertPoint_0")] public static extern 
bool InsertPoint_0(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, float /*(float[3])*/ []x);

// void InsertPoint(vtkIdType id, const double x[3])
// void InsertPoint(vtkIdType id, const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertPoint_1")] public static extern 
bool InsertPoint_1(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double[3])*/ []x);

// void InsertPoint(vtkIdType id, double x, double y, double z)
// void InsertPoint(vtkIdType id, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertPoint_2")] public static extern 
bool InsertPoint_2(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void InsertPoints(vtkIdList * dstIds, vtkIdList * srcIds, vtkPoints * source)
// void InsertPoints(vtkIdList *dstIds, vtkIdList *srcIds, vtkPoints *source)
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertPoints_0")] public static extern 
bool InsertPoints_0(IntPtr /*(vtkPoints*)*/ callingObject, IntPtr /*(vtkIdList*)*/ dstIds, IntPtr /*(vtkIdList*)*/ srcIds, IntPtr /*(vtkPoints*)*/ source);

// void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints * source)
// void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints* source)
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertPoints_1")] public static extern 
bool InsertPoints_1(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, IntPtr /*(vtkPoints*)*/ source);

// vtkIdType InsertNextPoint(const float x[3])
// vtkIdType InsertNextPoint(const float x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertNextPoint_0")] public static extern 
bool InsertNextPoint_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, float /*(float[3])*/ []x);

// vtkIdType InsertNextPoint(const double x[3])
// vtkIdType InsertNextPoint(const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertNextPoint_1")] public static extern 
bool InsertNextPoint_1(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, double /*(double[3])*/ []x);

// vtkIdType InsertNextPoint(double x, double y, double z)
// vtkIdType InsertNextPoint(double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkPoints_InsertNextPoint_2")] public static extern 
bool InsertNextPoint_2(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void SetNumberOfPoints(vtkIdType numPoints)
// void SetNumberOfPoints(vtkIdType numPoints)
[DllImport("vtkplugin", EntryPoint="vtkPoints_SetNumberOfPoints_0")] public static extern 
bool SetNumberOfPoints_0(IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ numPoints);

// int Resize(vtkIdType numPoints)
// int Resize(vtkIdType numPoints)
[DllImport("vtkplugin", EntryPoint="vtkPoints_Resize_0")] public static extern 
bool Resize_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject, long /*(vtkIdType)*/ numPoints);

// void GetPoints(vtkIdList * ptId, vtkPoints * fp)
// void GetPoints(vtkIdList *ptId, vtkPoints *fp)
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetPoints_0")] public static extern 
bool GetPoints_0(IntPtr /*(vtkPoints*)*/ callingObject, IntPtr /*(vtkIdList*)*/ ptId, IntPtr /*(vtkPoints*)*/ fp);

// virtual void ComputeBounds()
// virtual void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkPoints_ComputeBounds_0")] public static extern 
bool ComputeBounds_0(IntPtr /*(vtkPoints*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetBounds_0")] public static extern 
bool GetBounds_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkPoints*)*/ callingObject, double /*(double[6])*/ []bounds);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkPoints_GetMTime_0")] public static extern 
bool GetMTime_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkPoints*)*/ callingObject);

// void Modified()
// void Modified()
[DllImport("vtkplugin", EntryPoint="vtkPoints_Modified_0")] public static extern 
bool Modified_0(IntPtr /*(vtkPoints*)*/ callingObject);

}
};
