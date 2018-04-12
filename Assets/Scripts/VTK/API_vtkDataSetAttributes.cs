
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK {
class API_vtkDataSetAttributes {

//       Method: static vtkDataSetAttributes * vtkDataSetAttributes::New()
// 
[DllImport("vtkplugin", EntryPoint="STATIC_API_vtkDataSetAttributes_New_0")] public static extern 
bool New(IntPtr /*vtkDataSetAttributes** */ ret);

//       Method: virtual const char * vtkDataSetAttributes::GetClassName()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetClassName_0")] public static extern 
bool GetClassName(IntPtr /*const char** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::Initialize()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_Initialize_0")] public static extern 
bool Initialize(IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: virtual void vtkDataSetAttributes::Update()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_Update_0")] public static extern 
bool Update(IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::DeepCopy(vtkFieldData* pd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_DeepCopy_0")] public static extern 
bool DeepCopy(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkFieldData* */ pd);

//       Method: void vtkDataSetAttributes::ShallowCopy(vtkFieldData* pd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_ShallowCopy_0")] public static extern 
bool ShallowCopy(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkFieldData* */ pd);

//       Method: int vtkDataSetAttributes::SetScalars(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetScalars_0")] public static extern 
bool SetScalars(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveScalars(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveScalars_0")] public static extern 
bool SetActiveScalars(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetScalars()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetScalars_0")] public static extern 
bool GetScalars(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetVectors(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetVectors_0")] public static extern 
bool SetVectors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveVectors(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveVectors_0")] public static extern 
bool SetActiveVectors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetVectors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetVectors_0")] public static extern 
bool GetVectors(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetNormals(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetNormals_0")] public static extern 
bool SetNormals(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveNormals(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveNormals_0")] public static extern 
bool SetActiveNormals(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetNormals()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetNormals_0")] public static extern 
bool GetNormals(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetTCoords(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetTCoords_0")] public static extern 
bool SetTCoords(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveTCoords(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveTCoords_0")] public static extern 
bool SetActiveTCoords(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetTCoords()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetTCoords_0")] public static extern 
bool GetTCoords(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetTensors(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetTensors_0")] public static extern 
bool SetTensors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveTensors(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveTensors_0")] public static extern 
bool SetActiveTensors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetTensors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetTensors_0")] public static extern 
bool GetTensors(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetGlobalIds(vtkDataArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetGlobalIds_0")] public static extern 
bool SetGlobalIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataArray* */ da);

//       Method: int vtkDataSetAttributes::SetActiveGlobalIds(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveGlobalIds_0")] public static extern 
bool SetActiveGlobalIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetGlobalIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetGlobalIds_0")] public static extern 
bool GetGlobalIds(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: int vtkDataSetAttributes::SetPedigreeIds(vtkAbstractArray* da)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetPedigreeIds_0")] public static extern 
bool SetPedigreeIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkAbstractArray* */ da);

//       Method: int vtkDataSetAttributes::SetActivePedigreeIds(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActivePedigreeIds_0")] public static extern 
bool SetActivePedigreeIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkAbstractArray * vtkDataSetAttributes::GetPedigreeIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetPedigreeIds_0")] public static extern 
bool GetPedigreeIds(IntPtr /*vtkAbstractArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: vtkDataArray * vtkDataSetAttributes::GetScalars(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetScalars_1")] public static extern 
bool GetScalars(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetVectors(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetVectors_1")] public static extern 
bool GetVectors(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetNormals(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetNormals_1")] public static extern 
bool GetNormals(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetTCoords(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetTCoords_1")] public static extern 
bool GetTCoords(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetTensors(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetTensors_1")] public static extern 
bool GetTensors(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkDataArray * vtkDataSetAttributes::GetGlobalIds(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetGlobalIds_1")] public static extern 
bool GetGlobalIds(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: vtkAbstractArray * vtkDataSetAttributes::GetPedigreeIds(const char* name)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetPedigreeIds_1")] public static extern 
bool GetPedigreeIds(IntPtr /*vtkAbstractArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name);

//       Method: int vtkDataSetAttributes::SetActiveAttribute(const char* name, int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveAttribute_0")] public static extern 
bool SetActiveAttribute(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, string/*const char* */ name, int attributeType);

//       Method: int vtkDataSetAttributes::SetActiveAttribute(int index, int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetActiveAttribute_1")] public static extern 
bool SetActiveAttribute(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, int index, int attributeType);

//       Method: void vtkDataSetAttributes::GetAttributeIndices(int* indexArray)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetAttributeIndices_0")] public static extern 
bool GetAttributeIndices(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*int* */ indexArray);

//       Method: int vtkDataSetAttributes::IsArrayAnAttribute(int idx)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_IsArrayAnAttribute_0")] public static extern 
bool IsArrayAnAttribute(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, int idx);

//       Method: int vtkDataSetAttributes::SetAttribute(vtkAbstractArray* aa, int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetAttribute_0")] public static extern 
bool SetAttribute(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkAbstractArray* */ aa, int attributeType);

//       Method: vtkDataArray * vtkDataSetAttributes::GetAttribute(int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetAttribute_0")] public static extern 
bool GetAttribute(IntPtr /*vtkDataArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, int attributeType);

//       Method: vtkAbstractArray * vtkDataSetAttributes::GetAbstractAttribute(int attributeType)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetAbstractAttribute_0")] public static extern 
bool GetAbstractAttribute(IntPtr /*vtkAbstractArray** */ ret, IntPtr /*vtkDataSetAttributes* */ obj, int attributeType);

//       Method: void vtkDataSetAttributes::RemoveArray(int index)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_RemoveArray_0")] public static extern 
bool RemoveArray(IntPtr /*vtkDataSetAttributes* */ obj, int index);

//       Method: void vtkDataSetAttributes::SetCopyScalars(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyScalars_0")] public static extern 
bool SetCopyScalars(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyScalars()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyScalars_0")] public static extern 
bool GetCopyScalars(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyVectors(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyVectors_0")] public static extern 
bool SetCopyVectors(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyVectors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyVectors_0")] public static extern 
bool GetCopyVectors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyNormals(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyNormals_0")] public static extern 
bool SetCopyNormals(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyNormals()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyNormals_0")] public static extern 
bool GetCopyNormals(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyTCoords(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyTCoords_0")] public static extern 
bool SetCopyTCoords(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyTCoords()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyTCoords_0")] public static extern 
bool GetCopyTCoords(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyTensors(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyTensors_0")] public static extern 
bool SetCopyTensors(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyTensors()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyTensors_0")] public static extern 
bool GetCopyTensors(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyGlobalIds(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyGlobalIds_0")] public static extern 
bool SetCopyGlobalIds(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyGlobalIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyGlobalIds_0")] public static extern 
bool GetCopyGlobalIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::SetCopyPedigreeIds(int i)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetCopyPedigreeIds_0")] public static extern 
bool SetCopyPedigreeIds(IntPtr /*vtkDataSetAttributes* */ obj, int i);

//       Method: int vtkDataSetAttributes::GetCopyPedigreeIds()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_GetCopyPedigreeIds_0")] public static extern 
bool GetCopyPedigreeIds(IntPtr /*int* */ ret, IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::CopyAllOn()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyAllOn_0")] public static extern 
bool CopyAllOn(IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::CopyAllOff()
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyAllOff_0")] public static extern 
bool CopyAllOff(IntPtr /*vtkDataSetAttributes* */ obj);

//       Method: void vtkDataSetAttributes::PassData(vtkFieldData* fd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_PassData_0")] public static extern 
bool PassData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkFieldData* */ fd);

//       Method: void vtkDataSetAttributes::CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyAllocate_0")] public static extern 
bool CopyAllocate(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze);

//       Method: void vtkDataSetAttributes::CopyAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyAllocate_1")] public static extern 
bool CopyAllocate(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze, long ext, int shallowCopyArrays);

//       Method: void vtkDataSetAttributes::SetupForCopy(vtkDataSetAttributes* pd)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_SetupForCopy_0")] public static extern 
bool SetupForCopy(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ pd);

//       Method: void vtkDataSetAttributes::CopyStructuredData(vtkDataSetAttributes* inDsa, const int* inExt, const int* outExt)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyStructuredData_0")] public static extern 
bool CopyStructuredData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ inDsa, IntPtr/*const int* */ inExt, IntPtr/*const int* */ outExt);

//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdType fromId, vtkIdType toId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyData_0")] public static extern 
bool CopyData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long fromId, long toId);

//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdList* fromIds, vtkIdList* toIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyData_1")] public static extern 
bool CopyData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, IntPtr/*vtkIdList* */ fromIds, IntPtr/*vtkIdList* */ toIds);

//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* fromPd, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyData_2")] public static extern 
bool CopyData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long dstStart, long n, long srcStart);

//       Method: void vtkDataSetAttributes::CopyTuple(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdType fromId, vtkIdType toId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyTuple_0")] public static extern 
bool CopyTuple(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, long fromId, long toId);

//       Method: void vtkDataSetAttributes::CopyTuples(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdList* fromIds, vtkIdList* toIds)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyTuples_0")] public static extern 
bool CopyTuples(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, IntPtr/*vtkIdList* */ fromIds, IntPtr/*vtkIdList* */ toIds);

//       Method: void vtkDataSetAttributes::CopyTuples(vtkAbstractArray* fromData, vtkAbstractArray* toData, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyTuples_1")] public static extern 
bool CopyTuples(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkAbstractArray* */ fromData, IntPtr/*vtkAbstractArray* */ toData, long dstStart, long n, long srcStart);

//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolateAllocate_0")] public static extern 
bool InterpolateAllocate(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze);

//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkDataSetAttributes* pd, vtkIdType sze, vtkIdType ext, int shallowCopyArrays)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolateAllocate_1")] public static extern 
bool InterpolateAllocate(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ pd, long sze, long ext, int shallowCopyArrays);

//       Method: void vtkDataSetAttributes::InterpolatePoint(vtkDataSetAttributes* fromPd, vtkIdType toId, vtkIdList* ids, double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolatePoint_0")] public static extern 
bool InterpolatePoint(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long toId, IntPtr/*vtkIdList* */ ids, IntPtr/*double* */ weights);

//       Method: void vtkDataSetAttributes::InterpolateEdge(vtkDataSetAttributes* fromPd, vtkIdType toId, vtkIdType p1, vtkIdType p2, double t)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolateEdge_0")] public static extern 
bool InterpolateEdge(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, long toId, long p1, long p2, double t);

//       Method: void vtkDataSetAttributes::InterpolateTime(vtkDataSetAttributes* from1, vtkDataSetAttributes* from2, vtkIdType id, double t)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolateTime_0")] public static extern 
bool InterpolateTime(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ from1, IntPtr/*vtkDataSetAttributes* */ from2, long id, double t);

//       Method: void vtkDataSetAttributes::CopyAllocate(vtkIdType sze)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyAllocate_2")] public static extern 
bool CopyAllocate(IntPtr /*vtkDataSetAttributes* */ obj, long sze);

//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* dsa, int idx, vtkIdType fromId, vtkIdType toId)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyData_3")] public static extern 
bool CopyData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ dsa, int idx, long fromId, long toId);

//       Method: void vtkDataSetAttributes::CopyData(vtkDataSetAttributes* dsa, int idx, vtkIdType dstStart, vtkIdType n, vtkIdType srcStart)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_CopyData_4")] public static extern 
bool CopyData(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ dsa, int idx, long dstStart, long n, long srcStart);

//       Method: void vtkDataSetAttributes::InterpolateAllocate(vtkIdType sze)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolateAllocate_2")] public static extern 
bool InterpolateAllocate(IntPtr /*vtkDataSetAttributes* */ obj, long sze);

//       Method: void vtkDataSetAttributes::InterpolatePoint(vtkDataSetAttributes* fromPd, int idx, vtkIdType toId, vtkIdList* ids, double* weights)
// 
[DllImport("vtkplugin", EntryPoint="API_vtkDataSetAttributes_InterpolatePoint_1")] public static extern 
bool InterpolatePoint(IntPtr /*vtkDataSetAttributes* */ obj, IntPtr/*vtkDataSetAttributes* */ fromPd, int idx, long toId, IntPtr/*vtkIdList* */ ids, IntPtr/*double* */ weights);

}
};
