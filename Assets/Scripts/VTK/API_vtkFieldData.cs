
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkFieldData {

//       Method: static vtkFieldData * vtkFieldData::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkFieldData_New_0")] public static extern 
bool New(IntPtr /*vtkFieldData** */ ret);

//       Method: virtual const char * vtkFieldData::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkFieldData* */ obj);

//       Method: virtual void vtkFieldData::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkFieldData* */ obj);

//       Method: int vtkFieldData::Allocate(vtkIdType sz)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_Allocate_0")] public static extern 
bool Allocate(IntPtr /*int* */ ret, IntPtr /*vtkFieldData* */ obj, long sz);

//       Method: void vtkFieldData::CopyStructure(vtkFieldData* ARG_0)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_CopyStructure_0")] public static extern 
bool CopyStructure(IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkFieldData* */ ARG_0);

//       Method: void vtkFieldData::AllocateArrays(int num)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_AllocateArrays_0")] public static extern 
bool AllocateArrays(IntPtr /*vtkFieldData* */ obj, int num);

//       Method: int vtkFieldData::GetNumberOfArrays()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetNumberOfArrays_0")] public static extern 
bool GetNumberOfArrays(IntPtr /*int* */ ret, IntPtr /*vtkFieldData* */ obj);

//       Method: int vtkFieldData::AddArray(vtkAbstractArray* array)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_AddArray_0")] public static extern 
bool AddArray(IntPtr /*int* */ ret, IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkAbstractArray* */ array);

//       Method: virtual void vtkFieldData::RemoveArray(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_RemoveArray_0")] public static extern 
bool RemoveArray(IntPtr /*vtkFieldData* */ obj, string/*const char* */ name);

//       Method: virtual void vtkFieldData::RemoveArray(int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_RemoveArray_1")] public static extern 
bool RemoveArray(IntPtr /*vtkFieldData* */ obj, int index);

//       Method: vtkDataArray * vtkFieldData::GetArray(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetArray_0")] public static extern 
bool GetArray(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkFieldData* */ obj, int i);

//       Method: vtkDataArray * vtkFieldData::GetArray(const char* arrayName)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetArray_2")] public static extern 
bool GetArray(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkFieldData* */ obj, string/*const char* */ arrayName);

//       Method: vtkAbstractArray * vtkFieldData::GetAbstractArray(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetAbstractArray_0")] public static extern 
bool GetAbstractArray(IntPtr /*vtkAbstractArray** */ ret, IntPtr /*vtkFieldData* */ obj, int i);

//       Method: vtkAbstractArray * vtkFieldData::GetAbstractArray(const char* arrayName)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetAbstractArray_2")] public static extern 
bool GetAbstractArray(IntPtr /*vtkAbstractArray** */ ret, IntPtr /*vtkFieldData* */ obj, string/*const char* */ arrayName);

//       Method: int vtkFieldData::HasArray(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_HasArray_0")] public static extern 
bool HasArray(IntPtr /*int* */ ret, IntPtr /*vtkFieldData* */ obj, string/*const char* */ name);

//       Method: virtual void vtkFieldData::PassData(vtkFieldData* fd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_PassData_0")] public static extern 
bool PassData(IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkFieldData* */ fd);

//       Method: void vtkFieldData::CopyFieldOn(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_CopyFieldOn_0")] public static extern 
bool CopyFieldOn(IntPtr /*vtkFieldData* */ obj, string/*const char* */ name);

//       Method: void vtkFieldData::CopyFieldOff(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_CopyFieldOff_0")] public static extern 
bool CopyFieldOff(IntPtr /*vtkFieldData* */ obj, string/*const char* */ name);

//       Method: virtual void vtkFieldData::CopyAllOn(int unused)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_CopyAllOn_0")] public static extern 
bool CopyAllOn(IntPtr /*vtkFieldData* */ obj, int unused);

//       Method: virtual void vtkFieldData::CopyAllOff(int unused)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_CopyAllOff_0")] public static extern 
bool CopyAllOff(IntPtr /*vtkFieldData* */ obj, int unused);

//       Method: virtual void vtkFieldData::DeepCopy(vtkFieldData* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkFieldData* */ da);

//       Method: virtual void vtkFieldData::ShallowCopy(vtkFieldData* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkFieldData* */ da);

//       Method: void vtkFieldData::Squeeze()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_Squeeze_0")] public static extern 
bool Squeeze(IntPtr /*vtkFieldData* */ obj);

//       Method: void vtkFieldData::Reset()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_Reset_0")] public static extern 
bool Reset(IntPtr /*vtkFieldData* */ obj);

//       Method: vtkMTimeType vtkFieldData::GetMTime()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetMTime_0")] public static extern 
bool GetMTime(IntPtr /*vtkMTimeType* */ ret, IntPtr /*vtkFieldData* */ obj);

//       Method: void vtkFieldData::GetField(vtkIdList* ptId, vtkFieldData* f)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetField_0")] public static extern 
bool GetField(IntPtr /*vtkFieldData* */ obj, IntPtr/*vtkIdList* */ ptId, IntPtr/*vtkFieldData* */ f);

//       Method: int vtkFieldData::GetNumberOfComponents()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetNumberOfComponents_0")] public static extern 
bool GetNumberOfComponents(IntPtr /*int* */ ret, IntPtr /*vtkFieldData* */ obj);

//       Method: vtkIdType vtkFieldData::GetNumberOfTuples()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_GetNumberOfTuples_0")] public static extern 
bool GetNumberOfTuples(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkFieldData* */ obj);

//       Method: void vtkFieldData::SetNumberOfTuples(const vtkIdType number)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_SetNumberOfTuples_0")] public static extern 
bool SetNumberOfTuples(IntPtr /*vtkFieldData* */ obj, long number);

//       Method: void vtkFieldData::SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_SetTuple_0")] public static extern 
bool SetTuple(IntPtr /*vtkFieldData* */ obj, long i, long j, IntPtr/*vtkFieldData* */ source);

//       Method: void vtkFieldData::InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_InsertTuple_0")] public static extern 
bool InsertTuple(IntPtr /*vtkFieldData* */ obj, long i, long j, IntPtr/*vtkFieldData* */ source);

//       Method: vtkIdType vtkFieldData::InsertNextTuple(const vtkIdType j, vtkFieldData* source)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkFieldData_InsertNextTuple_0")] public static extern 
bool InsertNextTuple(IntPtr /*vtkIdType* */ ret, IntPtr /*vtkFieldData* */ obj, long j, IntPtr/*vtkFieldData* */ source);

}
};
